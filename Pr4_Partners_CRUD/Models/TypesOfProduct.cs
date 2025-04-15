﻿namespace Pr4_Partners_CRUD.Models;

public partial class TypesOfProduct
{
    public short Id { get; set; }

    public string TypeOfProduct { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
