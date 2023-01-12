namespace ProgrammingPrinciples.SOLID
{
    class Cart
    {
        private static string StringifierPrefix = "Your cart:\n";
        private static string ItemsSeparator = ";\n";
        private List<CartItem> _items = new List<CartItem>();

        private CartItem? Find(string name)
        {
            return this._items.Find((CartItem item) => String.Equals(item.Name, name));
        }

        public int Add(string name, int count = 1)
        {
            CartItem? existingItem = this.Find(name);
            if (existingItem == null) {
                CartItem item = new(name, count);
                _items.Add(item);
            } else {
                existingItem.Count += count;
            }
            
            return _items.Count;
        }

        public bool Remove(string name, int count = 1)
        {
            CartItem? existingItem = this.Find(name);
            if (existingItem == null) {
                throw new KeyNotFoundException();
            } else if (existingItem.Count < count) {
                throw new NotSupportedException("Actual number is less than the number requested to delete!");
            } else if (existingItem.Count == count) {
                this._items.Remove(existingItem);
            } else {
                existingItem.Count -= count;
            }
            return true;
        }

        public override string ToString()
        {
            string list = String.Join(ItemsSeparator, _items);
            return $"{Cart.StringifierPrefix}{list}";
        }

        
        public bool Save(string filename)
        {
            File.WriteAllText(filename, this.ToString());
            return true;
        }

        public static bool Load(string filename)
        {
            throw new NotImplementedException();
        }
    }
}
