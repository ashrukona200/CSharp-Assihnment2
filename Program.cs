using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment
{
    public class Program
    {
        string ProductName;
        double ProductPrice;
        int ProductQuantity;
        string ProductType;

        public string proName
        {
            get { return ProductName; }
            set { ProductName = value; }
        }
        public double proPrice
        {
            get { return ProductPrice; }
            set { ProductPrice = value; }
        }
        public int proQuantity
        {
            get { return ProductQuantity; }
            set { ProductQuantity = value; }
        }

        public string proType
        {
            get { return ProductType; }
            set { ProductType = value; }
        }

        public override string ToString()
        {
            return ($"{proName}, {proPrice}, {proQuantity}, {proType}");
        }


        static void Main(string[] args)
        {
            List<Program> newProductList = new List<Program>()
            {
                new Program(){
                    proName = "lettuce", 
                    proPrice = 10.5, 
                    proQuantity = 50, 
                    proType = "Leafy green"
                },
                new Program(){
                    proName = "cabbage", 
                    proPrice = 20, 
                    proQuantity = 100, 
                    proType = "Cruciferous"
                },
                new Program(){ 
                    proName = "pumpkin", 
                    proPrice = 30, 
                    proQuantity = 30, 
                    proType = "Marrow"
                },
                new Program(){ 
                    proName = "cauliflower", 
                    proPrice = 10, 
                    proQuantity = 25, 
                    proType = "Cruciferous"
                },
                new Program(){ 
                    proName = "zucchini", 
                    proPrice = 20.5, 
                    proQuantity = 50, 
                    proType = "Marrow"
                },
                new Program(){ 
                    proName = "yam", 
                    proPrice = 30, 
                    proQuantity = 50, 
                    proType = "Root"
                },
                new Program(){ 
                    proName = "spinach", 
                    proPrice = 10, 
                    proQuantity = 100, 
                    proType = "Leafy green"
                },
                new Program(){ 
                    proName = "broccoli", 
                    proPrice = 20.2 , 
                    proQuantity = 75, 
                    proType = "Cruciferous"
                },
                new Program(){ 
                    proName = "garlic", 
                    proPrice = 30 , 
                    proQuantity = 20, 
                    proType = "Leafy green"
                },
                new Program(){
                    proName = "silverbeet", 
                    proPrice = 10, 
                    proQuantity = 50, 
                    proType = "Marrow"
                }
            };

            Console.WriteLine("Total number of products in the list : {0}\n", newProductList.Count);

            newProductList.Add(new Program(){ 
                proName = "Potato", 
                proPrice = 10, 
                proQuantity = 50, 
                proType = "Root" 
            });

            Console.WriteLine("After adding new product (Potato,10RS, 50, Root), Now new Products are : ");
            foreach (var product in newProductList)
                Console.WriteLine(product);
            Console.WriteLine("\nTotal number of Product in new Product List: {0}\n", newProductList.Count);

            Console.WriteLine("Products of which have the type Leafy green are : ");
            foreach (var product in newProductList)
            {
                if (product.proType.Equals("Leafy green"))
                    Console.WriteLine(product);
            }

            newProductList.RemoveAt(9);
            Console.WriteLine("\nAs all the garlic is sold out, after removing Garlic from the list, now total number of products that are left on the list : {0}", newProductList.Count);

            foreach (var product in newProductList)
            {
                if(product.proName.Equals("cabbage")){
                    product.proQuantity = product.proQuantity +50;
                    Console.WriteLine("\nIf the user adds 50 cabbages to the inventory, then the final quantity of cabbage in the inventory : " + product);
                }
            }

            double totalPrice = 0;
            foreach (var product in newProductList)
            {
                if (product.proName.Equals("lettuce"))
                {
                    totalPrice = totalPrice + (1 * product.proPrice);
                }
                if (product.proName.Equals("zucchini"))
                {
                    totalPrice = totalPrice + (2 * product.proPrice);
                }
                if (product.proName.Equals("broccoli"))
                {
                    totalPrice = totalPrice + (1 * product.proPrice);
                }
            }
            Console.WriteLine("\nIf a user purchases 1kg lettuce, 2 kg zucchini, 1 kg broccoli then the user needs to pay : {0} RS", Math.Round(totalPrice));
        }
    }
}