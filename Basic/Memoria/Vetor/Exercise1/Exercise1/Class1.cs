using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Estudante
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        
        public Estudante(string nome,string email) {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + ", "+ Email;
        }
    }
}
