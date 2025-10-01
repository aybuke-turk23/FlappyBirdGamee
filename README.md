# FlappyBirdGamee
Flappy bird game  
# 🐦 Flappy Bird Projesi

Bu proje, C# programlama dili ve **Windows Forms (.NET )** kullanılarak geliştirilmiş popüler Flappy Bird oyununun bir replikasıdır. Proje, temel oyun mantığı ve dinamik zorluk artışı gibi özellikleri içerir.

---

## 🛠️ Temel Özellikler

Oyun, aşağıdaki temel mekaniklere sahiptir:

* **Kuş Hareketi:** Boşluk tuşu (**Space**) ile zıplama mekaniği. Yerçekimi kuvveti (`gravity`) ile sürekli düşme simülasyonu.
* **Dinamik Boru Sistemi:** Borular sürekli sola hareket eder (`pipeSpeed`). Ekran dışına çıkan borular rastgele aralıklarla yeniden konumlandırılarak sonsuz döngü sağlanır.
* **Skorlama:** Geçilen her boru çiftinde skor artar.
* **Zorluk Artışı:** Skor 5 ve 10'a ulaştığında oyun hızı (`pipeSpeed`) otomatik olarak artırılarak zorluk kademeli olarak yükseltilir.
* **Çarpışma Kontrolü:** Kuşun borulara, zemine veya ekranın üst sınırına çarpması durumunda **Game Over** (Oyun Bitti) ekranı tetiklenir.

---

## 🚀 Projeyi Çalıştırma

Projeyi çalıştırmanın iki yolu vardır:

### 1. Çalıştırılabilir Sürümü İndirme

Eğer sadece oyunu test etmek istiyorsanız:

1.  Bu deponun **[Releases (Sürümler)](https://github.com/aybuke-turk23/FlappyBirdGamee/releases/tag/v1.0)** sekmesine gidin. 
2.  Yayımlanan son sürümün altındaki **`Assets`** bölümünden `.zip` dosyasını indirin.
3.  ZIP dosyasını açın ve içerisindeki **`.exe`** dosyasını çalıştırın.

### 2. Kaynak Koddan Derleme

Eğer kod üzerinde değişiklik yapmak veya incelemek istiyorsanız:

1.  Depoyu bilgisayarınıza klonlayın (git clone https://github.com/aybuke-turk23/FlappyBirdGamee.git).
2.  Visual Studio'da `FlappyBirdProject.sln` dosyasını açın.
3.  Projeyi derleyin ve `F5` tuşuna basarak çalıştırın.

---

## 🕹️ Nasıl Oynanır?

* **Başlatma:** Uygulama açıldığında oyun otomatik olarak başlar.
* **Zıplama:** **Boşluk (Space)** tuşuna basarak kuşun zıplamasını sağlayın.
* **Amaç:** Boruların arasından yere çarpmadan geçerek en yüksek skoru elde etmektir.

---

## 🧑‍💻 Geliştirici

**Aybüke TÜRK**
* **GitHub:** (https://github.com/aybuke-turk23)
* **Proje Tarihi:** Eylül 2025
