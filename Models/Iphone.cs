namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    // Implementado!
    public class Iphone : Smartphone
    {
        private String SistemaIOS { get; set; }
        public Iphone(string numero, string modelo, string imei, int memoria, string sistemaIOS) : base(numero, modelo, imei, memoria)
        {
            SistemaIOS = sistemaIOS;
        }
        // Sobrescrever o método "InstalarAplicativo"
        // Implementado!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Iphone com sistema {SistemaIOS}");
        }
    }
}