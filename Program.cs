using System;

namespace Aulas7encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            cartao card = new cartao();

            Mastercard master = new Mastercard();
            master.titular = "Ryan";
            master.parcelas = 4;
            master.ComprarComDescontoMastercard(92f);
        }
    }
}
