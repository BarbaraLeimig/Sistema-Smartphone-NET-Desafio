namespace DesafioPOO.Models
{
    // A classe Iphone herda da classe abstrata Smartphone
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone. Ele chama o construtor da classe Smartphone
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }

        // Impementação do método abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no aparelho telefônico Iphone.");
        }
    }
}