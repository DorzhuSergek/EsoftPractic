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
    
    public partial class house_demands
    {
        public int Id { get; set; }
        public Nullable<int> IdDemands { get; set; }
        public Nullable<int> AgentId { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> MinFloors { get; set; }
        public Nullable<int> MaxFloors { get; set; }
        public Nullable<int> MinRooms { get; set; }
        public Nullable<int> MaxRooms { get; set; }
    
        public virtual agents agents { get; set; }
        public virtual clients clients { get; set; }
        public virtual Demands Demands { get; set; }
    }
}
