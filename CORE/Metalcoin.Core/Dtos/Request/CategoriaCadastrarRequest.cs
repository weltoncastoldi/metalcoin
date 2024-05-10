namespace Metalcoin.Core.Dtos.Categorias
{
    public record CategoriaCadastrarRequest
    {
        public string Nome { get; set; }
        public bool Status { get; set; }
    }
}
