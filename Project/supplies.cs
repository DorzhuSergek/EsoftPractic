//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class supplies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public supplies()
        {
            this.deals = new HashSet<deals>();
        }
    
        public int Id { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> AgentId { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> IdDIstrict { get; set; }
    
        public virtual agents agents { get; set; }
        public virtual clients clients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<deals> deals { get; set; }
        public virtual districts districts { get; set; }
    }
}
