using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema{
    public class pessoaJuridica : pessoa {

        public string CNPJ { get; set; }

        public string RazaoSocial { get; set; }

        public string caminho { get; private set; } = "Database/PessoaJuricia.csv";

        public override float PagarImposto(float rendimento) { 

            if (rendimento <= 5000){
                return rendimento * 6/100;
            } else if (rendimento >5000 && rendimento <=10000){
                return rendimento = rendimento * 8 /100 ;
            }else if(rendimento >=100001) {
                return rendimento * 10 / 100;
            } else{
                return 0; 
            }
        }

        public bool ValidarCNPJ (string cnpj){

            if(cnpj.Length >= 14 && (cnpj.Substring(cnpj.Length - 4)) == "0001"){
                return true;
            }else{
                return false;
            }
        }

        public void Inserir(PessoaJuridica pj){

            VerificarPastaArquivo(caminho);

            string[] pjstring = {$"{pj.nome}, {pj.CNPJ}, {pj.RazaoSocial}"};

            File.AppendAllLines(caminho, pjstring);
        }

        public List<PessoaJuridica> Ler(){

            PessoaJuridica cadaPj = new PessoaJuridica();

            List<PessoaJuridica> listapj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas){
                string[] atributos = cadaLinha.Split(",");
                cadaPj.nome = atributos[0];
                cadaPj.CNPJ = atributos[1];
                cadaPj.RazaoSocial = atributos[2];

                listapj.Add(cadaPj);
            }
            return listapj;
        }
    }
}