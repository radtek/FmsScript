//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Easyman.Service
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class EM_DB_TAG
    {
        public EM_DB_TAG()
        {
            this.EM_DB_SERVER = new HashSet<EM_DB_SERVER>();
        }
    [Key]
        public long ID { get; set; }
        public string NAME { get; set; }
        public string REMARK { get; set; }
        public System.DateTime CREATE_TIME { get; set; }
        public Nullable<long> CREATE_UID { get; set; }
        public Nullable<long> DELETE_UID { get; set; }
        public Nullable<System.DateTime> DELETE_TIME { get; set; }
        public short IS_DELETE { get; set; }
        public Nullable<System.DateTime> UPDATE_TIME { get; set; }
        public Nullable<long> UPDATE_UID { get; set; }
    
        public virtual ICollection<EM_DB_SERVER> EM_DB_SERVER { get; set; }
    }
}
