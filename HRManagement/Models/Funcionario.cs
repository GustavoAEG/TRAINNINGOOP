using System.Collections.Generic;
public class Funcionario
{
    public string Nome { get; set; }
    protected double SalarioBase { get; set; }
    public virtual double CalcularSalario()
    {
        // Cálculo do FGTS e transporte utiliza o encapsulamento indiretamente, através do acesso à propriedade protegida SalarioBase
        double fgts = SalarioBase * 0.1;
        double transporte = SalarioBase * 0.05;
        double salarioFinal = SalarioBase - fgts - transporte;
        return salarioFinal;
    }

}