﻿// See https://aka.ms/new-console-template for more information

public class Comercio
{

    private double Emprega { get; set; } = 200;
    private double salarioDeCadaEmpregado { get; set; } = 7500;

    //tem caixa mas n tem item para vender 
    //vc pode gastar tudo de uma vez e vendo quando ganha pra comprar mais 
    private double caixaDaEmpresa { get; set; } = 10000000;
    private double custoDeReposicaoDeEstoque { get; set; } = 75;
    private double valorDaVenda { get; set; } = 203;

    private int quantidadeDeProduto { get; set; } = 0;

    /*
     * O Comércio precisa ter estoque suficiente para atender toda a população economicamente ativa.
     * Se não conseguir repor o estoque, a simulação deve ser interrompida
     * */

}

