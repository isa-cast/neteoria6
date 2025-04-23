using Teoria6;

Auto a = new Auto("Ford",2000,TipoAuto.Deportivo);
Colectivo c = new Colectivo("Mercedes",2010,20);
a.Imprimir();
c.Imprimir();
Console.WriteLine(a.Marca + " " + a.Modelo);
Console.WriteLine(c.Marca + " " + c.Modelo);

Automotor[] vector = [
new Auto("Ford", 2015, TipoAuto.Deportivo),
new Colectivo("Mercedes", 2019, 20),
new Colectivo("Mercedes", 2018, 30),
new Auto("Nissan", 2020, TipoAuto.Familiar),
new Moto("Gilera", 2017)
];
ImprimidorAutomotores.Imprimir(vector);

Console.WriteLine(a);