using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace microfundaento_apis_web_services_fuel_manager.Model
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public  string Descricão { get; set; }
        [Required]
        public  DateTime Data { get; set; }
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public TipoCombustivel Tipo{ get; set; }
        [Required]
        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }

    }
    public enum TipoCombustivel
    {
        Gasolina,
        Etanol,
        Diesel
    }
    
}
