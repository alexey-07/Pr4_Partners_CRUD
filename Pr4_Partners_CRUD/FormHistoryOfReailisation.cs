using Microsoft.EntityFrameworkCore;
using Pr4_Partners_CRUD.Models;
using AppContext = Pr4_Partners_CRUD.Models.AppContext;

namespace Pr4_Partners_CRUD
{
    public partial class FormHistoryOfReailisation : Form
    {
        int partnerId;
        public FormHistoryOfReailisation(int id)
        {
            InitializeComponent();
            partnerId = id;
        }

        private AppContext db = new AppContext();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            db.PartnersProducts.Load();
            db.Products.Load();
            var partner = db.Partners
            .Include(p => p.TypeOfPartner)  // Включаем тип партнера
            .FirstOrDefault(o => o.Id == partnerId);

            labelPartnerName.Text = partner != null
            ? $"{partner.TypeOfPartner.TypeOfPartner} - {partner.Name}"
            : "Неизвестный партнер";

            var partnersProducts = db.PartnersProducts
                .Include(o => o.IdProductNavigation)
                .Where(o => o.IdPartner == partnerId)
                .Select(i => new { i.IdProductNavigation.Name, i.Amount, i.DateOfSell, i.IdPartner })
                .ToList();

            if (partnersProducts.Count == 0)
            {
                MessageBox.Show("Нет записей о продажах для данного партнера.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.dataGridViewPartnersProducts.DataSource = partnersProducts;
                dataGridViewPartnersProducts.Columns["IdPartner"].Visible = false;
            }
        }
    }
}