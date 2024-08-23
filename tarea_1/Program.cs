public interface IEdificio
{
    void Construir();
}
public class Castillo : IEdificio
{
    public void Construir()
    {
        Console.WriteLine("Construyendo un castillo.");
    }
}
public class Torre : IEdificio
{
    public void Construir()
    {
        Console.WriteLine("Construyendo una torre.");
    }
}
public class Muralla : IEdificio
{
    public void Construir()
    {
        Console.WriteLine("Construyendo una muralla.");
    }
}
public interface IEdificioFactory
{
    IEdificio CrearEdificio();
    public void CreandoEdificio()
    {
        Console.WriteLine("Creando Edifio.");
    }

}
public class CastilloFactory : IEdificioFactory
{
    public IEdificio CrearEdificio()
    {
        return new Castillo();
    }
}
public class TorreFactory : IEdificioFactory
{
    public IEdificio CrearEdificio()
    {
        return new Torre();
    }
}
public class MurallaFactory : IEdificioFactory
{
    public IEdificio CrearEdificio()
    {
        return new Muralla();
    }
}
class Juego
{
    private List<IEdificio> edificios = new();

    public void AgregarEdificio(IEdificio edificio)
    {
        edificios.Add(edificio);
    }

    public void ConstruirTodos()
    {
        Console.WriteLine("Construyendo todos los edificios:");
        foreach (var edificio in edificios)
        {
            edificio.Construir();
        }
    }
}

class Program
{
    static void Main()
    {
        Juego juego = new Juego();

        IEdificioFactory castilloFactory = new CastilloFactory();
        IEdificioFactory torreFactory = new TorreFactory();
        IEdificioFactory murallaFactory = new MurallaFactory();

        IEdificio castillo = castilloFactory.CrearEdificio();
        juego.AgregarEdificio(castillo);

        IEdificio torre = torreFactory.CrearEdificio();
        juego.AgregarEdificio(torre);

        IEdificio muralla = murallaFactory.CrearEdificio();
        juego.AgregarEdificio(muralla);

        juego.ConstruirTodos();
    }
}