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

            purchases.Save("./tmp.txt");

            Cart.Load("./tmp.txt");
        }
    }
}

// @TOADD: API service with higher and lower methods