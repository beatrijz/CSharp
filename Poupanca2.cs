﻿using System;
class Poupanca
{
	static void Main(string[] args)
	{
		Console.WriteLine("Execultando o projeto 10 - Calcula Polpança");


		//rentimento de 0.5% (0.005) ao mês
		/*
		while (mes <= 12)
		{
			investimento = investimento + investimento * 0.005;
			Console.WriteLine("No mês " + mes + " você tem R$" + investimento);
			// mes += 1;
			//mes = mes + 1;
			mes++;

		}
		*/

		double investimento = 1000;

		for (int mes = 1; mes <= 12; mes++)
		{
			investimento *= 1.005;
			Console.WriteLine("No mês " + mes + " você tem R$" + investimento);
		}


		Console.WriteLine("Tecle enter para fechar");
		Console.WriteLine();
	}
}