﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExcleChange
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class yikatongEntities : DbContext
    {
        public yikatongEntities()
            : base("name=yikatongEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<card_make> card_make { get; set; }
        public virtual DbSet<customer> customer { get; set; }
        public virtual DbSet<kq_dept> kq_dept { get; set; }
        public virtual DbSet<M_Record> M_Record { get; set; }
    
        public virtual ObjectResult<SELECTDT_Result> SELECTDT(Nullable<System.DateTime> startDT, Nullable<System.DateTime> endDT, string dept)
        {
            var startDTParameter = startDT.HasValue ?
                new ObjectParameter("startDT", startDT) :
                new ObjectParameter("startDT", typeof(System.DateTime));
    
            var endDTParameter = endDT.HasValue ?
                new ObjectParameter("endDT", endDT) :
                new ObjectParameter("endDT", typeof(System.DateTime));
    
            var deptParameter = dept != null ?
                new ObjectParameter("dept", dept) :
                new ObjectParameter("dept", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SELECTDT_Result>("SELECTDT", startDTParameter, endDTParameter, deptParameter);
        }
    }
}