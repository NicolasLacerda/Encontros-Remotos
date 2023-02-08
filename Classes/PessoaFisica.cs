using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encontros_Remotos.Interfaces;

namespace Encontros_Remotos.Classes
{
    public class pessoaFisica : Pessoa, InterfacePessoaFisica
    {
        public string? nome {get; set;}

        public string? cpf{get; set;}

        public string? dataNasc{get; set;}

        public string? cepPf { get; set; }
        
        public string? ruaPf { get; set; }

        public string? numeroPf { get; set; }

        public string? complementoPf { get; set; }

        public bool endComercialPf { get; set; }

        public string? impostoPf { get; set; }

        public string? enderecoComercialPf { get; set; }

        public string? rendimentoPf { get; set; } 

        public string caminhoPf {get; private set;} = "DatabasePf/PessoaFisica.csv";

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
        public bool ValidarDataNascimento(string dataNasc)
        {   
            DateTime dataConvertida;
            if(DateTime.TryParse(dataNasc, out dataConvertida)){
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays / 365;
                if (anos >= 18){
                    return true;
                }
                return false;  
            } 
            return false; 
        }

        internal bool ValidarDataNascimento(object dataNasc)
        {
            throw new NotImplementedException();
        }

        public void Inserir(pessoaFisica pf) //Fazer Cadastros
        {
            VerificarPastaArquivoPf(caminhoPf);

            string[] pfString = {$"{pf.nome}, {pf.cpf}, {pf.dataNasc}, {pf.cepPf}, {pf.ruaPf}, {pf.numeroPf}, {pf.complementoPf}, {pf.endComercialPf}, {pf.rendimento}, {calcularImposto(pf.rendimento)}"};

            File.AppendAllLines(caminhoPf, pfString);
        }

        public List<pessoaFisica> Ler() //Mostrar Cadastros
        {
            List<pessoaFisica> listaPf = new List<pessoaFisica>();

            string[] linhas = File.ReadAllLines(caminhoPf);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");
                pessoaFisica cadaPf = new pessoaFisica();

                cadaPf.nome = atributos[0];
                cadaPf.cpf = atributos[1];
                cadaPf.dataNasc = atributos[2];
                cadaPf.cepPf = atributos[3];
                cadaPf.ruaPf = atributos[4];
                cadaPf.numeroPf = atributos[5];
                cadaPf.complementoPf = atributos[6];
                cadaPf.enderecoComercialPf = atributos[7];
                cadaPf.rendimentoPf = atributos[8];
                cadaPf.impostoPf = atributos[9];

                listaPf.Add(cadaPf);
            }

            return listaPf;
        }

    }
}