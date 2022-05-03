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

namespace İnternet_Cafe
{
    public partial class RaporYazdır : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public static string sqlcon1 = @"Data Source=DESKTOP-3ODUATA\SQLEXPRESS;Initial Catalog=InternetCafe;Integrated Security=True";
        public RaporYazdır()
        {
            InitializeComponent();
        }

        public void RaporDoldur(string sql)
        {
            con = new SqlConnection(sqlcon1);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();

            con.Open();
            da.Fill(ds);
            RaporSatis1.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = RaporSatis1;
            con.Close();
        }

        private void RaporYazdır_Load(object sender, EventArgs e)
        {
            RaporDoldur("select *from tbl_satis");
        }
    }
}
