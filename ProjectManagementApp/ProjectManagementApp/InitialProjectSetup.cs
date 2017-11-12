using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementApp
{
    public partial class InitialProjectSetup : Form
    {
        public InitialProjectSetup()
        {
            InitializeComponent();
        }
        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            if(TeamMemberNewInputBox.Text != "" )
            TeamMembersListBox.Items.Add(TeamMemberNewInputBox.Text);
        }
        private void AddRiskButton_Click(object sender, EventArgs e)
        {

        }
        private void FinishSetupButton_Click(object sender, EventArgs e)
        {

        }
        private void CancelSetupButton_Click(object sender, EventArgs e)
        {

        }
    }
}
