using System;

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