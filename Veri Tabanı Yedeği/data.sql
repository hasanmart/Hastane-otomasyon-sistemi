-- MySQL dump 10.16  Distrib 10.1.48-MariaDB, for debian-linux-gnu (x86_64)
--
-- Host: localhost    Database: db
-- ------------------------------------------------------
-- Server version	10.1.48-MariaDB-0+deb9u2

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `dbo.DoktorTBL`
--

DROP TABLE IF EXISTS `dbo.DoktorTBL`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.DoktorTBL` (
  `docID` varchar(0) DEFAULT NULL,
  `docName` varchar(0) DEFAULT NULL,
  `docDob` varchar(0) DEFAULT NULL,
  `docCs` varchar(0) DEFAULT NULL,
  `docUzm` varchar(0) DEFAULT NULL,
  `docDeneyim` varchar(0) DEFAULT NULL,
  `docTel` varchar(0) DEFAULT NULL,
  `docAdres` varchar(0) DEFAULT NULL,
  `docPass` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.DoktorTBL`
--

LOCK TABLES `dbo.DoktorTBL` WRITE;
/*!40000 ALTER TABLE `dbo.DoktorTBL` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.DoktorTBL` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.HastaTBL`
--

DROP TABLE IF EXISTS `dbo.HastaTBL`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.HastaTBL` (
  `hastaID` varchar(0) DEFAULT NULL,
  `hastaAD` varchar(0) DEFAULT NULL,
  `hastaCS` varchar(0) DEFAULT NULL,
  `hastaTARİH` varchar(0) DEFAULT NULL,
  `hastaEKLE` varchar(0) DEFAULT NULL,
  `hastaTEL` varchar(0) DEFAULT NULL,
  `hastaHIV` varchar(0) DEFAULT NULL,
  `hastaALG` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.HastaTBL`
--

LOCK TABLES `dbo.HastaTBL` WRITE;
/*!40000 ALTER TABLE `dbo.HastaTBL` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.HastaTBL` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.TestTBL`
--

DROP TABLE IF EXISTS `dbo.TestTBL`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.TestTBL` (
  `testNum` varchar(0) DEFAULT NULL,
  `testName` varchar(0) DEFAULT NULL,
  `testCost` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.TestTBL`
--

LOCK TABLES `dbo.TestTBL` WRITE;
/*!40000 ALTER TABLE `dbo.TestTBL` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.TestTBL` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.presTBL`
--

DROP TABLE IF EXISTS `dbo.presTBL`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.presTBL` (
  `presID` varchar(0) DEFAULT NULL,
  `docID` varchar(0) DEFAULT NULL,
  `docAd` varchar(0) DEFAULT NULL,
  `hastaID` varchar(0) DEFAULT NULL,
  `hastaAD` varchar(0) DEFAULT NULL,
  `labtestID` varchar(0) DEFAULT NULL,
  `labtestAd` varchar(0) DEFAULT NULL,
  `ilaclar` varchar(0) DEFAULT NULL,
  `maliyet` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.presTBL`
--

LOCK TABLES `dbo.presTBL` WRITE;
/*!40000 ALTER TABLE `dbo.presTBL` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.presTBL` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.resTBL`
--

DROP TABLE IF EXISTS `dbo.resTBL`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.resTBL` (
  `resID` varchar(0) DEFAULT NULL,
  `resAd` varchar(0) DEFAULT NULL,
  `resTel` varchar(0) DEFAULT NULL,
  `resAdres` varchar(0) DEFAULT NULL,
  `resPas` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.resTBL`
--

LOCK TABLES `dbo.resTBL` WRITE;
/*!40000 ALTER TABLE `dbo.resTBL` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.resTBL` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.sysdiagrams`
--

DROP TABLE IF EXISTS `dbo.sysdiagrams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.sysdiagrams` (
  `name` varchar(0) DEFAULT NULL,
  `principal_id` varchar(0) DEFAULT NULL,
  `diagram_id` varchar(0) DEFAULT NULL,
  `version` varchar(0) DEFAULT NULL,
  `definition` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.sysdiagrams`
--

LOCK TABLES `dbo.sysdiagrams` WRITE;
/*!40000 ALTER TABLE `dbo.sysdiagrams` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.sysdiagrams` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-09-18 10:46:26
