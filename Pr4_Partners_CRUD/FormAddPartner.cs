using System.Data;
using Microsoft.EntityFrameworkCore;
using Pr4_Partners_CRUD.Models;
using AppContext = Pr4_Partners_CRUD.Models.AppContext;

namespace Pr4_Partners_CRUD
{
    public partial class FormAddPartner : Form
    {

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
    }
}
