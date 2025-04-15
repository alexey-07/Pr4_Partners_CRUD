namespace Pr4_Partners_CRUD.Models;

public partial class TypesOfPartner
{
    public string TypeOfPartner { get; set; } = null!;

    public short Id { get; set; }

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}
