namespace ProgrammingPrinciples.SOLID
{
  class OCPDemo
  {
    public static void show()
    {
      Weapon sword = new Weapon.Sword("Iron Sword", 10, 3);
      Warrior conan = new("Conan", sword);
      conan.Attack();

      Weapon bow = new Weapon.Bow("Obsidian Bow", 15, 100);
      conan.ChangeWeapon(bow);
      conan.Attack();
    }
  }
}

// @TOADD: SortCLient: if < 10 BubbleSort; if < 1000 MergeSort; else QuickSort