using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.Constants
{
    public class Messages
    {
        public static string BrandAdd = "Marka başarıyla eklendi.";
        public static string BrandDelete = "Marka başarıyla silindi.";
        public static string BrandUpdate = "Marka başarıyla güncellendi.";
        public static string FailedBrandAddOrUpdate = "Lütfen marka isminin uzunluğunu 2 karakterden fazla giriniz.";

        public static string CarAdd = "Araba başarıyla eklendi.";
        public static string CarDelete = "Araba başarıyla silindi.";
        public static string CarUpdate = "Araba başarıyla güncellendi.";
        public static string FailedCarAddOrUpdate = "Lütfen! Günlük fiyat kısmını 0'dan büyük bir değer giriniz.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Arabalar listelendi";

        public static string ColorAdd= "Renk başarıyla eklendi.";
        public static string ColorDelete = "Renk başarıyla silindi.";
        public static string ColorUpdate = "Renk başarıyla güncellendi.";

        public static string CustomerAdd = "Müşteri başarıyla eklendi.";
        public static string CustomerDelete = "Müşteri başarıyla silindi.";
        public static string CustomerUpdate = "Müşteri başarıyla güncellendi.";


        public static string UserAdd = "Kullanıcı başarıyla eklendi.";
        public static string UserDelete = "Kullanıcı başarıyla silindi.";
        public static string UserUpdate = "Kullanıcı başarıyla güncellendi.";


        public static string RentalAdd = "Araba Kiralama işlemi baraşıyla gerçekleşti.";
        public static string RentalDelete = "Araba Kiralama işlemi iptal edildi.Siliniyor";
        public static string RentalUpdate = "Araba Kiralama işlemi güncellendi.";
        public static string FailedRentalAddOrUpdate = "Araba teslim edilmediği için kiralayamazsınız.";
        public static string RentalReturn = "Kiralanan araç teslim edildi.";

        public static string CarImageLimit = "Varsayılan resim limitne ulaşıldı.";
    }
}
