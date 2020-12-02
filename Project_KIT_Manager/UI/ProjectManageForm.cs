using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_KIT_Manager;
using Project_KIT_Manager.Data;

namespace KIT_Manager.UI
{
    public partial class ProjectManageForm : Form
    {
        MemberDataContext db = new MemberDataContext();
        private string _nameNotFound = "ID hoặc Tên sinh viên không đúng! Vui lòng kiểm tra lại";

        public ProjectManageForm()
        {
            InitializeComponent();
            LoadData();
        }

        //My methods
        private void LoadData()
        {
            try
            {
                //Load DataGridView
                var result =
                    from s in db.Projects
                    select s;

                dataGridView.DataSource = result;
                dataGridView.Refresh();
                dataGridView.ClearSelection();

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
            textBoxSearchByPID.Text = string.Empty;
            textBoxPLeaderName.Text = string.Empty;
            textBoxPName.Text = string.Empty;
            textBoxProjectLeaderID.Text = string.Empty;
            textBoxProjectID.Text = string.Empty;
            richTextBoxNote.Text = string.Empty;
        }

        //Event
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
