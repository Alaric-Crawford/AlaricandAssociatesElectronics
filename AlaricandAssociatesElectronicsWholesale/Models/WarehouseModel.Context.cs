﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlaricandAssociatesElectronicsWholesale.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class AlaricWholesaleEntities1 : DbContext
    {
        public AlaricWholesaleEntities1()
            : base("name=AlaricWholesaleEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    
        public virtual ObjectResult<Product> GetProductsByCategoryID(Nullable<int> categoryID)
        {
            var categoryIDParameter = categoryID.HasValue ?
                new ObjectParameter("CategoryID", categoryID) :
                new ObjectParameter("CategoryID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("GetProductsByCategoryID", categoryIDParameter);
        }
    
        public virtual ObjectResult<Product> GetProductsByCategoryID(Nullable<int> categoryID, MergeOption mergeOption)
        {
            var categoryIDParameter = categoryID.HasValue ?
                new ObjectParameter("CategoryID", categoryID) :
                new ObjectParameter("CategoryID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("GetProductsByCategoryID", mergeOption, categoryIDParameter);
        }
    }
}
