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
    public List<Vehicle> vehicles = new List<Vehicle>()
    {
        new Vehicle
        (
            
        )
    };



    // Constructor propio de la clase
    public Vehicle()
    {

    }



    // Métodos requeridos para el programa propios de esta clase
    public void DeleteVehicle (int id)
    {
        
    }
}
