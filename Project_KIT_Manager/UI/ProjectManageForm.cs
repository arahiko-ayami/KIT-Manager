using System;
using System.Linq;
using System.Windows.Forms;
using Project_KIT_Manager.Data;

namespace Project_KIT_Manager.UI
{
    public partial class ProjectManageForm : Form
    {
        public string WindowName = Program.ApplicationName + " - Quản Lí Nhóm Nghiên Cứu";
        MemberDataContext _db = new MemberDataContext();
        private int _oldId;
        private String _oldName;
        private string _nameNotFound = "ID hoặc Tên sinh viên không đúng! Vui lòng kiểm tra lại";

        public ProjectManageForm()
        {
            InitializeComponent();
            this.Text = WindowName;
            LoadData();
        }

        //My methods
        private void LoadData()
        {
            try
            {
                //Load DataGridView
                var result =
                    from s in _db.Projects
                    select new
                    {
                        s.ProjectID,
                        s.ProjectName,
                        s.ProjectLeaderID,
                        s.ProjectLeaderName,
                        s.ProjectDescribe
                    };

                dataGridView.DataSource = result;
                dataGridView.Refresh();
                dataGridView.ClearSelection();
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].HeaderText = "Tên Nhóm";
                dataGridView.Columns[2].HeaderText = "Mã SV Nhóm Trưởng";
                dataGridView.Columns[3].HeaderText = "Nhóm Trưởng";
                dataGridView.Columns[4].HeaderText = "Mô Tả";
                
                    //Resize columns
                for (int i = 1; i < 4; i++)
                {
                    dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }

                dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                //Clear Textboxes
                ClearBoxes();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void ClearBoxes()
        {
            textBoxSearchByPName.Text = string.Empty;
            textBoxPLeaderName.Text = string.Empty;
            textBoxPName.Text = string.Empty;
            textBoxProjectLeaderID.Text = string.Empty;
            textBoxProjectID.Text = string.Empty;
            richTextBoxNote.Text = string.Empty;
        }

        private void AddData()
        {
            var result =
                (from s in _db.Members
                    where s.StudentID == textBoxProjectLeaderID.Text
                    select s).Single();

            if (result.Name.Equals(textBoxPLeaderName.Text))
            {
                try
                {
                    Project prj = new Project()
                    {
                        Member = result,
                        ProjectLeaderID = result.StudentID,
                        ProjectDescribe = richTextBoxNote.Text,
                        ProjectLeaderName = result.Name,
                        ProjectName = textBoxPName.Text
                    };

                    _db.Projects.InsertOnSubmit(prj);
                    _db.SubmitChanges();
                    LoadData();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void Delete(int projectId)
        {
            try
            {
                var result =
                    from s in _db.Projects
                    where s.ProjectID == projectId
                    select s;

                var deleteItems = result.ToList();

                foreach (var deleteItem in deleteItems)
                {
                    _db.Projects.DeleteOnSubmit(deleteItem);
                }

                _db.SubmitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Modify()
        {
            try
            {
                var result =
                    (from s in _db.Projects
                        where s.ProjectID == _oldId
                        select s).SingleOrDefault();

                if (result.ProjectID != Convert.ToInt32(textBoxProjectID.Text))
                {
                    Delete(result.ProjectID);
                    AddData();
                }

                else
                {
                    if (!result.ProjectName.Equals(textBoxPName.Text))
                        result.ProjectName = textBoxPName.Text;

                    if (!result.ProjectLeaderID.Equals(textBoxProjectLeaderID.Text))
                        result.ProjectLeaderID = textBoxProjectLeaderID.Text;

                    if (!result.ProjectLeaderName.Equals(textBoxPLeaderName.Text))
                        result.ProjectLeaderName = textBoxPLeaderName.Text;

                    if (!result.ProjectDescribe.Equals(richTextBoxNote.Text))
                        result.ProjectDescribe = richTextBoxNote.Text;

                    if(!(result.ProjectLeaderID.Equals(textBoxProjectID.Text)))
                    {
                        Delete(result.ProjectID);
                        var member =
                            (from s in _db.Members
                                where s.StudentID == textBoxProjectLeaderID.Text
                                select s).Single();

                        if (member.Name.Equals(textBoxPLeaderName.Text))
                        {
                            try
                            {
                                Project prj = new Project()
                                {
                                    ProjectID = result.ProjectID,
                                    Member = member,
                                    ProjectLeaderID = member.StudentID,
                                    ProjectDescribe = richTextBoxNote.Text,
                                    ProjectLeaderName = member.Name,
                                    ProjectName = textBoxPName.Text
                                };

                                _db.Projects.InsertOnSubmit(prj);
                                _db.SubmitChanges();
                                LoadData();
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show(exception.Message);
                            }
                        }
                    }
                }

                _db.SubmitChanges();
                dataGridView.Refresh();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        //Event
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowNo = e.RowIndex;
            if (rowNo > -1)
            {
                textBoxProjectID.Text = dataGridView.Rows[rowNo].Cells[0].Value.ToString();
                _oldName = textBoxPName.Text = dataGridView.Rows[rowNo].Cells[1].Value.ToString();
                textBoxProjectLeaderID.Text = dataGridView.Rows[rowNo].Cells[2].Value.ToString();
                textBoxPLeaderName.Text = dataGridView.Rows[rowNo].Cells[3].Value.ToString();
                richTextBoxNote.Text = dataGridView.Rows[rowNo].Cells[4].Value.ToString();
                _oldId = Convert.ToInt32(textBoxProjectID.Text);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                AddData();
            }
            catch (Exception)
            {
                MessageBox.Show(_nameNotFound, Program.ApplicationName);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = DialogResult.None;
            if (!textBoxProjectID.Text.Equals(string.Empty))
                confirm = MessageBox.Show("Bạn có muốn xoá nhóm: " + textBoxPName.Text + " không?", "Bạn có chắc chắn?",
                    MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int id = -1;
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        id = Convert.ToInt32(row.Cells[0].Value);
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

        private void buttonModify_Click(object sender, EventArgs e)
        {
            try
            {
                String newInfo = "Thông tin sẽ được sửa thành:"
                                 + "\nTên Nhóm: " + textBoxPName.Text
                                 + "\nMã SV Trưởng Nhóm: " + textBoxProjectLeaderID.Text
                                 + "\nTên Trưởng Nhóm: " + textBoxPLeaderName.Text
                                 + "\nGhi Chú: " + richTextBoxNote.Text;

                DialogResult confirm = DialogResult.None;
                if (!(textBoxPName.Text.Equals(string.Empty) && textBoxPLeaderName.Text.Equals(string.Empty) 
                                                           && textBoxProjectLeaderID.Text.Equals(string.Empty)))
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
    }
}
