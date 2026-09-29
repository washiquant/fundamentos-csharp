////while -> (enquanto)
////enquanto minha condição for True
////Executa o bloco de codigo
////int contador = 1;
////while(contador <= 5)
////{
////    Console.WriteLine($"Repetição numero {contador}");
////    contador ++;
////    // ou
////    // contador = contador +1;
////}
////Console.WriteLine("Acabou");

//////use um laço while para exibir apenas numeros pares de um até 1 a 20
////contador = 30;
////while (contador <= 20)
////{
////    if (contador % 2 == 0)
////    {
////        Console.WriteLine(contador);
////    }
////    contador++;
////}
////while (contador >= 0)
////{
////    Console.WriteLine($"A contagem está em : {contador}");
////    contador--; 
////}
//////DO while -> testa a condicao DEPOIS de executar o bloco.
//////         -> dessa forma sera executada ao menos 1x
////int idade = 1;
////do
////{
////    Console.WriteLine($"A repetição está em {idade}");
////} while (idade > 5); // condicao.

////o usuario deve enviar a senha corretamente.Enquanto ele errar, solicite para enviar a senha novamente.
////a senha deve ser senai134
////string senha = "senai134";
////string tentativaSenha;
////Console.WriteLine("Digite a senha : ");
////tentativaSenha = Console.ReadLine();
////do
////{
////    Console.WriteLine("Senha Incorreta, tente novamente :");
////    tentativaSenha = Console.ReadLine();

////} while (senha != tentativaSenha);

////for -> para;
////for(inicialização/condição/incremento)
////{

////}
//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine($"Adoro arroz, contador numero: {i}");
//}
////Utilizando o for imprima do numero 1 ao 5
////for (int i = 1; i <= 200000000000000000; i++)
////{
////    Console.WriteLine(i);
////}
////Utilizando for faça uma contagem regressiva de 10 a 1
//for (int i = 1;i >= 10; i--)
//{
//    Console.WriteLine(i);
//}
////Utilizando for exiba os numeros de 0 até 20, imprimindo 2 em 2
//for(int i = 0;i <=20; i= i + 2)
//{
//    Console.WriteLine(i);
//}



//Peça uma senha ao usuário. Enquanto ele não digitar 123, exiba "Senha incorreta!" e peça novamente.
//Quando acertar, exiba "Acesso liberado!".

////Console.WriteLine("Digite a senha:");
////string senha = "123";

////string tentativa_senha = Console.ReadLine();

////while (tentativa_senha != senha)
////{
////    Console.WriteLine("Senha Incorreta, tente novamente : ");
////    tentativa_senha = Console.ReadLine();
////}

////Use um laço while para imprimir os números de 1 a 10.
//int numero_selecionado = 1;
//while (numero_selecionado <=10)
//{
//    Console.WriteLine(numero_selecionado++);
//}

//Exiba a mensagem `"Executando o processo..."` e pergunte se o usuário deseja executar novamente.
//Se ele digitar `s` ou `S`, repita. Caso contrário, exiba `"Processo encerrado!"`.
//*/
//string letraDoUsuario;
//do
//{
//    Console.WriteLine("Executando o processo...");
//    Console.WriteLine("Deseja executar novamente ? (Se sim, digite 's' ou 'S')");
//    letraDoUsuario = Console.ReadLine();

//} while (letraDoUsuario == "s" || letraDoUsuario == "S");

//Peça números inteiros ao usuário e vá somando todos. O laço para quando o usuário digitar `0`. No final, exiba a soma total.
//*/

//int somaNumerosInteiros = 0;
//int numerosInteiros;

//do
//{
//    Console.WriteLine("Digite o numero inteiro a ser somado :");
//    numerosInteiros = int.Parse(Console.ReadLine());
//    somaNumerosInteiros  += numerosInteiros;
//    Console.WriteLine($"A soma está em {somaNumerosInteiros}");
//} while (numerosInteiros != 0);
// * **5. Tabuada** · `for`

//Peça um número ao usuário e exiba a tabuada dele, de 1 a 10.
//*/
//Console.WriteLine("Digite um numero, para exibir sua tabuada...");
//int numeroDaTabuada = int.Parse(Console.ReadLine());
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i*numeroDaTabuada);
//}

//Use um laço `for` para somar todos os números de 1 a 100 e exiba o resultado.
//*/
//int somaDosNumeros = 0;
//for (int i = 1; i <= 100; i++)
//{
//     somaDosNumeros += i;
//    Console.WriteLine(somaDosNumeros);
//}
/*
 * Crie um cadastro que peça uma senha ao usuário. Use do-while para garantir que ela tenha no mínimo 8 caracteres.
 * 
 *Enquanto for curta, exiba "Senha muito curta. A senha deve ter no mínimo 8 caracteres." e peça novamente. 
 * Quando for válida, exiba "Senha cadastrada com sucesso!".
*/
//using System.ComponentModel.Design;

/////***3. Executar o Processo** · `do-while`
/////* **4. Somador de Números** · `do-while`
/////*
/////***6. Soma de 1 a 100** · `for`
//string senhaValida;
//Console.WriteLine("Digite uma senha valida");
//senhaValida = Console.ReadLine();
//if (senhaValida.Length < 8)
//{
//    do
//    {

//        Console.WriteLine("Senha muito curta. A senha deve ter no minimo 8 caracteres");
//        Console.WriteLine("Tente novamente: ");
//        senhaValida = Console.ReadLine();


//    } while (senhaValida.Length <= 8);
//}
//Console.WriteLine("Senha cadastrada com sucesso!");
/*
 * **8. Cálculo de Fatorial**

Peça um número inteiro não negativo e calcule o seu fatorial.

O fatorial de `n` (escrito `n!`) é o produto de todos os inteiros positivos até `n`. Exemplo: `5! = 5 × 4 × 3 × 2 × 1 = 120`.

*Dica: comece com uma variável de resultado valendo 1 e vá multiplicando.*
*/
//int numero_factorial = 0;
//int factorial = 1;
//Console.WriteLine("Digite um numero não negativo para receber seu factorial: ");
//numero_factorial = int.Parse(Console.ReadLine());
//for (int i = numero_factorial; i != 0; i--)
//{
//    factorial = factorial * i;
//    Console.WriteLine($"O produto de {numero_factorial} é : {factorial}) ");
//}



// link para resolver exercicios : https://plastic-end-f7d.notion.site/Exerc-cios-Fundamentos-de-C-99a9c706943882b1a8e4818f3c00aa4a
/*
 * **10. Calculadora Interativa**

Desenvolva uma calculadora com as quatro operações básicas. O programa deve:

1. Exibir um menu com as opções (somar, subtrair, multiplicar, dividir, sair).
2. Pedir ao usuário para escolher uma operação.
3. Pedir dois números.
4. Exibir o resultado.
5. Voltar ao menu, repetindo até que o usuário escolha "Sair".

*Dica: use `do-while` para o menu e `if/else` ou `switch` para as operações.*
*/
int numero_do_usuario = 0;
double primeiro_numero = 0;
double segundo_numero = 0;
Console.WriteLine("Escolha uma das Operações : ");
Console.WriteLine(" 1 - Somar / 2 - subtrair / 3 - multiplicar / 4 - dividir / 5 - sair ");
numero_do_usuario = int.Parse(Console.ReadLine());
if (numero_do_usuario == 1)
{
    Console.WriteLine("Escreva o primeiro numero");
    primeiro_numero = double.Parse(Console.ReadLine());
    Console.WriteLine("Escreva o segundo numero");
    segundo_numero = double.Parse(Console.ReadLine());
    Console.WriteLine($"A soma resultante é {primeiro_numero + segundo_numero}");
}
else if (numero_do_usuario == 2)
{
    Console.WriteLine("Escreva o primeiro numero");
    primeiro_numero = double.Parse(Console.ReadLine());
    Console.WriteLine("Escreva o segundo numero");
    segundo_numero = double.Parse(Console.ReadLine());
    Console.WriteLine($"A subtração resultante é {primeiro_numero - segundo_numero}");

}
else if (numero_do_usuario == 3)
{
    Console.WriteLine("Escreva o primeiro numero");
    primeiro_numero = double.Parse(Console.ReadLine());
    Console.WriteLine("Escreva o segundo numero");
    segundo_numero = double.Parse(Console.ReadLine());
    Console.WriteLine($"A multiplicação resultante é {primeiro_numero * segundo_numero}");
}
else if (numero_do_usuario == 4)
{
    Console.WriteLine("Escreva o primeiro numero");
    primeiro_numero = double.Parse(Console.ReadLine());
    Console.WriteLine("Escreva o segundo numero");
    segundo_numero = double.Parse(Console.ReadLine());
    Console.WriteLine($"A multiplicação resultante é {primeiro_numero / segundo_numero}");
}
else if (numero_do_usuario == 5)
{
    Console.WriteLine("Voce saiu do sistema!");
}

//**11.Números Primos até 100 * *

//Liste todos os números primos entre 1 e 100.

//Um número primo é um número natural maior que 1 que só é divisível por 1 e por ele mesmo.

//*Dica: você vai precisar de um `for` dentro de outro. O laço externo percorre os números de 2 a 100 e o interno verifica se existe algum divisor.
// O comando `break` ajuda a sair do laço interno assim que um divisor é encontrado.*