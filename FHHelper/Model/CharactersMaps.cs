//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FHHelper.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CharactersMaps
    {
        public int Id { get; set; }
        public int Character_id { get; set; }
        public int Map_id { get; set; }
    
        public virtual Characters Characters { get; set; }
        public virtual Maps Maps { get; set; }
    }
}
