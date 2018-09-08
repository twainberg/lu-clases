using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace bcl
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var file = File.OpenText("C:\\Users\\tomas\\Code\\Lagash\\bcl\\alumnos.txt"))
            {
                var alumnos = file.ReadToEnd();

                var alumno = new { 
                    lista = new List<string>(),
                    pais = "" };
                var jsonAl = JsonConvert.DeserializeAnonymousType(alumnos, alumno);
                jsonAl.lista.ForEach( (n) => Console.WriteLine(n.ToLowerInvariant()) );

                var listaAlumnos = alumnos.Split("\n");  
                
                var misAlumnos = new List<string>(listaAlumnos);
                
                Console.WriteLine(listaAlumnos.Length);
            }
            var numero =  "434";
            Convert.ToInt32(numero);

            var lista = new List<int>();
            lista.Add(3);
            lista.Add(6);
            lista.Add(9);
            lista.Add(12);
            lista.Sort();
            lista.ForEach( (n) => Console.WriteLine(n*3) );

            decimal d = 10.56565656565m;
            var dstr = d.ToString("#.###");
            var fecha = DateTime.Now.AddMonths(3);
            var fstr = fecha.ToString("yyyy-MM-dd");

            var p = new Persona { 
                Nombre = "Diego",
                Apellido = "Gonzalez" };
            var pstr = p.ToString();

            Console.WriteLine(pstr);
        }
    }

    class Persona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public override string ToString()
        {
            return "Nombre: " + Nombre + " Apellido: " + Apellido;
        }
    }
}
