using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread
{
    class Program
    {

        static void Main(string[] args)
        {
            Task.Run(
                async () => 
                {
                    List<Task<string>> TareasARealizarEnFormaParalela = new List<Task<string>>();
                    for (int i = 0; i < 10; i++)
                    {
                        TareasARealizarEnFormaParalela.Add(ReadFileAsync());
                    }

                    var x = Task.WhenAll(TareasARealizarEnFormaParalela);

                    Task<string> resultado = ReadFileAsync(); 
                    for (int i = 0; i < 1000; i++) Console.Write("x");
                    //////
                    var result = await x;
                    foreach (var valor in result)
                    {
                        Console.WriteLine(valor);   
                    }

                    Console.WriteLine(await resultado);
                }
            );

            Console.Read();
        }

        static async Task<string> ReadFileAsync()
        {
            await Task.Delay(5000);
            return "Ejecucion ReadFile Terminada";
        }

        /*static void Main(string[] args)
        {
            Thread t = new Thread(WriteY);
            t.Start();

            t.Join();
            for (int i = 0; i < 1000; i++) Console.Write("x");
        }

        static void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }*/
    }
}
