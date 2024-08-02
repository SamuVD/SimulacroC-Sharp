using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroC_Sharp.Models;

public class Customer : User
{
    
    // Propiedades o atributos
    public string? MembershipLevel { get; set; }
    public string? PreferredPaymentMethod { get; set; }



    // Constructor de mi clase
    public Customer()
    {

    }



    // Métodos requeridos para el programa propios de esta clase
    

    // Método para actualizar la memebresía
    public void UpdateMembershipLevel()
    {
        
    }
}