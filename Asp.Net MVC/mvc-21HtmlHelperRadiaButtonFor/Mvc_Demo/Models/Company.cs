using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Demo.Models
{
    public class Company
    {
        private string _name;
        
        public Company()
        {

        }

        public Company(string name)
        {
            this._name = name;
        }

        public List<Department> Departments
        {
            get
            {
                SampleDBContext db = new SampleDBContext();
                return db.Departments.ToList();
            }
        }

        public string CompanyName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string SelectedDepartment { get; set; }
    }
}