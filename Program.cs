/*

Ejercicio 1 — Sistema de Gestión de Vehículos


Una empresa de transporte necesita un sistema de consola para administrar distintos tipos de vehículos.

El sistema debe permitir:
• Registrar diferentes vehículos.
• Mostrar la información de cada vehículo.
• Simular aceleraciones y frenadas.
• Mostrar cómo cambia la velocidad de cada vehículo luego de realizar acciones.
• Permitir que cada tipo de vehículo tenga un comportamiento diferente al acelerar y frenar.

Requisitos funcionales:
• Cada vehículo debe tener información básica.
• El sistema debe poder trabajar con varios tipos de vehículos distintos.
• Cada tipo de vehículo debe implementar su propia lógica de aceleración y frenado.
• Desde el programa principal se deben ejecutar acciones sobre distintos vehículos y mostrar los resultados en
consola.


El programa debe demostrar:
• Uso de herencia.
• Polimorfismo.
• Reutilización de código.
• Organización correcta de responsabilidades entre clases.


Ejemplo de salida esperada
===== SISTEMA DE VEHÍCULOS =====
Vehículo: Toyota Corolla
Velocidad actual: 0 km/h
Acelerando...
Velocidad actual: 20 km/h
Frenando...
Velocidad actual: 10 km/h
--------------------------------
Vehículo: Yamaha MT-03
Velocidad actual: 0 km/h
Acelerando...
Velocidad actual: 35 km/h


*/

using System.Runtime.InteropServices;

class Program {


    static List<Vehiculo> listaVehiculos = new List<Vehiculo>();
    static void Main(){

        MostrarMenu();
        
    }

    static void MostrarMenu()
    {
        Console.WriteLine("Bienvenido (nuevamente) al gestor de vehículos (dos)");

        Console.WriteLine("Ingrese la opción que desea realizar");

        int opcionControl=666;

        while (opcionControl != 0)
        {
            Console.WriteLine("Opcion 1: Registrar Auto");
            Console.WriteLine("Opcion 2: Registrar Moto");
            Console.WriteLine("Opcion 3: Registrar Barco");
            Console.WriteLine("Opcion 4: Mostrar vehiculos registrados");
            Console.WriteLine("Opcion 5: Cerrar programa");
            
            int opcionUsuario = int.Parse(Console.ReadLine());

            switch (opcionUsuario)
            {
                
                case 1:
                    RegistrarAuto();
                    break;
                case 2:
                    RegistrarMoto();
                    break;
                case 3:
                    RegistrarBarco();
                    break;
                case 4:
                    MostrarVehiculos();
                    break;
                case 5:
                    Console.WriteLine("Gracias por usar softwares gatito");
                    opcionControl=0;
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta, pruebe con una opción válida");
                    break;    

            }

        }

    }

    static void RegistrarAuto()
    {
        string marca,modelo,patente;
        Console.WriteLine("Ingrese marca del auto");
        marca=Console.ReadLine();

        Console.WriteLine("Ingrese modelo del auto");
        modelo=Console.ReadLine();

        Console.WriteLine("Ingrese patente del auto");
        patente=Console.ReadLine();

        listaVehiculos.Add(new Auto (marca,modelo,0,patente));

    }

    static void RegistrarMoto()
    {
         string marca,modelo,patente;
        Console.WriteLine("Ingrese marca de la motocicleta");
        marca=Console.ReadLine();

        Console.WriteLine("Ingrese modelo de la motocicleta");
        modelo=Console.ReadLine();

        Console.WriteLine("Ingrese patente de la motocicleta");
        patente=Console.ReadLine();

        listaVehiculos.Add(new Moto (marca,modelo,0,patente));
    }

    static void RegistrarBarco()
    {
         string marca,modelo;
        Console.WriteLine("Ingrese marca del barco");
        marca=Console.ReadLine();

        Console.WriteLine("Ingrese modelo del barco");
        modelo=Console.ReadLine();

        Console.WriteLine("Ingrese los tripulantes mínimos para operar esta embarcación");
        int tripulacion=int.Parse(Console.ReadLine());

        listaVehiculos.Add(new Barco (marca,modelo,0,tripulacion));
    }

    static void MostrarVehiculos()
    {
        Console.WriteLine(" \n Mostrando vehiculos..");
        foreach (Vehiculo c in listaVehiculos)        
        {
            Console.WriteLine(" - - - - - - - - - - - - - - - - - - -");
            c.MostrarInfo();
            Console.WriteLine(" - - - - - - - - - - - - - - - - - - -");
        }
    }

}
