namespace Examen_U3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista _lista = new Lista();
           
            //Console.WriteLine("Ciuantas personas quiere ingresar");
            //int _NPerosona=Convert.ToInt32(Console.ReadLine());
            int X=0;
            Persona persona = new Persona ();

            while (5> X)
            {
                X++;
                Console.WriteLine($"ingrese el nombre de la persona {X}");
                persona.Nombre = Console.ReadLine();
               
                Console.WriteLine($"ingrese el Edad de la persona {X}");
                persona.Edad = Convert.ToInt32(Console.ReadLine());


                _lista.insertar(persona);
               
            }


            

            _lista.DesplegarLista();

        }
    }
}