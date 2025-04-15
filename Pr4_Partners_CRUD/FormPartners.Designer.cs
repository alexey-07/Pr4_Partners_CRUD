namespace Pr4_Partners_CRUD
{
    partial class FormPartners
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanelTop = new FlowLayoutPanel();
            buttonAddPartner = new Button();
            buttonEdit = new Button();
            buttonHistory = new Button();
            flowLayoutPanelFill = new FlowLayoutPanel();
            labelDiscount = new Label();
            labelRating = new Label();
            labelPhoneNumber = new Label();
            labelDirectorName = new Label();
            labelName = new Label();
            flowLayoutPanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.FromArgb(244, 232, 211);
            flowLayoutPanelTop.Controls.Add(buttonAddPartner);
            flowLayoutPanelTop.Controls.Add(buttonEdit);
            flowLayoutPanelTop.Controls.Add(buttonHistory);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10, 20, 10, 10);
            flowLayoutPanelTop.Size = new Size(934, 81);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // buttonAddPartner
            // 
            buttonAddPartner.BackColor = Color.FromArgb(103, 186, 128);
            buttonAddPartner.FlatStyle = FlatStyle.Flat;
            buttonAddPartner.Location = new Point(13, 23);
            buttonAddPartner.Name = "buttonAddPartner";
            buttonAddPartner.Size = new Size(276, 45);
            buttonAddPartner.TabIndex = 0;
            buttonAddPartner.Text = "Добавить";
            buttonAddPartner.UseVisualStyleBackColor = false;
            buttonAddPartner.Click += ButtonAddPartner_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(103, 186, 128);
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Location = new Point(295, 23);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(276, 45);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += ButtonEdit_Click;
            // 
            // buttonHistory
            // 
            buttonHistory.AutoSize = true;
            buttonHistory.BackColor = Color.FromArgb(103, 186, 128);
            buttonHistory.FlatStyle = FlatStyle.Flat;
            buttonHistory.Location = new Point(577, 23);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(305, 45);
            buttonHistory.TabIndex = 2;
            buttonHistory.Text = "История реализации продукции";
            buttonHistory.UseVisualStyleBackColor = false;
            buttonHistory.Click += ButtonHistory_Click;
            // 
            // flowLayoutPanelFill
            // 
            flowLayoutPanelFill.AutoScroll = true;
            flowLayoutPanelFill.BackColor = Color.White;
            flowLayoutPanelFill.Dock = DockStyle.Fill;
            flowLayoutPanelFill.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelFill.Location = new Point(0, 81);
            flowLayoutPanelFill.Margin = new Padding(100);
            flowLayoutPanelFill.Name = "flowLayoutPanelFill";
            flowLayoutPanelFill.Padding = new Padding(10);
            flowLayoutPanelFill.Size = new Size(934, 480);
            flowLayoutPanelFill.TabIndex = 1;
            flowLayoutPanelFill.WrapContents = false;
            // 
            // labelDiscount
            // 
            labelDiscount.Location = new Point(0, 0);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(100, 23);
            labelDiscount.TabIndex = 0;
            // 
            // labelRating
            // 
            labelRating.Location = new Point(0, 0);
            labelRating.Name = "labelRating";
            labelRating.Size = new Size(100, 23);
            labelRating.TabIndex = 0;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.Location = new Point(0, 0);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(100, 23);
            labelPhoneNumber.TabIndex = 0;
            // 
            // labelDirectorName
            // 
            labelDirectorName.Location = new Point(0, 0);
            labelDirectorName.Name = "labelDirectorName";
            labelDirectorName.Size = new Size(100, 23);
            labelDirectorName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.Location = new Point(0, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(100, 23);
            labelName.TabIndex = 0;
            // 
            // FormPartners
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(934, 561);
            Controls.Add(flowLayoutPanelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FormPartners";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Partners";
            Load += FormPartners_Load;
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button buttonAddPartner;
        private Button buttonEdit;
        private Button buttonHistory;
        private FlowLayoutPanel flowLayoutPanelFill;
        private Label labelName;
        private Label labelDirectorName;
        private Label labelRating;
        private Label labelPhoneNumber;
        private Label labelDiscount;
    }
}
