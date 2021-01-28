-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Gegenereerd op: 23 nov 2020 om 10:27
-- Serverversie: 10.4.11-MariaDB
-- PHP-versie: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `izbankingatm`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `izbanking_accounts`
--

CREATE TABLE `izbanking_accounts` (
  `id` int(11) NOT NULL,
  `email` varchar(45) NOT NULL,
  `sex` varchar(45) NOT NULL,
  `firstname` varchar(45) NOT NULL,
  `lastname` varchar(45) NOT NULL,
  `bsn_number` varchar(45) NOT NULL,
  `date_of_birth` varchar(45) NOT NULL,
  `address` varchar(45) NOT NULL,
  `house_number` varchar(11) NOT NULL,
  `postalcode` varchar(45) NOT NULL,
  `town` varchar(45) NOT NULL,
  `account_number` int(11) NOT NULL,
  `pincode` varchar(200) NOT NULL,
  `balance` decimal(20,2) NOT NULL DEFAULT 0.00,
  `status` varchar(45) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Gegevens worden geëxporteerd voor tabel `izbanking_accounts`
--

INSERT INTO `izbanking_accounts` (`id`, `email`, `sex`, `firstname`, `lastname`, `bsn_number`, `date_of_birth`, `address`, `house_number`, `postalcode`, `town`, `account_number`, `pincode`, `balance`, `status`) VALUES
(1, 'damathijs@live.nl', 'Man', 'Mathijs', 'van der Laan', '224837932', '22-6-1996', 'Albert Schweitzersingel', '79', '3822BV', 'Amersfoort', 14135976, '0000', '5474.27', '0'),
(2, 'ptrjansen@hotmail.com', 'Man', 'Peter', 'Jansen', '232354325', '9-6-1984', 'Bombardonstraat', '3', '3822CG', 'Amersfoort', 25874022, '0000', '0.00', '1'),
(10, 'fwr@dfs.ml', 'man', 'rwe', 'wer', 'rew', '8-6-1995', 'rwe', 'rwer', 'rewrwe', 'wer', 82130356, '0000', '0.00', '0');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `izbanking_employees`
--

CREATE TABLE `izbanking_employees` (
  `id` int(11) NOT NULL,
  `first_name` varchar(45) NOT NULL,
  `last_name` varchar(45) NOT NULL,
  `employee_number` varchar(45) NOT NULL,
  `password` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Gegevens worden geëxporteerd voor tabel `izbanking_employees`
--

INSERT INTO `izbanking_employees` (`id`, `first_name`, `last_name`, `employee_number`, `password`) VALUES
(1, 'Mathijs', 'van der Laan', 'pnlml19u', '1234');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `izbanking_transactions`
--

CREATE TABLE `izbanking_transactions` (
  `id` int(11) NOT NULL,
  `amount` decimal(20,2) NOT NULL,
  `type` varchar(45) NOT NULL,
  `created_at` date NOT NULL,
  `customer_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Gegevens worden geëxporteerd voor tabel `izbanking_transactions`
--

INSERT INTO `izbanking_transactions` (`id`, `amount`, `type`, `created_at`, `customer_id`) VALUES
(1, '5.00', 'withdraw', '2020-11-19', 1),
(6, '500.00', 'withdraw', '2020-11-19', 1),
(7, '200.00', 'withdraw', '2020-11-19', 1),
(9, '10.00', 'deposit', '2020-11-20', 1),
(10, '10.10', 'deposit', '2020-11-20', 1),
(11, '100.00', 'withdraw', '2020-11-20', 1),
(19, '5.00', 'withdraw', '2020-11-20', 1),
(20, '5.00', 'withdraw', '2020-11-20', 1),
(21, '100.00', 'deposit', '2020-11-20', 1),
(22, '10.00', 'deposit', '2020-11-20', 1),
(23, '-10.00', 'deposit', '2020-11-20', 1),
(24, '-100.00', 'deposit', '2020-11-20', 1),
(25, '5555.00', 'deposit', '2020-11-22', 1),
(26, '200.00', 'withdraw', '2020-11-22', 1),
(27, '-6000.00', 'deposit', '2020-11-22', 1),
(28, '1000.00', 'deposit', '2020-11-22', 1),
(29, '100.00', 'withdraw', '2020-11-22', 1),
(30, '9.00', 'deposit', '2020-11-23', 1),
(31, '10.00', 'deposit', '2020-11-23', 1),
(33, '10.00', 'deposit', '2020-11-23', 1),
(46, '22.00', 'withdraw', '2020-11-23', 1),
(47, '33.00', 'deposit', '2020-11-23', 1),
(48, '22.22', 'deposit', '2020-11-23', 1),
(50, '11.12', 'deposit', '2020-11-23', 1),
(51, '222.88', 'deposit', '2020-11-23', 1),
(52, '44.78', 'withdraw', '2020-11-23', 1),
(53, '5.88', 'deposit', '2020-11-23', 1),
(54, '333.00', 'deposit', '2020-11-23', 1),
(55, '33.00', 'withdraw', '2020-11-23', 1),
(56, '323.00', 'deposit', '2020-11-23', 1),
(57, '232.00', 'deposit', '2020-11-23', 1),
(58, '2323.00', 'deposit', '2020-11-23', 1),
(59, '11.11', 'deposit', '2020-11-23', 1),
(60, '55.00', 'deposit', '2020-11-23', 1);

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `izbanking_accounts`
--
ALTER TABLE `izbanking_accounts`
  ADD PRIMARY KEY (`id`);

--
-- Indexen voor tabel `izbanking_employees`
--
ALTER TABLE `izbanking_employees`
  ADD PRIMARY KEY (`id`);

--
-- Indexen voor tabel `izbanking_transactions`
--
ALTER TABLE `izbanking_transactions`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `izbanking_accounts`
--
ALTER TABLE `izbanking_accounts`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT voor een tabel `izbanking_employees`
--
ALTER TABLE `izbanking_employees`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT voor een tabel `izbanking_transactions`
--
ALTER TABLE `izbanking_transactions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
