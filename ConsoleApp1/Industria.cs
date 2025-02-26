// See https://aka.ms/new-console-template for more information

public class Industria
{

    public double Emprega { get; set; } = 675;
    public double salarioDeCadaEmpregado { get; set; } = 10000;
    public double caixaDaEmpresa { get; set; } = 50000000;
    public double custoDeReposicaoDeEstoque { get; set; } = 42.75;
    public double valorDaVenda { get; set; } = 75;

    public int quantidadeDeProduto { get; set; } = 0;


    // Método para vender produtos ao Comércio
    public bool VenderParaComercio(int quantidade, out double receitaLiquida)
    {
        receitaLiquida = 0;

        // Custo total para produzir os itens
        double custoTotalProducao = quantidade * custoDeReposicaoDeEstoque;
        if (caixaDaEmpresa < custoTotalProducao)
        {
            Console.WriteLine("❌ Indústria não tem dinheiro suficiente para produzir os itens.");
            return false;
        }

        // Deduz custo de produção
        caixaDaEmpresa -= custoTotalProducao;

        // Receita bruta da venda
        double receitaBruta = quantidade * valorDaVenda;
        double imposto = receitaBruta * 0.18; // 18% de imposto sobre venda
        receitaLiquida = receitaBruta - imposto;

        // Adiciona a receita líquida ao caixa
        caixaDaEmpresa += receitaLiquida;

        Console.WriteLine($"✅ Indústria vendeu {quantidade} itens para o Comércio e recebeu R$ {receitaLiquida:N2} (após imposto).");
        return true;
    }

}

