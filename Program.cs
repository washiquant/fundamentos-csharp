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

// See https://aka.ms/new-console-template for more information
//using System.ComponentModel.Design;
//using System.Net.Mail;
//using System.Runtime.CompilerServices;

////Console.WriteLine("Hello, World!");
////int a = 5, b = 10;
////Console.WriteLine(a == b);// A é igual a B ?
////Console.WriteLine(b != a);// A é diferente de B ?
////Console.WriteLine(a > b);// A é maior que B ?
////Console.WriteLine(a < b);// A é menor que B ? 
////Console.WriteLine(a>= b);// A é maior ou igual a B
////Console.WriteLine(a<=b);// A é menor ou igual a B ?

///*for(int i = 1; i > n; i++)
//{

//}
//*/
//bool washingtonHetero = true;
//bool washingtonEBaixo = false;

//// Ambos precisam ser iguais para retornar True, caso contrario será False.
//bool resultado = washingtonEBaixo && washingtonHetero;
//Console.WriteLine(resultado);
////Um dos dois precisa ser verdadeiro para retornar True, caso contrario sera False.
//bool operadorOu = washingtonHetero ||  washingtonEBaixo;
//Console.WriteLine(operadorOu);

////! = NÃO/NEGAÇÃO -> Traz o oposto do que esta na variavel.

// resultado = !washingtonHetero;
////Condicional 
//// Se o cara é maior de idade...
//int idade = 18;
//if (idade>= 60)
//{
//    Console.WriteLine("Parabens,vc é idoso.");
//}
//else if (idade>=18)
//{
//    Console.WriteLine("Parabens, vc é um adulto.");

//}
//else if (idade>=14)
//{
//    Console.WriteLine("Parabens, vc é um adolescente.");
//}


//else
//{
//    Console.WriteLine("Parabens, vc é uma criança.");

//}
///*### **Exercícios Fundamentais**

//**1. Verificador de Maioridade**

//Crie um programa que declare uma variável **`idade`**. 

//Use uma estrutura **`if/else`** para verificar se a idade é **maior ou igual a 18**. 

//O programa deve imprimir "*Você é maior de idade*" se a condição for verdadeira, e "*Você é menor de idade*" caso contrário
//*/
//int idade1 = 50;
//if (idade1 >= 18)
//{
//    Console.WriteLine("*Você é maior de idade*");

//}
//else
//{
//    Console.Write("*Você é menor de idade*");
//}
///***2. Verificador de Número (Positivo, Negativo ou Zero)**

//Crie um programa que declare uma variável **`numero`**; 

//Utilize uma estrutura **`if/else if/else`** para verificar e imprimir uma das seguintes mensagens: "*O número é positivo.*", "*O número é negativo.*" ou "*O número é zero.*".
//*/
//int numero = 0;
//if (numero == 0)
//{
//    Console.WriteLine("O numero é zero");

//}
//else if (numero > 0)
//{
//    Console.Write("O numero é positivo");
//}
//else
//{
//    Console.WriteLine("O numero é negativo");
//}
///*
// * **3. Classificação de Aluno**

//Crie um programa que use a classe para pedir ao usuário que digite a nota de um aluno (um valor **`double`**). 

//Em seguida, use uma estrutura **`if/else`** simples para imprimir "Aprovado" se a nota for maior ou igual a 7.0, e "Reprovado" caso contrário
//*/
//Console.WriteLine("Digite a nota do aluno");
//double notaDoAluno = double.Parse(Console.ReadLine());
//if (notaDoAluno >= 7)
//{
//    Console.WriteLine("Aprovado");

//}
//else
//{
//    Console.WriteLine("Reprovado");
//}

///*
// * 
// * **4. Classificação por Faixa Etária**

//Peça a idade do usuário e classifique: até 12 anos → `"Criança"`, de 13 a 17 → `"Adolescente"`, 18 ou mais → `"Adulto"`. Use condicional encadeada (`else if`).
//*/
//Console.WriteLine("Digite a idade do usuario");
//int idadeDoUsuario = int.Parse(Console.ReadLine());
//if (idadeDoUsuario >= 18)
//{
//    Console.WriteLine("Adulto");
//}
//else if (notaDoAluno >= 13 && notaDoAluno <= 17)
//{
//    Console.WriteLine("Adolescente");
//}
//else
//{
//    Console.WriteLine("Criança");
//}
///*
// *
// ***5. Status de Tarefa**

//Declare uma variável **`boolean tarefaConcluida`**. 

//Usando uma estrutura **`if/else`**, exiba a mensagem "A tarefa está pendente!" se a variável for **`false`**, e "A tarefa foi finalizada com sucesso!" se for **`true`**.
// */
//bool tarefaConcluida = true;
//if (tarefaConcluida )
//{
//    Console.WriteLine("A tarefa foi finalizada com sucesso!");

//}
//else
//{
//    Console.WriteLine("A tarefa está pendente!");
//}
///*
// * **6. Nota Válida (operador &&)**

//Peça uma nota ao usuário. Use o operador `&&` para verificar se ela está dentro do intervalo válido (entre 0 e 10). Exiba `"Nota válida"` ou `"Nota inválida"`.

//csharp
//*/
//Console.WriteLine("Digite uma nota:");
//int notaUsuario1 = int.Parse(Console.ReadLine());
//if (notaDoAluno >= 0 && notaDoAluno <= 10)
//{
//    Console.WriteLine("Nota Valida");
//}
//else
//{
//    Console.WriteLine("Nota Invalida");
//}
///*
// * **7. Aprovação de Empréstimo**

//Para aprovar um empréstimo, um banco exige que o cliente tenha um salário mensal de pelo menos R$ 2.000,00 e não possua restrições de crédito. 

//Crie um programa com as variáveis **`double salarioMensal`**; e **`boolean possuiRestricao`** .
//Use o operador lógico "E" (**`&&`**) em uma estrutura **`if`** para determinar e imprimir "Empréstimo aprovado." ou "Empréstimo negado
//*/
//double salarioMensal = 2.000;
//bool possuiRestricao = false;
//if (salarioMensal > 2.000 && possuiRestricao == false)
//{
//    Console.WriteLine("Emprestimo Aprovado");
//}
//else
//{
//    Console.WriteLine("Emprestimo negado");
//}
///*
// * **8. Classificação de Média Escolar Completa**

//Crie um programa que solicita ao usuário que digite uma nota (um valor

//**`double`**). Utilizando uma estrutura **`if/ else if /else`**, classifique a nota da seguinte forma:

//- Se a nota for 7.0 ou maior, imprima "Aprovado!".
//- Se a nota for maior ou igual a 5.0, mas menor que 7.0, imprima "Recuperação.".
//- Se a nota for menor que 5.0, imprima "Reprovado.".
//*/
//Console.WriteLine("Digite uma nota:");
//notaUsuario1 = int.Parse(Console.ReadLine());
//if (notaDoAluno >= 7)
//{
//    Console.WriteLine("Aprovado");
//}
//else if (notaDoAluno >= 5 && notaDoAluno < 7)
//{
//    Console.WriteLine("Recuperacao");
//}
//else 
//{
//    Console.WriteLine("Reprovado");
//}

///*
// * **9. Par ou Ímpar com Operador Ternário**

//Declare uma variável **`numero`**; Utilizando o operador ternário (**`? :`**), 
//crie uma variável String resultado que receba o texto "Par" se o número for par, ou "Ímpar" se for ímpar.
//Ao final, imprima o resultado.

//**Dica:** O operador de módulo **`%`** (resto da divisão), apresentado no material, é perfeito para isso.
//*/
// numero = 5;
// string resultado1 = numero % 2 == 0 ? "Par" : "Impar";
//Console.WriteLine(resultado1);
///*
// * **10. Cálculo de Desconto Progressivo**

//Uma loja oferece descontos baseados no valor da compra. Crie um programa que declare uma variável

//`double valorCompra = 150.0;` e aplique as seguintes regras usando `if/else if/else`:

//- Compras acima de R$ 200,00 têm 20% de desconto.
//- Compras entre R$ 100,00 (inclusive) e R$ 200,00 (exclusive) têm 10% de desconto.
//- Compras abaixo de R$ 100,00 não têm desconto.

//    O programa deve usar os operadores aritméticos para calcular e exibir o valor final a ser pago.
//*;
//*/
//double valorCompra = 150.0;
//if (valorCompra > 200)
//{
//    Console.WriteLine($"Sua conta vai com 20% de desconto, o valor final fica em : {valorCompra * 0.20} ");
//}
//else if (valorCompra >=100 && valorCompra <= 200)
//{
//    Console.WriteLine($"Sua conta vai com 10% de desconto, o valor final fica em : {valorCompra * 0.10} ");
//}
//else
//{
//    Console.WriteLine($"Sua conta ficou no valor de : {valorCompra }");
//}

//Estruturas de repetição ():
// while - > (enquanto a condicao for true) { faz algo}

//Peço uma senha, enquanto a senha estiver errada, eu pergunto denovo.
Console.WriteLine("Digite a senha: ");
string senha = Console.ReadLine();
while (senha != "vini")
{
    Console.WriteLine("Senha Incorreta! ");

    Console.WriteLine("Digite a senha novamente: ");
    senha = Console.ReadLine();
}
// do/while

// 