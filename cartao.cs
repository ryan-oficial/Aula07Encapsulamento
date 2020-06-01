namespace Aulas7encapsulamento
{
    public class cartao
    {
        public string numero { get; set; }
        public string bandeira { get; set; }
        public string titular { get; set; }
        private string token { get; set; }
        protected int cvc { get; set; }


        public string AprovarCartao(){
            return "compra aprovada";
        }
        private bool ValidarToken(){
            
            if( token != null && token != ""){
                return  true;
            }
            return  false;
        }
        protected bool ValidarCompra(){
            return  true;
        }

    }
}