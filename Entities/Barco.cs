using System;

public class Barco:Vehiculo{


    private int tripulacion;

    public int Tripulacion {get{return this.tripulacion;} set{value=this.tripulacion;}}


    public Barco (string marca, string modelo, int velocidad, int tripulacion):base(marca,modelo,velocidad){
        this.tripulacion=tripulacion;
    }



    
    public override int Frenar(){

        Random rand = new Random();
        Velocidad-= rand.Next(1,2);
        return Velocidad;

    }

    public override int Acelerar() {


        Random rand = new Random();
        Velocidad+= rand.Next(1,10);
        return Velocidad;

    }


    public override void MostrarInfo()
    {
        Console.WriteLine($"Auto: {Marca} modelo: {Modelo}");
        Console.WriteLine($"Se necesita una tripulación Mínima de: {tripulacion}");
        base.MostrarInfo();
    }
}