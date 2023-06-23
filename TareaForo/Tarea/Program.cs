// See https://aka.ms/new-console-template for more information
using System;
using Tarea;

//Console.WriteLine("Hello, World!");

//Cajero cuenta1 = new Cajero("Juan Pérez");
//cuenta1.Depositar(1000);
//cuenta1.Retirar(500);
//Console.WriteLine($"Titular: {cuenta1.Titular}, Saldo: {cuenta1.Saldo}");

//CuentaCorriente cuenta2 = new CuentaCorriente("María Gómez", 2000);
//cuenta2.Depositar(500);
//cuenta2.Retirar(3000);
//Console.WriteLine($"Titular: {cuenta2.Titular}, Saldo: {cuenta2.Saldo}, Línea de crédito: {cuenta2.LineaCredito}");

Console.WriteLine("Bienvenidos al Cajero");
Console.WriteLine("Ingrese el Nombre del Titular");
string titular = Console.ReadLine();

Console.Write("Ingrese el saldo inicial: ");
decimal saldoInicial = decimal.Parse(Console.ReadLine());

Console.WriteLine();

Cajero cuenta = new Cajero(titular);

Console.WriteLine($"Titular: {cuenta.Titular}, Saldo disponible es de: {cuenta.Saldo + saldoInicial}");
Console.WriteLine();
        

    

