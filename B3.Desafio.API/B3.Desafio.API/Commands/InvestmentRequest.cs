using System.ComponentModel.DataAnnotations;

namespace B3.Desafio.API.Commands
{
    public class InvestmentRequest  
    {
        [Required(ErrorMessage = "O valor inicial é obrigatorio!")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor deve ser maior que zero")]
        public double InitialValue { get; set; }
        
        [Required(ErrorMessage = "A quantidade de meses é obrigatoria!")]
        [Range(2, double.MaxValue, ErrorMessage = "A quantidade de meses deve ser maior que 2 zero!")]
        public int Months { get; set; }
    }
}
