// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

public class ComercioMercado
{
    


    // TODOS OS VALORA DOS SALARIO SERÃO SERÃOCALCULADO JUNTO DEPOS DIVIDIDO PARA DAR O
    // VALOR DE CADA COLABORADOR
    static void Main(string[] args)
    {
        CLT[] clt;
        Comercio comercio = new Comercio();
        Industria industria = new Industria();
        Prefeitura prefeitura = new Prefeitura();


        int anosPassados = 0;

        // quando o mes chegar a 12  zera e começa denovo e add +1 na variavel "anosPassados"
        int mesPassados = 0;
        

        


        for (int i = 0; mesPassados <= 13; mesPassados++)
        {
            if (mesPassados == 13)
            {
                anosPassados++;
                mesPassados = 0;
            }
                
            if (anosPassados == 5)
            {
                mesPassados = 14;
            }

            Console.WriteLine("ANOS PASSADOS: " + anosPassados + "\nMES PASSADO: " + mesPassados);

        }

    }

    public static double impostoSobreSalario()
    {
        return 0;
    }

    public static double impostoSobreVenda()
    {
        return 0;
    }

    ////////////////////////////////////////////////////////////////////////////////
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
    public static double CalcularImpostoVendaComercio(double precoVenda)
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

/*
 * Regras de impostos

Impostos sobre salários:
Para cada colaborador, a empresa e o comércio recolhem 61% de impostos e/ou obrigações sobre o salário bruto.
O colaborador tem 25% do seu salário descontado como imposto.


Impostos sobre vendas:
Comércio: Recolhe 38% de impostos sobre cada item vendido. Ou seja, ao vender um item por R$ 100,00, o Comércio fica com R$ 62,00 e a prefeitura com R$ 38,00.
Indústria: Recolhe 18% de impostos sobre cada item vendido ao Comércio.
Regras para os beneficiários dos serviços sociais:
Não pagam impostos sobre os benefícios recebidos, mas pagam impostos sobre as compras que fazem no comércio.
Tarefas

Simule os ciclos mensais, imprimindo ao final de cada ano a condição financeira de cada entidade.
Imprima o valor anual pago de impostos pelo comercio, indústria e a população respectivamente.
Apresente o número total de ciclos (anos) até que uma das entidades não tenha mais dinheiro para continuar operando (se acontecer).

Adicionalmente, para a entrega da atividade, você deve criar um repositório git e colocar como colaborador o usuário jhoseju@gmail.com. A entrega deve ser o link para o código disponível para ser cloano no repositório.
Não esqueça de configurar o git ignore.
 */