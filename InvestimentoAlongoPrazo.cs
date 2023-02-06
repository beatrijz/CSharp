using System;
class InvestimentoAlongoPrazo
{
	private void Main(string[] args)
	{
		Console.WriteLine("Execultando o projeto 11 - Fator de rendimento");
		double fatorDeRendimento = 1.005;
		double investimento = 1000;
		//encadeamento de for 
		for (int anos = 1; anos <= 5; anos++)
		{
			for (int mes = 1; mes <= 12; mes++)
			{
				investimento *= fatorDeRendimento;
			}

				fatorDeRendimento += + 0.001;
			
		}
		Console.WriteLine("Depois de cinco anod você terá R$ " + investimento);

		Console.WriteLine("Tecle enter para fechar");
		Console.WriteLine();
	}
}