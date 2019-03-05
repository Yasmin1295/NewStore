using System;

namespace Library
{
    public class Store
    {
        public string Name;
        public int Size;
        public Seller Seller;
        public Products Products;

        public Store (string name, int size)
        {
            this.Name = name;
            this.Size = size;
        }
    }
}
