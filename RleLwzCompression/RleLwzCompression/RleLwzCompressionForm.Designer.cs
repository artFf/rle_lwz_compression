namespace RleLwzCompression
{
    partial class RleLwzCompressionForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxLoadedPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxRleDecodePicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxLwzDecodePicture = new System.Windows.Forms.PictureBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelLoadedPictureSize = new System.Windows.Forms.Label();
            this.labelLoadedPicturePath = new System.Windows.Forms.Label();
            this.labelLoadedPictureName = new System.Windows.Forms.Label();
            this.labelPicture = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelLwzEncodeCompression = new System.Windows.Forms.Label();
            this.labelRleEncodeCompression = new System.Windows.Forms.Label();
            this.labelPathToEncodedPicture = new System.Windows.Forms.Label();
            this.labelLwzEncodeSize = new System.Windows.Forms.Label();
            this.labelRleEncodeSize = new System.Windows.Forms.Label();
            this.groupBoxProgresses = new System.Windows.Forms.GroupBox();
            this.progressBarLwzEncode = new System.Windows.Forms.ProgressBar();
            this.progressBarRleEncode = new System.Windows.Forms.ProgressBar();
            this.progressBarLoadPicture = new System.Windows.Forms.ProgressBar();
            this.labelEncodeLwzProgress = new System.Windows.Forms.Label();
            this.labelEncodeRleProgress = new System.Windows.Forms.Label();
            this.labelLoadePictureProgress = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRleDecodePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLwzDecodePicture)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxProgresses.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPictureToolStripMenuItem,
            this.logViewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadPictureToolStripMenuItem
            // 
            this.loadPictureToolStripMenuItem.Name = "loadPictureToolStripMenuItem";
            this.loadPictureToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadPictureToolStripMenuItem.Text = "Load Picture";
            // 
            // logViewToolStripMenuItem
            // 
            this.logViewToolStripMenuItem.Name = "logViewToolStripMenuItem";
            this.logViewToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.logViewToolStripMenuItem.Text = "Log View";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pictureBoxLoadedPicture
            // 
            this.pictureBoxLoadedPicture.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBoxLoadedPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLoadedPicture.Location = new System.Drawing.Point(12, 70);
            this.pictureBoxLoadedPicture.Name = "pictureBoxLoadedPicture";
            this.pictureBoxLoadedPicture.Size = new System.Drawing.Size(299, 234);
            this.pictureBoxLoadedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoadedPicture.TabIndex = 1;
            this.pictureBoxLoadedPicture.TabStop = false;
            // 
            // pictureBoxRleDecodePicture
            // 
            this.pictureBoxRleDecodePicture.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBoxRleDecodePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRleDecodePicture.Location = new System.Drawing.Point(337, 70);
            this.pictureBoxRleDecodePicture.Name = "pictureBoxRleDecodePicture";
            this.pictureBoxRleDecodePicture.Size = new System.Drawing.Size(299, 234);
            this.pictureBoxRleDecodePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRleDecodePicture.TabIndex = 2;
            this.pictureBoxRleDecodePicture.TabStop = false;
            // 
            // pictureBoxLwzDecodePicture
            // 
            this.pictureBoxLwzDecodePicture.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBoxLwzDecodePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLwzDecodePicture.Location = new System.Drawing.Point(667, 70);
            this.pictureBoxLwzDecodePicture.Name = "pictureBoxLwzDecodePicture";
            this.pictureBoxLwzDecodePicture.Size = new System.Drawing.Size(299, 234);
            this.pictureBoxLwzDecodePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLwzDecodePicture.TabIndex = 3;
            this.pictureBoxLwzDecodePicture.TabStop = false;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(104, 515);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonEncode.TabIndex = 4;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(293, 515);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // labelLoadedPictureSize
            // 
            this.labelLoadedPictureSize.AutoSize = true;
            this.labelLoadedPictureSize.Location = new System.Drawing.Point(6, 74);
            this.labelLoadedPictureSize.Name = "labelLoadedPictureSize";
            this.labelLoadedPictureSize.Size = new System.Drawing.Size(148, 16);
            this.labelLoadedPictureSize.TabIndex = 2;
            this.labelLoadedPictureSize.Text = "Loaded picture size:";
            // 
            // labelLoadedPicturePath
            // 
            this.labelLoadedPicturePath.AutoSize = true;
            this.labelLoadedPicturePath.Location = new System.Drawing.Point(6, 47);
            this.labelLoadedPicturePath.Name = "labelLoadedPicturePath";
            this.labelLoadedPicturePath.Size = new System.Drawing.Size(150, 16);
            this.labelLoadedPicturePath.TabIndex = 1;
            this.labelLoadedPicturePath.Text = "Loaded picture path:";
            // 
            // labelLoadedPictureName
            // 
            this.labelLoadedPictureName.AutoSize = true;
            this.labelLoadedPictureName.Location = new System.Drawing.Point(6, 18);
            this.labelLoadedPictureName.Name = "labelLoadedPictureName";
            this.labelLoadedPictureName.Size = new System.Drawing.Size(158, 16);
            this.labelLoadedPictureName.TabIndex = 0;
            this.labelLoadedPictureName.Text = "Loaded picture name:";
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPicture.Location = new System.Drawing.Point(12, 47);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(130, 20);
            this.labelPicture.TabIndex = 8;
            this.labelPicture.Text = "Loaded Picture";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "RLE Decode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(663, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "LWZ Decode";
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(196, 515);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonDecode.TabIndex = 11;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelLoadedPictureSize);
            this.groupBoxInfo.Controls.Add(this.labelLwzEncodeCompression);
            this.groupBoxInfo.Controls.Add(this.labelLoadedPicturePath);
            this.groupBoxInfo.Controls.Add(this.labelRleEncodeCompression);
            this.groupBoxInfo.Controls.Add(this.labelLoadedPictureName);
            this.groupBoxInfo.Controls.Add(this.labelPathToEncodedPicture);
            this.groupBoxInfo.Controls.Add(this.labelLwzEncodeSize);
            this.groupBoxInfo.Controls.Add(this.labelRleEncodeSize);
            this.groupBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfo.Location = new System.Drawing.Point(485, 327);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(481, 233);
            this.groupBoxInfo.TabIndex = 7;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Info";
            // 
            // labelLwzEncodeCompression
            // 
            this.labelLwzEncodeCompression.AutoSize = true;
            this.labelLwzEncodeCompression.Location = new System.Drawing.Point(6, 125);
            this.labelLwzEncodeCompression.Name = "labelLwzEncodeCompression";
            this.labelLwzEncodeCompression.Size = new System.Drawing.Size(210, 16);
            this.labelLwzEncodeCompression.TabIndex = 7;
            this.labelLwzEncodeCompression.Text = "LZW Encode % compression:";
            // 
            // labelRleEncodeCompression
            // 
            this.labelRleEncodeCompression.AutoSize = true;
            this.labelRleEncodeCompression.Location = new System.Drawing.Point(6, 99);
            this.labelRleEncodeCompression.Name = "labelRleEncodeCompression";
            this.labelRleEncodeCompression.Size = new System.Drawing.Size(208, 16);
            this.labelRleEncodeCompression.TabIndex = 6;
            this.labelRleEncodeCompression.Text = "RLE Encode % compression:";
            // 
            // labelPathToEncodedPicture
            // 
            this.labelPathToEncodedPicture.AutoSize = true;
            this.labelPathToEncodedPicture.Location = new System.Drawing.Point(6, 204);
            this.labelPathToEncodedPicture.Name = "labelPathToEncodedPicture";
            this.labelPathToEncodedPicture.Size = new System.Drawing.Size(158, 16);
            this.labelPathToEncodedPicture.TabIndex = 5;
            this.labelPathToEncodedPicture.Text = "Path to encoded files:";
            // 
            // labelLwzEncodeSize
            // 
            this.labelLwzEncodeSize.AutoSize = true;
            this.labelLwzEncodeSize.Location = new System.Drawing.Point(6, 178);
            this.labelLwzEncodeSize.Name = "labelLwzEncodeSize";
            this.labelLwzEncodeSize.Size = new System.Drawing.Size(132, 16);
            this.labelLwzEncodeSize.TabIndex = 4;
            this.labelLwzEncodeSize.Text = "LZW Encode size:";
            // 
            // labelRleEncodeSize
            // 
            this.labelRleEncodeSize.AutoSize = true;
            this.labelRleEncodeSize.Location = new System.Drawing.Point(6, 153);
            this.labelRleEncodeSize.Name = "labelRleEncodeSize";
            this.labelRleEncodeSize.Size = new System.Drawing.Size(130, 16);
            this.labelRleEncodeSize.TabIndex = 3;
            this.labelRleEncodeSize.Text = "RLE Encode size:";
            // 
            // groupBoxProgresses
            // 
            this.groupBoxProgresses.Controls.Add(this.progressBarLwzEncode);
            this.groupBoxProgresses.Controls.Add(this.progressBarRleEncode);
            this.groupBoxProgresses.Controls.Add(this.progressBarLoadPicture);
            this.groupBoxProgresses.Controls.Add(this.labelEncodeLwzProgress);
            this.groupBoxProgresses.Controls.Add(this.labelEncodeRleProgress);
            this.groupBoxProgresses.Controls.Add(this.labelLoadePictureProgress);
            this.groupBoxProgresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProgresses.Location = new System.Drawing.Point(12, 327);
            this.groupBoxProgresses.Name = "groupBoxProgresses";
            this.groupBoxProgresses.Size = new System.Drawing.Size(467, 169);
            this.groupBoxProgresses.TabIndex = 7;
            this.groupBoxProgresses.TabStop = false;
            this.groupBoxProgresses.Text = "Progresses";
            // 
            // progressBarLwzEncode
            // 
            this.progressBarLwzEncode.Location = new System.Drawing.Point(215, 79);
            this.progressBarLwzEncode.Name = "progressBarLwzEncode";
            this.progressBarLwzEncode.Size = new System.Drawing.Size(236, 23);
            this.progressBarLwzEncode.TabIndex = 5;
            // 
            // progressBarRleEncode
            // 
            this.progressBarRleEncode.Location = new System.Drawing.Point(215, 50);
            this.progressBarRleEncode.Name = "progressBarRleEncode";
            this.progressBarRleEncode.Size = new System.Drawing.Size(236, 23);
            this.progressBarRleEncode.TabIndex = 4;
            // 
            // progressBarLoadPicture
            // 
            this.progressBarLoadPicture.Location = new System.Drawing.Point(215, 21);
            this.progressBarLoadPicture.Name = "progressBarLoadPicture";
            this.progressBarLoadPicture.Size = new System.Drawing.Size(236, 23);
            this.progressBarLoadPicture.TabIndex = 3;
            // 
            // labelEncodeLwzProgress
            // 
            this.labelEncodeLwzProgress.AutoSize = true;
            this.labelEncodeLwzProgress.Location = new System.Drawing.Point(4, 86);
            this.labelEncodeLwzProgress.Name = "labelEncodeLwzProgress";
            this.labelEncodeLwzProgress.Size = new System.Drawing.Size(166, 16);
            this.labelEncodeLwzProgress.TabIndex = 2;
            this.labelEncodeLwzProgress.Text = "Encode LWZ progress:";
            // 
            // labelEncodeRleProgress
            // 
            this.labelEncodeRleProgress.AutoSize = true;
            this.labelEncodeRleProgress.Location = new System.Drawing.Point(6, 57);
            this.labelEncodeRleProgress.Name = "labelEncodeRleProgress";
            this.labelEncodeRleProgress.Size = new System.Drawing.Size(164, 16);
            this.labelEncodeRleProgress.TabIndex = 1;
            this.labelEncodeRleProgress.Text = "Encode RLE progress:";
            // 
            // labelLoadePictureProgress
            // 
            this.labelLoadePictureProgress.AutoSize = true;
            this.labelLoadePictureProgress.Location = new System.Drawing.Point(6, 28);
            this.labelLoadePictureProgress.Name = "labelLoadePictureProgress";
            this.labelLoadePictureProgress.Size = new System.Drawing.Size(164, 16);
            this.labelLoadePictureProgress.TabIndex = 0;
            this.labelLoadePictureProgress.Text = "Load picture progress:";
            // 
            // RleLwzCompressionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(979, 567);
            this.Controls.Add(this.groupBoxProgresses);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.pictureBoxLwzDecodePicture);
            this.Controls.Add(this.pictureBoxRleDecodePicture);
            this.Controls.Add(this.pictureBoxLoadedPicture);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(995, 605);
            this.MinimumSize = new System.Drawing.Size(995, 605);
            this.Name = "RleLwzCompressionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RLE LWZ Compression";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRleDecodePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLwzDecodePicture)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxProgresses.ResumeLayout(false);
            this.groupBoxProgresses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxLoadedPicture;
        private System.Windows.Forms.PictureBox pictureBoxRleDecodePicture;
        private System.Windows.Forms.PictureBox pictureBoxLwzDecodePicture;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ToolStripMenuItem logViewToolStripMenuItem;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLoadedPictureSize;
        private System.Windows.Forms.Label labelLoadedPicturePath;
        private System.Windows.Forms.Label labelLoadedPictureName;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelLwzEncodeCompression;
        private System.Windows.Forms.Label labelRleEncodeCompression;
        private System.Windows.Forms.Label labelPathToEncodedPicture;
        private System.Windows.Forms.Label labelLwzEncodeSize;
        private System.Windows.Forms.Label labelRleEncodeSize;
        private System.Windows.Forms.GroupBox groupBoxProgresses;
        private System.Windows.Forms.ProgressBar progressBarLwzEncode;
        private System.Windows.Forms.ProgressBar progressBarRleEncode;
        private System.Windows.Forms.ProgressBar progressBarLoadPicture;
        private System.Windows.Forms.Label labelEncodeLwzProgress;
        private System.Windows.Forms.Label labelEncodeRleProgress;
        private System.Windows.Forms.Label labelLoadePictureProgress;
    }
}

