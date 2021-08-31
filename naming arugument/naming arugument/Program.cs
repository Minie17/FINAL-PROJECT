using System;

namespace naming_arugument
{
    class Program
    {
    
            class NamedExample
        {
            static void Main(string[] args)
            {

                PrintOrderDetails(sellerName: "ss gift shope", orderNum: 45, productName :"photo pirnt pillow"); ;
                PrintOrderDetails(orderNum: 46, productName: "photo print mug", sellerName: "ss gift shope");
                PrintOrderDetails(productName: "red mug", sellerName: "ss gift shope", orderNum:47);
                PrintOrderDetails(sellerName: "ss gift shope", orderNum:31, productName: "red mug"); ;
                PrintOrderDetails(sellerName: "ss gift shope", orderNum:34, productName: "photo frame");    
                PrintOrderDetails(sellerName:"ss gift shope", orderNum: 36, productName :"photo print bookmark");                   
            }

            static void PrintOrderDetails(string sellerName, int orderNum, string productName)
            {
                if (string.IsNullOrWhiteSpace(sellerName))
                {
                    throw new ArgumentException(message: "Seller name cannot be null or empty.", paramName: nameof(sellerName));
                }

                Console.WriteLine($"Seller: {sellerName}, Order #: {orderNum}, Product: {productName}");
            }
        }
    }
    }
