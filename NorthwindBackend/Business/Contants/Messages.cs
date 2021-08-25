using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Contants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi.";
        public static string ProductDeleted = "Ürün başarıyla silindi.";
        public static string ProductUpdated = "Ürün başarıyla güncellendi.";

        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı.";
        public static string SuccessfulLogin = "Sisteme giriş başarılı.";
        public static string UserAlreadyExists = "Bu Kullanıcı zaten mevcut.";
        public static string UserRegistered = "Kullanıcı Başarıyla Kaydedildi.";
        public static string AccessTokenCreated = "Access Token Başarıyla Oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz Yok.";
    }
}
