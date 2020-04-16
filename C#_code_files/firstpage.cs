using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class firstpage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FADBDTJL\\SQLEXPRESS;Initial Catalog=Gulzar-e-Rahim;Integrated Security=True");
        public string password;
        public firstpage()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string p = "";
            SqlCommand com = new SqlCommand("select string from password where unit_idUnit = "+ comboBox1.SelectedIndex+1 , con);
            using (SqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {
                    p = (string)reader["string"];
                }


                if ((comboBox1.SelectedIndex == 2) && (maskedTextBox1.Text == p))
                {
                    searchform form2 = new searchform();
                    form2.Text = "Rover ";
                    form2.title = "Rover Scouts";
                    form2.ShowDialog();
                }
                else if ((comboBox1.SelectedIndex == 1) && (maskedTextBox1.Text == p))
                {
                    searchform form2 = new searchform();
                    form2.Text = "Boys ";
                    form2.title = "Boys Scouts";
                    form2.ShowDialog();
                }
                else if ((comboBox1.SelectedIndex == 0) && (maskedTextBox1.Text == p))
                {
                    searchform form2 = new searchform();
                    form2.Text = "Shaheen ";
                    form2.title = "Shaheen Scouts";
                    form2.ShowDialog();
                }
            }
            con.Close();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Shaheen Scouts");
            comboBox1.Items.Add("Boys Scouts");
            comboBox1.Items.Add("Rover Scouts");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            passwordChange pc = new passwordChange();
            pc.ShowDialog();
        }
    }
}
