using System;
using System.Collections.Generic;

public abstract class Product
{
    public string Name { get; set; }
    public virtual decimal Price { get; set; }

    public abstract string GetInformation();
}
