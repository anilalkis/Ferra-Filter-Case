namespace FerraFilterCase.UI.Forms
{
    partial class FilterDetailsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            filterTitleLbl = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // filterTitleLbl
            // 
            filterTitleLbl.AutoSize = true;
            filterTitleLbl.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            filterTitleLbl.ForeColor = Color.Red;
            filterTitleLbl.Location = new Point(29, 11);
            filterTitleLbl.Name = "filterTitleLbl";
            filterTitleLbl.Size = new Size(171, 67);
            filterTitleLbl.TabIndex = 0;
            filterTitleLbl.Text = "label1";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(filterTitleLbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1331, 142);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(168, 81);
            button2.Name = "button2";
            button2.Size = new Size(136, 44);
            button2.TabIndex = 2;
            button2.Text = "Çapraz Referans";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(38, 81);
            button1.Name = "button1";
            button1.Size = new Size(124, 44);
            button1.TabIndex = 1;
            button1.Text = "Ferra Filtre";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 142);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1331, 558);
            mainPanel.TabIndex = 2;
            // 
            // FilterDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 700);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Name = "FilterDetailsForm";
            Text = "FilterDetailsForm";
            Load += FilterDetailsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label filterTitleLbl;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Panel mainPanel;
    }
}