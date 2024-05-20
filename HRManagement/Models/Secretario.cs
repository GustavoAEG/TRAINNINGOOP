public class Secretario:Funcionario
{
public Secretario()
{

SalarioBase = 5.000;

}

    public override double CalcularSalario()
    {
        return base.CalcularSalario();
    }
}