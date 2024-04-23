using EjS9.Clases;

Carro carrito = new Carro("Toyota", 2024);
Carro car2 = new Carro("Porche",2025);

carrito.Color = "Rojo";
carrito.Owner = "Juan";


Console.WriteLine("Marca: " + carrito.Marca);
Console.WriteLine("Marca de mi segundo carro: " + car2.Marca);

if (car2.Acelerar()==0)
{
    Console.WriteLine("El carro esta apagado.");
}
else
{
    Console.WriteLine(car2.Acelerar() + "/KPH");
    Console.WriteLine(car2.Acelerar() + "/KPH");
    Console.WriteLine(car2.Acelerar() + "/KPH");
    Console.WriteLine(car2.Acelerar() + "/KPH");
    car2.Acelerar();
}



