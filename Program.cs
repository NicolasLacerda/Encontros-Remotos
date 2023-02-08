using Encontros_Remotos.Classes;

Utils.BarraDeCarregamento("Carregando",300);

Console.Clear();

Thread.Sleep(500);
Console.WriteLine(@$"
======================================================
|         Bem vindo ao sistema de cadastro de        |
|            Pessoas Físicas e Jurídicas             |
======================================================
");

Thread.Sleep(2500);
Console.Clear();

string? opcao;
do{
Console.Clear();
Console.WriteLine(@$"
======================================================
|          Digite o número da opção desejada         |
======================================================
|                                                    |
|                  1- Pessoa Física                  |
|                 2- Pessoa Jurídica                 |
|                                                    |
======================================================
|                                                    |
|                      0 - Sair                      |
======================================================
");

opcao = Console.ReadLine();

switch (opcao)
{
    case "1": //Pessoa Física

        pessoaFisica metodoPf = new pessoaFisica();

        string? opcaoPf;
        do
        {

        Console.Clear();
        Console.WriteLine(@$"
======================================================
|          Digite o número da opção desejada         |
======================================================
|                                                    |
|             1- Cadastrar Pessoa Física             |
|             2- Mostrar Pessoas Físicas             |
|                                                    |
======================================================
|                                                    |
|             0- Voltar ao menu anterior             |
======================================================
");
        opcaoPf = Console.ReadLine();
            switch (opcaoPf) //Menu cadastrar pessoa fisica ou mostrar.
                {
                    case "1": //Cadastro de pessoa fisica
                    Console.Clear();
                    pessoaFisica novaPf = new pessoaFisica();
                    Endereco novoEnd = new Endereco();

                        Console.Clear();
                        Console.WriteLine(@$"
===================================
|    Bem-Vindo                    |
|    Digite seu nome completo:    |
===================================
");
                        novaPf.nome = Console.ReadLine();
                        Console.Clear();

                    bool dataValida;
                    do
                    {
                        Console.WriteLine(@$"
==================================================
|         Digite sua data de nascimento:         |
==================================================
");
                        string? dataNascimento = Console.ReadLine()!;

                        dataValida = metodoPf.ValidarDataNascimento(dataNascimento);

                        if (dataValida)
                        {
                            novaPf.dataNasc = dataNascimento;
                        }
                        else    
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Data digitada inválida, por favor digite uma data válida");
                            Console.ResetColor();
                        }  
                    } while (dataValida == false);

                        Console.Clear();
                        Console.WriteLine(@$"
===================================
|         Digite seu CPF:         |
===================================
");
                        novaPf.cpf = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine(@$"
===================================
|         Digite seu CEP:         |
===================================
");
                        novaPf.cepPf = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine(@$"
===================================
|         Digite seu Rua:         |
===================================
");
                        novaPf.ruaPf = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine(@$"
===================================
|        Digite seu Número:       |
===================================
");
                        novaPf.numeroPf = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine(@$"
===================================
|     Digite seu Complemento:     |
===================================
");
                        novaPf.complementoPf = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine(@$"
================================================
|    Este endereço é comercial? Sim ou Não:    |
================================================
");
                        string endCom = Console.ReadLine()!.ToUpper();
                        if(endCom == "SIM")
                        {
                            novaPf.endComercialPf = true;
                        }
                        else{
                            novaPf.endComercialPf = false;
                        }

                        Console.Clear();
                        Console.WriteLine(@$"
===================================
|      Digite seu Rendimento:     |
===================================
");
                        novaPf.rendimento = float.Parse(Console.ReadLine()!);

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(@$"
================================================
|        Cadastro realizado com sucesso        |
================================================
");
                        Thread.Sleep(1500);
                        Console.ResetColor();
                        metodoPf.Inserir(novaPf);

                    break;

    case "2":
        Console.Clear();
        List<pessoaFisica> listaPf = metodoPf.Ler();

        if (listaPf.Count > 0)
        {
            foreach (pessoaFisica cadaPessoaF in listaPf)
            {
                 Console.Clear();
                        Console.WriteLine(@$"
                        Nome: {cadaPessoaF.nome}
                        Cpf: {cadaPessoaF.cpf}
                        Data de Nascimento: {cadaPessoaF.dataNasc}
                        Cep: {cadaPessoaF.cepPf}
                        Rua: {cadaPessoaF.ruaPf}
                        Numero: {cadaPessoaF.numeroPf}
                        Complemento: {cadaPessoaF.complementoPf}
                        Endereço Comercial? {cadaPessoaF.enderecoComercialPf}
                        Rendimento: R${cadaPessoaF.rendimentoPf},00
                        Taxa de Imposto a ser paga: R${cadaPessoaF.impostoPf},00
                        ");
                        
                Console.WriteLine($"Aperte 'Enter'para continuar...");
                Console.ReadLine();
            }
        }
        else
            {
                Console.WriteLine($"Lista Vazia!!!");
                Thread.Sleep(3000);
            }

        break;
    case "0":
        Console.Clear();
        Console.WriteLine(@$"
=================================================
|      Obrigado por Utilizar nosso sistema      |
=================================================
");
        Utils.BarraDeCarregamento("Finalizando",300);

        break;

    default:
    
        Console.WriteLine("Opção inválida, digite um dos valores indicados");
        Console.WriteLine("para continuar,tecle Enter");
        Console.ReadLine();
        break;
        }

    } while (opcaoPf != "0");

        break;
        
//-----------------------------------------------------------------------------------------------//

    case "2": //Pessoa Juridica

        pessoaJuridica metodoPj = new pessoaJuridica();

        string? opcaoPj;
        do
        {

        Console.Clear();
        Console.WriteLine(@$"
======================================================
|          Digite o número da opção desejada         |
======================================================
|                                                    |
|            1- Cadastrar Pessoa Jurídica            |
|            2- Mostrar Pessoas Jurídicas            |
|                                                    |
======================================================
|                                                    |
|             0- Voltar ao menu anterior             |
======================================================
");
        opcaoPj = Console.ReadLine();
            switch (opcaoPj) //Menu cadastrar pessoa Juridica ou mostrar.
                {
                    case "1": //Cadastro de pessoa Juridica
                    Console.Clear();
                    pessoaJuridica novaPj = new pessoaJuridica();

                        Console.Clear();
                        Console.WriteLine(@$"
===================================
|    Bem-Vindo                    |
|    Digite sua Razão Social:     |
===================================
");
                        novaPj.razaoSocialPj = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine(@$"
===================================
|        Digite seu CNPJ:         |
===================================
");
                        novaPj.cnpjPj = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine(@$"
===================================
|         Digite seu CEP:         |
===================================
");
                        novaPj.cepPj = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine(@$"
===================================
|         Digite seu Rua:         |
===================================
");
                        novaPj.ruaPj = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine(@$"
===================================
|        Digite seu Número:       |
===================================
");
                        novaPj.numeroPj = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine(@$"
===================================
|     Digite seu Complemento:     |
===================================
");
                        novaPj.complementoPj = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine(@$"
================================================
|    Este endereço é comercial? Sim ou Não:    |
================================================
");
                        string endCom = Console.ReadLine()!.ToUpper();
                        if(endCom == "SIM")
                        {
                            novaPj.endComercialPj = true;
                        }
                        else{
                            novaPj.endComercialPj = false;
                        }

                        Console.Clear();
                        Console.WriteLine(@$"
===================================
|      Digite seu Rendimento:     |
===================================
");
                        novaPj.rendimento = float.Parse(Console.ReadLine()!);

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(@$"
================================================
|        Cadastro realizado com sucesso        |
================================================
");

                        Thread.Sleep(1500);
                        Console.ResetColor();
                        metodoPj.Inserir(novaPj);

                    break;

    case "2":
        Console.Clear();
        List<pessoaJuridica> listaPj = metodoPj.Ler();

        if (listaPj.Count > 0)
        {
            foreach (pessoaJuridica cadaPessoaJ in listaPj)
            {
                 Console.Clear();
                        Console.WriteLine(@$"
                        Razão Social: {cadaPessoaJ.razaoSocialPj}
                        CNPJ: {cadaPessoaJ.cnpjPj}
                        Cep: {cadaPessoaJ.cepPj}
                        Rua: {cadaPessoaJ.ruaPj}
                        Numero: {cadaPessoaJ.numeroPj}
                        Complemento: {cadaPessoaJ.complementoPj}
                        Endereço Comercial? {cadaPessoaJ.enderecoComercialPj}
                        Rendimento: R${cadaPessoaJ.rendimentoPj},00
                        Taxa de Imposto a ser paga: R${cadaPessoaJ.impostoPj},00
                        ");
                        
                Console.WriteLine($"Aperte 'Enter'para continuar...");
                Console.ReadLine();
            }
        }
        else
            {
                Console.WriteLine($"Lista Vazia!!!");
                Thread.Sleep(3000);
            }
        break;
    case "0":
        Console.Clear();
        Console.WriteLine(@$"
=================================================
|      Obrigado por Utilizar nosso sistema      |
=================================================
");
        Utils.BarraDeCarregamento("Carregando",300);
        break;
    default:
        Console.Clear();
        Console.WriteLine($"Opção Inválida, por favor digite outra opção.");
        Thread.Sleep(3000);
        break;
        }

    } while (opcaoPj != "0");

        break;
}
}while (opcao != "0");