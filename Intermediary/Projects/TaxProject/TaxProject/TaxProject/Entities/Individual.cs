using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxProject.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpeditures { get; set; }

        public Individual() { }

        public Individual(string name, double anualInCome, double healthExpeditures)
            : base(name, anualInCome)
        {
        }

        public override double Tax()
        {
            if (AnualInCome > 20000.00)
            {
                return AnualInCome * 0.15 - HealthExpeditures * 0.5;
            }
            else
            {
                return AnualInCome * 0.25 - HealthExpeditures * 0.5;
            }
        }
    }
}
