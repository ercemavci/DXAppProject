using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApp.Data
{
    public class HR_Employees
    {
        [Key]
        public int Id { get; set; }
        public string RegisterNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Name2 { get; set; }
        public string Surname2 { get; set; }
        public string FatherName2 { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? EnterDate { get; set; }
        public string CountryOfBirth { get; set; }
        public string Gender { get; set; }
        public string EmployeesPhotoId { get; set; }
        public string Email { get; set; }
        public string PassportNo { get; set; }
        public string Phone1 { get; set; }
        public string IsLeft { get; set; }
        public string NotBack { get; set; }
        public DateTime? LeftDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
