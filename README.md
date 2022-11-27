
# EtkinlikProjesi
Projenin amacı, organizatörlerin etkinlik oluşturabildiği ve katılımcıların bu etkinlikleri görüp
başvurabildiği bir online etkinlik yönetim sistemi oluşturmaktır.

Bu sistem, son kullanıcılara mobil ve web ortamında çalışan farklı arayüz yazılımları ile sunulacaktır.
Ayrıca bilet satışının olduğu etkinlikler için farklı online satış kanallarıyla, ilgili etkinliklerin paylaşılması
gerekmektedir. Bu sistem üzerinden bir bilet satış işlemi yapılmayacaktır.

• Kullanıcılar üye olmadan sistemin işlevselliklerini kullanamazlar.

• Organizatör rolüyle kayıt olan kullanıcılar düzenlemek istedikleri etkinlikleri gerekli bilgileri girerek tanımlarlar.

• Katılımcı rolüyle kayıt olan kullanıcılar sistemde tanımlı etkinlikleri görebilirler ve istedikleri etkinliğe katılabilirler.

• Farklı online bilet satış firmaları sistem üzerinde tanımlı ve bilet satışının olduğu etkinliklere erişebilirler.

• Katılımcılar biletli bir etkinliğe katılmak istediklerinde sisteme entegre olmuş bilet satış firmalarının listesi sunulur.

Kullanım Senaryoları

-Üye Olma

Sisteme üye olurken ad, soyad, kullanıcı adı, şifre bilgileri girilir. Şifre en az 6 karakter olur ve hem büyük harf hem küçük harf içerir. Üyelik esnasında organizatör veya katılımcı rolü seçilir.

Her kullanıcı adına sadece bir üyelik tanımlıdır.

-Üye Girişi Yapma

Kullanıcılar kayıt esnasında verdikleri kullanıcı adı ve şifre bilgileriyle giriş yapar.

-Etkinlik Düzenleme

Organizatör rolüne sahip kullanıcılar sistem üzerinde etkinlik oluşturabilir. Etkinliğin adını, gerçekleşeceği tarihi, açıklamasını(tanıtım yazısı, detaylar vb. için), düzenlendiği şehri, kontenjanı, biletli olup olmadığını bilgisini girer.

-Etkinliğe Katılma

Katılımcı rolüne sahip kullanıcılar sistemde tanımlı etkinlikleri görüntülerler.

İstedikleri etkinliği katılabilirler. Eğer etkinlik kontenjanı dolmuşsa buna yönelik uyarı verilir.Kullanıcı biletli bir etkinliğe katılmak isterse, bileti satın alabileceği firmaların adını görüntüler ve istediğine tıklayarak firmanın web sitesine yönlendirilir.

-Bilet Satış Entegrasyonu

Geliştirilecek sistemde etkinlikler için bilet satışı yapılmayacaktır ancak biletli etkinlik düzenlenebilecektir. Bu etkinlikler için bilet satışı bu işlemi yapan firmalar üzerinden gerçekleşecektir.Katılımcının bilet satın alması, sonrasında isterse iade süreçleri katılımcı ile satın alma işlemini yaptığı firma arasında bir süreçtir. Geliştirilecek sistemin bu süreçte bir dahli ve sorumluluğu yoktur. Sisteme entegre olmak isteyen bilet firmaları sistemde tanımlanmalıdır. Bu tanımlama esnasında firma adı ve web sitesi bilgileri girilir.Bu firmalar, sistem üzerinde tanımlı etkinlik bilgilerini çekebilirler. Bu firmalar farklı yapılara sahip
olabileceğinden sistem bu verileri hem XML, hem de JSON formatında sunar.
