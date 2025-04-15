using System.Data;
using Microsoft.EntityFrameworkCore;
using Pr4_Partners_CRUD.Models;
using AppContext = Pr4_Partners_CRUD.Models.AppContext;

namespace Pr4_Partners_CRUD
{
    public partial class FormAddPartner : Form
    {
        string msgError = "Поле не может быть пустым";
        private AppContext db = new AppContext();

        private string type;

        public FormAddPartner()
        {
            InitializeComponent();
        }
        public FormAddPartner(string type)
        {
            InitializeComponent();
            this.type = type;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.db.TypesOfPartners.Load();

            List<TypesOfPartner> typesOfParners = this.db.TypesOfPartners.Local.OrderBy(o => o.TypeOfPartner).ToList();

            comboBoxTypes.DataSource = typesOfParners;
            comboBoxTypes.DisplayMember = "typesOfPartners";
            comboBoxTypes.ValueMember = "typeOfPartner";
            if (type != null)
            {
                comboBoxTypes.SelectedValue = type;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, пустое ли поле
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                errorProviderName.SetError(textBoxName, msgError);
                buttonAdd.Enabled = false; // Деактивируем кнопку "Сохранить"
            }
            else
            {
                errorProviderName.Clear();
                buttonAdd.Enabled = true; // Активируем кнопку "Сохранить"
            }
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                errorProviderName.SetError(textBoxName, msgError);
                buttonAdd.Enabled = false;
            }
            else
            {
                errorProviderName.Clear();
                buttonAdd.Enabled = true;
            }
        }

        private void textBoxAdress_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxAdress.Text))
            {
                errorProviderAdress.SetError(textBoxAdress, msgError);
                buttonAdd.Enabled = false; // Деактивируем кнопку "Сохранить"
            }
            else
            {
                errorProviderName.Clear();
                buttonAdd.Enabled = true; // Активируем кнопку "Сохранить"
            }
        }

        private void textBoxAdress_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxAdress.Text))
            {
                errorProviderAdress.SetError(textBoxAdress, msgError);
                buttonAdd.Enabled = false;
            }
            else
            {
                errorProviderName.Clear();
                buttonAdd.Enabled = true;
            }
        }

        private void textBoxINN_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxINN.Text))
            {
                errorProviderInn.SetError(textBoxINN, msgError);
                buttonAdd.Enabled = false; // Деактивируем кнопку "Сохранить"
            }
            else
            {
                errorProviderInn.Clear();
                buttonAdd.Enabled = true; // Активируем кнопку "Сохранить"
            }
        }

        private void textBoxINN_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxINN.Text))
            {
                errorProviderInn.SetError(textBoxINN, msgError);
                buttonAdd.Enabled = false;
            }
            else
            {
                errorProviderInn.Clear();
                buttonAdd.Enabled = true;
            }
        }

        private void textBoxDirectorFullName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxDirectorFullName.Text))
            {
                errorProviderDirectory.SetError(textBoxDirectorFullName, msgError);
                buttonAdd.Enabled = false; // Деактивируем кнопку "Сохранить"
            }
            else
            {
                errorProviderDirectory.Clear();
                buttonAdd.Enabled = true; // Активируем кнопку "Сохранить"
            }
        }

        private void textBoxDirectorFullName_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxDirectorFullName.Text))
            {
                errorProviderDirectory.SetError(textBoxDirectorFullName, msgError);
                buttonAdd.Enabled = false;
            }
            else
            {
                errorProviderDirectory.Clear();
                buttonAdd.Enabled = true;
            }
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPhoneNumber.Text))
            {
                errorProviderNumber.SetError(textBoxPhoneNumber, msgError);
                buttonAdd.Enabled = false; // Деактивируем кнопку "Сохранить"
            }
            else
            {
                errorProviderNumber.Clear();
                buttonAdd.Enabled = true; // Активируем кнопку "Сохранить"
            }
        }

        private void textBoxPhoneNumber_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPhoneNumber.Text))
            {
                errorProviderNumber.SetError(textBoxPhoneNumber, msgError);
                buttonAdd.Enabled = false;
            }
            else
            {
                errorProviderNumber.Clear();
                buttonAdd.Enabled = true;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxEmail.Text))
            {
                errorProviderMail.SetError(textBoxEmail, msgError);
                buttonAdd.Enabled = false; // Деактивируем кнопку "Сохранить"
            }
            else
            {
                errorProviderMail.Clear();
                buttonAdd.Enabled = true; // Активируем кнопку "Сохранить"
            }
        }

        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxEmail.Text))
            {
                errorProviderMail.SetError(textBoxEmail, msgError);
                buttonAdd.Enabled = false;
            }
            else
            {
                errorProviderMail.Clear();
                buttonAdd.Enabled = true;
            }
        }

        private void textBoxRating_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxRating.Text))
            {
                errorProviderRaiting.SetError(textBoxRating, msgError);
                buttonAdd.Enabled = false; // Деактивируем кнопку "Сохранить"
            }
            else
            {
                errorProviderRaiting.Clear();
                buttonAdd.Enabled = true; // Активируем кнопку "Сохранить"
            }
        }

        private void textBoxRating_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxRating.Text))
            {
                errorProviderRaiting.SetError(textBoxRating, msgError);
                buttonAdd.Enabled = false;
            }
            else
            {
                errorProviderRaiting.Clear();
                buttonAdd.Enabled = true;
            }
        }
    }
}
