using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnternet_Cafe
{
    public partial class HareketRaporu : Form
    {
        public HareketRaporu()
        {
            InitializeComponent();
        }

        private void HareketRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'InternetCafeDataSet.tbl_hareketler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_hareketlerTableAdapter.Fill(this.InternetCafeDataSet.tbl_hareketler);

            this.reportViewer1.RefreshReport();
        }
    }
}
