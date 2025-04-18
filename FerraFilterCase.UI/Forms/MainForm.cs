using FerraFilterCase.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerraFilterCase.UI.Forms
{
    public partial class MainForm : Form
    {
        private FiltersDal _filtersDal;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _filtersDal = new FiltersDal();
            dataGridView1.DataSource = _filtersDal.GetByFerraNo("LF3321");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _filtersDal.GetByFerraNo(RemoveSpecialChars(textBox1.Text));
        }

        private static string RemoveSpecialChars(string input)
        {
            return Regex.Replace(input, "[^a-zA-Z0-9]", "");
        }

    }
}
