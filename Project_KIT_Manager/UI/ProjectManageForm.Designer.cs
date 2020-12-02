namespace KIT_Manager.UI
{
    partial class ProjectManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManageForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.textBoxSearchByPID = new System.Windows.Forms.TextBox();
            this.toolStripMenuQLNNC = new System.Windows.Forms.ToolStrip();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.labelPDescribe = new System.Windows.Forms.Label();
            this.textBoxSearchByPName = new System.Windows.Forms.TextBox();
            this.labelSearchProjectName = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelProjectID = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxPName = new System.Windows.Forms.TextBox();
            this.labelPLeaderName = new System.Windows.Forms.Label();
            this.textBoxProjectLeaderID = new System.Windows.Forms.TextBox();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.textBoxProjectID = new System.Windows.Forms.TextBox();
            this.textBoxPLeaderName = new System.Windows.Forms.TextBox();
            this.labelProjectLeaderID = new System.Windows.Forms.Label();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStripMenuQLNNC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(25, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "Mã Nhóm:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(365, 44);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(637, 496);
            this.dataGridView.TabIndex = 76;
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(50, 22);
            this.toolStripButtonRefresh.Text = "Refresh";
            this.toolStripButtonRefresh.TextChanged += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // textBoxSearchByPID
            // 
            this.textBoxSearchByPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSearchByPID.Location = new System.Drawing.Point(165, 103);
            this.textBoxSearchByPID.Name = "textBoxSearchByPID";
            this.textBoxSearchByPID.Size = new System.Drawing.Size(153, 23);
            this.textBoxSearchByPID.TabIndex = 77;
            // 
            // toolStripMenuQLNNC
            // 
            this.toolStripMenuQLNNC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuQLNNC.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenuQLNNC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRefresh});
            this.toolStripMenuQLNNC.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenuQLNNC.Name = "toolStripMenuQLNNC";
            this.toolStripMenuQLNNC.Size = new System.Drawing.Size(1025, 25);
            this.toolStripMenuQLNNC.TabIndex = 75;
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNote.Location = new System.Drawing.Point(165, 383);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(153, 123);
            this.richTextBoxNote.TabIndex = 67;
            this.richTextBoxNote.Text = "";
            // 
            // labelPDescribe
            // 
            this.labelPDescribe.AutoSize = true;
            this.labelPDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPDescribe.Location = new System.Drawing.Point(24, 440);
            this.labelPDescribe.Name = "labelPDescribe";
            this.labelPDescribe.Size = new System.Drawing.Size(52, 17);
            this.labelPDescribe.TabIndex = 74;
            this.labelPDescribe.Text = "Mô Tả:";
            // 
            // textBoxSearchByPName
            // 
            this.textBoxSearchByPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSearchByPName.Location = new System.Drawing.Point(165, 74);
            this.textBoxSearchByPName.Name = "textBoxSearchByPName";
            this.textBoxSearchByPName.Size = new System.Drawing.Size(153, 23);
            this.textBoxSearchByPName.TabIndex = 58;
            // 
            // labelSearchProjectName
            // 
            this.labelSearchProjectName.AutoSize = true;
            this.labelSearchProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSearchProjectName.Location = new System.Drawing.Point(24, 76);
            this.labelSearchProjectName.Name = "labelSearchProjectName";
            this.labelSearchProjectName.Size = new System.Drawing.Size(78, 17);
            this.labelSearchProjectName.TabIndex = 73;
            this.labelSearchProjectName.Text = "Tên Nhóm:";
            // 
            // labelSearch
            // 
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSearch.Image = ((System.Drawing.Image)(resources.GetObject("labelSearch.Image")));
            this.labelSearch.Location = new System.Drawing.Point(8, 44);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(265, 26);
            this.labelSearch.TabIndex = 72;
            this.labelSearch.Text = "Tìm Kiếm";
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInfo.Image = ((System.Drawing.Image)(resources.GetObject("labelInfo.Image")));
            this.labelInfo.Location = new System.Drawing.Point(8, 236);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(265, 26);
            this.labelInfo.TabIndex = 71;
            this.labelInfo.Text = "Thông Tin";
            // 
            // buttonModify
            // 
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonModify.Image = ((System.Drawing.Image)(resources.GetObject("buttonModify.Image")));
            this.buttonModify.Location = new System.Drawing.Point(235, 512);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(83, 28);
            this.buttonModify.TabIndex = 70;
            this.buttonModify.Text = "Sửa";
            this.buttonModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(135, 512);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(83, 28);
            this.buttonDelete.TabIndex = 69;
            this.buttonDelete.Text = "Xoá";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelProjectID
            // 
            this.labelProjectID.AutoSize = true;
            this.labelProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelProjectID.Location = new System.Drawing.Point(25, 270);
            this.labelProjectID.Name = "labelProjectID";
            this.labelProjectID.Size = new System.Drawing.Size(52, 17);
            this.labelProjectID.TabIndex = 59;
            this.labelProjectID.Text = "Mã Số:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSubmit.Image = ((System.Drawing.Image)(resources.GetObject("buttonSubmit.Image")));
            this.buttonSubmit.Location = new System.Drawing.Point(31, 512);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(83, 28);
            this.buttonSubmit.TabIndex = 62;
            this.buttonSubmit.Text = "Thêm";
            this.buttonSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxPName
            // 
            this.textBoxPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPName.Location = new System.Drawing.Point(165, 296);
            this.textBoxPName.Name = "textBoxPName";
            this.textBoxPName.Size = new System.Drawing.Size(153, 23);
            this.textBoxPName.TabIndex = 61;
            // 
            // labelPLeaderName
            // 
            this.labelPLeaderName.AutoSize = true;
            this.labelPLeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPLeaderName.Location = new System.Drawing.Point(24, 354);
            this.labelPLeaderName.Name = "labelPLeaderName";
            this.labelPLeaderName.Size = new System.Drawing.Size(128, 17);
            this.labelPLeaderName.TabIndex = 68;
            this.labelPLeaderName.Text = "Tên Nhóm Trưởng:";
            // 
            // textBoxProjectLeaderID
            // 
            this.textBoxProjectLeaderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxProjectLeaderID.Location = new System.Drawing.Point(165, 324);
            this.textBoxProjectLeaderID.Name = "textBoxProjectLeaderID";
            this.textBoxProjectLeaderID.Size = new System.Drawing.Size(153, 23);
            this.textBoxProjectLeaderID.TabIndex = 63;
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelProjectName.Location = new System.Drawing.Point(24, 299);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(78, 17);
            this.labelProjectName.TabIndex = 64;
            this.labelProjectName.Text = "Tên Nhóm:";
            // 
            // textBoxProjectID
            // 
            this.textBoxProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxProjectID.Location = new System.Drawing.Point(165, 267);
            this.textBoxProjectID.Name = "textBoxProjectID";
            this.textBoxProjectID.ReadOnly = true;
            this.textBoxProjectID.Size = new System.Drawing.Size(153, 23);
            this.textBoxProjectID.TabIndex = 60;
            // 
            // textBoxPLeaderName
            // 
            this.textBoxPLeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPLeaderName.Location = new System.Drawing.Point(165, 354);
            this.textBoxPLeaderName.Name = "textBoxPLeaderName";
            this.textBoxPLeaderName.Size = new System.Drawing.Size(153, 23);
            this.textBoxPLeaderName.TabIndex = 65;
            // 
            // labelProjectLeaderID
            // 
            this.labelProjectLeaderID.AutoSize = true;
            this.labelProjectLeaderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelProjectLeaderID.Location = new System.Drawing.Point(24, 327);
            this.labelProjectLeaderID.Name = "labelProjectLeaderID";
            this.labelProjectLeaderID.Size = new System.Drawing.Size(148, 17);
            this.labelProjectLeaderID.TabIndex = 66;
            this.labelProjectLeaderID.Text = "Mã SV Nhóm Trưởng: ";
            // 
            // ProjectManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1025, 563);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxSearchByPID);
            this.Controls.Add(this.toolStripMenuQLNNC);
            this.Controls.Add(this.richTextBoxNote);
            this.Controls.Add(this.labelPDescribe);
            this.Controls.Add(this.textBoxSearchByPName);
            this.Controls.Add(this.labelSearchProjectName);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelProjectID);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxPName);
            this.Controls.Add(this.labelPLeaderName);
            this.Controls.Add(this.textBoxProjectLeaderID);
            this.Controls.Add(this.labelProjectName);
            this.Controls.Add(this.textBoxProjectID);
            this.Controls.Add(this.textBoxPLeaderName);
            this.Controls.Add(this.labelProjectLeaderID);
            this.MaximizeBox = false;
            this.Name = "ProjectManageForm";
            this.Text = "ProjectManageForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStripMenuQLNNC.ResumeLayout(false);
            this.toolStripMenuQLNNC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.TextBox textBoxSearchByPID;
        private System.Windows.Forms.ToolStrip toolStripMenuQLNNC;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.Label labelPDescribe;
        private System.Windows.Forms.TextBox textBoxSearchByPName;
        private System.Windows.Forms.Label labelSearchProjectName;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelProjectID;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxPName;
        private System.Windows.Forms.Label labelPLeaderName;
        private System.Windows.Forms.TextBox textBoxProjectLeaderID;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.TextBox textBoxProjectID;
        private System.Windows.Forms.TextBox textBoxPLeaderName;
        private System.Windows.Forms.Label labelProjectLeaderID;
    }
}