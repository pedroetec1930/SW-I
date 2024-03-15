namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Banco ETEC MCM!");

            //Instanciar a classe Conta e criar um objeto dela

            Conta conta = new Conta();

            conta.depositar(1000);
            conta.consulta_saldo();
            conta.sacar(500);
            conta.consulta_saldo();

            conta.sacar(1000);
            conta.consulta_saldo();

            conta.sacar(10000);
            conta.consulta_saldo();
            

        }
    }
}