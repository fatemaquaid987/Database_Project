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
    public partial class passwordChange : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FADBDTJL\\SQLEXPRESS;Initial Catalog=Gulzar-e-Rahim;Integrated Security=True");
        public passwordChange()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0)
            {
                if (textBox2.Text != textBox3.Text)
                { MessageBox.Show("confirmed password is different from new password!"); }
                else
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("update password set string = '" + textBox3.Text + "' where unit_idunit = " + comboBox1.SelectedIndex + 1, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Password updated sucessfully");
                    con.Close();
                }
            }
            else
            { MessageBox.Show("you must eneter a new password!"); }
        }

        private void passwordChange_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Shaheen Scouts");
            comboBox1.Items.Add("Boys Scouts");
            comboBox1.Items.Add("Rover Scouts");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
