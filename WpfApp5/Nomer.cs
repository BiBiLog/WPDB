//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp5
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nomer
    {
        public int ID_Nomer { get; set; }
        public string Nomer1 { get; set; }
        public int ID_FIO { get; set; }
    
        public virtual FIO FIO { get; set; }
    }
}
