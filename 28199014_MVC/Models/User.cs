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
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int Id { get; set; }
        [Required]
        
        public string username { get; set; }
        [Required]
        public string usertype { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",ErrorMessage ="Email is not a valid email address !")]
        public string email { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]\w{5,17}$", ErrorMessage = "Password is not in a valid format !")]
        public string password { get; set; }
        [Required]
        public string birthday { get; set; }
        [Required]
        [Range(0,100)]
        public string age { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public string catsize { get; set; }
        [Required]
        public string catfur { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string petkeeping { get; set; }
        [Required]
        [RegularExpression(@"^http://([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$", ErrorMessage = "Url is not in a valid format  !")]
        public string url { get; set; }
        [Required]
        public string uphoto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
