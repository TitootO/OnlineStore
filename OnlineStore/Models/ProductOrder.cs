using Shott.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OnlineStore.Models
{
    public class ProductOrder: NotifyProperty
    {
        int id;
        Order order;
        Product product;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public Order Order
        {
            get { return order; }
            set
            {
                order = value;
                OnPropertyChanged(nameof(Order));
            }
        }

        public Product Product
        {
            get { return product; }
            set
            {
                product = value;
                OnPropertyChanged(nameof(Product));
            }
        }
    
}
}
