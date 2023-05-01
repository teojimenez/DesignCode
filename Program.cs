using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using System.Security.Permissions;

namespace Design_Code
    {
    internal class Program
    {
        public abstract class User
        {
            public string name;
            public string username;
            private string password;
            protected string email;
            public int phoneNumber;
            public string dni;
            public string address;
            public string country;
        }

        public class Admin : User
        {
            public void BanUser(User user) { }
            public void AddProduct(Product product) { }
        }

        public class Customer : User
        {
            public WishList WishListCart;
            public ShoppingCart shoppingCart;
            public void RatingProduct(Product product) { }
        }

        public class Product
        {
            public int identifier;
            public string name;
            private bool visible;
            public string description;
            public string brand;
            public List<string> images;
            public string basePrice;
            public Category clasification;

            public float AverageRating()
            {
                return 0;
            }

            public List<Rating> SortRatings()
            {
                return new List<Rating>();
            }
        }

        public class Category
        {
            public string category;
            public string subcategory;
        }

        public class Subcategory_complex : Category
        {
            public string category_complex;
        }

        public class Rating
        {
            public Customer author;
            public DateTime published;
            public int rating;
            public string summary;
        }

        public class WishList
        {
            public List<Product> products;
            public Dictionary<Product, int> quantity;
        }

        public class ShoppingCart
        {
            public List<Product> products;
            public bool readyOrder;
            public OrderingSystem orderDetails;

        }

        public class OrderingSystem
        {
            public int orderNumber;
            public DateTime orderDate;
            public List<Product> products;
            public float finalPrice;
        }

    }
}
