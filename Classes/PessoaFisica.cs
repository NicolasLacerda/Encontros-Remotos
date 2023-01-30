using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encontros_Remotos.Interfaces;

namespace Encontros_Remotos.Classes
{
    public class pessoaFisica : Pessoa, InterfacePessoaFisica
    {
        public string? cpf{get; set;}

        public DateTime dataNasc{get; set;}

        public override float? calcularImposto(float rendimento)
        {
            if(rendimento <= 1500){
                return 0;
            }

            else if (rendimento > 1500 && rendimento <= 3500) {
                return rendimento * 0.02f;
            }

            else if (rendimento > 3500 && rendimento <= 6000) {
                return rendimento * 0.035f;
            }

            else {
                return rendimento * 0.05f;
            }

            throw new NotImplementedException();
        }

        public bool validarDatadeNasc(string dataNasc)
        {
            if(DateTime.TryParse(dataNasc, out DateTime dataConvertida)){

            DateTime dataAtual = DateTime.Today;
            double idade = (dataAtual - dataConvertida).TotalDays / 365;

            // Console.WriteLine(idade);

            if(idade >= 18){  
                return true;
            }

        }
            return false;
        }
    }
}