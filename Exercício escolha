using System; 

class URI {

    static void Main(string[] args) { 

        string opcoes = Console.ReadLine();
        string[] quantidadeOpcoes = opcoes.Split(' ');

        string escolha = Console.ReadLine();
        string[] quantidadesEscolha = escolha.Split(' ');

        int diferenca = 0;
        int somaDiferenca = 0;

        for (int i = 0; i < quantidadeOpcoes.Length; i++)
        {
             int opcaoAtual = Convert.ToInt32(quantidadeOpcoes[i]);
             int escolhaAtual = Convert.ToInt32(quantidadesEscolha[i]);
               
             if (opcaoAtual < escolhaAtual) 
             {
                diferenca = opcaoAtual - escolhaAtual;    
             }
             if (diferenca < 0)
             {
                diferenca = diferenca * -1;
                somaDiferenca += diferenca;
             }
       }
            Console.WriteLine(somaDiferenca);
    }
