class RobotSoldado: RobotBasico{
    int escudoMetal;
    public RobotSoldado(int x, int y, int id,string nombre, int energia, int escudo):base(x,y,id, nombre, energia){
        this.escudoMetal = escudo;
    }
    public void Atacar(RobotSoldado otro){
        otro.recibirAtaque();
    }
    public new void recibirAtaque(){
        if(escudoMetal > 0) escudoMetal--;
        else base.recibirAtaque();
    }
    public override void mostrarNombre()
    {
        Console.WriteLine($"Soy un soldado y me llamo: {nombre}");
    }
    public override string ToString()
    {
        return base.ToString()+"Escudo: "+escudoMetal;
    }
}