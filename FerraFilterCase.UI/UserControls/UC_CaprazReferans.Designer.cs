namespace FerraFilterCase.UI.UserControls
{
    partial class UC_CaprazReferans
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
            tabControl1 = new TabControl();
            oemTab = new TabPage();
            comboBox1 = new ComboBox();
            oemDataGrid = new DataGridView();
            ureticiTab = new TabPage();
            urecitiCbx = new ComboBox();
            ureticiDgw = new DataGridView();
            tabControl1.SuspendLayout();
            oemTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)oemDataGrid).BeginInit();
            ureticiTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ureticiDgw).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(oemTab);
            tabControl1.Controls.Add(ureticiTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1331, 558);
            tabControl1.TabIndex = 0;
            // 
            // oemTab
            // 
            oemTab.Controls.Add(comboBox1);
            oemTab.Controls.Add(oemDataGrid);
            oemTab.Location = new Point(4, 29);
            oemTab.Name = "oemTab";
            oemTab.Padding = new Padding(3);
            oemTab.Size = new Size(1323, 525);
            oemTab.TabIndex = 0;
            oemTab.Text = "OEM NO";
            oemTab.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(40, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // oemDataGrid
            // 
            oemDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            oemDataGrid.Location = new Point(40, 80);
            oemDataGrid.Name = "oemDataGrid";
            oemDataGrid.RowHeadersWidth = 51;
            oemDataGrid.RowTemplate.Height = 29;
            oemDataGrid.Size = new Size(838, 419);
            oemDataGrid.TabIndex = 0;
            // 
            // ureticiTab
            // 
            ureticiTab.Controls.Add(ureticiDgw);
            ureticiTab.Controls.Add(urecitiCbx);
            ureticiTab.Location = new Point(4, 29);
            ureticiTab.Name = "ureticiTab";
            ureticiTab.Padding = new Padding(3);
            ureticiTab.Size = new Size(1323, 525);
            ureticiTab.TabIndex = 1;
            ureticiTab.Text = "ÜRETİCİ";
            ureticiTab.UseVisualStyleBackColor = true;
            // 
            // urecitiCbx
            // 
            urecitiCbx.FormattingEnabled = true;
            urecitiCbx.Location = new Point(25, 34);
            urecitiCbx.Name = "urecitiCbx";
            urecitiCbx.Size = new Size(266, 28);
            urecitiCbx.TabIndex = 0;
            urecitiCbx.SelectedIndexChanged += urecitiCbx_SelectedIndexChanged;
            // 
            // ureticiDgw
            // 
            ureticiDgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ureticiDgw.Location = new Point(25, 91);
            ureticiDgw.Name = "ureticiDgw";
            ureticiDgw.RowHeadersWidth = 51;
            ureticiDgw.RowTemplate.Height = 29;
            ureticiDgw.Size = new Size(852, 371);
            ureticiDgw.TabIndex = 1;
            // 
            // UC_CaprazReferans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "UC_CaprazReferans";
            Size = new Size(1331, 558);
            Load += UC_CaprazReferans_Load;
            tabControl1.ResumeLayout(false);
            oemTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)oemDataGrid).EndInit();
            ureticiTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ureticiDgw).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage oemTab;
        private TabPage ureticiTab;
        private DataGridView oemDataGrid;
        private ComboBox comboBox1;
        private DataGridView ureticiDgw;
        private ComboBox urecitiCbx;
    }
}
