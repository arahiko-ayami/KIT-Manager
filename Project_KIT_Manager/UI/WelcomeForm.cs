using System;
using System.Windows.Forms;

namespace Project_KIT_Manager.UI
{
    public partial class WelcomeForm : Form
    {
        private readonly string _windowName = Program.ApplicationName;
        public WelcomeForm()
        {
            InitializeComponent();
            this.Text = _windowName;
        }

        private void quảnLíThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberManageForm memberManageForm = new MemberManageForm() { Visible = true };
        }

        private void quảnLíNhómNghiênCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManageForm projectManageForm = new ProjectManageForm() { Visible = true };
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm(){Visible = true};
        }
    }
}