﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetFood.Entities {
  public class PurchaseBO {
    public int Id { get; set; }
    public int IngredientId { get; set; }
    public int Count { get; set; }
    public DateTime Date { get; set; }
    public int PricePerItem { get; set; }
    public PartnerBO? Purveyor { get; set; }
    public string? Comment { get; set; }
  }
}
