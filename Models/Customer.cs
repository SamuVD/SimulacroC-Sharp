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
  public static List<Customer> customers = new List<Customer>()
    {
       new Customer
       (
         _name: "juan",
         _lastName: "perez",
         _typeDocument: "CC",
         _identificationNumber: "123456789",
         _birthDate: new DateOnly(1990, 1, 15),
         _email: "juan@example.com",
         _phoneNumber: "1234567890",
         _adreess: "calle 123",
         _membershipLevel: "GOLD",
         _preferredPaymentMethod: "tarjeta de crédito"
       ),
       new Customer
       (
         _name: "ana",
         _lastName: "lopez",
         _typeDocument: "TI",
         _identificationNumber: "987654321",
         _birthDate: new DateOnly(1980, 6, 10),
         _email: "ana@example.com",
         _phoneNumber: "9876543210",
         _adreess: "calle 456",
         _membershipLevel: "PLATINUM",
         _preferredPaymentMethod: "transferencia bancaria"
       ),
       new Customer
       (
         _name: "luis",
         _lastName: "martinez",
         _typeDocument: "CE",
         _identificationNumber: "789456123",
         _birthDate: new DateOnly(1975, 7, 5),
         _email: "luis@example.com",
         _phoneNumber: "7894561230",
         _adreess: "calle 789",
         _membershipLevel: "PREMIUM",
         _preferredPaymentMethod: "efectivo"
       ),
       new Customer
       (
         _name: "jose",
         _lastName: "garcia",
         _typeDocument: "TI",
         _identificationNumber: "321654987",
         _birthDate: new DateOnly(1985, 8, 20),
         _email: "jose@example.com",
         _phoneNumber: "3216549870",
         _adreess: "calle 456",
         _membershipLevel: "PLATINUM",
         _preferredPaymentMethod: "transferencia bancaria"
       ),
       new Customer
       (
         _name: "maria",
         _lastName: "lopez",
         _typeDocument: "CC",
         _identificationNumber: "654321987",
         _birthDate: new DateOnly(1995, 9, 15),
         _email: "maria@example.com",
         _phoneNumber: "6543219870",
         _adreess: "calle 789",
         _membershipLevel: "PREMIUM",
         _preferredPaymentMethod: "transferencia bancaria"
       )
    };


  // ToString
  public override string ToString()
  {
    return @$"
################################################################################ 

Nombre: {Name}
Apellido: {LastName}
Tipo de documento: {TypeDocument}
Número de identificación: {IdentificationNumber}
Fecha de nacimiento: {BirthDate}, Correo electrónico: {Email}
Edad: {ShowAgeCalculated()}
Teléfono: {PhoneNumber}
Dirección: {Adreess}
Nivel de membresía: {MembershipLevel}
Método de pago preferido: {PreferredPaymentMethod}";

  }


  // Constructor de mi clase
  protected Customer
  (string _name, string _lastName, string _typeDocument, string _identificationNumber, DateOnly _birthDate, string _email, string _phoneNumber, string _adreess, string _membershipLevel, string _preferredPaymentMethod)
      : base(_name, _lastName, _typeDocument, _identificationNumber, _birthDate, _email, _phoneNumber, _adreess)
  {
    MembershipLevel = _membershipLevel;
    PreferredPaymentMethod = _preferredPaymentMethod;
  }



  // Métodos requeridos para el programa propios de esta clase


  // Método para actualizar la memebresía
  public static void UpdateMembershipLevel()
  {
    Console.Write("\nIngrese el nombre del cliente para el cual desea modificar el nivel de membresía => ");
    string customerNameLevel = Console.ReadLine().ToLower();

    var customerFoundLevel = customers.FirstOrDefault(item => item.Name == customerNameLevel);

    if (customerFoundLevel != null)
    {
      Console.WriteLine(customerFoundLevel);
      Console.Write("\nIngrese el nuevo nivel de membresía del cliente => ");
      customerFoundLevel.MembershipLevel = Console.ReadLine().ToUpper();

      Console.WriteLine("\nNIVEL DE MEMBRESIA ACTUALIZADO CON ÉXITO!\n");
      Console.WriteLine(customerFoundLevel);
    }
    else
    {
      Console.Write("\nEl nombre del cliente no está agregado en la base de datos");
    }
  }
}