using System;
using System.Collections.Generic;
using System.Text;

namespace MovieProject.Business.Contans
{
   public static class Messages
    {
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string UserAdd = "Kullanıcı başarıyla kaydedildi";

        public static string MovieAdd = "Film başarıyla eklendi";
        public static string MovieDelete = "Film başarıyla silindi";
        public static string MovieUpdate = "Film içeriği başarıyla güncellendi";
    }
}
