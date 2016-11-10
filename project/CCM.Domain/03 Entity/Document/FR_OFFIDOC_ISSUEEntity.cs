using System;
using System.ComponentModel.DataAnnotations;

namespace CCM.Domain.Entity.Document
{
    public class FR_OFFIDOC_ISSUE_Entity : IEntity<FR_OFFIDOC_ISSUE_Entity> //, ICreationAudited, IDeleteAudited, IModificationAudited
    {

        [Display(Name = "ISSUEID")]
        public string ISSUEID { get; set; }

        [Display(Name = "COMPANY")]
        public string COMPANY { get; set; }

        [Display(Name = "ISSUEDATE")]
        public DateTime ISSUEDATE { get; set; }


        [Display(Name = "OFFICIAL_NM")]
        public string OFFICIAL_NM { get; set; }

        [Display(Name = "SUBJECT")]
        public string SUBJECT { get; set; }

        [Display(Name = "DESCR")]
        public string DESCR { get; set; }

        [Display(Name = "AttachFIle")]
        public string AttachFIle { get; set; }

        [Display(Name = "EMPID")]
        public string EMPID { get; set; }

        [Display(Name = "DEPID")]
        public string DEPID { get; set; }

        [Display(Name = "STATUS")]
        public string STATUS { get; set; }

        [Display(Name = "DOCTYPE")]
        public string DOCTYPE { get; set; }

        [Display(Name = "CONTACT")]
        public string CONTACT { get; set; }
        [Display(Name = "PHONEAREACODE")]
        public string PHONEAREACODE { get; set; }

        [Display(Name = "PHONE")]
        public string PHONE { get; set; }

        [Display(Name = "PHONEEXTENSION")]
        public string PHONEEXTENSION { get; set; }

        [Display(Name = "FAX")]
        public string FAX { get; set; }

        [Display(Name = "Original")]
        public string Original { get; set; }

        [Display(Name = "Duplicate")]
        public string Duplicate { get; set; }

        [Display(Name = "GUID")]
        public string GUID { get; set; }

        //public string F_Id { get; set; }
        //public DateTime? F_CreatorTime { get; set; }
        //public string F_CreatorUserId { get; set; }
        //public DateTime? F_LastModifyTime { get; set; }
        //public string F_LastModifyUserId { get; set; }
        //public bool? F_DeleteMark { get; set; }
        //public DateTime? F_DeleteTime { get; set; }
        //public string F_DeleteUserId { get; set; }
    }
}
