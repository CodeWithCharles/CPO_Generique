namespace CPO_Generique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            double b = 5.84;
            float c = 1.25f;
            string str1 = "Hha";

            Affichage(ref a);
            Affichage(ref b);
            Affichage(ref c);
            Affichage(ref str1);

            Console.ReadKey();
        }

        static void Affichage<T>(ref T objet)
        {
            Console.WriteLine($"Affichage de l'objet : {objet}");
        }
    }
}
