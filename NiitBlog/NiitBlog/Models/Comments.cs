//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NiitBlog.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comments
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public Nullable<int> AID { get; set; }
        public Nullable<int> PID { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int UID { get; set; }
        public Nullable<int> ParentId { get; set; }
    
        public virtual Articles Articles { get; set; }
        public virtual Photos Photos { get; set; }
        public virtual Users Users { get; set; }
    }
}
