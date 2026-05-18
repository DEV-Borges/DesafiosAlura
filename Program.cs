
using System.ComponentModel;

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

void Menu() {
    Titulo();
    Console.WriteLine("1. Retornar o valor das operações de dois números");
    Console.WriteLine("2. Listar bandas favoritas");
    Console.WriteLine("3. Somar uma lista de inteiros");

    Console.WriteLine("****************************** Variaveis e Tipos ***************************");
    Console.WriteLine("4. Calculando a idade");
    Console.WriteLine("5. Registro de doações");
    Console.WriteLine("6. Convertendo distâncias");
    Console.WriteLine("7. Convertendo hora para minutos");
    Console.WriteLine("8. Calculando a área de um retângulo");
    Console.WriteLine("9. Média de notas");
    Console.WriteLine("10. Convertendo tipos");
    Console.WriteLine("11. Controle de vidas em um jogo");
    Console.WriteLine("12. Aumento de salário");
    Console.WriteLine("13. Calculando a área e o perímetro");

    Console.WriteLine("****************************** Condicionais com IF/ELSE ***************************");
    Console.WriteLine("14. Verificando o saldo da conta");
    Console.WriteLine("15. Classificação de Produtos");
    Console.WriteLine("16. Classificando a nota de um aluno");
    Console.WriteLine("17. Verificando acesso a área restrita");
    Console.WriteLine("18. Classificando a faixa etária");

    Console.WriteLine("****************************** Condicionais com Switch-Case ***************************");
    Console.WriteLine("19. Calculadora de operações basicas");
    Console.WriteLine("20. Saudação personalizada");
    Console.WriteLine("21. Sistema de Recompensas");
    Console.WriteLine("22. Refatorando a organização de livros");
    Console.WriteLine("23. Autenticação de usuário");

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
