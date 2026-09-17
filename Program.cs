//// Comentario na Tela :)
// * é 
// * vida */



//// Como eu mostro um texto na tela ?

////Toda instrução, termina com ponto e virgula (;)
//Console.WriteLine("Seja Bem Vindo a sua nova linguagem");

////Guardar Informações
////variaveis (caixinhas que guardam informacoes)

//// TIPO Nome_Da_Variavel = Valor;
//int idade = 25;
//double saldo_banco = 100000.0000;
//string nome = "Washington";

//Console.WriteLine(nome);

////Quando a variavel nao muda, e chamada de variavel constante
//const double pi = 3.14159;

//Console.WriteLine(pi);
//var nome_novo = "washington"; // O proprio C# define qual o tipo

//char inicial_do_nome = 'W'; // char = 1 caractere


//Console.WriteLine("Digite seu nome");
//string nomeUsuario = Console.ReadLine(); // lê o texto que foi digitado


//Console.WriteLine("Informe sua idade");
//int idadeUsuario = int.Parse(Console.ReadLine());

////Console.WriteLine("Bem Vindo " + (nomeUsuario)  + ("\n Sua idade é : ") + (idadeUsuario) + (" anos"));

////Interpolação de Strings 
//Console.WriteLine($"Olá, {nomeUsuario} /*!\n Você tem {idadeUsuario} anos"); 

using System.ComponentModel.Design;

///* c# 
int soma = 10 + 5;
int subtracao = 10 - 5;
int multiplicacao = 10 * 5;
int divisao = 10 / 2;

int modulo = 10 % 3; // ele recebe o resto da divisao de 10 por 3
Console.WriteLine(soma);
Console.WriteLine(subtracao);
Console.WriteLine(modulo);
Console.WriteLine(divisao);
Console.WriteLine(multiplicacao);

/*
 * 1. Exibir uma Mensagem
Escreva um programa que use o comando Console.WriteLine() para exibir a frase "Olá, Mundo!" no console.
*/
string apresentacao = ("Olá, Mundo!");
Console.WriteLine(apresentacao);
/*
 * 2. Declarar e Usar uma Variável
Crie um programa que declare uma variável inteira chamada numero com o valor 10. Em seguida, imprima o valor dessa variável no console.
*/
int numero = 10;
Console.WriteLine(numero);
/*
 * 3. Fazer uma Soma
Escreva um programa que declare duas variáveis inteiras, a = 5 e b = 3. Calcule a soma das duas e imprima o resultado.
*/
int a = 5;
int b = 3;
int soma_ab = a + b;
/*
 * **4. Produto de dois números**
Declare duas variáveis, `num1 = 8` e `num2 = 7`. Calcule o produto (multiplicação) entre elas e imprima o resultado.
*/

int num1 = 8;
int num2 = 7;
int produto = num1 * num2;

/*
 * ### **Exercícios Intermediários**

**5. Saudação Personalizada**
Crie um programa que declare uma variável `String` chamada `nome` com o valor `"Ana"`. Depois, exiba uma mensagem de boas-vindas, como `"Olá, Ana!"`.
*/

string nome = "Ana";
Console.WriteLine($"Olá, {nome} ");

/*
6.Calcular o Dobro
Declare uma variável inteira valor. Em seguida, calcule o dobro desse número utilizando a variável e exiba o resultado.
*/

int valor_a_ser_dobrado  = 10;
int dobrador =  2;
int dobro = valor_a_ser_dobrado * dobrador;
                                                                                                                     
/*
**7.Média de três números * *

Escreva um programa que recebe três números e imprime a média aritmética deles.
*/
int valor1 = 25;
int valor2 = 15;
int valor3 = 30;
double media = (valor1 + valor2 + valor3) / 3;

/*
 * **8. Ficha de Cadastro**

Peça ao usuário que digite, um de cada vez, o seu **nome**, a sua **idade** e a sua **cidade**. Depois, monte uma única frase com as três informações.
*/

Console.WriteLine("Digite seu nome :");
string nomeUsuario1 = Console.ReadLine();
Console.WriteLine("Digite sua idade:");
string idadeUsuario1 = Console.ReadLine();
Console.WriteLine("Digite sua cidade:");
string cidadeUsuario1 = Console.ReadLine();

Console.WriteLine($"Seja Muito Bem Vindo {nomeUsuario1}, sua idade é {idadeUsuario1}, e vc é proveninente da cidade de {cidadeUsuario1}");

/*
 * **9. Comparar Dois Números**

Escreva um programa que declare duas variáveis inteiras, x = 10 e y = 20.
O programa deve comparar se `x` é menor que `y` (`<`) e imprimir o resultado (`true` ou `false`) no console.
*/
int x = 10;
int y = 20;
if (x < y) 
{
    Console.WriteLine(true);
}
else 
{ 
    Console.WriteLine(false); 
}

/*
 * **9. Verificação de Idade para Votar**

Peça ao usuário para digitar sua idade. O programa deve usar um operador de comparação para verificar se a idade é maior ou igual a 16 e imprimir o resultado (

`true` ou `false`).

- **Extra:** Adicione um comentário de uma linha (`//`) explicando o que a comparação faz.
*/
Console.WriteLine("Digite sua idade :");
int idadeUsuario2 = int.Parse(Console.ReadLine());
if (idadeUsuario2 >= 16)
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}

/*
 * **10. Usando o Operador Lógico "E" (&&)**

Declare uma variável int temperatura = 28. Escreva uma expressão lógica que verifique se a

`temperatura` é maior que 25 **E** menor que 30. Imprima o resultado `true` ou `false` no console.

*/
int temperatura = 28;
if (temperatura > 25 && temperatura < 30)
{
    Console.WriteLine(true);

}
else
{
    Console.WriteLine(false);
}
/*
 * **11. Usando o Operador Lógico "OU" (||)**

Declare uma variável booleana temCartao = true e uma variável double compra = 50.0. 
O cliente ganha um desconto se temCartao for verdadeiro OU se o valor da compra for maior que 100.0. Escreva a expressão lógica e imprima o resultado (

`true` ou `false`).
*/

bool temCartao = true;
double compra = 50.0;
if (temCartao || compra > 100)
{
    Console.WriteLine(true);

}
else
{
    Console.WriteLine(false);

}
//Metodos, Classes - > PascalCase
//Variaveis em C# -> camelCase
// C# || C sharp -> int idadeDoAluno = 9; //camelCase
// python -> idade_do_aluno = 9 // snake_case

