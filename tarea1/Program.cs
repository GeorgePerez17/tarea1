using System;

namespace tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int curs;
            estudiantes pollo;
            pollo = new estudiantes();

            Console.WriteLine("INGRESE EL NOMBRE");
            pollo.Nombre = Console.ReadLine();

             Console.WriteLine("INGRESE LA EDAD");
             pollo.Edad = Int32.Parse(Console.ReadLine());

              Console.WriteLine("INGRESE LA NOTA");
              pollo.Nota = Int32.Parse(Console.ReadLine());

               Console.WriteLine("INGRESE EL CURSO");
               curs = Int32.Parse(Console.ReadLine());

            pregunta(curs);
            guardado(pollo.Nombre, pollo.Edad,pollo.Nota) ;
          
        }
        public static void pregunta (int curs){
                _3curso pollo;
                pollo = new _3curso();

            if (curs==3)
            {
               
                Console.WriteLine("INGRESE LA ALTURA");
                pollo.Altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("INGRESE LOS DIAS ASISTIDOS");
                pollo.Dias_asistidos = Int32.Parse(Console.ReadLine());
                
            }
            else
            {
                Console.WriteLine("GRACIAS");
            }
            guardado2(pollo.Altura,pollo.Dias_asistidos);


        }
        public static void guardado(string nombre,int edad,float nota)
        {
            Console.WriteLine(nombre);
            Console.WriteLine(edad);
            Console.WriteLine(nota);
        }
        public static void guardado2(double altura,int dias)
        {
            Console.WriteLine(altura);
            Console.WriteLine(dias);

        }

    }
}
