﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KIT_Manager.UI;

namespace KIT_Manager
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void quảnLíThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberManageForm memberManageForm = new MemberManageForm() { Visible = true };
        }

        private void quảnLíNhómNghiênCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManageForm projectManageForm = new ProjectManageForm() { Visible = true };
        }
    }
}