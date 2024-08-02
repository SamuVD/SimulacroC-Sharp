using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroC_Sharp.Models;

public class User
{

    // Propiedades o atributos
    protected Guid Id;
    protected string? Name { get; set; }
    protected string? LastName { get; set; }
    protected string? TypeDocument { get; set; }
    protected string? IdentificationNumber { get; set; }
    protected DateOnly BirthDate { get; set; }
    protected string? Email { get; set; }
    protected string? PhoneNumber { get; set; }
    protected string? Adreess { get; set; }



    // Constructor propio de la clase
    protected User(string _name, string _lastName, string _typeDocument, string _identificationNumber, DateOnly _birthDate, string _email, string _phoneNumber, string _adreess)
    {
        Id = Guid.NewGuid();
        Name = _name;
        LastName = _lastName;
        TypeDocument = _typeDocument;
        IdentificationNumber = _identificationNumber;
        BirthDate = _birthDate;
        Email = _email;
        PhoneNumber = _phoneNumber;
        Adreess = _adreess;
    }


 
    // Métodos requeridos para el programa propios de esta clase


    // Método ToString para mostrar los detalles
    public override string ToString()
    {
        return $"ID: {Id}, Nombre: {Name} {LastName}, Tipo de documento: {TypeDocument}, Número de identificación: {IdentificationNumber}, Fecha de nacimiento: {BirthDate}, Email: {Email}, Teléfono: {PhoneNumber}, Dirección: {Adreess}";
    }

    // Método para calcular la edad del usuario con DateOnly
    // protected int CalculateAge()
    // {

    // }

    // Método para mostrar la edad del usuario
    protected void ShowAge()
    {
        
    }
}