using System;
using System.Text;

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

            StringsBuilders();
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

            Console.WriteLine(indices.IndexOf("é")); // IndexOf ele conta a quantidade de casas até chegar na palavra.
            Console.WriteLine(indices.LastIndexOf("e")); // LastIndexOf ele conta a quantidade de casas até a última letra.
        }

        // Aula 07 Metodos Adicionais
        static void MetodosAdicionais()
        {
            var lower = "ESSE É UM TEXTO GRANDE";
            var upper = "esse é um texto pequeno";

            Console.WriteLine(lower.ToLower()); // Transformando o texto em tudo minusculo.
            Console.WriteLine(upper.ToUpper()); // Transformando o texto em tudo MAIUSCULO.
            Console.WriteLine(upper.Insert(5, "AQUI ")); // Adiciona um texto dentro de outro.
            Console.WriteLine(upper.Remove(5, 0)); // Remove uma parte do texto.
            Console.WriteLine(lower.Length);
        }

        static void ManipulandoStrings()
        {
            var strings = "Este texto é um teste";
            Console.WriteLine(strings.Replace("e", "T")); // StringComparison.OrdinalIgnoreCase usar isso para ignorar o Case Sensitive.

            var divisao = strings.Split(" ");
            Console.WriteLine(strings[..^0]); // Pega do final e limita conforme coloca a quantidade de caracteres.

            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);
            Console.WriteLine(divisao[4]);

            //var resultado = strings.Substring(5, 5);
            var resultado = strings.Substring(5, strings.LastIndexOf("o"));
            Console.WriteLine(resultado);

            Console.WriteLine(strings.Trim());
        }

        static void StringsBuilders() //StringBuilder junta os textos quando se usa Append
        {
            var texto = new StringBuilder();
            texto.Append("Esse texto é um teste");
            texto.Append("é um teste");
            texto.Append("um teste");
            texto.Append("Esse é um teste");

            texto.ToString();
            Console.WriteLine(texto);
        }
    }
}
