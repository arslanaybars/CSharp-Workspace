//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    [MetadataType(typeof(EmployeeMetadata))]
    [DisplayColumn("FullName")]
    public partial class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public System.DateTime HireDate { get; set; }
        public string EmailAddress { get; set; }
        public int Salary { get; set; }
        public string PersonalWebSite { get; set; }
    }

    public class EmployeeMetadata
    {
        [ReadOnly(true)]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [DisplayAttribute(Name = "Full Name")]
        public string FullName { get; set; }

        //[DisplayFormat(DataFormatString="{0:d}")]
        //public DateTime HireDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]
        [DisplayAttribute(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        // NULL display
        [DisplayFormat(NullDisplayText = "Gender is not specified")]
        public string Gender { get; set; }

        // If you dont want to display column use ScaffoldColumn attribute
        // this only works when you use @Html.DisplayForModel() helper
        [HiddenInput(DisplayValue=false)]
        public int? Id { get; set; }

        [ScaffoldColumn(true)]
        [DataType(DataType.Currency)]
        public int? Salary { get; set; }
        // Notice that Id and Salary properties
        // are not displayed in the user interface

        [DataType(DataType.Url)]
        [UIHint("OpenInNewWindow")]
        public string PersonalWebSite { get; set; }
    }
}