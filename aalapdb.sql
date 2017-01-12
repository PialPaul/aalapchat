-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 18, 2017 at 01:53 PM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 7.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `aalapdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `convtable`
--

CREATE TABLE `convtable` (
  `conId` int(11) NOT NULL,
  `msgForm` int(11) NOT NULL,
  `msgTo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `convtable`
--

INSERT INTO `convtable` (`conId`, `msgForm`, `msgTo`) VALUES
(1, 1, 2),
(2, 2, 4),
(3, 2, 6),
(4, 1, 6),
(5, 4, 6),
(6, 1, 19),
(8, 8, 4),
(9, 19, 4);

-- --------------------------------------------------------

--
-- Table structure for table `membertable`
--

CREATE TABLE `membertable` (
  `mem_id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `user_name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=armscii8;

--
-- Dumping data for table `membertable`
--

INSERT INTO `membertable` (`mem_id`, `name`, `email`, `user_name`, `password`) VALUES
(1, 'ashique imran', 'imranashik50@gmail.com', 'ashik50', '7794'),
(2, 'pial paul', 'pial771@gmail.com ', 'pial771', '353535'),
(4, 'abrar shariar', 'shariarabrar@gmail.com ', 'shariarabrar', 'abrar22'),
(6, 'azizur rahman', 'anhonestdevil@gmail.com', 'ananda', '353535'),
(8, 'purba das gupta', 'purbadasgupta66@gmail.com ', 'purbadasgupta66', 'purba18'),
(10, 'edf', 'ewf', 'ewf', 'ewf'),
(13, 'df', 'defr', 'erf', 'b b'),
(14, 'reg', 'reg', 'rg', 'ppp'),
(18, 'abc', 'abc', 'abc', '12345'),
(19, 'sohan chowdhury', 'sohanchy@gmail.com', 'sohanchy', '1212'),
(20, 'jbdlkfv', 'hvclsdjbkfgih', 'lhdbvlkfd', '1212'),
(21, 'asdsd', 'sdfcsdfs', 'gdfdgret', 'jkophitj'),
(22, 'erfg', 'erg', 'erg', 'erg');

-- --------------------------------------------------------

--
-- Table structure for table `msgtable`
--

CREATE TABLE `msgtable` (
  `con_id` int(11) NOT NULL,
  `msg_form` int(11) NOT NULL,
  `msg_to` int(11) NOT NULL,
  `text` text NOT NULL,
  `datetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `msgtable`
--

INSERT INTO `msgtable` (`con_id`, `msg_form`, `msg_to`, `text`, `datetime`) VALUES
(1, 1, 2, 'Hi Friend, how are you?', '2017-08-02 13:29:53'),
(3, 2, 1, 'Fine. what about you? ', '2017-08-18 15:50:15'),
(4, 1, 2, 'Yeah ! Everything going well. like to go to class tomorrow?', '2017-08-18 15:54:51'),
(6, 2, 1, 'Yeah there is a quiz i have to', '2017-08-18 16:13:03'),
(7, 1, 2, 'ok! got it. is that TOC quiz?', '2017-08-18 16:15:35'),
(8, 2, 1, 'humn. As far as I know you have a quiz also..', '2017-08-18 16:16:42'),
(9, 1, 2, 'I have math5 quiz. you know.', '2017-08-18 17:40:17'),
(10, 2, 1, 'i heard that is easy', '2017-08-18 17:43:38');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `convtable`
--
ALTER TABLE `convtable`
  ADD PRIMARY KEY (`conId`);

--
-- Indexes for table `membertable`
--
ALTER TABLE `membertable`
  ADD PRIMARY KEY (`mem_id`),
  ADD UNIQUE KEY `email` (`email`,`user_name`),
  ADD UNIQUE KEY `user_name` (`user_name`);

--
-- Indexes for table `msgtable`
--
ALTER TABLE `msgtable`
  ADD UNIQUE KEY `con_id` (`con_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `convtable`
--
ALTER TABLE `convtable`
  MODIFY `conId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `membertable`
--
ALTER TABLE `membertable`
  MODIFY `mem_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
--
-- AUTO_INCREMENT for table `msgtable`
--
ALTER TABLE `msgtable`
  MODIFY `con_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
