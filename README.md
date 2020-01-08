RANDEVU SİSTEMİ TOPLANTI KARARLARI

Taraflar geliştirilmesi istenen uygulama için karşılıklı bilgi alışverişinde bulundu. Amaç belirlenmiş
olup uygulama için gerekli rollerinin çalışma kapsamları belirtildi. Değişiklik taleplerinin iki taraflı
olarak yazılı yapılmasına karar verildi.
Amaç: MHRS sisteminden ilgili hastaneleri çıkarmak ve hastaneler için MHRS den bağımsız randevu
sistemi oluşturmak. Sonraki dönem satılmak istenen tedavi/operasyon paketleri için uygun raporlama
ortamının sağlanması.
HASTA ROLÜ
1- Hastalar ilgili sisteme üye olmadan randevu alamayacaklar.
2- Üyelik için hastadan mail adresi alınacak. Hasta sisteme girerken mail adresini kullanıcı hesabı
olarak kullanacak.
3- Sisteme kullanıcı hesabı ve şifre ile giriş yapılacak. Şifre en az 8 en fazla 16 karakter olmalıdır.  Aynı
zamanda özel karakter içermemelidir.
4- Hasta sisteme girişi sağladıktan sonra Karşısına Randevu Al seçeneği gelmelidir. Bu ekrana
girdiğinde hastadan sıralı olarak Hastane, Hastaneye ait varsa poliklinik, Hastane departmanı
seçimleri alınacaktır. Bu seçimler sonrasında ilgili departmanda çalışan doktorlar listelenecektir.
Opsiyonel olarak hasta Hastane ve Poliklinik seçmeden sadece departman seçebilir. Bu durumda Tüm
hastane ve polikliniklerin seçilen departmandaki doktorları listelenecektir.
5- Hasta randevu almak istediği tarihi seçmelidir.
6- Hasta Tarihi seçtikten sonra Doktor için mesai içindeki seansları listelenecektir. Seanslar şimdilik
30dk şeklinde planlanacak lakin istenildiğinde ileride değiştirilebilecek şekilde tasarlanmalıdır.
Doktorun ilgili tarihte müsait seansı var ise müsait seansları ile birlikte dolu seansları da
görüntülenecektir. Eğer hiç müsait seans yok ise herhangi listeleme yapmadan ilgili gün uygun seans
olmadığına yönelik bir mesaj verilecektir.
7- Hasta uygun bir seans seçtiğinde Hasta için bir randevu oluşturulacaktır. Randevu bilgisi içinde
Hasta, Doktor, Tarih, seans bilgileri tutulur.
8- Hasta ekranında mevcut Randevular menü seçeneğini seçtiğinde Almış olduğu randevular
listelenir.
9- Hasta seçtiği herhangi randevuyu sistemden silebilir. Silmesi durumunda Doktorun ilgili seansı boşa
çıkarılmalıdır.

DOKTOR ROLÜ
1- Doktor sisteme önceden kayıtlı olan kullanıcı adı ve şifre ile giriş yapar.
2- ÇalışmaGünü menüsünden günün randevularını seanslar halinde görüntüler.

3- Randevuları seçtiğinde bunlar için Muayene oluştur seçeneği ile Randevudaki hasta için Muayene
oluşturur ve Muayene ekranına geçer. Eğer Hasta gelmemiş ise Randevuyu Muayene gerçekleşmedi
şeklinde işaretleyebilmelidir.
5- Muayene ekranında not girişi yaparak hazır bulunan bir Teşhis verisini seçmelidir. Eğer gerekir ise
Reçete oluşturabilir. Eğer Teşhis koyulamıyor ise Tahlil talebinde bulunabilir. Bu durumda ileri bir
tarih için Hastaya yeni bir randevuyu bu ekran aracılığı ile Doktor yapacaktır.
6- Tamamlanmış Muayene için sorgu yapılabilir sistemin kurgulanması gerekmektedir.
ECZACI ROLÜ
1- Eczacı sisteme önceden kayıtlı olan kullanıcı adı ve şifre ile giriş yapar.
2- Gelen hastanın verdiği Reçete numarası ile sistemde sorgulama yapıp reçetenin içerdiği ilaçları
görüntüleyebilir.
3- Hasta reçete geçmişi menüsünden hastanın daha önce aldığı ilaçları görüntüleyebilir.
KULLANILACAK TEKNOLOJILER
WinForm, Ado.Net, MS SQL Server