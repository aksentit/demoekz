//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace glazki_save.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class zakazy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zakazy()
        {
            this.clients = new HashSet<clients>();
            this.uslugi1 = new HashSet<uslugi>();
        }
    
        public int id { get; set; }
        public string code { get; set; }
        public Nullable<System.DateTime> date_creation { get; set; }
        public Nullable<System.TimeSpan> time { get; set; }
        public Nullable<int> code_client { get; set; }
        public string uslugi { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> date_of_closing { get; set; }
        public string time_prokat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<clients> clients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<uslugi> uslugi1 { get; set; }
    }
}