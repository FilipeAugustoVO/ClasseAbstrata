using System;

namespace ClasseAbstrata
{
    abstract class Teste
    {
        public int _a; //atributo _a
        public abstract void A(); //metodo A
    }

    class Exemplo1 : Teste
    {
        public override void A()
        {
            Console.WriteLine("Exemplo1.A"); //Mensagem que será escrita no console pelo método A
            base._a++; //palavra-chave que denota um metodo construtor
        }
    }

    class Exemplo2 : Teste
    {
        public override void A()
        {
            Console.WriteLine("Exemplo2.A");
            base._a--;                   
        }
    }

    class Programa
    {
        static void Main()
        {
            // Referência Exemplo1 pelo tipo Teste.
            Teste teste1 = new Exemplo1();
            teste1.A();

            // Referência Exemplo2 pelo tipo Teste.
            Teste teste2 = new Exemplo2();
            teste2.A();
        }
    }

}
