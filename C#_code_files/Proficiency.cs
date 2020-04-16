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
    public partial class Proficiency : Form
    {
        public int unit;
        public string title = "";
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FADBDTJL\\SQLEXPRESS;Initial Catalog=Gulzar-e-Rahim;Integrated Security=True");
        public Proficiency()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Proficiency_Load(object sender, EventArgs e)
        {
            label3.Text = title;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length > 0) && (dataGridView1.Rows.Count>1))
            {
                con.Open();
                
                DialogResult yn = MessageBox.Show("Add this Badge " + textBox1.Text+ " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                if (yn == DialogResult.Yes)
                {
                    
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            string g = row.Cells[0].Value.ToString();
                            //string a = row.Cells[1].Value.ToString();

                            SqlCommand command = new SqlCommand("if ((" + g + " not in (select Scouts_GZR_no from scouts_has_badges where badges_idbadges= "+ textBox1.Text + ")) or" +
                        "( " +textBox1.Text + " not in (select badges_idbadges from scouts_has_badges where  Scouts_GZR_no = " + g + ")))" + 
                        "begin insert into Scouts_has_Badges(Badges_idbadges, scouts_GZR_no, Unit_idUnit, DateOfPassing)" +
                                "values("+textBox1.Text +" , " + g +  "," + unit + ", @date1) end ", con);
                            command.Parameters.Add(new SqlParameter("@date1", dateTimePicker1.Value.Date));
                            int flag2 = command.ExecuteNonQuery();

                        }
                    }
                }
                con.Close();
            }
           else
            { MessageBox.Show("You must enter a scout name and badge! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
