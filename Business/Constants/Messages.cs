using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarDeleted = "Araç Silindi";
        public static string CarUpdated = "Araç Güncellendi";
        public static string CarError = "Araç ismi ikiden büyük olmalı ve fiyatı 0 dan yüksek olmalıdır";
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string ImageLimited = "Bu araca ait 5 foto var";
        public static string CarImageUpdated = "Updated";
        public static string CarImageDeleted = "Deleted";

        public static string CarImageAdded = "Fotoğraf eklendi.";

        public static string AuthorizationDenied = "";
    }
}
