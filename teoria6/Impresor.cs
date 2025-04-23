namespace Teoria6;

static class ImprimidorAutomotores
{
public static void Imprimir(Automotor[] vector)
{
foreach (Automotor a in vector)
{
a.Imprimir();
}
}
}