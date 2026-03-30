# 📚 Kütüphane Otomasyon Sistemi

Bu proje, C# ve SQL Server kullanılarak geliştirilmiş kapsamlı bir kütüphane yönetim otomasyonudur.

## 🚀 Özellikler
* **Üye Yönetimi:** Üye ekleme, silme ve güncelleme işlemleri.
* **Kitap Yönetimi:** Kitap  takibi ve kategori işlemleri.
* **Emanet Sistemi:** Ödünç verme ve iade alma süreçleri.
* **Veritabanı:** Entity Framework ile güvenli ve hızlı veri yönetimi.

## 🛠️ Kurulum ve Çalıştırma
1. Bu projeyi bilgisayarınıza indirin (Clone).
2. `db` klasörü içindeki `db.sql` dosyasını **SQL Server Management Studio (SSMS)** üzerinde çalıştırarak veritabanını oluşturun.
3. Projeyi Visual Studio ile açın.
4. `App.config` dosyasına gidin ve `connectionString` kısmındaki `Data Source` alanını kendi SQL Server adınızla (örneğin: `veritabaniismi`) güncelleyin.
5. Projeyi derleyin ve çalıştırın!

## 💻 Kullanılan Teknolojiler
* **Dil:** C#
* **Arayüz:** WinForms
* **ORM:** Entity Framework
* **Veritabanı:** MS SQL Server