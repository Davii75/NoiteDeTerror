string[] monstrosmes =
{
"O Zumbi",
"O Assassino",
"O Psicopata",
"O Alienígena",
"O Carniceiro",
"O Matador",
"O Vampiro",
"O Maluco",
"O Vingador",
"O Monstro",
"O Bruxo",
"O Demônio",
};

string[] monstrodia =
{
"Endiabrado",
"Radioativo",
"Endemoniado",
"Vermelho",
"Possuído",
"Macabro",
"Sombrio",
"Sem Cabeça",
"Desconhecido",
"Inconsciente",
"Oculto",
"Esquecido",
"Lúgubre",
"Invocado",
"Caído",
"Costurado",
"Amaldiçoado",
"Anormal",
"Perturbado",
"Sanguinário",
"Tenebroso",
"Imortal",
"Ressuscitado",
"do Pântano",
"da Encruzilhada",
"do Porão",
"do Velho Poço",
"sem Perdão",
"do Cemitério",
"da Meia-Noite",
"da Lua Cheia"
};

string[] mesnascimento =
{
"Janeiro",
"Fevereiro",
"Março",
"Abril",
"Maio",
"Junho",
"Julho",
"Agosto",
"Setembro",
"Outubro",
"Novembro",
"Dezembro" };

int dia, mes;

Console.WriteLine("--- Noite de Terror ---");

Console.Write("Digite o dia do seu nascimento (de 1 até 31): ");
dia = Convert.ToInt32(Console.ReadLine());

if (dia < 1 || dia > 31)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Número inválido");
    Console.ResetColor();
    return;
}

Console.Write("Digite o mês do seu nascimento (de 1 a 12): ");
mes = Convert.ToInt32(Console.ReadLine());

if (mes > 12 || mes < 1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Número inválido");
    Console.ResetColor();
    return;
}

Console.Clear();

Console.WriteLine($"Dia = {dia} | Mês = {mesnascimento[mes - 1]}");
Console.WriteLine($"Fuja! Lá vem {monstrosmes[mes - 1]} {monstrodia[dia - 1]}!");



