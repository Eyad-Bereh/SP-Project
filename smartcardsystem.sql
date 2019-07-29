-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 14, 2019 at 05:01 AM
-- Server version: 10.1.34-MariaDB
-- PHP Version: 7.2.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `smartcardsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `cards`
--

CREATE TABLE `cards` (
  `card_number` varchar(8) COLLATE utf8_bin NOT NULL,
  `car_number` varchar(8) COLLATE utf8_bin NOT NULL,
  `monthly_limit` int(11) NOT NULL,
  `current_consumption` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `cards`
--

INSERT INTO `cards` (`card_number`, `car_number`, `monthly_limit`, `current_consumption`) VALUES
('12378945', '14785100', 150, 0),
('12378947', '14785236', 99, 0),
('14725836', '11445566', 800, 764),
('14725837', '11445566', 800, 500),
('14725839', '11445566', 800, 0),
('14789637', '45632178', 900, 0);

-- --------------------------------------------------------

--
-- Table structure for table `log`
--

CREATE TABLE `log` (
  `card_number` varchar(8) COLLATE utf8_bin NOT NULL,
  `consumption_amount` int(11) NOT NULL,
  `timestamp` varchar(10) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `log`
--

INSERT INTO `log` (`card_number`, `consumption_amount`, `timestamp`) VALUES
('14725836', 100, '1557350504'),
('14725836', 12, '1557350512'),
('14725836', 100, '1557353498'),
('14725836', 12, '1557790055'),
('14725836', 12, '1557790223'),
('14725836', 12, '1557790408'),
('14725836', 12, '1557790589'),
('14725836', 12, '1557790970'),
('14725836', 12, '1557790972'),
('14725836', 23, '1557799190'),
('14725836', 400, '1557799201'),
('14725837', 500, '1557799837'),
('14725836', 12, '1557800301'),
('14725836', 13, '1557800378'),
('14725836', 12, '1557800440'),
('14725836', 12, '1557800507'),
('14725836', 1, '1557800627'),
('14725836', 1, '1557800635'),
('14725836', 1, '1557800681'),
('14725836', 1, '1557800828'),
('14725836', 1, '1557800900'),
('14725836', 1, '1557800970'),
('14725836', 1, '1557801048'),
('14725836', 1, '1557801065');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cards`
--
ALTER TABLE `cards`
  ADD PRIMARY KEY (`card_number`);

--
-- Indexes for table `log`
--
ALTER TABLE `log`
  ADD PRIMARY KEY (`timestamp`),
  ADD KEY `card_number` (`card_number`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `log`
--
ALTER TABLE `log`
  ADD CONSTRAINT `log_ibfk_1` FOREIGN KEY (`card_number`) REFERENCES `cards` (`card_number`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
