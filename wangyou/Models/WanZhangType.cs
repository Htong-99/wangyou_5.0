//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace wangyou.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WanZhangType
    {
        public WanZhangType()
        {
            this.WenZhang = new HashSet<WenZhang>();
        }
    
        public int WenZhangTypeID { get; set; }
        public string WenZhangTypeNmae { get; set; }
    
        public virtual ICollection<WenZhang> WenZhang { get; set; }
    }
}
