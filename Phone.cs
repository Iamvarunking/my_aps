using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MyFirstProject
{
    public partial class Phone : Form 

    {
        SqlConnection cn = new SqlConnection(@"Data Source=VARUNSINGH\SQLEXPRESS;Initial Catalog=Phone;Integrated Security=True");
        public Phone()
        {
            InitializeComponent();
            Display();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Text = "";
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Mobiles
                  (FirstName, SurName, Mobile, Email, Catagory)
VALUES ('" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("successfully save");
            Display();
            textBox4.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            
        }
        void Display()
        {
            SqlDataAdapter Sda = new SqlDataAdapter("select * from Mobiles", cn);
            DataTable Dt = new DataTable();
            Sda.Fill(Dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item  in Dt.Rows )
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
           textBox1.Text= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
           textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
           textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
           comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn.Open();
            string q = @"DELETE FROM Mobiles
where  Mobile = '" + textBox4.Text + "'";
            SqlCommand cmd = new SqlCommand(q, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(" Delete successfully ");
            Display();
            textBox4.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.Open();
            string p = @"UPDATE Mobiles
SET          FirstName ='" + textBox1.Text + "', SurName ='" + textBox2.Text + "', Email ='" + textBox3.Text + "', Catagory ='" + comboBox1.Text + "' where mobile = '" + textBox4.Text + "' ";
            SqlCommand cmd = new SqlCommand(p , cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(" updated successfully ");
            Display();
            textBox4.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            

        }

        private void button5_Click(object sender, EventArgs e)
        {

            cn.Open();
            string y = "DELETE FROM Mobiles";
            SqlCommand cmd = new SqlCommand(y , cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(" Delete successfully ");
            Display();
            textBox4.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
