using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBontodev1
{
    public partial class Manage_Customer_Information : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Manage_Customer_Information()
        {
            InitializeComponent();
        }

        private void Manage_Customer_Information_Load(object sender, EventArgs e)
        {
            SqlConnection condb = new SqlConnection("Data Source=NOOMZA;Initial Catalog=Project1Bontodev; Integrated Security=True");
            sda = new SqlDataAdapter(@"select * from tb_Customers", condb);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            condb.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection condb = new SqlConnection("Data Source=NOOMZA;Initial Catalog=Project1Bontodev; Integrated Security=True");
            sda = new SqlDataAdapter(@"select * from tb_Customers where FName like  '%" + txtSearch.Text.Trim() + "%' OR LName '%" + txtSearch.Text.Trim() + "%' ", condb);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            condb.Close();

        }
    }
}
