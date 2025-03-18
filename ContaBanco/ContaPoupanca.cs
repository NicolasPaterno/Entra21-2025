﻿namespace ContaBanco
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numeroConta, string titular, double saldo)
            : base(numeroConta, titular, saldo)
        {
        }

        public override double Depositar(double valor)
        {
            return base.Depositar(valor);
        }

        public override double Sacar(double valor)
        {
            return base.Sacar(valor);
        }
    }
}