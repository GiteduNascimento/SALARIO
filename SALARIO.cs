// See https://aka.ms/new-console-template for more information
double salario;
double aumento;
double soma;

Console.WriteLine("Me informe seu salario atual:");
salario = double.Parse(Console.ReadLine());

if(salario < 1700){
    aumento = (10 * salario) / 100;
    soma = salario + aumento;
    Console.WriteLine("Como você recebe {0}, seu salario agora é {1}:", salario, soma);
}if(salario > 1700){
    aumento = (5 * salario) / 100;
    soma = salario + aumento;
    Console.WriteLine("Como você recebe {0}, seu salario agora é {1}:", salario, soma);
}
