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

    /*
     * O Comércio precisa ter estoque suficiente para atender toda a população economicamente ativa.
     * Se não conseguir repor o estoque, a simulação deve ser interrompida
     * */

}

