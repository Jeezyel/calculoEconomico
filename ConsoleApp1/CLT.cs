// See https://aka.ms/new-console-template for more information

using System.Xml.Linq;

public class CLT
{
    private OrgaoContratante orgaoContratante = OrgaoContratante.SemEmprego;
    private double salarioGeral = 0;
    private double salarioUnitario = 0;

    public double SalarioBruto { get; set; }
    public double SalarioLiquido { get; set; }


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

    // Método para calcular o salário líquido após impostos
    public void CalcularSalarioLiquido()
    {
        SalarioLiquido = SalarioBruto - CalcularImpostoSalarioEmpregado(SalarioBruto);
    }

    // Método para calcular imposto sobre salário do empregado (25%)
    private static double CalcularImpostoSalarioEmpregado(double salario)
    {
        return salario * 0.25;
    }

    // Método para simular a compra no comércio
    public void ComprarNoComercio(Comercio comercio, Prefeitura prefeitura)
    {
        int quantidadeComprada = (int)(SalarioLiquido / comercio.valorDaVenda);
        double valorGasto = quantidadeComprada * comercio.valorDaVenda;
        double impostoVenda = comercio.CalcularImpostoVendaComercio(valorGasto);

        // Verifica se há estoque suficiente no comércio
        if (comercio.quantidadeDeProduto < quantidadeComprada)
        {
            Console.WriteLine("❌ Comércio sem estoque suficiente! Simulação interrompida.");
            Environment.Exit(0);
        }

        // Processa a compra
        comercio.caixaDaEmpresa += (valorGasto - impostoVenda);
        prefeitura.caixaDaEmpresa += impostoVenda;
        comercio.quantidadeDeProduto -= quantidadeComprada;

        Console.WriteLine($"🛒 Empregado gastou R$ {valorGasto:N2} comprando {quantidadeComprada} itens no Comércio.");
    }

}

