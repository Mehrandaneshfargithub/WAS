﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DMSDataLayer.EntityModels
{
    public partial class TblReturnPurchaseInvoiceDetail
    {
        public int Id { get; set; }
        public int MasterId { get; set; }
        public int PurchaseInvoiceDetailId { get; set; }
        public decimal? Num { get; set; }
        public decimal? FreeNum { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? NumInPaakat { get; set; }
        public int? WarehouseId { get; set; }

        public virtual TblReturnPurchaseInvoice Master { get; set; }
        public virtual TblPurchaseInvoiceDetail PurchaseInvoiceDetail { get; set; }
    }
}
