namespace DesafioPOO.Models
{
    // A classe Nokia herda da classe abstrata Smartphone
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia. Ele chama o construtor da classe Smartphone
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }

        // Impementação do método abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no aparelho telefônico Nokia");
        }
    }
}