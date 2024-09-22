# Otel Rezervasyon ve Yönetim Web API Projesi

Bu proje, otel rezervasyon ve yönetim süreçlerini kolaylaştırmak amacıyla **ASP.NET Core** kullanılarak geliştirilmiş bir web API uygulamasıdır. Kullanıcılar, otel odalarını kolayca rezerve edebilir ve yöneticiler, otel yönetim işlemlerini efektif bir şekilde gerçekleştirebilirler. Proje, kullanıcılar için iki farklı panel sunar: **Kullanıcı Paneli** ve **Admin Paneli**.

## Projenin Amacı

Projenin temel amacı, kullanıcıların web sitesi arayüzü üzerinden otel odaları hakkında bilgi alabilmelerini sağlamak ve rezervasyon yapmalarına imkan tanımaktır. Ayrıca, kullanıcılar admin paneline öneri, talep veya şikayet gibi konularda mesaj gönderebilirler. Admin paneli üzerinden yöneticiler, rezervasyonları düzenleyebilir, onaylayabilir ve otel yönetim süreçlerini yönetebilirler.

## Proje Özellikleri

### Kullanıcı Paneli
- Otel odaları hakkında bilgi edinme
- Rezervasyon yapma
- Admin paneline mesaj gönderme (öneri, talep, şikayet)

### Admin Paneli
- Oda ekleme, güncelleme ve silme
- Rezervasyonları yönetme ve onaylama
- Kullanıcı hesaplarını yönetme
- Anlık olarak kullanıcılara mail atma
- Gelen mesajları görüntüleme ve yanıtlama
- Sisteme kayıtlı misafirleri yönetme
- Profil bilgilerini yönetme
- Kullanıcı rol yönetimi

## Teknolojiler ve Kütüphaneler

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

## Proje Bileşenleri

- **Asp.Net Core API**: Otel rezervasyon ve yönetim işlemlerinin API tabanlı geliştirilmesi
- **MsSql**: Veritabanı yönetim sistemi
- **Identity**: Kullanıcı kimlik doğrulama ve yetkilendirme
- **Rapid API**: Harici API entegrasyonu
- **Postman**: API testleri
- **Swagger**: API dokümantasyonu ve test ortamı
- **Json Web Token (JWT)**: Kimlik doğrulama için kullanılan token tabanlı sistem
- **Fluent Validation**: Model doğrulama işlemleri

## Kurulum

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları takip edebilirsiniz:

1. **Projeyi klonlayın**:
   ```bash
   git clone https://github.com/kullanici-adi/proje-adi.git
