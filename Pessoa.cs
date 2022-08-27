using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema{
    public class pessoa{
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public bool EnderecoComercial { get; set; }
        public int MyProperty { get; set; }
        public void PagarImposto() {
        }
    }
}