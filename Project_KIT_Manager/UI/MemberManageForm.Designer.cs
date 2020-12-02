namespace KIT_Manager.UI
{
    partial class MemberManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberManageForm));
            this.labelFilter = new System.Windows.Forms.Label();
            this.checkBoxFilterClass = new System.Windows.Forms.CheckBox();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.comboBoxSearchClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearchByName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.toolStripMenuQLTV = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.labelPhoneNum = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStripMenuQLTV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFilter
            // 
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFilter.Image = ((System.Drawing.Image)(resources.GetObject("labelFilter.Image")));
            this.labelFilter.Location = new System.Drawing.Point(20, 129);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(265, 26);
            this.labelFilter.TabIndex = 55;
            this.labelFilter.Text = "Lọc Theo";
            // 
            // checkBoxFilterClass
            // 
            this.checkBoxFilterClass.AutoSize = true;
            this.checkBoxFilterClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxFilterClass.Location = new System.Drawing.Point(25, 166);
            this.checkBoxFilterClass.Name = "checkBoxFilterClass";
            this.checkBoxFilterClass.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFilterClass.TabIndex = 54;
            this.checkBoxFilterClass.UseVisualStyleBackColor = true;
            this.checkBoxFilterClass.CheckedChanged += new System.EventHandler(this.checkBoxFilterClass_CheckedChanged);
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNote.Location = new System.Drawing.Point(149, 433);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(153, 60);
            this.richTextBoxNote.TabIndex = 41;
            this.richTextBoxNote.Text = "";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNote.Location = new System.Drawing.Point(40, 453);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(63, 17);
            this.labelNote.TabIndex = 53;
            this.labelNote.Text = "Ghi Chú:";
            // 
            // comboBoxSearchClass
            // 
            this.comboBoxSearchClass.FormattingEnabled = true;
            this.comboBoxSearchClass.Location = new System.Drawing.Point(148, 164);
            this.comboBoxSearchClass.Name = "comboBoxSearchClass";
            this.comboBoxSearchClass.Size = new System.Drawing.Size(153, 21);
            this.comboBoxSearchClass.TabIndex = 31;
            this.comboBoxSearchClass.SelectedValueChanged += new System.EventHandler(this.comboBoxSearchClass_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(39, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Lớp:";
            // 
            // textBoxSearchByName
            // 
            this.textBoxSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSearchByName.Location = new System.Drawing.Point(148, 69);
            this.textBoxSearchByName.Name = "textBoxSearchByName";
            this.textBoxSearchByName.Size = new System.Drawing.Size(153, 23);
            this.textBoxSearchByName.TabIndex = 29;
            this.textBoxSearchByName.TextChanged += new System.EventHandler(this.textBoxSearchByName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Họ Tên:";
            // 
            // labelSearch
            // 
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSearch.Image = ((System.Drawing.Image)(resources.GetObject("labelSearch.Image")));
            this.labelSearch.Location = new System.Drawing.Point(20, 40);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(265, 26);
            this.labelSearch.TabIndex = 50;
            this.labelSearch.Text = "Tìm Kiếm";
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInfo.Image = ((System.Drawing.Image)(resources.GetObject("labelInfo.Image")));
            this.labelInfo.Location = new System.Drawing.Point(20, 227);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(265, 26);
            this.labelInfo.TabIndex = 49;
            this.labelInfo.Text = "Thông Tin";
            // 
            // buttonModify
            // 
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonModify.Image = ((System.Drawing.Image)(resources.GetObject("buttonModify.Image")));
            this.buttonModify.Location = new System.Drawing.Point(219, 503);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(83, 28);
            this.buttonModify.TabIndex = 45;
            this.buttonModify.Text = "Sửa";
            this.buttonModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(131, 503);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(83, 28);
            this.buttonDelete.TabIndex = 44;
            this.buttonDelete.Text = "Xoá";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(353, 40);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(637, 496);
            this.dataGridView.TabIndex = 48;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(149, 315);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(153, 22);
            this.dateTimePicker.TabIndex = 34;
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelStudentID.Location = new System.Drawing.Point(40, 261);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(95, 17);
            this.labelStudentID.TabIndex = 30;
            this.labelStudentID.Text = "Mã Sinh Viên:";
            // 
            // toolStripMenuQLTV
            // 
            this.toolStripMenuQLTV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuQLTV.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenuQLTV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRefresh});
            this.toolStripMenuQLTV.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenuQLTV.Name = "toolStripMenuQLTV";
            this.toolStripMenuQLTV.Size = new System.Drawing.Size(1002, 25);
            this.toolStripMenuQLTV.TabIndex = 28;
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(50, 22);
            this.toolStripButtonRefresh.Text = "Refresh";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelName.Location = new System.Drawing.Point(39, 290);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 17);
            this.labelName.TabIndex = 36;
            this.labelName.Text = "Họ Tên:";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxStudentID.Location = new System.Drawing.Point(148, 258);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(153, 23);
            this.textBoxStudentID.TabIndex = 32;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelGender.Location = new System.Drawing.Point(40, 377);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(69, 17);
            this.labelGender.TabIndex = 47;
            this.labelGender.Text = "Giới Tính:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSubmit.Image = ((System.Drawing.Image)(resources.GetObject("buttonSubmit.Image")));
            this.buttonSubmit.Location = new System.Drawing.Point(43, 503);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(83, 28);
            this.buttonSubmit.TabIndex = 43;
            this.buttonSubmit.Text = "Thêm";
            this.buttonSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxName.Location = new System.Drawing.Point(148, 287);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(153, 23);
            this.textBoxName.TabIndex = 33;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelBirthday.Location = new System.Drawing.Point(40, 317);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(77, 17);
            this.labelBirthday.TabIndex = 46;
            this.labelBirthday.Text = "Ngày Sinh:";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonMale.Location = new System.Drawing.Point(149, 374);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(55, 21);
            this.radioButtonMale.TabIndex = 37;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Nam";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonFemale.Location = new System.Drawing.Point(210, 373);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(44, 21);
            this.radioButtonFemale.TabIndex = 39;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Nữ";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // labelPhoneNum
            // 
            this.labelPhoneNum.AutoSize = true;
            this.labelPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPhoneNum.Location = new System.Drawing.Point(40, 407);
            this.labelPhoneNum.Name = "labelPhoneNum";
            this.labelPhoneNum.Size = new System.Drawing.Size(102, 17);
            this.labelPhoneNum.TabIndex = 42;
            this.labelPhoneNum.Text = "Số Điện Thoại:";
            // 
            // textBoxClass
            // 
            this.textBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxClass.Location = new System.Drawing.Point(149, 343);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(153, 23);
            this.textBoxClass.TabIndex = 35;
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPhoneNum.Location = new System.Drawing.Point(149, 404);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(153, 23);
            this.textBoxPhoneNum.TabIndex = 40;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelClass.Location = new System.Drawing.Point(40, 346);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(36, 17);
            this.labelClass.TabIndex = 38;
            this.labelClass.Text = "Lớp:";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            // 
            // MemberManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1002, 563);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.checkBoxFilterClass);
            this.Controls.Add(this.richTextBoxNote);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.comboBoxSearchClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSearchByName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.toolStripMenuQLTV);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.labelPhoneNum);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.textBoxPhoneNum);
            this.Controls.Add(this.labelClass);
            this.MaximizeBox = false;
            this.Name = "MemberManageForm";
            this.Text = "MemberManageForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStripMenuQLTV.ResumeLayout(false);
            this.toolStripMenuQLTV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.CheckBox checkBoxFilterClass;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.ComboBox comboBoxSearchClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearchByName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.ToolStrip toolStripMenuQLTV;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label labelPhoneNum;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.Label labelClass;
    }
}