Console.WriteLine("--- Esperto Contra Sabido ---\n");
Console.Write("Quantos alimentos serão distribuídos? ");
int total = int.Parse(Console.ReadLine());

int picaPau = 0;
int raposinha = 0;
int rodada = 1;

while (total > 0)
{
    if (total > 0)
   {
        Console.Write(rodada + " para você. ");
        picaPau++;
        total--;
    }
    else
    {
        break;
    }

        if (total > 0)
        {
            int raposaRecebe = rodada <= total ? rodada : total;
            for (int i = 1; i <= raposaRecebe; i++)
                {
                    if (i == 1)
                        Console.Write(i);
                    else
                        Console.Write(", " + i);
                }
                Console.WriteLine(" para mim.");

                raposinha += raposaRecebe;
                total -= raposaRecebe;
        }
        else
        {
            Console.WriteLine();
        }
            rodada++;
        }

Console.WriteLine($"\nPica-pau recebeu {picaPau} alimento(s).");
Console.WriteLine($"Raposinha recebeu {raposinha} alimento(s).");