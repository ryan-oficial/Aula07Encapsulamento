using System;

namespace Aulas7encapsulamento
{
    public class Mastercard : cartao
    {
        
        public int parcelas { get; set; }
        public void ComprarComDescontoMastercard(float desconto){
            cvc = 456;

            Console.WriteLine($"Aplicado desconto de {desconto}, no total de {parcelas} parcelas");
        }


    }
}