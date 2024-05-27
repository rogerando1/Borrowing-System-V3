-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: sql6.freemysqlhosting.net    Database: sql6690575
-- ------------------------------------------------------
-- Server version	5.5.62-0ubuntu0.14.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Accounts`
--

DROP TABLE IF EXISTS `Accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Accounts` (
  `personID` int(11) DEFAULT NULL,
  `accountID` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) DEFAULT NULL,
  `password_` varchar(255) DEFAULT NULL,
  `position` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`accountID`),
  KEY `Accounts_ibfk_1` (`personID`),
  CONSTRAINT `Accounts_ibfk_1` FOREIGN KEY (`personID`) REFERENCES `Person` (`personID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Accounts`
--

LOCK TABLES `Accounts` WRITE;
/*!40000 ALTER TABLE `Accounts` DISABLE KEYS */;
INSERT INTO `Accounts` VALUES (3,0,'keneth.klein','kklein','Admin'),(1,1,'rogerando','123123','Admin'),(4,3,'joshua.lance','jlance','Staff'),(124,24,'jarvis.test','123123','Admin');
/*!40000 ALTER TABLE `Accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AddCart`
--

DROP TABLE IF EXISTS `AddCart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `AddCart` (
  `cartID` int(11) NOT NULL AUTO_INCREMENT,
  `studentID` varchar(255) DEFAULT NULL,
  `instructorID` varchar(255) DEFAULT NULL,
  `accountID` int(11) DEFAULT NULL,
  `partID` int(11) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `orderdate` date DEFAULT NULL,
  `ordertime` time DEFAULT NULL,
  `status_` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`cartID`),
  KEY `AddCart_ibfk_1` (`studentID`),
  KEY `AddCart_ibfk_2` (`instructorID`),
  KEY `AddCart_ibfk_3` (`accountID`),
  KEY `AddCart_ibfk_4_idx` (`partID`),
  CONSTRAINT `AddCart_ibfk_4` FOREIGN KEY (`partID`) REFERENCES `Part` (`partID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `AddCart_ibfk_1` FOREIGN KEY (`studentID`) REFERENCES `Student` (`studentID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `AddCart_ibfk_2` FOREIGN KEY (`instructorID`) REFERENCES `Instructor` (`instructorID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `AddCart_ibfk_3` FOREIGN KEY (`accountID`) REFERENCES `Accounts` (`accountID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=203 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AddCart`
--

LOCK TABLES `AddCart` WRITE;
/*!40000 ALTER TABLE `AddCart` DISABLE KEYS */;
/*!40000 ALTER TABLE `AddCart` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Course`
--

DROP TABLE IF EXISTS `Course`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Course` (
  `courseID` varchar(255) NOT NULL DEFAULT '',
  `coursename` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`courseID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Course`
--

LOCK TABLES `Course` WRITE;
/*!40000 ALTER TABLE `Course` DISABLE KEYS */;
INSERT INTO `Course` VALUES ('CPE333','Basic Occupational Safety and Health'),('CPE461','Embedded Systems'),('CPE462','CPE Practice and Design 2'),('CPE465','Digital Signal Processing'),('CPECC481','CPE Comprehensive Evaluation Course 1'),('CPEPE463/SD','Software Development 3');
/*!40000 ALTER TABLE `Course` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `CourseTime`
--

DROP TABLE IF EXISTS `CourseTime`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `CourseTime` (
  `coursetimeID` int(11) NOT NULL AUTO_INCREMENT,
  `courseID` varchar(45) DEFAULT NULL,
  `instructorID` varchar(45) DEFAULT NULL,
  `startTime` time DEFAULT NULL,
  `endTime` time DEFAULT NULL,
  `section` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`coursetimeID`),
  KEY `courseID_idx` (`courseID`),
  KEY `instructorID_idx` (`instructorID`),
  CONSTRAINT `courseID` FOREIGN KEY (`courseID`) REFERENCES `Course` (`courseID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `instructorID` FOREIGN KEY (`instructorID`) REFERENCES `Instructor` (`instructorID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `CourseTime`
--

LOCK TABLES `CourseTime` WRITE;
/*!40000 ALTER TABLE `CourseTime` DISABLE KEYS */;
INSERT INTO `CourseTime` VALUES (36,'CPE462','66-4123-266','09:00:00','15:00:00','H1'),(37,'CPE461','12-1151-233','23:00:00','23:30:00','H2'),(38,'CPE333','61-6542-112','08:30:00','12:00:00','H1'),(40,'CPE333','11-3421-512','10:00:00','23:59:00','H2'),(41,'CPE461','12-1151-233','15:20:00','18:00:00','H3'),(42,'CPE461','66-4123-266','15:10:00','16:10:00','H5'),(44,'CPE461','66-4123-266','15:10:00','18:10:00','H7'),(45,'CPE333','45-1123-112','08:00:00','23:00:00','H7'),(46,'CPE333','45-1123-112','08:00:00','12:00:00','H8'),(47,'CPE333','11-3421-512','15:02:00','17:01:00','H9'),(48,'CPE333','11-3421-512','17:02:00','19:10:00','H10'),(49,'CPE462','11-3421-512','00:00:00','12:00:00','H5');
/*!40000 ALTER TABLE `CourseTime` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Instructor`
--

DROP TABLE IF EXISTS `Instructor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Instructor` (
  `instructorID` varchar(255) NOT NULL DEFAULT '',
  `personID` int(11) DEFAULT NULL,
  PRIMARY KEY (`instructorID`),
  KEY `Instructor_ibfk_1` (`personID`),
  CONSTRAINT `Instructor_ibfk_1` FOREIGN KEY (`personID`) REFERENCES `Person` (`personID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Instructor`
--

LOCK TABLES `Instructor` WRITE;
/*!40000 ALTER TABLE `Instructor` DISABLE KEYS */;
INSERT INTO `Instructor` VALUES ('11-3421-512',5),('45-1123-112',6),('12-1151-233',7),('61-6542-112',8),('66-4123-266',9);
/*!40000 ALTER TABLE `Instructor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Part`
--

DROP TABLE IF EXISTS `Part`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Part` (
  `productID` int(11) DEFAULT NULL,
  `partID` int(11) NOT NULL AUTO_INCREMENT,
  `partname` varchar(255) DEFAULT NULL,
  `partdescription` varchar(255) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `condition` int(11) DEFAULT NULL,
  PRIMARY KEY (`partID`),
  KEY `Part_ibfk_1` (`productID`),
  CONSTRAINT `Part_ibfk_1` FOREIGN KEY (`productID`) REFERENCES `Product` (`productID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1354 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Part`
--

LOCK TABLES `Part` WRITE;
/*!40000 ALTER TABLE `Part` DISABLE KEYS */;
/*!40000 ALTER TABLE `Part` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Person`
--

DROP TABLE IF EXISTS `Person`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Person` (
  `personID` int(11) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(255) DEFAULT NULL,
  `middleinitial` varchar(255) DEFAULT NULL,
  `lastname` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`personID`)
) ENGINE=InnoDB AUTO_INCREMENT=133 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Person`
--

LOCK TABLES `Person` WRITE;
/*!40000 ALTER TABLE `Person` DISABLE KEYS */;
INSERT INTO `Person` VALUES (1,'Roger','R','Ando'),(2,'Jeannelyn','C','Obero'),(3,'Keneth Klein','','Bardilass'),(4,'Joshua','L','Llopes'),(5,'Johnalyn','L','Figueras'),(6,'Jundith','D','Alterado'),(7,'Stephanie Grace','F','Villarubia'),(8,'Julian','N','Semblante'),(9,'Mervin','A','Tampus'),(104,'Test','C','Test'),(108,'Gera','','Cards'),(109,'Jarvis','J','Test'),(120,'TEST','a','awdawd'),(121,'TEST','d','awd'),(122,'TEST','A','TEST'),(123,'Jarvis','A','Test'),(124,'Jarvis','C','Test'),(125,'dawf','a','awd'),(126,'awfawd','d','d'),(127,'dwafawdaw','a','a'),(128,'Test','t','teasdawd'),(129,'Keneth','C','Bardila'),(130,'San','M','iguel'),(131,'John','J','Pol'),(132,'Kent','P','Sy');
/*!40000 ALTER TABLE `Person` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Product`
--

DROP TABLE IF EXISTS `Product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Product` (
  `productID` int(11) NOT NULL AUTO_INCREMENT,
  `productname` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`productID`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Product`
--

LOCK TABLES `Product` WRITE;
/*!40000 ALTER TABLE `Product` DISABLE KEYS */;
INSERT INTO `Product` VALUES (0,'IC'),(1,'TRANSISTORS'),(2,'FUSE'),(3,'OPERATION AMPLIFIERS'),(4,'OPTOCOUPLERS'),(5,'SENSORS'),(6,'VOLTAGE REGULATORS'),(7,'LED'),(8,'VOLTAGE CONVERTERS'),(9,'DIODES'),(10,'7-SEGMENT DISPLAY'),(11,'RELAY SWITCH'),(12,'SWITCHES'),(13,'MICROCONTROLLERS'),(14,'VARIABLE RESISTORS'),(15,'VARIABLE RESISTOR ( POTENTIOMETER)'),(16,'RESISTORS'),(17,'MOTORS'),(18,'OTHER CONSUMABLES'),(19,'CAPACITOR MYLAR'),(20,'CAPACITOR CERAMIC'),(21,'CAPACITOR ELECTROLYTIC');
/*!40000 ALTER TABLE `Product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Student`
--

DROP TABLE IF EXISTS `Student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Student` (
  `personID` int(11) DEFAULT NULL,
  `studentID` varchar(255) NOT NULL DEFAULT '',
  `program` varchar(255) DEFAULT NULL,
  `yearlevel` int(11) DEFAULT NULL,
  PRIMARY KEY (`studentID`),
  KEY `Student_ibfk_1` (`personID`),
  CONSTRAINT `Student_ibfk_1` FOREIGN KEY (`personID`) REFERENCES `Person` (`personID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Student`
--

LOCK TABLES `Student` WRITE;
/*!40000 ALTER TABLE `Student` DISABLE KEYS */;
INSERT INTO `Student` VALUES (132,'12-3456-789','BSCPE',5),(108,'18-1154-645','BSCPE',4),(131,'18-26254-463','BSCPE',4),(130,'22-2222-222','BSCPE',4);
/*!40000 ALTER TABLE `Student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `TransactionLogs`
--

DROP TABLE IF EXISTS `TransactionLogs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `TransactionLogs` (
  `transactionlogID` int(11) NOT NULL AUTO_INCREMENT,
  `transactionID` int(11) DEFAULT NULL,
  `returndate` date DEFAULT NULL,
  `returntime` time DEFAULT NULL,
  `notes` varchar(255) DEFAULT NULL,
  `receiverID` int(11) DEFAULT NULL,
  `releaserID` int(11) DEFAULT NULL,
  PRIMARY KEY (`transactionlogID`),
  KEY `TransactionLogs_ibfk_1` (`transactionID`),
  KEY `TransactionLogs_ibfk_2` (`receiverID`),
  KEY `TransactionLogs_ibfk_3` (`releaserID`),
  CONSTRAINT `TransactionLogs_ibfk_3` FOREIGN KEY (`releaserID`) REFERENCES `Accounts` (`accountID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `TransactionLogs_ibfk_1` FOREIGN KEY (`transactionID`) REFERENCES `Transactions` (`transactionID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `TransactionLogs_ibfk_2` FOREIGN KEY (`receiverID`) REFERENCES `Accounts` (`accountID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=67 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `TransactionLogs`
--

LOCK TABLES `TransactionLogs` WRITE;
/*!40000 ALTER TABLE `TransactionLogs` DISABLE KEYS */;
/*!40000 ALTER TABLE `TransactionLogs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Transactions`
--

DROP TABLE IF EXISTS `Transactions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Transactions` (
  `transactionID` int(11) NOT NULL AUTO_INCREMENT,
  `studentID` varchar(255) DEFAULT NULL,
  `instructorID` varchar(255) DEFAULT NULL,
  `accountID` int(11) DEFAULT NULL,
  `partID` int(11) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `orderdate` date DEFAULT NULL,
  `ordertime` time DEFAULT NULL,
  `status_` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`transactionID`),
  KEY `Transactions_ibfk_1` (`studentID`),
  KEY `Transactions_ibfk_2` (`instructorID`),
  KEY `Transactions_ibfk_3` (`accountID`),
  KEY `Transactions_ibfk_4_idx` (`partID`),
  CONSTRAINT `Transactions_ibfk_4` FOREIGN KEY (`partID`) REFERENCES `Part` (`partID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Transactions_ibfk_1` FOREIGN KEY (`studentID`) REFERENCES `Student` (`studentID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Transactions_ibfk_2` FOREIGN KEY (`instructorID`) REFERENCES `Instructor` (`instructorID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Transactions_ibfk_3` FOREIGN KEY (`accountID`) REFERENCES `Accounts` (`accountID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=207 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Transactions`
--

LOCK TABLES `Transactions` WRITE;
/*!40000 ALTER TABLE `Transactions` DISABLE KEYS */;
/*!40000 ALTER TABLE `Transactions` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-27 13:30:07
