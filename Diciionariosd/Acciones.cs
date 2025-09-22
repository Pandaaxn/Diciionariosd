using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diciionariosd
{
    internal class Acciones
    {

        public string nombre { get; set; }  
        public int matricula { get; set; }

        private Dictionary<int, string> StudentsDictionary = new Dictionary<int, string>();

        public void AddStudents()
        {
            Console.WriteLine("Dame la Matricula: ");
            int matricula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame nombre: ");
            string nombre = Console.ReadLine();
            StudentsDictionary.Add(matricula, nombre);
        }
    
        // Elimina una matrícula del diccionario
        public void RemoveMatricula()
        {
            Console.WriteLine("Ingrese la matrícula a eliminar:");
            int matricula = Convert.ToInt32(Console.ReadLine());
            if (StudentsDictionary.Remove(matricula))
            {
                Console.WriteLine("Matrícula eliminada correctamente.");
            }
            else
            {
                Console.WriteLine("Matrícula no encontrada.");
            }
        }

        // Actualiza el nombre de una matrícula existente
        public void UpdateMatricula()
        {
            Console.WriteLine("Ingrese la matrícula a actualizar:");
            int matricula = Convert.ToInt32(Console.ReadLine());
            if (StudentsDictionary.ContainsKey(matricula))
            {
                Console.WriteLine("Ingrese el nuevo nombre:");
                string nuevoNombre = Console.ReadLine();
                StudentsDictionary[matricula] = nuevoNombre;
                Console.WriteLine("Nombre actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("Matrícula no encontrada.");
            }
        }

        // Muestra todos los estudiantes
        public void Show()
        {
            Console.WriteLine("Listado de estudiantes:");
            foreach (var estudiante in StudentsDictionary)
            {
                Console.WriteLine($"Matrícula: {estudiante.Key}, Nombre: {estudiante.Value}");
            }
        }

        // Busca un estudiante por matrícula
        public void Search()
        {
            Console.WriteLine("Ingrese la matrícula a buscar:");
            int matricula = Convert.ToInt32(Console.ReadLine());
            if (StudentsDictionary.TryGetValue(matricula, out string nombre))
            {
                Console.WriteLine($"Matrícula: {matricula}, Nombre: {nombre}");
            }
            else
            {
                Console.WriteLine("Matrícula no encontrada.");
            }
        }

        // Cuenta el número de estudiantes
        public void Count()
        {
            Console.WriteLine($"Número total de estudiantes: {StudentsDictionary.Count}");
        }
    }
}
