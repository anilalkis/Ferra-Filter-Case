using FerraFilterCase.DataAccess.Concrete;
using FerraFilterCase.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerraFilterCase.UI.Forms
{
    public partial class FilterDetailsForm : Form
    {
        private FiltersDal _filtersDal;
        private string _ferraNo;
        public FilterDetailsForm(string ferraNo)
        {
            InitializeComponent();
            _filtersDal = new FiltersDal();
            _ferraNo = ferraNo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new UC_Filter(_ferraNo));
        }

        private void FilterDetailsForm_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new UC_Filter(_ferraNo));
            filterTitleLbl.Text = _ferraNo;


        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new UC_CaprazReferans());
        }
    }
}
