namespace Pr4_Partners_CRUD
{
    partial class FormAddPartner
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
            flowLayoutPanelBottom = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonCancel = new Button();
            panelFill = new Panel();
            textBoxRating = new TextBox();
            label7 = new Label();
            textBoxEmail = new TextBox();
            label6 = new Label();
            textBoxPhoneNumber = new TextBox();
            label5 = new Label();
            textBoxDirectorFullName = new TextBox();
            label4 = new Label();
            textBoxINN = new TextBox();
            label3 = new Label();
            textBoxAdress = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            comboBoxTypes = new ComboBox();
            labelType = new Label();
            flowLayoutPanelBottom.SuspendLayout();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.BackColor = Color.FromArgb(244, 232, 211);
            flowLayoutPanelBottom.Controls.Add(buttonCancel);
            flowLayoutPanelBottom.Controls.Add(buttonAdd);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(0, 684);
            flowLayoutPanelBottom.Margin = new Padding(4);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(12);
            flowLayoutPanelBottom.Size = new Size(541, 77);
            flowLayoutPanelBottom.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(103, 186, 128);
            buttonAdd.DialogResult = DialogResult.OK;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Location = new Point(184, 16);
            buttonAdd.Margin = new Padding(4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(160, 45);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(103, 186, 128);
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Location = new Point(16, 16);
            buttonCancel.Margin = new Padding(4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(160, 45);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(textBoxRating);
            panelFill.Controls.Add(label7);
            panelFill.Controls.Add(textBoxEmail);
            panelFill.Controls.Add(label6);
            panelFill.Controls.Add(textBoxPhoneNumber);
            panelFill.Controls.Add(label5);
            panelFill.Controls.Add(textBoxDirectorFullName);
            panelFill.Controls.Add(label4);
            panelFill.Controls.Add(textBoxINN);
            panelFill.Controls.Add(label3);
            panelFill.Controls.Add(textBoxAdress);
            panelFill.Controls.Add(label2);
            panelFill.Controls.Add(textBoxName);
            panelFill.Controls.Add(label1);
            panelFill.Controls.Add(comboBoxTypes);
            panelFill.Controls.Add(labelType);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Margin = new Padding(4);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(15);
            panelFill.Size = new Size(541, 684);
            panelFill.TabIndex = 1;
            // 
            // textBoxRating
            // 
            textBoxRating.Dock = DockStyle.Top;
            textBoxRating.Location = new Point(15, 633);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(511, 32);
            textBoxRating.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Location = new Point(15, 588);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 10, 0, 10);
            label7.Size = new Size(85, 45);
            label7.TabIndex = 28;
            label7.Text = "Рейтинг:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Dock = DockStyle.Top;
            textBoxEmail.Location = new Point(15, 556);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(511, 32);
            textBoxEmail.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(15, 511);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 10, 0, 10);
            label6.Size = new Size(185, 45);
            label6.TabIndex = 26;
            label6.Text = "Электронная почта:";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Dock = DockStyle.Top;
            textBoxPhoneNumber.Location = new Point(15, 479);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(511, 32);
            textBoxPhoneNumber.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(15, 434);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 10, 0, 10);
            label5.Size = new Size(162, 45);
            label5.TabIndex = 24;
            label5.Text = "Номер телефона:";
            // 
            // textBoxDirectorFullName
            // 
            textBoxDirectorFullName.Dock = DockStyle.Top;
            textBoxDirectorFullName.Location = new Point(15, 402);
            textBoxDirectorFullName.Name = "textBoxDirectorFullName";
            textBoxDirectorFullName.Size = new Size(511, 32);
            textBoxDirectorFullName.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(15, 357);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 10, 0, 10);
            label4.Size = new Size(154, 45);
            label4.TabIndex = 22;
            label4.Text = "ФИО директора:";
            // 
            // textBoxINN
            // 
            textBoxINN.Dock = DockStyle.Top;
            textBoxINN.Location = new Point(15, 325);
            textBoxINN.Name = "textBoxINN";
            textBoxINN.Size = new Size(511, 32);
            textBoxINN.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(15, 280);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 10, 0, 10);
            label3.Size = new Size(56, 45);
            label3.TabIndex = 20;
            label3.Text = "ИНН:";
            // 
            // textBoxAdress
            // 
            textBoxAdress.Dock = DockStyle.Top;
            textBoxAdress.Location = new Point(15, 215);
            textBoxAdress.Multiline = true;
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(511, 65);
            textBoxAdress.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(15, 170);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 10);
            label2.Size = new Size(68, 45);
            label2.TabIndex = 18;
            label2.Text = "Адрес:";
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Top;
            textBoxName.Location = new Point(15, 138);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.ScrollBars = ScrollBars.Horizontal;
            textBoxName.Size = new Size(511, 32);
            textBoxName.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(15, 93);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 10);
            label1.Size = new Size(99, 45);
            label1.TabIndex = 16;
            label1.Text = "Название:";
            // 
            // comboBoxTypes
            // 
            comboBoxTypes.Dock = DockStyle.Top;
            comboBoxTypes.FormattingEnabled = true;
            comboBoxTypes.Items.AddRange(new object[] { "ffdsgdf", "gdfgdfgdf", "gdfgdfgd" });
            comboBoxTypes.Location = new Point(15, 60);
            comboBoxTypes.Name = "comboBoxTypes";
            comboBoxTypes.Size = new Size(511, 33);
            comboBoxTypes.TabIndex = 15;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Dock = DockStyle.Top;
            labelType.Location = new Point(15, 15);
            labelType.Margin = new Padding(4, 0, 4, 0);
            labelType.Name = "labelType";
            labelType.Padding = new Padding(0, 10, 0, 10);
            labelType.Size = new Size(135, 45);
            labelType.TabIndex = 0;
            labelType.Text = "Тип партнера:";
            // 
            // FormAddPartner
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(541, 761);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelBottom);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            MinimizeBox = false;
            Name = "FormAddPartner";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить партнера";
            flowLayoutPanelBottom.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button buttonCancel;
        private Label labelType;
        protected Panel panelFill;
        protected internal ComboBox comboBoxTypes;
        protected internal Button buttonAdd;
        protected internal TextBox textBoxRating;
        private Label label7;
        protected internal TextBox textBoxEmail;
        private Label label6;
        protected internal TextBox textBoxPhoneNumber;
        private Label label5;
        protected internal TextBox textBoxDirectorFullName;
        private Label label4;
        protected internal TextBox textBoxINN;
        private Label label3;
        protected internal TextBox textBoxAdress;
        private Label label2;
        protected internal TextBox textBoxName;
        private Label label1;
    }
}