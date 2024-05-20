public class subGerente:Funcionario
{

public subGerente()
{

    SalarioBase = 7.000;

}
    public override double CalcularSalario()
    {
        return base.CalcularSalario();
    }


}