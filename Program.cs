using Encontros_Remotos.Classes;

pessoaFisica pessoaF = new pessoaFisica();
Endereco endPessoaF = new Endereco();

pessoaF.nome = "Eduardo";
pessoaF.cpf = "458.248.658-99";
pessoaF.endereco = endPessoaF;
endPessoaF.CEP = "25580-260";
endPessoaF.rua = "Rua Cecília Vilas Boas";
endPessoaF.numero = "30";
endPessoaF.complemento = "Proximo a Igreja.";
endPessoaF.endComercial = false;



float? resultado = pessoaF.calcularImposto(7000);

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

pessoaJuridica pessoaJ = new pessoaJuridica();

pessoaJ.razaoSocial = "Google Brasil Internet LTDA";
pessoaJ.cnpj = "06.991.991/0001-22";
float? resultado2 = pessoaJ.calcularImposto(12000);

Console.WriteLine(@$"
Bem-Vindo
Razão Social: {pessoaJ.razaoSocial}, 
CNPJ: {pessoaJ.cnpj},
CNPJ Válido: {pessoaJ.validarCNPJ(pessoaJ.cnpj)}
");
Console.WriteLine("De acordo com seu rendimento atual seu imposto será no valor de: R$" + resultado2);
Console.WriteLine("================================================================================");