using SimulacroC_Sharp.Models;

var conductor = Driver.drivers[0];
Console.WriteLine(conductor);
conductor.UpdateLicenseCategory();
Console.WriteLine(conductor);


// while (true)
// {
//     try
//     {
//         Console.Clear();
//         Console.Write(@"
// #############################################################################################
//                                     PLATAFORMA DE TRANSPORTE
// #############################################################################################
// ---------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------
// 0. SALIR DEL PROGRAMA.
// 1. Mostrar los detalles.
// 2. Delete one employee.
// 3. Show all employees.
// 4. Update one employee data.
// 5. Search one employee.
// 6. Show all employees of the same position.
// ----------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------
// Seleccione el número de la opción que desea realizar: ");
//         int op = Convert.ToInt32(Console.ReadLine());
//         switch (op)
//         {
//             case 0:
//                 Console.Clear();
//                 Console.WriteLine("¡Thanks for use the system!. See you...");
//                 return;
//             case 1:
//                 Console.ReadKey();
//                 break;
//             case 2:
//                 Console.ReadKey();
//                 break;
//             case 3:
//                 Console.ReadKey();
//                 break;
//             case 4:
//                 Console.ReadKey();
//                 break;
//             case 5:
//                 Console.ReadKey();
//                 break;
//             case 6:
//                 Console.ReadKey();
//                 break;
//             default:
//                 Console.Write("\nPresione cualquier tecla para volver al menú: ");
//                 Console.ReadKey();
//                 break;
//         }
//     }
//     catch (System.Exception)
//     {
//         Console.WriteLine();
//         Console.WriteLine("La opción que eligió es inválida. Escoja de nuevo.");
//         Console.ReadKey();
//     }
// }