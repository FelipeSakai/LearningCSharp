using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxProject.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployee { get; set; }

        public Company() { }

        public Company(string name, double anualInCome, int numberOfEmployee)
            : base(name, anualInCome)
        {
        }

        public override double Tax()
        {
            if (NumberOfEmployee > 10)
            {
                return AnualInCome * 0.14;
            }
            else
            {
                return AnualInCome * 0.16;
            }
        }
    }
}
