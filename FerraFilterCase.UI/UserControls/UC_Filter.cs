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
    public partial class UC_Filter : UserControl
    {
        private FiltersDal _filtersDal;
        private string _ferraNo;

        public UC_Filter(string ferraNo)
        {
            InitializeComponent();
            _filtersDal = new FiltersDal();
            _ferraNo = ferraNo;
        }

        private void filterInfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Filter_Load_1(object sender, EventArgs e)
        {
            var filterInfo = _filtersDal.GetFilterByFerraNo(_ferraNo);

            filterInfoDataGridView.DataSource = filterInfo;
            filterStatusLbl.Text = filterInfo.First().filtre_durumu;
            filterTypeLbl.Text = filterInfo.First().filtre_tipi_tr;
            pictureBox.Image = Image.FromFile($"C:\\Users\\Anıl\\source\\repos\\Ferra-Filter-Case\\FerraFilterCase.UI\\Images\\{filterInfo.First().foto1}");
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            filterInfoDataGridView.Refresh();
        }
    }
}
