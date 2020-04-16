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
    public partial class BadgeTest : Form
    {
        public string title;
        public int unit;
        public BadgeTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.title == "Shaheen Scouts")
            {
                Proficiency form1 = new Proficiency();
                form1.unit = 1;
                form1.title = "Shaheen Scouts";
                form1.ShowDialog();

            }
            else if (this.title == "Boys Scouts")
            {
                Proficiency form1 = new Proficiency();
                form1.unit = 2;
                form1.title = "Boys Scouts";
                form1.ShowDialog();
            }
            else if (this.title == "Rover Scouts")
            {
                Proficiency form1 = new Proficiency();
                form1.unit = 3;
                form1.title = "Rover Scouts";
                form1.ShowDialog();

            }
        }

        private void BadgeTest_Load(object sender, EventArgs e)
        {
            label3.Text = title;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
