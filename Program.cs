using SimulacroC_Sharp.Models;

// var conductor = Customer.customers[0];
// conductor.UpdateMembershipLevel();


while (true)
{
    try
    {
        Console.Clear();
        Console.Write(@"
#############################################################################################
                            MANAGEMENT FOR A COMPANY WITH EMPLOYEES
#############################################################################################
---------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------
0. SALIR DEL PROGRAMA.
1. Mostrar todos los clientes registrados.
2. Mostrar todos los conductores registrados.
3. Mostrar todos los usuarios que tienen más de 30 años de edad.
4. Mostrar los conductores por su experiencia de conducción.
5. Mostrar todos los clientes que prefieren pagar con tarjeta de crédito.
6. Mostrar todos los Conductores con Licencia de Categoría 'A2'.
7. Actualizar la categoría de la licencia.
8. Añadir años de experiencia a un conductor.
9. Actualizar la membresía del cliente.
----------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------

Seleccione el número de la opción que desea realizar: ");


        int op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 0:
                Console.Clear();
                Console.WriteLine("¡GRACIAS POR UTILIZAR NUESTRA PLATAFORMA DE TRANSPORTE!");
                return;
            case 1:
                ShowAllCustomers();
                Console.ReadKey();
                break;
            case 2:
                ShowAllDrivers();
                Console.ReadKey();
                break;
            case 3:
                ShowUsersOver30();
                Console.ReadKey();
                break;
            case 4:
                ShowDriversByExperience();
                Console.ReadKey();
                break;
            case 5:
                ShowCustomersWithCreditCard();
                Console.ReadKey();
                break;
            case 6:
                ShowDriversLicenseCategoryA2();
                Console.ReadKey();
                break;
            case 7:
                Driver.UpdateLicenseCategory();
                Console.ReadKey();
                break;
            case 8:
                Driver.AddExperience();
                Console.ReadKey();
                break;
            case 9:
                Customer.UpdateMembershipLevel();
                Console.ReadKey();
                break;
            default:
                Console.Write("\nPresione cualquier tecla para volver al menú: ");
                Console.ReadKey();
                break;
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("\nLa opción que eligió es inválida. Escoja de nuevo.");
        Console.ReadKey();
    }
}


// Método para mostrar todos los clientes registrados
static void ShowAllCustomers()
{
    Console.WriteLine("\nCLIENTES REGISTRADOS:");

    foreach (var item in Customer.customers)
    {
        Console.WriteLine(item);
    }
}

// Método para mostrar todos los conductores registrados
static void ShowAllDrivers()
{
    Console.WriteLine("\nCONDUCTORES REGISTRADOS:");

    foreach (var item in Driver.drivers)
    {
        Console.WriteLine(item);
    }
}

// Método para mostrar todos los usuarios que tienen más de 30 años de edad
static void ShowUsersOver30()
{
    Console.WriteLine("\nUSUARIOS CON MÁS DE 30 AÑOS:");

    Console.WriteLine();

    var drivers = Driver.drivers.Where(item => item.ShowAgeCalculated() > 30).ToList();

    foreach (var item in drivers)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine();

    var customers = Customer.customers.Where(item => item.ShowAgeCalculated() > 30).ToList();

    foreach (var item in customers)
    {
        Console.WriteLine(item);
    }
}

// Método para mostrar los conductores por su experiencia de conducción
static void ShowDriversByExperience()
{
    Console.WriteLine("\nCONDUCTORES POR EXPERIENCIA DE CONDUCCIÓN:");

    Console.WriteLine();

    var drivers = Driver.drivers.OrderByDescending(item => item.DrivingExperience).ToList();

    foreach (var item in drivers)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine();
}

// Método para mostrar todos los clientes que prefieren pagar con tarjeta de crédito
static void ShowCustomersWithCreditCard()
{
    Console.WriteLine("\nCLIENTES CON PAGO CON TARJETA DE CRÉDITO:");

    Console.WriteLine();

    var customers = Customer.customers.Where(item => item.PreferredPaymentMethod == "tarjeta de crédito").ToList();

    foreach (var item in customers)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine();
}

// Método para mostrar todos los conductores con Licencia de Categoría 'A2'
static void ShowDriversLicenseCategoryA2()
{
    Console.WriteLine("\nCONDUCTORES CON LICENCIA DE CATEGORÍA 'A2':");

    Console.WriteLine();

    var drivers = Driver.drivers.Where(item => item.LicenseCategory == "A2").ToList();

    foreach (var item in drivers)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine();
}