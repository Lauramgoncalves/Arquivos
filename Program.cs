using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace binarios
{
     class Program
    {
        [System.Serializable] 
        struct Produto
        {
            public string nome1;
            public float preco;
        }
        static void Main(string[] args)
        {

             // Para ler arquivos binários
            FileStream stream = new FileStream("meuarquivo", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();


            List<string> Linguagens = new List<string>();
            Linguagens.Add("Java");
            Linguagens.Add("C#");
            Linguagens.Add("C");
            Linguagens.Add("Phyton");
            Linguagens.Add("Javascript");
            Linguagens.Add("PHP");

            Produto maça = new Produto();
            maça.nome1 = "Maça";
            maça.preco = 4.5f;

            //encoder.Serialize(stream, Linguagens); // -> salvar a lista dentro do arquivo.
            // encoder.Serialize(stream, maça); // salvando o produto 

            List<string> listaDoArquivo = (List<string>)encoder.Deserialize(stream);
            Produto prod = (Produto)encoder.Deserialize(stream);
            // verificar a ordem dos itens dentro do arquivo.

            Console.WriteLine(listaDoArquivo[0]);
            Console.WriteLine(prod.nome1);

            stream.Close();
            Console.ReadLine();
        }
    }
}
