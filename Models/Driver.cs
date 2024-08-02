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



    // Constructor propio de la clase
    public Driver()
    {

    }



    // Métodos requeridos para el programa propios de esta clase


    // Método para actualizar la categoría de la licencia
    public void UpdateLicenseCategory(string newCategory)
    {

    }

    // Método para agregar años de experiencia al conductor
    public void DrivingExperience(int years)
    {

    }
}