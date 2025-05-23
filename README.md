# Geometrik Şekil Alan Hesaplayıcı (C# Konsol Uygulaması)

Bu proje, kullanıcıdan aldığı şekil ve ölçülerle alan hesaplaması yapan basit bir C# konsol uygulamasıdır. Kullanıcı `Kare`, `Dikdörtgen` veya `Üçgen` seçerek bu şeklin alanını hesaplayabilir.

## Özellikler

- Kullanıcıdan şekil seçimi alır (`1`: Kare, `2`: Dikdörtgen, `3`: Üçgen)
- Genişlik ve gerektiğinde yükseklik bilgilerini alır
- Alanı hesaplayarak ekranda gösterir
- Kullanıcıya işlemi tekrar etmek isteyip istemediğini sorar
- Yanlış girişlerde kullanıcıyı tekrar yönlendirir

- ## Sınıflar

- `GeometrikSekil`: Tüm şekillerin ortak sınıfıdır. `Genislik`, `Yukseklik` ve `AlanHesapla()` metodunu içerir.
- `Kare`, `Dikdortgen`, `Ucgen`: `GeometrikSekil` sınıfından türeyen sınıflardır ve kendi alan hesaplama mantıklarını override eder.
- `SekilHesapla`: Kullanıcıdan veri alır, kontrol eder ve alan hesaplamasını gerçekleştirir.
