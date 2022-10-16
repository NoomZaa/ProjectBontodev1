using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBontodev1
{
    public partial class Order_Book : Form
    {
        SqlConnection condb = new SqlConnection("Data Source=NOOMZA;Initial Catalog=Project1Bontodev; Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        int PriceSum;

        private void DisplayData()
        {
            condb.Open();
            dt = new DataTable();
            sda = new SqlDataAdapter(@"select ISBN,Title,Price from tb_Books", condb);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            condb.Close();
        }

        private void ClearData()
        {
            labPrice.Text = "";
            txtQuantity.Text = "";
            txtPriceSum.Text = "";
            txtCode.Text = "";
        }

        private void ClearDataCal()
        {
            txtQuantity.Text = "";
            txtPriceSum.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ISBN = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string Price = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtISBN.Text = ISBN;
            labPrice.Text = Price;
        }



        public Order_Book()
        {
            InitializeComponent();
        }

        private void Order_Book_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

            int quantity;
            int PriceP;

            if (txtQuantity.Text.Length > 0)
            {
                quantity = Convert.ToInt32(txtQuantity.Text);
                PriceP = Convert.ToInt32(labPrice.Text);

                PriceSum = PriceP * quantity ;
                txtPriceSum.Text = PriceSum.ToString();
            }
            else
            {
                ClearDataCal();
            }

        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            condb.Open();
            sda = new SqlDataAdapter("select ISBN,Title,Price from tb_Books where (ISBN like '%" + txtSearch.Text.Trim() + "%' or Title like '%" + txtSearch.Text.Trim() + "%')", condb);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            condb.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtQuantity.Text == "")
            {
                MessageBox.Show("กรุณาระบุจำนวนที่ต้องการซื้อ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtCode.Text != "") 
            {
                condb.Open();
                SqlCommand cmd = new SqlCommand("insert into tb_Transactions(ISBN,Customer_id,Quatity,Total_Price) values (@ISBN,@Customer_id,@Quatity,@Total_Price)", condb);
                cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                cmd.Parameters.AddWithValue("@Customer_id", txtCode.Text);
                cmd.Parameters.AddWithValue("@Quatity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@Total_Price", txtPriceSum.Text);
                cmd.ExecuteNonQuery();
                condb.Close();
                MessageBox.Show("สั่งซื้อหนังสือสำเร็จเรียบร้อย" + System.Environment.NewLine + "รหัสหนังสือที่สั่งซื้อ : "+txtISBN.Text+ System.Environment.NewLine+"จำนวนหนังสือที่สั่งซื้อ : "+txtQuantity.Text +"เล่ม"+ System.Environment.NewLine+"ราคารวม : "+txtPriceSum.Text +" บาท", "MessageBox");
                DisplayData();
                ClearData();
                txtISBN.Text = "";

            }
            else
            {
                MessageBox.Show("กรุณากรอกรหัสลูกค้า", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearData();
            txtISBN.Text = "";
        }
    }
}
