using System;
using System.Collections.Generic;
using System.Text;

namespace DesignandCode
{
    public class Product
    {
        public int id;
        private bool visibility;
        public string name;
        public string brand;
        public string description;
        public float price;
        public float discount;
        private List<string> labels;
        public HighCategory hc;
        public MidCategory mc;
        public LowCategory lc;
        public Image img;
        public List<Reviews> reviews;

        public float priceCalc(float price, float discount)
        {
            return price - discount;
        }
    }

    public abstract class Category
    {
        public string name;
        private bool active;
    }

    public class HighCategory : Category
    {

    }

    public class MidCategory : Category
    {

    }

    public class LowCategory : Category
    {

    }

    public class Image
    {
        private string imageName;
        private string imageUrl;
    }

    public class Reviews
    {
        public enum score { 1, 2, 3, 4, 5}
        public string comment;
        public Users user;
    }

    public class Whislist
    {
        public List<Product> products;
        public Users user;
    }
}
