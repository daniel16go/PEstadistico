-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: productivo_dev
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20211201232937_InitialCreate','3.1.7'),('20211202041545_AddCutsRelation','3.1.7'),('20211202083502_UpdateYielMeatCutting','3.1.7');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `abnormalitydetails`
--

DROP TABLE IF EXISTS `abnormalitydetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `abnormalitydetails` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `AbnormalityTypesId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_AbnormalityDetails_AbnormalityTypesId` (`AbnormalityTypesId`),
  CONSTRAINT `FK_AbnormalityDetails_AbnormalityTypes_AbnormalityTypesId` FOREIGN KEY (`AbnormalityTypesId`) REFERENCES `abnormalitytypes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `abnormalitydetails`
--

LOCK TABLES `abnormalitydetails` WRITE;
/*!40000 ALTER TABLE `abnormalitydetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `abnormalitydetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `abnormalityplacedetails`
--

DROP TABLE IF EXISTS `abnormalityplacedetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `abnormalityplacedetails` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `AbnormalityPlacesId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_AbnormalityPlaceDetails_AbnormalityPlacesId` (`AbnormalityPlacesId`),
  CONSTRAINT `FK_AbnormalityPlaceDetails_AbnormalityPlaces_AbnormalityPlacesId` FOREIGN KEY (`AbnormalityPlacesId`) REFERENCES `abnormalityplaces` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `abnormalityplacedetails`
--

LOCK TABLES `abnormalityplacedetails` WRITE;
/*!40000 ALTER TABLE `abnormalityplacedetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `abnormalityplacedetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `abnormalityplaces`
--

DROP TABLE IF EXISTS `abnormalityplaces`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `abnormalityplaces` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `abnormalityplaces`
--

LOCK TABLES `abnormalityplaces` WRITE;
/*!40000 ALTER TABLE `abnormalityplaces` DISABLE KEYS */;
/*!40000 ALTER TABLE `abnormalityplaces` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `abnormalitytypes`
--

DROP TABLE IF EXISTS `abnormalitytypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `abnormalitytypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `AffectationsId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_AbnormalityTypes_AffectationsId` (`AffectationsId`),
  CONSTRAINT `FK_AbnormalityTypes_Affectations_AffectationsId` FOREIGN KEY (`AffectationsId`) REFERENCES `affectations` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `abnormalitytypes`
--

LOCK TABLES `abnormalitytypes` WRITE;
/*!40000 ALTER TABLE `abnormalitytypes` DISABLE KEYS */;
/*!40000 ALTER TABLE `abnormalitytypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `affectations`
--

DROP TABLE IF EXISTS `affectations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `affectations` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `Initials` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `affectations`
--

LOCK TABLES `affectations` WRITE;
/*!40000 ALTER TABLE `affectations` DISABLE KEYS */;
/*!40000 ALTER TABLE `affectations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `areas`
--

DROP TABLE IF EXISTS `areas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `areas` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `areas`
--

LOCK TABLES `areas` WRITE;
/*!40000 ALTER TABLE `areas` DISABLE KEYS */;
/*!40000 ALTER TABLE `areas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetroleclaims`
--

DROP TABLE IF EXISTS `aspnetroleclaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetroleclaims` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `RoleId` varchar(256) NOT NULL,
  `ClaimType` text,
  `ClaimValue` text,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroleclaims`
--

LOCK TABLES `aspnetroleclaims` WRITE;
/*!40000 ALTER TABLE `aspnetroleclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetroleclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetroles`
--

DROP TABLE IF EXISTS `aspnetroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetroles` (
  `Id` varchar(256) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` text,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`NormalizedName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroles`
--

LOCK TABLES `aspnetroles` WRITE;
/*!40000 ALTER TABLE `aspnetroles` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserclaims`
--

DROP TABLE IF EXISTS `aspnetuserclaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetuserclaims` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `UserId` varchar(256) NOT NULL,
  `ClaimType` text,
  `ClaimValue` text,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetUserClaims_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserclaims`
--

LOCK TABLES `aspnetuserclaims` WRITE;
/*!40000 ALTER TABLE `aspnetuserclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserlogins`
--

DROP TABLE IF EXISTS `aspnetuserlogins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(256) NOT NULL,
  `ProviderKey` varchar(256) NOT NULL,
  `ProviderDisplayName` text,
  `UserId` varchar(256) NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  KEY `IX_AspNetUserLogins_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserlogins`
--

LOCK TABLES `aspnetuserlogins` WRITE;
/*!40000 ALTER TABLE `aspnetuserlogins` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserlogins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserroles`
--

DROP TABLE IF EXISTS `aspnetuserroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(256) NOT NULL,
  `RoleId` varchar(256) NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IX_AspNetUserRoles_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserroles`
--

LOCK TABLES `aspnetuserroles` WRITE;
/*!40000 ALTER TABLE `aspnetuserroles` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusers`
--

DROP TABLE IF EXISTS `aspnetusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetusers` (
  `Id` varchar(256) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` bit(1) NOT NULL,
  `PasswordHash` text,
  `SecurityStamp` text,
  `ConcurrencyStamp` text,
  `PhoneNumber` text,
  `PhoneNumberConfirmed` bit(1) NOT NULL,
  `TwoFactorEnabled` bit(1) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` bit(1) NOT NULL,
  `AccessFailedCount` int NOT NULL,
  `FirstName` varchar(80) NOT NULL,
  `CompanyId` int NOT NULL,
  `Position` varchar(80) NOT NULL,
  `FilePath` text,
  `CompaniesId` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  KEY `IX_AspNetUsers_CompaniesId` (`CompaniesId`),
  KEY `EmailIndex` (`NormalizedEmail`),
  CONSTRAINT `FK_AspNetUsers_Companies_CompaniesId` FOREIGN KEY (`CompaniesId`) REFERENCES `companies` (`Id`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusers`
--

LOCK TABLES `aspnetusers` WRITE;
/*!40000 ALTER TABLE `aspnetusers` DISABLE KEYS */;
INSERT INTO `aspnetusers` VALUES ('256a231a-3686-466e-9ad5-6a4b625bae10','daniel.16.go@gmail.com','DANIEL.16.GO@GMAIL.COM','daniel.16.go@gmail.com','DANIEL.16.GO@GMAIL.COM',_binary '\0','AQAAAAEAACcQAAAAEHQydkhzsGiswKamlI5ZRzUNIucNRiDUfY67mCxY+pxrvBiZyP28uW9sSs9AhvEKIw==','EW5AKOSFBKEUXCHF4OW2AXPKPNSMMHNH','06c09114-2110-4389-bf23-3359aa2178f4',NULL,_binary '\0',_binary '\0',NULL,_binary '',0,'Daniel',1,'Dev','9f7ffb92-651e-4f89-abf4-63481d070c20_avatar.png',NULL),('6f12776c-540a-4507-a4dc-d78bc0863d99','pepe@mail.com','PEPE@MAIL.COM','pepe@mail.com','PEPE@MAIL.COM',_binary '\0','AQAAAAEAACcQAAAAEBnD9W6xZIDIzE7hzl5R+GT2N0q+FoUT1ZNX6flp0SX181LCUGXuuufF4YbGcEPGDQ==','RO6PM4QKEEOJ3CRCDV64J5JGDJD2MIXL','8ddab54c-f5ef-4761-96b0-2719b23a1966',NULL,_binary '\0',_binary '\0',NULL,_binary '',0,'Pepe Roman',1,'ADMINISTRADOR',NULL,NULL);
/*!40000 ALTER TABLE `aspnetusers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusertokens`
--

DROP TABLE IF EXISTS `aspnetusertokens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(256) NOT NULL,
  `LoginProvider` varchar(256) NOT NULL,
  `Name` varchar(256) NOT NULL,
  `Value` text,
  PRIMARY KEY (`UserId`,`LoginProvider`,`Name`),
  CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusertokens`
--

LOCK TABLES `aspnetusertokens` WRITE;
/*!40000 ALTER TABLE `aspnetusertokens` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetusertokens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `banks`
--

DROP TABLE IF EXISTS `banks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `banks` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `banks`
--

LOCK TABLES `banks` WRITE;
/*!40000 ALTER TABLE `banks` DISABLE KEYS */;
/*!40000 ALTER TABLE `banks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `biocaresurveyanswers`
--

DROP TABLE IF EXISTS `biocaresurveyanswers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `biocaresurveyanswers` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `SurveyDate` datetime DEFAULT NULL,
  `SurveyTime` datetime DEFAULT NULL,
  `EmployeesId` int NOT NULL,
  `BioCareSurveyQuestionsId` int NOT NULL,
  `Answer` varchar(50) NOT NULL,
  `Temperature` decimal(18,2) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_BioCareSurveyAnswers_BioCareSurveyQuestionsId` (`BioCareSurveyQuestionsId`),
  KEY `IX_BioCareSurveyAnswers_EmployeesId` (`EmployeesId`),
  CONSTRAINT `FK_BioCareSurveyAnswers_BioCareSurveyQuestions_BioCareSurveyQue~` FOREIGN KEY (`BioCareSurveyQuestionsId`) REFERENCES `biocaresurveyquestions` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_BioCareSurveyAnswers_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `employees` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `biocaresurveyanswers`
--

LOCK TABLES `biocaresurveyanswers` WRITE;
/*!40000 ALTER TABLE `biocaresurveyanswers` DISABLE KEYS */;
/*!40000 ALTER TABLE `biocaresurveyanswers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `biocaresurveyquestions`
--

DROP TABLE IF EXISTS `biocaresurveyquestions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `biocaresurveyquestions` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `QuestionName` text NOT NULL,
  `AnswerName` varchar(100) DEFAULT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `biocaresurveyquestions`
--

LOCK TABLES `biocaresurveyquestions` WRITE;
/*!40000 ALTER TABLE `biocaresurveyquestions` DISABLE KEYS */;
/*!40000 ALTER TABLE `biocaresurveyquestions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bomdetails`
--

DROP TABLE IF EXISTS `bomdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bomdetails` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `BOMsId` int NOT NULL,
  `ProductsId` int NOT NULL,
  `ComponentsId` int NOT NULL,
  `BaseQuantity` decimal(18,2) DEFAULT NULL,
  `RequiredQuantity` decimal(18,2) DEFAULT NULL,
  `AdicionalQuantity` decimal(18,2) DEFAULT NULL,
  `WastePercentage` decimal(18,2) DEFAULT NULL,
  `ActivationDateTime` datetime DEFAULT NULL,
  `InactivationDateTime` datetime DEFAULT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_BOMDetails_BOMsId` (`BOMsId`),
  KEY `IX_BOMDetails_ProductsId` (`ProductsId`),
  CONSTRAINT `FK_BOMDetails_BOMs_BOMsId` FOREIGN KEY (`BOMsId`) REFERENCES `boms` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_BOMDetails_Products_ProductsId` FOREIGN KEY (`ProductsId`) REFERENCES `products` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bomdetails`
--

LOCK TABLES `bomdetails` WRITE;
/*!40000 ALTER TABLE `bomdetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `bomdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `boms`
--

DROP TABLE IF EXISTS `boms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `boms` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ProductsId` int NOT NULL,
  `InstallationsId` int NOT NULL,
  `MethodsId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_BOMs_InstallationsId` (`InstallationsId`),
  KEY `IX_BOMs_MethodsId` (`MethodsId`),
  KEY `IX_BOMs_ProductsId` (`ProductsId`),
  CONSTRAINT `FK_BOMs_Installations_InstallationsId` FOREIGN KEY (`InstallationsId`) REFERENCES `installations` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_BOMs_Methods_MethodsId` FOREIGN KEY (`MethodsId`) REFERENCES `methods` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_BOMs_Products_ProductsId` FOREIGN KEY (`ProductsId`) REFERENCES `products` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `boms`
--

LOCK TABLES `boms` WRITE;
/*!40000 ALTER TABLE `boms` DISABLE KEYS */;
/*!40000 ALTER TABLE `boms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `brands`
--

DROP TABLE IF EXISTS `brands`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `brands` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `brands`
--

LOCK TABLES `brands` WRITE;
/*!40000 ALTER TABLE `brands` DISABLE KEYS */;
/*!40000 ALTER TABLE `brands` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `calendarcategories`
--

DROP TABLE IF EXISTS `calendarcategories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `calendarcategories` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `Color` varchar(20) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `calendarcategories`
--

LOCK TABLES `calendarcategories` WRITE;
/*!40000 ALTER TABLE `calendarcategories` DISABLE KEYS */;
/*!40000 ALTER TABLE `calendarcategories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `calendarevents`
--

DROP TABLE IF EXISTS `calendarevents`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `calendarevents` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `CalendarsId` int NOT NULL,
  `CalendarCategoriesId` int NOT NULL,
  `Name` varchar(100) NOT NULL,
  `EventStartDate` datetime NOT NULL,
  `EventEndDate` datetime NOT NULL,
  `EventStartTime` datetime NOT NULL,
  `EventEndTime` datetime NOT NULL,
  `EventRemember` bit(1) NOT NULL,
  `Remarks` text,
  `Seen` bit(1) NOT NULL,
  `EmailSent` bit(1) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_CalendarEvents_CalendarCategoriesId` (`CalendarCategoriesId`),
  KEY `IX_CalendarEvents_CalendarsId` (`CalendarsId`),
  CONSTRAINT `FK_CalendarEvents_CalendarCategories_CalendarCategoriesId` FOREIGN KEY (`CalendarCategoriesId`) REFERENCES `calendarcategories` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_CalendarEvents_Calendars_CalendarsId` FOREIGN KEY (`CalendarsId`) REFERENCES `calendars` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `calendarevents`
--

LOCK TABLES `calendarevents` WRITE;
/*!40000 ALTER TABLE `calendarevents` DISABLE KEYS */;
/*!40000 ALTER TABLE `calendarevents` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `calendars`
--

DROP TABLE IF EXISTS `calendars`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `calendars` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `calendars`
--

LOCK TABLES `calendars` WRITE;
/*!40000 ALTER TABLE `calendars` DISABLE KEYS */;
/*!40000 ALTER TABLE `calendars` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categorymodels`
--

DROP TABLE IF EXISTS `categorymodels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categorymodels` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ScopeNameCategory` varchar(40) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorymodels`
--

LOCK TABLES `categorymodels` WRITE;
/*!40000 ALTER TABLE `categorymodels` DISABLE KEYS */;
/*!40000 ALTER TABLE `categorymodels` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `channelcategories`
--

DROP TABLE IF EXISTS `channelcategories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `channelcategories` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `channelcategories`
--

LOCK TABLES `channelcategories` WRITE;
/*!40000 ALTER TABLE `channelcategories` DISABLE KEYS */;
INSERT INTO `channelcategories` VALUES (1,'HEMBRA',1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-01-12 00:00:00','2021-01-12 00:00:00'),(2,'MACHO',1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-01-12 00:00:00','2021-01-12 00:00:00'),(3,'JOVEN',1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(4,'ADULTO',1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00');
/*!40000 ALTER TABLE `channelcategories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `channels`
--

DROP TABLE IF EXISTS `channels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `channels` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` text,
  `SpecieId` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Channels_SpecieId` (`SpecieId`),
  CONSTRAINT `FK_Channels_Species_SpecieId` FOREIGN KEY (`SpecieId`) REFERENCES `species` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `channels`
--

LOCK TABLES `channels` WRITE;
/*!40000 ALTER TABLE `channels` DISABLE KEYS */;
INSERT INTO `channels` VALUES (1,'C001-CERDO',1,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-01-12 00:00:00','2021-01-12 00:00:00'),(3,'C002 RES',2,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00');
/*!40000 ALTER TABLE `channels` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `commimports`
--

DROP TABLE IF EXISTS `commimports`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `commimports` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ImportsId` int NOT NULL,
  `DateComm` datetime NOT NULL,
  `Message` text NOT NULL,
  `SuppliersId` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_CommImports_ImportsId` (`ImportsId`),
  KEY `IX_CommImports_SuppliersId` (`SuppliersId`),
  CONSTRAINT `FK_CommImports_Imports_ImportsId` FOREIGN KEY (`ImportsId`) REFERENCES `imports` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_CommImports_Suppliers_SuppliersId` FOREIGN KEY (`SuppliersId`) REFERENCES `suppliers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `commimports`
--

LOCK TABLES `commimports` WRITE;
/*!40000 ALTER TABLE `commimports` DISABLE KEYS */;
/*!40000 ALTER TABLE `commimports` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `companies`
--

DROP TABLE IF EXISTS `companies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `companies` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Code` varchar(4) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Latitude` text,
  `Longitude` text,
  `Owner` varchar(100) DEFAULT NULL,
  `CreatedAt` datetime NOT NULL,
  `UpdatedAt` datetime NOT NULL,
  `PlansId` int NOT NULL,
  `ConfigMode` int NOT NULL,
  `PathWeb` text,
  `LogoPath` text,
  `SectorsId` int DEFAULT NULL,
  `SubSectorsId` int DEFAULT NULL,
  `PlanPaymentsId` int DEFAULT NULL,
  `SeederLoad` bit(1) DEFAULT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateDate` datetime NOT NULL,
  `ProcessesId` int DEFAULT NULL,
  `BrandsId` int DEFAULT NULL,
  `MachinesId` int DEFAULT NULL,
  `BanksId` int DEFAULT NULL,
  `LocationsId` int DEFAULT NULL,
  `CountriesId` int DEFAULT NULL,
  `CurrenciesId` int DEFAULT NULL,
  `CustomsAgenciesId` int DEFAULT NULL,
  `FinishPortsId` int DEFAULT NULL,
  `ImportsId` int DEFAULT NULL,
  `IncotermsId` int DEFAULT NULL,
  `PaymentTermsId` int DEFAULT NULL,
  `ShipmentsCompaniesId` int DEFAULT NULL,
  `StartPortsId` int DEFAULT NULL,
  `StatusId` int DEFAULT NULL,
  `SuppliersId` int DEFAULT NULL,
  `SupplierTypesId` int DEFAULT NULL,
  `TransportCompaniesId` int DEFAULT NULL,
  `ImportDetailsId` int DEFAULT NULL,
  `ProductsId` int DEFAULT NULL,
  `UnitsId` int DEFAULT NULL,
  `ProductTypesId` int DEFAULT NULL,
  `ContainersId` int DEFAULT NULL,
  `ContainerTypesId` int DEFAULT NULL,
  `CommImportsId` int DEFAULT NULL,
  `ImportFilesId` int DEFAULT NULL,
  `PackingListsId` int DEFAULT NULL,
  `PaymentTypesId` int DEFAULT NULL,
  `PaymentsId` int DEFAULT NULL,
  `ShiftsId` int DEFAULT NULL,
  `ProductionOrdersId` int DEFAULT NULL,
  `MetalUnitsId` int DEFAULT NULL,
  `MetalUnitTypesId` int DEFAULT NULL,
  `ProductionInfosId` int DEFAULT NULL,
  `ProductionOrderDetailsId` int DEFAULT NULL,
  `ProductionStopsId` int DEFAULT NULL,
  `ProductionOrderProcessesId` int DEFAULT NULL,
  `EmployeesId` int DEFAULT NULL,
  `EmployeeTypesId` int DEFAULT NULL,
  `StopsCategoriesId` int DEFAULT NULL,
  `AreasId` int DEFAULT NULL,
  `StopsId` int DEFAULT NULL,
  `ProductionOrderFilesId` int DEFAULT NULL,
  `ShapesId` int DEFAULT NULL,
  `CategoryModelsId` int DEFAULT NULL,
  `EvaluationCategoriesId` int DEFAULT NULL,
  `IoTsId` int DEFAULT NULL,
  `IoTAlertsId` int DEFAULT NULL,
  `IoTMachinesId` int DEFAULT NULL,
  `IoTNotificationsId` int DEFAULT NULL,
  `IoTVariablesId` int DEFAULT NULL,
  `ModelQuestionsId` int DEFAULT NULL,
  `IdealModelQuestionsId` int DEFAULT NULL,
  `DimensionEntityId` int DEFAULT NULL,
  `FinishEntityId` int DEFAULT NULL,
  `SteelEntityId` int DEFAULT NULL,
  `ThicknessEntityId` int DEFAULT NULL,
  `WHLocationEntityId` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Companies_AreasId` (`AreasId`),
  KEY `IX_Companies_BanksId` (`BanksId`),
  KEY `IX_Companies_BrandsId` (`BrandsId`),
  KEY `IX_Companies_CategoryModelsId` (`CategoryModelsId`),
  KEY `IX_Companies_CommImportsId` (`CommImportsId`),
  KEY `IX_Companies_ContainerTypesId` (`ContainerTypesId`),
  KEY `IX_Companies_ContainersId` (`ContainersId`),
  KEY `IX_Companies_CountriesId` (`CountriesId`),
  KEY `IX_Companies_CurrenciesId` (`CurrenciesId`),
  KEY `IX_Companies_CustomsAgenciesId` (`CustomsAgenciesId`),
  KEY `IX_Companies_DimensionEntityId` (`DimensionEntityId`),
  KEY `IX_Companies_EmployeeTypesId` (`EmployeeTypesId`),
  KEY `IX_Companies_EmployeesId` (`EmployeesId`),
  KEY `IX_Companies_EvaluationCategoriesId` (`EvaluationCategoriesId`),
  KEY `IX_Companies_FinishEntityId` (`FinishEntityId`),
  KEY `IX_Companies_FinishPortsId` (`FinishPortsId`),
  KEY `IX_Companies_IdealModelQuestionsId` (`IdealModelQuestionsId`),
  KEY `IX_Companies_ImportDetailsId` (`ImportDetailsId`),
  KEY `IX_Companies_ImportFilesId` (`ImportFilesId`),
  KEY `IX_Companies_ImportsId` (`ImportsId`),
  KEY `IX_Companies_IncotermsId` (`IncotermsId`),
  KEY `IX_Companies_IoTAlertsId` (`IoTAlertsId`),
  KEY `IX_Companies_IoTMachinesId` (`IoTMachinesId`),
  KEY `IX_Companies_IoTNotificationsId` (`IoTNotificationsId`),
  KEY `IX_Companies_IoTVariablesId` (`IoTVariablesId`),
  KEY `IX_Companies_IoTsId` (`IoTsId`),
  KEY `IX_Companies_LocationsId` (`LocationsId`),
  KEY `IX_Companies_MachinesId` (`MachinesId`),
  KEY `IX_Companies_MetalUnitTypesId` (`MetalUnitTypesId`),
  KEY `IX_Companies_MetalUnitsId` (`MetalUnitsId`),
  KEY `IX_Companies_ModelQuestionsId` (`ModelQuestionsId`),
  KEY `IX_Companies_PackingListsId` (`PackingListsId`),
  KEY `IX_Companies_PaymentTermsId` (`PaymentTermsId`),
  KEY `IX_Companies_PaymentTypesId` (`PaymentTypesId`),
  KEY `IX_Companies_PaymentsId` (`PaymentsId`),
  KEY `IX_Companies_PlanPaymentsId` (`PlanPaymentsId`),
  KEY `IX_Companies_PlansId` (`PlansId`),
  KEY `IX_Companies_ProcessesId` (`ProcessesId`),
  KEY `IX_Companies_ProductTypesId` (`ProductTypesId`),
  KEY `IX_Companies_ProductionInfosId` (`ProductionInfosId`),
  KEY `IX_Companies_ProductionOrderDetailsId` (`ProductionOrderDetailsId`),
  KEY `IX_Companies_ProductionOrderFilesId` (`ProductionOrderFilesId`),
  KEY `IX_Companies_ProductionOrderProcessesId` (`ProductionOrderProcessesId`),
  KEY `IX_Companies_ProductionOrdersId` (`ProductionOrdersId`),
  KEY `IX_Companies_ProductionStopsId` (`ProductionStopsId`),
  KEY `IX_Companies_ProductsId` (`ProductsId`),
  KEY `IX_Companies_SectorsId` (`SectorsId`),
  KEY `IX_Companies_ShapesId` (`ShapesId`),
  KEY `IX_Companies_ShiftsId` (`ShiftsId`),
  KEY `IX_Companies_ShipmentsCompaniesId` (`ShipmentsCompaniesId`),
  KEY `IX_Companies_StartPortsId` (`StartPortsId`),
  KEY `IX_Companies_StatusId` (`StatusId`),
  KEY `IX_Companies_SteelEntityId` (`SteelEntityId`),
  KEY `IX_Companies_StopsCategoriesId` (`StopsCategoriesId`),
  KEY `IX_Companies_StopsId` (`StopsId`),
  KEY `IX_Companies_SubSectorsId` (`SubSectorsId`),
  KEY `IX_Companies_SupplierTypesId` (`SupplierTypesId`),
  KEY `IX_Companies_SuppliersId` (`SuppliersId`),
  KEY `IX_Companies_ThicknessEntityId` (`ThicknessEntityId`),
  KEY `IX_Companies_TransportCompaniesId` (`TransportCompaniesId`),
  KEY `IX_Companies_UnitsId` (`UnitsId`),
  KEY `IX_Companies_WHLocationEntityId` (`WHLocationEntityId`),
  CONSTRAINT `FK_Companies_Areas_AreasId` FOREIGN KEY (`AreasId`) REFERENCES `areas` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Banks_BanksId` FOREIGN KEY (`BanksId`) REFERENCES `banks` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Brands_BrandsId` FOREIGN KEY (`BrandsId`) REFERENCES `brands` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_CategoryModels_CategoryModelsId` FOREIGN KEY (`CategoryModelsId`) REFERENCES `categorymodels` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_CommImports_CommImportsId` FOREIGN KEY (`CommImportsId`) REFERENCES `commimports` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Containers_ContainersId` FOREIGN KEY (`ContainersId`) REFERENCES `containers` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_ContainerTypes_ContainerTypesId` FOREIGN KEY (`ContainerTypesId`) REFERENCES `containertypes` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Countries_CountriesId` FOREIGN KEY (`CountriesId`) REFERENCES `countries` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Currencies_CurrenciesId` FOREIGN KEY (`CurrenciesId`) REFERENCES `currencies` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_CustomsAgencies_CustomsAgenciesId` FOREIGN KEY (`CustomsAgenciesId`) REFERENCES `customsagencies` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Dimensions_DimensionEntityId` FOREIGN KEY (`DimensionEntityId`) REFERENCES `dimensions` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `employees` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_EmployeeTypes_EmployeeTypesId` FOREIGN KEY (`EmployeeTypesId`) REFERENCES `employeetypes` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_EvaluationCategories_EvaluationCategoriesId` FOREIGN KEY (`EvaluationCategoriesId`) REFERENCES `evaluationcategories` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Finisheses_FinishEntityId` FOREIGN KEY (`FinishEntityId`) REFERENCES `finisheses` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_FinishPorts_FinishPortsId` FOREIGN KEY (`FinishPortsId`) REFERENCES `finishports` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_IdealModelQuestions_IdealModelQuestionsId` FOREIGN KEY (`IdealModelQuestionsId`) REFERENCES `idealmodelquestions` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_ImportDetails_ImportDetailsId` FOREIGN KEY (`ImportDetailsId`) REFERENCES `importdetails` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_ImportFiles_ImportFilesId` FOREIGN KEY (`ImportFilesId`) REFERENCES `importfiles` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Imports_ImportsId` FOREIGN KEY (`ImportsId`) REFERENCES `imports` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Incoterms_IncotermsId` FOREIGN KEY (`IncotermsId`) REFERENCES `incoterms` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_IoTAlerts_IoTAlertsId` FOREIGN KEY (`IoTAlertsId`) REFERENCES `iotalerts` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_IoTMachines_IoTMachinesId` FOREIGN KEY (`IoTMachinesId`) REFERENCES `iotmachines` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_IoTNotifications_IoTNotificationsId` FOREIGN KEY (`IoTNotificationsId`) REFERENCES `iotnotifications` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_IoTs_IoTsId` FOREIGN KEY (`IoTsId`) REFERENCES `iots` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_IoTVariables_IoTVariablesId` FOREIGN KEY (`IoTVariablesId`) REFERENCES `iotvariables` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Locations_LocationsId` FOREIGN KEY (`LocationsId`) REFERENCES `locations` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Machines_MachinesId` FOREIGN KEY (`MachinesId`) REFERENCES `machines` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_MetalUnits_MetalUnitsId` FOREIGN KEY (`MetalUnitsId`) REFERENCES `metalunits` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_MetalUnitTypes_MetalUnitTypesId` FOREIGN KEY (`MetalUnitTypesId`) REFERENCES `metalunittypes` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_ModelQuestions_ModelQuestionsId` FOREIGN KEY (`ModelQuestionsId`) REFERENCES `modelquestions` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_PackingLists_PackingListsId` FOREIGN KEY (`PackingListsId`) REFERENCES `packinglists` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Payments_PaymentsId` FOREIGN KEY (`PaymentsId`) REFERENCES `payments` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_PaymentTerms_PaymentTermsId` FOREIGN KEY (`PaymentTermsId`) REFERENCES `paymentterms` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_PaymentTypes_PaymentTypesId` FOREIGN KEY (`PaymentTypesId`) REFERENCES `paymenttypes` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_PlanPayments_PlanPaymentsId` FOREIGN KEY (`PlanPaymentsId`) REFERENCES `planpayments` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Plans_PlansId` FOREIGN KEY (`PlansId`) REFERENCES `plans` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Companies_Processes_ProcessesId` FOREIGN KEY (`ProcessesId`) REFERENCES `processes` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_ProductionInfos_ProductionInfosId` FOREIGN KEY (`ProductionInfosId`) REFERENCES `productioninfos` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_ProductionOrderDetails_ProductionOrderDetailsId` FOREIGN KEY (`ProductionOrderDetailsId`) REFERENCES `productionorderdetails` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_ProductionOrderFiles_ProductionOrderFilesId` FOREIGN KEY (`ProductionOrderFilesId`) REFERENCES `productionorderfiles` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_ProductionOrderProcesses_ProductionOrderProcessesId` FOREIGN KEY (`ProductionOrderProcessesId`) REFERENCES `productionorderprocesses` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_ProductionOrders_ProductionOrdersId` FOREIGN KEY (`ProductionOrdersId`) REFERENCES `productionorders` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_ProductionStops_ProductionStopsId` FOREIGN KEY (`ProductionStopsId`) REFERENCES `productionstops` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Products_ProductsId` FOREIGN KEY (`ProductsId`) REFERENCES `products` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_ProductTypes_ProductTypesId` FOREIGN KEY (`ProductTypesId`) REFERENCES `producttypes` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Sectors_SectorsId` FOREIGN KEY (`SectorsId`) REFERENCES `sectors` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Shapes_ShapesId` FOREIGN KEY (`ShapesId`) REFERENCES `shapes` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Shifts_ShiftsId` FOREIGN KEY (`ShiftsId`) REFERENCES `shifts` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_ShipmentCompanies_ShipmentsCompaniesId` FOREIGN KEY (`ShipmentsCompaniesId`) REFERENCES `shipmentcompanies` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_StartPorts_StartPortsId` FOREIGN KEY (`StartPortsId`) REFERENCES `startports` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Status_StatusId` FOREIGN KEY (`StatusId`) REFERENCES `status` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Steels_SteelEntityId` FOREIGN KEY (`SteelEntityId`) REFERENCES `steels` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Stops_StopsId` FOREIGN KEY (`StopsId`) REFERENCES `stops` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_StopsCategories_StopsCategoriesId` FOREIGN KEY (`StopsCategoriesId`) REFERENCES `stopscategories` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_SubSectors_SubSectorsId` FOREIGN KEY (`SubSectorsId`) REFERENCES `subsectors` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Suppliers_SuppliersId` FOREIGN KEY (`SuppliersId`) REFERENCES `suppliers` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_SupplierTypes_SupplierTypesId` FOREIGN KEY (`SupplierTypesId`) REFERENCES `suppliertypes` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Thicknesses_ThicknessEntityId` FOREIGN KEY (`ThicknessEntityId`) REFERENCES `thicknesses` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_TransportCompanies_TransportCompaniesId` FOREIGN KEY (`TransportCompaniesId`) REFERENCES `transportcompanies` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_Units_UnitsId` FOREIGN KEY (`UnitsId`) REFERENCES `units` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Companies_WHLocations_WHLocationEntityId` FOREIGN KEY (`WHLocationEntityId`) REFERENCES `whlocations` (`Id`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `companies`
--

LOCK TABLES `companies` WRITE;
/*!40000 ALTER TABLE `companies` DISABLE KEYS */;
/*!40000 ALTER TABLE `companies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `containers`
--

DROP TABLE IF EXISTS `containers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `containers` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ImportsId` int NOT NULL,
  `Container` varchar(40) NOT NULL,
  `BL` varchar(40) NOT NULL,
  `InitialDate` datetime NOT NULL,
  `FinalDate` datetime NOT NULL,
  `Booking` text,
  `ContainerTypesId` int NOT NULL,
  `GrossWeight` decimal(18,2) NOT NULL,
  `ContainerLoadType` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Containers_ContainerTypesId` (`ContainerTypesId`),
  KEY `IX_Containers_ImportsId` (`ImportsId`),
  CONSTRAINT `FK_Containers_ContainerTypes_ContainerTypesId` FOREIGN KEY (`ContainerTypesId`) REFERENCES `containertypes` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Containers_Imports_ImportsId` FOREIGN KEY (`ImportsId`) REFERENCES `imports` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `containers`
--

LOCK TABLES `containers` WRITE;
/*!40000 ALTER TABLE `containers` DISABLE KEYS */;
/*!40000 ALTER TABLE `containers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `containertypes`
--

DROP TABLE IF EXISTS `containertypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `containertypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Lenght` decimal(18,2) NOT NULL,
  `Width` decimal(18,2) NOT NULL,
  `Height` decimal(18,2) NOT NULL,
  `Weight` decimal(18,2) NOT NULL,
  `MaxLoadKG` decimal(18,2) NOT NULL,
  `MaxLoadCM` decimal(18,2) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `containertypes`
--

LOCK TABLES `containertypes` WRITE;
/*!40000 ALTER TABLE `containertypes` DISABLE KEYS */;
/*!40000 ALTER TABLE `containertypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `controleppdetails`
--

DROP TABLE IF EXISTS `controleppdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `controleppdetails` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ControlEPPsId` int NOT NULL,
  `EmployeesId` int NOT NULL,
  `AsignmentDateTime` datetime DEFAULT NULL,
  `ReturnDateTime` datetime DEFAULT NULL,
  `ProtectionElementsId` int NOT NULL,
  `Quantity` decimal(18,2) DEFAULT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ControlEPPDetails_ControlEPPsId` (`ControlEPPsId`),
  KEY `IX_ControlEPPDetails_EmployeesId` (`EmployeesId`),
  KEY `IX_ControlEPPDetails_ProtectionElementsId` (`ProtectionElementsId`),
  CONSTRAINT `FK_ControlEPPDetails_ControlEPPs_ControlEPPsId` FOREIGN KEY (`ControlEPPsId`) REFERENCES `controlepps` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ControlEPPDetails_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `employees` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ControlEPPDetails_ProtectionElements_ProtectionElementsId` FOREIGN KEY (`ProtectionElementsId`) REFERENCES `protectionelements` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `controleppdetails`
--

LOCK TABLES `controleppdetails` WRITE;
/*!40000 ALTER TABLE `controleppdetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `controleppdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `controlepps`
--

DROP TABLE IF EXISTS `controlepps`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `controlepps` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ControlEPPDate` datetime DEFAULT NULL,
  `Order` varchar(15) DEFAULT NULL,
  `StatusId` int NOT NULL,
  `EmployeesId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ControlEPPs_EmployeesId` (`EmployeesId`),
  KEY `IX_ControlEPPs_StatusId` (`StatusId`),
  CONSTRAINT `FK_ControlEPPs_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `employees` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ControlEPPs_Status_StatusId` FOREIGN KEY (`StatusId`) REFERENCES `status` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `controlepps`
--

LOCK TABLES `controlepps` WRITE;
/*!40000 ALTER TABLE `controlepps` DISABLE KEYS */;
/*!40000 ALTER TABLE `controlepps` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `countries`
--

DROP TABLE IF EXISTS `countries`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `countries` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Initials` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `countries`
--

LOCK TABLES `countries` WRITE;
/*!40000 ALTER TABLE `countries` DISABLE KEYS */;
/*!40000 ALTER TABLE `countries` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `currencies`
--

DROP TABLE IF EXISTS `currencies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `currencies` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Initials` text,
  `Factor` decimal(18,2) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `currencies`
--

LOCK TABLES `currencies` WRITE;
/*!40000 ALTER TABLE `currencies` DISABLE KEYS */;
INSERT INTO `currencies` VALUES (1,'PESOS','COP',1.00,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(2,'DOLAR','USD',3945.00,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00');
/*!40000 ALTER TABLE `currencies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customercomms`
--

DROP TABLE IF EXISTS `customercomms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customercomms` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `CustomerId` int NOT NULL,
  `DateComm` datetime NOT NULL,
  `Message` text NOT NULL,
  `Name` varchar(150) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  `CustomersId` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_CustomerComms_CustomersId` (`CustomersId`),
  CONSTRAINT `FK_CustomerComms_Customers_CustomersId` FOREIGN KEY (`CustomersId`) REFERENCES `customers` (`Id`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customercomms`
--

LOCK TABLES `customercomms` WRITE;
/*!40000 ALTER TABLE `customercomms` DISABLE KEYS */;
/*!40000 ALTER TABLE `customercomms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customerfiles`
--

DROP TABLE IF EXISTS `customerfiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customerfiles` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `CustomersId` int NOT NULL,
  `Remarks` text,
  `FilePath` text,
  `LoadDate` datetime NOT NULL,
  `TypeFile` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_CustomerFiles_CustomersId` (`CustomersId`),
  CONSTRAINT `FK_CustomerFiles_Customers_CustomersId` FOREIGN KEY (`CustomersId`) REFERENCES `customers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customerfiles`
--

LOCK TABLES `customerfiles` WRITE;
/*!40000 ALTER TABLE `customerfiles` DISABLE KEYS */;
/*!40000 ALTER TABLE `customerfiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Code` varchar(30) DEFAULT NULL,
  `Name` varchar(150) NOT NULL,
  `Latitude` text,
  `Longitude` text,
  `Initials` text,
  `CustomerTypesId` int NOT NULL,
  `CreditLimit` decimal(18,2) DEFAULT NULL,
  `BlockId` int NOT NULL,
  `VendorsId` int NOT NULL,
  `InstallationsId` int NOT NULL,
  `InvoiceDeliveryId` int NOT NULL,
  `TaxesId` int NOT NULL,
  `InvoiceCopies` decimal(18,2) DEFAULT NULL,
  `CurrenciesId` int NOT NULL,
  `PricesListsId` int NOT NULL,
  `DiscountListsId` int NOT NULL,
  `DownPaymentPercentage` decimal(18,2) DEFAULT NULL,
  `DownPaymentApId` int NOT NULL,
  `PaymentTermsId` int NOT NULL,
  `PaymentMethodsId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  `PriceListsId` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Customers_CurrenciesId` (`CurrenciesId`),
  KEY `IX_Customers_CustomerTypesId` (`CustomerTypesId`),
  KEY `IX_Customers_DiscountListsId` (`DiscountListsId`),
  KEY `IX_Customers_InstallationsId` (`InstallationsId`),
  KEY `IX_Customers_PaymentMethodsId` (`PaymentMethodsId`),
  KEY `IX_Customers_PaymentTermsId` (`PaymentTermsId`),
  KEY `IX_Customers_PriceListsId` (`PriceListsId`),
  KEY `IX_Customers_TaxesId` (`TaxesId`),
  KEY `IX_Customers_VendorsId` (`VendorsId`),
  CONSTRAINT `FK_Customers_Currencies_CurrenciesId` FOREIGN KEY (`CurrenciesId`) REFERENCES `currencies` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Customers_CustomerTypes_CustomerTypesId` FOREIGN KEY (`CustomerTypesId`) REFERENCES `customertypes` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Customers_DiscountLists_DiscountListsId` FOREIGN KEY (`DiscountListsId`) REFERENCES `discountlists` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Customers_Installations_InstallationsId` FOREIGN KEY (`InstallationsId`) REFERENCES `installations` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Customers_PaymentMethods_PaymentMethodsId` FOREIGN KEY (`PaymentMethodsId`) REFERENCES `paymentmethods` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Customers_PaymentTerms_PaymentTermsId` FOREIGN KEY (`PaymentTermsId`) REFERENCES `paymentterms` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Customers_PriceLists_PriceListsId` FOREIGN KEY (`PriceListsId`) REFERENCES `pricelists` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Customers_Taxes_TaxesId` FOREIGN KEY (`TaxesId`) REFERENCES `taxes` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Customers_Vendors_VendorsId` FOREIGN KEY (`VendorsId`) REFERENCES `vendors` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customertypes`
--

DROP TABLE IF EXISTS `customertypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customertypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Initials` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customertypes`
--

LOCK TABLES `customertypes` WRITE;
/*!40000 ALTER TABLE `customertypes` DISABLE KEYS */;
/*!40000 ALTER TABLE `customertypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customsagencies`
--

DROP TABLE IF EXISTS `customsagencies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customsagencies` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Address` text,
  `Phone1` text,
  `Phone2` text,
  `Email1` text NOT NULL,
  `Email2` text,
  `Contact` text,
  `Website` text,
  `Initials` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customsagencies`
--

LOCK TABLES `customsagencies` WRITE;
/*!40000 ALTER TABLE `customsagencies` DISABLE KEYS */;
/*!40000 ALTER TABLE `customsagencies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cutsofmeats`
--

DROP TABLE IF EXISTS `cutsofmeats`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cutsofmeats` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` text,
  `Quantity` int NOT NULL,
  `ChannelId` int NOT NULL,
  `MainCutId` int DEFAULT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_CutsOfMeats_ChannelId` (`ChannelId`),
  KEY `IX_CutsOfMeats_MainCutId` (`MainCutId`),
  CONSTRAINT `FK_CutsOfMeats_Channels_ChannelId` FOREIGN KEY (`ChannelId`) REFERENCES `channels` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_CutsOfMeats_CutsOfMeats_MainCutId` FOREIGN KEY (`MainCutId`) REFERENCES `cutsofmeats` (`Id`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cutsofmeats`
--

LOCK TABLES `cutsofmeats` WRITE;
/*!40000 ALTER TABLE `cutsofmeats` DISABLE KEYS */;
INSERT INTO `cutsofmeats` VALUES (1,'T BONE',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-01-12 00:00:00','2021-01-12 00:00:00'),(2,'PIERNA',2,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-01-12 00:00:00','2021-01-12 00:00:00'),(5,'RECORTE',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(6,'SEBO',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(7,'CINTA CON HUESO LIMPIA',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(8,'HUESO DE CADENA',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(9,'FILETE S/CORDON',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-02 01:20:30','2021-12-02 01:20:30'),(10,'FILETE ROJO',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-02 01:21:22','2021-12-02 01:21:22'),(11,'CINTA PEDIDO',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-02 01:26:36','2021-12-02 01:26:36'),(13,'NEW YORK',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-02 01:34:23','2021-12-02 01:34:23'),(14,'CINTA ROJA',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-02 01:37:03','2021-12-02 01:37:03'),(15,'HUESO',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-02 02:25:40','2021-12-02 02:25:40'),(16,'PULPA NEGRA SUCIA',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-02 02:28:24','2021-12-02 02:28:24'),(17,'RINCON SUCIO',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-02 02:28:39','2021-12-02 02:28:39'),(18,'BABILLA SUCIA',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-02 02:28:59','2021-12-02 02:28:59'),(19,'PALOMILLA SUCIA',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-02 02:29:23','2021-12-02 02:29:23'),(20,'LOMO REDONDO SUCIO',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-02 02:29:42','2021-12-02 02:29:42'),(21,'CAJA PIERNA',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-02 02:30:22','2021-12-02 02:30:22'),(23,'F. CON CORDON',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(24,'C/PIERNA CAJETA',1,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-02 02:37:08','2021-12-02 02:37:08'),(25,'T BONE',1,3,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(26,'COSTILLA',2,3,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(28,'PS SHORT RIB',1,3,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-02 07:43:27','2021-12-02 07:43:27'),(29,'RIP FINGER',1,3,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-02 07:43:48','2021-12-02 07:43:48'),(30,'COSTILLA',3,1,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00');
/*!40000 ALTER TABLE `cutsofmeats` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cutsrelations`
--

DROP TABLE IF EXISTS `cutsrelations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cutsrelations` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `MainCutMeatId` int NOT NULL,
  `SubCutMeatId` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_CutsRelations_MainCutMeatId` (`MainCutMeatId`),
  KEY `IX_CutsRelations_SubCutMeatId` (`SubCutMeatId`),
  CONSTRAINT `FK_CutsRelations_CutsOfMeats_MainCutMeatId` FOREIGN KEY (`MainCutMeatId`) REFERENCES `cutsofmeats` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_CutsRelations_CutsOfMeats_SubCutMeatId` FOREIGN KEY (`SubCutMeatId`) REFERENCES `cutsofmeats` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cutsrelations`
--

LOCK TABLES `cutsrelations` WRITE;
/*!40000 ALTER TABLE `cutsrelations` DISABLE KEYS */;
INSERT INTO `cutsrelations` VALUES (24,1,5,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(25,1,6,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(26,1,7,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(27,1,8,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(31,9,10,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(32,9,5,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(34,7,11,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(35,7,5,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(36,7,8,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(37,11,13,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(38,11,5,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(39,11,15,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(40,13,14,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(41,13,6,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(42,13,5,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(43,2,16,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(44,2,17,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(45,2,18,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(46,2,19,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(47,2,20,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(49,16,5,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(50,16,21,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(54,23,9,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(55,23,5,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(56,23,6,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(57,21,24,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(58,21,6,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(59,21,5,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(60,25,23,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(61,25,5,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(62,25,6,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(63,25,7,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(64,25,8,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(66,26,28,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(67,26,29,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(68,26,15,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(69,26,6,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00');
/*!40000 ALTER TABLE `cutsrelations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diagnosticdetails`
--

DROP TABLE IF EXISTS `diagnosticdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diagnosticdetails` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `DiagnosticsId` int NOT NULL,
  `ModelQuestionsId` int NOT NULL,
  `Execution` decimal(18,2) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_DiagnosticDetails_DiagnosticsId` (`DiagnosticsId`),
  KEY `IX_DiagnosticDetails_ModelQuestionsId` (`ModelQuestionsId`),
  CONSTRAINT `FK_DiagnosticDetails_Diagnostics_DiagnosticsId` FOREIGN KEY (`DiagnosticsId`) REFERENCES `diagnostics` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_DiagnosticDetails_ModelQuestions_ModelQuestionsId` FOREIGN KEY (`ModelQuestionsId`) REFERENCES `modelquestions` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diagnosticdetails`
--

LOCK TABLES `diagnosticdetails` WRITE;
/*!40000 ALTER TABLE `diagnosticdetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `diagnosticdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diagnostics`
--

DROP TABLE IF EXISTS `diagnostics`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diagnostics` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `CodeDiagnostic` varchar(5) NOT NULL,
  `StatusId` int NOT NULL,
  `DiagDate` datetime DEFAULT NULL,
  `EndDiagDate` datetime DEFAULT NULL,
  `SubSectorsId` int NOT NULL,
  `EmployeesId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Diagnostics_EmployeesId` (`EmployeesId`),
  KEY `IX_Diagnostics_StatusId` (`StatusId`),
  KEY `IX_Diagnostics_SubSectorsId` (`SubSectorsId`),
  CONSTRAINT `FK_Diagnostics_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `employees` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Diagnostics_Status_StatusId` FOREIGN KEY (`StatusId`) REFERENCES `status` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Diagnostics_SubSectors_SubSectorsId` FOREIGN KEY (`SubSectorsId`) REFERENCES `subsectors` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diagnostics`
--

LOCK TABLES `diagnostics` WRITE;
/*!40000 ALTER TABLE `diagnostics` DISABLE KEYS */;
/*!40000 ALTER TABLE `diagnostics` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dimensions`
--

DROP TABLE IF EXISTS `dimensions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dimensions` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Lenght` decimal(18,2) NOT NULL,
  `Width` decimal(18,2) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dimensions`
--

LOCK TABLES `dimensions` WRITE;
/*!40000 ALTER TABLE `dimensions` DISABLE KEYS */;
/*!40000 ALTER TABLE `dimensions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `discountlists`
--

DROP TABLE IF EXISTS `discountlists`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `discountlists` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Initials` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discountlists`
--

LOCK TABLES `discountlists` WRITE;
/*!40000 ALTER TABLE `discountlists` DISABLE KEYS */;
/*!40000 ALTER TABLE `discountlists` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `emailjobconfigs`
--

DROP TABLE IF EXISTS `emailjobconfigs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `emailjobconfigs` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Email` text NOT NULL,
  `Password` text NOT NULL,
  `SmtpHost` text NOT NULL,
  `SmtpPort` int NOT NULL,
  `EnableSSL` bit(1) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `emailjobconfigs`
--

LOCK TABLES `emailjobconfigs` WRITE;
/*!40000 ALTER TABLE `emailjobconfigs` DISABLE KEYS */;
/*!40000 ALTER TABLE `emailjobconfigs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `IdCode` int NOT NULL,
  `FirstName` varchar(80) NOT NULL,
  `SecondName` varchar(80) DEFAULT NULL,
  `LastName1` varchar(80) NOT NULL,
  `LastName2` varchar(80) DEFAULT NULL,
  `Address` varchar(80) NOT NULL,
  `Phone1` varchar(20) NOT NULL,
  `Phone2` varchar(20) DEFAULT NULL,
  `BirthDate` datetime NOT NULL,
  `EmployeeTypesId` int NOT NULL,
  `EmergencyName` varchar(100) DEFAULT NULL,
  `EmergencyPhone` varchar(20) DEFAULT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Employees_EmployeeTypesId` (`EmployeeTypesId`),
  CONSTRAINT `FK_Employees_EmployeeTypes_EmployeeTypesId` FOREIGN KEY (`EmployeeTypesId`) REFERENCES `employeetypes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employeetypes`
--

DROP TABLE IF EXISTS `employeetypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employeetypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employeetypes`
--

LOCK TABLES `employeetypes` WRITE;
/*!40000 ALTER TABLE `employeetypes` DISABLE KEYS */;
/*!40000 ALTER TABLE `employeetypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `evaluationcategories`
--

DROP TABLE IF EXISTS `evaluationcategories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `evaluationcategories` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `EvaluationNameCategory` varchar(40) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evaluationcategories`
--

LOCK TABLES `evaluationcategories` WRITE;
/*!40000 ALTER TABLE `evaluationcategories` DISABLE KEYS */;
/*!40000 ALTER TABLE `evaluationcategories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `finisheses`
--

DROP TABLE IF EXISTS `finisheses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `finisheses` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Initials` varchar(10) DEFAULT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `finisheses`
--

LOCK TABLES `finisheses` WRITE;
/*!40000 ALTER TABLE `finisheses` DISABLE KEYS */;
/*!40000 ALTER TABLE `finisheses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `finishports`
--

DROP TABLE IF EXISTS `finishports`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `finishports` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Latitude` text,
  `Longitude` text,
  `CompanyId` int NOT NULL,
  `CountriesId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_FinishPorts_CountriesId` (`CountriesId`),
  CONSTRAINT `FK_FinishPorts_Countries_CountriesId` FOREIGN KEY (`CountriesId`) REFERENCES `countries` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `finishports`
--

LOCK TABLES `finishports` WRITE;
/*!40000 ALTER TABLE `finishports` DISABLE KEYS */;
/*!40000 ALTER TABLE `finishports` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `idealmodelquestions`
--

DROP TABLE IF EXISTS `idealmodelquestions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `idealmodelquestions` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ModelQuestionsId` int NOT NULL,
  `SubSectorsId` int NOT NULL,
  `IdealExecution` decimal(18,2) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_IdealModelQuestions_ModelQuestionsId` (`ModelQuestionsId`),
  KEY `IX_IdealModelQuestions_SubSectorsId` (`SubSectorsId`),
  CONSTRAINT `FK_IdealModelQuestions_ModelQuestions_ModelQuestionsId` FOREIGN KEY (`ModelQuestionsId`) REFERENCES `modelquestions` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_IdealModelQuestions_SubSectors_SubSectorsId` FOREIGN KEY (`SubSectorsId`) REFERENCES `subsectors` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `idealmodelquestions`
--

LOCK TABLES `idealmodelquestions` WRITE;
/*!40000 ALTER TABLE `idealmodelquestions` DISABLE KEYS */;
/*!40000 ALTER TABLE `idealmodelquestions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `importdetails`
--

DROP TABLE IF EXISTS `importdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `importdetails` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ImportsId` int NOT NULL,
  `ProductsId` int NOT NULL,
  `LeadTime` datetime DEFAULT NULL,
  `Quantity` decimal(18,2) NOT NULL,
  `Amount` decimal(18,2) NOT NULL,
  `CertificationPath` text,
  `PendQuantity` decimal(18,2) NOT NULL,
  `Notes` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ImportDetails_ImportsId` (`ImportsId`),
  KEY `IX_ImportDetails_ProductsId` (`ProductsId`),
  CONSTRAINT `FK_ImportDetails_Imports_ImportsId` FOREIGN KEY (`ImportsId`) REFERENCES `imports` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ImportDetails_Products_ProductsId` FOREIGN KEY (`ProductsId`) REFERENCES `products` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `importdetails`
--

LOCK TABLES `importdetails` WRITE;
/*!40000 ALTER TABLE `importdetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `importdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `importfiles`
--

DROP TABLE IF EXISTS `importfiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `importfiles` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ImportsId` int NOT NULL,
  `Remarks` text,
  `FilePath` text,
  `LoadDate` datetime NOT NULL,
  `TypeFile` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ImportFiles_ImportsId` (`ImportsId`),
  CONSTRAINT `FK_ImportFiles_Imports_ImportsId` FOREIGN KEY (`ImportsId`) REFERENCES `imports` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `importfiles`
--

LOCK TABLES `importfiles` WRITE;
/*!40000 ALTER TABLE `importfiles` DISABLE KEYS */;
/*!40000 ALTER TABLE `importfiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `imports`
--

DROP TABLE IF EXISTS `imports`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `imports` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Order` varchar(6) NOT NULL,
  `SuppliersId` int NOT NULL,
  `Amount` decimal(18,2) NOT NULL,
  `CurrenciesId` int NOT NULL,
  `PurchaseDate` datetime NOT NULL,
  `ShipmentDate` datetime DEFAULT NULL,
  `PaymentTermsId` int NOT NULL,
  `Liquidacion` bit(1) NOT NULL,
  `Insurance` bit(1) NOT NULL,
  `Eta` datetime DEFAULT NULL,
  `Notes` text,
  `Goods` text,
  `StatusId` int NOT NULL,
  `WarehouseDate` datetime DEFAULT NULL,
  `PortDate` datetime DEFAULT NULL,
  `StartPortsId` int NOT NULL,
  `FinishPortsId` int NOT NULL,
  `DO` text,
  `TransportCompaniesId` int NOT NULL,
  `ShipmentCompaniesId` int NOT NULL,
  `IncotermsId` int NOT NULL,
  `CustomsAgenciesId` int NOT NULL,
  `Totalton` double DEFAULT NULL,
  `OC` text,
  `EA` text,
  `Dollar` decimal(18,2) DEFAULT NULL,
  `DollarSim` decimal(18,2) DEFAULT NULL,
  `DepositDate` datetime DEFAULT NULL,
  `DueDate` datetime DEFAULT NULL,
  `DocsAgencyDate` datetime DEFAULT NULL,
  `TransportDeliverDate` datetime DEFAULT NULL,
  `CustomsAuthDate` datetime DEFAULT NULL,
  `TRMCosts` decimal(18,2) DEFAULT NULL,
  `POFinishDate` datetime DEFAULT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  `PaymentMethodEntityId` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Imports_CurrenciesId` (`CurrenciesId`),
  KEY `IX_Imports_CustomsAgenciesId` (`CustomsAgenciesId`),
  KEY `IX_Imports_FinishPortsId` (`FinishPortsId`),
  KEY `IX_Imports_IncotermsId` (`IncotermsId`),
  KEY `IX_Imports_PaymentMethodEntityId` (`PaymentMethodEntityId`),
  KEY `IX_Imports_PaymentTermsId` (`PaymentTermsId`),
  KEY `IX_Imports_ShipmentCompaniesId` (`ShipmentCompaniesId`),
  KEY `IX_Imports_StartPortsId` (`StartPortsId`),
  KEY `IX_Imports_StatusId` (`StatusId`),
  KEY `IX_Imports_SuppliersId` (`SuppliersId`),
  KEY `IX_Imports_TransportCompaniesId` (`TransportCompaniesId`),
  CONSTRAINT `FK_Imports_Currencies_CurrenciesId` FOREIGN KEY (`CurrenciesId`) REFERENCES `currencies` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Imports_CustomsAgencies_CustomsAgenciesId` FOREIGN KEY (`CustomsAgenciesId`) REFERENCES `customsagencies` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Imports_FinishPorts_FinishPortsId` FOREIGN KEY (`FinishPortsId`) REFERENCES `finishports` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Imports_Incoterms_IncotermsId` FOREIGN KEY (`IncotermsId`) REFERENCES `incoterms` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Imports_PaymentMethods_PaymentMethodEntityId` FOREIGN KEY (`PaymentMethodEntityId`) REFERENCES `paymentmethods` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Imports_PaymentTerms_PaymentTermsId` FOREIGN KEY (`PaymentTermsId`) REFERENCES `paymentterms` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Imports_ShipmentCompanies_ShipmentCompaniesId` FOREIGN KEY (`ShipmentCompaniesId`) REFERENCES `shipmentcompanies` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Imports_StartPorts_StartPortsId` FOREIGN KEY (`StartPortsId`) REFERENCES `startports` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Imports_Status_StatusId` FOREIGN KEY (`StatusId`) REFERENCES `status` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Imports_Suppliers_SuppliersId` FOREIGN KEY (`SuppliersId`) REFERENCES `suppliers` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Imports_TransportCompanies_TransportCompaniesId` FOREIGN KEY (`TransportCompaniesId`) REFERENCES `transportcompanies` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `imports`
--

LOCK TABLES `imports` WRITE;
/*!40000 ALTER TABLE `imports` DISABLE KEYS */;
/*!40000 ALTER TABLE `imports` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `incoterms`
--

DROP TABLE IF EXISTS `incoterms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `incoterms` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Initials` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `incoterms`
--

LOCK TABLES `incoterms` WRITE;
/*!40000 ALTER TABLE `incoterms` DISABLE KEYS */;
/*!40000 ALTER TABLE `incoterms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `installations`
--

DROP TABLE IF EXISTS `installations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `installations` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Code` varchar(4) NOT NULL,
  `Name` varchar(80) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `installations`
--

LOCK TABLES `installations` WRITE;
/*!40000 ALTER TABLE `installations` DISABLE KEYS */;
/*!40000 ALTER TABLE `installations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `iotalerts`
--

DROP TABLE IF EXISTS `iotalerts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `iotalerts` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `IoTsId` int NOT NULL,
  `IoTVariablesId` int NOT NULL,
  `AlertColor` varchar(12) DEFAULT NULL,
  `MinAlertValue` decimal(18,4) NOT NULL,
  `MaxAlertValue` decimal(18,4) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  `IoTNotificationsId` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_IoTAlerts_IoTNotificationsId` (`IoTNotificationsId`),
  KEY `IX_IoTAlerts_IoTVariablesId` (`IoTVariablesId`),
  KEY `IX_IoTAlerts_IoTsId` (`IoTsId`),
  CONSTRAINT `FK_IoTAlerts_IoTNotifications_IoTNotificationsId` FOREIGN KEY (`IoTNotificationsId`) REFERENCES `iotnotifications` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_IoTAlerts_IoTs_IoTsId` FOREIGN KEY (`IoTsId`) REFERENCES `iots` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_IoTAlerts_IoTVariables_IoTVariablesId` FOREIGN KEY (`IoTVariablesId`) REFERENCES `iotvariables` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `iotalerts`
--

LOCK TABLES `iotalerts` WRITE;
/*!40000 ALTER TABLE `iotalerts` DISABLE KEYS */;
/*!40000 ALTER TABLE `iotalerts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `iotdataalertnotifications`
--

DROP TABLE IF EXISTS `iotdataalertnotifications`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `iotdataalertnotifications` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `EmployeesId` int NOT NULL,
  `Subject` text,
  `Seen` bit(1) NOT NULL,
  `EmailSent` bit(1) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_IoTDataAlertNotifications_EmployeesId` (`EmployeesId`),
  CONSTRAINT `FK_IoTDataAlertNotifications_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `employees` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `iotdataalertnotifications`
--

LOCK TABLES `iotdataalertnotifications` WRITE;
/*!40000 ALTER TABLE `iotdataalertnotifications` DISABLE KEYS */;
/*!40000 ALTER TABLE `iotdataalertnotifications` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `iotdatas`
--

DROP TABLE IF EXISTS `iotdatas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `iotdatas` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `DispositivoIOT` int NOT NULL,
  `Nombres` varchar(80) NOT NULL,
  `Valores` varchar(50) NOT NULL,
  `Fecha` datetime DEFAULT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `iotdatas`
--

LOCK TABLES `iotdatas` WRITE;
/*!40000 ALTER TABLE `iotdatas` DISABLE KEYS */;
/*!40000 ALTER TABLE `iotdatas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `iotmachines`
--

DROP TABLE IF EXISTS `iotmachines`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `iotmachines` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `IoTsId` int NOT NULL,
  `MachinesId` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `iotmachines`
--

LOCK TABLES `iotmachines` WRITE;
/*!40000 ALTER TABLE `iotmachines` DISABLE KEYS */;
/*!40000 ALTER TABLE `iotmachines` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `iotnotifications`
--

DROP TABLE IF EXISTS `iotnotifications`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `iotnotifications` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `IoTsId` int NOT NULL,
  `IoTAlertsId` int NOT NULL,
  `Emails` text NOT NULL,
  `Subject` varchar(150) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_IoTNotifications_IoTsId` (`IoTsId`),
  CONSTRAINT `FK_IoTNotifications_IoTs_IoTsId` FOREIGN KEY (`IoTsId`) REFERENCES `iots` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `iotnotifications`
--

LOCK TABLES `iotnotifications` WRITE;
/*!40000 ALTER TABLE `iotnotifications` DISABLE KEYS */;
/*!40000 ALTER TABLE `iotnotifications` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `iots`
--

DROP TABLE IF EXISTS `iots`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `iots` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `CodeIoT` varchar(5) NOT NULL,
  `URLPath` varchar(100) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `iots`
--

LOCK TABLES `iots` WRITE;
/*!40000 ALTER TABLE `iots` DISABLE KEYS */;
/*!40000 ALTER TABLE `iots` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `iotvariables`
--

DROP TABLE IF EXISTS `iotvariables`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `iotvariables` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `IoTsId` int NOT NULL,
  `MinValue` decimal(18,4) NOT NULL,
  `MaxValue` decimal(18,4) NOT NULL,
  `UpdateInterval` decimal(18,4) NOT NULL,
  `DailyReset` bit(1) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_IoTVariables_IoTsId` (`IoTsId`),
  CONSTRAINT `FK_IoTVariables_IoTs_IoTsId` FOREIGN KEY (`IoTsId`) REFERENCES `iots` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `iotvariables`
--

LOCK TABLES `iotvariables` WRITE;
/*!40000 ALTER TABLE `iotvariables` DISABLE KEYS */;
/*!40000 ALTER TABLE `iotvariables` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jobs`
--

DROP TABLE IF EXISTS `jobs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jobs` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jobs`
--

LOCK TABLES `jobs` WRITE;
/*!40000 ALTER TABLE `jobs` DISABLE KEYS */;
/*!40000 ALTER TABLE `jobs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `locations`
--

DROP TABLE IF EXISTS `locations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `locations` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `locations`
--

LOCK TABLES `locations` WRITE;
/*!40000 ALTER TABLE `locations` DISABLE KEYS */;
/*!40000 ALTER TABLE `locations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `machines`
--

DROP TABLE IF EXISTS `machines`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `machines` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `StatusId` int NOT NULL,
  `Model` varchar(50) NOT NULL,
  `Year` int NOT NULL,
  `Cost` decimal(18,2) NOT NULL,
  `Insurance` bit(1) NOT NULL,
  `Reference` text,
  `LocationsId` int NOT NULL,
  `BrandsId` int NOT NULL,
  `ProcessesId` int NOT NULL,
  `OutputStandard` decimal(18,2) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  `IoTMachineEntityId` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Machines_BrandsId` (`BrandsId`),
  KEY `IX_Machines_IoTMachineEntityId` (`IoTMachineEntityId`),
  KEY `IX_Machines_LocationsId` (`LocationsId`),
  KEY `IX_Machines_ProcessesId` (`ProcessesId`),
  KEY `IX_Machines_StatusId` (`StatusId`),
  CONSTRAINT `FK_Machines_Brands_BrandsId` FOREIGN KEY (`BrandsId`) REFERENCES `brands` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Machines_IoTMachines_IoTMachineEntityId` FOREIGN KEY (`IoTMachineEntityId`) REFERENCES `iotmachines` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Machines_Locations_LocationsId` FOREIGN KEY (`LocationsId`) REFERENCES `locations` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Machines_Processes_ProcessesId` FOREIGN KEY (`ProcessesId`) REFERENCES `processes` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Machines_Status_StatusId` FOREIGN KEY (`StatusId`) REFERENCES `status` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `machines`
--

LOCK TABLES `machines` WRITE;
/*!40000 ALTER TABLE `machines` DISABLE KEYS */;
/*!40000 ALTER TABLE `machines` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `metalunits`
--

DROP TABLE IF EXISTS `metalunits`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `metalunits` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `MetalCode` varchar(8) DEFAULT NULL,
  `WarehouseDate` datetime NOT NULL,
  `MetalUnitTypesId` int NOT NULL,
  `SteelsId` int NOT NULL,
  `ThicknessesId` int NOT NULL,
  `DimensionsId` int NOT NULL,
  `FinishesesId` int NOT NULL,
  `WHLocationsId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_MetalUnits_DimensionsId` (`DimensionsId`),
  KEY `IX_MetalUnits_FinishesesId` (`FinishesesId`),
  KEY `IX_MetalUnits_MetalUnitTypesId` (`MetalUnitTypesId`),
  KEY `IX_MetalUnits_SteelsId` (`SteelsId`),
  KEY `IX_MetalUnits_ThicknessesId` (`ThicknessesId`),
  KEY `IX_MetalUnits_WHLocationsId` (`WHLocationsId`),
  CONSTRAINT `FK_MetalUnits_Dimensions_DimensionsId` FOREIGN KEY (`DimensionsId`) REFERENCES `dimensions` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_MetalUnits_Finisheses_FinishesesId` FOREIGN KEY (`FinishesesId`) REFERENCES `finisheses` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_MetalUnits_MetalUnitTypes_MetalUnitTypesId` FOREIGN KEY (`MetalUnitTypesId`) REFERENCES `metalunittypes` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_MetalUnits_Steels_SteelsId` FOREIGN KEY (`SteelsId`) REFERENCES `steels` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_MetalUnits_Thicknesses_ThicknessesId` FOREIGN KEY (`ThicknessesId`) REFERENCES `thicknesses` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_MetalUnits_WHLocations_WHLocationsId` FOREIGN KEY (`WHLocationsId`) REFERENCES `whlocations` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `metalunits`
--

LOCK TABLES `metalunits` WRITE;
/*!40000 ALTER TABLE `metalunits` DISABLE KEYS */;
/*!40000 ALTER TABLE `metalunits` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `metalunittypes`
--

DROP TABLE IF EXISTS `metalunittypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `metalunittypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `metalunittypes`
--

LOCK TABLES `metalunittypes` WRITE;
/*!40000 ALTER TABLE `metalunittypes` DISABLE KEYS */;
/*!40000 ALTER TABLE `metalunittypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `methods`
--

DROP TABLE IF EXISTS `methods`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `methods` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Code` varchar(4) NOT NULL,
  `Name` varchar(80) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `methods`
--

LOCK TABLES `methods` WRITE;
/*!40000 ALTER TABLE `methods` DISABLE KEYS */;
/*!40000 ALTER TABLE `methods` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modelquestions`
--

DROP TABLE IF EXISTS `modelquestions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `modelquestions` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `QuestionName` text NOT NULL,
  `EvaluationCategoriesId` int NOT NULL,
  `CategoryModelsId` int NOT NULL,
  `WeightQuestion` decimal(18,2) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ModelQuestions_CategoryModelsId` (`CategoryModelsId`),
  KEY `IX_ModelQuestions_EvaluationCategoriesId` (`EvaluationCategoriesId`),
  CONSTRAINT `FK_ModelQuestions_CategoryModels_CategoryModelsId` FOREIGN KEY (`CategoryModelsId`) REFERENCES `categorymodels` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ModelQuestions_EvaluationCategories_EvaluationCategoriesId` FOREIGN KEY (`EvaluationCategoriesId`) REFERENCES `evaluationcategories` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modelquestions`
--

LOCK TABLES `modelquestions` WRITE;
/*!40000 ALTER TABLE `modelquestions` DISABLE KEYS */;
/*!40000 ALTER TABLE `modelquestions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modulecategories`
--

DROP TABLE IF EXISTS `modulecategories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `modulecategories` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modulecategories`
--

LOCK TABLES `modulecategories` WRITE;
/*!40000 ALTER TABLE `modulecategories` DISABLE KEYS */;
/*!40000 ALTER TABLE `modulecategories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `moduleroles`
--

DROP TABLE IF EXISTS `moduleroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `moduleroles` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `SubModulesId` int NOT NULL,
  `Access` bit(1) NOT NULL,
  `RolId` text NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ModuleRoles_SubModulesId` (`SubModulesId`),
  CONSTRAINT `FK_ModuleRoles_SubModules_SubModulesId` FOREIGN KEY (`SubModulesId`) REFERENCES `submodules` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `moduleroles`
--

LOCK TABLES `moduleroles` WRITE;
/*!40000 ALTER TABLE `moduleroles` DISABLE KEYS */;
/*!40000 ALTER TABLE `moduleroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modules`
--

DROP TABLE IF EXISTS `modules`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `modules` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `Order` int NOT NULL,
  `ModuleCategoriesId` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Modules_ModuleCategoriesId` (`ModuleCategoriesId`),
  CONSTRAINT `FK_Modules_ModuleCategories_ModuleCategoriesId` FOREIGN KEY (`ModuleCategoriesId`) REFERENCES `modulecategories` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modules`
--

LOCK TABLES `modules` WRITE;
/*!40000 ALTER TABLE `modules` DISABLE KEYS */;
/*!40000 ALTER TABLE `modules` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movementbasics`
--

DROP TABLE IF EXISTS `movementbasics`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movementbasics` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Code` varchar(10) NOT NULL,
  `Name` varchar(80) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movementbasics`
--

LOCK TABLES `movementbasics` WRITE;
/*!40000 ALTER TABLE `movementbasics` DISABLE KEYS */;
/*!40000 ALTER TABLE `movementbasics` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movementclasses`
--

DROP TABLE IF EXISTS `movementclasses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movementclasses` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Code` varchar(10) NOT NULL,
  `Distance` varchar(50) NOT NULL,
  `MotionRange` varchar(150) DEFAULT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movementclasses`
--

LOCK TABLES `movementclasses` WRITE;
/*!40000 ALTER TABLE `movementclasses` DISABLE KEYS */;
/*!40000 ALTER TABLE `movementclasses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movementdetails`
--

DROP TABLE IF EXISTS `movementdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movementdetails` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Code` varchar(10) NOT NULL,
  `Name` varchar(80) NOT NULL,
  `MovementBasicsId` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_MovementDetails_MovementBasicsId` (`MovementBasicsId`),
  CONSTRAINT `FK_MovementDetails_MovementBasics_MovementBasicsId` FOREIGN KEY (`MovementBasicsId`) REFERENCES `movementbasics` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movementdetails`
--

LOCK TABLES `movementdetails` WRITE;
/*!40000 ALTER TABLE `movementdetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `movementdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movements`
--

DROP TABLE IF EXISTS `movements`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movements` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Distance` double DEFAULT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movements`
--

LOCK TABLES `movements` WRITE;
/*!40000 ALTER TABLE `movements` DISABLE KEYS */;
/*!40000 ALTER TABLE `movements` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movementtypes`
--

DROP TABLE IF EXISTS `movementtypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movementtypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movementtypes`
--

LOCK TABLES `movementtypes` WRITE;
/*!40000 ALTER TABLE `movementtypes` DISABLE KEYS */;
/*!40000 ALTER TABLE `movementtypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `packinglists`
--

DROP TABLE IF EXISTS `packinglists`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `packinglists` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ImportsId` int NOT NULL,
  `ImportDetailsId` int NOT NULL,
  `Heat` varchar(40) NOT NULL,
  `Package` varchar(40) DEFAULT NULL,
  `Pieces` decimal(18,2) NOT NULL,
  `GrossWeight` decimal(18,2) NOT NULL,
  `NetWeight` decimal(18,2) NOT NULL,
  `Remarks` text,
  `LoadDate` datetime NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_PackingLists_ImportDetailsId` (`ImportDetailsId`),
  KEY `IX_PackingLists_ImportsId` (`ImportsId`),
  CONSTRAINT `FK_PackingLists_ImportDetails_ImportDetailsId` FOREIGN KEY (`ImportDetailsId`) REFERENCES `importdetails` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_PackingLists_Imports_ImportsId` FOREIGN KEY (`ImportsId`) REFERENCES `imports` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `packinglists`
--

LOCK TABLES `packinglists` WRITE;
/*!40000 ALTER TABLE `packinglists` DISABLE KEYS */;
/*!40000 ALTER TABLE `packinglists` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paymentmethods`
--

DROP TABLE IF EXISTS `paymentmethods`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paymentmethods` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paymentmethods`
--

LOCK TABLES `paymentmethods` WRITE;
/*!40000 ALTER TABLE `paymentmethods` DISABLE KEYS */;
/*!40000 ALTER TABLE `paymentmethods` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payments` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ImportsId` int NOT NULL,
  `BanksId` int NOT NULL,
  `PaymentTypesId` int NOT NULL,
  `CurrenciesId` int NOT NULL,
  `Amount` decimal(18,2) NOT NULL,
  `PaymentDate` datetime NOT NULL,
  `Legalization` bit(1) NOT NULL,
  `LegalDate` datetime DEFAULT NULL,
  `ChangeRate` decimal(18,2) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Payments_BanksId` (`BanksId`),
  KEY `IX_Payments_CurrenciesId` (`CurrenciesId`),
  KEY `IX_Payments_ImportsId` (`ImportsId`),
  KEY `IX_Payments_PaymentTypesId` (`PaymentTypesId`),
  CONSTRAINT `FK_Payments_Banks_BanksId` FOREIGN KEY (`BanksId`) REFERENCES `banks` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Payments_Currencies_CurrenciesId` FOREIGN KEY (`CurrenciesId`) REFERENCES `currencies` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Payments_Imports_ImportsId` FOREIGN KEY (`ImportsId`) REFERENCES `imports` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Payments_PaymentTypes_PaymentTypesId` FOREIGN KEY (`PaymentTypesId`) REFERENCES `paymenttypes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments`
--

LOCK TABLES `payments` WRITE;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
/*!40000 ALTER TABLE `payments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paymentterms`
--

DROP TABLE IF EXISTS `paymentterms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paymentterms` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Days` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paymentterms`
--

LOCK TABLES `paymentterms` WRITE;
/*!40000 ALTER TABLE `paymentterms` DISABLE KEYS */;
/*!40000 ALTER TABLE `paymentterms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paymenttypes`
--

DROP TABLE IF EXISTS `paymenttypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paymenttypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paymenttypes`
--

LOCK TABLES `paymenttypes` WRITE;
/*!40000 ALTER TABLE `paymenttypes` DISABLE KEYS */;
/*!40000 ALTER TABLE `paymenttypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `planpayments`
--

DROP TABLE IF EXISTS `planpayments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `planpayments` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `CompanyId` int NOT NULL,
  `PlansId` int NOT NULL,
  `PurchaseDate` datetime NOT NULL,
  `PaymentTypesId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_PlanPayments_PaymentTypesId` (`PaymentTypesId`),
  KEY `IX_PlanPayments_PlansId` (`PlansId`),
  CONSTRAINT `FK_PlanPayments_PaymentTypes_PaymentTypesId` FOREIGN KEY (`PaymentTypesId`) REFERENCES `paymenttypes` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_PlanPayments_Plans_PlansId` FOREIGN KEY (`PlansId`) REFERENCES `plans` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `planpayments`
--

LOCK TABLES `planpayments` WRITE;
/*!40000 ALTER TABLE `planpayments` DISABLE KEYS */;
/*!40000 ALTER TABLE `planpayments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `plans`
--

DROP TABLE IF EXISTS `plans`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `plans` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `LastPurchase` datetime NOT NULL,
  `ActiveDays` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `plans`
--

LOCK TABLES `plans` WRITE;
/*!40000 ALTER TABLE `plans` DISABLE KEYS */;
/*!40000 ALTER TABLE `plans` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pricecuts`
--

DROP TABLE IF EXISTS `pricecuts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pricecuts` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `MeatCuttingId` int NOT NULL,
  `MalePrice` decimal(18,2) NOT NULL,
  `FemalePrice` decimal(18,2) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_PriceCuts_MeatCuttingId` (`MeatCuttingId`),
  CONSTRAINT `FK_PriceCuts_CutsOfMeats_MeatCuttingId` FOREIGN KEY (`MeatCuttingId`) REFERENCES `cutsofmeats` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pricecuts`
--

LOCK TABLES `pricecuts` WRITE;
/*!40000 ALTER TABLE `pricecuts` DISABLE KEYS */;
/*!40000 ALTER TABLE `pricecuts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pricelists`
--

DROP TABLE IF EXISTS `pricelists`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pricelists` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Initials` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pricelists`
--

LOCK TABLES `pricelists` WRITE;
/*!40000 ALTER TABLE `pricelists` DISABLE KEYS */;
/*!40000 ALTER TABLE `pricelists` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `processes`
--

DROP TABLE IF EXISTS `processes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `processes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `ProductionTarget` decimal(18,2) DEFAULT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `processes`
--

LOCK TABLES `processes` WRITE;
/*!40000 ALTER TABLE `processes` DISABLE KEYS */;
/*!40000 ALTER TABLE `processes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productioninfos`
--

DROP TABLE IF EXISTS `productioninfos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productioninfos` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ProductionOrdersId` int NOT NULL,
  `ProductsId` int NOT NULL,
  `DeliveryDate` datetime NOT NULL,
  `Quantity` decimal(18,2) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ProductionInfos_ProductionOrdersId` (`ProductionOrdersId`),
  KEY `IX_ProductionInfos_ProductsId` (`ProductsId`),
  CONSTRAINT `FK_ProductionInfos_ProductionOrders_ProductionOrdersId` FOREIGN KEY (`ProductionOrdersId`) REFERENCES `productionorders` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ProductionInfos_Products_ProductsId` FOREIGN KEY (`ProductsId`) REFERENCES `products` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productioninfos`
--

LOCK TABLES `productioninfos` WRITE;
/*!40000 ALTER TABLE `productioninfos` DISABLE KEYS */;
/*!40000 ALTER TABLE `productioninfos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productionorderdetails`
--

DROP TABLE IF EXISTS `productionorderdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productionorderdetails` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ProductionOrdersId` int NOT NULL,
  `EmployeesId` int NOT NULL,
  `StartDateTime` datetime DEFAULT NULL,
  `FinishDateTime` datetime DEFAULT NULL,
  `TuneUp` int DEFAULT NULL,
  `LenghtDifference` decimal(18,2) DEFAULT NULL,
  `Speed` decimal(18,2) DEFAULT NULL,
  `ProdQuantity` decimal(18,2) DEFAULT NULL,
  `OddmentQuantity` decimal(18,2) DEFAULT NULL,
  `WasteQuantity` decimal(18,2) DEFAULT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ProductionOrderDetails_EmployeesId` (`EmployeesId`),
  KEY `IX_ProductionOrderDetails_ProductionOrdersId` (`ProductionOrdersId`),
  CONSTRAINT `FK_ProductionOrderDetails_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `employees` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ProductionOrderDetails_ProductionOrders_ProductionOrdersId` FOREIGN KEY (`ProductionOrdersId`) REFERENCES `productionorders` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productionorderdetails`
--

LOCK TABLES `productionorderdetails` WRITE;
/*!40000 ALTER TABLE `productionorderdetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `productionorderdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productionorderfiles`
--

DROP TABLE IF EXISTS `productionorderfiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productionorderfiles` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ProductionOrdersId` int NOT NULL,
  `Remarks` text,
  `FilePath` text,
  `LoadDate` datetime NOT NULL,
  `TypeFile` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ProductionOrderFiles_ProductionOrdersId` (`ProductionOrdersId`),
  CONSTRAINT `FK_ProductionOrderFiles_ProductionOrders_ProductionOrdersId` FOREIGN KEY (`ProductionOrdersId`) REFERENCES `productionorders` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productionorderfiles`
--

LOCK TABLES `productionorderfiles` WRITE;
/*!40000 ALTER TABLE `productionorderfiles` DISABLE KEYS */;
/*!40000 ALTER TABLE `productionorderfiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productionorderprocesses`
--

DROP TABLE IF EXISTS `productionorderprocesses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productionorderprocesses` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ProductionOrdersId` int NOT NULL,
  `MachinesId` int NOT NULL,
  `ScheduleDate` datetime NOT NULL,
  `EmployeesId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ProductionOrderProcesses_EmployeesId` (`EmployeesId`),
  KEY `IX_ProductionOrderProcesses_MachinesId` (`MachinesId`),
  KEY `IX_ProductionOrderProcesses_ProductionOrdersId` (`ProductionOrdersId`),
  CONSTRAINT `FK_ProductionOrderProcesses_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `employees` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ProductionOrderProcesses_Machines_MachinesId` FOREIGN KEY (`MachinesId`) REFERENCES `machines` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ProductionOrderProcesses_ProductionOrders_ProductionOrdersId` FOREIGN KEY (`ProductionOrdersId`) REFERENCES `productionorders` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productionorderprocesses`
--

LOCK TABLES `productionorderprocesses` WRITE;
/*!40000 ALTER TABLE `productionorderprocesses` DISABLE KEYS */;
/*!40000 ALTER TABLE `productionorderprocesses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productionorders`
--

DROP TABLE IF EXISTS `productionorders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productionorders` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ProdDate` datetime DEFAULT NULL,
  `ProdStartDate` datetime DEFAULT NULL,
  `ProdFinishDate` datetime DEFAULT NULL,
  `Order` varchar(15) DEFAULT NULL,
  `StatusId` int NOT NULL,
  `Lot` int DEFAULT NULL,
  `ProductsId` int NOT NULL,
  `ShiftsId` int NOT NULL,
  `MinPackageWeight` decimal(18,2) DEFAULT NULL,
  `MaxPackageWeight` decimal(18,2) DEFAULT NULL,
  `Lenght` decimal(18,2) DEFAULT NULL,
  `LenghtTolerance` decimal(18,2) DEFAULT NULL,
  `ExpectedQuantity` decimal(18,2) DEFAULT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ProductionOrders_ProductsId` (`ProductsId`),
  KEY `IX_ProductionOrders_ShiftsId` (`ShiftsId`),
  KEY `IX_ProductionOrders_StatusId` (`StatusId`),
  CONSTRAINT `FK_ProductionOrders_Products_ProductsId` FOREIGN KEY (`ProductsId`) REFERENCES `products` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ProductionOrders_Shifts_ShiftsId` FOREIGN KEY (`ShiftsId`) REFERENCES `shifts` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ProductionOrders_Status_StatusId` FOREIGN KEY (`StatusId`) REFERENCES `status` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productionorders`
--

LOCK TABLES `productionorders` WRITE;
/*!40000 ALTER TABLE `productionorders` DISABLE KEYS */;
/*!40000 ALTER TABLE `productionorders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productionstops`
--

DROP TABLE IF EXISTS `productionstops`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productionstops` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ProductionOrdersId` int NOT NULL,
  `StopsId` int NOT NULL,
  `MachinesId` int NOT NULL,
  `StartDateTime` datetime DEFAULT NULL,
  `FinishDateTime` datetime DEFAULT NULL,
  `EmployeesId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ProductionStops_EmployeesId` (`EmployeesId`),
  KEY `IX_ProductionStops_MachinesId` (`MachinesId`),
  KEY `IX_ProductionStops_ProductionOrdersId` (`ProductionOrdersId`),
  KEY `IX_ProductionStops_StopsId` (`StopsId`),
  CONSTRAINT `FK_ProductionStops_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `employees` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ProductionStops_Machines_MachinesId` FOREIGN KEY (`MachinesId`) REFERENCES `machines` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ProductionStops_ProductionOrders_ProductionOrdersId` FOREIGN KEY (`ProductionOrdersId`) REFERENCES `productionorders` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ProductionStops_Stops_StopsId` FOREIGN KEY (`StopsId`) REFERENCES `stops` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productionstops`
--

LOCK TABLES `productionstops` WRITE;
/*!40000 ALTER TABLE `productionstops` DISABLE KEYS */;
/*!40000 ALTER TABLE `productionstops` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Code` varchar(8) DEFAULT NULL,
  `Name` varchar(100) NOT NULL,
  `UnitsId` int NOT NULL,
  `CodeERP` varchar(8) DEFAULT NULL,
  `Minimum` decimal(18,2) NOT NULL,
  `Maximum` decimal(18,2) NOT NULL,
  `Factor1` decimal(18,2) NOT NULL,
  `Factor2` decimal(18,2) NOT NULL,
  `Weight` decimal(18,2) NOT NULL,
  `ProductTypesId` int NOT NULL,
  `ShapesId` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Products_ProductTypesId` (`ProductTypesId`),
  KEY `IX_Products_ShapesId` (`ShapesId`),
  KEY `IX_Products_UnitsId` (`UnitsId`),
  CONSTRAINT `FK_Products_ProductTypes_ProductTypesId` FOREIGN KEY (`ProductTypesId`) REFERENCES `producttypes` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Products_Shapes_ShapesId` FOREIGN KEY (`ShapesId`) REFERENCES `shapes` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Products_Units_UnitsId` FOREIGN KEY (`UnitsId`) REFERENCES `units` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producttypes`
--

DROP TABLE IF EXISTS `producttypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producttypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producttypes`
--

LOCK TABLES `producttypes` WRITE;
/*!40000 ALTER TABLE `producttypes` DISABLE KEYS */;
/*!40000 ALTER TABLE `producttypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `protectioncategories`
--

DROP TABLE IF EXISTS `protectioncategories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `protectioncategories` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `protectioncategories`
--

LOCK TABLES `protectioncategories` WRITE;
/*!40000 ALTER TABLE `protectioncategories` DISABLE KEYS */;
/*!40000 ALTER TABLE `protectioncategories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `protectionelements`
--

DROP TABLE IF EXISTS `protectionelements`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `protectionelements` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Code` varchar(8) DEFAULT NULL,
  `Name` varchar(100) NOT NULL,
  `UnitsId` int NOT NULL,
  `CodeERP` varchar(8) DEFAULT NULL,
  `Minimum` decimal(18,2) NOT NULL,
  `Maximum` decimal(18,2) NOT NULL,
  `Factor1` decimal(18,2) NOT NULL,
  `Factor2` decimal(18,2) NOT NULL,
  `MaxDayAsignment` decimal(18,2) NOT NULL,
  `Weight` decimal(18,2) NOT NULL,
  `ProtectionTypesId` int NOT NULL,
  `Remarks` text,
  `ImageElement` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ProtectionElements_ProtectionTypesId` (`ProtectionTypesId`),
  KEY `IX_ProtectionElements_UnitsId` (`UnitsId`),
  CONSTRAINT `FK_ProtectionElements_ProtectionTypes_ProtectionTypesId` FOREIGN KEY (`ProtectionTypesId`) REFERENCES `protectiontypes` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ProtectionElements_Units_UnitsId` FOREIGN KEY (`UnitsId`) REFERENCES `units` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `protectionelements`
--

LOCK TABLES `protectionelements` WRITE;
/*!40000 ALTER TABLE `protectionelements` DISABLE KEYS */;
/*!40000 ALTER TABLE `protectionelements` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `protectiontypes`
--

DROP TABLE IF EXISTS `protectiontypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `protectiontypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `ProtectionCategoriesId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ProtectionTypes_ProtectionCategoriesId` (`ProtectionCategoriesId`),
  CONSTRAINT `FK_ProtectionTypes_ProtectionCategories_ProtectionCategoriesId` FOREIGN KEY (`ProtectionCategoriesId`) REFERENCES `protectioncategories` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `protectiontypes`
--

LOCK TABLES `protectiontypes` WRITE;
/*!40000 ALTER TABLE `protectiontypes` DISABLE KEYS */;
/*!40000 ALTER TABLE `protectiontypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `quantitysaletops`
--

DROP TABLE IF EXISTS `quantitysaletops`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `quantitysaletops` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `MeatCuttingId` int NOT NULL,
  `Quantity` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_QuantitySaleTops_MeatCuttingId` (`MeatCuttingId`),
  CONSTRAINT `FK_QuantitySaleTops_CutsOfMeats_MeatCuttingId` FOREIGN KEY (`MeatCuttingId`) REFERENCES `cutsofmeats` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quantitysaletops`
--

LOCK TABLES `quantitysaletops` WRITE;
/*!40000 ALTER TABLE `quantitysaletops` DISABLE KEYS */;
/*!40000 ALTER TABLE `quantitysaletops` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rawmaterials`
--

DROP TABLE IF EXISTS `rawmaterials`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rawmaterials` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `RawCode` varchar(8) DEFAULT NULL,
  `Name` varchar(80) DEFAULT NULL,
  `WarehouseDate` datetime NOT NULL,
  `RawMaterialTypesId` int NOT NULL,
  `WHLocationsId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  `PackingListsId` int NOT NULL,
  `ProductionOrdersId` int DEFAULT NULL,
  `RawMaterialTypeEntityId` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_RawMaterials_PackingListsId` (`PackingListsId`),
  KEY `IX_RawMaterials_ProductionOrdersId` (`ProductionOrdersId`),
  KEY `IX_RawMaterials_RawMaterialTypeEntityId` (`RawMaterialTypeEntityId`),
  KEY `IX_RawMaterials_RawMaterialTypesId` (`RawMaterialTypesId`),
  KEY `IX_RawMaterials_WHLocationsId` (`WHLocationsId`),
  CONSTRAINT `FK_RawMaterials_MetalUnitTypes_RawMaterialTypesId` FOREIGN KEY (`RawMaterialTypesId`) REFERENCES `metalunittypes` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_RawMaterials_PackingLists_PackingListsId` FOREIGN KEY (`PackingListsId`) REFERENCES `packinglists` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_RawMaterials_ProductionOrders_ProductionOrdersId` FOREIGN KEY (`ProductionOrdersId`) REFERENCES `productionorders` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_RawMaterials_RawMaterialTypes_RawMaterialTypeEntityId` FOREIGN KEY (`RawMaterialTypeEntityId`) REFERENCES `rawmaterialtypes` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_RawMaterials_WHLocations_WHLocationsId` FOREIGN KEY (`WHLocationsId`) REFERENCES `whlocations` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rawmaterials`
--

LOCK TABLES `rawmaterials` WRITE;
/*!40000 ALTER TABLE `rawmaterials` DISABLE KEYS */;
/*!40000 ALTER TABLE `rawmaterials` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rawmaterialtypes`
--

DROP TABLE IF EXISTS `rawmaterialtypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rawmaterialtypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rawmaterialtypes`
--

LOCK TABLES `rawmaterialtypes` WRITE;
/*!40000 ALTER TABLE `rawmaterialtypes` DISABLE KEYS */;
/*!40000 ALTER TABLE `rawmaterialtypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `routeoperations`
--

DROP TABLE IF EXISTS `routeoperations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `routeoperations` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `RoutesId` int NOT NULL,
  `Code` int NOT NULL,
  `ProcessesId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_RouteOperations_ProcessesId` (`ProcessesId`),
  KEY `IX_RouteOperations_RoutesId` (`RoutesId`),
  CONSTRAINT `FK_RouteOperations_Processes_ProcessesId` FOREIGN KEY (`ProcessesId`) REFERENCES `processes` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_RouteOperations_Routes_RoutesId` FOREIGN KEY (`RoutesId`) REFERENCES `routes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `routeoperations`
--

LOCK TABLES `routeoperations` WRITE;
/*!40000 ALTER TABLE `routeoperations` DISABLE KEYS */;
/*!40000 ALTER TABLE `routeoperations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `routes`
--

DROP TABLE IF EXISTS `routes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `routes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `InstallationsId` int NOT NULL,
  `Code` varchar(30) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Active` bit(1) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Routes_InstallationsId` (`InstallationsId`),
  CONSTRAINT `FK_Routes_Installations_InstallationsId` FOREIGN KEY (`InstallationsId`) REFERENCES `installations` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `routes`
--

LOCK TABLES `routes` WRITE;
/*!40000 ALTER TABLE `routes` DISABLE KEYS */;
/*!40000 ALTER TABLE `routes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sectors`
--

DROP TABLE IF EXISTS `sectors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sectors` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Sector` varchar(150) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sectors`
--

LOCK TABLES `sectors` WRITE;
/*!40000 ALTER TABLE `sectors` DISABLE KEYS */;
/*!40000 ALTER TABLE `sectors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shapes`
--

DROP TABLE IF EXISTS `shapes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `shapes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shapes`
--

LOCK TABLES `shapes` WRITE;
/*!40000 ALTER TABLE `shapes` DISABLE KEYS */;
/*!40000 ALTER TABLE `shapes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shifts`
--

DROP TABLE IF EXISTS `shifts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `shifts` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) NOT NULL,
  `ShiftStart` datetime NOT NULL,
  `ShiftEnd` datetime NOT NULL,
  `RestTimeShift` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shifts`
--

LOCK TABLES `shifts` WRITE;
/*!40000 ALTER TABLE `shifts` DISABLE KEYS */;
/*!40000 ALTER TABLE `shifts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shipmentcompanies`
--

DROP TABLE IF EXISTS `shipmentcompanies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `shipmentcompanies` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `URLTracking` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shipmentcompanies`
--

LOCK TABLES `shipmentcompanies` WRITE;
/*!40000 ALTER TABLE `shipmentcompanies` DISABLE KEYS */;
/*!40000 ALTER TABLE `shipmentcompanies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `species`
--

DROP TABLE IF EXISTS `species`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `species` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `species`
--

LOCK TABLES `species` WRITE;
/*!40000 ALTER TABLE `species` DISABLE KEYS */;
INSERT INTO `species` VALUES (1,'CERDO',1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-01-12 00:00:00','2021-01-12 00:00:00'),(2,'RES',1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-01-12 00:00:00','2021-01-12 00:00:00'),(3,'POLLO',1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-01-12 00:00:00','2021-01-12 00:00:00'),(5,'PESCADO',1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00');
/*!40000 ALTER TABLE `species` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `startports`
--

DROP TABLE IF EXISTS `startports`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `startports` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Latitude` text,
  `Longitude` text,
  `CompanyId` int NOT NULL,
  `CountriesId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_StartPorts_CountriesId` (`CountriesId`),
  CONSTRAINT `FK_StartPorts_Countries_CountriesId` FOREIGN KEY (`CountriesId`) REFERENCES `countries` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `startports`
--

LOCK TABLES `startports` WRITE;
/*!40000 ALTER TABLE `startports` DISABLE KEYS */;
/*!40000 ALTER TABLE `startports` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `status`
--

DROP TABLE IF EXISTS `status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `status` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Module` text NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status`
--

LOCK TABLES `status` WRITE;
/*!40000 ALTER TABLE `status` DISABLE KEYS */;
INSERT INTO `status` VALUES (1,'PLANIFICADO','STRIPPING',1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-01 19:24:15','2021-12-01 19:24:15'),(2,'EN PRODUCCION','STRIPPING',1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(3,'FINALIZADO','STRIPPING',1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00'),(4,'DEFINICION','STRIPPING',1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-12-02 07:47:58','2021-12-02 07:47:58');
/*!40000 ALTER TABLE `status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `steels`
--

DROP TABLE IF EXISTS `steels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `steels` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `DIN` varchar(15) DEFAULT NULL,
  `AISI` varchar(15) DEFAULT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `steels`
--

LOCK TABLES `steels` WRITE;
/*!40000 ALTER TABLE `steels` DISABLE KEYS */;
/*!40000 ALTER TABLE `steels` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stops`
--

DROP TABLE IF EXISTS `stops`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stops` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `StopsCategoriesId` int NOT NULL,
  `Level` varchar(4) NOT NULL,
  `Code` varchar(4) NOT NULL,
  `Name` varchar(150) NOT NULL,
  `AreasId` int NOT NULL,
  `Cost` decimal(18,2) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Stops_AreasId` (`AreasId`),
  KEY `IX_Stops_StopsCategoriesId` (`StopsCategoriesId`),
  CONSTRAINT `FK_Stops_Areas_AreasId` FOREIGN KEY (`AreasId`) REFERENCES `areas` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Stops_StopsCategories_StopsCategoriesId` FOREIGN KEY (`StopsCategoriesId`) REFERENCES `stopscategories` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stops`
--

LOCK TABLES `stops` WRITE;
/*!40000 ALTER TABLE `stops` DISABLE KEYS */;
/*!40000 ALTER TABLE `stops` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stopscategories`
--

DROP TABLE IF EXISTS `stopscategories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stopscategories` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Level` varchar(4) NOT NULL,
  `Code` varchar(4) NOT NULL,
  `Name` varchar(150) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stopscategories`
--

LOCK TABLES `stopscategories` WRITE;
/*!40000 ALTER TABLE `stopscategories` DISABLE KEYS */;
/*!40000 ALTER TABLE `stopscategories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `strippingdetails`
--

DROP TABLE IF EXISTS `strippingdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `strippingdetails` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `StrippingId` int NOT NULL,
  `ChannelId` int NOT NULL,
  `ChannelCategoryId` int NOT NULL,
  `Weight` decimal(18,2) NOT NULL,
  `Quantity` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_StrippingDetails_ChannelCategoryId` (`ChannelCategoryId`),
  KEY `IX_StrippingDetails_ChannelId` (`ChannelId`),
  KEY `IX_StrippingDetails_StrippingId` (`StrippingId`),
  CONSTRAINT `FK_StrippingDetails_ChannelCategories_ChannelCategoryId` FOREIGN KEY (`ChannelCategoryId`) REFERENCES `channelcategories` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_StrippingDetails_Channels_ChannelId` FOREIGN KEY (`ChannelId`) REFERENCES `channels` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_StrippingDetails_Strips_StrippingId` FOREIGN KEY (`StrippingId`) REFERENCES `strips` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `strippingdetails`
--

LOCK TABLES `strippingdetails` WRITE;
/*!40000 ALTER TABLE `strippingdetails` DISABLE KEYS */;
INSERT INTO `strippingdetails` VALUES (1,1,1,1,1200.00,3,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-01-12 00:00:00','2021-12-01 19:25:15'),(2,2,3,2,2000.00,100,'CANAL 1 DE PRUEBA',1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-12-02 07:48:39'),(3,2,1,1,100.00,5,NULL,1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-12-02 07:49:15');
/*!40000 ALTER TABLE `strippingdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `strips`
--

DROP TABLE IF EXISTS `strips`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `strips` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Reference` text,
  `StartDate` datetime NOT NULL,
  `EndDate` datetime DEFAULT NULL,
  `StatusId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Strips_StatusId` (`StatusId`),
  CONSTRAINT `FK_Strips_Status_StatusId` FOREIGN KEY (`StatusId`) REFERENCES `status` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `strips`
--

LOCK TABLES `strips` WRITE;
/*!40000 ALTER TABLE `strips` DISABLE KEYS */;
INSERT INTO `strips` VALUES (1,'C001-DICIEMBRE','2021-12-01 07:30:00',NULL,1,'DESPOSTE DE PRUEBAS',1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-01-12 00:00:00','2021-01-12 00:00:00'),(2,'D001-DIC','2021-12-02 07:47:00','2021-12-02 07:49:37',3,'ESTE ES UN DESPOSTE DE PRUEBA',1,'256a231a-3686-466e-9ad5-6a4b625bae10','256a231a-3686-466e-9ad5-6a4b625bae10','2021-02-12 00:00:00','2021-02-12 00:00:00');
/*!40000 ALTER TABLE `strips` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subcuts`
--

DROP TABLE IF EXISTS `subcuts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subcuts` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `MainCutId` int NOT NULL,
  `SubCutId` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_SubCuts_MainCutId` (`MainCutId`),
  KEY `IX_SubCuts_SubCutId` (`SubCutId`),
  CONSTRAINT `FK_SubCuts_CutsOfMeats_MainCutId` FOREIGN KEY (`MainCutId`) REFERENCES `cutsofmeats` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_SubCuts_CutsOfMeats_SubCutId` FOREIGN KEY (`SubCutId`) REFERENCES `cutsofmeats` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subcuts`
--

LOCK TABLES `subcuts` WRITE;
/*!40000 ALTER TABLE `subcuts` DISABLE KEYS */;
/*!40000 ALTER TABLE `subcuts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `submodules`
--

DROP TABLE IF EXISTS `submodules`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `submodules` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ModulesId` int NOT NULL,
  `Name` varchar(80) NOT NULL,
  `URLPath` varchar(150) NOT NULL,
  `Order` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_SubModules_ModulesId` (`ModulesId`),
  CONSTRAINT `FK_SubModules_Modules_ModulesId` FOREIGN KEY (`ModulesId`) REFERENCES `modules` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `submodules`
--

LOCK TABLES `submodules` WRITE;
/*!40000 ALTER TABLE `submodules` DISABLE KEYS */;
/*!40000 ALTER TABLE `submodules` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subsectors`
--

DROP TABLE IF EXISTS `subsectors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subsectors` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `SectorsId` int NOT NULL,
  `SubSector` varchar(150) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_SubSectors_SectorsId` (`SectorsId`),
  CONSTRAINT `FK_SubSectors_Sectors_SectorsId` FOREIGN KEY (`SectorsId`) REFERENCES `sectors` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subsectors`
--

LOCK TABLES `subsectors` WRITE;
/*!40000 ALTER TABLE `subsectors` DISABLE KEYS */;
/*!40000 ALTER TABLE `subsectors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suppliers` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Latitude` text,
  `Longitude` text,
  `CountriesId` int NOT NULL,
  `Address` text,
  `Phone1` text,
  `Phone2` text,
  `Email1` text NOT NULL,
  `Email2` text,
  `Contact` text,
  `Initials` text,
  `SupplierTypesId` int NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Suppliers_CountriesId` (`CountriesId`),
  KEY `IX_Suppliers_SupplierTypesId` (`SupplierTypesId`),
  CONSTRAINT `FK_Suppliers_Countries_CountriesId` FOREIGN KEY (`CountriesId`) REFERENCES `countries` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Suppliers_SupplierTypes_SupplierTypesId` FOREIGN KEY (`SupplierTypesId`) REFERENCES `suppliertypes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suppliertypes`
--

DROP TABLE IF EXISTS `suppliertypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suppliertypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Initials` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliertypes`
--

LOCK TABLES `suppliertypes` WRITE;
/*!40000 ALTER TABLE `suppliertypes` DISABLE KEYS */;
/*!40000 ALTER TABLE `suppliertypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tasktypes`
--

DROP TABLE IF EXISTS `tasktypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tasktypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `JobsId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_TaskTypes_JobsId` (`JobsId`),
  CONSTRAINT `FK_TaskTypes_Jobs_JobsId` FOREIGN KEY (`JobsId`) REFERENCES `jobs` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tasktypes`
--

LOCK TABLES `tasktypes` WRITE;
/*!40000 ALTER TABLE `tasktypes` DISABLE KEYS */;
/*!40000 ALTER TABLE `tasktypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `taxes`
--

DROP TABLE IF EXISTS `taxes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `taxes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Code` varchar(30) DEFAULT NULL,
  `Name` varchar(150) NOT NULL,
  `TaxPercentage` decimal(18,2) DEFAULT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `taxes`
--

LOCK TABLES `taxes` WRITE;
/*!40000 ALTER TABLE `taxes` DISABLE KEYS */;
/*!40000 ALTER TABLE `taxes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `thicknesses`
--

DROP TABLE IF EXISTS `thicknesses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `thicknesses` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Valor` decimal(18,2) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `thicknesses`
--

LOCK TABLES `thicknesses` WRITE;
/*!40000 ALTER TABLE `thicknesses` DISABLE KEYS */;
/*!40000 ALTER TABLE `thicknesses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tools`
--

DROP TABLE IF EXISTS `tools`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tools` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `ToolTypesId` int NOT NULL,
  `PurchaseDate` datetime DEFAULT NULL,
  `Quantity` int NOT NULL,
  `StatusId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Tools_StatusId` (`StatusId`),
  KEY `IX_Tools_ToolTypesId` (`ToolTypesId`),
  CONSTRAINT `FK_Tools_Status_StatusId` FOREIGN KEY (`StatusId`) REFERENCES `status` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Tools_ToolTypes_ToolTypesId` FOREIGN KEY (`ToolTypesId`) REFERENCES `tooltypes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tools`
--

LOCK TABLES `tools` WRITE;
/*!40000 ALTER TABLE `tools` DISABLE KEYS */;
/*!40000 ALTER TABLE `tools` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tooltypes`
--

DROP TABLE IF EXISTS `tooltypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tooltypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tooltypes`
--

LOCK TABLES `tooltypes` WRITE;
/*!40000 ALTER TABLE `tooltypes` DISABLE KEYS */;
/*!40000 ALTER TABLE `tooltypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transportcompanies`
--

DROP TABLE IF EXISTS `transportcompanies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transportcompanies` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `URLTracking` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transportcompanies`
--

LOCK TABLES `transportcompanies` WRITE;
/*!40000 ALTER TABLE `transportcompanies` DISABLE KEYS */;
/*!40000 ALTER TABLE `transportcompanies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `units`
--

DROP TABLE IF EXISTS `units`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `units` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Initials` varchar(8) DEFAULT NULL,
  `Name` varchar(100) NOT NULL,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `units`
--

LOCK TABLES `units` WRITE;
/*!40000 ALTER TABLE `units` DISABLE KEYS */;
/*!40000 ALTER TABLE `units` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vendors`
--

DROP TABLE IF EXISTS `vendors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vendors` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Code` varchar(30) DEFAULT NULL,
  `Name` varchar(150) NOT NULL,
  `VendorTypesId` int NOT NULL,
  `BlockId` int NOT NULL,
  `InstallationsId` int NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Vendors_InstallationsId` (`InstallationsId`),
  KEY `IX_Vendors_VendorTypesId` (`VendorTypesId`),
  CONSTRAINT `FK_Vendors_Installations_InstallationsId` FOREIGN KEY (`InstallationsId`) REFERENCES `installations` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Vendors_VendorTypes_VendorTypesId` FOREIGN KEY (`VendorTypesId`) REFERENCES `vendortypes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vendors`
--

LOCK TABLES `vendors` WRITE;
/*!40000 ALTER TABLE `vendors` DISABLE KEYS */;
/*!40000 ALTER TABLE `vendors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vendortypes`
--

DROP TABLE IF EXISTS `vendortypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vendortypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Initials` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vendortypes`
--

LOCK TABLES `vendortypes` WRITE;
/*!40000 ALTER TABLE `vendortypes` DISABLE KEYS */;
/*!40000 ALTER TABLE `vendortypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `warehouses`
--

DROP TABLE IF EXISTS `warehouses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `warehouses` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `WareHouseTypesId` int NOT NULL,
  `Address` varchar(100) DEFAULT NULL,
  `Email1` text,
  `Phone` varchar(80) DEFAULT NULL,
  `Latitude` text,
  `Longitude` text,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_WareHouses_WareHouseTypesId` (`WareHouseTypesId`),
  CONSTRAINT `FK_WareHouses_WareHouseTypes_WareHouseTypesId` FOREIGN KEY (`WareHouseTypesId`) REFERENCES `warehousetypes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `warehouses`
--

LOCK TABLES `warehouses` WRITE;
/*!40000 ALTER TABLE `warehouses` DISABLE KEYS */;
/*!40000 ALTER TABLE `warehouses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `warehousetypes`
--

DROP TABLE IF EXISTS `warehousetypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `warehousetypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(80) NOT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `warehousetypes`
--

LOCK TABLES `warehousetypes` WRITE;
/*!40000 ALTER TABLE `warehousetypes` DISABLE KEYS */;
/*!40000 ALTER TABLE `warehousetypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `whlocations`
--

DROP TABLE IF EXISTS `whlocations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `whlocations` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `Position` varchar(10) DEFAULT NULL,
  `Remarks` text,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `LastUpdateDate` datetime NOT NULL,
  `CreateDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `whlocations`
--

LOCK TABLES `whlocations` WRITE;
/*!40000 ALTER TABLE `whlocations` DISABLE KEYS */;
/*!40000 ALTER TABLE `whlocations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `yieldmeatcuts`
--

DROP TABLE IF EXISTS `yieldmeatcuts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `yieldmeatcuts` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `CompanyId` int NOT NULL,
  `CreateUserId` text,
  `UpdateUserId` text,
  `CreateDate` datetime NOT NULL,
  `LastUpdateDate` datetime NOT NULL,
  `ChannelCategoryId` int NOT NULL DEFAULT '0',
  `ChannelId` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`),
  KEY `IX_YieldMeatCuts_ChannelCategoryId` (`ChannelCategoryId`),
  KEY `IX_YieldMeatCuts_ChannelId` (`ChannelId`),
  CONSTRAINT `FK_YieldMeatCuts_ChannelCategories_ChannelCategoryId` FOREIGN KEY (`ChannelCategoryId`) REFERENCES `channelcategories` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_YieldMeatCuts_Channels_ChannelId` FOREIGN KEY (`ChannelId`) REFERENCES `channels` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `yieldmeatcuts`
--

LOCK TABLES `yieldmeatcuts` WRITE;
/*!40000 ALTER TABLE `yieldmeatcuts` DISABLE KEYS */;
/*!40000 ALTER TABLE `yieldmeatcuts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'productivo_dev'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-25 10:28:43
