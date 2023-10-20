using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DTOs;

namespace WinFormsApp1.DAO
{
    internal class DAO
    {
        private static DAO instance;

        public static DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO();
                return instance;
            }
        }

        public DAO()
        {
        }

        public DataTable See()
        {
            string query = "SELECT * FROM Product";
            return DataProvider.Instance.execSql(query);
        }

        public DataTable Search(string name)
        {
            string query = "select * from product where productName like @keyword and productCode > @number";

            Object[] prms = new object[] { "%" + name + "%", 0 };

            return DataProvider.Instance.execSql(query, prms);
        }

        public bool Add(ProductModel p)
        {
            string query = "INSERT INTO Product VALUES ( @Name, @Price )";
            Object[] prms = { p.ProductName, p.ProductPrice };
            return DataProvider.Instance.execNonSql(query, prms) > 0;
        }

        public bool Delete(int pCode)
        {
            string query = "DELETE Product WHERE ProductCode = @id";
            object[] prms = { pCode };
            return DataProvider.Instance.execNonSql(query, prms) > 0;
        }

        public bool Edit(ProductModel p)
        {
            string query = "UPDATE Product SET ProductName = @Name, ProductPrice = @Price WHERE ProductCode = @Code";
            object[] prms = { p.ProductName, p.ProductPrice, p.ProductId };
            return DataProvider.Instance.execNonSql(query, prms) > 0;
        }

    }
}
