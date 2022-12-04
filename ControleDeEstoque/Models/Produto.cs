using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ControleDeEstoque.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        [Display(Name = "Produzido")]
        public int QntProduzida { get; set; }
        [Display(Name = "Vendido")]
        public int QntVendida { get; set; }
        [Display (Name= "Estoque")]
        public int QntEstoque
        {
            get { return QntProduzida - QntVendida; }
            set { return; }
        }
    }
}
