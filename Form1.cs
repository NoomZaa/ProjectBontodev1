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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conObj = new SqlConnection();
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            string strCon;

            strCon = "Data Source=NOOMZA;Initial Catalog=Project1Bontodev; Integrated Security=True";

            if(conObj.State == ConnectionState.Open)
            {
                conObj.Close();
            }
            else
            {
                conObj.ConnectionString = strCon;
                conObj.Open();
            }

            string strSQL = "select * from CustomerID;";

            da = new SqlDataAdapter(strSQL, conObj);

            ds.Tables.Clear();
            da.Fill(ds, "MyQuery");
            dataGridView1.DataSource = ds.Tables["MyQuery"];


        }
    }
}
