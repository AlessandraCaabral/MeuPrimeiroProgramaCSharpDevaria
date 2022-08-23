# MeuPrimeiroProgramaCSharp
//Mostre na tela uma lista de jogadores autorizados nas quartas de final e mostre os nomes de quem não está autorizado.

string nomeJogador;

Console.WriteLine("Beeem vindos ao grande torneio!!!!!");

Console.WriteLine("Qual é o nome do seu grande jogador, please?");

nomeJogador = Console.ReadLine().ToString();

switch(nomeJogador)
{

    case "Adriano":
    case "Lucas":
    case "Henrique":
    case "Fabio":
    case "Marcio":
    case "Manuel":
    case "Maxon":
        Console.WriteLine("Jogador super autorizado!!!");
     break;
default:
     Console.WriteLine("Infelizmente não autorizado....");
break;
}

//Utilize o mesmo racional e faça um exemplo seu: 

string candidato;

Console.WriteLine("Caros convidados, bem vindos nosso baile anual de moda!!");

Console.WriteLine("Qual o nome da sua modelo");

candidato = Console.ReadLine().ToString();

switch (candidato)
{

    case "Queila":
    case "Amanda":
    case "Natalia":
    case "Claudia":
    case "America":
        Console.WriteLine("Sua modelo está na listaaaa, logo você vai conferir o vestido dela na passarela");
        break;
    default:
        Console.WriteLine("Infelizmente a sua modelo não está na lista de hoje, entre em contato com o nosso sac");
        break;
}
