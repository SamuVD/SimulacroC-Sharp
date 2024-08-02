using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroC_Sharp.Models;

public class Driver : User
{

    // Propiedades o atributos
    public string? LicenseNumber { get; set; }
    public string? LicenseCategory { get; set; }
    public int DrivingExperience { get; set; }
    public static List<Driver> drivers = new List<Driver>()
    {
        new Driver
        (
            _name: "carlos",
            _lastName: "villa",
            _typeDocument: "CC",
            _identificationNumber: "123456789",
            _birthDate: new DateOnly(1990, 1, 1),
            _email: "carlos@example.com",
            _phoneNumber: "1234567890",
            _adreess: "calle 123",
            _licenseNumber: "ABC123",
            _licenseCategory: "A",
            _drivingExperience: 5
        ),
        new Driver
        (
            _name: "juan",
            _lastName: "perez",
            _typeDocument: "TI",
            _identificationNumber: "987654321",
            _birthDate: new DateOnly(1985, 5, 20),
            _email: "juan@example.com",
            _phoneNumber: "9876543210",
            _adreess: "calle 456",
            _licenseNumber: "DEF456",
            _licenseCategory: "B",
            _drivingExperience: 3
        ),
        new Driver
        (
            _name: "pedro",
            _lastName: "lopez",
            _typeDocument: "CE",
            _identificationNumber: "741258369",
            _birthDate: new DateOnly(1992, 8, 15),
            _email: "pedro@example.com",
            _phoneNumber: "7412583690",
            _adreess: "calle 789",
            _licenseNumber: "GHI789",
            _licenseCategory: "C",
            _drivingExperience: 2
        ),
        new Driver
        (
            _name: "maria",
            _lastName: "garcia",
            _typeDocument: "PA",
            _identificationNumber: "654321987",
            _birthDate: new DateOnly(1980, 12, 31),
            _email: "maria@example.com",
            _phoneNumber: "6543219870",
            _adreess: "calle 101",
            _licenseNumber: "JKL101",
            _licenseCategory: "D",
            _drivingExperience: 1
        ),
        new Driver
        (
            _name: "jose",
            _lastName: "martinez",
            _typeDocument: "RC",
            _identificationNumber: "521369874",
            _birthDate: new DateOnly(1988, 7, 25),
            _email: "jose@example.com",
            _phoneNumber: "5213698740",
            _adreess: "calle 159",
            _licenseNumber: "MNO159",
            _licenseCategory: "E",
            _drivingExperience: 4
        )
    };

    // ToString
    public override string ToString()
    {
        return $"Nombre: {Name} {LastName}, Licencia: {LicenseNumber}, Categoría: {LicenseCategory}, Experiencia: {DrivingExperience} años";
    }


    // Constructor propio de la clase
    public Driver
    (string _name, string _lastName, string _typeDocument, string _identificationNumber, DateOnly _birthDate, string _email, string _phoneNumber, string _adreess, string _licenseNumber, string _licenseCategory, int _drivingExperience)
        : base(_name, _lastName, _typeDocument, _identificationNumber, _birthDate, _email, _phoneNumber, _adreess)
    {
        LicenseNumber = _licenseNumber;
        LicenseCategory = _licenseCategory;
        DrivingExperience = _drivingExperience;
    }



    // Métodos requeridos para el programa propios de esta clase


    // Método para actualizar la categoría de la licencia
    public void UpdateLicenseCategory()
    {
        Console.Write("\nIngrese el nombre del conductor para el cual desea modificar la categoria => ");
        string driverNameCategory = Console.ReadLine().ToLower();

        var driverFoundCategory = drivers.FirstOrDefault(item => item.Name == driverNameCategory);

        if (driverFoundCategory != null)
        {
            Console.Write("\nIngrese la nueva categoria del conductor => ");
            driverFoundCategory.LicenseCategory = Console.ReadLine().ToUpper();

            Console.WriteLine("\n¡CATEGORÍA ACTUALIZADA CON ÉXITO!\n");
        }
        else
        {
            Console.Write("\nEl nombre del conductor no está agregado en la base de datos");
        }
    }

    // Método para agregar años de experiencia al conductor
    public void AddExperience(int years)
    {
        Console.Write("\nIngrese el nombre del conductor para el cual desea agregar años de experiencia => ");
        string driverNameExperience = Console.ReadLine().ToLower();

        var driverFoundExperience = drivers.FirstOrDefault(item => item.Name == driverNameExperience);

        if (driverFoundExperience!= null)
        {
            Console.Write("\nIngrese los nuevos años de experiencia del conductor => ");
            driverFoundExperience.DrivingExperience = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"\nAÑOS DE EXPERIENCIA AGREGADOS CON ÉXITO!\n");
        }
        else
        {
            Console.Write("\nEl nombre del conductor no está agregado en la base de datos");
        }
    }
}