using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Project_KIT_Manager.Data;

namespace Project_KIT_Manager.UI
{
    public partial class MemberManageForm : Form
    {
        public string WindowName = Program.ApplicationName + " - Quản Lí Thành Viên";
        readonly MemberDataContext _db = new MemberDataContext();      //Establish the connection
        private String _oldId;
        private String _oldName;

        public MemberManageForm()
        {
            InitializeComponent();
            this.Text = WindowName;
            comboBoxSearchClass.Enabled = false;
            LoadData();
        }

        //My custom methods
        private void LoadData()     //Get data from database
        {
            try
            {
                //Load DataGridView
                var result =
                    from s in _db.Members
                    select s;

                dataGridView.DataSource = result;
                dataGridView.Refresh();
                dataGridView.ClearSelection();
                dataGridView.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                
                    //Resize columns
                    for (int i = 0; i < 6; i++)
                    {
                        dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }

                    dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                //Load ComboBox
                LoadComboBox();

                //Get today's date
                dateTimePicker.MaxDate = DateTime.Today;

                //Clear Textboxes
                ClearBoxes();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void LoadComboBox()     //Get data from database to class combobox
        {
            try
            {
                var result =
                    from s in _db.Members
                    group s by s.Class;

                List<string> cl = new List<string>();

                foreach (var data in result)
                {
                    cl.Add(data.Key.ToString());
                }

                comboBoxSearchClass.DataSource = cl;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void ClearBoxes()
        {
            textBoxStudentID.Text = String.Empty;
            textBoxName.Text = String.Empty;
            textBoxClass.Text = String.Empty;
            textBoxPhoneNum.Text = String.Empty;
            richTextBoxEmail.Text = String.Empty;
            radioButtonFemale.Checked = radioButtonMale.Checked = false;
            dateTimePicker.Value = DateTime.Today;
        }

        private String SetGender()
        {
            if (radioButtonMale.Checked)
                return "Nam";
            else if (radioButtonFemale.Checked)
                return "Nữ";
            else
                return null;
        }

        private void GetGender(string gender)
        {
            if (gender != string.Empty)
            {
                if (radioButtonMale.Text.Equals(gender))
                    radioButtonMale.Checked = true;
                else if (radioButtonFemale.Text.Equals(gender))
                    radioButtonFemale.Checked = true;
            }
        }

        private void QueryByClass()
        {
            var result =
                from s in _db.Members
                where SqlMethods.Like(s.Class, comboBoxSearchClass.SelectedItem.ToString())
                select s;

            dataGridView.DataSource = result;
        }

        private void AddData()
        {
            try
            {
                if (textBoxStudentID.Text != String.Empty && textBoxName.Text != string.Empty)
                {
                    MemberDataContext db = new MemberDataContext();
                    Member newMember = new Member()
                    {
                        StudentID = textBoxStudentID.Text,
                        Name = textBoxName.Text,
                        Birthday = dateTimePicker.Value,
                        Class = textBoxClass.Text,
                        Gender = SetGender(),
                        Email = richTextBoxEmail.Text,
                        PhoneNumber = textBoxPhoneNum.Text
                    };

                    db.Members.InsertOnSubmit(newMember);
                    db.SubmitChanges();
                    LoadData();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Delete(String studentId)
        {
            var result =
                from s in _db.Members
                where s.StudentID == studentId
                select s;

            var deleteItems = result.ToList();

            foreach (var deleteItem in deleteItems)
            {
                _db.Members.DeleteOnSubmit(deleteItem);
            }

            _db.SubmitChanges();
        }

        private void Modify()
        {
            try
            {
                    String gender = radioButtonMale.Checked ? "Nam" : "Nữ";

                    var result =
                        (from s in _db.Members
                            where SqlMethods.Like(s.StudentID, _oldId)
                            select s).SingleOrDefault();

                    if (!result.StudentID.Equals(textBoxStudentID.Text))
                    {
                        Delete(result.StudentID);
                        AddData();
                    }

                    else
                    {
                        //if (!result.Name.Equals(textBoxName.Text))
                            result.Name = textBoxName.Text;

                        //if (!result.Class.Equals(textBoxClass.Text))
                            result.Class = textBoxClass.Text;

                        //if (!result.Birthday.Equals(DateTime.Parse(dateTimePicker.Value.ToString())))
                            result.Birthday = DateTime.Parse(dateTimePicker.Value.ToString());

                        //if (!result.PhoneNumber.Equals(textBoxPhoneNum.Text))
                            result.PhoneNumber = textBoxPhoneNum.Text;

                        //if (!result.Note.Equals(richTextBoxNote.Text))
                            result.Email = richTextBoxEmail.Text;

                        //if (!result.Gender.Equals(gender))
                            result.Gender = gender;
                    }

                    _db.SubmitChanges();
                    //MessageBox.Show("Sửa thành viên thành công!", Program.applicationName);
                    dataGridView.Refresh();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        //Event
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                AddData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowNo = e.RowIndex;
                ClearBoxes();
                if (rowNo > -1)
                {
                    if (dataGridView.Rows[rowNo].Cells[0].Value != null)
                        _oldId = textBoxStudentID.Text = dataGridView.Rows[rowNo].Cells[0].Value.ToString();

                    if (dataGridView.Rows[rowNo].Cells[1].Value != null)
                        _oldName = textBoxName.Text = dataGridView.Rows[rowNo].Cells[1].Value.ToString();

                    if (dataGridView.Rows[rowNo].Cells[2].Value != null)
                        textBoxPhoneNum.Text = dataGridView.Rows[rowNo].Cells[2].Value.ToString();

                    if (dataGridView.Rows[rowNo].Cells[3].Value != null)
                        textBoxClass.Text = dataGridView.Rows[rowNo].Cells[3].Value.ToString();

                    if (dataGridView.Rows[rowNo].Cells[4].Value != null)
                        GetGender(dataGridView.Rows[rowNo].Cells[4].Value.ToString());
                    else
                        radioButtonMale.Checked = radioButtonFemale.Checked = false;

                    if (dataGridView.Rows[rowNo].Cells[5].Value != null)
                        dateTimePicker.Value = DateTime.Parse(dataGridView.Rows[rowNo].Cells[5].Value.ToString());

                    if (dataGridView.Rows[rowNo].Cells[6].Value != null)
                        richTextBoxEmail.Text = dataGridView.Rows[rowNo].Cells[6].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = DialogResult.None;
            if (!textBoxStudentID.Text.Equals(string.Empty))
                confirm = MessageBox.Show("Bạn có muốn xoá " + textBoxName.Text + " không?", "Bạn có chắc chắn?",
                MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    String id = null;
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        id = row.Cells[0].Value.ToString();
                    }
                    Delete(id);
                    MessageBox.Show("Xoá thành công!", Program.ApplicationName);
                    LoadData();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBoxSearchByName_TextChanged(object sender, EventArgs e)
        {
            var result =
                from s in _db.Members
                where SqlMethods.Like(s.Name, "%" + textBoxSearchByName.Text + "%")
                select s;

            dataGridView.DataSource = result;
        }

        private void comboBoxSearchClass_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkBoxFilterClass.Checked)
            {
                dataGridView.ClearSelection();
                QueryByClass();
            }
        }

        private void checkBoxFilterClass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFilterClass.Checked)
            {
                comboBoxSearchClass.Enabled = true;
                QueryByClass();
            }
            else
            {
                comboBoxSearchClass.Enabled = false;
                LoadData();
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            try
            {
                String newInfo = "Thông tin sẽ được sửa thành:"
                                 + "\nMã Sinh Viên: " + textBoxStudentID.Text
                                 + "\nHọ tên: " + textBoxName.Text
                                 + "\nGiới Tính: " + (radioButtonMale.Checked ? "Nam" : "Nữ")
                                 + "\nNgày Sinh: " + dateTimePicker.Value.ToString("dd/MM/yyyy")
                                 + "\nLớp: " + textBoxName.Text
                                 + "\nSố Điện Thoại:" + textBoxPhoneNum.Text
                                 + "\nGhi Chú: " + richTextBoxEmail.Text;

                DialogResult confirm = DialogResult.None;
                if (!textBoxStudentID.Text.Equals(string.Empty))
                    confirm = MessageBox.Show("Bạn có muốn thay đổi " + _oldName + " không?" + "\n" + newInfo,
                        "Bạn có chắc chắn?",
                        MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    Modify();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void MemberManageForm_Shown(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
            ClearBoxes();
        }
    }
}
