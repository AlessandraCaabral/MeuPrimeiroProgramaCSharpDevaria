const string textoolamundo = "Olá mundoooo, esse é meu primeiro programa em C#!!!! Feitoo por ....";
int idade;
string nomeCompleto;

Console.WriteLine("Qual o seu nome completo,please?");

nomeCompleto = Console.ReadLine().ToString();

Console.WriteLine("Qual a sua idade,please?");

idade = Convert.ToInt32(Console.ReadLine().ToString());

Console.WriteLine(textoolamundo + nomeCompleto + " que tem " + idade + " anos");



