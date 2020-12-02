using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_KIT_Manager;
using Project_KIT_Manager.Data;

namespace KIT_Manager.UI
{
    public partial class MemberManageForm : Form
    {
        MemberDataContext db = new MemberDataContext();      //Establish the connection
        private String oldID;
        private String oldName;

        public MemberManageForm()
        {
            InitializeComponent();
            LoadData();
            comboBoxSearchClass.Enabled = false;
        }

        //My custom methods
        private void LoadData()     //Get data from database
        {
            try
            {
                //Load DataGridView
                var result =
                    from s in db.Members
                    select s;

                dataGridView.DataSource = result;
                dataGridView.Refresh();
                dataGridView.ClearSelection();

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
                    from s in db.Members
                    select s.Class;

                comboBoxSearchClass.DataSource = result.ToArray();
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
            richTextBoxNote.Text = String.Empty;
            radioButtonFemale.Checked = radioButtonMale.Checked = false;
            dateTimePicker.Value = DateTime.Today;
        }

        private String setGender()
        {
            if (radioButtonMale.Checked)
                return "Nam";
            else if (radioButtonFemale.Checked)
                return "Nữ";
            else
                return null;
        }

        private void getGender(string gender)
        {
            if (radioButtonMale.Text.Equals(gender))
                radioButtonMale.Checked = true;
            else if (radioButtonFemale.Text.Equals(gender))
                radioButtonFemale.Checked = true;
        }

        private void QueryByClass(string data)
        {
            var result =
                from s in db.Members
                where SqlMethods.Like(s.Class, comboBoxSearchClass.SelectedItem.ToString())
                select s;

            dataGridView.DataSource = result;
        }

        private void AddData()
        {
            MemberDataContext db = new MemberDataContext();
            Member newMember = new Member()
            {
                StudentID = textBoxStudentID.Text,
                Name = textBoxName.Text,
                Birthday = dateTimePicker.Value,
                Class = textBoxClass.Text,
                Gender = setGender(),
                Note = richTextBoxNote.Text,
                PhoneNumber = textBoxPhoneNum.Text
            };

            db.Members.InsertOnSubmit(newMember);
            db.SubmitChanges();
            LoadData();
        }

        private void Delete(String StudentID)
        {
            var result =
                from s in db.Members
                where s.StudentID == StudentID
                select s;

            var deleteItems = result.ToList();

            foreach (var deleteItem in deleteItems)
            {
                db.Members.DeleteOnSubmit(deleteItem);
            }

            db.SubmitChanges();
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
            int rowNo = e.RowIndex;
            if (rowNo > -1)
            {
                oldID = textBoxStudentID.Text = dataGridView.Rows[rowNo].Cells[0].Value.ToString();
                oldName = textBoxName.Text = dataGridView.Rows[rowNo].Cells[1].Value.ToString();
                textBoxPhoneNum.Text = dataGridView.Rows[rowNo].Cells[2].Value.ToString();
                textBoxClass.Text = dataGridView.Rows[rowNo].Cells[3].Value.ToString();
                getGender(dataGridView.Rows[rowNo].Cells[4].Value.ToString());
                dateTimePicker.Value = DateTime.Parse(dataGridView.Rows[rowNo].Cells[5].Value.ToString());
                richTextBoxNote.Text = dataGridView.Rows[rowNo].Cells[6].Value.ToString();
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
                    MessageBox.Show("Xoá thành công!", Program.applicationName);
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
                from s in db.Members
                where SqlMethods.Like(s.Name, "%" + textBoxSearchByName.Text + "%")
                select s;

            dataGridView.DataSource = result;
        }

        private void comboBoxSearchClass_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkBoxFilterClass.Checked)
            {
                QueryByClass(comboBoxSearchClass.SelectedItem.ToString());
            }
        }

        private void checkBoxFilterClass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFilterClass.Checked)
            {
                comboBoxSearchClass.Enabled = true;
                QueryByClass(comboBoxSearchClass.SelectedItem.ToString());
            }
            else
            {
                comboBoxSearchClass.Enabled = false;
                LoadData();
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            String newInfo = "Thông tin sẽ được sửa thành:"
                             + "\nMã Sinh Viên: " + textBoxStudentID.Text
                             + "\nHọ tên: " + textBoxName.Text
                             + "\nGiới Tính: " + (radioButtonMale.Checked ? "Nam" : "Nữ")
                             + "\nNgày Sinh: " + dateTimePicker.Value.ToString("dd/MM/yyyy")
                             + "\nLớp: " + textBoxName.Text
                             + "\nSố Điện Thoại:" + textBoxPhoneNum.Text
                             + "\nGhi Chú: " + richTextBoxNote.Text;

            DialogResult confirm = DialogResult.None;
            if (!textBoxStudentID.Text.Equals(string.Empty))
                confirm = MessageBox.Show("Bạn có muốn thay đổi " + oldName + " không?" + "\n" + newInfo, "Bạn có chắc chắn?",
                    MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    String gender = radioButtonMale.Checked ? "Nam" : "Nữ";

                    var result =
                        (from s in db.Members
                         where SqlMethods.Like(s.StudentID, oldID)
                         select s).SingleOrDefault();

                    if (!result.StudentID.Equals(textBoxStudentID.Text))
                    {
                        Delete(result.StudentID);
                        AddData();
                    }

                    else
                    {
                        if (!result.Name.Equals(textBoxName.Text))
                            result.Name = textBoxName.Text;

                        if (!result.Class.Equals(textBoxClass.Text))
                            result.Class = textBoxClass.Text;

                        if (!result.Birthday.Equals(DateTime.Parse(dateTimePicker.Value.ToString())))
                            result.Birthday = DateTime.Parse(dateTimePicker.Value.ToString());

                        if (!result.PhoneNumber.Equals(textBoxPhoneNum.Text))
                            result.PhoneNumber = textBoxPhoneNum.Text;

                        if (!result.Note.Equals(richTextBoxNote.Text))
                            result.Note = richTextBoxNote.Text;

                        if (!result.Gender.Equals(gender))
                            result.Gender = gender;
                    }

                    db.SubmitChanges();
                    MessageBox.Show("Sửa thành viên thành công!", Program.applicationName);
                    LoadData();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
