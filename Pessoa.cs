using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema{
    public class pessoa{

        public string? Nome { get; set; }

        public Endereco endereco { get; set; }

        public abstract float PagarImposto(float rendimento);

        public void VerificarPastaArquivo(string caminho) {

            string pasta = caminho.Split("/")[0];

            if (!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }
            if (!File.Exists(caminho)){
                using(File.Create(caminho));
            }
        }
    }
}