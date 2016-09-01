using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SAPTechnicalTest.Models
{
    public class UserRegistration
    {
        [Key]
        public int UserID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Login ID")]
        [StringLength(50)]
        public string LoginID { get; set; }

        [Display(Name = "User group")]
        public string UserGroup { get; set; }

        public string Organisation { get; set; }

        public string Department { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }


        public string Status { get; set; }

        [Display(Name ="Approval Status")]
        public string Approval { get; set; }

        public class ApproveViewModel
        {
            public int ApprovalID { get; set; }
            public string ApprovalValue { get; set; }
        }

        public IEnumerable<ApproveViewModel> ApprovalOptions = new List<ApproveViewModel>
        {
            new ApproveViewModel {ApprovalID = 1, ApprovalValue = "Approved"},
            new ApproveViewModel {ApprovalID = 0, ApprovalValue = "Disapproved"},
        };

        public class DepartmentViewModel
        {
            public int DepartmentID { get; set; }
            public string DepartmentValue { get; set; }
        }

        public IEnumerable<DepartmentViewModel> DepartmentOptions = new List<DepartmentViewModel>
        {
            new DepartmentViewModel {DepartmentID = 0, DepartmentValue = "Software"},
            new DepartmentViewModel {DepartmentID = 1, DepartmentValue = "HR"},
            new DepartmentViewModel {DepartmentID = 2, DepartmentValue = "Marketting"},
            new DepartmentViewModel {DepartmentID = 3, DepartmentValue = "Sales"} 
        };


        public class UserGroupViewModel
        {
            public int UserGroupID { get; set; }
            public string UserGroupValue { get; set; }
        }

        public IEnumerable<UserGroupViewModel> UserGroupOptions = new List<UserGroupViewModel>
        {
            new UserGroupViewModel {UserGroupID = 0, UserGroupValue = "A"},
            new UserGroupViewModel {UserGroupID = 1, UserGroupValue = "B"},
            new UserGroupViewModel {UserGroupID = 2, UserGroupValue = "C"},
            new UserGroupViewModel {UserGroupID = 3, UserGroupValue = "D"}
        };

        public class OrganisationViewModel
        {
            public int OrganisationID { get; set; }
            public string OrganisationValue { get; set; }
        }

        public IEnumerable<OrganisationViewModel> OrganisationOptions = new List<OrganisationViewModel>
        {
            new OrganisationViewModel {OrganisationID = 0, OrganisationValue = "ABC"},
            new OrganisationViewModel {OrganisationID = 1, OrganisationValue = "BCD"},
            new OrganisationViewModel {OrganisationID = 2, OrganisationValue = "CDE"},
            new OrganisationViewModel {OrganisationID = 3, OrganisationValue = "DEF"}
        };

        public class StatusViewModel
        {
            public int StatusID { get; set; }
            public string StatusValue { get; set; }
        }

        public IEnumerable<StatusViewModel> StatusOptions = new List<StatusViewModel>
        {
            new StatusViewModel {StatusID = 0, StatusValue = "Active"},
            new StatusViewModel {StatusID = 1, StatusValue = "Inactive"}
        };
    }
}