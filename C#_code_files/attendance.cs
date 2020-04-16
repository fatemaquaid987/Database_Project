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
    public partial class attendance : Form
    {
        DataTable dt;
        public int unit = 0;
        public string title = "";

        public attendance()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FADBDTJL\\SQLEXPRESS;Initial Catalog=Gulzar-e-Rahim;Integrated Security=True");
        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = title;
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            con.Open();
          
            SqlCommand com = new SqlCommand("if( @date not in (select date from Attendence)) begin insert into attendence(scouts_GZR_no, date, present) select GZR_no , @date, 0 from scouts end", con);
                com.Parameters.Add(new SqlParameter("@date", dateTimePicker1.Value.Date));
                int flag = com.ExecuteNonQuery();

            SqlDataAdapter sda = new SqlDataAdapter();
            SqlCommand com2 = new SqlCommand("Select Scouts_GZR_no, (select Name from scouts where GZR_no = attendence.Scouts_GZR_no) as Name, present from attendence where Scouts_GZR_no in (select GZR_no from scouts where Unit_idUnit =" + unit + ") and Date = @date1", con);
            com2.Parameters.Add(new SqlParameter("@date1", dateTimePicker1.Value.Date));
            sda.SelectCommand = com2;
            dt = new DataTable();
            sda.Fill(dt);
            
            foreach (DataRow item in dt.Rows)
            {
                
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[1].Value = item["Name"].ToString();
                dataGridView1.Rows[n].Cells[0].Value = item["Scouts_GZR_no"].ToString();
                if (Convert.ToBoolean(item["present"]) == true)
                { dataGridView1.Rows[n].Cells[2].Value = true; }
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult yn = MessageBox.Show("Update Attendence?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (yn == DialogResult.Yes)
            {
                con.Open();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string n = row.Cells[0].Value.ToString();
                        //MessageBox.Show(n);
                        DataGridViewCheckBoxCell chk = row.Cells[2] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(chk.Value) == true)
                        {
                            // MessageBox.Show("this cell checked");
                            SqlCommand com = new SqlCommand("update attendence set present = 1 where scouts_GZR_no =" + n + "and Date = @date", con);
                            com.Parameters.Add(new SqlParameter("@date", dateTimePicker1.Value.Date));
                            int flag = com.ExecuteNonQuery();
                        }
                        if (Convert.ToBoolean(chk.Value) == false)
                        {
                            //MessageBox.Show("this cell checked");
                            SqlCommand com = new SqlCommand("update attendence set present = 0 where scouts_GZR_no =" + n + "and Date = @date", con);
                            com.Parameters.Add(new SqlParameter("@date", dateTimePicker1.Value.Date));
                            int flag = com.ExecuteNonQuery();
                        }
                    }


                }
                con.Close();
            }
            

        }

       
       
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = title;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
