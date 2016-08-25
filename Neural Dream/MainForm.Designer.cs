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
            this.SrcBtn = new System.Windows.Forms.Button();
            this.StyleBtn = new System.Windows.Forms.Button();
            this.SrcPathLabel = new System.Windows.Forms.Label();
            this.StylePathLabel = new System.Windows.Forms.Label();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.HorizontalLine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImageSizeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ContentWeightText = new System.Windows.Forms.TextBox();
            this.StyleWeightText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalVariationWeightText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StyleScaleText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NoOfItersText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.DstBtn = new System.Windows.Forms.Button();
            this.DstPathLabel = new System.Windows.Forms.Label();
            this.RescaleCheck = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RescaleAlgoBox = new System.Windows.Forms.ComboBox();
            this.MaintainAspectRatioCheckBox = new System.Windows.Forms.CheckBox();
            this.CopyArgumentsBtn = new System.Windows.Forms.Button();
            this.ContentLayerBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.InitialLayerComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PoolingTypeBox = new System.Windows.Forms.ComboBox();
            this.SrcToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NetworkCheckBox = new System.Windows.Forms.CheckBox();
            this.PreserveColorBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SrcBtn
            // 
            this.SrcBtn.BackColor = System.Drawing.Color.White;
            this.SrcBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SrcBtn.Location = new System.Drawing.Point(48, 12);
            this.SrcBtn.Name = "SrcBtn";
            this.SrcBtn.Size = new System.Drawing.Size(95, 53);
            this.SrcBtn.TabIndex = 0;
            this.SrcBtn.Text = "Source Image";
            this.SrcToolTip.SetToolTip(this.SrcBtn, "Source Image\r\n");
            this.SrcBtn.UseVisualStyleBackColor = false;
            this.SrcBtn.Click += new System.EventHandler(this.SrcBtnSrcBtn_Click);
            // 
            // StyleBtn
            // 
            this.StyleBtn.BackColor = System.Drawing.Color.White;
            this.StyleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StyleBtn.Location = new System.Drawing.Point(48, 83);
            this.StyleBtn.Name = "StyleBtn";
            this.StyleBtn.Size = new System.Drawing.Size(95, 53);
            this.StyleBtn.TabIndex = 1;
            this.StyleBtn.Text = "Style Image";
            this.SrcToolTip.SetToolTip(this.StyleBtn, "Style Image\r\n");
            this.StyleBtn.UseVisualStyleBackColor = false;
            this.StyleBtn.Click += new System.EventHandler(this.StyleBtn_Click);
            // 
            // SrcPathLabel
            // 
            this.SrcPathLabel.AutoSize = true;
            this.SrcPathLabel.Location = new System.Drawing.Point(163, 48);
            this.SrcPathLabel.Name = "SrcPathLabel";
            this.SrcPathLabel.Size = new System.Drawing.Size(0, 17);
            this.SrcPathLabel.TabIndex = 2;
            // 
            // StylePathLabel
            // 
            this.StylePathLabel.AutoSize = true;
            this.StylePathLabel.Location = new System.Drawing.Point(163, 119);
            this.StylePathLabel.Name = "StylePathLabel";
            this.StylePathLabel.Size = new System.Drawing.Size(0, 17);
            this.StylePathLabel.TabIndex = 3;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BackColor = System.Drawing.Color.White;
            this.ExecuteButton.Location = new System.Drawing.Point(291, 594);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(213, 67);
            this.ExecuteButton.TabIndex = 4;
            this.ExecuteButton.Text = "Compute";
            this.ExecuteButton.UseVisualStyleBackColor = false;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // HorizontalLine
            // 
            this.HorizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorizontalLine.Location = new System.Drawing.Point(2, 271);
            this.HorizontalLine.Name = "HorizontalLine";
            this.HorizontalLine.Size = new System.Drawing.Size(978, 2);
            this.HorizontalLine.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(2, 680);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(978, 2);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Image Size";
            // 
            // ImageSizeBox
            // 
            this.ImageSizeBox.DisplayMember = "512";
            this.ImageSizeBox.FormattingEnabled = true;
            this.ImageSizeBox.Items.AddRange(new object[] {
            "400",
            "512",
            "600"});
            this.ImageSizeBox.Location = new System.Drawing.Point(153, 411);
            this.ImageSizeBox.Name = "ImageSizeBox";
            this.ImageSizeBox.Size = new System.Drawing.Size(121, 24);
            this.ImageSizeBox.TabIndex = 9;
            this.ImageSizeBox.Text = "400";
            this.ImageSizeBox.ValueMember = "512";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Content Weight";
            // 
            // ContentWeightText
            // 
            this.ContentWeightText.Location = new System.Drawing.Point(156, 350);
            this.ContentWeightText.Name = "ContentWeightText";
            this.ContentWeightText.Size = new System.Drawing.Size(121, 22);
            this.ContentWeightText.TabIndex = 11;
            this.ContentWeightText.Text = "0.025";
            // 
            // StyleWeightText
            // 
            this.StyleWeightText.Location = new System.Drawing.Point(462, 355);
            this.StyleWeightText.Name = "StyleWeightText";
            this.StyleWeightText.Size = new System.Drawing.Size(121, 22);
            this.StyleWeightText.TabIndex = 13;
            this.StyleWeightText.Text = "1.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Style Weight";
            // 
            // TotalVariationWeightText
            // 
            this.TotalVariationWeightText.Location = new System.Drawing.Point(801, 358);
            this.TotalVariationWeightText.Name = "TotalVariationWeightText";
            this.TotalVariationWeightText.Size = new System.Drawing.Size(121, 22);
            this.TotalVariationWeightText.TabIndex = 15;
            this.TotalVariationWeightText.Text = "8.5e-5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Variation Weight";
            // 
            // StyleScaleText
            // 
            this.StyleScaleText.Location = new System.Drawing.Point(462, 418);
            this.StyleScaleText.Name = "StyleScaleText";
            this.StyleScaleText.Size = new System.Drawing.Size(121, 22);
            this.StyleScaleText.TabIndex = 17;
            this.StyleScaleText.Text = "1.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Style Scale";
            // 
            // NoOfItersText
            // 
            this.NoOfItersText.Location = new System.Drawing.Point(801, 423);
            this.NoOfItersText.Name = "NoOfItersText";
            this.NoOfItersText.Size = new System.Drawing.Size(121, 22);
            this.NoOfItersText.TabIndex = 19;
            this.NoOfItersText.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(647, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Number Of Iterations";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DstBtn
            // 
            this.DstBtn.BackColor = System.Drawing.Color.White;
            this.DstBtn.Location = new System.Drawing.Point(48, 157);
            this.DstBtn.Name = "DstBtn";
            this.DstBtn.Size = new System.Drawing.Size(95, 53);
            this.DstBtn.TabIndex = 20;
            this.DstBtn.Text = "Destination Image";
            this.DstBtn.UseVisualStyleBackColor = false;
            this.DstBtn.Click += new System.EventHandler(this.DstBtn_Click);
            // 
            // DstPathLabel
            // 
            this.DstPathLabel.AutoSize = true;
            this.DstPathLabel.Location = new System.Drawing.Point(163, 193);
            this.DstPathLabel.Name = "DstPathLabel";
            this.DstPathLabel.Size = new System.Drawing.Size(0, 17);
            this.DstPathLabel.TabIndex = 21;
            // 
            // RescaleCheck
            // 
            this.RescaleCheck.AutoSize = true;
            this.RescaleCheck.Location = new System.Drawing.Point(38, 477);
            this.RescaleCheck.Name = "RescaleCheck";
            this.RescaleCheck.Size = new System.Drawing.Size(229, 21);
            this.RescaleCheck.TabIndex = 23;
            this.RescaleCheck.Text = "Rescale To Original Dimentions";
            this.RescaleCheck.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Rescale Algo";
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
            this.RescaleAlgoBox.Location = new System.Drawing.Point(462, 475);
            this.RescaleAlgoBox.Name = "RescaleAlgoBox";
            this.RescaleAlgoBox.Size = new System.Drawing.Size(121, 24);
            this.RescaleAlgoBox.TabIndex = 25;
            // 
            // MaintainAspectRatioCheckBox
            // 
            this.MaintainAspectRatioCheckBox.AutoSize = true;
            this.MaintainAspectRatioCheckBox.Checked = true;
            this.MaintainAspectRatioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MaintainAspectRatioCheckBox.Location = new System.Drawing.Point(650, 477);
            this.MaintainAspectRatioCheckBox.Name = "MaintainAspectRatioCheckBox";
            this.MaintainAspectRatioCheckBox.Size = new System.Drawing.Size(167, 21);
            this.MaintainAspectRatioCheckBox.TabIndex = 26;
            this.MaintainAspectRatioCheckBox.Text = "Maintain Aspect Ratio";
            this.MaintainAspectRatioCheckBox.UseVisualStyleBackColor = true;
            // 
            // CopyArgumentsBtn
            // 
            this.CopyArgumentsBtn.BackColor = System.Drawing.Color.White;
            this.CopyArgumentsBtn.Location = new System.Drawing.Point(550, 594);
            this.CopyArgumentsBtn.Name = "CopyArgumentsBtn";
            this.CopyArgumentsBtn.Size = new System.Drawing.Size(189, 67);
            this.CopyArgumentsBtn.TabIndex = 27;
            this.CopyArgumentsBtn.Text = "Copy Arguments to Clipboard";
            this.CopyArgumentsBtn.UseVisualStyleBackColor = false;
            this.CopyArgumentsBtn.Click += new System.EventHandler(this.CopyArgumentsBtn_Click);
            // 
            // ContentLayerBox
            // 
            this.ContentLayerBox.BackColor = System.Drawing.Color.White;
            this.ContentLayerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContentLayerBox.FormattingEnabled = true;
            this.ContentLayerBox.Items.AddRange(new object[] {
            "conv5_2",
            "conv4_2"});
            this.ContentLayerBox.Location = new System.Drawing.Point(156, 531);
            this.ContentLayerBox.Name = "ContentLayerBox";
            this.ContentLayerBox.Size = new System.Drawing.Size(121, 24);
            this.ContentLayerBox.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 531);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Content Layer";
            // 
            // InitialLayerComboBox
            // 
            this.InitialLayerComboBox.BackColor = System.Drawing.Color.White;
            this.InitialLayerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InitialLayerComboBox.FormattingEnabled = true;
            this.InitialLayerComboBox.Items.AddRange(new object[] {
            "content",
            "noise"});
            this.InitialLayerComboBox.Location = new System.Drawing.Point(462, 531);
            this.InitialLayerComboBox.Name = "InitialLayerComboBox";
            this.InitialLayerComboBox.Size = new System.Drawing.Size(121, 24);
            this.InitialLayerComboBox.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Initial Layer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(647, 534);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Pooling Type";
            // 
            // PoolingTypeBox
            // 
            this.PoolingTypeBox.BackColor = System.Drawing.Color.White;
            this.PoolingTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PoolingTypeBox.FormattingEnabled = true;
            this.PoolingTypeBox.Items.AddRange(new object[] {
            "max",
            "ave"});
            this.PoolingTypeBox.Location = new System.Drawing.Point(801, 528);
            this.PoolingTypeBox.Name = "PoolingTypeBox";
            this.PoolingTypeBox.Size = new System.Drawing.Size(121, 24);
            this.PoolingTypeBox.TabIndex = 33;
            // 
            // NetworkCheckBox
            // 
            this.NetworkCheckBox.AutoSize = true;
            this.NetworkCheckBox.Checked = true;
            this.NetworkCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NetworkCheckBox.Location = new System.Drawing.Point(41, 299);
            this.NetworkCheckBox.Name = "NetworkCheckBox";
            this.NetworkCheckBox.Size = new System.Drawing.Size(172, 21);
            this.NetworkCheckBox.TabIndex = 34;
            this.NetworkCheckBox.Text = "Use Improved Network";
            this.SrcToolTip.SetToolTip(this.NetworkCheckBox, "If checked, uses the INetwork.py script which is an improved version of the netwo" +
        "rk.\r\nElse, uses the original Network.py script without any improvements.\r\n");
            this.NetworkCheckBox.UseVisualStyleBackColor = true;
            // 
            // PreserveColorBox
            // 
            this.PreserveColorBox.AutoSize = true;
            this.PreserveColorBox.Location = new System.Drawing.Point(347, 299);
            this.PreserveColorBox.Name = "PreserveColorBox";
            this.PreserveColorBox.Size = new System.Drawing.Size(124, 21);
            this.PreserveColorBox.TabIndex = 35;
            this.PreserveColorBox.Text = "Preserve Color";
            this.SrcToolTip.SetToolTip(this.PreserveColorBox, "If checked, uses the INetwork.py script which is an improved version of the netwo" +
        "rk.\r\nElse, uses the original Network.py script without any improvements.\r\n");
            this.PreserveColorBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.PreserveColorBox);
            this.Controls.Add(this.NetworkCheckBox);
            this.Controls.Add(this.PoolingTypeBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.InitialLayerComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ContentLayerBox);
            this.Controls.Add(this.CopyArgumentsBtn);
            this.Controls.Add(this.MaintainAspectRatioCheckBox);
            this.Controls.Add(this.RescaleAlgoBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RescaleCheck);
            this.Controls.Add(this.DstPathLabel);
            this.Controls.Add(this.DstBtn);
            this.Controls.Add(this.NoOfItersText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StyleScaleText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalVariationWeightText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StyleWeightText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContentWeightText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ImageSizeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HorizontalLine);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.StylePathLabel);
            this.Controls.Add(this.SrcPathLabel);
            this.Controls.Add(this.StyleBtn);
            this.Controls.Add(this.SrcBtn);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neural Art";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SrcBtn;
        private System.Windows.Forms.Button StyleBtn;
        private System.Windows.Forms.Label SrcPathLabel;
        private System.Windows.Forms.Label StylePathLabel;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Label HorizontalLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ImageSizeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ContentWeightText;
        private System.Windows.Forms.TextBox StyleWeightText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotalVariationWeightText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StyleScaleText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NoOfItersText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button DstBtn;
        private System.Windows.Forms.Label DstPathLabel;
        private System.Windows.Forms.CheckBox RescaleCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox RescaleAlgoBox;
        private System.Windows.Forms.CheckBox MaintainAspectRatioCheckBox;
        private System.Windows.Forms.Button CopyArgumentsBtn;
        private System.Windows.Forms.ComboBox ContentLayerBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox InitialLayerComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox PoolingTypeBox;
        private System.Windows.Forms.ToolTip SrcToolTip;
        private System.Windows.Forms.CheckBox NetworkCheckBox;
        private System.Windows.Forms.CheckBox PreserveColorBox;
    }
}

