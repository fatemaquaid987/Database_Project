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
    public partial class new_admission : Form
    {
        public int unit;
        public string title;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FADBDTJL\\SQLEXPRESS;Initial Catalog=Gulzar-e-Rahim;Integrated Security=True");
        public new_admission()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label35.Text = title;
            comboBox2.Items.Add("A+");
            comboBox2.Items.Add("A-");
            comboBox2.Items.Add("B+");
            comboBox2.Items.Add("B-");
            comboBox2.Items.Add("AB+");
            comboBox2.Items.Add("AB-");
            comboBox2.Items.Add("O+");
            comboBox2.Items.Add("O-");
            textBox9.Enabled = false;
            groupBox1.Enabled = false;
            groupBox3.Enabled = false;
            groupBox5.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            string name = textBox1.Text;
            string fname = textBox3.Text;
            string email = textBox4.Text;
            string cnic = textBox5.Text;
            string cont = textBox6.Text;
            string bg = comboBox2.SelectedItem.ToString();
            string ad = textBox8.Text;
            string gzr = textBox17.Text;
            string idbsa = textBox18.Text;
            DialogResult yn = MessageBox.Show("Add new scout " + name+ "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (yn == DialogResult.Yes)
            {
                string query = "Set IDENTITY_INSERT Scouts ON Insert into scouts(GZR_no, name,fathername, IDBSA, DateOFBirth, Post, DateOFJoining," +
                " Unit_idUnit, email, cnic, contactNum, residentialAddress, bloodgroup) values (" +
                gzr + ", '" + name + "' , '" + fname + "' ," + idbsa + ", @date1 ,  's' , @date2  ,"
                + this.unit + ", '" + email + "' ," + cnic + " , " + cont + ", '" + ad + "' , '" + bg + "' )";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.Add(new SqlParameter("@date1", dateTimePicker15.Value.Date));
                command.Parameters.Add(new SqlParameter("@date2", dateTimePicker16.Value.Date));

                if (checkBox1.Checked)
                {
                    if (checkBox4.Checked)
                    {
                        string query2 = "Insert into Scouts_has_Badges values(" + gzr + ", 1, 1, @date3)";
                        SqlCommand command2 = new SqlCommand(query, con);
                        command2.Parameters.Add(new SqlParameter("@date3", dateTimePicker1.Value.Date));
                    }
                    if (checkBox5.Checked)
                    {
                        string query2 = "Insert into Scouts_has_Badges values(" + gzr + ", 2, 1, @date3)";
                        SqlCommand command2 = new SqlCommand(query, con);
                        command2.Parameters.Add(new SqlParameter("@date3", dateTimePicker2.Value.Date));
                    }
                    if (checkBox6.Checked)
                    {
                        string query2 = "Insert into Scouts_has_Badges values(" + gzr + ", 3, 1, @date3)";
                        SqlCommand command2 = new SqlCommand(query, con);
                        command2.Parameters.Add(new SqlParameter("@date3", dateTimePicker3.Value.Date));
                    }
                    if (checkBox7.Checked)
                    {
                        string query2 = "Insert into Scouts_has_Badges values(" + gzr + ", 4, 1, @date3)";
                        SqlCommand command2 = new SqlCommand(query, con);
                        command2.Parameters.Add(new SqlParameter("@date3", dateTimePicker4.Value.Date));
                    }
                    if (checkBox8.Checked)
                    {
                        string query2 = "Insert into Scouts_has_Badges values(" + gzr + ", 5, 1, @date3)";
                        SqlCommand command2 = new SqlCommand(query, con);
                        command2.Parameters.Add(new SqlParameter("@date3", dateTimePicker5.Value.Date));
                    }
                    if (checkBox9.Checked)
                    {
                        string query2 = "Insert into Scouts_has_Badges values(" + gzr + ", 6, 2, @date3)";
                        SqlCommand command2 = new SqlCommand(query, con);
                        command2.Parameters.Add(new SqlParameter("@date3", dateTimePicker6.Value.Date));
                    }
                    if (checkBox10.Checked)
                    {
                        string query2 = "Insert into Scouts_has_Badges values(" + gzr + ", 7, 2, @date3)";
                        SqlCommand command2 = new SqlCommand(query, con);
                        command2.Parameters.Add(new SqlParameter("@date3", dateTimePicker7.Value.Date));
                    }
                    if (checkBox11.Checked)
                    {
                        string query2 = "Insert into Scouts_has_Badges values(" + gzr + ", 8, 2, @date3)";
                        SqlCommand command2 = new SqlCommand(query, con);
                        command2.Parameters.Add(new SqlParameter("@date3", dateTimePicker8.Value.Date));
                    }
                    if (checkBox12.Checked)
                    {
                        string query2 = "Insert into Scouts_has_Badges values(" + gzr + ", 9, 2, @date3)";
                        SqlCommand command2 = new SqlCommand(query, con);
                        command2.Parameters.Add(new SqlParameter("@date3", dateTimePicker9.Value.Date));
                    }
                    if (checkBox13.Checked)
                    {
                        string query2 = "Insert into Scouts_has_Badges values(" + gzr + ", 10, 2, @date3)";
                        SqlCommand command2 = new SqlCommand(query, con);
                        command2.Parameters.Add(new SqlParameter("@date3", dateTimePicker10.Value.Date));
                    }
                    if (checkBox14.Checked)
                    {
                        string query2 = "Insert into Scouts_has_Badges values(" + gzr + ", 11, 3, @date3)";
                        SqlCommand command2 = new SqlCommand(query, con);
                        command2.Parameters.Add(new SqlParameter("@date3", dateTimePicker11.Value.Date));
                    }
                    if (checkBox15.Checked)
                    {
                        string query2 = "Insert into Scouts_has_Badges values(" + gzr + ", 12, 3, @date3)";
                        SqlCommand command2 = new SqlCommand(query, con);
                        command2.Parameters.Add(new SqlParameter("@date3", dateTimePicker12.Value.Date));
                    }
                    if (checkBox16.Checked)
                    {
                        string query2 = "Insert into Scouts_has_Badges values(" + gzr + ", 13, 3, @date3)";
                        SqlCommand command2 = new SqlCommand(query, con);
                        command2.Parameters.Add(new SqlParameter("@date3", dateTimePicker13.Value.Date));
                    }
                    if (checkBox17.Checked)
                    {
                        string query2 = "Insert into Scouts_has_Badges values(" + gzr + ", 14, 3, @date3)";
                        SqlCommand command2 = new SqlCommand(query, con);
                        command2.Parameters.Add(new SqlParameter("@date3", dateTimePicker14.Value.Date));
                    }

                }
                int flag = command.ExecuteNonQuery();

                con.Close();
                this.Close();
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox9.Enabled = true;
                groupBox1.Enabled = true;
                groupBox3.Enabled = true;
                groupBox5.Enabled = true;
            }
            else
            {
                textBox9.Enabled = false;
                groupBox1.Enabled = false;
                groupBox3.Enabled = false;
                groupBox5.Enabled = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker14_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker8_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
