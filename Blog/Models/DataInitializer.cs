using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Blog.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategori = new List<Kategori>()
            {
                new Kategori() { KategoriAd = "CSharp" },
                new Kategori() { KategoriAd = "ROS" },
                new Kategori() { KategoriAd = "Matlab" }
            };
            foreach (var item in kategori)
            {
                context.Kategoris.Add(item);
            }
            context.SaveChanges();

            var makale = new List<Makale>()
            {
                new Makale() {Baslik="C# Programlama Dilini Anlama", Aciklama="C#, Microsoft tarafından geliştirilen güçlü ve esnek bir programlama dilidir. Temel olarak nesne yönelimli programlamaya odaklanan C#, geniş bir geliştirici kitlesi tarafından kullanılmaktadır. Temiz sözdizimi, tip güvenliği, ve zengin kütüphane desteği, C#'ı öne çıkaran özelliklerindendir. Çeşitli platformlarda çalışabilme yeteneği ve Visual Studio gibi entegre geliştirme ortamlarıyla birleşerek, C# geliştiricilere etkili ve hızlı uygulama geliştirme imkanı sunar.", Resim="a1.png", YayinTarihi=Convert.ToDateTime("2020-09-11"), Goruntulenme=0, Onay=true,KategoriId=1, KullaniciAd="osmangultekin06"},
                new Makale() {Baslik="C# Akış Kontrol Mekanizmaları", Aciklama="C# programlama dilindeki akış kontrol mekanizmaları, kodun işleyişini yönlendirmek ve belirli durumlar altında farklı davranışlar sergilemek için kullanılan önemli yapıları içerir. Bu makalede, C# dilinde bulunan temel akış kontrol mekanizmalarına odaklanacağız ve bunların nasıl kullanıldığını anlatacağız.", Resim="a1.png", YayinTarihi=Convert.ToDateTime("2020-08-09"), Goruntulenme=0, Onay=true,KategoriId=1, KullaniciAd="recaizade66"},
                new Makale() {Baslik="ROS Nedir?", Aciklama="ROS (Robot Operating System), robotik uygulamalar için bir açık kaynaklı işletim sistemidir. Genellikle ROS olarak kısaltılan bu platform, robot geliştiricilerine, sensörlerden veri alımından, hareket kontrolüne kadar bir dizi robotik görevi kolayca gerçekleştirmelerini sağlayan bir çerçeve sunar. ROS, modüler yapısı sayesinde farklı robot sistemleri ve bileşenler arasında etkileşimi kolaylaştırır.", Resim="a2.jpg", YayinTarihi=Convert.ToDateTime("2020-05-11"), Goruntulenme=0, Onay=true,KategoriId=2, KullaniciAd="haci0606"}
            };

            foreach (var item in makale)
            {
                context.Makales.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}