-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 27, 2021 at 07:08 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pnd_express`
--

-- --------------------------------------------------------

--
-- Table structure for table `agen`
--

CREATE TABLE `agen` (
  `id_agen` int(8) NOT NULL,
  `nama_agen` varchar(64) NOT NULL,
  `alamat_agen` varchar(128) NOT NULL,
  `no_hp` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `agen`
--

INSERT INTO `agen` (`id_agen`, `nama_agen`, `alamat_agen`, `no_hp`) VALUES
(1, 'Agen Yogyakarta', 'Jl. Kaliurang No. 15, Sleman, Yogyakarta', '081412831241'),
(2, 'Agen Solo', 'Jl. Sudirman No. 452, Surakarta, Jawa Tengah', '0814128355551'),
(3, 'Agen Semarang', 'Jl. Kolonel Marhadi No. 96, Semarang, Jawa Tengah ', '08521591241'),
(4, 'Agen Surabaya', 'Jl. Asahan No.564 Surabaya, Jawa Timur', '081423923124'),
(6, 'Agen Bandung', 'Jl. Pattimura no. 157 Bandung, Jawa Barat', '0853125975258'),
(7, 'Agen Jakarta', 'Jl. Sudirman no. 507 Jakarta Selatan, DKI Jakarta', '038513401351');

-- --------------------------------------------------------

--
-- Table structure for table `detail_paket`
--

CREATE TABLE `detail_paket` (
  `id_paket` varchar(20) NOT NULL,
  `id_agen` int(8) NOT NULL,
  `nama_penerima` varchar(64) NOT NULL,
  `alamat_penerima` varchar(128) NOT NULL,
  `no_hp_penerima` varchar(16) NOT NULL,
  `nama_pengirim` varchar(64) NOT NULL,
  `alamat_pengirim` varchar(128) NOT NULL,
  `no_hp_pengirim` varchar(64) NOT NULL,
  `berat` varchar(16) NOT NULL,
  `isi` varchar(128) NOT NULL,
  `status` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `detail_paket`
--

INSERT INTO `detail_paket` (`id_paket`, `id_agen`, `nama_penerima`, `alamat_penerima`, `no_hp_penerima`, `nama_pengirim`, `alamat_pengirim`, `no_hp_pengirim`, `berat`, `isi`, `status`) VALUES
('EK001', 1, 'Kasim', 'Jogja', '08521133', 'Daka', 'Jakarta', '081241', '100', 'buku', 'proses pengiriman'),
('EK002', 6, 'Abbrar', 'Jogja', '095513', 'Bram', 'Surabaya', '08124156', '1300 gram', 'alat olahraga', 'proses pengiriman'),
('EK003', 4, 'Hadi', 'Bandung', '08433191', 'Joko', 'Semarang', '019313', '500 gram', 'Kemeja', 'proses pengiriman'),
('EK004', 6, 'Yubi', 'Cilacap', '081341349', 'Gani', 'Jember', '084219', '500 gram', 'Jam Tangan', 'proses pengiriman');

-- --------------------------------------------------------

--
-- Table structure for table `karyawan`
--

CREATE TABLE `karyawan` (
  `id_karyawan` int(8) NOT NULL,
  `id_agen` int(8) NOT NULL,
  `nama_karyawan` varchar(128) NOT NULL,
  `alamat_karyawan` varchar(128) NOT NULL,
  `no_hp_karyawan` varchar(16) NOT NULL,
  `password` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `karyawan`
--

INSERT INTO `karyawan` (`id_karyawan`, `id_agen`, `nama_karyawan`, `alamat_karyawan`, `no_hp_karyawan`, `password`) VALUES
(1, 1, 'Abbrar', 'Jogja', '08521212', '1111'),
(2, 6, 'Bram', 'Bandung', '08941', '2222');

-- --------------------------------------------------------

--
-- Table structure for table `paket`
--

CREATE TABLE `paket` (
  `id_paket` varchar(20) NOT NULL,
  `berat` varchar(16) NOT NULL,
  `isi` varchar(128) NOT NULL,
  `status` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `agen`
--
ALTER TABLE `agen`
  ADD PRIMARY KEY (`id_agen`);

--
-- Indexes for table `detail_paket`
--
ALTER TABLE `detail_paket`
  ADD PRIMARY KEY (`id_paket`),
  ADD KEY `FK_agen_detailpaket` (`id_agen`);

--
-- Indexes for table `karyawan`
--
ALTER TABLE `karyawan`
  ADD PRIMARY KEY (`id_karyawan`),
  ADD UNIQUE KEY `id_agen` (`id_agen`);

--
-- Indexes for table `paket`
--
ALTER TABLE `paket`
  ADD PRIMARY KEY (`id_paket`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `agen`
--
ALTER TABLE `agen`
  MODIFY `id_agen` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `karyawan`
--
ALTER TABLE `karyawan`
  MODIFY `id_karyawan` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `karyawan`
--
ALTER TABLE `karyawan`
  ADD CONSTRAINT `karyawan_ibfk_1` FOREIGN KEY (`id_agen`) REFERENCES `agen` (`id_agen`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
