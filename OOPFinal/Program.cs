// See https://aka.ms/new-console-template for more information
using NewtonBinomial;

Console.WriteLine("Hello, World!");

Binomial binomial = new Binomial();
Console.WriteLine(binomial.CalculateBinomialTaylor(5));
Console.WriteLine(binomial.CalculateBinomial(5));
Console.WriteLine(binomial.CalculateBinomialTaylor(-5));
Console.WriteLine(binomial.CalculateBinomial(-5));