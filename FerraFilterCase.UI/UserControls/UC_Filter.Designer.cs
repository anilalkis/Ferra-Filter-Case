namespace FerraFilterCase.UI.UserControls
{
    partial class UC_Filter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            filterStatusLbl = new Label();
            label3 = new Label();
            filterTypeLbl = new Label();
            label1 = new Label();
            panel2 = new Panel();
            filterInfoDataGridView = new DataGridView();
            pictureBox = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filterInfoDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(filterStatusLbl);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(filterTypeLbl);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1331, 86);
            panel1.TabIndex = 0;
            // 
            // filterStatusLbl
            // 
            filterStatusLbl.AutoSize = true;
            filterStatusLbl.Location = new Point(182, 50);
            filterStatusLbl.Name = "filterStatusLbl";
            filterStatusLbl.Size = new Size(50, 20);
            filterStatusLbl.TabIndex = 3;
            filterStatusLbl.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 50);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 2;
            label3.Text = "Filtre Durumu:";
            // 
            // filterTypeLbl
            // 
            filterTypeLbl.AutoSize = true;
            filterTypeLbl.Location = new Point(182, 17);
            filterTypeLbl.Name = "filterTypeLbl";
            filterTypeLbl.Size = new Size(50, 20);
            filterTypeLbl.TabIndex = 1;
            filterTypeLbl.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 17);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Fitre Tipi:";
            // 
            // panel2
            // 
            panel2.Controls.Add(filterInfoDataGridView);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(1331, 125);
            panel2.TabIndex = 1;
            // 
            // filterInfoDataGridView
            // 
            filterInfoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            filterInfoDataGridView.Dock = DockStyle.Fill;
            filterInfoDataGridView.Location = new Point(0, 0);
            filterInfoDataGridView.Name = "filterInfoDataGridView";
            filterInfoDataGridView.RowHeadersWidth = 51;
            filterInfoDataGridView.RowTemplate.Height = 29;
            filterInfoDataGridView.Size = new Size(1331, 125);
            filterInfoDataGridView.TabIndex = 0;
            filterInfoDataGridView.CellContentClick += filterInfoDataGridView_CellContentClick;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 211);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1331, 468);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // UC_Filter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_Filter";
            Size = new Size(1331, 679);
            Load += UC_Filter_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)filterInfoDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion



        private Panel panel1;
        private Label filterStatusLbl;
        private Label label3;
        private Label filterTypeLbl;
        private Label label1;
        private Panel panel2;
        private DataGridView filterInfoDataGridView;
        private PictureBox pictureBox;
    }
}
