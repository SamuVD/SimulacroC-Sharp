using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroC_Sharp.Models;

public class Vehicle
{

    // Propiedades o atributos
    public int Id { get; set; }
    public string? LicensePlate { get; set; }
    public string? Type { get; set; }
    public string? EngineNumber { get; set; }
    public string? SerialNumber { get; set; }
    public byte PeopleCapacity { get; set; }
    public Driver? Owner { get; set; }
    public List<Vehicle> vehicles = new List<Vehicle>() { };



    // Constructor propio de la clase
    public Vehicle(int _id, string _licensePlate, string _type, string _engineNumber, string _serialNumber, byte _peopleCapacity, Driver _owner)
    {
        Id = _id;
        LicensePlate = _licensePlate;
        Type = _type;
        EngineNumber = _engineNumber;
        SerialNumber = _serialNumber;
        PeopleCapacity = _peopleCapacity;
        Owner = _owner;
    }



    // Métodos requeridos para el programa propios de esta clase
    public void DeleteVehicle()
    {
        Console.Write("\nIngresa el ID del vehículo que quieres eliminar => ");
        int vehicleFoundDelete = Convert.ToInt32(Console.ReadLine());

        var vehicleDelete = vehicles.Find(item => item.Id == vehicleFoundDelete);

        vehicles.Remove(vehicleDelete);

        Console.WriteLine("\n¡EMPLOYEE DELETED CORRECTLY!\n");
    }
}