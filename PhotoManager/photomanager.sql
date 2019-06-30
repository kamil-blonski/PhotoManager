-- phpMyAdmin SQL Dump
-- version 3.5.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Czas wygenerowania: 30 Cze 2019, 22:45
-- Wersja serwera: 5.5.21-log
-- Wersja PHP: 5.3.20

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Baza danych: `photomanager`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `albums`
--

CREATE TABLE IF NOT EXISTS `albums` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` char(30) COLLATE utf8_unicode_ci NOT NULL,
  `creationdate` datetime DEFAULT NULL,
  `description` char(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `type` enum('PE','PC') COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `cameras`
--

CREATE TABLE IF NOT EXISTS `cameras` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `type` char(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `creation`
--

CREATE TABLE IF NOT EXISTS `creation` (
  `id_u` int(10) unsigned NOT NULL,
  `id_a` int(10) unsigned NOT NULL,
  KEY `id_u` (`id_u`),
  KEY `id_a` (`id_a`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `ownership`
--

CREATE TABLE IF NOT EXISTS `ownership` (
  `id_a` int(10) unsigned NOT NULL,
  `id_p` int(10) unsigned NOT NULL,
  KEY `id_a` (`id_a`),
  KEY `id_p` (`id_p`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `photography`
--

CREATE TABLE IF NOT EXISTS `photography` (
  `id_u` int(10) unsigned NOT NULL,
  `id_p` int(10) unsigned NOT NULL,
  `id_c` int(10) unsigned NOT NULL,
  KEY `id_u` (`id_u`),
  KEY `id_p` (`id_p`),
  KEY `id_c` (`id_c`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `photos`
--

CREATE TABLE IF NOT EXISTS `photos` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` char(50) COLLATE utf8_unicode_ci NOT NULL,
  `creationdate` datetime DEFAULT NULL,
  `description` char(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `format` char(5) COLLATE utf8_unicode_ci NOT NULL,
  `size` double NOT NULL,
  `pictureB` longblob NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=20 ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` char(30) COLLATE utf8_unicode_ci NOT NULL,
  `surname` char(30) COLLATE utf8_unicode_ci NOT NULL,
  `login` char(30) COLLATE utf8_unicode_ci NOT NULL,
  `password` char(50) COLLATE utf8_unicode_ci NOT NULL,
  `email` char(50) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `login` (`login`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=21 ;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `creation`
--
ALTER TABLE `creation`
  ADD CONSTRAINT `creation_ibfk_1` FOREIGN KEY (`id_u`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `creation_ibfk_2` FOREIGN KEY (`id_a`) REFERENCES `albums` (`id`);

--
-- Ograniczenia dla tabeli `ownership`
--
ALTER TABLE `ownership`
  ADD CONSTRAINT `ownership_ibfk_1` FOREIGN KEY (`id_a`) REFERENCES `albums` (`id`),
  ADD CONSTRAINT `ownership_ibfk_2` FOREIGN KEY (`id_p`) REFERENCES `photos` (`id`);

--
-- Ograniczenia dla tabeli `photography`
--
ALTER TABLE `photography`
  ADD CONSTRAINT `photography_ibfk_1` FOREIGN KEY (`id_u`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `photography_ibfk_2` FOREIGN KEY (`id_p`) REFERENCES `photos` (`id`),
  ADD CONSTRAINT `photography_ibfk_3` FOREIGN KEY (`id_c`) REFERENCES `cameras` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
