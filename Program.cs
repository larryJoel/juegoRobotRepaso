internal class Program
{
    private static void Main(string[] args)
    {
       var mapa =  new List<Cosa>();
       var cosa1 = new Cosa(0,0,0,9,"piedra");

       var RobotBasico1 = new RobotBasico(1,2,10,"Robotito",100);
       var RobotBasico2 = new RobotBasico(3,3,11,"Bob",100);

       var soldado1 = new RobotSoldado(5,5,12,"soldado 1", 100,100);
       var soldado2 = new RobotSoldado(7,7,12,"soldado 2", 100,100);

       mapa.Add(cosa1);
       mapa.Add(RobotBasico1);
       mapa.Add(RobotBasico2);
       mapa.Add(soldado1);
       mapa.Add(soldado2);
       RobotBasico1.Atacar(RobotBasico2);
       soldado1.Atacar(RobotBasico1);
       soldado1.Atacar(soldado2);

       soldado1.decirNombre();
       Cosa algo;
       algo = soldado1;
       algo.decirNombre();
       RobotBasico rb;
       rb = soldado1;
       rb.decirNombre();

       //mostrar todo lo que hay en el mapa
       foreach (var elemento in mapa)
       {
        Console.WriteLine(elemento);
        
       }
        
    }
}