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
            buttonCancel = new Button();
            buttonAdd = new Button();
            panelFill = new Panel();
            textBoxRating = new TextBox();
            labelRaiting = new Label();
            textBoxEmail = new TextBox();
            labelMail = new Label();
            textBoxPhoneNumber = new TextBox();
            labelNumber = new Label();
            textBoxDirectorFullName = new TextBox();
            labelDirectory = new Label();
            textBoxINN = new TextBox();
            labelInn = new Label();
            textBoxAdress = new TextBox();
            labelAdress = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
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
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(textBoxRating);
            panelFill.Controls.Add(labelRaiting);
            panelFill.Controls.Add(textBoxEmail);
            panelFill.Controls.Add(labelMail);
            panelFill.Controls.Add(textBoxPhoneNumber);
            panelFill.Controls.Add(labelNumber);
            panelFill.Controls.Add(textBoxDirectorFullName);
            panelFill.Controls.Add(labelDirectory);
            panelFill.Controls.Add(textBoxINN);
            panelFill.Controls.Add(labelInn);
            panelFill.Controls.Add(textBoxAdress);
            panelFill.Controls.Add(labelAdress);
            panelFill.Controls.Add(textBoxName);
            panelFill.Controls.Add(labelName);
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
            // labelRaiting
            // 
            labelRaiting.AutoSize = true;
            labelRaiting.Dock = DockStyle.Top;
            labelRaiting.Location = new Point(15, 588);
            labelRaiting.Margin = new Padding(4, 0, 4, 0);
            labelRaiting.Name = "labelRaiting";
            labelRaiting.Padding = new Padding(0, 10, 0, 10);
            labelRaiting.Size = new Size(85, 45);
            labelRaiting.TabIndex = 28;
            labelRaiting.Text = "Рейтинг:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Dock = DockStyle.Top;
            textBoxEmail.Location = new Point(15, 556);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(511, 32);
            textBoxEmail.TabIndex = 27;
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Dock = DockStyle.Top;
            labelMail.Location = new Point(15, 511);
            labelMail.Margin = new Padding(4, 0, 4, 0);
            labelMail.Name = "labelMail";
            labelMail.Padding = new Padding(0, 10, 0, 10);
            labelMail.Size = new Size(185, 45);
            labelMail.TabIndex = 26;
            labelMail.Text = "Электронная почта:";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Dock = DockStyle.Top;
            textBoxPhoneNumber.Location = new Point(15, 479);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(511, 32);
            textBoxPhoneNumber.TabIndex = 25;
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Dock = DockStyle.Top;
            labelNumber.Location = new Point(15, 434);
            labelNumber.Margin = new Padding(4, 0, 4, 0);
            labelNumber.Name = "labelNumber";
            labelNumber.Padding = new Padding(0, 10, 0, 10);
            labelNumber.Size = new Size(162, 45);
            labelNumber.TabIndex = 24;
            labelNumber.Text = "Номер телефона:";
            // 
            // textBoxDirectorFullName
            // 
            textBoxDirectorFullName.Dock = DockStyle.Top;
            textBoxDirectorFullName.Location = new Point(15, 402);
            textBoxDirectorFullName.Name = "textBoxDirectorFullName";
            textBoxDirectorFullName.Size = new Size(511, 32);
            textBoxDirectorFullName.TabIndex = 23;
            // 
            // labelDirectory
            // 
            labelDirectory.AutoSize = true;
            labelDirectory.Dock = DockStyle.Top;
            labelDirectory.Location = new Point(15, 357);
            labelDirectory.Margin = new Padding(4, 0, 4, 0);
            labelDirectory.Name = "labelDirectory";
            labelDirectory.Padding = new Padding(0, 10, 0, 10);
            labelDirectory.Size = new Size(154, 45);
            labelDirectory.TabIndex = 22;
            labelDirectory.Text = "ФИО директора:";
            // 
            // textBoxINN
            // 
            textBoxINN.Dock = DockStyle.Top;
            textBoxINN.Location = new Point(15, 325);
            textBoxINN.Name = "textBoxINN";
            textBoxINN.Size = new Size(511, 32);
            textBoxINN.TabIndex = 21;
            // 
            // labelInn
            // 
            labelInn.AutoSize = true;
            labelInn.Dock = DockStyle.Top;
            labelInn.Location = new Point(15, 280);
            labelInn.Margin = new Padding(4, 0, 4, 0);
            labelInn.Name = "labelInn";
            labelInn.Padding = new Padding(0, 10, 0, 10);
            labelInn.Size = new Size(56, 45);
            labelInn.TabIndex = 20;
            labelInn.Text = "ИНН:";
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
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Dock = DockStyle.Top;
            labelAdress.Location = new Point(15, 170);
            labelAdress.Margin = new Padding(4, 0, 4, 0);
            labelAdress.Name = "labelAdress";
            labelAdress.Padding = new Padding(0, 10, 0, 10);
            labelAdress.Size = new Size(68, 45);
            labelAdress.TabIndex = 18;
            labelAdress.Text = "Адрес:";
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
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Top;
            labelName.Location = new Point(15, 93);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Padding = new Padding(0, 10, 0, 10);
            labelName.Size = new Size(99, 45);
            labelName.TabIndex = 16;
            labelName.Text = "Название:";
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
        private Label labelRaiting;
        protected internal TextBox textBoxEmail;
        private Label labelMail;
        protected internal TextBox textBoxPhoneNumber;
        private Label labelNumber;
        protected internal TextBox textBoxDirectorFullName;
        private Label labelDirectory;
        protected internal TextBox textBoxINN;
        private Label labelInn;
        protected internal TextBox textBoxAdress;
        private Label labelAdress;
        protected internal TextBox textBoxName;
        private Label labelName;
    }
}