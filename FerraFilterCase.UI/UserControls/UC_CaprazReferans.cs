using FerraFilterCase.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerraFilterCase.UI.UserControls
{
    public partial class UC_CaprazReferans : UserControl
    {
        private Ferra_orjinal_muadilDal _ferraMuadil;
        public UC_CaprazReferans()
        {
            InitializeComponent();
            _ferraMuadil = new Ferra_orjinal_muadilDal();
        }

        private void UC_CaprazReferans_Load(object sender, EventArgs e)
        {
            oemDataGrid.DataSource = _ferraMuadil.GetCaprazDatas("1");
            ureticiDgw.DataSource = _ferraMuadil.GetCaprazDatas("2");
            comboBox1.DataSource = _ferraMuadil.GetFirmsByOrjinalMuadil("1");
            comboBox1.DisplayMember = "firma_adi";
            urecitiCbx.DataSource = _ferraMuadil.GetFirmsByOrjinalMuadil("2");
            urecitiCbx.DisplayMember = "firma_adi";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            oemDataGrid.DataSource = _ferraMuadil.GetCaprazDatasByFirm(comboBox1.Text.ToUpper(),"1");
        }

        private void urecitiCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ureticiDgw.DataSource = _ferraMuadil.GetCaprazDatasByFirm(urecitiCbx.Text.ToUpper(), "2");
        }
    }
}
