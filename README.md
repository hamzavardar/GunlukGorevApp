# 📋 Günlük Görev & Alışkanlık Takip Sistemi (Full-Stack Web Application)

Bu proje, kişisel günlük alışkanlıkların ve görevlerin dijital olarak takip edilmesini sağlayan, **Frontend ve Backend mimarisi tamamen birbirinden bağımsız (Decoupled)** olarak tasarlanmış full-stack bir web uygulamasıdır. 

Proje, kurumsal şirketlerin kullandığı Sunucu-İstemci (Client-Server) mimarisini yerel ortamda simüle etmek ve modern web standartlarını (CORS, RESTful API, Asenkron CRUD) pratik etmek amacıyla geliştirilmiştir.

---

## 🏗️ Proje Mimarisi

Uygulama iki temel katmandan oluşmaktadır:
1. **Backend (Sunucu):** HTTP isteklerini karşılayan, iş mantığını yürüten ve veri tabanı ile konuşan .NET 9 Web API katmanı.
2. **Frontend (İstemci):** Kullanıcının görevleri gördüğü, eklediği ve sildiği; asenkron JavaScript (`Fetch API`) kullanarak backend ile haberleşen dinamik arayüz katmanı.

---

## 🚀 Kullanılan Teknolojiler & Veri Tabanı

* **Backend Framework:** .NET 9.0 (Web API)
* **ORM:** Entity Framework Core (EF Core) - Code-First Yaklaşımı
* **Veri Tabanı:** SQLite (Hafif, taşınabilir ve dosya tabanlı ilişkisel veri tabanı)
* **Frontend:** HTML5, CSS3, Modern JavaScript (Vanilla JS - Fetch API)
* **API Dokümantasyonu:** Swashbuckle (Swagger UI)

---

## 🛠️ Edinilen Teknik Yetkinlikler

Bu projeyi sıfırdan geliştirerek backend ve full-stack süreçlerine dair şu kritik yetkinlikleri kazandım:

* **Full-Stack Entegrasyonu ve CORS Yönetimi:** Tarayıcı tabanlı güvenlik protokollerini aşmak ve frontend/backend katmanlarını güvenli bir şekilde konuşturmak için **CORS (Cross-Origin Resource Sharing)** politikaları yapılandırıldı.
* **RESTful API ve Durum Yönetimi:** HTTP metotları (`GET`, `POST`, `PUT`, `DELETE`) standartlara uygun şekilde işlendi; istemciye doğru HTTP durum kodları (`200 OK`, `21 Created`, `404 NotFound`) dönüldü.
* **Asenkron Veri Akışı (Async/Await):** Performans kaybını önlemek adına hem .NET tarafındaki veri tabanı işlemlerinde hem de tarayıcı tarafındaki API çağrılarında asenkron programlama teknikleri uygulandı.
* **Veri Tabanı Yaşam Döngüsü:** EF Core **Migrations** mekanizması kullanılarak C# modelleri üzerinden SQLite şeması oluşturuldu ve verilerin kalıcı olarak depolanması sağlandı.

---

## 📖 API Rotaları (Endpoints)

| Metot | Rota | Açıklama |
| :--- | :--- | :--- |
| **GET** | `/api/Gorevler` | Veri tabanındaki tüm görevleri listeler. |
| **POST** | `/api/Gorevler` | Yeni bir günlük görev/alışkanlık ekler. |
| **PUT** | `/api/Gorevler/{id}` | Belirtilen görevin tamamlanma durumunu (Yapıldı/Yapılmadı) tersine çevirir. |
| **DELETE** | `/api/Gorevler/{id}` | Belirtilen görevi veri tabanından kalıcı olarak siler. |

---

## 💻 Projeyi Yerelde Çalıştırma ve Test Etme

Uygulamayı kendi bilgisayarınızda çalıştırmak için aşağıdaki adımları sırasıyla izleyebilirsiniz:

### 1. Backend'i (Sunucuyu) Başlatma
1. Projeyi bilgisayarınıza klonlayın:
   ```bash
   git clone [https://github.com/](https://github.com/)[hamzavardar]/GunlukGorevApp.git

   Proje ana dizinine girin:
   cd GunlukGorevApp

   Yerel web sunucusunu ayağa kaldırın:
   dotnet run

   Proje ana dizininde bulunan index.html dosyasını açın.