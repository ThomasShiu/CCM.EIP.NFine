/*******************************************************************************
 * Copyright © 2016 CCM.Web.Framework 版权所有
 * Author: CCM.Web
 * Description: CCM.Web快速开发平台
 * Website：http://www.CCM.Web.cn
*********************************************************************************/
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;

namespace CCM.Web.Data
{
    public class CCMDbContext : DbContext
    {
        public CCMDbContext()
            : base("IdentityConn")
        {
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        /// <summary>
        /// 自動映射實體
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            string assembleFileName = Assembly.GetExecutingAssembly().CodeBase.Replace("CCM.Data.DLL", "CCM.Mapping.DLL").Replace("file:///", "");
            Assembly asm = Assembly.LoadFile(assembleFileName);
            var typesToRegister = asm.GetTypes()
            .Where(type => !String.IsNullOrEmpty(type.Namespace))
            .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
