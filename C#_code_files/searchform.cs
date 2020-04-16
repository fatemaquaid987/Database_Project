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
    public partial class searchform : Form

    {
        public string title;
        public int unit;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FADBDTJL\\SQLEXPRESS;Initial Catalog=Gulzar-e-Rahim;Integrated Security=True");
        SqlDataAdapter adapter;
        DataSet dt;
        public searchform()
        {
            InitializeComponent();
            title = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.title == "Shaheen Scouts")
            {
                attendance form4 = new attendance();
                form4.title = "Shaheen Scouts";
                form4.unit = 1;
                form4.ShowDialog();

            }
            else if (this.title == "Boys Scouts")
            {
                attendance form4 = new attendance();
                form4.title = "Boys Scouts";
                form4.unit = 2;
                form4.ShowDialog();

            }
            else if (this.title == "Rover Scouts")
            {
                attendance form4 = new attendance();
                form4.title = "Rover Scouts";
                form4.unit = 3;
                form4.ShowDialog();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (this.title == "Shaheen Scouts")
                {
                    Transfer form5 = new Transfer();
                    form5.title = "Shaheen Scouts";
                    form5.unit = 1;
                    string gzr = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    form5.gzr = gzr;
                    form5.name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    form5.ShowDialog();


                }
                else if (this.title == "Boys Scouts")
                {
                    Transfer form5 = new Transfer();
                    form5.title = "Boys Scouts";
                    form5.unit = 2;
                    string gzr = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    form5.gzr = gzr;
                    form5.name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    form5.ShowDialog();

                }
                else if (this.title == "Rover Scouts")
                {
                    Transfer form5 = new Transfer();
                    form5.title = "Rover Scouts";
                    form5.unit = 3;
                    string gzr = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    form5.gzr = gzr;
                    form5.name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    form5.ShowDialog();

                }
            }
            else
            { MessageBox.Show("You must select a scouts row in order to transfer! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.title == "Shaheen Scouts")
            {
                new_admission Form6 = new new_admission();
                Form6.unit = 1;
                Form6.title = "Shaheen Scouts";
                Form6.ShowDialog();

            }
            else if (this.title == "Boys Scouts")
            {
                new_admission Form6 = new new_admission();
                Form6.unit = 2;
                Form6.title = "Boys Scouts";
                Form6.ShowDialog();

            }
            else if (this.title == "Rover Scouts")
            {
                new_admission Form6 = new new_admission();
                Form6.unit = 3;
                Form6.title = "Rover Scouts";
                Form6.ShowDialog();

            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = title;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.title == "Shaheen Scouts")
            {
                nomination form7 = new nomination();
                form7.title = "Shaheen Scouts";
                form7.unit = 1;
                form7.badge1 = "Teesra Sitaara";
                form7.badge2 = "Allama Iqbal";
                form7.ShowDialog();

            }
            else if (this.title == "Boys Scouts")
            {
                nomination form7 = new nomination();
                form7.title = "Boys Scouts";
                form7.unit = 2;
                form7.badge1 = "Yaqeen";
                form7.badge2 = "Quaid-e-Azam";
                form7.ShowDialog();

            }
            else if (this.title == "Rover Scouts")
            {
                nomination form7 = new nomination();
                form7.title = "Rover Scouts";
                form7.unit = 3;
                form7.badge1 = "Istaqlal";
                form7.badge2 = "PRS";
                form7.ShowDialog();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = title;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult yn = MessageBox.Show("Do you want to edit selected scouts information? " + textBox3.Text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                if (yn == DialogResult.Yes)
                {
                    SqlCommandBuilder cmbd = new SqlCommandBuilder(adapter);
                    adapter.Update(dt, "Scouts");
                }
            }
            else
            { MessageBox.Show("You must select a row in order to edit information! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (this.title == "Shaheen Scouts")
            {
                FeeRecord Fee = new FeeRecord();
                Fee.unit = 1;
                Fee.title = "Shaheen Scouts";
                Fee.ShowDialog();

            }
            else if (this.title == "Boys Scouts")
            {
                FeeRecord Fee = new FeeRecord();
                Fee.unit = 2;
                Fee.title = "boys Scouts";
                Fee.ShowDialog();

            }
            else if (this.title == "Rover Scouts")
            {
                FeeRecord Fee = new FeeRecord();
                Fee.unit = 3;
                Fee.title = "Rover Scouts";
                Fee.ShowDialog();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            con.Open();

            string name = textBox2.Text;
            string fname = textBox3.Text;
            string gzr = textBox1.Text;
            string cnic = textBox4.Text;
            string idbsa = textBox5.Text;
            if (gzr == "")
            { gzr = "-1"; }
            if (name == "")
            { name = " "; }
            if (fname == "")
            { fname = " "; }
            if (cnic == "")
            { cnic = "-1"; }
            if (idbsa == "")
            { idbsa = "-1"; }

            string query = "Select * from scouts where GZR_no = " + gzr +
              " or name = '" + name + "' or fathername= '" + fname + "' or CNIC = " + cnic +
              " or IDBSA = " + idbsa + " and unit_idUnit = "+ unit;


            SqlCommand com = new SqlCommand(query, con);
            /*using (SqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {
                    listBox1.Items.Add((string)reader["Name"]);
                }
            }*/
            dt = new System.Data.DataSet();
            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt, "Scouts");
            dataGridView1.DataSource = dt.Tables[0];
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            if (this.title == "Shaheen Scouts")
            {
                Camp camp = new Camp();
                camp.unit = 1;
                camp.title = "Shaheen Scouts";
                camp.ShowDialog();
               
                

            }
            else if (this.title == "Boys Scouts")
            {
                Camp camp = new Camp();
                camp.unit = 2;
                camp.title = "Boys Scouts";
                camp.ShowDialog();

            }
            else if (this.title == "Rover Scouts")
            {
                Camp camp = new Camp();
                camp.unit = 3;
                camp.title = "Boys Scouts";
                camp.ShowDialog();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            
            if (this.title == "Shaheen Scouts")
            {
                Event events = new Event();
                events.unit = 1;
                events.title = "Shaheen Scouts";
                events.ShowDialog();


            }
            else if (this.title == "Boys Scouts")
            {
                Event events = new Event();
                events.unit = 2;
                events.title = "Boys Scouts";
                events.ShowDialog();

            }
            else if (this.title == "Rover Scouts")
            {
                Event events = new Event();
                events.unit = 3;
                events.title = "Rover Scouts";
                events.ShowDialog();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.title == "Shaheen Scouts")
            {
                BadgeTest Form22 = new BadgeTest();
                Form22.unit = 1;
                Form22.title = "Shaheen Scouts";
                Form22.ShowDialog();

            }
            else if (this.title == "Boys Scouts")
            {
                BadgeTest Form22 = new BadgeTest();
                Form22.unit = 2;
                Form22.title = "Boys Scouts";
                Form22.ShowDialog();

            }
            else if (this.title == "Rover Scouts")
            {
                BadgeTest Form22 = new BadgeTest();
                Form22.unit = 3;
                Form22.title = "Rover Scouts";
                Form22.ShowDialog();

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
                scout_report sr = new scout_report();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                sr.gzr = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sr.name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                sr.idbsa = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                sr.dob = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;
                sr.fname = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                sr.cont = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                sr.cnic = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                sr.email = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                sr.bg = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                sr.address = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                DialogResult yn = MessageBox.Show("Generate report for scout "+ sr.name+" ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                if (yn == DialogResult.Yes)
                {
                    if (this.title == "Shaheen Scouts")
                    {
                        sr.unit = 1;
                        sr.title = "Shaheen Scouts";
                    }
                    else if (this.title == "Boys Scouts")
                    {
                        sr.unit = 2;
                        sr.title = "Boys Scouts";
                    }
                    else if (this.title == "Rover Scouts")
                    {
                        sr.unit = 3;
                        sr.title = "Rover Scouts";
                    }
                    sr.ShowDialog();
                }
            }
            else
            { MessageBox.Show("You must select a row in order to view report! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
