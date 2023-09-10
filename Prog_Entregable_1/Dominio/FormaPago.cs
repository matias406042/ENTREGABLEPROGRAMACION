using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Entregable_1.Entities
{
    public class FormaPago
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public FormaPago() { }
        public FormaPago(int id,string name) {

            Id = id;
            Name = name;
        }
       public override string ToString()
        {

            return  Name+" yesss"; 
        }
    }
}
