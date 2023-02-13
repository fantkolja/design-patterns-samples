namespace ProgrammingPrinciples.SOLID
{
    class SRPDemo
    {
        public static void show()
        {
            Cart purchases = new();
            purchases.Add("beer");
            purchases.Add("beer");
            purchases.Add("beer");
            purchases.Add("chips", 2);
            purchases.Add("nuts");


            purchases.Remove("nuts", 1);
            purchases.Remove("chips", 1);

            Console.WriteLine(purchases);

            purchases.Save("./tmp/tmp.txt");

            // Cart.Load("./tmp/tmp.txt");
        }
    }
}

// @TOADD: API service with higher and lower methods