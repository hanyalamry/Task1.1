﻿using System;
using System.Collections.Generic;

namespace Task1._1.entities;

public partial class VStoreWithAddress
{
    public int BusinessEntityId { get; set; }

    public string Name { get; set; } = null!;

    public string AddressType { get; set; } = null!;

    public string AddressLine1 { get; set; } = null!;

    public string? AddressLine2 { get; set; }

    public string City { get; set; } = null!;

    public string StateProvinceName { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string CountryRegionName { get; set; } = null!;
}
