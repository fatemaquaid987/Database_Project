using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class scout_report_form : Form
    {
        public int unit = 0;
        public string title = "";
        public scout_report_form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult yn = MessageBox.Show("Generate Report?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (yn == DialogResult.Yes)
            {
                scout_report form9 = new scout_report();
                form9.ShowDialog();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            label2.Text = title;
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }
    }
}
