using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class SignupForm : Form
    {
        

        public string Username { get; private set; }
        public string Password { get; private set; }
        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }


        private void okButton_Click(object sender, EventArgs e)
        {
            Username = newID.Text;
            Password = newPW.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void newID_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

