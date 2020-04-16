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
    public partial class nomination : Form
    {
        public string title;
        public int unit;
        public string badge1;
        public string badge2;

        public nomination()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RB1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label1.Text = title;
            RB2.Text = badge2;
            RB1.Text = badge1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            DialogResult yn = MessageBox.Show("Create Nomination?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (yn == DialogResult.Yes)
            {
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
