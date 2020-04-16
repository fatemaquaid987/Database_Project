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
    public partial class Event : Form
    {
        DataTable dt;
        DataTable dt2;
        public string title;
        public int unit;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FADBDTJL\\SQLEXPRESS;Initial Catalog=Gulzar-e-Rahim;Integrated Security=True");
        public Event()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult yn = MessageBox.Show("Update Event?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (yn == DialogResult.Yes)
            {
                con.Open();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        //string n = row.Cells[0].Value.ToString();
                        //MessageBox.Show(n);
                        DataGridViewCheckBoxCell chk = row.Cells[2] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(chk.Value) == true)
                        {

                            string g = row.Cells[0].Value.ToString();



                            SqlCommand command = new SqlCommand("if( "+ g + "not in (select scouts_gzr_no from event_has_scouts where event_idevent in(select idEvent from Event where name = '" + textBox1.Text + "') ) )"+
                                "begin insert into Event_has_scouts(Event_idEvent, scouts_GZR_no)" +
                                "values( (select idEvent from Event where name = '" + textBox1.Text + "') , " + g +") end", con);
                            int flag2 = command.ExecuteNonQuery();
                        }
                        else
                        {
                            string g = row.Cells[0].Value.ToString();



                            SqlCommand command = new SqlCommand("if( " + g + " in (select scouts_gzr_no from event_has_scouts where event_idevent in(select idEvent from Event where name = '" + textBox1.Text + "') ) )" +
                                "begin delete Event_has_scouts " +
                                "where scouts_gzr_no = " + g + " and event_idevent = (select idEvent from Event where name = '" + textBox1.Text + "')  end", con);
                            int flag2 = command.ExecuteNonQuery();
                        }


                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Event_Load(object sender, EventArgs e)
        {
            label4.Text = title;
            con.Open();
            SqlCommand com1 = new SqlCommand("Select Name from Event", con);
            using (SqlDataReader reader = com1.ExecuteReader())
            {
                while (reader.Read())
                {
                    listBox1.Items.Add((string)reader["Name"]);
                }
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            con.Open();
            if (textBox1.Text != null)
            {
                SqlCommand com3 = new SqlCommand("if ('" + textBox1.Text + "' not in (select name from event)) begin insert into Event(Name,Date, Place) values( '" + textBox1.Text + "',@date1,'" + textBox2.Text + "') end", con);
                com3.Parameters.Add(new SqlParameter("@date1", dateTimePicker1.Value.Date));
                int flag = com3.ExecuteNonQuery();

                SqlCommand com = new SqlCommand("select GZR_no, Name  from scouts where unit_idunit ="+ unit, con);
                int flag1 = com.ExecuteNonQuery();


                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = com;
                dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[1].Value = item["Name"].ToString();
                    dataGridView1.Rows[n].Cells[0].Value = item["GZR_no"].ToString();
                    SqlCommand com1 = new SqlCommand("select scouts_gzr_no from event_has_scouts where event_idevent in (select idevent from event where name = '" + textBox1.Text + "')", con);
                    using (SqlDataReader reader = com1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if((string)dataGridView1.Rows[n].Cells[0].Value == reader["Scouts_gzr_no"].ToString())
                            { dataGridView1.Rows[n].Cells[2].Value = true; }
                           
                        }
                        reader.Close();
                    }
                    
                }
            }
                con.Close();
            }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }
    }
}
