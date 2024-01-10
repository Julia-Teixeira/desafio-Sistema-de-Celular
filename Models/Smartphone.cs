namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void Informacoes(string marca)
        {
            Console.WriteLine("________________________________________");
            Console.WriteLine($"Informações sobre o Smartphone {marca}");
            Console.WriteLine($"Modelo:  {Modelo}.");
            Console.WriteLine($"Número:  {Numero}.");
            Console.WriteLine($"IMEI:    {IMEI}.");
            Console.WriteLine($"Memória: {Memoria}Gb.");
            Console.WriteLine("----------------------------------------");

        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}