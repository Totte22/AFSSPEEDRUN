//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace centrserver
{
    using System;
    using System.Collections.Generic;
    
    public partial class transaction
    {
        public int Id { get; set; }
        public int AFSInfo { get; set; }
        public int UserId { get; set; }
        public System.DateTime date { get; set; }
        public decimal moneyspend { get; set; }
    
        public virtual AFSInfo AFSInfo1 { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
