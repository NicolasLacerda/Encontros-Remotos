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
        public string? cnpj{get; set;}

        public string? razaoSocial{get; set;}

        public string? CEP { get; set; }
        
        public string? rua { get; set; }

        public string? numero { get; set; }

        public string? complemento { get; set; }

        public bool endComercial { get; set; }

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
        public void Inserir(pessoaJuridica pj)
        {
            VerificarPastaArquivo(caminho);

            string[] pjString = {$"{pj.razaoSocial}, {pj.cnpj}, {pj.CEP}, {pj.rua}, {pj.numero}, {pj.complemento}, {pj.endComercial}"};

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
                
            
                cadaPj.razaoSocial = atributos[0];
                cadaPj.cnpj = atributos[1];
                cadaPj.CEP = atributos[2];
                cadaPj.rua = atributos[3];
                cadaPj.numero = atributos[4];
                cadaPj.complemento = atributos[5];
                atributos[6] = ((bool)(cadaPj.endComercial)?"Sim":"Não");

                listaPj.Add(cadaPj);
            }

            return listaPj;
        }
    }
}