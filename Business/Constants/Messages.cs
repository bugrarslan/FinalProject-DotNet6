using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductListed = "Ürün Listelendi";
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductNameAlreadyExists = "Bu isimde bir ürün var";
        public static string CategoryLimitExceed = "Kategori limiti aşıldı";
    }
}
