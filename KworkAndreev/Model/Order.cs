//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KworkAndreev.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrdersID { get; set; }
        public int UserID { get; set; }
        public System.DateTime Times { get; set; }
        public string Status { get; set; }
        public int ServicesID { get; set; }
    
        public virtual Service Service { get; set; }
        public virtual User User { get; set; }
    }
}
