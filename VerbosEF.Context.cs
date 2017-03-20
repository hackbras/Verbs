﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VerbosIrregulares
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class VerbosCS : DbContext
    {
        public VerbosCS()
            : base("name=VerbosCS")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<teste> testes { get; set; }
        public virtual DbSet<VerbosIrregulare> VerbosIrregulares { get; set; }
        public virtual DbSet<C_VerbosIrregulares> C_VerbosIrregulares { get; set; }
    
        [DbFunction("VerbosCS", "fn_verbos")]
        public virtual IQueryable<fn_verbos_Result> fn_verbos(string translate, string base_form, string past_form, string past_participle)
        {
            var translateParameter = translate != null ?
                new ObjectParameter("translate", translate) :
                new ObjectParameter("translate", typeof(string));
    
            var base_formParameter = base_form != null ?
                new ObjectParameter("base_form", base_form) :
                new ObjectParameter("base_form", typeof(string));
    
            var past_formParameter = past_form != null ?
                new ObjectParameter("past_form", past_form) :
                new ObjectParameter("past_form", typeof(string));
    
            var past_participleParameter = past_participle != null ?
                new ObjectParameter("past_participle", past_participle) :
                new ObjectParameter("past_participle", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_verbos_Result>("[VerbosCS].[fn_verbos](@translate, @base_form, @past_form, @past_participle)", translateParameter, base_formParameter, past_formParameter, past_participleParameter);
        }
    }
}