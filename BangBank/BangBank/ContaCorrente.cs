using BangBank.Titular;

namespace BangBank
{
    public class ContaCorrente
    {
        public Cliente Titular{get; set;}
       
        private int _numero_agencia;
        public int numero_agencia 
        {
            get 
            {
                return _numero_agencia;
            }
            set 
            {
                if(value <=0) 
                {

                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }
        private string _conta;
        public string conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if(value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }
        public string nome_agencia { get; set; }

        private double saldo;

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
           
        }
        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            saldo = saldo + valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

        public ContaCorrente(int numero_agencia,string conta)
        {
            numero_agencia = numero_agencia;
            conta = conta;
            TotalDeContasCriadas += 1;
        }

        public static int TotalDeContasCriadas { get; set; }


        //public void SetSaldo(double valor)
        //{
        //    if (valor < 0)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        saldo = valor;
        //    }
        //}
        //public double GetSaldo()
        //{
        //    return saldo;
        //}

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value<0)
                {
                    return;
                }
                saldo = value;
            }
        }
    }
}