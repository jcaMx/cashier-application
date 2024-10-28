using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    public abstract class Item
    {
        // Protected fields
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        protected double total_price;

        // Constructor
        public Item(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
        }

        // Abstract method for calculating the total price
        public abstract double getTotalPrice();

        // Method to set the payment amount
        public void setPayment(double amount)
        {
            this.total_price = amount;
        }
    }

    public class DiscountedItem : Item
    {
        // Private fields
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        // Constructor
        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            this.item_discount = discount;
        }

        // Override method to calculate total price with discount
        public override double getTotalPrice()
        {
            discounted_price = item_price * item_quantity * (1 - item_discount);
            return discounted_price;
        }

        // Override method to set the payment amount and calculate change
        public void setPayment(double amount)
        {
            payment_amount = amount;
            change = payment_amount - getTotalPrice();
        }

        // Method to get the change
        public double getChange()
        {
            return change;
        }
    }
}