# Otel Rezervasyon ve Yönetim Web API Projesi 
   
Projemiz, **ASP.NET Core** kullanılarak geliştirilmiş bir web API uygulamasıdır. bir otelin online rezervasyon sistemi üzerine kurgulanmış bir senaryo işleyişine sahip 🏨. Kullanıcılar, otel odalarını kolaylıkla rezerve edebilir ve yöneticiler otel yönetim işlemlerini gerçekleştirebilirler. Projede iki farklı panel bulunuyor: 
**Kullanıcı Paneli** ve **Admin Paneli**.      
      
                 
      
https://github.com/user-attachments/assets/8ccb584b-175a-4c75-adc3-ab44eafe2540
  
      
    
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

 ### Veritabanı 
 ![image](https://github.com/user-attachments/assets/37854279-2ada-4db7-b5b4-10eb081369eb)
![image](https://github.com/user-attachments/assets/315de644-213a-4c51-abb4-a9fd78ab26e7)

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

## Image File

https://localhost:7001/AdminImageFile/Index/
![screencapture-localhost-7001-AdminImageFile-Index-2024-09-23-01_24_24](https://github.com/user-attachments/assets/5941f319-c350-4679-b292-8d24f711cc0c)

## File
https://localhost:7001/AdminFile/Index/
![screencapture-localhost-7001-AdminImageFile-Index-2024-09-23-01_24_24](https://github.com/user-attachments/assets/c7d6ec74-9a94-402e-8d4a-c03f037c9a0e)

## Users
https://localhost:7001/AdminUsers/Index/
![screencapture-localhost-7001-AdminUsers-Index-2024-09-23-01_28_42](https://github.com/user-attachments/assets/9c47f9f3-8608-48e9-8af7-e7b8c7705fe9)

## Register Index
https://localhost:7001/Register/Index/
![screencapture-localhost-7001-Register-Index-2024-09-23-01_29_53](https://github.com/user-attachments/assets/a90aafb7-9a23-4c82-a2fc-48c734b7c766)

## Work Location
https://localhost:7001/AdminWorkLocation/Index/
![screencapture-localhost-7001-AdminWorkLocation-Index-2024-09-23-01_31_21](https://github.com/user-attachments/assets/87aef938-048f-41b5-b565-98125aad3738)

### Update WorkLocation 
https://localhost:7001/AdminWorkLocation/UpdateWorkLocation/1
![screencapture-localhost-7001-AdminWorkLocation-Index-2024-09-23-01_31_21 (1)](https://github.com/user-attachments/assets/d91fe526-9c46-4bf6-af24-b78340318719)

### Add Worklocation

https://localhost:7001/AdminWorkLocation/AddWorkLocation/
![screencapture-localhost-7001-AdminWorkLocation-AddWorkLocation-2024-09-23-01_32_57](https://github.com/user-attachments/assets/2bf27717-836c-4740-9e20-5a8530059d3d)

## Role 

https://localhost:7001/AdminRole
![screencapture-localhost-7001-AdminRole-2024-09-23-01_34_14](https://github.com/user-attachments/assets/3f9738da-34a2-4e30-b7e1-76233130a033)

### Add Role 
https://localhost:7001/AdminRole/AddRole/
![screencapture-localhost-7001-AdminRole-AddRole-2024-09-23-01_34_40](https://github.com/user-attachments/assets/7154aa79-b0c2-463b-b44b-9a2cd6990e88)

### Update Role

https://localhost:7001/AdminRole/UpdateRole/1
![screencapture-localhost-7001-AdminRole-UpdateRole-1-2024-09-23-01_35_17](https://github.com/user-attachments/assets/08c500ac-e962-4df4-9496-f0ee68d15373)

## Role Assign 
https://localhost:7001/RoleAssign/Index/
![screencapture-localhost-7001-RoleAssign-Index-2024-09-23-01_36_38](https://github.com/user-attachments/assets/c405fe85-10da-4c75-bfda-b294fb618f4a)

### Assign Role 
https://localhost:7001/RoleAssign/AssignRole/2
![screencapture-localhost-7001-RoleAssign-AssignRole-2-2024-09-23-01_37_21](https://github.com/user-attachments/assets/f330d6e2-9511-4319-b32b-13159036f9ab)


## Settings 
https://localhost:7001/Settings/Index/
![screencapture-localhost-7001-Settings-Index-2024-09-23-01_38_11](https://github.com/user-attachments/assets/390fb4f3-d03a-40f4-b053-f962f7130d9f)

# HotelProject.WebApi
![screencapture-localhost-5000-swagger-index-html-2024-09-23-01_50_24](https://github.com/user-attachments/assets/d1d06dc7-4c87-410b-a39c-16f2119c3134)

http://localhost:5000/swagger/index.html
![screencapture-localhost-5000-swagger-index-html-2024-09-23-01_39_05](https://github.com/user-attachments/assets/a3f80979-f38a-4337-bee1-29aad5afccfc)
 


