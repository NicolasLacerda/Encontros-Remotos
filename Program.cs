using Encontros_Remotos.Classes;

pessoaFisica pessoaF = new pessoaFisica();
Endereco endPessoaF = new Endereco();

pessoaF.nome = "Eduardo Costa Silva";
pessoaF.cpf = "458.248.658-99";
pessoaF.endereco = endPessoaF;
endPessoaF.CEP = "25580-260";
endPessoaF.rua = "Rua Cecília Vilas Boas";
endPessoaF.numero = "30";
endPessoaF.complemento = "Proximo a Igreja.";
endPessoaF.endComercial = false;

float? resultado = pessoaF.calcularImposto(7000);

pessoaJuridica pessoaJ = new pessoaJuridica();

pessoaJ.razaoSocial = "Google Brasil Internet LTDA";
pessoaJ.cnpj = "06.991.991/0001-22";
float? resultado2 = pessoaJ.calcularImposto(12000);

Utils.BarraDeCarregamento("Carregando");

Console.WriteLine(@$"
======================================================
|                   !!!Bem-Vindo!!!                  | 
|                 Consulta já o valor                |
|                         de                         |  
|                seu imposto de renda                |  
======================================================
|          Digite o número da opção desejada         |
======================================================
|                                                    |
|                  1- Pessoa Física                  |
|                 2- Pessoa Jurídica                 |
|                                                    |
|                      0 - Sair                      |
======================================================
");

string? opcaoSelecionada;

opcaoSelecionada = Console.ReadLine();

Thread.Sleep(300);

switch (opcaoSelecionada)
{
    case "1":

        Console.WriteLine("================================================================================");
        Console.WriteLine(@$"
            Bem-Vindo
            Nome: {pessoaF.nome}, 
            CPF: {pessoaF.cpf},
            Endereço: {pessoaF.endereco.rua},
            Data de Nascimento: {pessoaF.dataNasc}
            Idade Válida: {pessoaF.validarDatadeNasc("01/01/2000")}
        ");
        Console.WriteLine("De acordo com seu rendimento atual seu imposto será no valor de: R$" + resultado);
        Console.WriteLine("================================================================================");
    
        break;
    
    case "2":

        Console.WriteLine("================================================================================");
        Console.WriteLine(@$"
            Bem-Vindo
            Razão Social: {pessoaJ.razaoSocial}, 
            CNPJ: {pessoaJ.cnpj},
            CNPJ Válido: {pessoaJ.validarCNPJ(pessoaJ.cnpj)}
        ");
        Console.WriteLine("De acordo com seu rendimento atual seu imposto será no valor de: R$" + resultado2);
        Console.WriteLine("================================================================================");

        break;

    case "0":
    
        Console.WriteLine("Obrigado por utilizar nosso sistema");
        Utils.BarraDeCarregamento("Finalizando");

        break;

    default:
    
        Console.WriteLine("Opção inválida, digite um dos valores indicados");
        Console.WriteLine("para continuar,tecle Enter");
        Console.ReadLine();
    
        break; 
}