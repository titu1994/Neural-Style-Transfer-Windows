namespace Neural_Dream
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SrcToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PreserveColorBox = new System.Windows.Forms.CheckBox();
            this.NetworkCheckBox = new System.Windows.Forms.CheckBox();
            this.StyleBtn = new System.Windows.Forms.Button();
            this.SrcBtn = new System.Windows.Forms.Button();
            this.StyleImageDoodle = new System.Windows.Forms.Button();
            this.SourceImageDoodle = new System.Windows.Forms.Button();
            this.StyleMaskDoodle = new System.Windows.Forms.Button();
            this.TargetMaskDoodle = new System.Windows.Forms.Button();
            this.UseImprovedNetworkDoodle = new System.Windows.Forms.CheckBox();
            this.PreserveColorDoodle = new System.Windows.Forms.CheckBox();
            this.MaskImagesBtn = new System.Windows.Forms.Button();
            this.ContentColorTransferBtn = new System.Windows.Forms.Button();
            this.GeneratedColorTransferBtn = new System.Windows.Forms.Button();
            this.GeneratedImageMaskedBtn = new System.Windows.Forms.Button();
            this.ContentImageMaskedBtn = new System.Windows.Forms.Button();
            this.MaskedImageBtn = new System.Windows.Forms.Button();
            this.MaskColorTransferBtn = new System.Windows.Forms.Button();
            this.ColorMaskImageBtn = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CopyArgumentsBtn = new System.Windows.Forms.Button();
            this.MaintainAspectRatioCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RescaleCheck = new System.Windows.Forms.CheckBox();
            this.DstBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.CopyArgsDoodle = new System.Windows.Forms.Button();
            this.ExecuteDoodle = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DestinationPrefixDoodleBtn = new System.Windows.Forms.Button();
            this.CopyArgumentsColorTransferBtn = new System.Windows.Forms.Button();
            this.ExecuteColorTransferBtn = new System.Windows.Forms.Button();
            this.CopyArgumentsMaskedTransferBtn = new System.Windows.Forms.Button();
            this.ExecuteMaskedTransferBtn = new System.Windows.Forms.Button();
            this.ContentMaskImageBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ContentMaskPathLabel = new System.Windows.Forms.Label();
            this.ColorMaskImageLabel = new System.Windows.Forms.Label();
            this.MaskPathLabel = new System.Windows.Forms.Label();
            this.ContentLossTypeBox = new System.Windows.Forms.ComboBox();
            this.ModelTypeBox = new System.Windows.Forms.ComboBox();
            this.MinThresholdText = new System.Windows.Forms.TextBox();
            this.PoolingTypeBox = new System.Windows.Forms.ComboBox();
            this.InitialLayerComboBox = new System.Windows.Forms.ComboBox();
            this.ContentLayerBox = new System.Windows.Forms.ComboBox();
            this.RescaleAlgoBox = new System.Windows.Forms.ComboBox();
            this.DstPathLabel = new System.Windows.Forms.Label();
            this.NoOfItersText = new System.Windows.Forms.TextBox();
            this.StyleScaleText = new System.Windows.Forms.TextBox();
            this.TotalVariationWeightText = new System.Windows.Forms.TextBox();
            this.StyleWeightText = new System.Windows.Forms.TextBox();
            this.ContentWeightText = new System.Windows.Forms.TextBox();
            this.ImageSizeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HorizontalLine = new System.Windows.Forms.Label();
            this.StylePathLabel = new System.Windows.Forms.Label();
            this.SrcPathLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RegionWeightDoodleText = new System.Windows.Forms.TextBox();
            this.NumColorsText = new System.Windows.Forms.TextBox();
            this.NumIterDoodle = new System.Windows.Forms.TextBox();
            this.ImageSizeBoxDoodle = new System.Windows.Forms.ComboBox();
            this.TVWeightBoxDoodle = new System.Windows.Forms.TextBox();
            this.StyleWeightBoxDoodle = new System.Windows.Forms.TextBox();
            this.ContentWeightBoxDoodle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DestinationPrefixDoodleLabel = new System.Windows.Forms.Label();
            this.TargetImageMaskDoodleLabel = new System.Windows.Forms.Label();
            this.StyleMaskImageDoodleLabel = new System.Windows.Forms.Label();
            this.StyleImageDoodleLabel = new System.Windows.Forms.Label();
            this.SrcImageDoodleLabel = new System.Windows.Forms.Label();
            this.ColorTransfer = new System.Windows.Forms.TabPage();
            this.ColorTransferHistMatchCheck = new System.Windows.Forms.CheckBox();
            this.MaskedColorTransferLabel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.GeneratedColorTransferLabel = new System.Windows.Forms.Label();
            this.ContentColorTransferLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MaskedLable = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.GeneratedMaskedLabel = new System.Windows.Forms.Label();
            this.ContentMaskedLabel = new System.Windows.Forms.Label();
            this.cbCPU = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ColorTransfer.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PreserveColorBox
            // 
            this.PreserveColorBox.AutoSize = true;
            this.PreserveColorBox.Location = new System.Drawing.Point(220, 255);
            this.PreserveColorBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PreserveColorBox.Name = "PreserveColorBox";
            this.PreserveColorBox.Size = new System.Drawing.Size(95, 17);
            this.PreserveColorBox.TabIndex = 71;
            this.PreserveColorBox.Text = "Preserve Color";
            this.SrcToolTip.SetToolTip(this.PreserveColorBox, "If checked, preserves the original color of the content. Else, does not apply col" +
        "or preservation.");
            this.PreserveColorBox.UseVisualStyleBackColor = true;
            // 
            // NetworkCheckBox
            // 
            this.NetworkCheckBox.AutoSize = true;
            this.NetworkCheckBox.Checked = true;
            this.NetworkCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NetworkCheckBox.Location = new System.Drawing.Point(28, 255);
            this.NetworkCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NetworkCheckBox.Name = "NetworkCheckBox";
            this.NetworkCheckBox.Size = new System.Drawing.Size(135, 17);
            this.NetworkCheckBox.TabIndex = 70;
            this.NetworkCheckBox.Text = "Use Improved Network";
            this.SrcToolTip.SetToolTip(this.NetworkCheckBox, "If checked, uses the INetwork.py script which is an improved version of the netwo" +
        "rk.\r\nElse, uses the original Network.py script without any improvements.\r\n");
            this.NetworkCheckBox.UseVisualStyleBackColor = true;
            // 
            // StyleBtn
            // 
            this.StyleBtn.BackColor = System.Drawing.Color.White;
            this.StyleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StyleBtn.Location = new System.Drawing.Point(19, 71);
            this.StyleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StyleBtn.Name = "StyleBtn";
            this.StyleBtn.Size = new System.Drawing.Size(71, 43);
            this.StyleBtn.TabIndex = 39;
            this.StyleBtn.Text = "Style Images";
            this.SrcToolTip.SetToolTip(this.StyleBtn, "Style Image\r\n");
            this.StyleBtn.UseVisualStyleBackColor = false;
            this.StyleBtn.Click += new System.EventHandler(this.StyleBtn_Click_1);
            // 
            // SrcBtn
            // 
            this.SrcBtn.BackColor = System.Drawing.Color.White;
            this.SrcBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SrcBtn.Location = new System.Drawing.Point(19, 13);
            this.SrcBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SrcBtn.Name = "SrcBtn";
            this.SrcBtn.Size = new System.Drawing.Size(71, 43);
            this.SrcBtn.TabIndex = 38;
            this.SrcBtn.Text = "Source Image";
            this.SrcToolTip.SetToolTip(this.SrcBtn, "Source Image\r\n");
            this.SrcBtn.UseVisualStyleBackColor = false;
            this.SrcBtn.Click += new System.EventHandler(this.SrcBtn_Click);
            // 
            // StyleImageDoodle
            // 
            this.StyleImageDoodle.BackColor = System.Drawing.Color.White;
            this.StyleImageDoodle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StyleImageDoodle.Location = new System.Drawing.Point(16, 76);
            this.StyleImageDoodle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StyleImageDoodle.Name = "StyleImageDoodle";
            this.StyleImageDoodle.Size = new System.Drawing.Size(71, 43);
            this.StyleImageDoodle.TabIndex = 60;
            this.StyleImageDoodle.Text = "Style Image";
            this.SrcToolTip.SetToolTip(this.StyleImageDoodle, "Style Image\r\n");
            this.StyleImageDoodle.UseVisualStyleBackColor = false;
            this.StyleImageDoodle.Click += new System.EventHandler(this.StyleImageDoodle_Click);
            // 
            // SourceImageDoodle
            // 
            this.SourceImageDoodle.BackColor = System.Drawing.Color.White;
            this.SourceImageDoodle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SourceImageDoodle.Location = new System.Drawing.Point(16, 19);
            this.SourceImageDoodle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SourceImageDoodle.Name = "SourceImageDoodle";
            this.SourceImageDoodle.Size = new System.Drawing.Size(71, 43);
            this.SourceImageDoodle.TabIndex = 59;
            this.SourceImageDoodle.Text = "Source Image";
            this.SrcToolTip.SetToolTip(this.SourceImageDoodle, "Source Image\r\n");
            this.SourceImageDoodle.UseVisualStyleBackColor = false;
            this.SourceImageDoodle.Click += new System.EventHandler(this.SourceImageDoodle_Click);
            // 
            // StyleMaskDoodle
            // 
            this.StyleMaskDoodle.BackColor = System.Drawing.Color.White;
            this.StyleMaskDoodle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StyleMaskDoodle.Location = new System.Drawing.Point(16, 136);
            this.StyleMaskDoodle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StyleMaskDoodle.Name = "StyleMaskDoodle";
            this.StyleMaskDoodle.Size = new System.Drawing.Size(71, 43);
            this.StyleMaskDoodle.TabIndex = 65;
            this.StyleMaskDoodle.Text = "Style Mask Image";
            this.SrcToolTip.SetToolTip(this.StyleMaskDoodle, "Style Image Mask\r\n");
            this.StyleMaskDoodle.UseVisualStyleBackColor = false;
            this.StyleMaskDoodle.Click += new System.EventHandler(this.StyleMaskDoodle_Click);
            // 
            // TargetMaskDoodle
            // 
            this.TargetMaskDoodle.BackColor = System.Drawing.Color.White;
            this.TargetMaskDoodle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TargetMaskDoodle.Location = new System.Drawing.Point(16, 193);
            this.TargetMaskDoodle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TargetMaskDoodle.Name = "TargetMaskDoodle";
            this.TargetMaskDoodle.Size = new System.Drawing.Size(71, 43);
            this.TargetMaskDoodle.TabIndex = 66;
            this.TargetMaskDoodle.Text = "Target Mask Image";
            this.SrcToolTip.SetToolTip(this.TargetMaskDoodle, "Optional : Target Mask Image");
            this.TargetMaskDoodle.UseVisualStyleBackColor = false;
            this.TargetMaskDoodle.Click += new System.EventHandler(this.TargetMaskDoodle_Click);
            // 
            // UseImprovedNetworkDoodle
            // 
            this.UseImprovedNetworkDoodle.AutoSize = true;
            this.UseImprovedNetworkDoodle.Checked = true;
            this.UseImprovedNetworkDoodle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseImprovedNetworkDoodle.Location = new System.Drawing.Point(32, 312);
            this.UseImprovedNetworkDoodle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UseImprovedNetworkDoodle.Name = "UseImprovedNetworkDoodle";
            this.UseImprovedNetworkDoodle.Size = new System.Drawing.Size(135, 17);
            this.UseImprovedNetworkDoodle.TabIndex = 71;
            this.UseImprovedNetworkDoodle.Text = "Use Improved Network";
            this.SrcToolTip.SetToolTip(this.UseImprovedNetworkDoodle, "If checked, uses the INetwork.py script which is an improved version of the netwo" +
        "rk.\r\nElse, uses the original Network.py script without any improvements.\r\n");
            this.UseImprovedNetworkDoodle.UseVisualStyleBackColor = true;
            // 
            // PreserveColorDoodle
            // 
            this.PreserveColorDoodle.AutoSize = true;
            this.PreserveColorDoodle.Location = new System.Drawing.Point(308, 312);
            this.PreserveColorDoodle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PreserveColorDoodle.Name = "PreserveColorDoodle";
            this.PreserveColorDoodle.Size = new System.Drawing.Size(95, 17);
            this.PreserveColorDoodle.TabIndex = 72;
            this.PreserveColorDoodle.Text = "Preserve Color";
            this.SrcToolTip.SetToolTip(this.PreserveColorDoodle, "If checked, preserves the original color of the content. Else, does not apply col" +
        "or preservation.");
            this.PreserveColorDoodle.UseVisualStyleBackColor = true;
            // 
            // MaskImagesBtn
            // 
            this.MaskImagesBtn.BackColor = System.Drawing.Color.White;
            this.MaskImagesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaskImagesBtn.Location = new System.Drawing.Point(344, 71);
            this.MaskImagesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaskImagesBtn.Name = "MaskImagesBtn";
            this.MaskImagesBtn.Size = new System.Drawing.Size(71, 43);
            this.MaskImagesBtn.TabIndex = 78;
            this.MaskImagesBtn.Text = "Style Mask Images";
            this.SrcToolTip.SetToolTip(this.MaskImagesBtn, "Optional : Style Masks");
            this.MaskImagesBtn.UseVisualStyleBackColor = false;
            this.MaskImagesBtn.Click += new System.EventHandler(this.MaskImagesBtn_Click);
            // 
            // ContentColorTransferBtn
            // 
            this.ContentColorTransferBtn.BackColor = System.Drawing.Color.White;
            this.ContentColorTransferBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContentColorTransferBtn.Location = new System.Drawing.Point(24, 15);
            this.ContentColorTransferBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContentColorTransferBtn.Name = "ContentColorTransferBtn";
            this.ContentColorTransferBtn.Size = new System.Drawing.Size(71, 43);
            this.ContentColorTransferBtn.TabIndex = 39;
            this.ContentColorTransferBtn.Text = "Content Image";
            this.SrcToolTip.SetToolTip(this.ContentColorTransferBtn, "Source Image\r\n");
            this.ContentColorTransferBtn.UseVisualStyleBackColor = false;
            this.ContentColorTransferBtn.Click += new System.EventHandler(this.ContentColorTransferBtn_Click);
            // 
            // GeneratedColorTransferBtn
            // 
            this.GeneratedColorTransferBtn.BackColor = System.Drawing.Color.White;
            this.GeneratedColorTransferBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeneratedColorTransferBtn.Location = new System.Drawing.Point(24, 82);
            this.GeneratedColorTransferBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GeneratedColorTransferBtn.Name = "GeneratedColorTransferBtn";
            this.GeneratedColorTransferBtn.Size = new System.Drawing.Size(71, 43);
            this.GeneratedColorTransferBtn.TabIndex = 40;
            this.GeneratedColorTransferBtn.Text = "Generated Image";
            this.SrcToolTip.SetToolTip(this.GeneratedColorTransferBtn, "Generated Image\r\n");
            this.GeneratedColorTransferBtn.UseVisualStyleBackColor = false;
            this.GeneratedColorTransferBtn.Click += new System.EventHandler(this.GeneratedColorTransferBtn_Click);
            // 
            // GeneratedImageMaskedBtn
            // 
            this.GeneratedImageMaskedBtn.BackColor = System.Drawing.Color.White;
            this.GeneratedImageMaskedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeneratedImageMaskedBtn.Location = new System.Drawing.Point(24, 82);
            this.GeneratedImageMaskedBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GeneratedImageMaskedBtn.Name = "GeneratedImageMaskedBtn";
            this.GeneratedImageMaskedBtn.Size = new System.Drawing.Size(71, 43);
            this.GeneratedImageMaskedBtn.TabIndex = 68;
            this.GeneratedImageMaskedBtn.Text = "Generated Image";
            this.SrcToolTip.SetToolTip(this.GeneratedImageMaskedBtn, "Generated Image");
            this.GeneratedImageMaskedBtn.UseVisualStyleBackColor = false;
            this.GeneratedImageMaskedBtn.Click += new System.EventHandler(this.GeneratedImageMaskedBtn_Click);
            // 
            // ContentImageMaskedBtn
            // 
            this.ContentImageMaskedBtn.BackColor = System.Drawing.Color.White;
            this.ContentImageMaskedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContentImageMaskedBtn.Location = new System.Drawing.Point(24, 15);
            this.ContentImageMaskedBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContentImageMaskedBtn.Name = "ContentImageMaskedBtn";
            this.ContentImageMaskedBtn.Size = new System.Drawing.Size(71, 43);
            this.ContentImageMaskedBtn.TabIndex = 67;
            this.ContentImageMaskedBtn.Text = "Content Image";
            this.SrcToolTip.SetToolTip(this.ContentImageMaskedBtn, "Source Image\r\n");
            this.ContentImageMaskedBtn.UseVisualStyleBackColor = false;
            this.ContentImageMaskedBtn.Click += new System.EventHandler(this.ContentImageMaskedBtn_Click);
            // 
            // MaskedImageBtn
            // 
            this.MaskedImageBtn.BackColor = System.Drawing.Color.White;
            this.MaskedImageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaskedImageBtn.Location = new System.Drawing.Point(24, 147);
            this.MaskedImageBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaskedImageBtn.Name = "MaskedImageBtn";
            this.MaskedImageBtn.Size = new System.Drawing.Size(71, 43);
            this.MaskedImageBtn.TabIndex = 72;
            this.MaskedImageBtn.Text = "Mask Image";
            this.SrcToolTip.SetToolTip(this.MaskedImageBtn, "Content Mask Image");
            this.MaskedImageBtn.UseVisualStyleBackColor = false;
            this.MaskedImageBtn.Click += new System.EventHandler(this.MaskedImageBtn_Click);
            // 
            // MaskColorTransferBtn
            // 
            this.MaskColorTransferBtn.BackColor = System.Drawing.Color.White;
            this.MaskColorTransferBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaskColorTransferBtn.Location = new System.Drawing.Point(24, 151);
            this.MaskColorTransferBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaskColorTransferBtn.Name = "MaskColorTransferBtn";
            this.MaskColorTransferBtn.Size = new System.Drawing.Size(71, 43);
            this.MaskColorTransferBtn.TabIndex = 74;
            this.MaskColorTransferBtn.Text = "Mask Image";
            this.SrcToolTip.SetToolTip(this.MaskColorTransferBtn, "Optional : Color Mask Image");
            this.MaskColorTransferBtn.UseVisualStyleBackColor = false;
            this.MaskColorTransferBtn.Click += new System.EventHandler(this.MaskColorTransferBtn_Click);
            // 
            // ColorMaskImageBtn
            // 
            this.ColorMaskImageBtn.BackColor = System.Drawing.Color.White;
            this.ColorMaskImageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ColorMaskImageBtn.Location = new System.Drawing.Point(19, 186);
            this.ColorMaskImageBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ColorMaskImageBtn.Name = "ColorMaskImageBtn";
            this.ColorMaskImageBtn.Size = new System.Drawing.Size(71, 43);
            this.ColorMaskImageBtn.TabIndex = 80;
            this.ColorMaskImageBtn.Text = "Color Mask Image";
            this.SrcToolTip.SetToolTip(this.ColorMaskImageBtn, "Optional : Color Mask");
            this.ColorMaskImageBtn.UseVisualStyleBackColor = false;
            this.ColorMaskImageBtn.Click += new System.EventHandler(this.ColorMaskImageBtn_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(26, 496);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 13);
            this.label22.TabIndex = 76;
            this.label22.Text = "Content Loss Type";
            this.SrcToolTip.SetToolTip(this.label22, "Scaling applied to content loss. \r\n\r\n- 0 = 0 does not add any scaling of the loss" +
        ". \r\n- 1 = 1 / (2 * sqrt(channels) * sqrt(width * height))\r\n- 2 = 1 / (channels *" +
        " width * height)");
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(255, 493);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 13);
            this.label21.TabIndex = 74;
            this.label21.Text = "Model Type";
            this.SrcToolTip.SetToolTip(this.label21, "Use either VGG 16 or VGG 19 architecture");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(482, 401);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 72;
            this.label12.Text = "Minimum Improvement";
            this.SrcToolTip.SetToolTip(this.label12, "Minimum improvement required at each iteration. If improvement is less than minim" +
        "um specified here, it stops the script");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(482, 446);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Pooling Type";
            this.SrcToolTip.SetToolTip(this.label11, "Type of pooling that should be used in the VGG network");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 444);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Initial Layer";
            this.SrcToolTip.SetToolTip(this.label10, "Initialise the generated image with either the content image itself, with noise o" +
        "r with a gray scale version of the content image");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 444);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Content Layer";
            this.SrcToolTip.SetToolTip(this.label9, "Content layer used for style transfer");
            // 
            // CopyArgumentsBtn
            // 
            this.CopyArgumentsBtn.BackColor = System.Drawing.Color.White;
            this.CopyArgumentsBtn.Location = new System.Drawing.Point(405, 552);
            this.CopyArgumentsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CopyArgumentsBtn.Name = "CopyArgumentsBtn";
            this.CopyArgumentsBtn.Size = new System.Drawing.Size(142, 54);
            this.CopyArgumentsBtn.TabIndex = 63;
            this.CopyArgumentsBtn.Text = "Copy Arguments to Clipboard";
            this.SrcToolTip.SetToolTip(this.CopyArgumentsBtn, "Copy the script arguments, so that you can open the terminal and paste the comman" +
        "d");
            this.CopyArgumentsBtn.UseVisualStyleBackColor = false;
            this.CopyArgumentsBtn.Click += new System.EventHandler(this.CopyArgumentsBtn_Click_1);
            // 
            // MaintainAspectRatioCheckBox
            // 
            this.MaintainAspectRatioCheckBox.AutoSize = true;
            this.MaintainAspectRatioCheckBox.Checked = true;
            this.MaintainAspectRatioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MaintainAspectRatioCheckBox.Location = new System.Drawing.Point(366, 255);
            this.MaintainAspectRatioCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaintainAspectRatioCheckBox.Name = "MaintainAspectRatioCheckBox";
            this.MaintainAspectRatioCheckBox.Size = new System.Drawing.Size(130, 17);
            this.MaintainAspectRatioCheckBox.TabIndex = 62;
            this.MaintainAspectRatioCheckBox.Text = "Maintain Aspect Ratio";
            this.SrcToolTip.SetToolTip(this.MaintainAspectRatioCheckBox, "Maintain the aspect ratio of output image");
            this.MaintainAspectRatioCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 400);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Rescale Algo";
            this.SrcToolTip.SetToolTip(this.label8, "Algorithm used for rescaling generated image to original size");
            // 
            // RescaleCheck
            // 
            this.RescaleCheck.AutoSize = true;
            this.RescaleCheck.Location = new System.Drawing.Point(28, 400);
            this.RescaleCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RescaleCheck.Name = "RescaleCheck";
            this.RescaleCheck.Size = new System.Drawing.Size(174, 17);
            this.RescaleCheck.TabIndex = 59;
            this.RescaleCheck.Text = "Rescale To Original Dimentions";
            this.SrcToolTip.SetToolTip(this.RescaleCheck, "Upscale the generated image using bicubic interpolation to the original size of t" +
        "he content image. Not recommended as it introduces noise.");
            this.RescaleCheck.UseVisualStyleBackColor = true;
            // 
            // DstBtn
            // 
            this.DstBtn.BackColor = System.Drawing.Color.White;
            this.DstBtn.Location = new System.Drawing.Point(19, 131);
            this.DstBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DstBtn.Name = "DstBtn";
            this.DstBtn.Size = new System.Drawing.Size(71, 43);
            this.DstBtn.TabIndex = 57;
            this.DstBtn.Text = "Destination Image";
            this.SrcToolTip.SetToolTip(this.DstBtn, "Path and prefix of output image");
            this.DstBtn.UseVisualStyleBackColor = false;
            this.DstBtn.Click += new System.EventHandler(this.DstBtn_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Number Of Iterations";
            this.SrcToolTip.SetToolTip(this.label7, "Number of iterations to process the image");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Style Scale";
            this.SrcToolTip.SetToolTip(this.label6, "Style weight multiplier");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Total Variation Weight";
            this.SrcToolTip.SetToolTip(this.label5, "Smoothness weight. Increase to obtain a smoother image. Decrease to increase shar" +
        "pness.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Style Weights";
            this.SrcToolTip.SetToolTip(this.label4, "Weight for Style Image/s. Pass multiple style weights, seperated by spaces.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Content Weight";
            this.SrcToolTip.SetToolTip(this.label3, "Weight for Content Image");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 346);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Image Size";
            this.SrcToolTip.SetToolTip(this.label2, "Gram matrix size. Use small values for speed and upscale later using upscaling pr" +
        "ograms");
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BackColor = System.Drawing.Color.White;
            this.ExecuteButton.Location = new System.Drawing.Point(211, 552);
            this.ExecuteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(160, 54);
            this.ExecuteButton.TabIndex = 42;
            this.ExecuteButton.Text = "Compute";
            this.SrcToolTip.SetToolTip(this.ExecuteButton, "Start style transfer");
            this.ExecuteButton.UseVisualStyleBackColor = false;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click_1);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(511, 405);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 87;
            this.label20.Text = "Region Weight";
            this.SrcToolTip.SetToolTip(this.label20, "Weightage given to individual regions. Do not change unless you know what you are" +
        " doing!");
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(511, 315);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 85;
            this.label19.Text = "Num Colors";
            this.SrcToolTip.SetToolTip(this.label19, "Number of colors in mask image");
            // 
            // CopyArgsDoodle
            // 
            this.CopyArgsDoodle.BackColor = System.Drawing.Color.White;
            this.CopyArgsDoodle.Location = new System.Drawing.Point(388, 515);
            this.CopyArgsDoodle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CopyArgsDoodle.Name = "CopyArgsDoodle";
            this.CopyArgsDoodle.Size = new System.Drawing.Size(142, 54);
            this.CopyArgsDoodle.TabIndex = 84;
            this.CopyArgsDoodle.Text = "Copy Arguments to Clipboard";
            this.SrcToolTip.SetToolTip(this.CopyArgsDoodle, "Copy the script arguments, so that you can open the terminal and paste the comman" +
        "d");
            this.CopyArgsDoodle.UseVisualStyleBackColor = false;
            this.CopyArgsDoodle.Click += new System.EventHandler(this.CopyArgsDoodle_Click);
            // 
            // ExecuteDoodle
            // 
            this.ExecuteDoodle.BackColor = System.Drawing.Color.White;
            this.ExecuteDoodle.Location = new System.Drawing.Point(194, 515);
            this.ExecuteDoodle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExecuteDoodle.Name = "ExecuteDoodle";
            this.ExecuteDoodle.Size = new System.Drawing.Size(160, 54);
            this.ExecuteDoodle.TabIndex = 83;
            this.ExecuteDoodle.Text = "Compute";
            this.SrcToolTip.SetToolTip(this.ExecuteDoodle, "Start neural doodle script");
            this.ExecuteDoodle.UseVisualStyleBackColor = false;
            this.ExecuteDoodle.Click += new System.EventHandler(this.ExecuteDoodle_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(306, 402);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 13);
            this.label17.TabIndex = 81;
            this.label17.Text = "Number Of Iterations";
            this.SrcToolTip.SetToolTip(this.label17, "Number of iterations to process the image");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 400);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 79;
            this.label18.Text = "Image Size";
            this.SrcToolTip.SetToolTip(this.label18, "Resize the image to certain size. -1 indicates do not scale image");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(511, 357);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 13);
            this.label16.TabIndex = 77;
            this.label16.Text = "Total Variation Weight";
            this.SrcToolTip.SetToolTip(this.label16, "Smoothness weight. Increase to obtain a smoother image. Decrease to increase shar" +
        "pness.");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(306, 357);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 75;
            this.label15.Text = "Style Weight";
            this.SrcToolTip.SetToolTip(this.label15, "Weight for Style Image");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 354);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 73;
            this.label14.Text = "Content Weight";
            this.SrcToolTip.SetToolTip(this.label14, "Weight for Content Image");
            // 
            // DestinationPrefixDoodleBtn
            // 
            this.DestinationPrefixDoodleBtn.BackColor = System.Drawing.Color.White;
            this.DestinationPrefixDoodleBtn.Location = new System.Drawing.Point(16, 249);
            this.DestinationPrefixDoodleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DestinationPrefixDoodleBtn.Name = "DestinationPrefixDoodleBtn";
            this.DestinationPrefixDoodleBtn.Size = new System.Drawing.Size(71, 43);
            this.DestinationPrefixDoodleBtn.TabIndex = 63;
            this.DestinationPrefixDoodleBtn.Text = "Destination Image";
            this.SrcToolTip.SetToolTip(this.DestinationPrefixDoodleBtn, "Path and prefix of output image");
            this.DestinationPrefixDoodleBtn.UseVisualStyleBackColor = false;
            this.DestinationPrefixDoodleBtn.Click += new System.EventHandler(this.DestinationPathDoodle_Click);
            // 
            // CopyArgumentsColorTransferBtn
            // 
            this.CopyArgumentsColorTransferBtn.BackColor = System.Drawing.Color.White;
            this.CopyArgumentsColorTransferBtn.Location = new System.Drawing.Point(355, 358);
            this.CopyArgumentsColorTransferBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CopyArgumentsColorTransferBtn.Name = "CopyArgumentsColorTransferBtn";
            this.CopyArgumentsColorTransferBtn.Size = new System.Drawing.Size(142, 54);
            this.CopyArgumentsColorTransferBtn.TabIndex = 65;
            this.CopyArgumentsColorTransferBtn.Text = "Copy Arguments to Clipboard";
            this.SrcToolTip.SetToolTip(this.CopyArgumentsColorTransferBtn, "Copy the script arguments, so that you can open the terminal and paste the comman" +
        "d");
            this.CopyArgumentsColorTransferBtn.UseVisualStyleBackColor = false;
            this.CopyArgumentsColorTransferBtn.Click += new System.EventHandler(this.CopyArgumentsColorTransferBtn_Click);
            // 
            // ExecuteColorTransferBtn
            // 
            this.ExecuteColorTransferBtn.BackColor = System.Drawing.Color.White;
            this.ExecuteColorTransferBtn.Location = new System.Drawing.Point(160, 358);
            this.ExecuteColorTransferBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExecuteColorTransferBtn.Name = "ExecuteColorTransferBtn";
            this.ExecuteColorTransferBtn.Size = new System.Drawing.Size(160, 54);
            this.ExecuteColorTransferBtn.TabIndex = 64;
            this.ExecuteColorTransferBtn.Text = "Transfer";
            this.SrcToolTip.SetToolTip(this.ExecuteColorTransferBtn, "Start color transfer script");
            this.ExecuteColorTransferBtn.UseVisualStyleBackColor = false;
            this.ExecuteColorTransferBtn.Click += new System.EventHandler(this.ExecuteColorTransferBtn_Click);
            // 
            // CopyArgumentsMaskedTransferBtn
            // 
            this.CopyArgumentsMaskedTransferBtn.BackColor = System.Drawing.Color.White;
            this.CopyArgumentsMaskedTransferBtn.Location = new System.Drawing.Point(347, 392);
            this.CopyArgumentsMaskedTransferBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CopyArgumentsMaskedTransferBtn.Name = "CopyArgumentsMaskedTransferBtn";
            this.CopyArgumentsMaskedTransferBtn.Size = new System.Drawing.Size(142, 54);
            this.CopyArgumentsMaskedTransferBtn.TabIndex = 75;
            this.CopyArgumentsMaskedTransferBtn.Text = "Copy Arguments to Clipboard";
            this.SrcToolTip.SetToolTip(this.CopyArgumentsMaskedTransferBtn, "Copy the script arguments, so that you can open the terminal and paste the comman" +
        "d");
            this.CopyArgumentsMaskedTransferBtn.UseVisualStyleBackColor = false;
            // 
            // ExecuteMaskedTransferBtn
            // 
            this.ExecuteMaskedTransferBtn.BackColor = System.Drawing.Color.White;
            this.ExecuteMaskedTransferBtn.Location = new System.Drawing.Point(153, 392);
            this.ExecuteMaskedTransferBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExecuteMaskedTransferBtn.Name = "ExecuteMaskedTransferBtn";
            this.ExecuteMaskedTransferBtn.Size = new System.Drawing.Size(160, 54);
            this.ExecuteMaskedTransferBtn.TabIndex = 74;
            this.ExecuteMaskedTransferBtn.Text = "Transfer";
            this.SrcToolTip.SetToolTip(this.ExecuteMaskedTransferBtn, "Start masked style transfer script");
            this.ExecuteMaskedTransferBtn.UseVisualStyleBackColor = false;
            this.ExecuteMaskedTransferBtn.Click += new System.EventHandler(this.ExecuteMaskedTransferBtn_Click);
            // 
            // ContentMaskImageBtn
            // 
            this.ContentMaskImageBtn.BackColor = System.Drawing.Color.White;
            this.ContentMaskImageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContentMaskImageBtn.Location = new System.Drawing.Point(344, 13);
            this.ContentMaskImageBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContentMaskImageBtn.Name = "ContentMaskImageBtn";
            this.ContentMaskImageBtn.Size = new System.Drawing.Size(71, 43);
            this.ContentMaskImageBtn.TabIndex = 82;
            this.ContentMaskImageBtn.Text = "Content Mask Image";
            this.SrcToolTip.SetToolTip(this.ContentMaskImageBtn, "Optional : Style Masks");
            this.ContentMaskImageBtn.UseVisualStyleBackColor = false;
            this.ContentMaskImageBtn.Click += new System.EventHandler(this.ContentMaskImageBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.ColorTransfer);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 693);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbCPU);
            this.tabPage1.Controls.Add(this.ContentMaskPathLabel);
            this.tabPage1.Controls.Add(this.ContentMaskImageBtn);
            this.tabPage1.Controls.Add(this.ColorMaskImageLabel);
            this.tabPage1.Controls.Add(this.ColorMaskImageBtn);
            this.tabPage1.Controls.Add(this.MaskPathLabel);
            this.tabPage1.Controls.Add(this.MaskImagesBtn);
            this.tabPage1.Controls.Add(this.ContentLossTypeBox);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.ModelTypeBox);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.MinThresholdText);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.PreserveColorBox);
            this.tabPage1.Controls.Add(this.NetworkCheckBox);
            this.tabPage1.Controls.Add(this.PoolingTypeBox);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.InitialLayerComboBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.ContentLayerBox);
            this.tabPage1.Controls.Add(this.CopyArgumentsBtn);
            this.tabPage1.Controls.Add(this.MaintainAspectRatioCheckBox);
            this.tabPage1.Controls.Add(this.RescaleAlgoBox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.RescaleCheck);
            this.tabPage1.Controls.Add(this.DstPathLabel);
            this.tabPage1.Controls.Add(this.DstBtn);
            this.tabPage1.Controls.Add(this.NoOfItersText);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.StyleScaleText);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.TotalVariationWeightText);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.StyleWeightText);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ContentWeightText);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ImageSizeBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.HorizontalLine);
            this.tabPage1.Controls.Add(this.ExecuteButton);
            this.tabPage1.Controls.Add(this.StylePathLabel);
            this.tabPage1.Controls.Add(this.SrcPathLabel);
            this.tabPage1.Controls.Add(this.StyleBtn);
            this.tabPage1.Controls.Add(this.SrcBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(728, 667);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Neural Style Transfer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ContentMaskPathLabel
            // 
            this.ContentMaskPathLabel.AutoSize = true;
            this.ContentMaskPathLabel.Location = new System.Drawing.Point(430, 28);
            this.ContentMaskPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContentMaskPathLabel.MaximumSize = new System.Drawing.Size(225, 0);
            this.ContentMaskPathLabel.Name = "ContentMaskPathLabel";
            this.ContentMaskPathLabel.Size = new System.Drawing.Size(0, 13);
            this.ContentMaskPathLabel.TabIndex = 83;
            // 
            // ColorMaskImageLabel
            // 
            this.ColorMaskImageLabel.AutoSize = true;
            this.ColorMaskImageLabel.Location = new System.Drawing.Point(110, 201);
            this.ColorMaskImageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorMaskImageLabel.MaximumSize = new System.Drawing.Size(225, 0);
            this.ColorMaskImageLabel.Name = "ColorMaskImageLabel";
            this.ColorMaskImageLabel.Size = new System.Drawing.Size(0, 13);
            this.ColorMaskImageLabel.TabIndex = 81;
            // 
            // MaskPathLabel
            // 
            this.MaskPathLabel.AutoSize = true;
            this.MaskPathLabel.Location = new System.Drawing.Point(430, 85);
            this.MaskPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaskPathLabel.MaximumSize = new System.Drawing.Size(225, 0);
            this.MaskPathLabel.Name = "MaskPathLabel";
            this.MaskPathLabel.Size = new System.Drawing.Size(0, 13);
            this.MaskPathLabel.TabIndex = 79;
            // 
            // ContentLossTypeBox
            // 
            this.ContentLossTypeBox.BackColor = System.Drawing.Color.White;
            this.ContentLossTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContentLossTypeBox.FormattingEnabled = true;
            this.ContentLossTypeBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.ContentLossTypeBox.Location = new System.Drawing.Point(125, 491);
            this.ContentLossTypeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContentLossTypeBox.Name = "ContentLossTypeBox";
            this.ContentLossTypeBox.Size = new System.Drawing.Size(80, 21);
            this.ContentLossTypeBox.TabIndex = 77;
            // 
            // ModelTypeBox
            // 
            this.ModelTypeBox.BackColor = System.Drawing.Color.White;
            this.ModelTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelTypeBox.FormattingEnabled = true;
            this.ModelTypeBox.Items.AddRange(new object[] {
            "vgg16",
            "vgg19"});
            this.ModelTypeBox.Location = new System.Drawing.Point(344, 491);
            this.ModelTypeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModelTypeBox.Name = "ModelTypeBox";
            this.ModelTypeBox.Size = new System.Drawing.Size(92, 21);
            this.ModelTypeBox.TabIndex = 75;
            this.ModelTypeBox.SelectedIndexChanged += new System.EventHandler(this.ModelTypeBox_SelectedIndexChanged);
            // 
            // MinThresholdText
            // 
            this.MinThresholdText.Location = new System.Drawing.Point(598, 400);
            this.MinThresholdText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinThresholdText.Name = "MinThresholdText";
            this.MinThresholdText.Size = new System.Drawing.Size(92, 20);
            this.MinThresholdText.TabIndex = 73;
            this.MinThresholdText.Text = "0.0";
            // 
            // PoolingTypeBox
            // 
            this.PoolingTypeBox.BackColor = System.Drawing.Color.White;
            this.PoolingTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PoolingTypeBox.FormattingEnabled = true;
            this.PoolingTypeBox.Items.AddRange(new object[] {
            "max",
            "ave"});
            this.PoolingTypeBox.Location = new System.Drawing.Point(598, 441);
            this.PoolingTypeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PoolingTypeBox.Name = "PoolingTypeBox";
            this.PoolingTypeBox.Size = new System.Drawing.Size(92, 21);
            this.PoolingTypeBox.TabIndex = 69;
            // 
            // InitialLayerComboBox
            // 
            this.InitialLayerComboBox.BackColor = System.Drawing.Color.White;
            this.InitialLayerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InitialLayerComboBox.FormattingEnabled = true;
            this.InitialLayerComboBox.Items.AddRange(new object[] {
            "content",
            "noise",
            "gray",
            "<choose image>"});
            this.InitialLayerComboBox.Location = new System.Drawing.Point(344, 444);
            this.InitialLayerComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InitialLayerComboBox.Name = "InitialLayerComboBox";
            this.InitialLayerComboBox.Size = new System.Drawing.Size(92, 21);
            this.InitialLayerComboBox.TabIndex = 66;
            this.InitialLayerComboBox.SelectedIndexChanged += new System.EventHandler(this.InitialLayerComboBox_SelectedIndexChanged);
            // 
            // ContentLayerBox
            // 
            this.ContentLayerBox.BackColor = System.Drawing.Color.White;
            this.ContentLayerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContentLayerBox.FormattingEnabled = true;
            this.ContentLayerBox.Location = new System.Drawing.Point(114, 441);
            this.ContentLayerBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContentLayerBox.Name = "ContentLayerBox";
            this.ContentLayerBox.Size = new System.Drawing.Size(92, 21);
            this.ContentLayerBox.TabIndex = 64;
            // 
            // RescaleAlgoBox
            // 
            this.RescaleAlgoBox.BackColor = System.Drawing.Color.White;
            this.RescaleAlgoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RescaleAlgoBox.FormattingEnabled = true;
            this.RescaleAlgoBox.Items.AddRange(new object[] {
            "nearest",
            "bilinear",
            "bicubic",
            "cubic"});
            this.RescaleAlgoBox.Location = new System.Drawing.Point(344, 398);
            this.RescaleAlgoBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RescaleAlgoBox.Name = "RescaleAlgoBox";
            this.RescaleAlgoBox.Size = new System.Drawing.Size(92, 21);
            this.RescaleAlgoBox.TabIndex = 61;
            // 
            // DstPathLabel
            // 
            this.DstPathLabel.AutoSize = true;
            this.DstPathLabel.Location = new System.Drawing.Point(105, 160);
            this.DstPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DstPathLabel.Name = "DstPathLabel";
            this.DstPathLabel.Size = new System.Drawing.Size(0, 13);
            this.DstPathLabel.TabIndex = 58;
            // 
            // NoOfItersText
            // 
            this.NoOfItersText.Location = new System.Drawing.Point(598, 356);
            this.NoOfItersText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NoOfItersText.Name = "NoOfItersText";
            this.NoOfItersText.Size = new System.Drawing.Size(92, 20);
            this.NoOfItersText.TabIndex = 56;
            this.NoOfItersText.Text = "10";
            // 
            // StyleScaleText
            // 
            this.StyleScaleText.Location = new System.Drawing.Point(344, 352);
            this.StyleScaleText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StyleScaleText.Name = "StyleScaleText";
            this.StyleScaleText.Size = new System.Drawing.Size(92, 20);
            this.StyleScaleText.TabIndex = 54;
            this.StyleScaleText.Text = "1.0";
            // 
            // TotalVariationWeightText
            // 
            this.TotalVariationWeightText.Location = new System.Drawing.Point(598, 303);
            this.TotalVariationWeightText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TotalVariationWeightText.Name = "TotalVariationWeightText";
            this.TotalVariationWeightText.Size = new System.Drawing.Size(92, 20);
            this.TotalVariationWeightText.TabIndex = 52;
            this.TotalVariationWeightText.Text = "8.5e-5";
            // 
            // StyleWeightText
            // 
            this.StyleWeightText.Location = new System.Drawing.Point(344, 301);
            this.StyleWeightText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StyleWeightText.Name = "StyleWeightText";
            this.StyleWeightText.Size = new System.Drawing.Size(92, 20);
            this.StyleWeightText.TabIndex = 50;
            this.StyleWeightText.Text = "1.0";
            // 
            // ContentWeightText
            // 
            this.ContentWeightText.Location = new System.Drawing.Point(114, 297);
            this.ContentWeightText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContentWeightText.Name = "ContentWeightText";
            this.ContentWeightText.Size = new System.Drawing.Size(92, 20);
            this.ContentWeightText.TabIndex = 48;
            this.ContentWeightText.Text = "0.025";
            // 
            // ImageSizeBox
            // 
            this.ImageSizeBox.DisplayMember = "512";
            this.ImageSizeBox.FormattingEnabled = true;
            this.ImageSizeBox.Items.AddRange(new object[] {
            "400",
            "512",
            "600"});
            this.ImageSizeBox.Location = new System.Drawing.Point(114, 346);
            this.ImageSizeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImageSizeBox.Name = "ImageSizeBox";
            this.ImageSizeBox.Size = new System.Drawing.Size(92, 21);
            this.ImageSizeBox.TabIndex = 46;
            this.ImageSizeBox.Text = "400";
            this.ImageSizeBox.ValueMember = "512";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-9, 635);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 2);
            this.label1.TabIndex = 44;
            // 
            // HorizontalLine
            // 
            this.HorizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorizontalLine.Location = new System.Drawing.Point(-5, 241);
            this.HorizontalLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HorizontalLine.Name = "HorizontalLine";
            this.HorizontalLine.Size = new System.Drawing.Size(734, 2);
            this.HorizontalLine.TabIndex = 43;
            // 
            // StylePathLabel
            // 
            this.StylePathLabel.AutoSize = true;
            this.StylePathLabel.Location = new System.Drawing.Point(105, 100);
            this.StylePathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StylePathLabel.Name = "StylePathLabel";
            this.StylePathLabel.Size = new System.Drawing.Size(0, 13);
            this.StylePathLabel.TabIndex = 41;
            // 
            // SrcPathLabel
            // 
            this.SrcPathLabel.AutoSize = true;
            this.SrcPathLabel.Location = new System.Drawing.Point(105, 42);
            this.SrcPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SrcPathLabel.Name = "SrcPathLabel";
            this.SrcPathLabel.Size = new System.Drawing.Size(0, 13);
            this.SrcPathLabel.TabIndex = 40;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RegionWeightDoodleText);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.NumColorsText);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.CopyArgsDoodle);
            this.tabPage2.Controls.Add(this.ExecuteDoodle);
            this.tabPage2.Controls.Add(this.NumIterDoodle);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.ImageSizeBoxDoodle);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.TVWeightBoxDoodle);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.StyleWeightBoxDoodle);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.ContentWeightBoxDoodle);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.PreserveColorDoodle);
            this.tabPage2.Controls.Add(this.UseImprovedNetworkDoodle);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.DestinationPrefixDoodleLabel);
            this.tabPage2.Controls.Add(this.TargetImageMaskDoodleLabel);
            this.tabPage2.Controls.Add(this.TargetMaskDoodle);
            this.tabPage2.Controls.Add(this.StyleMaskDoodle);
            this.tabPage2.Controls.Add(this.StyleMaskImageDoodleLabel);
            this.tabPage2.Controls.Add(this.DestinationPrefixDoodleBtn);
            this.tabPage2.Controls.Add(this.StyleImageDoodleLabel);
            this.tabPage2.Controls.Add(this.SrcImageDoodleLabel);
            this.tabPage2.Controls.Add(this.StyleImageDoodle);
            this.tabPage2.Controls.Add(this.SourceImageDoodle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(728, 667);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Neural Doodle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RegionWeightDoodleText
            // 
            this.RegionWeightDoodleText.Location = new System.Drawing.Point(626, 401);
            this.RegionWeightDoodleText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegionWeightDoodleText.Name = "RegionWeightDoodleText";
            this.RegionWeightDoodleText.Size = new System.Drawing.Size(92, 20);
            this.RegionWeightDoodleText.TabIndex = 88;
            this.RegionWeightDoodleText.Text = "1.";
            // 
            // NumColorsText
            // 
            this.NumColorsText.Location = new System.Drawing.Point(626, 312);
            this.NumColorsText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumColorsText.Name = "NumColorsText";
            this.NumColorsText.Size = new System.Drawing.Size(92, 20);
            this.NumColorsText.TabIndex = 86;
            this.NumColorsText.Text = "4";
            // 
            // NumIterDoodle
            // 
            this.NumIterDoodle.Location = new System.Drawing.Point(415, 402);
            this.NumIterDoodle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumIterDoodle.Name = "NumIterDoodle";
            this.NumIterDoodle.Size = new System.Drawing.Size(92, 20);
            this.NumIterDoodle.TabIndex = 82;
            this.NumIterDoodle.Text = "10";
            // 
            // ImageSizeBoxDoodle
            // 
            this.ImageSizeBoxDoodle.DisplayMember = "512";
            this.ImageSizeBoxDoodle.FormattingEnabled = true;
            this.ImageSizeBoxDoodle.Items.AddRange(new object[] {
            "-1",
            "400",
            "512",
            "600"});
            this.ImageSizeBoxDoodle.Location = new System.Drawing.Point(118, 400);
            this.ImageSizeBoxDoodle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImageSizeBoxDoodle.Name = "ImageSizeBoxDoodle";
            this.ImageSizeBoxDoodle.Size = new System.Drawing.Size(92, 21);
            this.ImageSizeBoxDoodle.TabIndex = 80;
            this.ImageSizeBoxDoodle.Text = "-1";
            this.ImageSizeBoxDoodle.ValueMember = "512";
            // 
            // TVWeightBoxDoodle
            // 
            this.TVWeightBoxDoodle.Location = new System.Drawing.Point(626, 357);
            this.TVWeightBoxDoodle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TVWeightBoxDoodle.Name = "TVWeightBoxDoodle";
            this.TVWeightBoxDoodle.Size = new System.Drawing.Size(92, 20);
            this.TVWeightBoxDoodle.TabIndex = 78;
            this.TVWeightBoxDoodle.Text = "8.5e-5";
            // 
            // StyleWeightBoxDoodle
            // 
            this.StyleWeightBoxDoodle.Location = new System.Drawing.Point(416, 357);
            this.StyleWeightBoxDoodle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StyleWeightBoxDoodle.Name = "StyleWeightBoxDoodle";
            this.StyleWeightBoxDoodle.Size = new System.Drawing.Size(92, 20);
            this.StyleWeightBoxDoodle.TabIndex = 76;
            this.StyleWeightBoxDoodle.Text = "1.0";
            // 
            // ContentWeightBoxDoodle
            // 
            this.ContentWeightBoxDoodle.Location = new System.Drawing.Point(118, 354);
            this.ContentWeightBoxDoodle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContentWeightBoxDoodle.Name = "ContentWeightBoxDoodle";
            this.ContentWeightBoxDoodle.Size = new System.Drawing.Size(92, 20);
            this.ContentWeightBoxDoodle.TabIndex = 74;
            this.ContentWeightBoxDoodle.Text = "0.1";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(0, 300);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(734, 2);
            this.label13.TabIndex = 69;
            // 
            // DestinationPrefixDoodleLabel
            // 
            this.DestinationPrefixDoodleLabel.AutoSize = true;
            this.DestinationPrefixDoodleLabel.Location = new System.Drawing.Point(108, 268);
            this.DestinationPrefixDoodleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DestinationPrefixDoodleLabel.Name = "DestinationPrefixDoodleLabel";
            this.DestinationPrefixDoodleLabel.Size = new System.Drawing.Size(0, 13);
            this.DestinationPrefixDoodleLabel.TabIndex = 68;
            // 
            // TargetImageMaskDoodleLabel
            // 
            this.TargetImageMaskDoodleLabel.AutoSize = true;
            this.TargetImageMaskDoodleLabel.Location = new System.Drawing.Point(108, 208);
            this.TargetImageMaskDoodleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TargetImageMaskDoodleLabel.Name = "TargetImageMaskDoodleLabel";
            this.TargetImageMaskDoodleLabel.Size = new System.Drawing.Size(0, 13);
            this.TargetImageMaskDoodleLabel.TabIndex = 67;
            // 
            // StyleMaskImageDoodleLabel
            // 
            this.StyleMaskImageDoodleLabel.AutoSize = true;
            this.StyleMaskImageDoodleLabel.Location = new System.Drawing.Point(108, 151);
            this.StyleMaskImageDoodleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StyleMaskImageDoodleLabel.Name = "StyleMaskImageDoodleLabel";
            this.StyleMaskImageDoodleLabel.Size = new System.Drawing.Size(0, 13);
            this.StyleMaskImageDoodleLabel.TabIndex = 64;
            // 
            // StyleImageDoodleLabel
            // 
            this.StyleImageDoodleLabel.AutoSize = true;
            this.StyleImageDoodleLabel.Location = new System.Drawing.Point(108, 91);
            this.StyleImageDoodleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StyleImageDoodleLabel.Name = "StyleImageDoodleLabel";
            this.StyleImageDoodleLabel.Size = new System.Drawing.Size(0, 13);
            this.StyleImageDoodleLabel.TabIndex = 62;
            // 
            // SrcImageDoodleLabel
            // 
            this.SrcImageDoodleLabel.AutoSize = true;
            this.SrcImageDoodleLabel.Location = new System.Drawing.Point(108, 33);
            this.SrcImageDoodleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SrcImageDoodleLabel.Name = "SrcImageDoodleLabel";
            this.SrcImageDoodleLabel.Size = new System.Drawing.Size(0, 13);
            this.SrcImageDoodleLabel.TabIndex = 61;
            // 
            // ColorTransfer
            // 
            this.ColorTransfer.Controls.Add(this.ColorTransferHistMatchCheck);
            this.ColorTransfer.Controls.Add(this.MaskedColorTransferLabel);
            this.ColorTransfer.Controls.Add(this.MaskColorTransferBtn);
            this.ColorTransfer.Controls.Add(this.label23);
            this.ColorTransfer.Controls.Add(this.CopyArgumentsColorTransferBtn);
            this.ColorTransfer.Controls.Add(this.ExecuteColorTransferBtn);
            this.ColorTransfer.Controls.Add(this.GeneratedColorTransferLabel);
            this.ColorTransfer.Controls.Add(this.ContentColorTransferLabel);
            this.ColorTransfer.Controls.Add(this.GeneratedColorTransferBtn);
            this.ColorTransfer.Controls.Add(this.ContentColorTransferBtn);
            this.ColorTransfer.Location = new System.Drawing.Point(4, 22);
            this.ColorTransfer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ColorTransfer.Name = "ColorTransfer";
            this.ColorTransfer.Size = new System.Drawing.Size(728, 667);
            this.ColorTransfer.TabIndex = 2;
            this.ColorTransfer.Text = "Color Transfer";
            this.ColorTransfer.UseVisualStyleBackColor = true;
            // 
            // ColorTransferHistMatchCheck
            // 
            this.ColorTransferHistMatchCheck.AutoSize = true;
            this.ColorTransferHistMatchCheck.Location = new System.Drawing.Point(24, 250);
            this.ColorTransferHistMatchCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ColorTransferHistMatchCheck.Name = "ColorTransferHistMatchCheck";
            this.ColorTransferHistMatchCheck.Size = new System.Drawing.Size(120, 17);
            this.ColorTransferHistMatchCheck.TabIndex = 77;
            this.ColorTransferHistMatchCheck.Text = "Histogram Matching";
            this.ColorTransferHistMatchCheck.UseVisualStyleBackColor = true;
            // 
            // MaskedColorTransferLabel
            // 
            this.MaskedColorTransferLabel.AutoSize = true;
            this.MaskedColorTransferLabel.Location = new System.Drawing.Point(115, 166);
            this.MaskedColorTransferLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaskedColorTransferLabel.Name = "MaskedColorTransferLabel";
            this.MaskedColorTransferLabel.Size = new System.Drawing.Size(0, 13);
            this.MaskedColorTransferLabel.TabIndex = 75;
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Location = new System.Drawing.Point(-3, 223);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(734, 2);
            this.label23.TabIndex = 66;
            // 
            // GeneratedColorTransferLabel
            // 
            this.GeneratedColorTransferLabel.AutoSize = true;
            this.GeneratedColorTransferLabel.Location = new System.Drawing.Point(115, 97);
            this.GeneratedColorTransferLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GeneratedColorTransferLabel.Name = "GeneratedColorTransferLabel";
            this.GeneratedColorTransferLabel.Size = new System.Drawing.Size(0, 13);
            this.GeneratedColorTransferLabel.TabIndex = 43;
            // 
            // ContentColorTransferLabel
            // 
            this.ContentColorTransferLabel.AutoSize = true;
            this.ContentColorTransferLabel.Location = new System.Drawing.Point(115, 30);
            this.ContentColorTransferLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContentColorTransferLabel.Name = "ContentColorTransferLabel";
            this.ContentColorTransferLabel.Size = new System.Drawing.Size(0, 13);
            this.ContentColorTransferLabel.TabIndex = 42;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CopyArgumentsMaskedTransferBtn);
            this.tabPage3.Controls.Add(this.ExecuteMaskedTransferBtn);
            this.tabPage3.Controls.Add(this.MaskedLable);
            this.tabPage3.Controls.Add(this.MaskedImageBtn);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.GeneratedMaskedLabel);
            this.tabPage3.Controls.Add(this.ContentMaskedLabel);
            this.tabPage3.Controls.Add(this.GeneratedImageMaskedBtn);
            this.tabPage3.Controls.Add(this.ContentImageMaskedBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(728, 667);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Masked Transfer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MaskedLable
            // 
            this.MaskedLable.AutoSize = true;
            this.MaskedLable.Location = new System.Drawing.Point(109, 162);
            this.MaskedLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaskedLable.Name = "MaskedLable";
            this.MaskedLable.Size = new System.Drawing.Size(0, 13);
            this.MaskedLable.TabIndex = 73;
            // 
            // label24
            // 
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label24.Location = new System.Drawing.Point(-9, 209);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(734, 2);
            this.label24.TabIndex = 71;
            // 
            // GeneratedMaskedLabel
            // 
            this.GeneratedMaskedLabel.AutoSize = true;
            this.GeneratedMaskedLabel.Location = new System.Drawing.Point(115, 97);
            this.GeneratedMaskedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GeneratedMaskedLabel.Name = "GeneratedMaskedLabel";
            this.GeneratedMaskedLabel.Size = new System.Drawing.Size(0, 13);
            this.GeneratedMaskedLabel.TabIndex = 70;
            // 
            // ContentMaskedLabel
            // 
            this.ContentMaskedLabel.AutoSize = true;
            this.ContentMaskedLabel.Location = new System.Drawing.Point(115, 30);
            this.ContentMaskedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContentMaskedLabel.Name = "ContentMaskedLabel";
            this.ContentMaskedLabel.Size = new System.Drawing.Size(0, 13);
            this.ContentMaskedLabel.TabIndex = 69;
            // 
            // cbCPU
            // 
            this.cbCPU.AutoSize = true;
            this.cbCPU.Checked = true;
            this.cbCPU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCPU.Location = new System.Drawing.Point(565, 255);
            this.cbCPU.Margin = new System.Windows.Forms.Padding(2);
            this.cbCPU.Name = "cbCPU";
            this.cbCPU.Size = new System.Drawing.Size(48, 17);
            this.cbCPU.TabIndex = 84;
            this.cbCPU.Text = "CPU";
            this.SrcToolTip.SetToolTip(this.cbCPU, "Maintain the aspect ratio of output image");
            this.cbCPU.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 693);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neural Art";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ColorTransfer.ResumeLayout(false);
            this.ColorTransfer.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip SrcToolTip;
        private System.Windows.Forms.TextBox MinThresholdText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox PreserveColorBox;
        private System.Windows.Forms.CheckBox NetworkCheckBox;
        private System.Windows.Forms.ComboBox PoolingTypeBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox InitialLayerComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ContentLayerBox;
        private System.Windows.Forms.Button CopyArgumentsBtn;
        private System.Windows.Forms.CheckBox MaintainAspectRatioCheckBox;
        private System.Windows.Forms.ComboBox RescaleAlgoBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox RescaleCheck;
        private System.Windows.Forms.Label DstPathLabel;
        private System.Windows.Forms.Button DstBtn;
        private System.Windows.Forms.TextBox NoOfItersText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StyleScaleText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalVariationWeightText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StyleWeightText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ContentWeightText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ImageSizeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HorizontalLine;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Label StylePathLabel;
        private System.Windows.Forms.Label SrcPathLabel;
        private System.Windows.Forms.Button StyleBtn;
        private System.Windows.Forms.Button SrcBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button StyleMaskDoodle;
        private System.Windows.Forms.Button DestinationPrefixDoodleBtn;
        private System.Windows.Forms.Button StyleImageDoodle;
        private System.Windows.Forms.Button SourceImageDoodle;
        private System.Windows.Forms.Button TargetMaskDoodle;
        private System.Windows.Forms.Label DestinationPrefixDoodleLabel;
        private System.Windows.Forms.Label TargetImageMaskDoodleLabel;
        private System.Windows.Forms.Label StyleMaskImageDoodleLabel;
        private System.Windows.Forms.Label StyleImageDoodleLabel;
        private System.Windows.Forms.Label SrcImageDoodleLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox UseImprovedNetworkDoodle;
        private System.Windows.Forms.CheckBox PreserveColorDoodle;
        private System.Windows.Forms.TextBox TVWeightBoxDoodle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox StyleWeightBoxDoodle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ContentWeightBoxDoodle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox NumIterDoodle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox ImageSizeBoxDoodle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button CopyArgsDoodle;
        private System.Windows.Forms.Button ExecuteDoodle;
        private System.Windows.Forms.TextBox NumColorsText;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox RegionWeightDoodleText;
        private System.Windows.Forms.ComboBox ModelTypeBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox ContentLossTypeBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button MaskImagesBtn;
        private System.Windows.Forms.Label MaskPathLabel;
        private System.Windows.Forms.TabPage ColorTransfer;
        private System.Windows.Forms.Label GeneratedColorTransferLabel;
        private System.Windows.Forms.Label ContentColorTransferLabel;
        private System.Windows.Forms.Button GeneratedColorTransferBtn;
        private System.Windows.Forms.Button ContentColorTransferBtn;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button CopyArgumentsColorTransferBtn;
        private System.Windows.Forms.Button ExecuteColorTransferBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button CopyArgumentsMaskedTransferBtn;
        private System.Windows.Forms.Button ExecuteMaskedTransferBtn;
        private System.Windows.Forms.Label MaskedLable;
        private System.Windows.Forms.Button MaskedImageBtn;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label GeneratedMaskedLabel;
        private System.Windows.Forms.Label ContentMaskedLabel;
        private System.Windows.Forms.Button GeneratedImageMaskedBtn;
        private System.Windows.Forms.Button ContentImageMaskedBtn;
        private System.Windows.Forms.Label MaskedColorTransferLabel;
        private System.Windows.Forms.Button MaskColorTransferBtn;
        private System.Windows.Forms.Label ColorMaskImageLabel;
        private System.Windows.Forms.Button ColorMaskImageBtn;
        private System.Windows.Forms.CheckBox ColorTransferHistMatchCheck;
        private System.Windows.Forms.Label ContentMaskPathLabel;
        private System.Windows.Forms.Button ContentMaskImageBtn;
        private System.Windows.Forms.CheckBox cbCPU;
    }
}

