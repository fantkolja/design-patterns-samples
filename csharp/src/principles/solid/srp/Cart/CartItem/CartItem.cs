using Pluralize.NET;

namespace ProgrammingPrinciples.SOLID
{
    class CartItem {
        private Pluralizer _pluralizer = new();
        public int Count { get; set; }
        public string Name { get; set; }

        public CartItem(string name, int count = 1) 
        {
            this.Name = name;
            this.Count = count;
        }

        public override string ToString()
        {
            string name = this.Name;
            if (this.Count > 1) {
                name = this._pluralizer.Pluralize(name);
            }
            return $"{this.Count} {name}";
        }
    }
}