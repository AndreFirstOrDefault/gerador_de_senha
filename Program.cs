List<string> listaMaiuscula = new List<string>(){"A","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","S","T","U","V","W","X","Y","Z"};

List<string> listaMinuscula = new List<string>(){"a","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","s","t","u","v","w","x","y","z"};

List<string> listaNumeros = new List<string>(){"0","1","2","3","4","5","6","7","8","9"};

List<string> listaCaracteresEspeciais = new List<string>(){"@","#","&","$"};
Console.WriteLine();
Console.WriteLine("Bem vindo ao simples gerador de senhas!\n");
Console.Write("Quantos caracteres deseja na sua senha? ");
int numero = int.Parse(Console.ReadLine());
string senha = string.Empty;

for (int i=0; i < numero;i++)
{
    Random rd = new Random();
    int bt = rd.Next(1,101);

    if(bt >= 1 && bt < 20 )
    {
        Random letraM = new Random();
        int indice1 = letraM.Next(0,24);
        senha += listaMaiuscula[indice1];
    }
    else if(bt >= 21 && bt <= 55 )
    {
        Random letraMin = new Random();
        int indice2 = letraMin.Next(0,24);
        senha += listaMinuscula[indice2];
    }
    else if(bt >= 56 && bt <= 80)
    {
         Random numeros = new Random();
        int indice3 = numeros.Next(0,10);
        senha += listaNumeros[indice3];
    }
    else if(bt >= 81 && bt <= 100)
    {
        Random caracteres = new Random();
        int indice4 = caracteres.Next(0,4);
        senha += listaCaracteresEspeciais[indice4];
    }

    
}

Console.WriteLine();
Console.WriteLine("Sua senha gerada é: " + senha);
Console.WriteLine();

