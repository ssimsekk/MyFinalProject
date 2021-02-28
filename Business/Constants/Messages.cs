using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi!";
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string MaintenanceTime = "Sistem bakımda!";
        public static string ProductsListed = "Ürünler listelendi!";
        public static string ProductCountOfCategoryError = "Kategorideki ürün sayısı limitini aştınız!";
        public static string ProductNameAlreadyExists = "Bu ürün isminde başka bir ürün mevcut!";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor!";
        public static string AuthorizationDenied = "Yetkiniz bulunmamaktadır!";
        public static string UserRegistered = "Kayıt olundu!";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Şifre hatalı!";
        public static string SuccessfulLogin = "Giriş başarılı!";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut!";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu!";
    }
}
