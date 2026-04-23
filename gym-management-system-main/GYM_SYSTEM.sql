-- MySQL dump 10.13  Distrib 8.0.45, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mydb
-- ------------------------------------------------------
-- Server version	8.0.45

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
-- Table structure for table `membership_records`
--

DROP TABLE IF EXISTS `membership_records`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `membership_records` (
  `MEMBER_ID` int NOT NULL AUTO_INCREMENT,
  `CODE` varchar(50) DEFAULT NULL,
  `NAME` varchar(50) DEFAULT NULL,
  `PHONE_NUMBER` varchar(50) DEFAULT NULL,
  `TYPE` varchar(50) DEFAULT NULL,
  `STATUS` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`MEMBER_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `membership_records`
--

LOCK TABLES `membership_records` WRITE;
/*!40000 ALTER TABLE `membership_records` DISABLE KEYS */;
INSERT INTO `membership_records` VALUES (1,'GYM012026-652','Patrick Ong','09811326152','VIP','Inactive'),(2,'GYM012026-139','Kevin Bautista','09423219859','VIP','Active'),(3,'GYM012026-478','Leo Torres','09621997855','VIP','Active'),(4,'GYM012026-612','Jenny Lim','09487773362','VIP','Active'),(5,'GYM012026-231','Marco Castillo','09998389549','Regular','Inactive'),(6,'GYM012026-328','Grace Fajardo','09538364218','VIP','Inactive'),(7,'GYM012026-204','Ella Gutierrez','09168017878','Regular','Active'),(8,'GYM012026-496','Adrian Aquino','09429474520','Regular','Active'),(9,'GYM012026-758','Denise Dominguez','09528979394','VIP','Active'),(10,'GYM012026-171','Denise Estrada','09406646693','VIP','Active'),(11,'GYM012026-409','Grace Alonzo','09851835175','VIP','Inactive'),(12,'GYM012026-908','Karen Bautista','09272305776','VIP','Active'),(13,'GYM012026-777','Ethan Pineda','09656737001','VIP','Inactive'),(14,'GYM012026-235','Paul Torres','09933461703','VIP','Inactive'),(15,'GYM012026-459','Paul Santos','09741417082','VIP','Active'),(16,'GYM012026-819','Bianca Garcia','09150906457','Regular','Active'),(17,'GYM012026-781','Chloe Ong','09039125669','VIP','Active'),(18,'GYM012026-949','Bianca Reyes','09573210128','VIP','Active'),(19,'GYM012026-558','Carlo Mendoza','09005127622','Regular','Inactive'),(20,'GYM012026-412','Mark Delgado','09729951978','VIP','Inactive'),(21,'GYM012026-672','Grace Villanueva','09241291661','Regular','Inactive'),(22,'GYM012026-523','Mia Pineda','09700915125','VIP','Inactive'),(23,'GYM012026-839','Mia Gutierrez','09149637057','Regular','Inactive'),(24,'GYM012026-175','Angela Salazar','09527344506','VIP','Active'),(25,'GYM012026-449','Bianca Gutierrez','09700268329','Regular','Inactive'),(26,'GYM012026-651','Victor Delgado','09040192957','Regular','Active'),(27,'GYM012026-542','Patrick Bautista','09686491518','VIP','Inactive'),(28,'GYM012026-269','Daniel Fajardo','09090115618','Regular','Inactive'),(29,'GYM012026-356','Bianca Ramos','09321019224','Regular','Active'),(30,'GYM012026-920','John Navarro','09884368057','VIP','Inactive');
/*!40000 ALTER TABLE `membership_records` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `UID` int NOT NULL AUTO_INCREMENT,
  `CODE` varchar(50) NOT NULL,
  `NAME` varchar(50) DEFAULT NULL,
  `EMAIL` varchar(50) DEFAULT NULL,
  `PASSWORD` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`UID`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'GYM012026-107','Paul Delgado','paul.delgado11@gmail.com','Paul11'),(2,'GYM012026-134','Grace Gutierrez','grace.gutierrez19@gmail.com','Grace19'),(3,'GYM012026-246','Ethan Navarro','ethan.navarro6@gmail.com','Ethan6'),(4,'GYM012026-250','Daniel Alonzo','daniel.alonzo26@gmail.com','Daniel26'),(5,'GYM012026-317','Chloe Ramos','chloe.ramos23@gmail.com','Chloe23'),(6,'GYM012026-353','Liza Delgado','liza.delgado4@gmail.com','Liza4'),(7,'GYM012026-358','Liza Soriano','liza.soriano20@gmail.com','Liza20'),(8,'GYM012026-400','Chloe DelaCruz','chloe.delacruz10@gmail.com','Chloe10'),(9,'GYM012026-444','John Robles','john.robles25@gmail.com','John25'),(10,'GYM012026-478','Sofia Garcia','sofia.garcia28@gmail.com','Sofia28'),(11,'GYM012026-516','James Ramos','james.ramos29@gmail.com','James29'),(12,'GYM012026-568','Mark Ramos','mark.ramos9@gmail.com','Mark9'),(13,'GYM012026-582','Ethan Garcia','ethan.garcia5@gmail.com','Ethan5'),(14,'GYM012026-604','Ryan Villanueva','ryan.villanueva18@gmail.com','Ryan18'),(15,'GYM012026-646','Chloe Delgado','chloe.delgado1@gmail.com','Chloe1'),(16,'GYM012026-658','Daniel Garcia','daniel.garcia14@gmail.com','Daniel14'),(17,'GYM012026-673','Camille Robles','camille.robles7@gmail.com','Camille7'),(18,'GYM012026-692','Paul Dominguez','paul.dominguez12@gmail.com','Paul12'),(19,'GYM012026-740','Joshua Cruz','joshua.cruz17@gmail.com','Joshua17'),(20,'GYM012026-753','Maria Estrada','maria.estrada30@gmail.com','Maria30'),(21,'GYM012026-797','Paul Lopez','paul.lopez15@gmail.com','Paul15'),(22,'GYM012026-800','Grace Navarro','grace.navarro13@gmail.com','Grace13'),(23,'GYM012026-827','Liza Lim','liza.lim24@gmail.com','Liza24'),(24,'GYM012026-829','Liza Salazar','liza.salazar27@gmail.com','Liza27'),(25,'GYM012026-853','Chloe Dominguez','chloe.dominguez8@gmail.com','Chloe8'),(26,'GYM012026-862','Grace Reyes','grace.reyes2@gmail.com','Grace2'),(27,'GYM012026-897','James Alonzo','james.alonzo16@gmail.com','James16'),(28,'GYM012026-909','Angela Fajardo','angela.fajardo3@gmail.com','Angela3'),(29,'GYM012026-946','Leo Chavez','leo.chavez22@gmail.com','Leo22'),(30,'GYM012026-981','Jenny Villanueva','jenny.villanueva21@gmail.com','Jenny21');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-04-18 18:54:24
