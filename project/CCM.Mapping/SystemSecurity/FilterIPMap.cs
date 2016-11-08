/*******************************************************************************
 * Copyright © 2016 CCM.Framework 版权所有
 * Author: CCM
 * Description: CCM快速开发平台
 * Website：http://www.CCM.cn
*********************************************************************************/
using CCM.Domain.Entity.SystemSecurity;
using System.Data.Entity.ModelConfiguration;

namespace CCM.Mapping.SystemSecurity
{
    public class FilterIPMap : EntityTypeConfiguration<FilterIPEntity>
    {
        public FilterIPMap()
        {
            this.ToTable("Sys_FilterIP");
            this.HasKey(t => t.F_Id);
        }
    }
}
