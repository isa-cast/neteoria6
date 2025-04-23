
namespace Teoria6;

abstract class Automotor {

  /*public abstract void HacerMantenimiento();
  public abstract DateTime FechaService { get; set; }
  public abstract double PrecioDeVenta { get; }*/

  public string Marca {get; } // protected hace que la propiedad sea accesible desde la misma clase o subclases, aunque no es aconsejable, siempre es mejor poner private
  private int _modelo;
  public virtual int Modelo
  {
        get => _modelo;
        protected set => _modelo = (value < 2005) ? 2005 : value;
   }

  public Automotor(string marca, int modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }  

    public Automotor()
{
}
  public virtual void Imprimir()
     => Console.WriteLine($"{Marca} {Modelo}");

    public override string ToString()
        {
        return $"Marca: {Marca} \nModelo: {Modelo}";
        }
}