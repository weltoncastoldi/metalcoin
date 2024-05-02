using MetalCoin.Domain.Abstracts;
using MetalCoin.Domain.Enums;

namespace MetalCoin.Domain.Entities
{
    public class Fornecedor : Entidade
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public bool Status { get; set; }
        public Endereco Endereco { get; set; }

        /* EF Relation */
        public IEnumerable<Produto> Produtos { get; set; }

    }
}
