namespace Pr4_Partners_CRUD
{
    partial class FormHistoryOfReailisation
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelPartnerName = new Label();
            panel1 = new Panel();
            dataGridViewPartnersProducts = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartnersProducts).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(244, 232, 211);
            flowLayoutPanel1.Controls.Add(labelPartnerName);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(12);
            flowLayoutPanel1.Size = new Size(934, 49);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // labelPartnerName
            // 
            labelPartnerName.AutoSize = true;
            labelPartnerName.BackColor = Color.FromArgb(103, 186, 128);
            labelPartnerName.Dock = DockStyle.Fill;
            labelPartnerName.Location = new Point(15, 12);
            labelPartnerName.Name = "labelPartnerName";
            labelPartnerName.Size = new Size(87, 25);
            labelPartnerName.TabIndex = 1;
            labelPartnerName.Text = "Партнер";
            labelPartnerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridViewPartnersProducts);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 49);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(934, 538);
            panel1.TabIndex = 1;
            // 
            // dataGridViewPartnersProducts
            // 
            dataGridViewPartnersProducts.AllowUserToAddRows = false;
            dataGridViewPartnersProducts.AllowUserToDeleteRows = false;
            dataGridViewPartnersProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewPartnersProducts.BackgroundColor = Color.White;
            dataGridViewPartnersProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPartnersProducts.Dock = DockStyle.Fill;
            dataGridViewPartnersProducts.Location = new Point(10, 10);
            dataGridViewPartnersProducts.Name = "dataGridViewPartnersProducts";
            dataGridViewPartnersProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewPartnersProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPartnersProducts.Size = new Size(914, 518);
            dataGridViewPartnersProducts.TabIndex = 0;
            // 
            // FormHistoryOfReailisation
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 587);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FormHistoryOfReailisation";
            StartPosition = FormStartPosition.CenterParent;
            Text = "История реализации продукции";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartnersProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private DataGridView dataGridViewPartnersProducts;
        private Label labelPartnerName;
    }
}