Console.WriteLine("Digite um número para ver a tabuada:");
int numero = Convert.ToInt32(Console.ReadLine());
int contador = 1;
int limite = 10;

while (contador <= limite)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
}
