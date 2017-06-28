using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvViewer
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            LinkedinPicture.Image = Properties.Resources.LinkedIn;
            GithubPicture.Image = Properties.Resources.GitHub;
            Icon = Properties.Resources.Main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void GithubPicture_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/jvorssel/CsvViewer");
        }

        private void LinkedinPicture_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/jeroen-vorsselman-8a6a8249/");
        }
    }
}
