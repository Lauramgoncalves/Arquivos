using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // -> INPUT OUTPUT (ENTRADA/SAIDA) 
using System.Runtime.Serialization.Formatters.Binary; // Serializa e desserializa um objeto ou um grafo inteiro de objetos conectados, em formato binário.


namespace ManipulaçãodeArquivos
{
    class Program
    {
        /*   {   existem 2 tipos de arquivos na computação TEXTOS (*txt, *html, *cs, *csv)
                e BINARIOS(mp4,png, jpg, pdf)*

               Stream -> Fluxo de Comunicação entre o csharp e aruivos 

               */
        //static void Main(string[] args)
        // { // escrita de arquivos
        /* StreamWriter escritor = new StreamWriter("teste.txt");
         escritor.WriteLine("Laura"); 
         escritor.WriteLine(24 + "Anos");
         escritor.Close();  // -> Para fechar o fluxo .Close() , se não fechar o arquivo fica vazio e o arquivo fica aberto no programa.
         Console.WriteLine("Arquivo gerado");
         Console.ReadLine(); */




        /* Append é especializada em adicionar informaçoes em Arquivo, sem remover as anteriores.
        StreamWriter escritor1 = File.AppendText("teste.txt");
        escritor1.WriteLine("Laura");
        escritor1.Close();*/


        // Ler arquivos pelo Csharp
        //  StreamReader leitor = new StreamReader("teste.txt");
        // string conteudo = leitor.ReadToEnd(); // -> ReadtoEnd Le todo o Arquivo até o final, e a string retorna o arquivo.
        //  Console.WriteLine(conteudo);
        //    Console.WriteLine(leitor.ReadLine()); // ReadLine ->Exibe linha por linha do arquivo
        //    Console.ReadLine();

        //}


        /* para gerar linha por linha

        string linha = "";
        while (linha != null)
        {
            linha = leitor.ReadLine();

            if(linha !=null) 
            {
                Console.WriteLine(linha);
            }

        }

        leitor.Close();
        Console.WriteLine("Arquivo gerado");
        Console.ReadLine();

        }

        }
*/




        //Escrita de arquivos binários


        [System.Serializable] //Serializable - converter qualquer tipo em bits para armazenar.
        struct Produto
        {
            public string nome1;
            public float preco;
        }

        static void Main(string[] args)

        {
            FileStream stream = new FileStream("meuarquivo", FileMode.OpenOrCreate);
            //não importa a extensão do aruivo, só o ue está dentro
            // Binario vem de Bit 
            // FileMode - é um (Parametro) -  os parâmetros controlam se um arquivo é substituído, criado, aberto ou alguma combinação dela.
            // OpenOrCreate - irá criar o arquivo caso ele não exista.
            BinaryFormatter encoder = new BinaryFormatter();


            // para escrever no arquivos
            encoder.Serialize(stream, 120);
            encoder.Serialize(stream, "Refrigerante");
            encoder.Serialize(stream, true);

            /* dá pra salvar variaveis.
            int a = 230;
            string nome = "Leandro";
            float b = 12.2f;*/

            // dá pra salvar listas
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


            // encoder.Serialize(stream, Linguagens); // -> salvar a lista dentro do arquivo.
            // encoder.Serialize(stream, maça); // salvando o produto 


            /* encoder.Serialize(stream, a);
             encoder.Serialize(stream, nome);
             encoder.Serialize(stream, b);*/




            //stream.Close();


            /*Arquivos binarios - possibilidade de salvar listas.*/



        }
    }
}






