using System;

namespace Diciionariosd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones("", 0);
            bool entrar = Loggin();
            if (entrar)
            {
                bool salir = false;
                while (!salir)
                {
                    switch (Menu())
                    {
                        case EnumMenu.Mostrar:
                            acciones.Show();
                            break;
                        case EnumMenu.Agregar:
                            acciones.AddStudents();
                            break;
                        case EnumMenu.Eliminar:
                            acciones.RemoveMatricula();
                            break;
                        case EnumMenu.Actualizar:
                            acciones.UpdateMatricula();
                            break;
                        case EnumMenu.Buscar:
                            acciones.Search();
                            break;
                        case EnumMenu.Contar:
                            acciones.Count();
                            break;
                        case EnumMenu.Salir:
                            salir = true;
                            Console.WriteLine("Saliendo...");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("PIN incorrecto.");
            }
        }

        public enum EnumMenu
        {
            Mostrar = 1,
            Agregar,
            Eliminar,
            Actualizar,
            Buscar,
            Contar,
            Salir
        }

        static EnumMenu Menu()
        {
            Console.WriteLine("\n--- Menú de Estudiantes ---");
            Console.WriteLine("1) Mostrar estudiantes");
            Console.WriteLine("2) Agregar estudiante");
            Console.WriteLine("3) Eliminar matrícula");
            Console.WriteLine("4) Actualizar matrícula");
            Console.WriteLine("5) Buscar estudiante");
            Console.WriteLine("6) Contar estudiantes");
            Console.WriteLine("7) Salir");
            Console.Write("Seleccione una opción: ");

            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 7)
            {
                Console.WriteLine("Opción no válida. Intente de nuevo:");
            }
            return (EnumMenu)opcion;
        }

        static bool Loggin()
        {
            Console.WriteLine("Dame PIN");
            string pin = Console.ReadLine();
            return pin == "1234";
        }
    }
}
