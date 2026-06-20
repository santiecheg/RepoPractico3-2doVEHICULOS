using System;

public class Auto:Vehiculo{


    private string patente;

    public string Patente {get{return this.patente;} set{this.patente = value;}}


    public Auto (string marca, string modelo, int velocidad, string patente):base(marca,modelo,velocidad){
        this.patente=patente;
    }



    
    public override int Frenar(){

        Random rand = new Random();
        Velocidad-= rand.Next(1,50);
        return Velocidad;

    }

    public override int Acelerar() {


        Random rand = new Random();
        Velocidad+= rand.Next(1,100);
        return Velocidad;

    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Auto: {Marca} modelo: {Modelo}");
        Console.WriteLine($"Patente: {Patente}");
        base.MostrarInfo();
    }
}