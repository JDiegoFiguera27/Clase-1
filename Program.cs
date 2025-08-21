// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Personas persona1 = new Personas();
persona1.Id = 2323;
persona1.Nombre = "Juanchito";
persona1.XP = 329;
persona1.fechaIngreso = DateTime.Now;
persona1.Privilegios = new List<Privilegios>();
persona1.Privilegios.add(new Privilegios {Id = 0, vipNivel = 2, esVIP = true });
persona1.Administradores = new Administradores { nivelAdmin = 1, tipoAdmin = "Admin de Host"};
Console.WriteLine(persona1.Id);
Console.WriteLine(persona1.Nombre);
Console.WriteLine(persona1.XP);
Console.WriteLine(persona1.fechaIngreso);
Console.WriteLine(persona1.Administradores.nivelAdmin);
Console.WriteLine(persona1.Administradores.tipoAdmin);




public class Personas{
    public int Id = 0;
    public decimal XP = 0;
    public String? Nombre = "";
    public DateTime fechaIngreso = DateTime.Now;
    public bool administrador = false;
    public Administradores admin = new Administradores();
    public List<Privilegios> Privilegios = new List<Privilegios>();

}

public class Administradores : Personas{

    public DateTime fechaAdministrador = DateTime.Now;
    public int nivelAdmin = 0;
    public String tipoAdmin = "";

}


public class Privilegios{
    public int Id = 0;
    public int vipNivel = 0;
    public bool esVIP = false;

}