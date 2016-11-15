using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neural_Style_Transfer;
using Neural_Style_Transfer.LogClasses;
using Neural_Style_Transfer.Properties;
using Newtonsoft.Json;

namespace Neural_Dream
{
    public partial class MainForm : Form
    {
        private string desktopPath = "";

        // Neural Style region
        private double contentWeight, tvWeight, styleScale, minThreshold;
        private int imageSize, noIters, styleCount, maskCount, colorMaskCount;
        private string rescaleAlgo, contentLayer, poolingType, styleWeight, modelType;
        
        // Neural Doodle region
        private double contentWeightDoodle, styleWeightDoodle, tvWeightDoodle, regionWeightDoodle;
        private int imageSizeDoodle, noItersDoodle;

        private string lastArgumentList;

        private static readonly string[] VGG_16_Layer_Names = new string[]
        {
            "conv5_3", "conv5_2", "conv5_1",
            "conv4_3", "conv4_2", "conv4_1",
            "conv3_3", "conv3_2", "conv3_1",
            "conv2_2", "conv2_1", 
            "conv1_2", "conv2_1"
        };

        private static readonly  string[] VGG_19_Layer_Names = new string[]
        {
            "conv5_4", "conv5_3", "conv5_2", "conv5_1",
            "conv4_4", "conv4_3", "conv4_2", "conv4_1",
            "conv3_4", "conv3_3", "conv3_2", "conv3_1",
            "conv2_2", "conv2_1",
            "conv1_2", "conv1_1"
        };

        private const string NETWORK_PATH = "Network.py";
        private const string INETWORK_PATH = "INetwork.py";
        private const string NEURAL_DOODLE_PATH = "neural_doodle.py";
        private const string INEURAL_DOODLE_PATH = "improved_neural_doodle.py";
        private const string COLOR_TRANSFER_PATH = "color_transfer.py";
        private const string MASKED_TRANSFER_PATH = "mask_transfer.py";

        public MainForm()
        {
            InitializeComponent();
            desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            RescaleAlgoBox.Text = "bicubic";
            ContentLayerBox.Items.AddRange(VGG_16_Layer_Names);
            ContentLayerBox.Text = "conv5_2";
            InitialLayerComboBox.Text = "content";
            PoolingTypeBox.Text = "max";
            ModelTypeBox.Text = "vgg16";
            ContentLossTypeBox.Text = "0";
        }


        private void SetUpOpenFileDialog()
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = desktopPath;
            openFileDialog1.Filter = "Image (*.jpeg, *.jpg, *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
        }

        private void SrcBtn_Click(object sender, EventArgs e)
        {
            SetUpOpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SrcPathLabel.Text = openFileDialog1.FileName;
                SrcBtn.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                SrcBtn.Text = "";
            }
        }
 

        private void StyleBtn_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            SetUpOpenFileDialog();
            styleCount = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StringBuilder pathBuilder = new StringBuilder();

                foreach (string fn in openFileDialog1.FileNames)
                {
                    pathBuilder.Append("\"").Append(fn).Append("\" ");
                    styleCount++;
                }
                StylePathLabel.Text = pathBuilder.ToString();
                StyleBtn.BackgroundImage = Image.FromFile(openFileDialog1.FileNames[0]);
                StyleBtn.Text = "";
            }
        }

        private void DstBtn_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = desktopPath;
            saveFileDialog1.Filter = "";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DstPathLabel.Text = saveFileDialog1.FileName;
            }
        }


        private void MaskImagesBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            SetUpOpenFileDialog();
            maskCount = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StringBuilder pathBuilder = new StringBuilder("--style_masks ");

                foreach (string fn in openFileDialog1.FileNames)
                {
                    pathBuilder.Append("\"").Append(fn).Append("\" ");
                    maskCount++;
                }
                MaskPathLabel.Text = pathBuilder.ToString();
                MaskImagesBtn.BackgroundImage = Image.FromFile(openFileDialog1.FileNames[0]);
                MaskImagesBtn.Text = "";
            }
        }

        private void ColorMaskImageBtn_Click(object sender, EventArgs e)
        {
            SetUpOpenFileDialog();
            colorMaskCount = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ColorMaskImageLabel.Text = openFileDialog1.FileName;
                ColorMaskImageBtn.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                ColorMaskImageBtn.Text = "";

                colorMaskCount = 1;
            }
        }


        private void SourceImageDoodle_Click(object sender, EventArgs e)
        {
            SetUpOpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SrcImageDoodleLabel.Text = openFileDialog1.FileName;
                SourceImageDoodle.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                SourceImageDoodle.Text = "";
            }
        }
        
        private void StyleImageDoodle_Click(object sender, EventArgs e)
        {
            SetUpOpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StyleImageDoodleLabel.Text = openFileDialog1.FileName;
                StyleImageDoodle.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                StyleImageDoodle.Text = "";
            }
        }

        private void StyleMaskDoodle_Click(object sender, EventArgs e)
        {
            SetUpOpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StyleMaskImageDoodleLabel.Text = openFileDialog1.FileName;
                StyleMaskDoodle.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                StyleMaskDoodle.Text = "";
            }
        }
        
        private void TargetMaskDoodle_Click(object sender, EventArgs e)
        {
            SetUpOpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TargetImageMaskDoodleLabel.Text = openFileDialog1.FileName;
                TargetMaskDoodle.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                TargetMaskDoodle.Text = "";
            }
        }

        private void DestinationPathDoodle_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = desktopPath;
            saveFileDialog1.Filter = "";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DestinationPrefixDoodleLabel.Text = saveFileDialog1.FileName;
            }
        }

        private void ContentColorTransferBtn_Click(object sender, EventArgs e)
        {
            SetUpOpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ContentColorTransferLabel.Text = openFileDialog1.FileName;
                ContentColorTransferBtn.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                ContentColorTransferBtn.Text = "";
            }
        }


        private void GeneratedColorTransferBtn_Click(object sender, EventArgs e)
        {
            SetUpOpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GeneratedColorTransferLabel.Text = openFileDialog1.FileName;
                GeneratedColorTransferBtn.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                GeneratedColorTransferBtn.Text = "";
            }
        }


        private void MaskColorTransferBtn_Click(object sender, EventArgs e)
        {
            SetUpOpenFileDialog();
            colorMaskCount = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MaskedColorTransferLabel.Text = openFileDialog1.FileName;
                MaskColorTransferBtn.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                MaskColorTransferBtn.Text = "";

                colorMaskCount = 1;
            }
        }


        private void ContentImageMaskedBtn_Click(object sender, EventArgs e)
        {
            SetUpOpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ContentMaskedLabel.Text = openFileDialog1.FileName;
                ContentImageMaskedBtn.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                ContentImageMaskedBtn.Text = "";
            }
        }


        private void GeneratedImageMaskedBtn_Click(object sender, EventArgs e)
        {
            SetUpOpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GeneratedMaskedLabel.Text = openFileDialog1.FileName;
                GeneratedImageMaskedBtn.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                GeneratedImageMaskedBtn.Text = "";
            }
        }


        private void MaskedImageBtn_Click(object sender, EventArgs e)
        {
            SetUpOpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MaskedLable.Text = openFileDialog1.FileName;
                MaskedImageBtn.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                MaskedImageBtn.Text = "";
            }
        }

        private bool CheckMasks()
        {
            if (maskCount <= 0) return true;
            if (maskCount != styleCount)
            {
                MessageBox.Show("Number of style masks provided is not the same as the number of image masks",
                    "Illegal number of masks");
                return false;
            }
            return true;
        }

        private bool CheckContentWeignt()
        {
            try
            {
                contentWeight = Convert.ToDouble(ContentWeightText.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Content Weight must be a double type number", "Content Weight not in standard format");
                return false;
            }
        }

        private bool CheckStyleWeignt()
        {
            try
            {
                if (styleCount > 1 && !StyleWeightText.Text.Contains(" "))
                {
                    MessageBox.Show(
                        "Multiple styles chosen. Multiple style weights must be supplied with spaces in between.",
                        "Multiple Styles Selected");
                    return false;
                }

                if (styleCount > 1)
                {
                    int styleWeightsCount = StyleWeightText.Text.TrimEnd().Split(' ').Length;
                    if (styleWeightsCount != styleCount)
                    {
                        MessageBox.Show(string.Format("Number of Styles selected = {0}, \n" +
                                                      "Number of Style Weights provided = {1}, \n" +
                                                      "Please provide correct number of style weights.", styleCount, styleWeightsCount),
                                                      "Invalid number of Style Weights");
                        return false;
                    }

                    styleWeight = StyleWeightText.Text.TrimEnd();
                }
                else
                {
                    styleWeight = StyleWeightText.Text;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Style Weight must be a double type number", "Style Weight not in standard format");
                return false;
            }
        }

        private bool CheckTVWeignt()
        {
            try
            {
                tvWeight = Convert.ToDouble(TotalVariationWeightText.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Total Variation Weight must be a double type number", "TV Weight not in standard format");
                return false;
            }
        }

        private bool CheckStyleScale()
        {
            try
            {
                styleScale = Convert.ToDouble(StyleScaleText.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Style Scale must be a double type number", "Style Scale not in standard format");
                return false;
            }
        }

        private bool CheckImageSize()
        {
            try
            {
                imageSize = Convert.ToInt32(ImageSizeBox.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Image Size must be a double type number", "Image Size not in standard format");
                return false;
            }
        }

        private bool CheckTotalIterations()
        {
            try
            {
                noIters = Convert.ToInt32(NoOfItersText.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Total Iterations must be a integer type number", "Total Iterations not in standard format");
                return false;
            }
        }

        private bool CheckRescaleAlgo()
        {
            rescaleAlgo = RescaleAlgoBox.Text;
            if (string.IsNullOrEmpty(rescaleAlgo) && RescaleCheck.Checked)
            {
                MessageBox.Show("Rescale Algo Must be selected if rescaling is being applied.", "Rescale Algo");
                return false;
            }
            return true;
        }

        private bool CheckContentLayer()
        {
            contentLayer = ContentWeightText.Text;
            if (string.IsNullOrEmpty(contentLayer))
            {
                MessageBox.Show("Content Must be selected from one of the three options", "Content Layer");
                return false;
            }
            return true;
        }


        private bool CheckPoolingLayer()
        {
            poolingType = PoolingTypeBox.Text;
            if (string.IsNullOrEmpty(poolingType))
            {
                MessageBox.Show("Pooling type must be one of two types : ave or max", "Pooling Tyoe");
                return false;
            }
            return true;
        }


        private bool CheckMinThreshold()
        {
            try
            {
                minThreshold = Convert.ToDouble(MinThresholdText.Text);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Minimum Threshold must be a Double value.", "Minimum Threshold Value Error");
                return false;
            }
        }

        private void ModelTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = ModelTypeBox.SelectedItem as string;

            switch (selectedValue)
            {
                case "vgg16":
                    ContentLayerBox.Items.Clear();
                    ContentLayerBox.Items.AddRange(VGG_16_Layer_Names);
                    ContentLayerBox.SelectedIndex = 1;
                    break;
                case "vgg19":
                    ContentLayerBox.Items.Clear();
                    ContentLayerBox.Items.AddRange(VGG_19_Layer_Names);
                    ContentLayerBox.SelectedIndex = 2;
                    break;
            }

        }

        private string GetNetworkPath()
        {
            if (NetworkCheckBox.Checked)
            {
                return INETWORK_PATH;
            }
            else
            {
                return NETWORK_PATH;
            }
        }

        private string GetDoodlePath()
        {
            if (UseImprovedNetworkDoodle.Checked)
            {
                return INEURAL_DOODLE_PATH;
            }
            else
            {
                return NEURAL_DOODLE_PATH;
            }
        }

        private string GetColorTransferPath()
        {
            return COLOR_TRANSFER_PATH;
        }

        private string GetMaskedTransferPath()
        {
            return MASKED_TRANSFER_PATH;
        }

        public void RunScript(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            bool exists = File.Exists(Settings.Default.PythonPath);

            if (Settings.Default.PythonPath.Equals("--") || !exists)
            {
                openFileDialog1.FileName = "";
                openFileDialog1.InitialDirectory = desktopPath;
                openFileDialog1.Filter = "Python Exe (python.exe)|*.exe|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fp = openFileDialog1.FileName;
                    
                    int p = (int) Environment.OSVersion.Platform;
                    
                    string pythonName;
                    // Unix/Linux pyton name. Used if run with mono.
                    // From the mono FAQ: http://www.mono-project.com/docs/faq/technical/
                    if ((p == 4) || (p == 6) || (p == 128))
                    {
                        pythonName = "python";
                    }
                    else
                    {
                        pythonName = "python.exe";
                    }
                    
                    if (fp.Contains(pythonName))
                    {
                        Settings.Default.PythonPath = fp;
                        Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("Python.exe not selected. Stopping.", "python.exe not found");
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            start.FileName = Settings.Default.PythonPath;
            start.Arguments = string.Format("{0} {1}", cmd, args);
            start.UseShellExecute = true;
            start.ErrorDialog = true;

            using (Process process = Process.Start(start))
            {
                process.WaitForExit();
            }
        }

        private bool PerformChecks()
        {
            if (!CheckMasks()) return true;
            if (!CheckContentWeignt()) return true;
            if (!CheckStyleWeignt()) return true;
            if (!CheckTVWeignt()) return true;
            if (!CheckImageSize()) return true;
            if (!CheckStyleScale()) return true;
            if (!CheckTotalIterations()) return true;
            if (!CheckRescaleAlgo()) return true;
            if (!CheckContentLayer()) return true;
            if (!CheckPoolingLayer()) return true;
            if (!CheckMinThreshold()) return true;

            return false;
        }

        private string BuildCommandArgs()
        {
            StringBuilder args = new StringBuilder();
            args.Append("\"" + SrcPathLabel.Text + "\" ");
            args.Append(StylePathLabel.Text);
            args.Append("\"" + DstPathLabel.Text + "\" ");

            if (maskCount > 0)
                args.Append(MaskPathLabel.Text);

            if (colorMaskCount > 0)
                args.Append("--color_mask \"" + ColorMaskImageLabel.Text + "\" ");

            args.Append("--image_size " + imageSize + " ");
            args.Append("--content_weight " + contentWeight + " ");
            args.Append("--style_weight " + styleWeight + " ");
            args.Append("--total_variation_weight " + tvWeight + " ");
            args.Append("--style_scale " + styleScale + " ");
            args.Append("--num_iter " + noIters + " ");
            args.Append("--rescale_image \"" + RescaleCheck.Checked + "\" ");
            args.Append("--rescale_method \"" + RescaleAlgoBox.Text + "\" ");
            args.Append("--maintain_aspect_ratio \"" + MaintainAspectRatioCheckBox.Checked + "\" ");
            args.Append("--content_layer \"" + ContentLayerBox.Text + "\" ");
            args.Append("--init_image \"" + InitialLayerComboBox.Text + "\" ");
            args.Append("--pool_type \"" + PoolingTypeBox.Text + "\" ");
            args.Append("--preserve_color \"" + PreserveColorBox.Checked + "\" ");
            args.Append("--min_improvement " + minThreshold + " ");
            args.Append("--model \"" + ModelTypeBox.Text + "\" ");
            args.Append("--content_loss_type " + ContentLossTypeBox.Text + "");

            return args.ToString();
        }

        private string BuildDoodleCommandArgs()
        {
            StringBuilder args = new StringBuilder();
            if (!string.IsNullOrEmpty(SrcImageDoodleLabel.Text))
                args.Append("--content-image \"" + SrcImageDoodleLabel.Text + "\" ");
            args.Append("--style-image \"" + StyleImageDoodleLabel.Text + "\" ");
            args.Append("--style-mask \"" + StyleMaskImageDoodleLabel.Text + "\" ");
            args.Append("--target-mask \"" + TargetImageMaskDoodleLabel.Text + "\" ");
            args.Append("--target-image-prefix \"" + DestinationPrefixDoodleLabel.Text + "\" ");

            args.Append("--nlabels " + NumColorsText.Text + " ");
            args.Append("--img_size " + ImageSizeBoxDoodle.Text + " ");

            args.Append("--content_weight " + ContentWeightBoxDoodle.Text + " ");
            args.Append("--style_weight " + StyleWeightBoxDoodle.Text + " ");
            args.Append("--tv_weight " + TVWeightBoxDoodle.Text + " ");
            args.Append("--region_style_weight " + RegionWeightDoodleText.Text + " ");

            args.Append("--num_iter " + NumIterDoodle.Text + " ");
            args.Append("--preserve_color \"" + PreserveColorDoodle.Checked + "\" ");

            return args.ToString();
        }

        private string BuildColorTransferArgs()
        {
            StringBuilder args = new StringBuilder();

            args.Append("\"" + ContentColorTransferLabel.Text + "\" ");
            args.Append("\"" + GeneratedColorTransferLabel.Text + "\"");

            if (colorMaskCount > 0)
            {
                args.Append(" --mask \"" + MaskedColorTransferLabel.Text + "\"");
            }

            return args.ToString();
        }

        private string BuildMaskedTransferArgs()
        {
            StringBuilder args = new StringBuilder();

            args.Append("\"" + ContentMaskedLabel.Text + "\" ");
            args.Append("\"" + GeneratedMaskedLabel.Text + "\" ");
            args.Append("\"" + MaskedLable.Text + "\"");

            return args.ToString();
        }

        private void ExecuteButton_Click_1(object sender, EventArgs e)
        {
            if (PerformChecks()) return;

            string command = "Script/" + GetNetworkPath();
            string args = BuildCommandArgs();

            Console.WriteLine(args);
            LogData(args);

            RunScript(command, args);
        }

        private void ExecuteDoodle_Click(object sender, EventArgs e)
        {
            string command = "Script/" + GetDoodlePath();
            string args = BuildDoodleCommandArgs();

            Console.WriteLine(args);
            LogDoodleData(args);

            RunScript(command, args);
        }

        private void ExecuteColorTransferBtn_Click(object sender, EventArgs e)
        {
            string command = "Script/" + GetColorTransferPath();
            string args = BuildColorTransferArgs();

            Console.WriteLine(args);
            LogColorTransferData(args);

            RunScript(command, args);

        }

        private void ExecuteMaskedTransferBtn_Click(object sender, EventArgs e)
        {
            string command = "Script/" + GetMaskedTransferPath();
            string args = BuildMaskedTransferArgs();

            Console.WriteLine(args);
            LogMaskedTransferData(args);

            RunScript(command, args);
        }

        private void CopyArgumentsBtn_Click_1(object sender, EventArgs e)
        {
            if (PerformChecks()) return;

            string args = BuildCommandArgs();

            lastArgumentList = args;

            Clipboard.SetText(lastArgumentList);
        }


        private void CopyArgsDoodle_Click(object sender, EventArgs e)
        {
            string args = BuildDoodleCommandArgs();

            lastArgumentList = args;

            Clipboard.SetText(lastArgumentList);
        }


        private void CopyArgumentsColorTransferBtn_Click(object sender, EventArgs e)
        {
            string args = BuildColorTransferArgs();
            lastArgumentList = args;

            Clipboard.SetText(args);
        }


        private void LogData(string args)
        {
            string basePath = "Logs/";
            string folderName = DateTime.Now.ToString("dd-MMM-yyyy");

            if (!Directory.Exists(basePath + folderName))
                Directory.CreateDirectory(basePath + folderName);

            string fileName = DateTime.Now.ToString("hh-mm-ss tt");
            fileName = basePath + folderName + "/" + fileName + ".json";
            
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                LogStyleTransferData styleTransferData = new LogStyleTransferData()
                {
                    Time = DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss"),
                    ScriptType = GetNetworkPath(), 
                    ContentFilePath = SrcPathLabel.Text,
                    StyleFilePath = StylePathLabel.Text,
                    OutputFilePrefix = DstPathLabel.Text,
                    ParameterList = args
                };

                writer.WriteLine(JsonConvert.SerializeObject(styleTransferData, Formatting.Indented));
            }

        }

        private void LogDoodleData(string args)
        {
            string basePath = "Logs-Doodle/";
            string folderName = DateTime.Now.ToString("dd-MMM-yyyy");

            if (!Directory.Exists(basePath + folderName))
                Directory.CreateDirectory(basePath + folderName);

            string fileName = DateTime.Now.ToString("hh-mm-ss tt");
            fileName = basePath + folderName + "/" + fileName + ".json";

            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                LogDoodleData info = new LogDoodleData()
                {
                    Time = DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss"),
                    ScriptType = GetDoodlePath(),
                    ContentFilePath = SrcImageDoodleLabel.Text,
                    StyleFilePath = StyleImageDoodleLabel.Text,
                    OutputFilePrefix = DestinationPrefixDoodleLabel.Text,
                    StyleMaskPath = StyleMaskImageDoodleLabel.Text,
                    TargetMaskPath = TargetImageMaskDoodleLabel.Text,
                    ParameterList = args
                };

                writer.WriteLine(JsonConvert.SerializeObject(info, Formatting.Indented));
            }
        }

        private void LogColorTransferData(string args)
        {
            string basePath = "Logs-Color-Transfer/";
            string folderName = DateTime.Now.ToString("dd-MMM-yyyy");

            if (!Directory.Exists(basePath + folderName))
                Directory.CreateDirectory(basePath + folderName);

            string fileName = DateTime.Now.ToString("hh-mm-ss tt");
            fileName = basePath + folderName + "/" + fileName + ".json";

            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                LogColorTransferData data = new LogColorTransferData()
                {
                    Time = DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss"),
                    ContentFilePath = ContentColorTransferLabel.Text,
                    GeneratedFilePath = GeneratedColorTransferLabel.Text,
                    ParameterList = args,
                };

                writer.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));
            }

        }

        private void LogMaskedTransferData(string args)
        {
            string basePath = "Logs-Maksed-Transfer/";
            string folderName = DateTime.Now.ToString("dd-MMM-yyyy");

            if (!Directory.Exists(basePath + folderName))
                Directory.CreateDirectory(basePath + folderName);

            string fileName = DateTime.Now.ToString("hh-mm-ss tt");
            fileName = basePath + folderName + "/" + fileName + ".json";

            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                LogMaskedTransferData data = new LogMaskedTransferData()
                {
                    Time = DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss"),
                    ContentFilePath = ContentMaskedLabel.Text,
                    GeneratedFilePath = GeneratedMaskedLabel.Text,
                    MaskFilePath = MaskedLable.Text,
                    ParameterList = args,
                };

                writer.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));
            }
        }
    }
}
