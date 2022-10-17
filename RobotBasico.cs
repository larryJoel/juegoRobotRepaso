class RobotBasico: Cosa{
    int energia;
    public int Energia{get=>energia;set=>energia=value;}
    public RobotBasico(int x, int y, int id, string nombre, int energia):base(x,y,0,id, nombre){
        this.energia =energia;
    }
    public void Mover(int pasosEnX, int pasosEnY){
        X += pasosEnX;
        Y += pasosEnY;
    }
    public void Atacar(RobotBasico otro){
        otro.recibirAtaque();
    }
    public void recibirAtaque(){
        energia--;
    }
    public override void mostrarNombre()
    {
        Console.WriteLine($"Soy un simple robot y me llamo {nombre}");
    }
    public override string ToString()
    {
        return base.ToString()+"Energia: "+energia;
    }
}