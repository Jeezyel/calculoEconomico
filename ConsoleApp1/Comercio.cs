// See https://aka.ms/new-console-template for more information

public class Comercio
{

    public double Emprega { get; set; } = 200;
    public double salarioDeCadaEmpregado { get; set; } = 7500;

    //tem caixa mas n tem item para vender 
    //vc pode gastar tudo de uma vez e vendo quando ganha pra comprar mais 
    public double caixaDaEmpresa { get; set; } = 10000000;
    public double custoDeReposicaoDeEstoque { get; set; } = 75;
    public double valorDaVenda { get; set; } = 203;

    public int quantidadeDeProduto { get; set; } = 0;

    public bool ReporEstoque(Industria industria)
    {
        int quantidadeNecessaria = 1055;
        double custoTotal = quantidadeNecessaria * industria.valorDaVenda;

        if (caixaDaEmpresa < custoTotal)
        {
            Console.WriteLine("❌ Comércio não tem dinheiro suficiente para repor o estoque!");
            return false;
        }


        bool compraRealizada = industria.VenderParaComercio(quantidadeNecessaria, out double valorPago);
        if (!compraRealizada)
        {
            Console.WriteLine("❌ Indústria não conseguiu fornecer os itens necessários.");
            return false;
        }

        caixaDaEmpresa -= custoTotal;
        quantidadeDeProduto += quantidadeNecessaria;

        Console.WriteLine($"✅ Comércio comprou {quantidadeNecessaria} itens da Indústria por R$ {custoTotal:N2}");
        return true;
    }

    // Método para calcular imposto sobre salário do empregador
    public static double CalcularImpostoSalarioEmpregador(double salario)
    {
        double imposto = salario * 0.61;
        return imposto;
    }

    // Método para calcular imposto sobre salário do empregado
    public static double CalcularImpostoSalarioEmpregado(double salario)
    {
        double imposto = salario * 0.25;
        return imposto;
    }

    // Método para calcular imposto sobre venda do comércio
    public double CalcularImpostoVendaComercio(double precoVenda)
    {
        double imposto = precoVenda * 0.38;
        return imposto;
    }

    // Método para calcular imposto sobre venda da indústria
    public static double CalcularImpostoVendaIndustria(double precoVenda)
    {
        double imposto = precoVenda * 0.18;
        return imposto;
    }

}

