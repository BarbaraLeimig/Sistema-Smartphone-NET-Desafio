namespace DesafioPOO.Models
{
    // 'abstract' significa que esta classe não pode ser instanciada diretamente
    public abstract class Smartphone
    {
        // Propriedades da classe abstrada Smartphone
        private string _modelo;
        private string _imei;
        private int _memoria;
        public string Numero { get; set; }
        public string Modelo
        {
            get => _modelo;
            set => _modelo = value;
        }
        public string IMEI
        {
            get => _imei;
            set => _imei = value;
        }
        public int Memoria
        {
            get => _memoria;
            set => _memoria = value;
        }

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