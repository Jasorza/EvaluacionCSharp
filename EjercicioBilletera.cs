using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionCSharp
{
    class EjercicioBilletera
    {
        double inicial;
        int gasto;
        int saldo;
        double banco;
        double ahorro;
        double ahorro2;
        int opcion;
        string res;

        public double Inicial
        {
            get { return inicial; }
            set { inicial = value; }
        }

        public double Banco
        {
            get { return banco; }
            set { banco = value; }
        }

        public double Ahorro10
        {
            get { return ahorro; }
            set { ahorro = value;}
        }

        public double Ahorro2{
            get{ return ahorro2; }
            set{ ahorro2 = value; }
        }

        public int Gasto
        {
            get { return gasto; }
            set { gasto = value; }
        }

        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public int Opcion
        {
            get { return opcion; }
            set { opcion = value; }
        }

        public void Ingresar()
        {
            Console.WriteLine("Ingrese un valor de dinero Inicial: ");
            Inicial = int.Parse(Console.ReadLine());
        }

        public void Depositar()
        {
            if (Inicial>0)
            {
                Banco = Banco + Inicial + Ahorro2;
                Inicial = 0;
            }
        }

        public void Gastar()
        {
            Console.WriteLine("Ingrese el valor de lo que va a Gastar: ");
            Gasto = int.Parse(Console.ReadLine());
            Inicial = Inicial - Gasto;
            Ahorro10 = Gasto * 0.10;
            Inicial = Inicial - Ahorro10;
            Ahorro2 = Ahorro2 + Ahorro10;
        }

        public void ImprimirDinero()
        {
            Console.WriteLine("El dinero que hay en la billetera es de: "+Inicial);
        }

        public void TotalAhorrado()
        {
            Console.WriteLine($"El total de dinero ahorrado en el Banco es de: ${Banco}");
        }

        public void NotificaTransaciones()
        {
            if (Opcion==1)
            {
                Console.WriteLine("--------------------Notificación-----------------");
                Console.WriteLine($"Se ha ingresado un Dinero Inicial por el valor: ${Inicial}");
            }
            else if (Opcion==2)
            {
                Console.WriteLine("--------------------Notificación-----------------");
                Console.WriteLine($"Se ha hecho un gasto por: ${Gasto}");
            }
            else if (Opcion==3)
            {
                Console.WriteLine("--------------------Notificación-----------------");
                Console.WriteLine($"Se ha Trasferido todo el dinero de la Billetera al Banco");
            }
            else if (Opcion==4)
            {
                Console.WriteLine("--------------------Notificación-----------------");
                Console.WriteLine($"Se ha consultado el Dinero en la Billetera");
            }
            else if (Opcion==5)
            {
                Console.WriteLine("--------------------Notificación-----------------");
                Console.WriteLine($"Se ha consultado el Saldo en el Banco");
            }
        }

        public void Menu()
        {
            Console.WriteLine("------------------------|Menú|------------------------");
            Console.WriteLine("1)--> Ingresar Dinero Inicial.");
            Console.WriteLine("2)--> Ingresar un Gasto.");
            Console.WriteLine("3)--> Depositar toda la billetera en el Banco.");
            Console.WriteLine("4)--> Consultar Saldo de la Billetera.");
            Console.WriteLine("5)--> Consultar Dinero total Ahorrado en el Banco.");
            Console.WriteLine("6)--> Salir de la Aplicación");
			Console.WriteLine("Seleccione una opcion");

            Opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case (int)1:
                    Ingresar();
                    NotificaTransaciones();
                    Console.WriteLine("<--Presiona cualquier tecla para volver al Menú");
                    res = Console.ReadLine();
                    if (true)
                    {
                        Menu();
                    }
                    break;

                case (int)2:
                    if (Inicial>0)
                    {
                        Gastar();
                        NotificaTransaciones();
                        Console.WriteLine("<--Presiona cualquier tecla para volver al Menú");
                        res = Console.ReadLine();
                        if (true)
                        {
                            Menu();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay dinero en la billetera");
                        Console.WriteLine("<--Presiona cualquier tecla para volver al Menú");
                        res = Console.ReadLine();
                        if (true)
                        {
                            Menu();
                        }
                    }
                    
                    
                    
                    break;

                case (int)3:
                    Depositar();
                    NotificaTransaciones();
                    Console.WriteLine("<--Presiona cualquier tecla para volver al Menú");
                    res = Console.ReadLine();
                    if (true)
                    {
                        Menu();
                    }
                    break;

                case (int)4:
                    ImprimirDinero();
                    NotificaTransaciones();
                    Console.WriteLine("<--Presiona cualquier tecla para volver al Menú");
                    res = Console.ReadLine();
                    if (true)
                    {
                        Menu();
                    }
                    break;

                case (int)5:
                    TotalAhorrado();
                    NotificaTransaciones();
                    Console.WriteLine("<---Presiona cualquier tecla para volver al Menú");
                    res = Console.ReadLine();
                    if (true)
                    {
                        Menu();
                    }
                    break;

                case (int)6:
                    Console.WriteLine("Hasta la Proxima");
                    break;
                default:
                    Console.WriteLine("Opcion no valida, Intente de nuevo");
                    Menu();
                    break;
            }
        }
    }
}
