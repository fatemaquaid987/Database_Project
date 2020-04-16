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
    public partial class Transfer : Form
    {
        public string title = "";
        public int unit;
        public string name;
        public string gzr;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FADBDTJL\\SQLEXPRESS;Initial Catalog=Gulzar-e-Rahim;Integrated Security=True");
        public Transfer()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        

        private void CancelButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label2.Text = title;
            textBox1.Text = gzr;
            textBox1.Enabled = false;
            Nametextbox.Text = name;
            Nametextbox.Enabled = false;

            comboBox1.Items.Add("Shaheen Scouts");
            comboBox1.Items.Add("Boys Scouts");
            comboBox1.Items.Add("Rover Scouts");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                DialogResult yn = MessageBox.Show("Do you really want to transfer " + name + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                if (yn == DialogResult.Yes)
                {
                    con.Open();
                    string query = "begin transaction " +
                    "update scouts_has_Badges " +
                    "set DateofPassing =@date " +
                    "where Scouts_GZR_no = " + textBox1.Text + " and Unit_idUnit =" + unit.ToString() +

                    " insert into transfer(Unit_idUnit,Scouts_GZR_no, DateOfTransfer) " +
                    "values(" + unit.ToString() + "," + textBox1.Text + ", @date) " +

                    "update Scouts set unit_idUnit = " + (comboBox1.SelectedIndex+1).ToString() + "where gzr_no = " +
                    gzr +

                    " commit";
                    SqlCommand com = new SqlCommand(query, con);
                    
                    com.Parameters.Add(new SqlParameter("@date", dateTimePicker1.Value.Date));
                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
            else
            { MessageBox.Show("You must select a new unit to transfer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
