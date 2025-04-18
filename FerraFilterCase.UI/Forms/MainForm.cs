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

            dataGridView1.DataSource = _filtersDal.GetAll();

            dataGridView1.Columns["ferra_no_b"].HeaderText = "FERRA NO";
            dataGridView1.Columns["filtre_durumu"].HeaderText = "FİLTRE DURUMU";
            dataGridView1.Columns["firma_adi"].HeaderText = "ÜRETİCİ";
            dataGridView1.Columns["filtre_no_göster"].HeaderText = "ORJİNAL NO";
            dataGridView1.Columns["foto1"].Visible = false;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "RESİM";
            imgCol.Name = "imgCol";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Add(imgCol);

            string foto1 = "";
            string imagePath = "";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foto1 = row.Cells["foto1"].Value.ToString();
                imagePath = $"C:\\Users\\Anıl\\source\\repos\\Ferra-Filter-Case\\FerraFilterCase.UI\\Images\\{foto1}";
                row.Cells["imgCol"].Value = Image.FromFile(imagePath);
            }

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
