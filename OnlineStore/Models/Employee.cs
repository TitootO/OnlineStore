using Shott.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
     public class Employee: NotifyProperty
    {
        private int id;
        private string name;
        private string surname;
        private string phone;
        private int salary;
        private OrderPickupPoint point;
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
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value; 
                OnPropertyChanged("Surname");
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                OnPropertyChanged("Phone");
            }
        }
        public int Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                OnPropertyChanged("Salary");
            }
        }
        public OrderPickupPoint Point
        {
            get { return point; }
            set
            {
                point = value;
                OnPropertyChanged("Point");
            }
        }
    }
}
