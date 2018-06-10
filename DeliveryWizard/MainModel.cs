using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryWizard
{

    public class DeliveryRquestDto
    {
        /// <summary>
        /// Дата заполнения
        /// </summary>
        public DateTime Filled { get; set; }

        /// <summary>
        /// ФИО клиента
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Описание пути
        /// </summary>
        public List<WayPoint> WayPoints { get; set; }
       
        /// <summary>
        /// Время доставки
        /// </summary>
        public DateTime TimeDeliver { get; set; }

        /// <summary>
        /// Адрес клиента
        /// </summary>
        public string ClientAddress { get; set; }

        /// <summary>
        /// Общая стоимость
        /// </summary>
        public decimal TotalCost { get; set; }
    }

    public class WayPoint
    {
        /// <summary>
        /// Название места
        /// </summary>
        public string PlaceTitle { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Тип места
        /// </summary>
        public string ShopType { get; set; }

        /// <summary>
        /// Список продуктов к покупке в этом месте
        /// </summary>
        public List<Product> ProductsList { get; set; }

        /// <summary>
        /// Общая стоимость
        /// </summary>
        public decimal TotalCost { get; set; }

        public override string ToString()
        {
            return PlaceTitle;
        }

        public WayPoint Clone()
        {
            return new WayPoint { PlaceTitle = PlaceTitle, Address = Address, ShopType = ShopType, ProductsList = ProductsList, TotalCost = TotalCost };
        }
    }

    public class Product
    {
        /// <summary>
        /// Название продукта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public float Amount {
            get
            {
                return amount;
            }
            set
            {
                 amount = value;
            }
        }

        private float amount = 1;

        /// <summary>
        /// Дополнительные сведения о продукте
        /// </summary>
        public string Additions { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public float Cost { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1:0.00} {2} {3} руб.", Name, Amount, Additions, Cost);
        }

        public Product Clone()
        {
            return new Product { Name = Name, Amount = Amount, Additions = Additions, Cost = Cost };
        }
    }        
}
