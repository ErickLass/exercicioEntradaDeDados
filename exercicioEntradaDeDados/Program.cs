internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entre com seu nome completo:");
        string nome = Console.ReadLine();
        Console.WriteLine("Quantos quartos tem na sua casa?");
        int quartos = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o preço de um produto");
        double preço = double.Parse(Console.ReadLine());
        Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha)");
        string[] vet = Console.ReadLine().Split(' ');
        string lastName = vet[0];
        int idade = int.Parse(vet[1]);
        double altura = double.Parse(vet[2]);

        Console.WriteLine("Seus dados são: ");
        Console.WriteLine(nome);
        Console.WriteLine(quartos);
        Console.WriteLine(preço);
        Console.WriteLine(lastName);
        Console.WriteLine(idade);
        Console.WriteLine(altura);
    }
}