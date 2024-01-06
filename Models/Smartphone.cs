namespace DesafioPOO.Models
{
    // 'abstract' significa que esta classe não pode ser instanciada diretamente
    public abstract class Smartphone
    {
        // Propriedades da classe abstrada Smartphone
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        // Construtor da classe abstrata Smartphone, que será herdado pelas classes filhas
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

        // Método abstrato que será herdado pelas classes filhas
        public abstract void InstalarAplicativo(string nomeApp);
    }
}