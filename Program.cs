Console.Write("Ingrese m: ");
int valor = Convert.ToInt32(Console.ReadLine());
int temporal1 = 0;
int temporal2 = 1;
string cadena = "0 1";
for(int i = 1; i<valor-1; i++){
    int suma = temporal1 + temporal2;
    temporal1 = temporal2;
    temporal2 = suma;
    cadena += " " + Convert.ToString(temporal2);
}
Console.WriteLine("Los primeros numeros de Fibonacci son: ");
Console.WriteLine(cadena);
