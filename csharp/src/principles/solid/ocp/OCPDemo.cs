namespace ProgrammingPrinciples.SOLID
{
  class OCPDemo
  {
    public static void show()
    {
      Weapon sword = new Weapon("Iron Sword", 10, 3);
      Warrior conan = new("Conan", sword);
      conan.Attack();
    }
  }
}

// @TOADD: SortCLient: if < 10 BubbleSort; if < 1000 MergeSort; else QuickSort