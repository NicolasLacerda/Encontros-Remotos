using Encontros_Remotos.Classes;

pessoaFisica pessoaF = new pessoaFisica();

pessoaF.nome = "Eduardo";
pessoaF.cpf = "458.248.658-99";
float? resultado = pessoaF.calcularImposto(7000);

Console.WriteLine("Bem-Vindo " +pessoaF.nome+ ", CPF:" +pessoaF.cpf+ ".");
Console.WriteLine("De acordo com seu rendimento atual seu imposto será no valor de: R$" + resultado);

pessoaJuridica pessoaJ = new pessoaJuridica();

pessoaJ.razaoSocial = "Google Brasil Internet LTDA";
pessoaJ.cnpj = "06.990.590/0001-23";
float? resultado2 = pessoaJ.calcularImposto(12000);

Console.WriteLine("Bem-Vindo " +pessoaJ.razaoSocial+ ", CNPJ:" +pessoaJ.cnpj+ ".");
Console.WriteLine("De acordo com seu rendimento atual seu imposto será no valor de: R$" + resultado2);
