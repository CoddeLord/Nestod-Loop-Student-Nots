# Nestod-Loop-Student-Nots


Bu C# programı, kullanıcıdan öğrenci notlarını alır ve her bir öğrencinin her bir ders için vize ve final notlarının ortalamasını hesaplar.

## Nasıl Çalışır

Program, konsol üzerinde çalışır ve aşağıdaki adımları izler:

1. Her bir öğrenci için:
   - Her bir ders için vize ve final notları istenir.
   - Girilen vize ve final notları kullanılarak ders ortalaması hesaplanır.
   - Her dersin ortalaması ekrana yazdırılır.

2. Toplamda 4 öğrenci ve her bir öğrenci için 3 ders bulunmaktadır.

## Kullanım

1. Programı çalıştırın.
2. Her bir öğrencinin her bir ders için istenen vize ve final notlarını girin.
3. Program, her dersin ortalamasını gösterecektir.

## Kod Yapısı

- `for` döngüleri kullanılarak öğrenci ve ders sayıları belirlenir.
- Kullanıcıdan not girişi almak için `Console.ReadLine()` ve `Convert.ToInt32()` kullanılır.
- Ortalama hesaplamak için basit bir formül kullanılır: `ortalama = (vize * 0.4) + (final * 0.6)`.


