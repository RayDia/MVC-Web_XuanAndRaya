//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace _28199014_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int oid { get; set; }
        public System.DateTime orderData { get; set; }
        public string orderDescription { get; set; }
        public int orderuid { get; set; }
        public int ordercid { get; set; }
    
        public virtual Cat Cat { get; set; }
        public virtual User User { get; set; }
    }
}
