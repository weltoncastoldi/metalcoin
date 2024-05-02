namespace MetalCoin.Domain.Dtos.Response
{
    public class InssCalculoResponse
    {
        public double SalarioBase { get; set; }
        public double ValorDesconto { get; set; }
        public double SalarioLiquido { get; set; }
        public string Aliquota { get; set; }
    }
}
