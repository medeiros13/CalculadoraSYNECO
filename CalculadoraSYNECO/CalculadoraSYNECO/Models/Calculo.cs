using System.ComponentModel.DataAnnotations;

namespace CalculadoraSYNECO.Models
{
    public enum TipoOperacao
    {
        Adicao = '+',
        Subtracao = '-',
        Multiplicacao = '*',
        Divisao = '/'
    }
    public class Calculo
    {
        public int Id { get; set; }
        [Display(Name = "Primeiro número")]
        public double Numero1 { get; set; }
        [Display(Name = "Segundo número")]
        public double? Numero2 { get; set; }
        [Display(Name = "Operação")]
        public TipoOperacao Operacao { get; set; }
        [Display(Name = "Resultado")]
        public double? Resultado { get; set; }
        public Calculo()
        {
        }
        public Calculo(int id, double numero1, TipoOperacao operacao, double? numero2, double? resultado)
        {
            Id = id;
            Numero1 = numero1;
            Operacao = operacao;
            Numero2 = numero2;
            Resultado = resultado;
        }

        private char converteOperacao(TipoOperacao operacao)
        {
            char retorno;
            switch (operacao)
            {
                case TipoOperacao.Adicao:
                    retorno = '+';
                    break;
                case TipoOperacao.Subtracao:
                    retorno = '-';
                    break;
                case TipoOperacao.Multiplicacao:
                    retorno = '*';
                    break;
                case TipoOperacao.Divisao:
                    retorno = '/';
                    break;
                default:
                    retorno = '@';
                    break;
            }
            return retorno;
        }
        public override string ToString()
        {
            return $"{Numero1} {converteOperacao(Operacao)} {Numero2} = {Resultado}";
        }
    }
}
