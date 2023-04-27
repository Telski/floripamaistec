
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        FileInfo arquivo = null;
        try
        {
            Console.Write("Digite o nome do arquivo para criá-lo: ");
            string nomeArquivo = Console.ReadLine(); 
            
            arquivo = new FileInfo(nomeArquivo);
            
            using (StreamWriter gravadorTexto = File.AppendText(nomeArquivo))
            {
                Console.WriteLine("O que deseja escrever no arquivo?");
                gravadorTexto.WriteLine(Console.ReadLine());
            }
                        
        }
        catch (System.ArgumentException ex)
         {
             Console.WriteLine("Ocorreu o erro: {0}.\n\nDigite um nome para o arquivo",ex.Message);    
         }
        catch (Exception ex)
         {
             Console.WriteLine("Ocorreu o erro: {0}",ex.Message); 
        }
         finally 
         { 
              Console.WriteLine("Encerrando programa... \n"); arquivo = null;           
         }
        
    }
}

