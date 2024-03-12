using Shott.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Product: NotifyProperty
    {
        private int id;
        private string name;
        private int price;
        private double rating;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Name 
        { 
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }
        public double Rating
        {
            get { return rating; }
            set
            {
                rating = value;
                OnPropertyChanged("Rating");
            }
        }
    }
}
