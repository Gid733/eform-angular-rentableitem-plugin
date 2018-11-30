﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RentableItems.Pn.Infrastructure.Models
{
    public class ContractInspectionsRequestModel
    {
        public string ContractId { get; set; }
        public string SortColumnName { get; set; }
        public int Offset { get; set; }
        public int PageSize { get; set; }
        public bool IsSortDsc { get; set; }
    }
}
