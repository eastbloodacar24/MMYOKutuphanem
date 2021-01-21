-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Anamakine: localhost:3306
-- Üretim Zamanı: 21 Oca 2021, 13:56:31
-- Sunucu sürümü: 10.3.27-MariaDB
-- PHP Sürümü: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `eastbloo_mmyokutuphanem`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `Assigments`
--

CREATE TABLE `Assigments` (
  `Id` int(11) NOT NULL,
  `UserId` int(11) NOT NULL,
  `AssignDate` int(11) NOT NULL DEFAULT 0,
  `ReturnDate` int(11) DEFAULT 0,
  `DealedDate` int(11) NOT NULL DEFAULT 0,
  `Notes` text COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `Barcod` bigint(20) DEFAULT NULL,
  `Statu` int(11) DEFAULT 0
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `Books`
--

CREATE TABLE `Books` (
  `Id` int(11) NOT NULL,
  `Barcod` bigint(20) NOT NULL,
  `Name` varchar(50) CHARACTER SET latin1 NOT NULL,
  `Author` varchar(50) CHARACTER SET latin1 NOT NULL,
  `RCount` int(11) DEFAULT 0,
  `Statu` int(11) DEFAULT 0
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `Branchs`
--

CREATE TABLE `Branchs` (
  `Id` int(11) NOT NULL,
  `Name` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL DEFAULT ''
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `Users`
--

CREATE TABLE `Users` (
  `Id` int(11) NOT NULL,
  `Name` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL DEFAULT '',
  `ReadBooks` text COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `BranchId` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `Assigments`
--
ALTER TABLE `Assigments`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `Books`
--
ALTER TABLE `Books`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `Branchs`
--
ALTER TABLE `Branchs`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `Users`
--
ALTER TABLE `Users`
  ADD PRIMARY KEY (`Id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `Assigments`
--
ALTER TABLE `Assigments`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `Books`
--
ALTER TABLE `Books`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Tablo için AUTO_INCREMENT değeri `Branchs`
--
ALTER TABLE `Branchs`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `Users`
--
ALTER TABLE `Users`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
