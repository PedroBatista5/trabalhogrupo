-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: mydb
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

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
-- Table structure for table `tb_animal`
--

DROP TABLE IF EXISTS `tb_animal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_animal` (
  `id_animal` int(11) NOT NULL AUTO_INCREMENT,
  `nome_dono` varchar(90) DEFAULT NULL,
  `contacto_dono` varchar(9) DEFAULT NULL,
  `data_nascimento` date NOT NULL,
  `data_ultima_consulta` date DEFAULT NULL,
  `tipo_animal` varchar(50) NOT NULL,
  `raça` varchar(80) NOT NULL,
  `sexo` varchar(20) NOT NULL,
  `peso` double NOT NULL,
  PRIMARY KEY (`id_animal`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_animal`
--

LOCK TABLES `tb_animal` WRITE;
/*!40000 ALTER TABLE `tb_animal` DISABLE KEYS */;
INSERT INTO `tb_animal` VALUES (4,'Catarina','905968455','2024-02-07','2024-03-30','Cão','Golden Retriver','Macho',10),(5,'João','919877533','2024-02-06','2024-03-06','Gato','Indefinido','Fêmea',7),(6,'Cátia','919888534','2024-02-22','2024-04-01','Cão','Pitbull','Fêmea',16);
/*!40000 ALTER TABLE `tb_animal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_consulta`
--

DROP TABLE IF EXISTS `tb_consulta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_consulta` (
  `id_consulta` int(11) NOT NULL AUTO_INCREMENT,
  `id_animal` int(11) NOT NULL,
  `data_consulta` date NOT NULL,
  `tipo_consulta` varchar(45) DEFAULT NULL,
  `nome_medico` varchar(60) NOT NULL,
  `diagnostico` varchar(120) DEFAULT NULL,
  `ato_medico` varchar(70) DEFAULT NULL,
  `peso` double DEFAULT NULL,
  `observacoes` varchar(120) DEFAULT NULL,
  `prescricao_medica` varchar(80) DEFAULT NULL,
  `prox_visita` date DEFAULT NULL,
  PRIMARY KEY (`id_consulta`),
  KEY `id_animal` (`id_animal`),
  CONSTRAINT `id_animal` FOREIGN KEY (`id_animal`) REFERENCES `tb_animal` (`id_animal`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_consulta`
--

LOCK TABLES `tb_consulta` WRITE;
/*!40000 ALTER TABLE `tb_consulta` DISABLE KEYS */;
INSERT INTO `tb_consulta` VALUES (1,4,'2024-04-11','Verificação','Joana','','',14,'','','2024-04-24');
/*!40000 ALTER TABLE `tb_consulta` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-26 20:39:50
