using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema{
    public class pessoaFisica : pessoa{

        public string? CPF { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public float salario { get; set; }
        
        public override void PagarImposto(float salario){
            if (salario <= 1500){
                return 0;
            }else if (salario >= 1501 && salario <= 5000){
                return salario  = salario * 3/100;
            }else if (){
                return salario * 5/100;
            }else {
                return 0;
            }
        }

        public boo ValidaDataNascimento(DataTime dataNascimento){

            DataTime dataAtual = DataTime.Today;

            double anos = (dataAtual - dataNascimento).TotalDays /365;

            if (anos >= 18){
                return true;
            }else{
                return false;
            }
        }
        
    }
}