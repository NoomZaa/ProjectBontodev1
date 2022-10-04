using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBontodev1
{
    public partial class Manage_Book_Information : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Manage_Book_Information()
        {
            InitializeComponent();
        }

        private void Manage_Book_Information_Load(object sender, EventArgs e)
        {
            SqlConnection condb = new SqlConnection("Data Source=NOOMZA;Initial Catalog=Project1Bontodev; Integrated Security=True");
            sda = new SqlDataAdapter(@"select * from tb_Books", condb);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            condb.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection condb = new SqlConnection("Data Source=NOOMZA;Initial Catalog=Project1Bontodev; Integrated Security=True");
            sda = new SqlDataAdapter("select * from tb_Books where (ISBN like '%" + txtSearch.Text.Trim() + "%' or Title like '%" + txtSearch.Text.Trim() + "%' or Price like '%" + txtSearch.Text.Trim() + "%' or Description like '%" + txtSearch.Text.Trim() + "%')  ", condb);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            condb.Close();

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string isbn = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string title = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string price = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string Description = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtISBN.Text = isbn;
            txtTitle.Text = title;
            txtPrice.Text = price;
            txtDescription.Text = Description;
        }
    }
}
