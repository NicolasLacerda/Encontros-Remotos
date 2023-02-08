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

        public void VerificarPastaArquivo(string caminho)
        {
            string pasta = caminho.Split("/")[0];

            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(caminho))
            {
                using (File.Create(caminho)){} 
            }
        }
    }
}