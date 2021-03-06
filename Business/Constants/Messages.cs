﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Ürün limiti aşılmış";
        public static string ProductNameAlreadyExists = "Bu isimde başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı, yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
