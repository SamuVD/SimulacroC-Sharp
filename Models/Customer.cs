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
    public List<Customer> vehicles = new List<Customer>()
    {
        // new Customer
        // (
            
        // )
    };


    // Constructor de mi clase
    protected Customer(string _name, string _lastName, string _typeDocument, string _identificationNumber, DateOnly _birthDate, string _email, string _phoneNumber, string _adreess) : base(_name, _lastName, _typeDocument, _identificationNumber, _birthDate, _email, _phoneNumber, _adreess)
    {
    }



    // Métodos requeridos para el programa propios de esta clase


    // Método para actualizar la memebresía
    public void UpdateMembershipLevel()
    {
        
    }
}