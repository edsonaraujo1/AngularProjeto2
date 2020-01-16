﻿using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using AngularProjeto2.Authorization.Roles;
using AngularProjeto2.Authorization.Users;
using AngularProjeto2.MultiTenancy;

namespace AngularProjeto2.EntityFramework
{
    public class AngularProjeto2DbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AngularProjeto2DbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AngularProjeto2DataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AngularProjeto2DbContext since ABP automatically handles it.
         */
        public AngularProjeto2DbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public AngularProjeto2DbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public AngularProjeto2DbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
