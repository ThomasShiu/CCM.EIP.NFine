/*******************************************************************************
 * Copyright © 2016 CCM.Framework 版权所有
 * Author: CCM
 * Description: CCM快速开发平台
 * Website：http://www.CCM.cn
*********************************************************************************/
using CCM.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace CCM.Mapping.SystemManage
{
    public class ItemsMap : EntityTypeConfiguration<ItemsEntity>
    {
        public ItemsMap()
        {
            this.ToTable("Sys_Items");
            this.HasKey(t => t.F_Id);
        }
    }
}
