-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: localhost
-- Üretim Zamanı: 03 Oca 2023, 11:29:07
-- Sunucu sürümü: 8.0.17
-- PHP Sürümü: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `arackiralama`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `arackayit`
--

CREATE TABLE `arackayit` (
  `aracid` int(11) NOT NULL,
  `plaka` varchar(200) NOT NULL,
  `marka` varchar(200) NOT NULL,
  `model` varchar(200) NOT NULL,
  `renk` varchar(200) NOT NULL,
  `km` varchar(200) NOT NULL,
  `yakit` varchar(200) NOT NULL,
  `resim` varchar(200) NOT NULL,
  `kiraucreti` int(11) NOT NULL,
  `durumu` varchar(200) NOT NULL,
  `tarih` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `arackayit`
--

INSERT INTO `arackayit` (`aracid`, `plaka`, `marka`, `model`, `renk`, `km`, `yakit`, `resim`, `kiraucreti`, `durumu`, `tarih`) VALUES
(13, '34 sh 856', 'Aston Martin', '152', 'sarı', '60', 'Benzin', 'C:\\Users\\Furkan\\OneDrive\\Masaüstü\\astonmartin.jpg', 1400, 'Boş', '2023-01-03 13:59:41'),
(14, '34TT345', 'Tesla', '2015', 'Siyah', '20520520', 'Dizel', 'C:\\Users\\Furkan\\OneDrive\\Masaüstü\\tesla.jpg', 500, 'Dolu', '2023-01-03 13:48:56'),
(15, '16FF355', 'Ford', '2010', 'Siyah', '150000', 'Dizel', 'C:\\Users\\Furkan\\OneDrive\\Masaüstü\\focus.jpg', 500, 'Boş', '2023-01-03 14:02:26');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `araclar`
--

CREATE TABLE `araclar` (
  `arac_id` int(11) NOT NULL,
  `arac_marka` varchar(50) NOT NULL,
  `arac_model` varchar(50) NOT NULL,
  `arac_sube_id` varchar(50) NOT NULL,
  `arac_bolge_id` varchar(50) NOT NULL,
  `arac_kisi_sayisi` varchar(50) NOT NULL,
  `arac_tipi` varchar(50) NOT NULL,
  `arac_aciklama` text NOT NULL,
  `arac_olusturma_tarihi` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `bolgeler`
--

CREATE TABLE `bolgeler` (
  `bolge_id` int(11) NOT NULL,
  `bolge_baslik` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanicilar`
--

CREATE TABLE `kullanicilar` (
  `kullanici_id` int(11) NOT NULL,
  `kullanici_tc` varchar(11) NOT NULL,
  `kullanici_ad` varchar(50) NOT NULL,
  `kullanici_soyad` varchar(50) NOT NULL,
  `kullanici_adi` varchar(50) NOT NULL,
  `kullanici_sifre` varchar(50) NOT NULL,
  `kullanici_telefon` varchar(50) NOT NULL,
  `kullanici_email` varchar(50) NOT NULL,
  `kullanici_adres` text NOT NULL,
  `kullanici_sehir` varchar(50) NOT NULL,
  `kullanici_ilce` varchar(50) NOT NULL,
  `kullanici_olusturma_tarihi` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `kullanicilar`
--

INSERT INTO `kullanicilar` (`kullanici_id`, `kullanici_tc`, `kullanici_ad`, `kullanici_soyad`, `kullanici_adi`, `kullanici_sifre`, `kullanici_telefon`, `kullanici_email`, `kullanici_adres`, `kullanici_sehir`, `kullanici_ilce`, `kullanici_olusturma_tarihi`) VALUES
(4, '200', 'Mehmet', 'Yılmaz', 'memed.123', '123456', '05205202020', 'memed.123@gmail.com', 'Çiçek mah. bBahçe sk. No.10 Daire 8 \r\nNilüfer/Bursa', 'Bursa', 'Nilüfer', '2023-01-02 01:38:43'),
(5, '300', 'Ali', 'Yıldız', 'ali123', '123456', '5205205656', 'aliyıldız.com', 'Bursa/Yıldırım', 'Bursa', 'Yıldırım', '2023-01-02 01:41:37'),
(6, '2020', 'Oğuzhan', 'Acaroğlu', 'oguz.321', '123456', '5205203030', 'oguz.321@gmail.com', 'Deniz Mah. Tamer Sk. No7 Daire9\r\nOsmangazi/Bursa', 'Bursa', 'Osmangazi', '2023-01-02 01:43:32'),
(7, '700', 'Samet', 'Çıtlak', 'esc', 'esc123', '5205206363', 'esc@gmail.com', 'ağaç mah. 7.sk no50 daire8\r\nuzungöl/trabzon', 'Trabzon', 'Uzungöl', '2023-01-03 04:10:05'),
(8, '300', 'Ali', 'Yıldız', 'ali123', '123456', '5205205656', 'aliyıldız.com', 'Bursa/Yıldırım', 'Bursa', 'Yıldırım', '2023-01-03 13:47:09');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `satis`
--

CREATE TABLE `satis` (
  `id` int(11) NOT NULL,
  `tc` varchar(11) NOT NULL,
  `adsoyad` varchar(50) NOT NULL,
  `plaka` varchar(50) NOT NULL,
  `marka` varchar(50) NOT NULL,
  `model` varchar(100) NOT NULL,
  `renk` varchar(50) NOT NULL,
  `gun` int(50) NOT NULL,
  `fiyat` int(50) NOT NULL,
  `tutar` int(50) NOT NULL,
  `ctarihi` datetime DEFAULT NULL,
  `gtarihi` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `satis`
--

INSERT INTO `satis` (`id`, `tc`, `adsoyad`, `plaka`, `marka`, `model`, `renk`, `gun`, `fiyat`, `tutar`, `ctarihi`, `gtarihi`) VALUES
(1, '200', 'Mehmet', '16FF200', 'Hundai', '2016', 'Kırmızı', 7, 2800, 400, '2023-01-12 00:00:00', '2003-01-20 23:00:00'),
(2, '200', 'Mehmet', '16FF200', 'Hundai', '2016', 'Kırmızı', 0, 0, 350, '2023-01-03 00:00:00', '2003-01-20 23:00:00'),
(3, '200', 'Mehmet', '16FF200', 'Hundai', '2020', 'Kırmızı', -1, -350, 350, '2023-01-04 00:00:00', '2003-01-20 23:00:00'),
(4, '700', 'Samet', '16JJT300', 'Mercedes', 'Siyah', '20000', 10, 5250, 525, '2022-12-24 00:00:00', '2003-01-20 23:00:00'),
(5, '2020', 'Oğuzhan', '34YY546', 'Renault', '2050', 'Siyah', 3, 600, 200, '2022-12-31 00:00:00', '2003-01-20 23:00:00'),
(6, '700', 'Samet', '16FF200', 'Hundai', '2020', 'Kırmızı', 3, 960, 320, '2022-12-31 00:00:00', '2003-01-20 23:00:00'),
(7, '2020', 'Oğuzhan', '16JJT300', 'Mercedes', 'Siyah', '20000', -9, -5400, 600, '2023-01-12 00:00:00', '2003-01-20 23:00:00'),
(8, '700', 'Samet', '34TT345', 'Tesla', '2015', 'Siyah', 4, 2000, 500, '2022-12-30 00:00:00', '2003-01-20 23:00:00'),
(9, '2020', 'Oğuzhan', '34 sh 856', 'Aston Martin', '152', 'sarı', 3, 4200, 1400, '2022-12-31 00:00:00', '2003-01-20 23:00:00');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sozlesme`
--

CREATE TABLE `sozlesme` (
  `tc` varchar(50) NOT NULL,
  `adsoyad` varchar(50) NOT NULL,
  `telefon` varchar(50) NOT NULL,
  `ehliyetno` varchar(50) NOT NULL,
  `e_tarih` varchar(50) NOT NULL,
  `plaka` varchar(50) NOT NULL,
  `marka` varchar(50) NOT NULL,
  `model` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `renk` varchar(50) NOT NULL,
  `kirasekli` int(40) NOT NULL,
  `kiraucreti` int(50) NOT NULL,
  `gun` int(50) NOT NULL,
  `tutar` int(50) NOT NULL,
  `ctarihi` varchar(200) NOT NULL,
  `gtarihi` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `sozlesme`
--

INSERT INTO `sozlesme` (`tc`, `adsoyad`, `telefon`, `ehliyetno`, `e_tarih`, `plaka`, `marka`, `model`, `renk`, `kirasekli`, `kiraucreti`, `gun`, `tutar`, `ctarihi`, `gtarihi`) VALUES
('700', 'Samet', '5205206363', '2020', '202020', '34TT345', 'Tesla', '2015', 'Siyah', 0, 500, -5, -2500, '31 Aralık 2022 Cumartesi', '5 Ocak 2023 Perşembe');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `subeler`
--

CREATE TABLE `subeler` (
  `sube_id` int(11) NOT NULL,
  `sube_baslik` varchar(100) NOT NULL,
  `sube_aciklama` text NOT NULL,
  `sube_resim` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `yoneticiler`
--

CREATE TABLE `yoneticiler` (
  `yonetici_id` int(11) NOT NULL,
  `yonetici_kullanici_adi` varchar(30) NOT NULL,
  `yonetici_kullanici_sifre` varchar(30) NOT NULL,
  `yonetici_adi` varchar(30) NOT NULL,
  `yonetici_soyadi` varchar(30) NOT NULL,
  `yonetici_yetki` enum('Kullanici','Admin') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `yoneticiler`
--

INSERT INTO `yoneticiler` (`yonetici_id`, `yonetici_kullanici_adi`, `yonetici_kullanici_sifre`, `yonetici_adi`, `yonetici_soyadi`, `yonetici_yetki`) VALUES
(1, 'acar', '123456', 'Furkan', 'Acaroğlu', 'Admin');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `arackayit`
--
ALTER TABLE `arackayit`
  ADD PRIMARY KEY (`aracid`);

--
-- Tablo için indeksler `araclar`
--
ALTER TABLE `araclar`
  ADD PRIMARY KEY (`arac_id`);

--
-- Tablo için indeksler `bolgeler`
--
ALTER TABLE `bolgeler`
  ADD PRIMARY KEY (`bolge_id`);

--
-- Tablo için indeksler `kullanicilar`
--
ALTER TABLE `kullanicilar`
  ADD PRIMARY KEY (`kullanici_id`);

--
-- Tablo için indeksler `satis`
--
ALTER TABLE `satis`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `subeler`
--
ALTER TABLE `subeler`
  ADD PRIMARY KEY (`sube_id`);

--
-- Tablo için indeksler `yoneticiler`
--
ALTER TABLE `yoneticiler`
  ADD PRIMARY KEY (`yonetici_id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `arackayit`
--
ALTER TABLE `arackayit`
  MODIFY `aracid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- Tablo için AUTO_INCREMENT değeri `araclar`
--
ALTER TABLE `araclar`
  MODIFY `arac_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `bolgeler`
--
ALTER TABLE `bolgeler`
  MODIFY `bolge_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `kullanicilar`
--
ALTER TABLE `kullanicilar`
  MODIFY `kullanici_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Tablo için AUTO_INCREMENT değeri `satis`
--
ALTER TABLE `satis`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Tablo için AUTO_INCREMENT değeri `subeler`
--
ALTER TABLE `subeler`
  MODIFY `sube_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `yoneticiler`
--
ALTER TABLE `yoneticiler`
  MODIFY `yonetici_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
