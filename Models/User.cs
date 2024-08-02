using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroC_Sharp.Models;

public class User
{

    // Propiedades o atributos
    protected Guid Id;
    protected string? Name { get; set; };
    protected string? LastName { get; set; };
    protected string? TypeDocument { get; set; };
    protected string? IdentificationNumber { get; set; };
    protected DateOnly BirthDate { get; set; };
    protected string? Email { get; set; };
    protected string? PhoneNumber { get; set; };
    protected string? Adreess { get; set; };



    // Constructor propio de la clase
    protected User()
    {

    }


 
    // Métodos requeridos para el programa propios de esta clase


    // Método para mostrar los detalles de cada usuario
    protected void ShowDetails()
    {

    }

    // Método para calcular la edad del usuario
    protected int CalculateAge()
    {

    }

    // Método para mostrar la edad del usuario
    protected void ShowAge()
    {
        
    }
}