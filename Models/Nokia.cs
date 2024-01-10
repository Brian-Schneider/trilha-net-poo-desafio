namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    // Implementado!
    public class Nokia : Smartphone
    {
        // Sobrescrever o método "InstalarAplicativo"
        // Implementado!
        private string SistemaAndroid { get; set; }
        public Nokia(string numero, string modelo, string imei, int memoria, string sistemaAndroid) : base(numero, modelo, imei, memoria)
        {
            SistemaAndroid = sistemaAndroid;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia com sistema {SistemaAndroid}");
        }
    }
}