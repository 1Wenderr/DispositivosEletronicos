namespace DispositivosEletronicos.Models
{
    public abstract class DispositivoEletronico
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoDeFabricacao { get; set; }

        public abstract string ExibirDetalhes();
    }
}
