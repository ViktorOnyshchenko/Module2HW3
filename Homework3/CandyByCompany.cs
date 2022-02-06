using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    public class CandyByCompany : ChocoCandy
    {
        public string CompanyName { get; protected set; }

        public CandyByCompany(string name, double weight, string companyName): base(name, weight)
        {
            CompanyName = companyName;
        }

        public void ChangeCompany(string companyName)
        {
            CompanyName = companyName;
        }
    }
}
