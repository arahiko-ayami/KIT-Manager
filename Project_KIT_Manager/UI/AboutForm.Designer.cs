namespace Project_KIT_Manager.UI
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.picBoxKIT = new System.Windows.Forms.PictureBox();
            this.picBoxMe = new System.Windows.Forms.PictureBox();
            this.labelAppName = new System.Windows.Forms.Label();
            this.labelDev = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMe)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxKIT
            // 
            this.picBoxKIT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxKIT.BackgroundImage")));
            this.picBoxKIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxKIT.Location = new System.Drawing.Point(12, 42);
            this.picBoxKIT.Name = "picBoxKIT";
            this.picBoxKIT.Size = new System.Drawing.Size(80, 80);
            this.picBoxKIT.TabIndex = 0;
            this.picBoxKIT.TabStop = false;
            // 
            // picBoxMe
            // 
            this.picBoxMe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxMe.BackgroundImage")));
            this.picBoxMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxMe.Location = new System.Drawing.Point(98, 42);
            this.picBoxMe.Name = "picBoxMe";
            this.picBoxMe.Size = new System.Drawing.Size(80, 80);
            this.picBoxMe.TabIndex = 1;
            this.picBoxMe.TabStop = false;
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppName.Location = new System.Drawing.Point(218, 55);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(191, 36);
            this.labelAppName.TabIndex = 2;
            this.labelAppName.Text = "KIT Manager";
            // 
            // labelDev
            // 
            this.labelDev.AutoSize = true;
            this.labelDev.Font = new System.Drawing.Font("JetBrains Mono Light", 11F, System.Drawing.FontStyle.Italic);
            this.labelDev.Location = new System.Drawing.Point(185, 91);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(162, 19);
            this.labelDev.TabIndex = 3;
            this.labelDev.Text = "A program made by";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("JetBrains Mono Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(346, 91);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 19);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@Arahiko";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(186, 148);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 183);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelDev);
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.picBoxMe);
            this.Controls.Add(this.picBoxKIT);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxKIT;
        private System.Windows.Forms.PictureBox picBoxMe;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Label labelDev;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button buttonOK;
    }
}