namespace Pr4_Partners_CRUD.Models;

public partial class Product
{
    public int Id { get; set; }

    public short IdTypeOfProduct { get; set; }

    public string Name { get; set; } = null!;

    public string Article { get; set; } = null!;

    public decimal MinimalCost { get; set; }

    public virtual TypesOfProduct IdTypeOfProductNavigation { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
