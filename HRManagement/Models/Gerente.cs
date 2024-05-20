public class Gerente : Funcionario
{
    public Gerente()
    {

        SalarioBase = 9.000;
    }

    public override double CalcularSalario()
    {
        return base.CalcularSalario();
    }

}
