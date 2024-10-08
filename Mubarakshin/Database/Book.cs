//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mubarakshin.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int BookId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> MaxDiscountId { get; set; }
        public Nullable<int> MakerId { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> ActiveDiscountId { get; set; }
        public Nullable<int> Count { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    
        public virtual ActiveDiscount ActiveDiscount { get; set; }
        public virtual Category Category { get; set; }
        public virtual Maker Maker { get; set; }
        public virtual MaxDiscount MaxDiscount { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
