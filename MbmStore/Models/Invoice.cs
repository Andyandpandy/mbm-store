using System;
using System.Collections.Generic;

namespace MbmStore.Models
{
    public class Invoice
    {
        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceId;
            OrderDate = orderDate;
            Customer = customer;
            OrderItems = new List<OrderItem>();
            totalPrice = 0;
        }

        private decimal totalPrice;

        public int InvoiceId;
        public DateTime OrderDate;
        public decimal TotalPrice
        {
            get { return totalPrice; }
        }
        public Customer Customer;
        
        public readonly List<OrderItem> OrderItems;

        public void AddOrderItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
            totalPrice = 0;
            OrderItems.ForEach(item => { totalPrice += item.TotalPrice; });                
        }
    }
}