
using System.ComponentModel;
using System.Drawing;

void Titulo() {
    string titulo = @"
█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████
█░░░░░░░░░░░░███░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█
█░░▄▀▄▀▄▀▄▀░░░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█
█░░▄▀░░░░▄▀▄▀░░█░░▄▀░░░░░░░░░░█░░▄▀░░░░░░░░░░█░░▄▀░░░░░░▄▀░░█░░▄▀░░░░░░░░░░█░░░░▄▀░░░░█░░▄▀░░░░░░▄▀░░█░░▄▀░░░░░░░░░░█
█░░▄▀░░██░░▄▀░░█░░▄▀░░█████████░░▄▀░░█████████░░▄▀░░██░░▄▀░░█░░▄▀░░███████████░░▄▀░░███░░▄▀░░██░░▄▀░░█░░▄▀░░█████████
█░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░░░░░█░░▄▀░░░░░░░░░░█░░▄▀░░░░░░▄▀░░█░░▄▀░░░░░░░░░░███░░▄▀░░███░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░░░░░█
█░░▄▀░░██░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░███░░▄▀░░███░░▄▀░░██░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█
█░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░░░░░█░░░░░░░░░░▄▀░░█░░▄▀░░░░░░▄▀░░█░░▄▀░░░░░░░░░░███░░▄▀░░███░░▄▀░░██░░▄▀░░█░░░░░░░░░░▄▀░░█
█░░▄▀░░██░░▄▀░░█░░▄▀░░█████████████████░░▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░███████████░░▄▀░░███░░▄▀░░██░░▄▀░░█████████░░▄▀░░█
█░░▄▀░░░░▄▀▄▀░░█░░▄▀░░░░░░░░░░█░░░░░░░░░░▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░█████████░░░░▄▀░░░░█░░▄▀░░░░░░▄▀░░█░░░░░░░░░░▄▀░░█
█░░▄▀▄▀▄▀▄▀░░░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░█████████░░▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█
█░░░░░░░░░░░░███░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░██░░░░░░█░░░░░░█████████░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█
█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████
";
    Console.WriteLine(titulo);
}

void FinalizaFuncao() {
    Thread.Sleep(3000);
    Console.Clear();
    Menu();
}
int inicial = 0;
int RetornaNumero() {
    inicial++;
    return inicial;
}

void Menu() {
    Titulo();
    Console.WriteLine($"{RetornaNumero()}. Retornar o valor das operações de dois números");
    Console.WriteLine($"{RetornaNumero()}. Listar bandas favoritas");
    Console.WriteLine($"{RetornaNumero()}. Somar uma lista de inteiros");
    Console.WriteLine();

    Console.WriteLine("****************************** Variaveis e Tipos ***************************");
    Console.WriteLine($"{RetornaNumero()}. Calculando a idade");
    Console.WriteLine($"{RetornaNumero()}. Registro de doações");
    Console.WriteLine($"{RetornaNumero()}. Convertendo distâncias");
    Console.WriteLine($"{RetornaNumero()}. Convertendo hora para minutos");
    Console.WriteLine($"{RetornaNumero()}. Calculando a área de um retângulo");
    Console.WriteLine($"{RetornaNumero()}. Média de notas");
    Console.WriteLine($"{RetornaNumero()}. Convertendo tipos");
    Console.WriteLine($"{RetornaNumero()}. Controle de vidas em um jogo");
    Console.WriteLine($"{RetornaNumero()}. Aumento de salário");
    Console.WriteLine($"{RetornaNumero()}. Calculando a área e o perímetro");
    Console.WriteLine();


    Console.WriteLine("****************************** Condicionais com IF/ELSE ***************************");
    Console.WriteLine($"{RetornaNumero()}. Verificando o saldo da conta");
    Console.WriteLine($"{RetornaNumero()}. Classificação de Produtos");
    Console.WriteLine($"{RetornaNumero()}. Classificando a nota de um aluno");
    Console.WriteLine($"{RetornaNumero()}. Verificando acesso a área restrita");
    Console.WriteLine($"{RetornaNumero()}. Classificando a faixa etária");
    Console.WriteLine();


    Console.WriteLine("****************************** Condicionais com Switch-Case ***************************");
    Console.WriteLine($"{RetornaNumero()}. Calculadora de operações basicas");
    Console.WriteLine($"{RetornaNumero()}. Saudação personalizada");
    Console.WriteLine($"{RetornaNumero()}. Sistema de Recompensas");
    Console.WriteLine($"{RetornaNumero()}. Refatorando a organização de livros");
    Console.WriteLine($"{RetornaNumero()}. Autenticação de usuário");
    Console.WriteLine();

    Console.WriteLine("****************************** Laços de Repetição com While/ Do WHILE ***************************");
    Console.WriteLine($"{RetornaNumero()}. Soma das Vendas ");
    Console.WriteLine($"{RetornaNumero()}. Controle de estoque");
    Console.WriteLine($"{RetornaNumero()}. Número secreto");
    Console.WriteLine($"{RetornaNumero()}. Buscando em uma lista");
    Console.WriteLine($"{RetornaNumero()}. Senhas de atendimento");
    Console.WriteLine($"{RetornaNumero()}. Conversor de temperatura");
    Console.WriteLine();

    Console.WriteLine("****************************** Laços de Repetição com For/Foreach ***************************");
    Console.WriteLine($"{RetornaNumero()}. Pulando números");
    Console.WriteLine($"{RetornaNumero()}. Tabela de Mutiplicação");
    Console.WriteLine($"{RetornaNumero()}. Classificação de números");
    Console.WriteLine($"{RetornaNumero()}. O laço certo para o problema");
    Console.WriteLine($"{RetornaNumero()}. Quantos ímpares foram digitados?");

    Console.WriteLine("0. Sair");

    Console.Write("Escolha uma opção: ");
    string opcao = Console.ReadLine()!;
    int opcaoInt = int.Parse(opcao);
    switch (opcaoInt) {
        case 1:
            ResultadoDeOperacaoDeDoisNumeros();
            break;
        case 2:
            ListaDeBandasFavoritas();
            break;
        case 3:
            RetornaASomaDeUmaListaDeInteiros();
            break;

        //****************************** Variaveis e Tipos ***************************
        case 4:
            RetornaIdadeUsuario();
            break;
        case 5:
            RegistroDoação();
            break;
        case 6:
            ConvertendoDistancia();
            break;
        case 7:
            ConvertendoHoraParaMinutos();
            break;
        case 8:
            CaculandoAreaDeUmRetangulo();
            break;
        case 9:
            MediaDeNotas();
            break;
        case 10:
            ConvertendoTipos();
            break;
        case 11:
            ControleDeVidas();
            break;
        case 12:
            AumentoDeSalario();
            break;
        case 13:
            CalculandoAreaEPerimetro();
            break;

        //****************************** Condicionais com IF/ELSE ***************************
        case 14:
            VerificandoSaldo();
            break;
        case 15:
            ClassificandoProdutos();
            break;
        case 16:
            ClassificandoNotasDoAluno();
            break;
        case 17:
            VerificandoAcesso();
            break;
        case 18:
            ClassificandoFaixaEtaria();
            break;

        //****************************** Condicionais com Switch-Case ***************************

        case 19:
            CalculadoraOperacaoBasica();
            break;
        case 20:
            SaudacaoPersonalizada();
            break;
        case 21:
            SistemaRecompensa();
            break;
        case 22:
            RefatorandoOrganizacaoLivros();
            break;
        case 23:
            AutenticandoUsuario();
            break;

        //****************************** Laços de Repetição com While/ Do WHILE ***************************

        case 24:
            SomaVendas();
            break;
        case 25:
            ConstroleDeEstoque();
            break;
        case 26:
            NumeroSecreto();
            break;
        case 27:
            BuscandoEmUmaLista();
            break;
        case 28:
            SenhasAtendimento();
            break;
        case 29:
            ConversorDeTemperatura();
            break;

        //****************************** Laços de Repetição com For/ Foreach ***************************

        case 30:
            PulandoNumeros();
            break;
        case 31:
            TabelaMultiplicacao();
            break;
        case 32:
            ClassificacaoNumeros();
            break;
        case 33:
            LacoCertoParaProblema();
            break;
        case 34:
            QuantosImparesForamDigitados();
            break;


        case 0:
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            Console.Clear();
            Menu();
            break;
    };
}

void QuantosImparesForamDigitados() {
    Console.Clear();

    int qtdImpares = 0;

    for (int i = 0; i < 10; i++) {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine()!);

        if (numero % 2 != 0) {
            qtdImpares++;
        }
    }

    Console.WriteLine($"Você digitou {qtdImpares} números ímpares.");

    FinalizaFuncao();
}

void LacoCertoParaProblema() {
    Console.Clear();

    List<double> notas = new List<double>
{
    8.5,
    6.2,
    9.1,
    5.8,
    7.4
};

    double mediaCorte = 7.0;

    foreach (var nota in notas) {
        if (nota < mediaCorte) {
            Console.WriteLine($"O aluno com a nota {nota} está abaixo da média!");
        } else {
            Console.WriteLine($"O aluno com a nota {nota} está indo muito bem!");
        }
    }

    FinalizaFuncao();
}

void ClassificacaoNumeros() {
    Console.Clear();

    List<int> notas = new List<int> { 4, 7, 5, 9, 6 };

    for (int i = 0; i < notas.Count; i++) {
        if (notas[i] >= 6) {
            Console.WriteLine($"Nota {notas[i]} - Aprovado");
        } else {
            Console.WriteLine($"Nota {notas[i]} - Reprovado");
        }
    }

    FinalizaFuncao();
}

void TabelaMultiplicacao() {
    Console.Clear();

    int numero = 7;

    for (int i = 1; i <= 10; i++) {

        Console.WriteLine(numero + " x " + i + " = " + (numero * i));
    }

    FinalizaFuncao();
}

void PulandoNumeros() {
    Console.Clear();

    for (int i = 1; i <= 20; i++) {
        if (i % 3 == 0) {
            continue;
        }
        Console.WriteLine(i);
    }

    FinalizaFuncao();
}

void ConversorDeTemperatura() {
    Console.Clear();

    int opcao;
    do {
        Console.WriteLine("1 - Celsius para Fahrenheit");
        Console.WriteLine("2 - Fahrenheit para Celsius");
        Console.WriteLine("3 - Sair");
        Console.Write("Escolha uma opção: ");
        opcao = int.Parse(Console.ReadLine()!);

        switch (opcao) {
            case 1:
                Console.Write("Digite a temperatura em Celsius: ");
                double celsius = double.Parse(Console.ReadLine()!);
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius}°C equivalem a {fahrenheit}°F");
                break;
            case 2:
                Console.Write("Digite a temperatura em Fahrenheit: ");
                double fahr = double.Parse(Console.ReadLine()!);
                double cel = (fahr - 32) * 5 / 9;
                Console.WriteLine($"{fahr}°F equivalem a {cel}°C");
                break;
            case 3:
                Console.WriteLine("Saindo...");
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    } while (opcao != 3);

    FinalizaFuncao();
}

void SenhasAtendimento() {
    Console.Clear();

    int senhaGerada = 0;
    int senhaAtual = 0;
    int opcao;

    do {
        Console.WriteLine("1 - Gerar nova senha");
        Console.WriteLine("2 - Chamar próxima senha");
        Console.WriteLine("3 - Sair");
        Console.Write("Escolha uma opção: ");
        opcao = int.Parse(Console.ReadLine()!);

        switch (opcao) {
            case 1:
                senhaGerada++;
                Console.WriteLine("Senha gerada: " + senhaGerada.ToString("D3"));
                break;
            case 2:
                senhaAtual++;
                Console.WriteLine("Senha chamada: " + senhaAtual.ToString("D3"));
                break;
            case 3:
                Console.WriteLine("Encerrando sistema.");
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    } while (opcao != 3);

    FinalizaFuncao();
}

void BuscandoEmUmaLista() {
    Console.Clear();

    List<string> alunos = new List<string> { "Ana", "Carlos", "Bianca", "João", "Marina" };

    Console.WriteLine("Digite o nome do aluno:");
    string nomeBusca = Console.ReadLine()!;
    int indice = 0;
    bool encontrado = false;

    while (indice < alunos.Count) {
        if (alunos[indice] == nomeBusca) {
            encontrado = true;
            break;
        }
        indice++;
    }

    if (encontrado) {
        Console.WriteLine($"Aluno encontrado na posição: {indice}");
    } else {
        Console.WriteLine("Aluno não está presente na lista");
    }

    FinalizaFuncao();
}

void NumeroSecreto() {
    Console.Clear();

    int segredo = 7;
    int tentativa;

    while (true) {
        Console.Write("Tente adivinhar o número entre 1 e 10: ");
        tentativa = int.Parse(Console.ReadLine()!);

        if (tentativa == segredo) {
            Console.WriteLine("Parabéns, você acertou!");
            break;
        }
        Console.WriteLine("Errado! Tente novamente.");
    }

    FinalizaFuncao();
}

void ConstroleDeEstoque() {
    Console.Clear();

    int estoque = 0;

    Console.WriteLine("Deseja adicionar um produto ao estoque?");
    Console.WriteLine("1 - Sim | 0 - Não");
    int resposta = int.Parse(Console.ReadLine()!);

    while (resposta == 1) {
        Console.WriteLine("Quantidade:");
        int quantidade = Convert.ToInt32(Console.ReadLine());
        estoque += quantidade;

        Console.WriteLine($"Estoque atual: {estoque}");

        Console.WriteLine("Deseja continuar?");
        Console.WriteLine("1 - Sim | 0 - Não");
        resposta = int.Parse(Console.ReadLine()!);
    }

    Console.WriteLine("Obrigado por usar nosso sistema de estoque!");

    FinalizaFuncao();   
}

void SomaVendas() {
    Console.Clear();

    double vendaTotal = 0;
    double valor = 0;

    do {

        Console.Write($"Digite o valor da venda (ou 0 para encerrar): ");
        if (double.TryParse(Console.ReadLine()!, out valor)) {
            vendaTotal += valor ;
        } else { 
            Console.WriteLine("Entrada invalida");
        }

    } while (valor != 0);

    Console.WriteLine($"Total de vendas do dia: R${vendaTotal}");

    FinalizaFuncao();

}

void AutenticandoUsuario() {
    Console.Clear();

    string ADMIN_USER = "Admin";

    Console.WriteLine("Sistema de Autenticação");
    Console.WriteLine("-----------------------");
    Console.Write("Digite seu nome de usuário: ");

    string username = Console.ReadLine()!;

    if (username == ADMIN_USER) {
        Console.WriteLine($"Bem-vindo, {username}!");
    } else {
        Console.WriteLine("Usuário não cadastrado.");
        Console.WriteLine("Opções disponíveis:");
        Console.WriteLine("[1] Cadastrar novo usuário");
        Console.WriteLine("[2] Acessar como convidado");
        Console.WriteLine("[3] Sair");

        int opcao = int.Parse(Console.ReadLine()!);

        switch (opcao) {
            case 1:
                Console.WriteLine($"Novo usuário '{username}' cadastrado com sucesso!");
                break;

            case 2:
                Console.WriteLine("Acesso concedido como convidado.");
                break;

            case 3:
                Console.WriteLine("Saindo do sistema...");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Opção inválida. O sistema será encerrado.");
                break;
        }
    }

    FinalizaFuncao();

}

void RefatorandoOrganizacaoLivros() {
    Console.Clear();

    Console.WriteLine("Digite o código do livro: ");
    int codigo = int.Parse(Console.ReadLine()!);

    switch (codigo / 100) {
        case 1:
            Console.WriteLine("Ficção Científica");
            break;
        case 2:
            Console.WriteLine("Literatura Clássica");
            break;
        case 3:
            Console.WriteLine("Fantasia");
            break;
        case 4:
            Console.WriteLine("Romance");
            break;
        case 5:
            Console.WriteLine("Suspense/Mistério");
            break;
        case 6:
            Console.WriteLine("Não Ficção");
            break;
        case 7:
            Console.WriteLine("Biografias/Memórias");
            break;
        case 8:
            Console.WriteLine("Distopia");
            break;
        case 9:
            Console.WriteLine("Infantojuvenil");
            break;
        default:
            Console.WriteLine("Código inexistente");
            break;
    }

    FinalizaFuncao();


}

void SistemaRecompensa() {
    Console.Clear();

    Console.Write("Digite o código de recompensa (DOBRAR, CURAR, OURO, ESPECIAL): ");
    string codigo = Console.ReadLine()!;

    string mensagem = codigo switch {
        "DOBRAR" => "Você ganhou 2x EXP por 1 hora!",
        "CURAR" => "Poção de cura adquirida!",
        "OURO" => "+1000 moedas de ouro!",
        "ESPECIAL" => "Item lendário desbloqueado!",
        _ => "Recompensa indisponível."
    };

    Console.WriteLine(mensagem);

    FinalizaFuncao();

}

void SaudacaoPersonalizada() {
    Console.Clear();

    string Nome = "";
    int periodo = 0;

    Console.Write(@"
1 - Manhã
2 - Tarde
3 - Noite
 
Que momento do dia é agora? ");
    periodo = int.Parse(Console.ReadLine()!);

    Console.Write("Qual o seu nome? ");
    Nome = Console.ReadLine()!;

    switch (periodo) {
        case 1:
            Console.WriteLine($"Bom dia, {Nome}.");
            break;
            
        case 2:
            Console.WriteLine($"Boa tarde, {Nome}.");
            break;

        case 3:
            Console.WriteLine($"Boa noite, {Nome}.");
            break;

        default:
            Console.WriteLine("Operação inválida");
            break;
    }

    FinalizaFuncao();


}

void CalculadoraOperacaoBasica() {
    Console.Clear();

    int x, y;
    char operacao;
    Console.Write("Digite o primeiro número: ");
    x = int.Parse(Console.ReadLine()!);

    Console.Write("Digite o primeiro número: ");
    y = int.Parse(Console.ReadLine()!);

    Console.Write("Digite a operação (+, -, *, /): ");
    operacao = char.Parse(Console.ReadLine()!);

    switch (operacao) {

        case '+':
            Console.WriteLine($"Resultado: {x + y}");
            break;

        case '-':
            Console.WriteLine($"Resultado: {x - y}");
            break;

        case '*':
            Console.WriteLine($"Resultado: {x * y}");
            break;

        case '/':
            Console.WriteLine($"Resultado: {x / y}");
            break;

        default:
            Console.WriteLine($"Operação inválida");
            break;
    }

FinalizaFuncao();
}

void ClassificandoFaixaEtaria() {
    Console.Clear();

    int idade = 0;
    string classificacao = "";

    Console.Write($"Digite a idade: ");
    idade = int.Parse( Console.ReadLine()!);

    if (idade>= 0 && idade <= 12) {
        classificacao = "Infantil";

    } else if (idade >= 13 && idade <= 17) {
        classificacao = "Adolescente";

    } else if (idade >= 18 && idade <= 59) {
        classificacao = "Adulto";

    } else {
        classificacao = "Idoso";

    }

    Console.WriteLine($"Classificação: {classificacao}");

    FinalizaFuncao();
}

void VerificandoAcesso() {
    Console.Clear();


    int senhaValida = 42;
    int senha, nivel;
    string situacao  = "";

    Console.Write("Digite a senha: ");
    senha = int.Parse(Console.ReadLine()!);

    Console.Write("Digite o nível de acesso: ");
    nivel = int.Parse(Console.ReadLine()!);

    if (senha == senhaValida && nivel >= 5) {
        situacao = "Acesso liberado";
    }else {
        situacao = "Acesso negado";
    }

    Console.WriteLine(situacao);



    Thread.Sleep(3000);
    VerificandoAcesso();
}

void ClassificandoNotasDoAluno() {
    Console.Clear();

    double nota = 0;
    string situacao = "";

    Console.Write("Informe a nota final do aluno: ");
    nota = double.Parse(Console.ReadLine()!);


    if (nota >= 9) {
        situacao = "A";

    } else if (nota >= 7 && nota < 9) {
        situacao = "B";

    } else if (nota >= 5 && nota < 7) {
        situacao = "C";

    } else {
        //Menor que 5
        situacao = "D";

    }

    Console.WriteLine($"O aluno recebeu a nota {situacao}");

FinalizaFuncao();
}

void ClassificandoProdutos() {
    Console.Clear();

    int tipoProduto = 0;
    string classificacao = "";

    Console.Write("Digite o código do produto: ");
    tipoProduto = int.Parse(Console.ReadLine()!);

    if (tipoProduto == 1) {
        classificacao = "Perecível";
    } else if (tipoProduto == 2) {
        classificacao = "Não Perecível";
    } else {
        classificacao = "Código inválido!";
    }

    Console.WriteLine(classificacao);

FinalizaFuncao();

}

void VerificandoSaldo() {

    Console.Clear();
    double saldo = 0;
    string status = "";

    Console.WriteLine("Digite o saldo: ");
    saldo = double.Parse(Console.ReadLine()!);

    if (saldo > 0) {
        status = "Positivo";
    } else if (saldo == 0) {
        status = "Zerado";
    } else {
        status = "Negativo";
    }

    Console.WriteLine($"O saldo está {status}");

    FinalizaFuncao();

}

void CalculandoAreaEPerimetro() {
    Console.Clear ();
    float pi = 3.14159f;
    double raio = 5.0;
    double area = pi * raio * raio;
    double perimetro = 2 * pi * raio;

    Console.WriteLine($"Raio: {raio}");
    Console.WriteLine($"Área do circulo: {area.ToString("F2")}");
    Console.WriteLine($"Perímetro do círculo: {perimetro.ToString("F2")}");

    FinalizaFuncao();
}

void AumentoDeSalario() {
    Console.Clear();

    decimal salarioInicial = 1500;
    decimal percentualAumento = 10;
    decimal novoSalario = salarioInicial    + (salarioInicial * percentualAumento / 100);

    Console.WriteLine($"O novo salário é de R${novoSalario.ToString("F2")}");

    FinalizaFuncao();

}

void ControleDeVidas() {
    Console.Clear();
    int vida = 5;
    vida--;
    vida++;
    vida++;

    Console.WriteLine($"Vidas Finais: {vida}");

    FinalizaFuncao();    
}

void ConvertendoTipos() {
    Console.Clear() ;

    decimal pesoContainer = 18.75m;

    Console.WriteLine($"Veículos necessários: {(int)pesoContainer}");
    FinalizaFuncao();

}

void MediaDeNotas() {

    Console.Clear();
    float m1,m2,m3, media;

    m1 = 7.2f;
    m2 = 8.3f;
    m3 = 9.1f;

    media = (m1 + m2 + m3) / 3;

    Console.WriteLine($"A média das notas é: {media}");
    FinalizaFuncao();

}

void CaculandoAreaDeUmRetangulo() {
    Console.Clear();
    double largura = 10.5;
    double comprimento = 20.3;
    double area = largura * comprimento;

    Console.WriteLine($"A área do terreno é: {area} metros quadrados");
    FinalizaFuncao();

}

void ConvertendoHoraParaMinutos() {
    Console.Clear();

    int minutos = 0;

    Console.Write("Informe os minutos: ");
    minutos = Convert.ToInt32(Console.ReadLine());

    int hora = minutos / 60;
    int minutosRestantes = minutos % 60;

    Console.WriteLine($"Tempo: {hora} horas e {minutosRestantes} minutos");
    FinalizaFuncao();

}

void ConvertendoDistancia() {

    float valorDeUmaMilha = 1.60934f;
    float milha = 0;
    Console.Clear();

    Console.Write("Informe o valor em Milha: ");
    milha = float.Parse(Console.ReadLine()!);

    Console.WriteLine($"{milha} equivalem a {milha * valorDeUmaMilha} quilôemetros.");
    FinalizaFuncao();
}

void RegistroDoação() {
    Console.Clear();
    float valor = 500.00f;
    bool anonimo = true;
    string tipoConta = "P";

    Console.WriteLine($"Valor recebido: R${valor}");
    Console.WriteLine($"Doação anônima: {anonimo}");
    Console.WriteLine($"Tipo de conta: {tipoConta}");
    FinalizaFuncao();

}

void RetornaIdadeUsuario() {
    Console.Clear();
    Console.Write("Digite o ano do seu nascimento: ");
    string ano = Console.ReadLine()!;

    if (ano.Length == 4) {
        int idade = (DateTime.Now.Year) - int.Parse(ano);
        Console.WriteLine($"Sua idade é: {idade} anos");
        FinalizaFuncao();


    } else {
        Console.WriteLine("Ano informado inválido.");
        FinalizaFuncao();
    }
}

void RetornaASomaDeUmaListaDeInteiros()
{
    Console.Clear();
    List<int> numeros = new List<int>();
    Console.WriteLine("Digite um número inteiro: ");
    int numero = int.Parse(Console.ReadLine()!);
    
    numeros.Add(numero);

    while (true)
    {
        Console.Clear();
        Console.WriteLine("Digite outro número inteiro ou digite '0' para finalizar: ");
        numero = int.Parse(Console.ReadLine()!);
        if (numero == 0)
        {
            break;
        }
        numeros.Add(numero);
    }

    Console.WriteLine($"Os números digitados foram: {string.Join(", ", numeros)}");
    Console.WriteLine($"A soma dos números é: {numeros.Sum()}");
    FinalizaFuncao();

}

void ListaDeBandasFavoritas()
{
    Console.Clear();
    List<string> bandas = new List<string>();
    Console.WriteLine("Digite Sua Banda Favorita: ");

    while (true)
    {
        string banda = Console.ReadLine()!;
        if (banda.ToLower() == "sair")
        {
            break;
        }
        bandas.Add(banda);
        Console.Clear();
        Console.WriteLine("Digite outra banda ou digite 'sair' para finalizar: ");
    }

Console.WriteLine("Suas bandas favoritas são: ");
    foreach (string banda in bandas)
    {
        Console.WriteLine(banda);
    }
    FinalizaFuncao();

}

void ResultadoDeOperacaoDeDoisNumeros()
{
    Console.Clear();
    Console.Write("Digite o primeiro número: ");
    float num1 = float.Parse(Console.ReadLine()!);

    Console.Write("Digite o segundo número: ");
    float num2 = float.Parse(Console.ReadLine()!);

    float resultSoma = num1 + num2;
    float resultSub = num1 - num2;
    float resultMult = num1 * num2;
    float resultDiv = num1 / num2;
    Console.WriteLine($"O resultado das operações são: \nSoma: {resultSoma} \nMultiplicação: {resultMult} \nDivisão: {resultDiv} \nSubtração: {resultSub}");
    FinalizaFuncao();
}

Menu();
