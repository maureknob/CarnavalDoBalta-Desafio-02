using CalculateImc;

var parseInput = new ParseInput();
ConsoleKey key;

do
{
    Console.Clear();
    Console.WriteLine("Digite a sua altura (Ex: 1.70) \n");
    var heigth = parseInput.ToFloat(Console.ReadLine());

    Console.WriteLine("Digite o seu peso (Ex: 64.5) \n");
    var weight = parseInput.ToFloat(Console.ReadLine());

    if(heigth == 0 || weight == 0)
    {
        Console.WriteLine("Valores incorretos. Tente novamente");
        Thread.Sleep(1000);

        key = ConsoleKey.Enter;
        continue;
    }

    CalculateImc(heigth, weight);

    Console.WriteLine("Pressione qualquer tecla para calcular um novo IMC.");
    Console.WriteLine("Pressione ESC para terminar o programa.");

    key = Console.ReadKey().Key;
} while (!key.Equals(ConsoleKey.Escape));


void CalculateImc(float height, float weight)
{
    var personData = new PersonData(height, weight);

    var calculate = new Calculate(personData);
    var calcResult = calculate.ClacResult();

    var classificationList = new ImcClassificationList();
    var imcData = classificationList.GetClassificationList();

    var response = imcData
        .Where(i => calcResult >= i.RangeStart && calcResult <= i.RangeEnd ).FirstOrDefault();

    Console.WriteLine();
    Console.WriteLine($"Seu IMC é {Math.Round(calcResult)}");
    Console.WriteLine(response.Classification);
    Console.WriteLine($"Risco {response.Risk}");
}