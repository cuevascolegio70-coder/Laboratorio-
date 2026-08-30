//Bloque 1:
for (int i = 2; i < 10; i += 2)
{
    Console.WriteLine(i);
}
//Bloque 2:
int x = 5;
while (x > 0)
{
    Console.WriteLine(x);
    x = x - 2;
}
//Bloque 3:
for (int i = 0; i < 5; i++)
{
    if (i == 3)
    {
        break;
    }
    Console.WriteLine(i);
}
//Bloque 4:
for (int i = 0; i < 5; i++)
{
    if (i == 2)
    {
        continue;
    }
    Console.WriteLine(i);
}
