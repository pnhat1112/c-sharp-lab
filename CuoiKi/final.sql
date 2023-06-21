-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 04, 2023 at 06:48 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `final`
--

-- --------------------------------------------------------

--
-- Table structure for table `song`
--

CREATE TABLE `song` (
  `id` int(11) NOT NULL,
  `name` varchar(60) NOT NULL,
  `artist` varchar(50) NOT NULL,
  `path` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `song`
--

INSERT INTO `song` (`id`, `name`, `artist`, `path`) VALUES
(1, 'Loser', 'a', 'C:[]Users[]thanhtuan[]Documents[]songs[]a.mp3'),
(2, 'Dangerously Lyrics.mp3', '', 'C:[]Users[]thanhtuan[]Documents[]songs[]Dangerously Lyrics.mp3'),
(3, 'I Dont Think That I Like Her Lyrics.mp3', '', 'C:[]Users[]thanhtuan[]Documents[]songs[]I Dont Think That I Like Her Lyrics.mp3'),
(4, 'Left And Right Lyrics ft Jungkook of BTS.mp3', '', 'C:[]Users[]thanhtuan[]Documents[]songs[]Left And Right Lyrics ft Jungkook of BTS.mp3'),
(5, 'Light Switch Lyrics.mp3', '', 'C:[]Users[]thanhtuan[]Documents[]songs[]Light Switch Lyrics.mp3'),
(6, 'Thats Hilarious Lyrics_256kbps.mp3', '', 'C:[]Users[]thanhtuan[]Documents[]songs[]Thats Hilarious Lyrics_256kbps.mp3'),
(7, 'WaitingForYou-MONOOnionn-7733882.mp3', 'MONO, Onionn', 'C:[]Users[]thanhtuan[]Documents[]songs[]WaitingForYou-MONOOnionn-7733882.mp3');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `song`
--
ALTER TABLE `song`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `song`
--
ALTER TABLE `song`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
