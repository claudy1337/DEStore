//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DEStore.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class basket
    {
        public int idBasket { get; set; }
        public Nullable<int> idProduct { get; set; }
    
        public virtual product product { get; set; }
    }
}
