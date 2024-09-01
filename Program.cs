using Desafio_Gupy.models;

Console.WriteLine("Questão 01:");
Fibonacci fibonacci = new Fibonacci(34);

Console.WriteLine(fibonacci.PertenceFibonacci());
fibonacci.VerificarNumero();

Console.WriteLine("Questão 02:");
VerificaCaracter verificaCaracter = new VerificaCaracter("Me contrata ai recrutador, rsrs",'a');
Console.WriteLine($"\n{verificaCaracter.ContarOcorrencias()}");
Console.WriteLine(verificaCaracter.VerificarExistencia());
verificaCaracter.ExibirResultado();
