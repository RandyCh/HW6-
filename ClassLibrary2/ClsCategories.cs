using ClassLibrary2.NorthwindDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class ClsCategories
    {
        static NorthwindDataSet northwindDataSet1 = new NorthwindDataSet();
        static CategoriesTableAdapter adapter2 = new NorthwindDataSetTableAdapters.CategoriesTableAdapter();
        public ClsCategories()
        {
            adapter2.Fill(northwindDataSet1.Categories);
        }
        public DataTable GetCategoryList()
        {
            return northwindDataSet1.Categories;
        }
        public DataTable GetCategoryID()
        {

            adapter2.FillByCategoryID(northwindDataSet1.Categories);
            return northwindDataSet1.Categories;
        }
    }
}
