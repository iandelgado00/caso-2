using System;
class Program
{
    static void Main(string[] args)
    {
        double precio;
        int cantidad;
        double total;
        double descuento;
        double totalPagar;

        Console.Write("Digite el precio del producto: ");
        precio = double.Parse(Console.ReadLine());
        Console.Write("Digite la cantidad: ");
        cantidad = int.Parse(Console.ReadLine());
        if (precio > 0 && cantidad > 0)
        {
            total = precio * cantidad;



            if (total > 25000)
            {
                descuento = total * 0.10;
            }
            else
            {
                descuento = 0;
            }

            totalPagar = total - descuento;

            Console.WriteLine("Total: " + total);
            Console.WriteLine("Descuento: " + descuento);
            Console.WriteLine("Total a pagar: " + totalPagar);
        }
        else
        {
            Console.WriteLine("Los datos no son validos.");
        }
    }
}
