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
using Neural_Style_Transfer.Properties;
using Newtonsoft.Json;

namespace Neural_Dream
{
    public partial class MainForm : Form
    {
        private string desktopPath = "";

        // Neural Style region
        private double contentWeight, styleWeight, tvWeight, styleScale, minThreshold;
        private int imageSize, noIters;
        private string rescaleAlgo, contentLayer, poolingType;
        
        // Neural Doodle region
        private double contentWeightDoodle, styleWeightDoodle, tvWeightDoodle, regionWeightDoodle;
        private int imageSizeDoodle, noItersDoodle;

        private string lastArgumentList;

        private const string NETWORK_PATH = "Network.py";
        private const string INETWORK_PATH = "INetwork.py";
        private const string NEURAL_DOODLE_PATH = "neural_doodle.py";
        private const string INEURAL_DOODLE_PATH = "improved_neural_doodle.py";

        public MainForm()
        {
            InitializeComponent();
            desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            RescaleAlgoBox.Text = "bilinear";
            ContentLayerBox.Text = "conv5_2";
            InitialLayerComboBox.Text = "content";
            PoolingTypeBox.Text = "max";
        }

        private void SrcBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = desktopPath;
            openFileDialog1.Filter = "Image (*.jpeg, *.jpg, *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SrcPathLabel.Text = openFileDialog1.FileName;
                SrcBtn.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                SrcBtn.Text = "";
            }
        }

        private void StyleBtn_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = desktopPath;
            openFileDialog1.Filter = "Image (*.jpeg, *.jpg, *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StylePathLabel.Text = openFileDialog1.FileName;
                StyleBtn.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
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


        private void SourceImageDoodle_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = desktopPath;
            openFileDialog1.Filter = "Image (*.jpeg, *.jpg, *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SrcImageDoodleLabel.Text = openFileDialog1.FileName;
                SourceImageDoodle.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                SourceImageDoodle.Text = "";
            }
        }
        
        private void StyleImageDoodle_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = desktopPath;
            openFileDialog1.Filter = "Image (*.jpeg, *.jpg, *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StyleImageDoodleLabel.Text = openFileDialog1.FileName;
                StyleImageDoodle.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                StyleImageDoodle.Text = "";
            }
        }

        private void StyleMaskDoodle_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = desktopPath;
            openFileDialog1.Filter = "Image (*.jpeg, *.jpg, *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StyleMaskImageDoodleLabel.Text = openFileDialog1.FileName;
                StyleMaskDoodle.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                StyleMaskDoodle.Text = "";
            }
        }
        
        private void TargetMaskDoodle_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = desktopPath;
            openFileDialog1.Filter = "Image (*.jpeg, *.jpg, *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

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
                styleWeight = Convert.ToDouble(StyleWeightText.Text);
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
                MessageBox.Show("Content Must be selected from one of the two options", "Content Layer");
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
                        pythonName = "python"
                    }
                    else 
                    {
                        pythonName = "python.exe"
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
            args.Append("\"" + StylePathLabel.Text + "\" ");
            args.Append("\"" + DstPathLabel.Text + "\" ");

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
            args.Append("--min_improvement " + minThreshold + "");

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
                LogInfo info = new LogInfo()
                {
                    Time = DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss"),
                    ScriptType = GetNetworkPath(), 
                    ContentFilePath = SrcPathLabel.Text,
                    StyleFilePath = StylePathLabel.Text,
                    OutputFilePrefix = DstPathLabel.Text,
                    ParameterList = args
                };

                writer.WriteLine(JsonConvert.SerializeObject(info, Formatting.Indented));
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

    }
}
