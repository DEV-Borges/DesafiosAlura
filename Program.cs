
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
    Console.WriteLine("******************************Variaveis e Tipos***************************");
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
