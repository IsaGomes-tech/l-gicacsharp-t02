/*
Exercícios com if, else e elseif:
1.Faça um programa para verificação de estoque
Um sistema de gerenciamento de estoque precisa notificar os funcionários 
quando for hora de reabastecer um produto.
Escreva um código que verifique a quantidade de um produto em estoque. Se a 
quantidade for menor que 5, exiba a mensagem: "Alerta: Baixo estoque. Por favor, 
reabasteça este produto.". Caso contrário, exiba: "Estoque suficiente.".
*/

int quantidadeProdutos = 4;
if (quantidadeProdutos < 5)
{
    Console.WriteLine("Alerta: Baixo estoque. Por favor,reabasteça este produto.");
}
else
{
    Console.WriteLine("Estoque suficiente.");
}

/*
 2.Faça um programa de desconto
Uma loja oferece um desconto para compras acima de um certo valor como parte 
de uma promoção de vendas. Escreva um código que determine o valor total da 
compra de um cliente. Se o valor total for superior a R$ 200,00, aplique um 
desconto de 10% e exiba: "Desconto de 10% aplicado!".Se o valor total for R$ 
200,00 ou menos, informe: "Adicione mais itens ao carrinho para ganhar um 
desconto de 10%.".
*/
double valorProduto = 250.0;
double percentualDesconto = 0.10;
double desconto = valorProduto * percentualDesconto;
double valorFinal = valorProduto - desconto;
if (valorProduto > 200.0)
{
    Console.WriteLine($"Desconto de 10% aplicado!, compra saiu por R${valorFinal:F2}");
}
else
{
    Console.WriteLine("Adicione mais itens ao carrinho para ganhar um desconto de 10 %");
}

/*
Exercícios com if, else e elseif:
Exercícios com switch:
1.Faça um programa que determine o dia da semana
O programa deve receber um número de 1 a 7, representando um dia da semana,
e imprimir o nome do dia correspondente (por exemplo, 1 = "Domingo", 2 = 
"Segunda-feira", etc.).
*/
int diaDaSemana = 2;
switch (diaDaSemana)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda-feira");
        break;
    case 3:
        Console.WriteLine("Terça-feira");
        break;
    case 4:
        Console.WriteLine("Quarta-feira");
        break;
    case 5:
        Console.WriteLine("Quinta-feira");
        break;
    case 6:
        Console.WriteLine("Sexta-feira");
        break;
    case 7:
        Console.WriteLine("Sábado");
        break;
    default:
        Console.WriteLine("Número inválido");
        break;
}

/*
2. Faça um programa que calcule o preço final de um produto com base em um 
código de desconto
O programa deve receber um código de desconto (de 1 a 3) e aplicar o desconto 
correspondente ao preço do produto.
o Código 1: 10 % de desconto
o Código 2: 20 % de desconto
o Código 3: 30 % de desconto
o Se o código for inválido, deve mostrar uma mensagem de erro.
*/
int codigoDesconto = 2;
double precoOriginal = 100.0;
double desconto2 = 0;
double precoFinal = 0;
switch (codigoDesconto)
{
    case 1:
        desconto2 = precoOriginal * 0.10;
        precoFinal = precoOriginal - desconto2;
        Console.WriteLine($"O produto com desconto de 10% ficou por R${precoFinal:F2}");
        break;

    case 2:
        desconto2 = precoOriginal * 0.20;
        precoFinal = precoOriginal - desconto2;
        Console.WriteLine($"O produto com desconto de 20% ficou por R${precoFinal:F2}");
        break;

    case 3:
        desconto2 = precoOriginal * 0.30;
        precoFinal = precoOriginal - desconto2;
        Console.WriteLine($"O produto com desconto de 30% ficou por R${precoFinal:F2}");
        break;
    default:
        Console.WriteLine("Erro, opção inválida");
        break;
}

/*
Exercícios com for:
1.Crie um programa que mostre na tela as tabuadas do número 7, utilizando laço de
repetição for.
O programa deve exibir, para cada número de 7, a multiplicação desse número
pelos valores de 1 a 10
*/
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"7 X {i} = {7 * i}");
}

/*
2. Faça um programa para calcular a média
Crie um programa que receba 10 números inteiros e calcule a média desses 
números. Utilize o laço for para ler os números e calcular a média.
Exercícios com while:
*/
double[] numeros = { 2.5, 3.0, 4.0, 5.0, 6.8, 7.0, 8.8, 2.5, 4.8, 4.5 };
double soma = 0;
foreach (double n in numeros)
{
    soma += n;
}
double media = soma / numeros.Length;

Console.WriteLine($"A média é: {media:F2}");

/*
1.Faça um programa contador de visitantes
Desenvolva um código que simula a entrada X visitantes aleatoriamente no 
museu. A capacidade máxima é de 50 pessoas. Use um loop while para "contar" 
cada visitante até que a capacidade máxima seja atingida. A cada visitante 
adicional, exiba o número total de visitantes até o momento.
*/
int visitantes = 1;
while (visitantes <= 50)
{
    Console.WriteLine($"Total de: {visitantes} visitantes");
    visitantes++;
}
/*
2. Faça um programa de sistema de login
Um sistema de login precisa verificar a autenticidade do usuário, permitindo 
múltiplas tentativas até que as credenciais corretas sejam fornecidas.
Desenvolva um código que simule um sistema de login usando um loop while. O 
usuário tem um máximo de 3 tentativas para inserir a senha correta. Se a senha 
correta ("senha123") for inserida, exiba "Login bem-sucedido!". Se o limite de 
tentativas for atingido, mostre "Conta bloqueada por excesso de tentativas."
*/

int tentativas = 0;
string senha = "senha123";
string senhaDigitada = "";
while (tentativas < 3)
{
    Console.Write("Digite sua senha: ");
    senhaDigitada = Console.ReadLine();

    if (senhaDigitada == senha)
    {
        Console.WriteLine("Login bem-sucedido!");
        break;
    }
    else
    {
        tentativas++;
        Console.WriteLine("Senha incorreta!");

        if (tentativas == 3)
        {
            Console.WriteLine("Conta bloqueada por excesso de tentativas.");
        }
    }
}