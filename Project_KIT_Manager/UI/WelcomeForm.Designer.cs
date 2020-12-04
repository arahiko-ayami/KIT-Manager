namespace KIT_Manager
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownBtnMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.quảnLíThànhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíNhómNghiênCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownBtnMenu,
            this.toolStripButtonAbout});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(337, 25);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "Click Me!";
            // 
            // toolStripDropDownBtnMenu
            // 
            this.toolStripDropDownBtnMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownBtnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíThànhViênToolStripMenuItem,
            this.quảnLíNhómNghiênCứuToolStripMenuItem});
            this.toolStripDropDownBtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownBtnMenu.Image")));
            this.toolStripDropDownBtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownBtnMenu.Name = "toolStripDropDownBtnMenu";
            this.toolStripDropDownBtnMenu.Size = new System.Drawing.Size(80, 22);
            this.toolStripDropDownBtnMenu.Text = "Chức Năng";
            // 
            // quảnLíThànhViênToolStripMenuItem
            // 
            this.quảnLíThànhViênToolStripMenuItem.Name = "quảnLíThànhViênToolStripMenuItem";
            this.quảnLíThànhViênToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.quảnLíThànhViênToolStripMenuItem.Text = "Quản Lí Thành Viên";
            this.quảnLíThànhViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLíThànhViênToolStripMenuItem_Click);
            // 
            // quảnLíNhómNghiênCứuToolStripMenuItem
            // 
            this.quảnLíNhómNghiênCứuToolStripMenuItem.Name = "quảnLíNhómNghiênCứuToolStripMenuItem";
            this.quảnLíNhómNghiênCứuToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.quảnLíNhómNghiênCứuToolStripMenuItem.Text = "Quản Lí Nhóm Nghiên Cứu";
            this.quảnLíNhómNghiênCứuToolStripMenuItem.Click += new System.EventHandler(this.quảnLíNhómNghiênCứuToolStripMenuItem_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonAbout.Text = "About Us!";
            this.toolStripButtonAbout.ToolTipText = "More information about KIT Manager devlopers!";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Pacifico", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(92, 136);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(148, 56);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "Welcome!";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(337, 324);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.toolStripMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownBtnMenu;
        private System.Windows.Forms.ToolStripMenuItem quảnLíThànhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíNhómNghiênCứuToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.Label labelWelcome;
    }
}