﻿double percentualBonus, percentualRetorno;
int pontosATransferir;
int pontosAReduzirOrigem, pontosAAcrescentarDestino;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Milhas Bumerangue");
Console.ResetColor();
Console.WriteLine();

Console.Write("percentual de bônus...: ");
percentualBonus = Convert.ToDouble(Console.ReadLine());

Console.Write("Percentual de retorno...: ");
percentualRetorno = Convert.ToDouble(Console.ReadLine());

Console.Write("Pontos a transferir...: ");
pontosATransferir = Convert.ToInt32(Console.ReadLine());

pontosAReduzirOrigem = Convert.ToInt32(pontosATransferir - (percentualRetorno / 100) * pontosATransferir);
pontosAAcrescentarDestino = Convert.ToInt32(pontosATransferir + (percentualBonus / 100) * pontosATransferir);

Console.WriteLine();
Console.WriteLine($"Pontos a reduzir na origem.....: {pontosAReduzirOrigem}");
Console.WriteLine($"Pontos a acrescentar no destino....: {pontosAAcrescentarDestino}");