using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encontros_Remotos.Interfaces;

namespace Encontros_Remotos.Classes
{
    public class pessoaJuridica : Pessoa, InterfacePessoaJuridica
    {
        public string? cnpj{get; set;}

        public string? razaoSocial{get; set;}

        public override float? calcularImposto(float rendimento)
        {
            if(rendimento <= 3000){
                return rendimento * 0.03f;
            }

            else if (rendimento > 3000 && rendimento <= 6000) {
                return rendimento * 0.05f;
            }

            else if (rendimento > 6000 && rendimento <= 10000) {
                return rendimento * 0.07f;
            }

            else {
                return rendimento * 0.09f;
            }
            throw new NotImplementedException();
        }

        public bool validarCNPJ(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}