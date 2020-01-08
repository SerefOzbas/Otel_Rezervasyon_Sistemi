OTEL REZERVASYON SİSTEMİ

Tanım;
Proje bir otel rezervasyon sisteminin basitleştirilmiş hali olarak kurgulanmıştır.
Müşteriler rezervasyon yaparken aşağıdaki bilgileri girebilmelidir.
1. Giriş Tarihi
2. Çıkış Tarihi
3. Konaklayacak kişi sayısı
4. 3 kişiden fazla kişi gelirse tek rezervasyonda 2. Oda için rezervasyon
mecburidir.
5. Sisteme giriş yapan kişi rezervasyonu yaptıracaktır.
6. Ayrıca rezervasyon sırasında kişi sayısına göre konaklayacak kişilerin ad
soyad ve TCKN bilgileri de alınacaktır.
7. Rezervasyon yaptırırken 3 tip rezervasyon çeşidi olacak. (Standart,Full,
Full + Full)
8. Rezervasyon çeşidi açıklamaları şu şekildedir:
Standart: sadece oda ve kahvaltı dahildir.
Full: oda ve tüm öğünler dahildir.
Full + Full: oda yemek ve içki dahildir.
1. Rezervasyon yaptıracak kişi aynı anda tek çeşit rezervasyon yaptırabilir.

Detaylar:
1. Otel odaları standart 2 kişliktir ve sisteme bu fiyatlar girilecektir
2. Odaların haftasonu (cuma-ctesi) geceleme fiyatları haftaiçi fiyatlarından %30
daha fazladır. Oran değişebilir.
3. Odalarda tek kişilik konaklama yapılabilmektedir fakat ücret standart oda
ücretin %30 eksiği olarak fiyatlandırılmaktadır. Oran değişebilir.
4. Odalara 1 adet ilave yatak eklenerek 3 kişi kalınabilmektedir, 3 kişilik
konaklama standart fiyatının %20 fazlası şeklindedir. Oran değişebilir.
5. Sistem konaklayacak kişi sayısına göre en ucuz fiyatı sağlayacak oda sayısını
belirlemelidir
6. Kalınacak tarihler içindeki haftasonu gecelemelerini bulup ücreti haftasonu
fiyatlarından hesaplanmalıdır.

SİSTEM ROLLERİ
Müşteri Rolü
1- Müşteriler ilgili sisteme üye olmadan rezervasyon yapamayacaktır.
2- Sisteme giriş için müşteriden mai adresi alınacak. Müşteri mail adresini
kullanıcı hesabı olarak kullanacak.

3- Sisteme kullanıcı hesabı ve şifre ile giriş yapılacak. Şifre en az 8 en fazla
16 karakter olmalı ve özel karakter içermemelidir.
4- Müşteri sisteme girdikten sonra karşısına Rezervasyon Yap seçeneği çıkmalıdır.
Detayları yukarıda belirtilen şekilde rezervasyonu yapmalıdır.
5- Müşteri geçmiş rezervasyonlarını görebilmelidir. Gelecek rezervasyonlarını
başlangıç tarihinden 1 hafta öncesine kadar iptal edebilir.
OTEL YÖNETİCİSİ ROLÜ
1- Otel yöneticisi sisteme daha önceden tanımlanmış kullanıcı hesabı ve şifre ile
giriş yapmalıdır.
2- Sisteme odaları tanımlamalıdır. Oda fiyatlarını sisteme girmesi gerekmektedir.
3- Hafta sonu fiyatlarının ne kadar fazla olacağını yüzdelik oran olarak
tanımlayabilmeli ve değiştirebilmelidir. Aynı şekilde tek kişilik ve üç kişilik
kalma durumlarındaki yüzdelik oranı da değiştirebilmelidir.
4- Tarih aralığı girerek o aralıkta tüm odalarının boş mu dolu mu olduğunu
görebilmelidir. Dolu odalarda kimlerin kalacağını listeleyebilmelidir.
5- Sistemde yapılmış rezervasyonları tiplerine göre filtreleyerek görebilmelidir.
Rezervasyon detaylarına bakıp kaç kişilik olduğunu, o rezervasyonun kaç adet oda
içerdiğini, ilave yatak eklenen odaları ve yatak çıkartılan odaları
görebilmelidir.
KULLANILACAK TEKNOLOJILER
WinForm, Ado.Net, MS SQL Server