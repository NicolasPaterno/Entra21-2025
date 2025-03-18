namespace ContaBanco
{
    public class ContaBancaria
    {
        private int _numeroConta;
        private string _titular;
        protected double _saldo; 

        public ContaBancaria(int numeroConta, string titular, double saldo)
        {
            if (numeroConta <= 0)
                throw new ArgumentException("Número da conta deve ser positivo.", nameof(numeroConta));
            if (string.IsNullOrEmpty(titular))
                throw new ArgumentException("Titular não pode ser nulo ou vazio.", nameof(titular));
            if (saldo < 0)
                throw new ArgumentException("Saldo inicial não pode ser negativo.", nameof(saldo));

            _numeroConta = numeroConta;
            _titular = titular;
            _saldo = saldo;
        }

        public int NumeroConta => _numeroConta;
        public string Titular
        {
            get => _titular;
            set => _titular = string.IsNullOrEmpty(value) ? throw new ArgumentException("Titular não pode ser nulo ou vazio.") : value;
        }
        public double Saldo => _saldo;

        public virtual double Depositar(double valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor do depósito deve ser positivo.");
            _saldo += valor;
            return _saldo;
        }

        public virtual double Sacar(double valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor do saque deve ser positivo.");
            if (_saldo < valor)
                throw new InvalidOperationException("Saldo insuficiente para o saque.");
            _saldo -= valor;
            return _saldo;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Conta - {_titular} | Saldo: R${_saldo:F2}");
        }
    }
}