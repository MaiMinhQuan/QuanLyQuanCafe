﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Menu
    {
        public Menu(string foodName, int count, float price, float totalPrice = 0) 
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.FoodName = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)row["price"];
            this.TotalPrice = (float)row["total_price"];
        }

        private string foodName;

        public string FoodName 
        { 
            get => foodName; 
            set => foodName = value; 
        }
        
        private int count;
        public int Count { get => count; set => count = value; }
        

        private float price;
        public float Price { get => price; set => price = value; }

        private float totalPrice;

        public float TotalPrice { get => totalPrice; set => totalPrice = value; }


    }
}
