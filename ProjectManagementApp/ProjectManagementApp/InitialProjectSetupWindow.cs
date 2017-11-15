using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementApp
{
    public partial class InitialProjectSetupWindow : UserControl
    {
        private static InitialProjectSetupWindow _instance;

        public static InitialProjectSetupWindow Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InitialProjectSetupWindow();
                return _instance;
            }
        }
        public InitialProjectSetupWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProjectNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProjectManagerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeamMembersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TeamMemberNewInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {

        }

        private void RiskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddRiskTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddRiskButton_Click(object sender, EventArgs e)
        {
            if (TeamMemberNewInputBox.Text != "")
                TeamMembersListBox.Items.Add(TeamMemberNewInputBox.Text);
        }

        private void FinishSetupButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelSetupButton_Click(object sender, EventArgs e)
        {

        }

        private void InitialProjectSetupWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
