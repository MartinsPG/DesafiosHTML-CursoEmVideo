using System;
using static System.Net.Mime.MediaTypeNames;

/*
class Program
{
    static void Main()
    {
        Console.WriteLine("Qual o valor do empréstimo? ");
        var valorEmprestimo = Convert.ToDecimal(Console.ReadLine());
        var taxaAumento = valorEmprestimo * 20 / 100 + valorEmprestimo;
        Console.WriteLine("Quantas parcelas? ");
        var parcelas = Convert.ToDecimal(Console.ReadLine());
        var qntParcelas = taxaAumento / parcelas;
        Console.WriteLine("Vou pagar " + taxaAumento + " em " + parcelas + " vezes.");
    }
}
*/

/*
class ParOuImpar
{
       static void Main()
    {
        Console.WriteLine("Digite um número: ");
        var n1 = Convert.ToInt32(Console.ReadLine());

        if (n1 % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            {
                Console.WriteLine("O número é ímpar.");
            }
        }
    }
}
*/
/*
class IMC
{
    static void Main()
    {
        Console.WriteLine("Digite seu peso: ");
        var kg = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite sua altura: ");
        var h = Convert.ToDouble(Console.ReadLine());

        var imc = kg / (h * h);
        Console.WriteLine("Seu IMC é: " + imc);

        if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine("Parabéns, você está na faixa de peso ideal!");
        }
        else
        {
            Console.WriteLine("Você está fora da faixa de peso ideal.");
        }
    }
}
*/

/*
// Está apto a dirigir? 
class Dirigir
{
    static void Main()
    {
        Console.WriteLine("Ano atual: ");
        var anoAtual = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ano de nascimento: ");
        var anoNasc = Convert.ToInt32(Console.ReadLine());
        var Cond = anoAtual - anoNasc;

        Console.WriteLine("IDADE: " + Cond);
        if (Cond >= 18)
        {
            Console.WriteLine("Está apto a dirigir.");
        }
        else
        {
            Console.WriteLine("Não está apto a dirigir.");
        }

    }
}
*/

// Aluno aprovado ou reprovado? média 7
/*
class Aluno
{
    static void Main()
    {
        Console.WriteLine("Digite a primeira nota: ");
        var pnt = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota: ");
        var snt = Convert.ToDouble(Console.ReadLine());
        var med = (pnt + snt) / 2;

        Console.WriteLine("MÉDIA: " + med);
        if (med >= 7) {
            Console.WriteLine("Aluno aprovado.");
        }
        else
        {
            Console.WriteLine("Aluno reprovado.");
        }
    }
}
*/


/*
// Aproveitamento do aluno
class AproveitamentpAluno
{
    static void Main()
    {
        Console.WriteLine("Digite a primeira nota: ");
        var pnota = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota: ");
        var snota = Convert.ToDouble(Console.ReadLine());

        var media = Convert.ToDouble((pnota + snota) / 2);
        Console.WriteLine("MÉDIA: " + media);
        
        switch (media)
        {
            case >= 9 and <= 10:
                Console.WriteLine("Aproveitamento: A");
                break;
            case >= 8 and < 9:
                Console.WriteLine("Aproveitamento: B");
                break;
            case >= 7 and < 8:
                Console.WriteLine("Aproveitamento: C");
                break;
            case >= 6 and < 7:
                Console.WriteLine("Aproveitamento: D");
                break;
            case >= 5 and < 6:
                Console.WriteLine("Aproveitamento: E");
                break;
            case < 5:
                Console.WriteLine("Aproveitamento: F");
                break;
        }
    }
}
*/



/*
// Laços de repetição de 0 à 10
class LacoRep
{
    static void Main()
    {
        var contador = 0;
        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador = contador + 1;
        }
        Console.WriteLine("Terminei de contar");
    }
}
*/



/*
// Laços de repetição de 10 à 0
class LacoRep
{
    static void Main()
    {
        var contador = 10;

        while (contador > 0)
        {
            Console.WriteLine(contador);
            contador = contador - 1;
        }
        Console.WriteLine("Terminei de contar");
    }
}
*/


/*
// Contar até onde o usuario quiser 
class LacoRep
{
    static void Main()
    {
        var cUsu = 0;
        Console.WriteLine("Até qual número voce gostaria de contar?: ");
        var eUsu = Convert.ToInt32(Console.ReadLine());

        while (cUsu <= eUsu)
        {
            Console.WriteLine(cUsu);
            cUsu = cUsu + 1;
        }
    }
}
*/


/*
// Laço infinito
class Teste
{
    static void Main()
    {
        var cont = 0;
        while (cont < 1)
        {
            Console.WriteLine(cont);
        }
    }
}
*/


/*
// Contador inteligente 
 class ContadorInteligente
{
    static void Main()
    {
        Console.WriteLine("Digite o número inicial: ");
        var n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o número final: ");
        var n2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("-----------------");
        Console.WriteLine("CONTANDO");
        Console.WriteLine("-----------------");
        if ( n1  <= n2 )
        {
            while (n1 <= n2)
            {
                Console.WriteLine(n1 + "..");
                n1 = n1 + 1;
            }
        }
        else
        {
             while (n1 >= n2)
            {
                Console.WriteLine(n1 + "..");
                n1 = n1 - 1;
            }
        }
    }
}
*/


/*
// Repita 
class Repita
{
    static void Main()
    {
        int cont = 1;
        do
        {
            Console.WriteLine(cont);
            cont = cont + 1;
        } while (cont <= 10);
    }
}
*/



/*
// Tabuada 
class Tabuada
{
    static void Main()
    {
        Console.WriteLine("Qual tabuada você quer? ");
        var tab = Convert.ToInt32(Console.ReadLine());
        int cont = 0;
        do
        {
            var result = tab * (cont + 1);
            cont = cont + 1;
            Console.WriteLine(tab + " x " + cont + " = " + result);
        } while (cont < 10);
    }
}
*/



/*
// Super Contador 
class SupCont
{
    static void Main()
    {
        {
            Console.WriteLine("==================");
            Console.WriteLine("Menu");
            Console.WriteLine("==================");
            Console.WriteLine("[1] De 1 até 10");
            Console.WriteLine("[2] De 10 até 1");
            Console.WriteLine("[3] Sair");
            Console.WriteLine("==================");

            var esq = Convert.ToInt32(Console.ReadLine());

            if (esq == 1)
            {
                var cont = 0;
                do
                {
                    cont = cont + 1;
                    Console.WriteLine(cont);
                } while (cont < 10);
            }
            else if (esq == 2)
            {
                var cont = 11;
                do
                {
                    cont = cont - 1;
                    Console.WriteLine(cont);
                } while (cont > 0);
            }
            else if (esq == 3)
            {
                Console.WriteLine("Tchau, tchau!");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}
*/

/*
// Funções
int Somar(int num1, int num2)
{
    int resultado = num1 + num2;
    return resultado;
}

int minhaSoma = Somar(5, 5);
Console.WriteLine(minhaSoma);


void BoasVindas(string nome)
{
    Console.WriteLine("Seja bem-vindo(a), " + nome + "!");
}

Console.WriteLine("Qual o seu nome? ");
var myName = Console.ReadLine();
BoasVindas(myName);

*/

//Exercícios de função
/*
void Saudacao()
{
    Console.WriteLine("Olá, Mundo da programação!");
}

Saudacao();
*/

// Soma com input do usuário
/*
int CalcularSoma(int n1, int n2)
{
    int soma = n1 + n2;
    return soma;
}

Console.WriteLine("Digite um número: ");
var number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite outro número: ");
var number2 = Convert.ToInt32(Console.ReadLine());
var result = CalcularSoma(number1, number2);
Console.WriteLine("A soma dos numeros é: " + result);
*/