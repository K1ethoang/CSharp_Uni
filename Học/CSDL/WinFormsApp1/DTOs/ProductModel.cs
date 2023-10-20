using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DTOs
{
    internal class ProductModel
    {
        private int productId;
        private string productName;
        private float productPrice;

        public int ProductId
        {
            get => productId;
            set => productId = value;
        }
        public string ProductName
        {
            get => productName;
            set => productName = value;
        }
        public float ProductPrice
        {
            get => productPrice;
            set => productPrice = value;
        }
    }
}
