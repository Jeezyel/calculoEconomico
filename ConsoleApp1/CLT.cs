// See https://aka.ms/new-console-template for more information

using System.Xml.Linq;

public class CLT
{
    private OrgaoContratante orgaoContratante = OrgaoContratante.SemEmprego;
    private double salarioGeral = 0;
    private double salarioUnitario = 0;


    public OrgaoContratante OrgaoContratante
    {
        get { return orgaoContratante; }  
        set { orgaoContratante = value; }
    }

    public double SalarioGeral
    {
        get { return salarioGeral; }   
        set { salarioGeral = value; }
    }

    public double SalarioUnitario
    {
        get { return salarioUnitario; }  
        set { salarioUnitario = value; }
    }

}

