using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Examen.ClsMenu;

namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            while (true)
            {
                menu.MostrarMenuPrincipal();
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        menu.AgregarEmpleado();
                        break;
                    case 2:
                        menu.ConsultarEmpleados();
                        break;
                    case 3:
                        menu.ModificarEmpleado();
                        break;
                    case 4:
                        menu.BorrarEmpleado();
                        break;
                    case 5:
                        menu.InicializarArreglos();
                        break;
                    case 6:
                        menu.GenerarReportes();
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }




        }
    }
}
