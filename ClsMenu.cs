using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Examen.ClsEmpleado;

namespace Examen
{
    internal class ClsMenu
    {
        public class Menu
        {
            
            private List<Empleado> empleados = new List<Empleado>();

            public void MostrarMenuPrincipal()
            {
                Console.WriteLine("Menú Principal");
                Console.WriteLine("1. Agregar Empleados");
                Console.WriteLine("2. Consultar Empleados");
                Console.WriteLine("3. Modificar Empleados");
                Console.WriteLine("4. Borrar Empleados");
                Console.WriteLine("5. Inicializar Arreglos");
                Console.WriteLine("6. Reportes");
            }

            public void AgregarEmpleado()
            {
                Console.Write("Ingrese la cedula del empleado: ");
                string cedula = Console.ReadLine();
                Console.Write("Ingrese el nombre del empleado: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese la direccion del empleado: ");
                string direccion = Console.ReadLine();
                Console.Write("Ingrese el telefono del empleado: ");
                string telefono = Console.ReadLine();
                Console.Write("Ingrese el salario del empleado: ");
                double salario = Convert.ToDouble(Console.ReadLine());

                Empleado empleado = new Empleado(cedula, nombre, direccion, telefono, salario);
                empleados.Add(empleado);
                Console.WriteLine("Empleado agregado con éxito.");
            }

            public void ConsultarEmpleados()
            {
                Console.Write("Ingrese la cedula del empleado a consultar: ");
                string cedula = Console.ReadLine();

                var empleado = empleados.FirstOrDefault(e => e.Cedula == cedula);

                if (empleado != null)
                {
                    Console.WriteLine("Informacion del empleado:");
                    Console.WriteLine($"Cedula: {empleado.Cedula}");
                    Console.WriteLine($"Nombre: {empleado.Nombre}");
                    Console.WriteLine($"Direccion: {empleado.Direccion}");
                    Console.WriteLine($"Telefono: {empleado.Telefono}");
                    Console.WriteLine($"Salario: {empleado.Salario}");
                }
                else
                {
                    Console.WriteLine("Empleado no encontrado.");
                }
            }

            public void ModificarEmpleado()
            {
                Console.Write("Ingrese la cedula del empleado a modificar: ");
                string cedula = Console.ReadLine();

                var empleado = empleados.FirstOrDefault(e => e.Cedula == cedula);

                if (empleado != null)
                {
                    Console.WriteLine("Empleado encontrado. Proporcione los nuevos datos:");
                    Console.Write("Nuevo nombre: ");
                    empleado.Nombre = Console.ReadLine();
                    Console.Write("Nueva direccion: ");
                    empleado.Direccion = Console.ReadLine();
                    Console.Write("Nuevo teléfono: ");
                    empleado.Telefono = Console.ReadLine();
                    Console.Write("Nuevo salario: ");
                    empleado.Salario = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Empleado modificado con éxito.");
                }
                else
                {
                    Console.WriteLine("Empleado no encontrado.");
                }
            }

            public void BorrarEmpleado()
            {
                Console.Write("Ingrese la cédula del empleado a borrar: ");
                string cedula = Console.ReadLine();

                var empleado = empleados.FirstOrDefault(e => e.Cedula == cedula);

                if (empleado != null)
                {
                    empleados.Remove(empleado);
                    Console.WriteLine("Empleado eliminado con éxito.");
                }
                else
                {
                    Console.WriteLine("Empleado no encontrado.");
                }
            }

            public void InicializarArreglos()
            {
                empleados.Clear();
                Console.WriteLine("Arreglos de empleados inicializados.");
            }

            public void GenerarReportes()
            {
                Console.WriteLine("Menú de Reportes");
                Console.WriteLine("1. Consultar empleados con número de cédula");
                Console.WriteLine("2. Listar todos los empleados ordenados por nombre");
                Console.WriteLine("3. Calcular y mostrar el promedio de los salarios");
                Console.WriteLine("4. Calcular y mostrar el salario más alto y el más bajo");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el número de cédula a consultar: ");
                        string cedula = Console.ReadLine();
                        var empleado = empleados.FirstOrDefault(e => e.Cedula == cedula);

                        if (empleado != null)
                        {
                            Console.WriteLine("Información del empleado:");
                            Console.WriteLine($"Cédula: {empleado.Cedula}");
                            Console.WriteLine($"Nombre: {empleado.Nombre}");
                            Console.WriteLine($"Dirección: {empleado.Direccion}");
                            Console.WriteLine($"Teléfono: {empleado.Telefono}");
                            Console.WriteLine($"Salario: {empleado.Salario}");
                        }
                        else
                        {
                            Console.WriteLine("Empleado no encontrado.");
                        }
                        break;
                    case 2:
                        var empleadosOrdenados = empleados.OrderBy(e => e.Nombre).ToList();
                        Console.WriteLine("Lista de empleados ordenados por nombre:");
                        foreach (var e in empleadosOrdenados)
                        {
                            Console.WriteLine($"Cédula: {e.Cedula}, Nombre: {e.Nombre}");
                        }
                        break;
                    case 3:
                        double promedioSalarios = empleados.Average(e => e.Salario);
                        Console.WriteLine($"Promedio de salarios: {promedioSalarios:C}");
                        break;
                    case 4:
                        double salarioMasAlto = empleados.Max(e => e.Salario);
                        double salarioMasBajo = empleados.Min(e => e.Salario);
                        Console.WriteLine($"Salario más alto: {salarioMasAlto:C}");
                        Console.WriteLine($"Salario más bajo: {salarioMasBajo:C}");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }


    }
}
