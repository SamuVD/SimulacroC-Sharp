using SimulacroC_Sharp.Models;


Driver driver = new Driver()
driver.

try
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine(@"
||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
                                                                    
                                                        ANALIZADOR DE VENTAS DE NUESTRA TIENDA
                                                                     
||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

--------------------------------------------------------------------------------------------------------------------------------------------------------

0. SALIR DEL PROGRAMA.
1. Registrar nueva venta.
2. Calcular el valor de una venta.
3. Calcular el promedio de ventas diarias.
4. Mostrar el empleado del MES.
5. Mostrar el cliente del MES.
6. Filtrar ventas de una fecha específica.
7. Seleccionar vendedores que realizaron ventas por encima de cierto valor.
8. Mostrar ventas agrupadas por mes y calcular el total de ventas mensuales.
9. Encontrar el vendedor con más ventas.
10. Ordenar las ventas por valor total descendente y mostrar las primeras ventas.
11. Encontrar los productos más vendidos por cantidad en un año determinado.
12. Validar si existe alguna venta con un valor específico.
13. Buscar todas las ventas realizadas a un cliente específico.
14. Calcular el total de ventas para cada vendedor y mostrar el promedio de ventas por vendedor.
15. Encontrar el mes con el mayor número de ventas y mostrar las ventas de ese mes

--------------------------------------------------------------------------------------------------------------------------------------------------------
");
        Console.Write("Selecciona la opción que quieras realizar: ");

        if (!int.TryParse(Console.ReadLine(), out int op))
        {
            return;
        }

        switch (op)
        {
            case 0:
                Console.Clear();
                Console.WriteLine("Ha salido del programa. Lo esperamos próximamente.");
                return;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            case 9:
                break;
            case 10:
                break;
            case 11:
                break;
            case 12:
                break;
            case 13:
                break;
            case 14:
                break;
            case 15:
                break;
            default:
                Console.WriteLine("\nPresione cualquier tecla para volver al menú.");
                break;
        }


    }
}
catch (System.Exception)
{
    Console.WriteLine("Opción no válida. Intente de nuevo.");
    Console.ReadKey();
}