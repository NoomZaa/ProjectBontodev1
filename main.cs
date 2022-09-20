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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Customer_Information showManage_Customer_Information = new Manage_Customer_Information();
            showManage_Customer_Information.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
