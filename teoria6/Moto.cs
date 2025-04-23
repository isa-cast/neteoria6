namespace Teoria6;

class Moto : Automotor
{
    public Moto(string marca, int modelo) : base(marca, modelo) { }

    public override void Imprimir()
    {
    Console.Write("Moto ");
    base.Imprimir();
    }
}