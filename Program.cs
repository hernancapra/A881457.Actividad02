using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A881457.Actividad02
{
    class Program
    {
        static void Main(string[] args)
        {
            //A) Ingreso de aeropuertos.
            string IngresoAeropuerto = "";
            List<string> ListaAeropuertos = new List<string>();
            string Agregar = "";

            do
            {                
                Console.WriteLine("Ingrese el código de aeropuerto: ");
                IngresoAeropuerto = Console.ReadLine();

                if (String.IsNullOrEmpty(IngresoAeropuerto)) //Se valida que lo ingresado no esté vacío.
                {
                    Console.WriteLine("No se ingresó un código de aeropuerto. Por favor, intentelo nuevamente.");
                }
                else if (IngresoAeropuerto.Any(c => Char.IsNumber(c))) //Se valida que no se ingresen números.
                {
                    Console.WriteLine("Los aeropuertos se identifican con un código de 3 letras. Por favor, intentelo nuevamente.");
                }

                else if (IngresoAeropuerto.Length != 3) //Se valida que las letras ingresadas no sean más de 3.
                {
                    Console.WriteLine("Los aeropuertos se identifican con un código de 3 letras. Por favor, intentelo nuevamente.");
                }
                else
                {
                    //se agrega a la lista de aeropuertos y se pregunta si se quiere agregar otro aeropuerto.
                    ListaAeropuertos.Add(IngresoAeropuerto.ToUpper());
                    Console.WriteLine("Se agregó el aeropuerto a la lista. ¿Desea agregar otro aeropuerto? [SI/NO]");
                    Agregar = Console.ReadLine();
                }
            } while (Agregar.ToUpper() == "SI");

            //B) Ingreso de vuelos

            string Origen;
            string Destino;
            string VueloValidado = "";
            string Capacidad;
            int CapacidadValidada = 0;

            Dictionary<string, int> Vuelos = new Dictionary<string, int>();

            do
            {                
                Console.WriteLine("Ingrese el origen del vuelo: ");
                Origen = Console.ReadLine();

                if (String.IsNullOrEmpty(Origen)) //Se valida que lo ingresado no esté vacío.
                {
                    Console.WriteLine("No se ingresó nada. Por favor, intentelo nuevamente.");
                }
                else if (Origen.Any(Char.IsDigit)) //Se valida que no se ingresen números.
                {
                    Console.WriteLine("El origen se debe identificar con un código de 3 letras. Por favor, intentelo nuevamente.");
                }
                else if (Origen.Length != 3) //Se valida que el código ingresado no tenga más de 3 letras.
                {
                    Console.WriteLine("Los aeropuertos se identifican con un código de 3 letras. Por favor, intentelo nuevamente.");
                }
                else
                {                    
                    Console.WriteLine("Ingrese el destino del vuelo: ");
                    Destino = Console.ReadLine();
                    
                    if (String.IsNullOrEmpty(Destino))
                    {
                        Console.WriteLine("No se ingresó nada. Por favor, intentelo nuevamente.");
                    }
                    else if (Destino.Any(c => Char.IsNumber(c))) 
                    {
                        Console.WriteLine("El destino se debe identificar con un código de 3 letras. Por favor, intentelo nuevamente.");
                    }
                    else if (Destino.Length != 3)
                    {
                        Console.WriteLine("Los aeropuertos se identifican con un código de 3 letras. Por favor, intentelo nuevamente.");
                    }
                    else
                    {
                        VueloValidado = Origen + "-" + Destino;
                        
                        Console.WriteLine("Ingrese la capacidad del vuelo: ");
                        Capacidad = Console.ReadLine();
                        
                        if (String.IsNullOrEmpty(Capacidad))
                        {
                            Console.WriteLine("No se ingresó nada. Por favor, intentelo nuevamente.");
                        }
                        else if (!int.TryParse(Capacidad, out CapacidadValidada))
                        {
                            Console.WriteLine("La capacidad se debe identificar con un número entero. Por favor, intentelo nuevamente.");
                        }
                        else
                        {                            
                            Vuelos.Add(VueloValidado.ToUpper(), CapacidadValidada);
                            Console.WriteLine("Se agregó el vuelo. ¿Desea agregar otro vuelo? [SI/NO]");
                            Agregar = Console.ReadLine();
                        }
                    }
                }
                Console.WriteLine("Se ingresó el vuelo " + VueloValidado + " con capacidad de " + CapacidadValidada + " personas.");
            }
            while (Agregar.ToUpper() == "SI");

            //C) Ingreso de reservas

            string IDReserva;
            int IDReservaValidado;
            string OrigenReserva;
            string DestinoReserva;
            string VueloReserva;
            string Adultos;
            int CantAdultos;
            string Menores;
            int CantMenores;
            string Infantes;
            int CantInfantes;
            int TotalPasajeros;

            Dictionary<string, int> Reservas = new Dictionary<string, int>();

            do
            {                
                Console.WriteLine("Ingrese ID de reserva: ");
                IDReserva = Console.ReadLine();

                if (String.IsNullOrEmpty(IDReserva))
                {
                    Console.WriteLine("No se ingresó nada. Por favor, intentelo nuevamente.");
                }
                else if (!int.TryParse(IDReserva, out IDReservaValidado))
                {
                    Console.WriteLine("La reserva se debe identificar con un número entero. Por favor, intentelo nuevamente.");
                }
                else
                {                    
                    Console.WriteLine("Ingrese el origen del vuelo: ");
                    OrigenReserva = Console.ReadLine();

                    if (String.IsNullOrEmpty(OrigenReserva))
                    {
                        Console.WriteLine("No se ingresó nada. Por favor, intentelo nuevamente.");
                    }
                    else if (OrigenReserva.Any(c => Char.IsNumber(c))) //Se valida que no se ingresen números.
                    {
                        Console.WriteLine("El destino se debe identificar con un código de 3 letras. Por favor, intentelo nuevamente.");
                    }
                    else if (OrigenReserva.Length != 3)
                    {
                        Console.WriteLine("El origen con un código de 3 letras. Por favor, intentelo nuevamente.");
                    }
                    else
                    {                        
                        Console.WriteLine("Ingrese el origen del vuelo: ");
                        DestinoReserva = Console.ReadLine();

                        if (String.IsNullOrEmpty(DestinoReserva))
                        {
                            Console.WriteLine("No se ingresó nada. Por favor, intentelo nuevamente.");
                        }
                        else if (DestinoReserva.Any(c => Char.IsNumber(c))) //Se validan que no se ingresen números.
                        {
                            Console.WriteLine("El destino se debe identificar con un código de 3 letras. Por favor, intentelo nuevamente.");
                        }
                        else if (DestinoReserva.Length != 3)
                        {
                            Console.WriteLine("El destino se identifican con un código de 3 letras. Por favor, intentelo nuevamente.");
                        }
                        else
                        {
                            VueloReserva = OrigenReserva.ToUpper() + "-" + DestinoReserva.ToUpper();
                            
                            Console.WriteLine("Ingrese la cantidad de pasajeros adultos del vuelo: ");
                            Adultos = Console.ReadLine();

                            if (String.IsNullOrEmpty(Adultos))
                            {
                                Console.WriteLine("No se ingresó nada. Por favor, intentelo nuevamente.");
                            }
                            else if (!int.TryParse(Adultos, out CantAdultos))
                            {
                                Console.WriteLine("La capacidad se debe identificar con un número entero. Por favor, intentelo nuevamente.");
                            }
                            else
                            {                                
                                Console.WriteLine("Ingrese la cantidad de pasajeros menores del vuelo (entre 3 y 10 años): ");
                                Menores = Console.ReadLine();

                                if (String.IsNullOrEmpty(Menores))
                                {
                                    Console.WriteLine("No se ingresó nada. Por favor, intentelo nuevamente.");
                                }
                                else if (!int.TryParse(Menores, out CantMenores))
                                {
                                    Console.WriteLine("La capacidad se debe identificar con un número entero. Por favor, intentelo nuevamente.");
                                }
                                else
                                {                                   
                                    Console.WriteLine("Ingrese la cantidad de pasajeros menores del vuelo (menores de 3 años): ");
                                    Infantes = Console.ReadLine();

                                    if (String.IsNullOrEmpty(Infantes))
                                    {
                                        Console.WriteLine("No se ingresó nada. Por favor, intentelo nuevamente.");
                                    }
                                    else if (!int.TryParse(Infantes, out CantInfantes))
                                    {
                                        Console.WriteLine("La capacidad se debe identificar con un número entero. Por favor, intentelo nuevamente.");
                                    }
                                    else
                                    {
                                        TotalPasajeros = CantAdultos + CantMenores + CantInfantes;
                                        
                                        if (TotalPasajeros > CapacidadValidada) //Se valida que no se pueda ingresar una reserva si excede la capacidad disponible del vuelo.
                                        {
                                            Console.WriteLine("No se puede tomar la reserva ya que excede la capacidad de pasajeros disponibles.");
                                        }
                                        else
                                        {
                                            CapacidadValidada -= TotalPasajeros;

                                            Reservas.Add(VueloReserva, IDReservaValidado);
                                            Console.WriteLine("Se agregó correctamente la reserva. ¿Desea agregar otra reserva? [SI/NO]");
                                            Agregar = Console.ReadLine();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } while (Agregar.ToUpper() == "SI");

            for (int indexVuelo = 0; indexVuelo < Vuelos.Count; indexVuelo++)
            {
                var itemVuelo = Vuelos.ElementAt(indexVuelo);
                string itemKeyVuelo = itemVuelo.Key;

                for (int indexReserva = 0; indexReserva < Vuelos.Count; indexReserva++)
                {
                    var itemReserva = Vuelos.ElementAt(indexReserva);
                    var itemKeyReserva = itemReserva.Key;
                    var itemvalueReserva = itemReserva.Value;

                    if (itemKeyVuelo == itemKeyReserva)
                    {

                    }
                }
            }
            Console.ReadLine();
        }
    }
}