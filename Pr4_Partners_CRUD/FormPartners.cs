using Microsoft.EntityFrameworkCore;
using Pr4_Partners_CRUD.Models;
using AppContext = Pr4_Partners_CRUD.Models.AppContext;

namespace Pr4_Partners_CRUD
{
    public partial class FormPartners : Form
    {

        AppContext db = new AppContext();
        Panel _selectedPanel;
        int index = 1;
        public FormPartners()
        {
            InitializeComponent();
        }

        private void PanelPartner_Click(object sender, System.EventArgs e)
        {
            if (_selectedPanel != null)
            {
                _selectedPanel.BackColor = Color.White;
            }

            _selectedPanel = (Panel)sender;
            _selectedPanel.BackColor = Color.Azure;
        }

        private void ButtonAddPartner_Click(object sender, System.EventArgs e)
        {

            FormAddPartner formAddPartner = new FormAddPartner();
            DialogResult result = formAddPartner.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            TypesOfPartner typeId = (TypesOfPartner)formAddPartner.comboBoxTypes.SelectedItem;

            Partner partner = new Partner
            {
                IdTypeOfPartner = typeId.Id,
                Name = formAddPartner.textBoxName.Text,
                Adress = formAddPartner.textBoxAdress.Text,
                Inn = formAddPartner.textBoxINN.Text,
                DirectorFullName = formAddPartner.textBoxDirectorFullName.Text,
                PhoneNumber = formAddPartner.textBoxPhoneNumber.Text,
                Email = formAddPartner.textBoxEmail.Text,
                Rating = Int16.Parse(formAddPartner.textBoxRating.Text)
            };


            db.Partners.Add(partner);
            db.SaveChanges();

            MessageBox.Show("Объект добавлен",
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CreatePanel(partner.Rating,
                partner.PhoneNumber,
                partner.DirectorFullName,
                db.TypesOfPartners.FirstOrDefault(u => u.Id == partner.IdTypeOfPartner).TypeOfPartner,
                partner.Name,
                partner.Id,
                0);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Partners.Load();
            this.db.TypesOfPartners.Load();

            List<Partner> partners = db.Partners.Local.OrderBy(o => o.Id).ToList();

            int discount = 0;

            List<PartnersProduct> partnersProducts;

            int sum = 0;

            foreach (var partner in partners)
            {

                db.PartnersProducts.Load();

                partnersProducts = db.PartnersProducts.Local
                   .Where(o => o.IdPartner == partner.Id)
                   .ToList();

                foreach (var item in partnersProducts)
                {
                    sum += item.Amount;
                }

                if (sum < 10000)
                {
                    discount = 0;
                }
                else if (sum >= 10000 && sum < 50000)
                {
                    discount = 5;
                }
                else if (sum >= 50000 && sum < 300000)
                {
                    discount = 10;
                }
                else if (sum >= 300000)
                {
                    discount = 15;
                }

                CreatePanel(partner.Rating,
                    partner.PhoneNumber,
                    partner.DirectorFullName,
                    db.TypesOfPartners.FirstOrDefault(u => u.Id == partner.IdTypeOfPartner).TypeOfPartner,
                    partner.Name,
                    partner.Id,
                    discount);

                sum = 0;
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (_selectedPanel == null)
            {
                MessageBox.Show("Выберите партнера для редактирования",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int id = Int32.Parse(_selectedPanel.Name.Split("panelPartner")[1]);

            Partner partner = db.Partners.FirstOrDefault(u => u.Id == id);

            FormAddPartner formAddPartner = new FormAddPartner(db.TypesOfPartners.FirstOrDefault(u => u.Id == partner.IdTypeOfPartner).TypeOfPartner);

            formAddPartner.Text = "Редактировать парнера";
            formAddPartner.buttonAdd.Text = "Редактировать";

            formAddPartner.textBoxName.Text = partner.Name;
            formAddPartner.textBoxDirectorFullName.Text = partner.DirectorFullName;
            formAddPartner.textBoxRating.Text = partner.Rating.ToString();
            formAddPartner.textBoxPhoneNumber.Text = partner.PhoneNumber;
            formAddPartner.textBoxEmail.Text = partner.Email;
            formAddPartner.textBoxINN.Text = partner.Inn;
            formAddPartner.textBoxAdress.Text = partner.Adress;

            DialogResult result = formAddPartner.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            TypesOfPartner typeId = (TypesOfPartner)formAddPartner.comboBoxTypes.SelectedItem;

            partner.Name = formAddPartner.textBoxName.Text;
            partner.DirectorFullName = formAddPartner.textBoxDirectorFullName.Text;
            partner.Rating = Int16.Parse(formAddPartner.textBoxRating.Text);
            partner.PhoneNumber = formAddPartner.textBoxPhoneNumber.Text;
            partner.Email = formAddPartner.textBoxEmail.Text;
            partner.Inn = formAddPartner.textBoxINN.Text;
            partner.Adress = formAddPartner.textBoxAdress.Text;
            partner.IdTypeOfPartner = typeId.Id;

            db.SaveChanges();

            _selectedPanel.Controls["labelRating" + id].Text = "Рейтинг: " + partner.Rating.ToString();
            _selectedPanel.Controls["labelPhoneNumber" + id].Text = "+7 " + partner.PhoneNumber;
            _selectedPanel.Controls["labelDirectorName" + id].Text = partner.DirectorFullName;
            _selectedPanel.Controls["labelName" + id].Text = typeId.TypeOfPartner + " | " + partner.Name;

            MessageBox.Show("Партнер отредактирован",
                                "Информация",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }

        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            if (_selectedPanel == null)
            {
                MessageBox.Show("Выберите партнера",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            int id = Int32.Parse(_selectedPanel.Name.Split("panelPartner")[1]);
            FormHistoryOfReailisation historyOfRealisation = new FormHistoryOfReailisation(id);

            DialogResult result = historyOfRealisation.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void CreatePanel(short? rating, string phoneNumber, string directorName, string typeOfPartner, string name, int index, int discount)
        {
            Panel panelPartner = new Panel();
            Label labelDiscount = new Label();
            Label labelRating = new Label();
            Label labelPhoneNumber = new Label();
            Label labelDirectorName = new Label();
            Label labelName = new Label();

            flowLayoutPanelFill.Controls.Add(panelPartner);

            // 
            // panelPartner
            // 
            panelPartner.BorderStyle = BorderStyle.FixedSingle;
            panelPartner.Controls.Add(labelDiscount);
            panelPartner.Controls.Add(labelRating);
            panelPartner.Controls.Add(labelPhoneNumber);
            panelPartner.Controls.Add(labelDirectorName);
            panelPartner.Controls.Add(labelName);
            panelPartner.Location = new Point(13, 13);
            panelPartner.Name = "panelPartner" + index;
            panelPartner.Padding = new Padding(10);
            panelPartner.AutoSize = true;
            panelPartner.TabIndex = 0;
            panelPartner.Click += this.PanelPartner_Click;
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = false;
            labelDiscount.Location = new Point(800, 10);
            labelDiscount.Name = "labelDiscount" + index;
            labelDiscount.Size = new Size(60, 25);
            labelDiscount.TabIndex = 4;
            labelDiscount.Text = discount + "%";
            // 
            // labelRating
            // 
            labelRating.AutoSize = true;
            labelRating.Dock = DockStyle.Top;
            labelRating.Font = new Font("Segoe UI", 12F);
            labelRating.Location = new Point(10, 77);
            labelRating.Name = "labelRating" + index;
            labelRating.Size = new Size(92, 21);
            labelRating.TabIndex = 3;
            //labelRating.Text = "Рейтинг: " + partner.Rating;
            labelRating.Text = "Рейтинг: " + rating;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Dock = DockStyle.Top;
            labelPhoneNumber.Font = new Font("Segoe UI", 12F);
            labelPhoneNumber.Location = new Point(10, 56);
            labelPhoneNumber.Name = "labelPhoneNumber" + index;
            labelPhoneNumber.Size = new Size(136, 21);
            labelPhoneNumber.TabIndex = 2;
            //labelPhoneNumber.Text = "+7 " + partner.PhoneNumber;
            labelPhoneNumber.Text = "+7 " + phoneNumber;
            // 
            // labelDirectorName
            // 
            labelDirectorName.AutoSize = true;
            labelDirectorName.Dock = DockStyle.Top;
            labelDirectorName.Font = new Font("Segoe UI", 12F);
            labelDirectorName.Location = new Point(10, 35);
            labelDirectorName.Name = "labelDirectorName" + index;
            labelDirectorName.Size = new Size(80, 21);
            labelDirectorName.TabIndex = 1;
            //labelDirectorName.Text = partner.DirectorFullName;
            labelDirectorName.Text = directorName;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Top;
            labelName.Location = new Point(10, 10);
            labelName.Name = "labelName" + index;
            labelName.Size = new Size(190, 25);
            labelName.TabIndex = 0;
            //labelName.Text = db.TypesOfPartners.FirstOrDefault(u => u.Id == partner.IdTypeOfPartner).TypeOfPartner + " | " + partner.Name;
            labelName.Text = typeOfPartner + " | " + name;
        }

        private void FormPartners_Load(object sender, EventArgs e)
        {

        }
    }
}
