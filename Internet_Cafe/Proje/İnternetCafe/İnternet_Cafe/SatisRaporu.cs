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
    public partial class SatisRaporu : Form
    {
        public SatisRaporu()
        {
            InitializeComponent();
        }

        private void SatisRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'InternetCafeDataSet.tbl_satis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_satisTableAdapter.Fill(this.InternetCafeDataSet.tbl_satis);

            this.reportViewer1.RefreshReport();
        }
    }
}
