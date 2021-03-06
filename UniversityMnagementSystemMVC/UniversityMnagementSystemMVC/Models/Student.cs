//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace UniversityMnagementSystemMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public Student()
        {
            this.EnrollInACourses = new HashSet<EnrollInACourse>();
            this.Results = new HashSet<Result>();
        }
    
        public int StudentId { get; set; }
        public string RegNo { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Email address")]
        [Remote(action: "EmailExists", controller: "Students", ErrorMessage = "This Code Exists, Try new One")]
        [Display(Name = "Students Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Contact Number")]
        [Remote(action: "ContactExists", controller: "Students", ErrorMessage = "This Code Exists, Try new One")]
        [Display(Name = "Students Contact Number")]
        public string ContactNo { get; set; }
        public System.DateTime Date { get; set; }
        public string Address { get; set; }
        public int DeptId { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<EnrollInACourse> EnrollInACourses { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
