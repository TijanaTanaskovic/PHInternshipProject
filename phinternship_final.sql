-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Mar 12, 2023 at 08:35 PM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `phinternship`
--

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
CREATE TABLE IF NOT EXISTS `employee` (
  `employee_ID` int(255) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `phone_number` varchar(255) NOT NULL,
  `date_of_birth` date NOT NULL,
  `monthly_salary` int(11) NOT NULL,
  PRIMARY KEY (`employee_ID`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`employee_ID`, `first_name`, `last_name`, `email`, `phone_number`, `date_of_birth`, `monthly_salary`) VALUES
(1, 'Tamara', 'Markovic', 'tmarkovic@gmail.com', '0611234569', '1998-05-10', 500),
(5, 'Jovana', 'Matic', 'matic@gmail.com', '0612345698', '2000-01-01', 1000),
(6, 'Nevenka', 'Jovic', 'nena@gmail.com', '06689532', '1990-06-15', 2200),
(3, 'Marko', 'Markovic', 'markic1@gmail.com', '0601234565', '2000-02-01', 600),
(9, 'Milena', 'Radulovic', 'milenica@gmail.com', '069999852', '1993-04-21', 1000),
(10, 'Anica', 'Dimitrijevic', 'anicad92@gmail.com', '068259259', '1992-02-02', 650),
(11, 'Mateja', 'Mircic', 'matejamm@gmail.com', '063256984', '2001-08-14', 699),
(12, 'Ognjen', 'Ognjenovic', 'ogica@gmail.com', '063987463', '1998-02-07', 3000),
(13, 'Dimitrije', 'Vasic', 'vaske@gmail.com', '0647251836', '1996-06-08', 1000),
(14, 'Maja', 'Eric', 'eric@gmail.com', '061234556', '2023-03-07', 1111);

-- --------------------------------------------------------

--
-- Table structure for table `project`
--

DROP TABLE IF EXISTS `project`;
CREATE TABLE IF NOT EXISTS `project` (
  `projectID` int(11) NOT NULL AUTO_INCREMENT,
  `project_name` varchar(255) NOT NULL,
  `project_description` varchar(255) NOT NULL,
  PRIMARY KEY (`projectID`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `project`
--

INSERT INTO `project` (`projectID`, `project_name`, `project_description`) VALUES
(1, 'Integer lobortis', 'Morbi ut enim congue, facilisis lectus id, pharetra nunc. Curabitur porttitor dolor non quam venenatis iaculis.'),
(2, 'Fusce volutpat', 'Curabitur in magna auctor, maximus ex sodales, vehicula ante.'),
(3, 'Vivamus lacinia', 'Nunc quis mauris luctus, sodales justo dignissim, elementum ligula.'),
(4, 'Etiam sit amet ', 'Nulla ultricies nisi tempus dolor tristique, pharetra viverra nunc volutpat.');

-- --------------------------------------------------------

--
-- Table structure for table `task`
--

DROP TABLE IF EXISTS `task`;
CREATE TABLE IF NOT EXISTS `task` (
  `task_ID` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  `assignee` int(11) NOT NULL,
  `due_date` date NOT NULL,
  `project_id` int(11) NOT NULL,
  PRIMARY KEY (`task_ID`)
) ENGINE=MyISAM AUTO_INCREMENT=36 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `task`
--

INSERT INTO `task` (`task_ID`, `title`, `description`, `assignee`, `due_date`, `project_id`) VALUES
(1, 'Data changes', 'Change the data in the employee section in the database with the current information.', 1, '2023-01-25', 1),
(2, 'Design changes', 'Change the design of these pages: blablabla and blablabla2.', 3, '2023-01-17', 2),
(6, 'Lorem ipsum', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam vehicula.', 3, '2023-02-05', 3),
(5, 'Vestibulum lobortis sapien quis', 'Nam magna una, aliquet a nunc nec, lobortis elementum elit. Vestibulum efficitur quam non tincidunt blandit. ', 5, '2023-02-06', 4),
(7, 'Ut luctus', 'Phasellus vel sollicitudin nibh, id elementum massa. Fusce vel lorem.', 10, '2023-03-01', 3),
(8, 'Nullam id', 'Nam pellentesque lorem lacinia turpis ultrices, ut sollicitudin.', 12, '2023-03-02', 1),
(10, 'Etiam tempus', 'Nullam auctor mauris ipsum, sed egestas neque condimentum.', 5, '2023-02-22', 2),
(11, 'Ut sit amet', 'Cras diam orci, tristique vitae nisl quis, vulputate bibendum risus.', 10, '2023-02-28', 1),
(12, ' Donec ut tristique ex', 'Nulla auctor lobortis pulvinar.', 10, '2023-03-06', 3),
(13, 'Maecenaas', 'Duis aliquam sem sit amet nulla elementum suscipit nec nec ligula. ', 11, '2023-02-26', 4),
(14, 'Proin nec', 'Quisque vitae erat faucibus, placerat magna vel.', 13, '2023-01-16', 2),
(15, 'Aenean at', 'Curabitur fringilla justo quis leo eleifend, ac cursus enim scelerisque.', 3, '2023-03-06', 2),
(16, 'Pellentesque', 'Phasellus posuere feugiat nunc sed mattis.', 5, '2023-02-20', 1),
(17, 'Vivamus sed', 'Aliquam ac lectus faucibus, luctus nisl a, condimentum eros.', 10, '2023-02-23', 1),
(18, 'Aenean nec', 'Aenean nec velit blandit massa vehicula ornare. ', 10, '2023-03-22', 1),
(19, 'Vestibulum', 'Vehicula elit mauris, sed vestibulum lorem tristique quis. ', 10, '2023-02-16', 3),
(20, 'Suspendisse potenti', 'Sed non pulvinar nunc, non feugiat lectus.', 10, '2023-02-19', 4),
(21, 'Nam nibh massa', 'Accumsan ac quam vitae, vestibulum accumsan metus.', 11, '2023-02-25', 2),
(22, 'Nulla facilisi', 'Vestibulum ultrices augue turpis.', 12, '2023-02-01', 1),
(23, 'Nulla', 'Nulla varius cursus egestas.', 12, '2023-02-05', 3),
(24, 'Morbi nec ', 'Curabitur finibus lorem turpis, sed pharetra massa varius id.', 12, '2023-02-27', 4),
(25, 'Etiam', 'Interdum et malesuada fames ac ante ipsum primis in faucibus. ', 12, '2023-01-22', 2),
(26, 'Mauris sed erat', 'Etiam egestas viverra urna am consequat.\r\n', 5, '2023-03-06', 1),
(27, 'Cras eget', 'In neque lectus, fringilla non gravida quis, pharetra vitae felis.', 5, '2023-03-08', 1),
(34, 'New', 'Vivamus sollicitudin turpis quis ultrices sodales.', 9, '2023-03-11', 3),
(35, 'One', 'Donec porta est consectetur erat mollis facilisis.', 9, '2023-03-11', 4);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
