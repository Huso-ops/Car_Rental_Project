using Core.Entity.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Car
        public static string CarAdded = "Ürün Eklendi";
        public static string CarInvalid = "Ürün İsmi Geçersiz";
        public static string CarListed = "Arabalar Listelendi";
        //Maintenance--Bakım
        public static string MaintenanceTime = "Sistem Bakımda";
        //User
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı sistemden silindi";
        public static string UserListed = "Kullanıcılar listelendi";
        public static string UserUptaded = "Kullanıcı Güncellendi";
        //Rental
        public static string RentalStarted = "Kiralama Başlatıldı";
        public static string RentalDeleted = "Kİralama İptal Edildi";
        public static string RentalUptaded = "Kiralama Güncellendi";
        public static string RentalListed = "Kİralama Geçmişi Listelendi";
        //Customer
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUptaded = "Müşteriler Listelendi";
        public static string CustomerListed = "Müşteri Listelendi";
        //SecuredOperation
        public static string  AuthorizationDenied = "Yetkiniz Yok";
        public static string UserRegistered ="Kayıt Başarılı";
        public static string  UserNotFound="Kullanıcı Bulunamadı";
        public static string  PasswordError="Şifre Hatalı";
        public static string SuccessfulLogin ="Kiriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı Zaten Mevcut";
        public static string AccessTokenCreated ="AccessTokenCreated";
    }
}
