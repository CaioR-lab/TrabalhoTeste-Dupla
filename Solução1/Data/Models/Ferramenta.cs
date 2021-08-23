using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Ferramenta : Base
    {
        private string _nome;  
        public float Peso { get; set; }
        public decimal Valor { get; set; }

        public string Nome {
            get { return _nome; }
            set 
            { 
                if (_nome.Length > 5)
                {
                    _nome = value;
                }
                else
                {
                    throw new ArgumentException("Numero de caracteres deve ser maior que 5");
                }
            } 
        }
    }
}
