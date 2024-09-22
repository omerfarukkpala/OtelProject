# Otel Rezervasyon ve Yönetim Web API Projesi

Projemiz, **ASP.NET Core** kullanılarak geliştirilmiş bir web API uygulamasıdır. bir otelin online rezervasyon sistemi üzerine kurgulanmış bir senaryo işleyişine sahip 🏨. Kullanıcılar, otel odalarını kolaylıkla rezerve edebilir ve yöneticiler otel yönetim işlemlerini gerçekleştirebilirler. Projede iki farklı panel bulunuyor: 
**Kullanıcı Paneli** ve **Admin Paneli**.  

## Projenin Amacı

Projenin temel amacı, kullanıcıların web sitesi arayüzü üzerinden otel odaları hakkında bilgi alabilmelerini sağlamak ve rezervasyon yapmalarına imkan tanımaktır. Ayrıca, kullanıcılar admin paneline öneri, talep veya şikayet gibi konularda mesaj gönderebilirler. Admin paneli üzerinden yöneticiler, rezervasyonları düzenleyebilir, onaylayabilir ve otel yönetim süreçlerini yönetebilirler.

## Neler Yaptık 

1. **ASP.NET Core API Geliştirme**: Projemiz tamamen API ile geliştirildi 🚀. API’yi geliştirirken **çok katmanlı mimari** kullanarak modüler bir yapı kurduk. Veri tabanı işlemlerinde **MSSQL** kullanarak otel verileri, odalar ve istatistikler gibi bilgileri API'den çekip consume ederek listeledik 🧳.

2. **Repository Design Pattern**: Proje **Repository Design Pattern** ile tasarlandı 🍜. Bu sayede özellikle **CRUD** işlemlerinde tekrarların önüne geçtik ve kodun daha sürdürülebilir olmasını sağladık. Ayrıca **Dependency Injection** ve **SOLID** prensiplerine olabildiğince sadık kaldık ki projeyi inceleyen yazılımcılar da projeyi rahatlıkla anlayabilsin 🍩.

3. **DTO Sınıflarıyla Eşleme**: Veritabanı modellerimizi **DTO (Data Transfer Object)** sınıflarıyla eşleştirerek veri akışını düzenledik ve güvenli hale getirdik 🔄.

4. **API Test ve Consume İşlemleri**: Geliştirdiğimiz **API**'lerin test işlemlerini **Swagger** ve **Postman** kullanarak gerçekleştirdik ☕️. Sorunsuz çalışan API’lerimizi, güçlü bir **HTML** teması üzerine **Vitrin** ve **Admin** olarak ayırarak verileri consume ettik 🏇.

5. **Arayüz Geliştirme**: **Vitrin tarafında** otel bilgileri, odalar, istatistikler, iletişim paneli gibi alanları listeleyerek kullanıcı deneyimini zenginleştirdik 🌸. Ayrıca **Admin panelinde** yöneticilerin otel yönetimini kolayca yapabileceği bir arayüz sunduk.

6. **Güvenlik ve Rol Yönetimi**: Projemize güvenlik katmanı olarak **AspNet Core Identity** ekledik 🔑. Güvenlik yetmez dedik, **rol yönetimi** de dahil ederek kullanıcı yetkilendirmelerini düzenledik 💣. 

7. **Mail Gönderimi**: Rezervasyon işlemlerini tamamlayan kullanıcılara, rezervasyon detaylarını içeren mailleri **gerçek e-posta adreslerine** gönderdik 🎷.

8. **Harici API Tüketimi (Rapid API)**: Sadece kendi API’mizi kullanmakla kalmayıp **RapidAPI** entegrasyonuyla otel rezervasyonlarına yardımcı olacak harici veriler çektik 🪻. İlk olarak döviz kuru bilgilerini panelimize entegre ettik 💷. Ardından, sosyal medya hesaplarındaki takipçi sayıları gibi verileri de çekerek gösterdik ⏳.

9. **İstatistik ve Dashboard Yönetimi**: Admin panelindeki **Dashboard** ve **widgetlar** için bolca **Entity Framework** ve **LINQ** sorguları yazdık 🪻. Böylece yönetim için dinamik ve anlık istatistikler sunduk.

10. **Dosya İşlemleri**: Dosya yükleme ve indirme işlemlerini API üzerinden nasıl gerçekleştireceğimizi de projeye ekledik 📂.

Bu adımlarla, otel rezervasyon ve yönetim sistemini modern ve güvenli teknolojilerle donatılmış bir yapı üzerine inşa ettik 🌟.




## 🌟 Proje Özellikleri

### 🌸 Kullanıcı Paneli
- Otel odaları hakkında bilgi edinme
- Rezervasyon yapma
- Admin paneline mesaj gönderme (öneri, talep, şikayet)

### 🍜 Admin Paneli
- Oda ekleme, güncelleme ve silme
- Rezervasyonları yönetme ve onaylama
- Kullanıcı hesaplarını yönetme
- Anlık olarak kullanıcılara mail atma
- Gelen mesajları görüntüleme ve yanıtlama
- Sisteme kayıtlı misafirleri yönetme
- Profil bilgilerini yönetme
- Kullanıcı rol yönetimi

## 🧳 Teknolojiler ve Kütüphaneler

Bu projede kullanılan başlıca teknolojiler ve kütüphaneler şunlardır:

- **ASP.NET Core 6.0**: Web API geliştirme platformu
- **Entity Framework Core**: Veritabanı işlemleri için ORM aracı
- **.NET Core Identity**: Kimlik doğrulama ve yetkilendirme işlemleri
- **Repository Design Pattern**: Veri erişimini soyutlamak için kullanılan tasarım deseni
- **N-Tier Architecture**: Katmanlı mimari ile projenin modüler yapıda geliştirilmesi
- **JWT (Json Web Token)**: API üzerinde kimlik doğrulama için kullanılan token tabanlı sistem
- **Fluent Validation**: Model validasyon işlemleri için kullanılan kütüphane
- **AutoMapper**: Nesne modelleri arasında dönüşümleri kolaylaştıran kütüphane
- **Swagger**: API dokümantasyonu ve test için kullanılan araç
- **Postman**: API isteklerini test etmek için kullanılan araç
- **Rapid API**: Harici API hizmetleriyle entegrasyon

## ⏳ Proje Bileşenleri

- **Asp.Net Core API**: Otel rezervasyon ve yönetim işlemlerinin API tabanlı geliştirilmesi
- **MsSql**: Veritabanı yönetim sistemi
- **Identity**: Kullanıcı kimlik doğrulama ve yetkilendirme
- **Rapid API**: Harici API entegrasyonu
- **Postman**: API testleri
- **Swagger**: API dokümantasyonu ve test ortamı
- **Json Web Token (JWT)**: Kimlik doğrulama için kullanılan token tabanlı sistem
- **Fluent Validation**: Model doğrulama işlemleri

 ## 🖼️ Projeye Ait Görseller
 ### Anasayfa  
 https://localhost:7001/Default/Index/
 
![fullsayfa](https://github.com/user-attachments/assets/54873eb6-d196-482b-875c-f901f69f6479)

### Booking  
https://localhost:7001/Booking/Index/

![booking](https://github.com/user-attachments/assets/18338e55-6c94-489d-aabb-27b13ab9c75f)

### İletişim 
https://localhost:7001/Contact/Index/

![illetişim](https://github.com/user-attachments/assets/95a8e013-2d6b-4a01-999b-864fb9f2d9ba)

## Otel Giriş Paneli 
https://localhost:7001/Login/Index/

![otel giriş panel](https://github.com/user-attachments/assets/3293d074-c431-4ee7-91dc-065e7f3e65f9)

## Otel Kayıt Panel 
https://localhost:7001/Register/Index/

![otelkayit](https://github.com/user-attachments/assets/d0ca8202-509a-4bb4-b4c6-285e06d31134)

## Dashboard
https://localhost:7001/Dashboard

![dashboard](https://github.com/user-attachments/assets/5dd569f6-af57-4618-9cac-a0283feca042)

## Booking
https://localhost:7001/BookingAdmin/Index/

![Rezarvazyonlar](https://github.com/user-attachments/assets/3a73319d-2ed8-44c0-9498-0eb17e09d39b)

## Staff
https://localhost:7001/Staff

![httpslocalhost7001Staff](https://github.com/user-attachments/assets/2762f66a-5f73-403e-a8e6-4eb78073bb1e)

### Add Staff
https://localhost:7001/Staff/AddStaff/
![addstaff](https://github.com/user-attachments/assets/5c78199b-d7c0-490d-8187-d37c42d18808)


### Update Staff
https://localhost:7001/Staff/UpdateStaff/1
![updatestaff](https://github.com/user-attachments/assets/118793c2-5d45-4f35-af75-61d9a8f26ded)

## Service 
https://localhost:7001/Service/Index/

![httpslocalhost7001ServiceIndex](https://github.com/user-attachments/assets/b80d36ce-3263-4b7b-9417-a69289b71a2c)

### Add Service
![addservice](https://github.com/user-attachments/assets/25e3d3b2-ffc8-4a88-8add-ef0d7ffe68f5)

https://localhost:7001/Service/AddService/

 ### Update Service 
 https://localhost:7001/Service/UpdateService/1
![updateservice](https://github.com/user-attachments/assets/e69baabe-aad2-4468-8d89-e5ed8c428a0d)

## Testimonial 
https://localhost:7001/Testimonial/Index/
 ![screencapture-localhost-7001-Testimonial-Index-2024-09-23-01_01_45](https://github.com/user-attachments/assets/52a2b40c-d49d-4b45-913f-45db7eba729d)

### Update Testimonial 
https://localhost:7001/Testimonial/UpdateTestimonial/2
![updatteee](https://github.com/user-attachments/assets/51ada29d-fb8d-494c-9f88-a9f0dfdc662c)

## About
https://localhost:7001/AdminAbout/Index/
![aboutt](https://github.com/user-attachments/assets/31ff8c47-f1e7-436b-92fe-acbb8fd12d70)

#### Update About 
https://localhost:7001/AdminAbout/UpdateAbout/2
![updatee](https://github.com/user-attachments/assets/87b2caae-b8b8-4591-9966-ce55ff89c84f)

## Room
https://localhost:7001/AdminRoom
![rrrr](https://github.com/user-attachments/assets/0f01a72f-5ea7-428a-b1d8-be0fc42f3655)

###  Update Room
https://localhost:7001/AdminRoom/UpdateRoom/1
![rupdate](https://github.com/user-attachments/assets/4ba85b81-e97c-4970-aa48-73826cc070bd)

### Add Room
https://localhost:7001/AdminRoom/AddRoom/
![addd](https://github.com/user-attachments/assets/113beb1c-503f-40a0-a908-ca27aa36dc5c)

## Guests
https://localhost:7001/AdminGuest/Index/
![ggg](https://github.com/user-attachments/assets/791b8215-33a3-4a6b-8289-93b8338c2b96)

### Add Guest
https://localhost:7001/AdminGuest/AddGuest/
![adddd](https://github.com/user-attachments/assets/bb1020d1-64db-4261-919b-d9069631f197)

### Update Guest 
https://localhost:7001/AdminGuest/UpdateGuest/3
![screencapture-localhost-7001-AdminGuest-UpdateGuest-3-2024-09-23-01_18_50](https://github.com/user-attachments/assets/685e9b72-2387-4d93-9539-01d0b0a84954)

## Message 
https://localhost:7001/AdminContact/InBox/
![screencapture-localhost-7001-AdminContact-InBox-2024-09-23-01_21_00](https://github.com/user-attachments/assets/3556b9cb-6863-4485-ac47-2de168ea2611)

### Add Send Mesaage
https://localhost:7001/AdminContact/AddSendMessage/
![screencapture-localhost-7001-AdminContact-AddSendMessage-2024-09-23-01_21_51](https://github.com/user-attachments/assets/dea33ab2-030c-4f7b-93c8-26921e9cee9a)


## Mail
https://localhost:7001/AdminMail/Index/
![screencapture-localhost-7001-AdminMail-Index-2024-09-23-01_22_54](https://github.com/user-attachments/assets/c80cae3c-be16-4d4e-9fc7-f62b15b634fb)


























