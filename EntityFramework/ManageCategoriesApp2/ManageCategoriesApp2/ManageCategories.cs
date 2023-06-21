using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCategoriesApp2
{
    public sealed class ManageCategories
    {
        private static ManageCategories instance = null;
        private static readonly object instanceLock = new object();
         private ManageCategories() { }
        public static ManageCategories Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ManageCategories();
                    }
                    return instance;
                }
            }
        }

        public List<Category> GetCategories()
        {
            List<Category> categories;
            try
            {
                using MyStockDBContext stock = new MyStockDBContext();
                categories = stock.Catagories.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return categories;
        }

        public void InsertCategory(Category category)
        {
            try
            {
                using MyStockDBContext stock = new MyStockDBContext();
                stock.Catagories.Add(category);
                stock.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateCategory(Category category)
        {
            try
            {
                using MyStockDBContext stock = new MyStockDBContext();
                stock.Entry<Category>(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteCategory(Category category)
        {
            try
            {
                using MyStockDBContext stock = new MyStockDBContext();
                var cate = stock.Catagories.SingleOrDefault(c=> c.CategoryId == category.CategoryId);
                stock.Catagories.Remove(cate);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
