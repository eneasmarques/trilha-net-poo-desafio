namespace DesafioPOO.Models
{
    using System.Net.Http.Headers;

    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = imei;
            this.Memoria = memoria;
        }

        public static void Ligar() => Console.WriteLine("Ligando...");

        public static void ReceberLigacao() => Console.WriteLine("Recebendo ligação...");

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
