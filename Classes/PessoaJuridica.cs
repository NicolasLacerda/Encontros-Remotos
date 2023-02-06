using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Encontros_Remotos.Interfaces;

namespace Encontros_Remotos.Classes
{
    public class pessoaJuridica : Pessoa, InterfacePessoaJuridica
    {
        public string? cnpjPj{get; set;}

        public string? razaoSocialPj{get; set;}

        public string? cepPj { get; set; }
        
        public string? ruaPj { get; set; }

        public string? numeroPj { get; set; }

        public string? complementoPj { get; set; }

        public bool endComercialPj { get; set; }

        public string? impostoPj { get; set; }

        public string? enderecoComercialPj { get; set; }

        public string? rendimentoPj { get; set; }        

        public string caminho {get; private set;} = "Database/PessoaJuridica.csv";

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

            bool validacaoCNPJ14 = Regex.IsMatch(cnpj, @"^(\d{14})$");

            if(validacaoCNPJ14){

                string substringCNPJ14 = cnpj.Substring(8, 4);

                    if(substringCNPJ14 == "0001"){
                        return true;
                    }
            }

            bool validacaoCNPJ18 = Regex.IsMatch(cnpj, @"^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$");

            if(validacaoCNPJ18){            
                string substringCNPJ18 = cnpj.Substring(11, 4);

                    if(substringCNPJ18 == "0001"){
                        return true;
                    }
            }
            
            return false;
        }
        public void Inserir(pessoaJuridica pj) //Fazer Cadastros
        {
            VerificarPastaArquivo(caminho);

            string[] pjString = {$"{pj.razaoSocialPj}, {pj.cnpjPj}, {pj.cepPj}, {pj.ruaPj}, {pj.numeroPj}, {pj.complementoPj}, {pj.endComercialPj}, {pj.rendimento}, {calcularImposto(pj.rendimento)}"};

            File.AppendAllLines(caminho, pjString);
        }

        public List<pessoaJuridica> Ler() //Mostrar Cadastros
        {
            List<pessoaJuridica> listaPj = new List<pessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");
                pessoaJuridica cadaPj = new pessoaJuridica();
            
                cadaPj.razaoSocialPj = atributos[0];
                cadaPj.cnpjPj = atributos[1];
                cadaPj.cepPj = atributos[2];
                cadaPj.ruaPj = atributos[3];
                cadaPj.numeroPj = atributos[4];
                cadaPj.complementoPj = atributos[5];
                cadaPj.enderecoComercialPj = atributos[6];
                cadaPj.rendimentoPj = atributos[7];
                cadaPj.impostoPj = atributos[8];

                listaPj.Add(cadaPj);
            }

            return listaPj;
        }
    }
}