class Cosa{
    int x;
    int y;
    int z;
    int id;
    public string nombre;
    public int X{
        get{return x;}
        set{x=value;}
    }
    public int Y{
        get{return y;}
        set{y=value;}
    }
    public int Z{
        get{return z;}
        set{z = value;}
    }

    public int ID{
        get{return id;}
    }
    public Cosa(int x, int y, int z, int id, string nombre){
        X = X;
        Y = Y;
        Z = Z;
        this.id = id;
        this.nombre = nombre;
    }
    public void decirNombre(){
        mostrarNombre();
    }
    public virtual void mostrarNombre(){
        Console.WriteLine($"Soy una cosa y me llamo {nombre}"); 
    }
    public override string ToString()
    {
        return $"Id: {id}, (x,y,z):{x}{y}{z}, Nombre: {nombre}";
    }

}