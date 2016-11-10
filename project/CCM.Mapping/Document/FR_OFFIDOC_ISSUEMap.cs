using CCM.Domain.Entity.Document;
using CCM.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace CCM.Mapping.Document
{
    public class FR_OFFIDOC_ISSUEMap : EntityTypeConfiguration<FR_OFFIDOC_ISSUE_Entity>
    {
        public FR_OFFIDOC_ISSUEMap()
        {
            this.ToTable("FR_OFFIDOC_ISSUE");
            this.HasKey(t => t.ISSUEID);
        }
    }
}
