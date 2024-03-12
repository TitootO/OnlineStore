using OnlineStore.Models;
using Shott.Model;
namespace OnlineStore.ViewModel
{
    public class MainViewModel : NotifyProperty
    {
        //public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>() { 
        //new Product() {Id = 1, Name = "123", Price = 5, Rating = 4.8}
        //};
        public Product Product {  get; set; }
        public Employee Employee { get; set; }
        //public ObservableCollection<OrderPickupPoint> OrderPickupPoints { get; set; } = new ObservableCollection<OrderPickupPoint>()
        //{
        //    new OrderPickupPoint(){Id = 1, Adress = "qwe12", Rating = 4.7}
        //};
        //public ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>()
        //{
        //    new Employee(){Id = 1, Name="qwe", Surname = "asd", Phone = "13", Point = new OrderPickupPoint(), Salary = 1457}
        //};
        private string search;
        private double ratingFrom;
        private double ratingTo;
        private int costFrom;
        private int costTo;
        public string Search
        {
            get { return search; }
            set
            {
                search = value;
                OnPropertyChanged();
            }
        }
        public double RatingFrom
        {
            get { return ratingFrom; }
            set
            {
                ratingFrom = value;
                OnPropertyChanged(nameof(RatingFrom));
            }
        }

        public double RatingTo
        {
            get { return ratingTo; }
            set
            {
                ratingTo = value;
                OnPropertyChanged(nameof(RatingTo));
            }
        }
        public int CostFrom
        {
            get { return costFrom; }
            set
            {
                costFrom = value;
                OnPropertyChanged(nameof(CostFrom));
            }
        }

        public int CostTo
        {
            get { return costTo; }
            set
            {
                costTo = value;
                OnPropertyChanged(nameof(CostTo));
            }
        }
    }
}
