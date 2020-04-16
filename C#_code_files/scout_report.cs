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
    public partial class scout_report : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FADBDTJL\\SQLEXPRESS;Initial Catalog=Gulzar-e-Rahim;Integrated Security=True");
        public string name;
        public string gzr;
        public string email;
        public string bg;
        public string fname;
        public string cont;
        public string address;
        public string cnic;
        public string idbsa;
        public DateTime dob;
        public string  title;
        public int  unit;
        public scout_report()
        {
            InitializeComponent();
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void OKbutton_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void scout_report_Load(object sender, EventArgs e)
        {
            label35.Text = title;
            textBox1.Text = name;
            textBox3.Text = fname;
            dateTimePicker1.Value= dob;
            textBox4.Text = email;
            textBox5.Text = cnic;
            textBox5.Text = cont;
            textBox7.Text = bg;
            textBox8.Text = address;
            textBox10.Text = idbsa;
            textBox11.Text = gzr;
            label35.Text = title;
            if(unit == 1)
            { checkBox1.Checked= true; }
            else if (unit == 2)
            { checkBox2.Checked = true; }
            else
            { checkBox3.Checked = true; }

            con.Open();
            string query = "select badges_idbadges, dateOfPassing from scouts_has_badges where scouts_gzr_no = " + gzr;
            SqlCommand com = new SqlCommand(query, con);
            using (SqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {
                    if ((int)reader["Badges_idBadges"] == 1 )

                    {
                        if (unit == 1)
                        {
                            checkBox4.Checked = true;
                            dateTimePicker1.Value = (DateTime)reader["DateOFPassing"];
                        }
                        else if (unit == 2)
                        {
                            checkBox9.Checked = true;
                            dateTimePicker6.Value = (DateTime)reader["DateOFPassing"];
                        }
                        else if (unit == 3)
                        {
                            checkBox14.Checked = true;
                            dateTimePicker11.Value = (DateTime)reader["DateOFPassing"];
                        }
                    }
                    else if ((int)reader["Badges_idBadges"] == 2)
                    { checkBox5.Checked = true;
                        dateTimePicker2.Value = (DateTime)reader["DateOFPassing"];
                    }
                    else if ((int)reader["Badges_idBadges"] == 3)
                    { checkBox6.Checked = true;
                        dateTimePicker3.Value = (DateTime)reader["DateOFPassing"];
                    }
                    else if ((int)reader["Badges_idBadges"] == 4)
                    { checkBox7.Checked = true;
                        dateTimePicker4.Value = (DateTime)reader["DateOFPassing"];
                    }
                    else if ((int)reader["Badges_idBadges"] == 5)
                    { checkBox8.Checked = true;
                        dateTimePicker5.Value = (DateTime)reader["DateOFPassing"];
                    }
                   
                    else if ((int)reader["Badges_idBadges"] == 6)
                    { checkBox10.Checked = true;
                        dateTimePicker7.Value = (DateTime)reader["DateOFPassing"];
                    }
                    else if ((int)reader["Badges_idBadges"] == 7)
                    { checkBox11.Checked = true;
                        dateTimePicker8.Value = (DateTime)reader["DateOFPassing"];
                    }
                    else if ((int)reader["Badges_idBadges"] == 8)
                    { checkBox12.Checked = true;
                        dateTimePicker9.Value = (DateTime)reader["DateOFPassing"];
                    }
                    else if ((int)reader["Badges_idBadges"] == 9)
                    { checkBox13.Checked = true;
                        dateTimePicker10.Value = (DateTime)reader["DateOFPassing"];
                    }
                    
                    else if ((int)reader["Badges_idBadges"] == 10)
                    { checkBox15.Checked = true;
                        dateTimePicker12.Value = (DateTime)reader["DateOFPassing"];
                    }
                    else if ((int)reader["Badges_idBadges"] == 11)
                    { checkBox16.Checked = true;
                        dateTimePicker13.Value = (DateTime)reader["DateOFPassing"];
                    }
                    else if ((int)reader["Badges_idBadges"] == 12)
                    { checkBox17.Checked = true;
                        dateTimePicker14.Value = (DateTime)reader["DateOFPassing"];
                    }
                }
                reader.Close();
                query = "select c.name as name from camps_has_scouts cs inner join " +
                "camps c on cs.camps_idCamps = c.idCamps where cs.scouts_gzr_no = " + gzr;
                com = new SqlCommand(query, con);
                SqlDataReader reader2 = com.ExecuteReader();
                while (reader2.Read())
                {
                    listBox1.Items.Add((string)reader2["name"]);
                }
                reader2.Close();

                query = "select e.name as name from event_has_scouts es inner join " +
                "event e on es.event_idevent = e.idevent where es.scouts_gzr_no = " + gzr;
                com = new SqlCommand(query, con);
                SqlDataReader reader3 = com.ExecuteReader();
                while (reader3.Read())
                {
                    listBox2.Items.Add((string)reader3["name"]);
                }
                reader3.Close();


            }
            

            
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
            }
            





