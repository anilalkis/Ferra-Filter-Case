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

            DataGridView1_DefaultStyle();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _filtersDal.GetByFerraNo(RemoveSpecialChars(textBox1.Text));

            string foto1 = "";
            string imagePath = "";
            string projectPath = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foto1 = row.Cells["foto1"].Value.ToString();
                imagePath = $"{projectPath}\\Images\\{foto1}";
                row.Cells["imgCol"].Value = Image.FromFile(imagePath);

            }
        }

        private static string RemoveSpecialChars(string input)
        {
            return Regex.Replace(input, "[^a-zA-Z0-9]", "");
        }

        private void DataGridView1_DefaultStyle()
        {
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

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "ferra_no_b")
            {
                string ferraNo = dataGridView1.Rows[e.RowIndex].Cells["ferra_no_b"].Value.ToString();
                FilterDetailsForm filterDetailsForm = new FilterDetailsForm(ferraNo);
                filterDetailsForm.ShowDialog();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns["ferra_no_b"].Index == e.ColumnIndex)
            {
                e.CellStyle.ForeColor = Color.Red;
                e.CellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            }
        }
    }
}
