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
    public partial class FeeRecord : Form
    {
        public int unit;
        public string title;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FADBDTJL\\SQLEXPRESS;Initial Catalog=Gulzar-e-Rahim;Integrated Security=True");
        public FeeRecord()
        {
            InitializeComponent();
        }

        private void FeeRecord_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Jan");
            comboBox1.Items.Add("Feb");
            comboBox1.Items.Add("Mar");
            comboBox1.Items.Add("Apr");
            comboBox1.Items.Add("May");
            comboBox1.Items.Add("Jun");
            comboBox1.Items.Add("Jul");
            comboBox1.Items.Add("Aug");
            comboBox1.Items.Add("Sep");
            comboBox1.Items.Add("Oct");
            comboBox1.Items.Add("Nov");

           
            comboBox2.Items.Add("2016");
            comboBox2.Items.Add("2015");
            comboBox2.Items.Add("2014");
            comboBox2.Items.Add("2013");
            comboBox2.Items.Add("2012");
            if(  comboBox2.Items.Contains(DateTime.Today.Year.ToString())  )
            {
                MessageBox.Show("yes");
            }
            else
            {
                comboBox2.Items.Add(DateTime.Today.Year.ToString());
            }
            label3.Text = title;
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            con.Open();
            string feeM = comboBox1.SelectedIndex.ToString();
            string feeY = comboBox2.SelectedItem.ToString();

            SqlCommand com = new SqlCommand("set identity_insert feeRecord ON if((" + feeM+" not in (select feeMonth from feeRecord where feeYear ="+feeY+")) or"+
                "("+ feeY+ "not in (select feeYear from feeRecord where feeMonth = "+ feeM+")))"+
                " begin insert into feeRecord(scouts_GZR_no, feeMonth, feeYear, Fee, Paid) select GZR_no , "+feeM+","+ feeY+
                ", (select fee from unit where idUnit = "+ unit.ToString()+") , 0 from scouts where unit_idUnit ="+unit.ToString()+" end", con);
            
            int flag = com.ExecuteNonQuery();
            
            SqlDataAdapter sda = new SqlDataAdapter();
            SqlCommand com2 = new SqlCommand("Select Scouts_GZR_no, (select Name from scouts where GZR_no = feeRecord.Scouts_GZR_no) as Name,"+
                " paid, fee from feeRecord where Scouts_GZR_no in (select GZR_no from scouts where Unit_idUnit =" + unit + ") and feeMonth ="+
                comboBox1.SelectedIndex.ToString()+ "and feeyear = " + comboBox2.SelectedItem.ToString(), con);
           
            sda.SelectCommand = com2;
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["Scouts_GZR_no"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Name"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Fee"].ToString();
                if (Convert.ToBoolean(item["paid"]) == true)
                { dataGridView1.Rows[n].Cells[3].Value = true; }
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult yn = MessageBox.Show("Update Fee Record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (yn == DialogResult.Yes)
            {
                string feeM = comboBox1.SelectedIndex.ToString();
                string feeY = comboBox2.SelectedItem.ToString();
                con.Open();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string n = row.Cells[0].Value.ToString();
                        //MessageBox.Show(n);
                        DataGridViewCheckBoxCell chk = row.Cells[3] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(chk.Value) == true)
                        {
                            // MessageBox.Show("this cell checked");
                            SqlCommand com = new SqlCommand("update feeRecord set paid = 1, feedate = @tdate where scouts_GZR_no =" + n + "and feeMonth =" + feeM + "and feeYear =" + feeY, con);
                            com.Parameters.Add(new SqlParameter("@tdate", DateTime.Today));
                            int flag = com.ExecuteNonQuery();
                        }
                        if (Convert.ToBoolean(chk.Value) == false)
                        {
                            //MessageBox.Show("this cell checked");
                            SqlCommand com = new SqlCommand("update feeRecord set paid = 0, feedate = @tdate where scouts_GZR_no =" + n + "and feeMonth =" + feeM + "and feeYear =" + feeY, con);
                            com.Parameters.Add(new SqlParameter("@tdate", DateTime.Today));
                            int flag = com.ExecuteNonQuery();
                        }
                    }


                }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
