// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var checkCPFCNPJ = new CPFCNPJ.Main();

var result = checkCPFCNPJ.IsValidCPFCNPJ("90099299033");

Console.WriteLine("Result:" + result);