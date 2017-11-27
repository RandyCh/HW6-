using ClassLibrary2.NorthwindDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class ClsProduct
    {

        static ProductsTableAdapter adapter = new NorthwindDataSetTableAdapters.ProductsTableAdapter();
        static NorthwindDataSet northwindDataSet1 = new NorthwindDataSet();
        


        public ClsProduct()
        {
            adapter.Fill(northwindDataSet1.Products);
        }

        public  DataTable GetProducts()
        {
      
            return northwindDataSet1.Products;

        }

        public DataTable GetProductsByCategoryID(int i)
        {
            adapter.FillByproductbycategoryid(northwindDataSet1.Products, i);
            return northwindDataSet1.Products;
        }

        public DataTable SearchProductsByName()
        {
            adapter.FillByProductName(northwindDataSet1.Products, i);
            return northwindDataSet1.Products;
        }


        ////ToDo ClsProducts
        //   - GetProducts   ....  
        //   - GetCategoryList ...
        //   - GetProductsByCategoryID  ...
        //   - SearchProductsByName ....
        //   - SearchProductsByPrice ....
        //   -  CRUD  Products 
    }
}
