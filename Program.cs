using System;
using System.Collections.Generic;
using System.Linq;

namespace ASSIGNMENT2
{
    public class ProductsList
    {
        string Name;
        double Price;
        int Quantity;
        string Type;

        public string proName
        {
            get { return Name; }
            set { Name = value; }
        }
        public double proPrice
        {
            get { return Price; }
            set { Price = value; }
        }
        public int proQuantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }

        public string proType
        {
            get { return Type; }
            set { Type = value; }
        }

        public override string ToString()
        {
            return ($"{proName}, {proPrice} RS, {proQuantity}, {proType}");
        }


        static void Main(string[] args)
        {
            List<ProductsList> newProductList = new List<ProductsList>(){
                new ProductsList(){
                    proName = "lettuce",
                    proPrice = 10.5,
                    proQuantity = 50,
                    proType = "Leafy green"
                },
                new ProductsList(){
                    proName = "cabbage",
                    proPrice = 20,
                    proQuantity = 100,
                    proType = "Cruciferous"
                },
                new ProductsList(){
                    proName = "pumpkin",
                    proPrice = 30,
                    proQuantity = 30,
                    proType = "Marrow"
                },
                new ProductsList(){
                    proName = "cauliflower",
                    proPrice = 10,
                    proQuantity = 25,
                    proType = "Cruciferous"
                },
                new ProductsList(){
                    proName = "zucchini",
                    proPrice = 20.5,
                    proQuantity = 50,
                    proType = "Marrow"
                },
                new ProductsList(){
                    proName = "yam",
                    proPrice = 30,
                    proQuantity = 50,
                    proType = "Root"
                },
                new ProductsList(){
                    proName = "spinach",
                    proPrice = 10,
                    proQuantity = 100,
                    proType = "Leafy green"
                },
                new ProductsList(){
                    proName = "broccoli",
                    proPrice = 20.2,
                    proQuantity = 75,
                    proType = "Cruciferous"
                },
                new ProductsList(){
                    proName = "garlic",
                    proPrice = 30,
                    proQuantity = 20,
                    proType = "Leafy green"
                },
                new ProductsList(){
                    proName = "silverbeet",
                    proPrice = 10,
                    proQuantity = 50,
                    proType = "Marrow"
                }
            };

            //Printing the total number of products in the list---------------
            int total = newProductList.Count;
            Console.WriteLine($"Total number of products in the list : {total}\n");


            //Adding a new product (Potato,10RS, 50, Root)-----------------
            newProductList.Add(new ProductsList()
            {
                proName = "Potato",
                proPrice = 10,
                proQuantity = 50,
                proType = "Root"
            });
            //printing the list of all products---------------------
            Console.WriteLine("After adding new product (Potato,10RS, 50, Root), Now new Products are : ");
            foreach (var product in newProductList)
            {
                Console.WriteLine(product);
            }
            //Printing total number of products---------------
            total = newProductList.Count;
            Console.WriteLine($"\nTotal number of Product in new Product List: {total}\n");


            //Printing all the products of which have the type Leafy green-----------------
            Console.WriteLine("Products of which have the type Leafy green are : ");
            foreach (var product in newProductList)
            {
                if (product.proType.Equals("Leafy green"))
                {
                    Console.WriteLine(product);
                }
            }

            //As all the garlic is sold out, Removing Garlic from the list and print the total number of products that are left on the list------------
            newProductList.RemoveAt(9);
            total = newProductList.Count;
            Console.WriteLine($"\nAs all the garlic is sold out, after removing Garlic from the list, now total number of products that are left on the list : {total}");


            //If the user adds 50 cabbages to the inventory, printing the final quantity of cabbage in the inventory------------------
            foreach (var product in newProductList)
            {
                if (product.proName.Equals("cabbage"))
                {
                    product.proQuantity = product.proQuantity + 50;
                    Console.WriteLine($"\nIf the user adds 50 cabbages to the inventory, then the final quantity of cabbage in the inventory : {product}");
                }
            }

            double price = 0;
            foreach (var product in newProductList)
            {
                if (product.proName.Equals("lettuce"))
                {
                    price = price + (1 * product.proPrice);
                }
                if (product.proName.Equals("zucchini"))
                {
                    price = price + (2 * product.proPrice);
                }
                if (product.proName.Equals("broccoli"))
                {
                    price = price + (1 * product.proPrice);
                }
            }
            Console.WriteLine($"\nIf a user purchases 1kg lettuce, 2 kg zucchini, 1 kg broccoli then the user needs to pay : {Math.Round(price)} RS");
        }
    }
}
