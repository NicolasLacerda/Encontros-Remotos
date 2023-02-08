using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontros_Remotos.Classes
{
    public abstract class Pessoa
    {
        
        public Endereco? endereco {get; set;}

        public float rendimento {get; set;}

        public abstract float? calcularImposto (float rendimento);

        public void VerificarPastaArquivoPj(string caminhoPj)
        {
            string pasta = caminhoPj.Split("/")[0];

            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(caminhoPj))
            {
                using(File.Create(caminhoPj))
                {

                }
            }
        }

        public void VerificarPastaArquivoPf(string caminhoPf)
        {
            string pasta = caminhoPf.Split("/")[0];

            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(caminhoPf))
            {
                using(File.Create(caminhoPf))
                {

                }
            }

        }
    }
}