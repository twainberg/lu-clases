using System;
using System.Collections.Generic;

namespace MVC.Models
{
    public class Alumno
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }
    }

    public class Data
    {
        public static List<Alumno> Lista = new List<Alumno>();
    }
}