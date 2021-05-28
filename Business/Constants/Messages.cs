using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string Yes = "İslem Basarili";
        public static string No = "İslem Basarisiz";
        public static string AuthorizationDenied = "Yekilendirme Engellendi";
        public static string UserRegistered = "Kullanici Kaydedildi";
        public static string UserNotFound = "Kullanici Bulunamadi";
        public static string PasswordError = "Sifre Hatali";
        public static string SuccessfulLogin = "Sisteme Giris Basarili";
        public static string UserAlreadyExists = "Bu Kullanici Mevcut";
        public static string AccessTokenCreated = "Access Token Basari ile Olusturuldu";
    }
}
