using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var id = Guid.NewGuid(); // Gerando valor com NewGuid()
            id.ToString();

            id = new Guid("81a67299-da49-4f56-83f7-1d806c4a4d12"); // Recebendo o valor do Guid.NewGuid()

            id = new Guid(); // Aqui não recebe o valor pois não usamos o NewGuid()
            //Console.WriteLine(id.ToString().Substring(0, 8));

            //Price();
            Indices();
        }
        
        // Aula de Interpolação
        static void Price()
        {
            var price = 10.2;
            var texto = "Preço do produto é: " + price + " apenas na promoção!";
            var text = string.Format("O preço do produto é: {0} apenas na promoção!", price); // Pode ser usado para formatar datas, moedas entre outros.
            var tex = @$"O preço do produto é: {price}";

            Console.WriteLine(tex);
        }

        // Aula de Comparação de Texto
        static void ComparandoStrings()
        {
            var texto = "Verificando se existe a palavra";
            Console.WriteLine(texto.CompareTo("Testando")); // CompareTo compara se o texto é igual, 0 está certo 1 está diferente.
            Console.WriteLine(texto.Contains("Existe")); // True a palavra contem no texto e False a palavra não contem.
            Console.WriteLine(texto.Contains("ExIsTe", StringComparison.OrdinalIgnoreCase)); // StringComparison.OrdinalIgnoreCase Ignora o case sensitive.
        }

        // Aula 4 StartsWithEndWith
        static void StartsWithEndWith()
        {
            Console.Clear();
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("texto"));

            Console.WriteLine("----------------------");
            
            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("Teste"));
            Console.WriteLine(texto.EndsWith("xyz"));
        }

        // Aula 5 Equals | 
        static void Equals()
        {
            Console.Clear();

            var equals = "Este texto é um teste do equals";
            Console.WriteLine(equals.Equals("Este texto é um teste do equals"));
            Console.WriteLine(equals.Equals("este texto é um teste do equals"));
            Console.WriteLine(equals.Equals("este texto é um teste do equals", StringComparison.OrdinalIgnoreCase));
        }

        static void Indices()
        {
            Console.Clear();

            var indices = "Este texto é um teste";

            Console.WriteLine(indices);
        }
    }
}
