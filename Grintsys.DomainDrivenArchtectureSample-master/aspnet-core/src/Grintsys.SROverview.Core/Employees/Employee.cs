using Abp.Domain.Entities;
using System;

namespace Grintsys.SROverview.Employees
{
    public class Employee : Entity
    {
        public String Name { get; set; }
        public String Address { get; set; }
        public String Celphone { get; set; }
        public String Identity { get; set; }
    }
}
