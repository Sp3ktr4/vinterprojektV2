using System;

int spektraHp = 100;
int fiendeHp = 100;

string spektraName = "SPEKTRA";
string fiendeName = "FIENDE";

Random generator = new Random();

while (spektraHp > 0 && fiendeHp > 0)
{
  Console.WriteLine("<<<NEW ROUND>>>");
  Console.WriteLine($"{spektraName}: {spektraHp}  {fiendeName}: {fiendeHp}\n");

  int spektraDamage = generator.Next(20);
  fiendeHp -= spektraDamage;
  fiendeHp = Math.Max(0, fiendeHp);
  Console.WriteLine($"{spektraName} gör {spektraDamage} skada på {fiendeName}");

  int fiendeDamage = generator.Next(20);
  spektraHp -= fiendeDamage;
  spektraHp = Math.Max(0, spektraHp);
  Console.WriteLine($"{fiendeName} gör {fiendeDamage} skada på {spektraName}");

  Console.WriteLine("Tryck på vilken knapp som helst för att fortsätta.");
  Console.WriteLine(" ");
  Console.ReadKey();
}



Console.WriteLine("<<<FIGHT IS OVER>>>");

if (spektraHp == 0 && fiendeHp == 0)
{
  Console.WriteLine("Stalemate!");
}

else if (spektraHp == 0)
{
  Console.WriteLine($"{fiendeName} is better!");
}

else
{
  Console.WriteLine($"{spektraName} is best!");
}

Console.WriteLine("Tryck på vilken knapp som helst för att avsluta.");
Console.ReadKey();