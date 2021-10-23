  IF EXISTS(SELECT 1 FROM information_schema.tables 
  WHERE table_name = '
'__EFMigrationsHistory'' AND table_schema = DATABASE()) 
BEGIN
CREATE TABLE `__EFMigrationsHistory` (
    `MigrationId` varchar(150) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    PRIMARY KEY (`MigrationId`)
);

END;

CREATE TABLE `AspNetRoles` (
    `Id` varchar(767) NOT NULL,
    `Name` varchar(256) NULL,
    `NormalizedName` varchar(256) NULL,
    `ConcurrencyStamp` text NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Plans` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `LastPurchase` datetime NOT NULL,
    `ActiveDays` int NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `CreateDate` datetime NOT NULL,
    `LastUpdateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `AspNetRoleClaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `RoleId` varchar(767) NOT NULL,
    `ClaimType` text NULL,
    `ClaimValue` text NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Companies` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Code` varchar(4) NOT NULL,
    `Name` varchar(100) NOT NULL,
    `Latitude` text NULL,
    `Longitude` text NULL,
    `Owner` varchar(100) NULL,
    `CreatedAt` datetime NOT NULL,
    `UpdatedAt` datetime NOT NULL,
    `PlansId` int NOT NULL,
    `ConfigMode` int NOT NULL,
    `PathWeb` text NULL,
    `LogoPath` text NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Companies_Plans_PlansId` FOREIGN KEY (`PlansId`) REFERENCES `Plans` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUsers` (
    `Id` varchar(767) NOT NULL,
    `UserName` varchar(256) NULL,
    `NormalizedUserName` varchar(256) NULL,
    `Email` varchar(256) NULL,
    `NormalizedEmail` varchar(256) NULL,
    `EmailConfirmed` bit NOT NULL,
    `PasswordHash` text NULL,
    `SecurityStamp` text NULL,
    `ConcurrencyStamp` text NULL,
    `PhoneNumber` text NULL,
    `PhoneNumberConfirmed` bit NOT NULL,
    `TwoFactorEnabled` bit NOT NULL,
    `LockoutEnd` timestamp NULL,
    `LockoutEnabled` bit NOT NULL,
    `AccessFailedCount` int NOT NULL,
    `FirstName` varchar(80) NOT NULL,
    `CompanyId` int NOT NULL,
    `Position` varchar(80) NOT NULL,
    `CompaniesId` int NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AspNetUsers_Companies_CompaniesId` FOREIGN KEY (`CompaniesId`) REFERENCES `Companies` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `AspNetUserClaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `UserId` varchar(767) NOT NULL,
    `ClaimType` text NULL,
    `ClaimValue` text NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUserLogins` (
    `LoginProvider` varchar(767) NOT NULL,
    `ProviderKey` varchar(767) NOT NULL,
    `ProviderDisplayName` text NULL,
    `UserId` varchar(767) NOT NULL,
    PRIMARY KEY (`LoginProvider`, `ProviderKey`),
    CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUserRoles` (
    `UserId` varchar(767) NOT NULL,
    `RoleId` varchar(767) NOT NULL,
    PRIMARY KEY (`UserId`, `RoleId`),
    CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUserTokens` (
    `UserId` varchar(767) NOT NULL,
    `LoginProvider` varchar(767) NOT NULL,
    `Name` varchar(767) NOT NULL,
    `Value` text NULL,
    PRIMARY KEY (`UserId`, `LoginProvider`, `Name`),
    CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_AspNetRoleClaims_RoleId` ON `AspNetRoleClaims` (`RoleId`);

CREATE UNIQUE INDEX `RoleNameIndex` ON `AspNetRoles` (`NormalizedName`);

CREATE INDEX `IX_AspNetUserClaims_UserId` ON `AspNetUserClaims` (`UserId`);

CREATE INDEX `IX_AspNetUserLogins_UserId` ON `AspNetUserLogins` (`UserId`);

CREATE INDEX `IX_AspNetUserRoles_RoleId` ON `AspNetUserRoles` (`RoleId`);

CREATE INDEX `IX_AspNetUsers_CompaniesId` ON `AspNetUsers` (`CompaniesId`);

CREATE INDEX `EmailIndex` ON `AspNetUsers` (`NormalizedEmail`);

CREATE UNIQUE INDEX `UserNameIndex` ON `AspNetUsers` (`NormalizedUserName`);

CREATE INDEX `IX_Companies_PlansId` ON `Companies` (`PlansId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20200909133934_PlanEntity', '3.1.7');

ALTER TABLE `Plans` ADD `Name` varchar(80) NOT NULL DEFAULT '';

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20200913185639_PlanEntityName', '3.1.7');

ALTER TABLE `Companies` ADD `AreasId` int NULL;

ALTER TABLE `Companies` ADD `BanksId` int NULL;

ALTER TABLE `Companies` ADD `BrandsId` int NULL;

ALTER TABLE `Companies` ADD `CommImportsId` int NULL;

ALTER TABLE `Companies` ADD `ContainerTypesId` int NULL;

ALTER TABLE `Companies` ADD `ContainersId` int NULL;

ALTER TABLE `Companies` ADD `CountriesId` int NULL;

ALTER TABLE `Companies` ADD `CurrenciesId` int NULL;

ALTER TABLE `Companies` ADD `CustomsAgenciesId` int NULL;

ALTER TABLE `Companies` ADD `DimensionEntityId` int NULL;

ALTER TABLE `Companies` ADD `EmployeeTypesId` int NULL;

ALTER TABLE `Companies` ADD `EmployeesId` int NULL;

ALTER TABLE `Companies` ADD `FinishEntityId` int NULL;

ALTER TABLE `Companies` ADD `FinishPortsId` int NULL;

ALTER TABLE `Companies` ADD `ImportDetailsId` int NULL;

ALTER TABLE `Companies` ADD `ImportFilesId` int NULL;

ALTER TABLE `Companies` ADD `ImportsId` int NULL;

ALTER TABLE `Companies` ADD `IncotermsId` int NULL;

ALTER TABLE `Companies` ADD `LocationsId` int NULL;

ALTER TABLE `Companies` ADD `MachinesId` int NULL;

ALTER TABLE `Companies` ADD `MetalUnitTypesId` int NULL;

ALTER TABLE `Companies` ADD `MetalUnitsId` int NULL;

ALTER TABLE `Companies` ADD `PackingListsId` int NULL;

ALTER TABLE `Companies` ADD `PaymentTermsId` int NULL;

ALTER TABLE `Companies` ADD `PaymentTypesId` int NULL;

ALTER TABLE `Companies` ADD `PaymentsId` int NULL;

ALTER TABLE `Companies` ADD `ProcessesId` int NULL;

ALTER TABLE `Companies` ADD `ProductTypesId` int NULL;

ALTER TABLE `Companies` ADD `ProductionInfosId` int NULL;

ALTER TABLE `Companies` ADD `ProductionOrderDetailsId` int NULL;

ALTER TABLE `Companies` ADD `ProductionOrderFilesId` int NULL;

ALTER TABLE `Companies` ADD `ProductionOrderProcessesId` int NULL;

ALTER TABLE `Companies` ADD `ProductionOrdersId` int NULL;

ALTER TABLE `Companies` ADD `ProductionStopsId` int NULL;

ALTER TABLE `Companies` ADD `ProductsId` int NULL;

ALTER TABLE `Companies` ADD `ShapesId` int NULL;

ALTER TABLE `Companies` ADD `ShiftsId` int NULL;

ALTER TABLE `Companies` ADD `ShipmentsCompaniesId` int NULL;

ALTER TABLE `Companies` ADD `StartPortsId` int NULL;

ALTER TABLE `Companies` ADD `StatusId` int NULL;

ALTER TABLE `Companies` ADD `SteelEntityId` int NULL;

ALTER TABLE `Companies` ADD `StopsCategoriesId` int NULL;

ALTER TABLE `Companies` ADD `StopsId` int NULL;

ALTER TABLE `Companies` ADD `SupplierTypesId` int NULL;

ALTER TABLE `Companies` ADD `SuppliersId` int NULL;

ALTER TABLE `Companies` ADD `ThicknessEntityId` int NULL;

ALTER TABLE `Companies` ADD `TransportCompaniesId` int NULL;

ALTER TABLE `Companies` ADD `UnitsId` int NULL;

ALTER TABLE `Companies` ADD `WHLocationEntityId` int NULL;

CREATE TABLE `Areas` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Banks` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Brands` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `ContainerTypes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(50) NOT NULL,
    `Lenght` decimal(18, 2) NOT NULL,
    `Width` decimal(18, 2) NOT NULL,
    `Height` decimal(18, 2) NOT NULL,
    `Weight` decimal(18, 2) NOT NULL,
    `MaxLoadKG` decimal(18, 2) NOT NULL,
    `MaxLoadCM` decimal(18, 2) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Countries` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Initials` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Currencies` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Initials` text NULL,
    `Factor` decimal(18, 2) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `CustomsAgencies` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Address` text NULL,
    `Phone1` text NULL,
    `Phone2` text NULL,
    `Email1` text NOT NULL,
    `Email2` text NULL,
    `Contact` text NULL,
    `Website` text NULL,
    `Initials` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Dimensions` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Lenght` decimal(18,2) NOT NULL,
    `Width` decimal(18,2) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `EmployeeTypes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Finisheses` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Initials` varchar(10) NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Incoterms` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Initials` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Locations` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `MetalUnitTypes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `PaymentTerms` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Days` int NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `PaymentTypes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(50) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Processes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `ProductTypes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(100) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Shapes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Shifts` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(100) NOT NULL,
    `ShiftStart` datetime NOT NULL,
    `ShiftEnd` datetime NOT NULL,
    `RestTimeShift` int NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `ShipmentCompanies` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `URLTracking` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Status` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Module` text NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Steels` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `DIN` varchar(15) NULL,
    `AISI` varchar(15) NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `StopsCategories` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Level` varchar(4) NOT NULL,
    `Code` varchar(4) NOT NULL,
    `Name` varchar(150) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `SupplierTypes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Initials` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Thicknesses` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Valor` decimal(18,2) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `TransportCompanies` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `URLTracking` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Units` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Initials` varchar(8) NULL,
    `Name` varchar(100) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `WHLocations` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Position` varchar(10) NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `FinishPorts` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Latitude` text NULL,
    `Longitude` text NULL,
    `CompanyId` int NOT NULL,
    `CountriesId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_FinishPorts_Countries_CountriesId` FOREIGN KEY (`CountriesId`) REFERENCES `Countries` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `StartPorts` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Latitude` text NULL,
    `Longitude` text NULL,
    `CompanyId` int NOT NULL,
    `CountriesId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_StartPorts_Countries_CountriesId` FOREIGN KEY (`CountriesId`) REFERENCES `Countries` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Employees` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `FirstName` varchar(80) NOT NULL,
    `SecondName` varchar(80) NULL,
    `LastName1` varchar(80) NOT NULL,
    `LastName2` varchar(80) NULL,
    `Address` varchar(80) NOT NULL,
    `Phone1` varchar(20) NOT NULL,
    `Phone2` varchar(20) NULL,
    `BirthDate` datetime NOT NULL,
    `EmployeeTypesId` int NOT NULL,
    `EmergencyName` varchar(100) NULL,
    `EmergencyPhone` varchar(20) NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Employees_EmployeeTypes_EmployeeTypesId` FOREIGN KEY (`EmployeeTypesId`) REFERENCES `EmployeeTypes` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Machines` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `StatusId` int NOT NULL,
    `Model` varchar(50) NOT NULL,
    `Year` int NOT NULL,
    `Cost` decimal(18,2) NOT NULL,
    `Insurance` bit NOT NULL,
    `Reference` text NULL,
    `LocationsId` int NOT NULL,
    `BrandsId` int NOT NULL,
    `ProcessesId` int NOT NULL,
    `OutputStandard` decimal(18,2) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Machines_Brands_BrandsId` FOREIGN KEY (`BrandsId`) REFERENCES `Brands` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Machines_Locations_LocationsId` FOREIGN KEY (`LocationsId`) REFERENCES `Locations` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Machines_Processes_ProcessesId` FOREIGN KEY (`ProcessesId`) REFERENCES `Processes` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Machines_Status_StatusId` FOREIGN KEY (`StatusId`) REFERENCES `Status` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Stops` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `StopsCategoriesId` int NOT NULL,
    `Level` varchar(4) NOT NULL,
    `Code` varchar(4) NOT NULL,
    `Name` varchar(150) NOT NULL,
    `AreasId` int NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Stops_Areas_AreasId` FOREIGN KEY (`AreasId`) REFERENCES `Areas` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Stops_StopsCategories_StopsCategoriesId` FOREIGN KEY (`StopsCategoriesId`) REFERENCES `StopsCategories` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Suppliers` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Latitude` text NULL,
    `Longitude` text NULL,
    `CountriesId` int NOT NULL,
    `Address` text NULL,
    `Phone1` text NULL,
    `Phone2` text NULL,
    `Email1` text NOT NULL,
    `Email2` text NULL,
    `Contact` text NULL,
    `Initials` text NULL,
    `SupplierTypesId` int NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Suppliers_Countries_CountriesId` FOREIGN KEY (`CountriesId`) REFERENCES `Countries` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Suppliers_SupplierTypes_SupplierTypesId` FOREIGN KEY (`SupplierTypesId`) REFERENCES `SupplierTypes` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Products` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Code` varchar(8) NULL,
    `Name` varchar(100) NOT NULL,
    `UnitsId` int NOT NULL,
    `CodeERP` varchar(8) NULL,
    `Minimum` decimal(18,2) NOT NULL,
    `Maximum` decimal(18,2) NOT NULL,
    `Factor1` decimal(18,2) NOT NULL,
    `Factor2` decimal(18,2) NOT NULL,
    `Weight` decimal(18,2) NOT NULL,
    `ProductTypesId` int NOT NULL,
    `ShapesId` int NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Products_ProductTypes_ProductTypesId` FOREIGN KEY (`ProductTypesId`) REFERENCES `ProductTypes` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Products_Shapes_ShapesId` FOREIGN KEY (`ShapesId`) REFERENCES `Shapes` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Products_Units_UnitsId` FOREIGN KEY (`UnitsId`) REFERENCES `Units` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Imports` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Order` varchar(6) NOT NULL,
    `SuppliersId` int NOT NULL,
    `Amount` decimal(18, 2) NOT NULL,
    `CurrenciesId` int NOT NULL,
    `PurchaseDate` datetime NOT NULL,
    `ShipmentDate` datetime NULL,
    `PaymentTermsId` int NOT NULL,
    `Liquidacion` bit NOT NULL,
    `Insurance` bit NOT NULL,
    `Eta` datetime NULL,
    `Notes` text NULL,
    `Goods` text NULL,
    `StatusId` int NOT NULL,
    `WarehouseDate` datetime NULL,
    `PortDate` datetime NULL,
    `StartPortsId` int NOT NULL,
    `FinishPortsId` int NOT NULL,
    `DO` text NULL,
    `TransportCompaniesId` int NOT NULL,
    `ShipmentCompaniesId` int NOT NULL,
    `IncotermsId` int NOT NULL,
    `CustomsAgenciesId` int NOT NULL,
    `Totalton` double NULL,
    `OC` text NULL,
    `EA` text NULL,
    `Dollar` decimal(18, 2) NULL,
    `DollarSim` decimal(18, 2) NULL,
    `DepositDate` datetime NULL,
    `DueDate` datetime NULL,
    `DocsAgencyDate` datetime NULL,
    `TransportDeliverDate` datetime NULL,
    `CustomsAuthDate` datetime NULL,
    `TRMCosts` decimal(18, 2) NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Imports_Currencies_CurrenciesId` FOREIGN KEY (`CurrenciesId`) REFERENCES `Currencies` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Imports_CustomsAgencies_CustomsAgenciesId` FOREIGN KEY (`CustomsAgenciesId`) REFERENCES `CustomsAgencies` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Imports_FinishPorts_FinishPortsId` FOREIGN KEY (`FinishPortsId`) REFERENCES `FinishPorts` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Imports_Incoterms_IncotermsId` FOREIGN KEY (`IncotermsId`) REFERENCES `Incoterms` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Imports_PaymentTerms_PaymentTermsId` FOREIGN KEY (`PaymentTermsId`) REFERENCES `PaymentTerms` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Imports_ShipmentCompanies_ShipmentCompaniesId` FOREIGN KEY (`ShipmentCompaniesId`) REFERENCES `ShipmentCompanies` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Imports_StartPorts_StartPortsId` FOREIGN KEY (`StartPortsId`) REFERENCES `StartPorts` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Imports_Status_StatusId` FOREIGN KEY (`StatusId`) REFERENCES `Status` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Imports_Suppliers_SuppliersId` FOREIGN KEY (`SuppliersId`) REFERENCES `Suppliers` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Imports_TransportCompanies_TransportCompaniesId` FOREIGN KEY (`TransportCompaniesId`) REFERENCES `TransportCompanies` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `CommImports` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ImportsId` int NOT NULL,
    `DateComm` datetime NOT NULL,
    `Message` text NOT NULL,
    `SuppliersId` int NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_CommImports_Imports_ImportsId` FOREIGN KEY (`ImportsId`) REFERENCES `Imports` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_CommImports_Suppliers_SuppliersId` FOREIGN KEY (`SuppliersId`) REFERENCES `Suppliers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Containers` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ImportsId` int NOT NULL,
    `Container` varchar(40) NOT NULL,
    `BL` varchar(40) NOT NULL,
    `InitialDate` datetime NOT NULL,
    `FinalDate` datetime NOT NULL,
    `Booking` text NULL,
    `ContainerTypesId` int NOT NULL,
    `GrossWeight` decimal(18, 2) NOT NULL,
    `ContainerLoadType` int NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Containers_ContainerTypes_ContainerTypesId` FOREIGN KEY (`ContainerTypesId`) REFERENCES `ContainerTypes` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Containers_Imports_ImportsId` FOREIGN KEY (`ImportsId`) REFERENCES `Imports` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `ImportDetails` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ImportsId` int NOT NULL,
    `ProductsId` int NOT NULL,
    `Quantity` decimal(18,2) NOT NULL,
    `Amount` decimal(18,2) NOT NULL,
    `CertificationPath` text NULL,
    `PendQuantity` decimal(18,2) NOT NULL,
    `Notes` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ImportDetails_Imports_ImportsId` FOREIGN KEY (`ImportsId`) REFERENCES `Imports` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ImportDetails_Products_ProductsId` FOREIGN KEY (`ProductsId`) REFERENCES `Products` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `ImportFiles` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ImportsId` int NOT NULL,
    `Remarks` text NULL,
    `FilePath` text NULL,
    `LoadDate` datetime NOT NULL,
    `TypeFile` int NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ImportFiles_Imports_ImportsId` FOREIGN KEY (`ImportsId`) REFERENCES `Imports` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Payments` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ImportsId` int NOT NULL,
    `BanksId` int NOT NULL,
    `PaymentTypesId` int NOT NULL,
    `CurrenciesId` int NOT NULL,
    `Amount` decimal(18, 2) NOT NULL,
    `PaymentDate` datetime NOT NULL,
    `Legalization` bit NOT NULL,
    `LegalDate` datetime NULL,
    `ChangeRate` decimal(18, 2) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Payments_Banks_BanksId` FOREIGN KEY (`BanksId`) REFERENCES `Banks` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Payments_Currencies_CurrenciesId` FOREIGN KEY (`CurrenciesId`) REFERENCES `Currencies` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Payments_Imports_ImportsId` FOREIGN KEY (`ImportsId`) REFERENCES `Imports` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Payments_PaymentTypes_PaymentTypesId` FOREIGN KEY (`PaymentTypesId`) REFERENCES `PaymentTypes` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `PackingLists` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ImportsId` int NOT NULL,
    `ImportDetailsId` int NOT NULL,
    `Heat` varchar(40) NOT NULL,
    `Package` varchar(40) NULL,
    `Pieces` decimal(18, 2) NOT NULL,
    `GrossWeight` decimal(18, 2) NOT NULL,
    `NetWeight` decimal(18, 2) NOT NULL,
    `Remarks` text NULL,
    `LoadDate` datetime NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_PackingLists_ImportDetails_ImportDetailsId` FOREIGN KEY (`ImportDetailsId`) REFERENCES `ImportDetails` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_PackingLists_Imports_ImportsId` FOREIGN KEY (`ImportsId`) REFERENCES `Imports` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `MetalUnits` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `MetalCode` varchar(8) NULL,
    `WarehouseDate` datetime NOT NULL,
    `MetalUnitTypesId` int NOT NULL,
    `SteelsId` int NOT NULL,
    `ThicknessesId` int NOT NULL,
    `DimensionsId` int NOT NULL,
    `FinishesesId` int NOT NULL,
    `WHLocationsId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    `PackingListsId` int NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_MetalUnits_Dimensions_DimensionsId` FOREIGN KEY (`DimensionsId`) REFERENCES `Dimensions` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_MetalUnits_Finisheses_FinishesesId` FOREIGN KEY (`FinishesesId`) REFERENCES `Finisheses` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_MetalUnits_MetalUnitTypes_MetalUnitTypesId` FOREIGN KEY (`MetalUnitTypesId`) REFERENCES `MetalUnitTypes` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_MetalUnits_PackingLists_PackingListsId` FOREIGN KEY (`PackingListsId`) REFERENCES `PackingLists` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_MetalUnits_Steels_SteelsId` FOREIGN KEY (`SteelsId`) REFERENCES `Steels` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_MetalUnits_Thicknesses_ThicknessesId` FOREIGN KEY (`ThicknessesId`) REFERENCES `Thicknesses` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_MetalUnits_WHLocations_WHLocationsId` FOREIGN KEY (`WHLocationsId`) REFERENCES `WHLocations` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `ProductionOrders` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ProdDate` datetime NOT NULL,
    `ProdStartDate` datetime NULL,
    `ProdFinishDate` datetime NULL,
    `Order` varchar(15) NULL,
    `StatusId` int NOT NULL,
    `MetalUnitsId` int NOT NULL,
    `Lot` int NOT NULL,
    `ProductsId` int NOT NULL,
    `ShiftsId` int NOT NULL,
    `MinPackageWeight` decimal(18, 2) NOT NULL,
    `MaxPackageWeight` decimal(18, 2) NOT NULL,
    `Lenght` decimal(18, 2) NOT NULL,
    `LenghtTolerance` decimal(18, 2) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ProductionOrders_MetalUnits_MetalUnitsId` FOREIGN KEY (`MetalUnitsId`) REFERENCES `MetalUnits` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ProductionOrders_Products_ProductsId` FOREIGN KEY (`ProductsId`) REFERENCES `Products` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ProductionOrders_Shifts_ShiftsId` FOREIGN KEY (`ShiftsId`) REFERENCES `Shifts` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ProductionOrders_Status_StatusId` FOREIGN KEY (`StatusId`) REFERENCES `Status` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `ProductionInfos` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ProductionOrdersId` int NOT NULL,
    `ProductsId` int NOT NULL,
    `DeliveryDate` datetime NOT NULL,
    `Quantity` decimal(18, 2) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ProductionInfos_ProductionOrders_ProductionOrdersId` FOREIGN KEY (`ProductionOrdersId`) REFERENCES `ProductionOrders` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ProductionInfos_Products_ProductsId` FOREIGN KEY (`ProductsId`) REFERENCES `Products` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `ProductionOrderDetails` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ProductionOrdersId` int NOT NULL,
    `EmployeesId` int NOT NULL,
    `StartDateTime` datetime NULL,
    `FinishDateTime` datetime NULL,
    `TuneUp` int NOT NULL,
    `LenghtDifference` decimal(18,2) NOT NULL,
    `Speed` decimal(18,2) NOT NULL,
    `ProdQuantity` decimal(18,2) NOT NULL,
    `OddmentQuantity` decimal(18,2) NOT NULL,
    `WasteQuantity` decimal(18,2) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ProductionOrderDetails_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `Employees` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ProductionOrderDetails_ProductionOrders_ProductionOrdersId` FOREIGN KEY (`ProductionOrdersId`) REFERENCES `ProductionOrders` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `ProductionOrderFiles` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ProductionOrdersId` int NOT NULL,
    `Remarks` text NULL,
    `FilePath` text NULL,
    `LoadDate` datetime NOT NULL,
    `TypeFile` int NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ProductionOrderFiles_ProductionOrders_ProductionOrdersId` FOREIGN KEY (`ProductionOrdersId`) REFERENCES `ProductionOrders` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `ProductionOrderProcesses` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ProductionOrdersId` int NOT NULL,
    `MachinesId` int NOT NULL,
    `ScheduleDate` datetime NOT NULL,
    `EmployeesId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ProductionOrderProcesses_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `Employees` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ProductionOrderProcesses_Machines_MachinesId` FOREIGN KEY (`MachinesId`) REFERENCES `Machines` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ProductionOrderProcesses_ProductionOrders_ProductionOrdersId` FOREIGN KEY (`ProductionOrdersId`) REFERENCES `ProductionOrders` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `ProductionStops` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ProductionOrdersId` int NOT NULL,
    `StopsId` int NOT NULL,
    `MachinesId` int NOT NULL,
    `StartDateTime` datetime NULL,
    `FinishDateTime` datetime NULL,
    `EmployeesId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ProductionStops_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `Employees` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ProductionStops_Machines_MachinesId` FOREIGN KEY (`MachinesId`) REFERENCES `Machines` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ProductionStops_ProductionOrders_ProductionOrdersId` FOREIGN KEY (`ProductionOrdersId`) REFERENCES `ProductionOrders` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ProductionStops_Stops_StopsId` FOREIGN KEY (`StopsId`) REFERENCES `Stops` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_Companies_AreasId` ON `Companies` (`AreasId`);

CREATE INDEX `IX_Companies_BanksId` ON `Companies` (`BanksId`);

CREATE INDEX `IX_Companies_BrandsId` ON `Companies` (`BrandsId`);

CREATE INDEX `IX_Companies_CommImportsId` ON `Companies` (`CommImportsId`);

CREATE INDEX `IX_Companies_ContainerTypesId` ON `Companies` (`ContainerTypesId`);

CREATE INDEX `IX_Companies_ContainersId` ON `Companies` (`ContainersId`);

CREATE INDEX `IX_Companies_CountriesId` ON `Companies` (`CountriesId`);

CREATE INDEX `IX_Companies_CurrenciesId` ON `Companies` (`CurrenciesId`);

CREATE INDEX `IX_Companies_CustomsAgenciesId` ON `Companies` (`CustomsAgenciesId`);

CREATE INDEX `IX_Companies_DimensionEntityId` ON `Companies` (`DimensionEntityId`);

CREATE INDEX `IX_Companies_EmployeeTypesId` ON `Companies` (`EmployeeTypesId`);

CREATE INDEX `IX_Companies_EmployeesId` ON `Companies` (`EmployeesId`);

CREATE INDEX `IX_Companies_FinishEntityId` ON `Companies` (`FinishEntityId`);

CREATE INDEX `IX_Companies_FinishPortsId` ON `Companies` (`FinishPortsId`);

CREATE INDEX `IX_Companies_ImportDetailsId` ON `Companies` (`ImportDetailsId`);

CREATE INDEX `IX_Companies_ImportFilesId` ON `Companies` (`ImportFilesId`);

CREATE INDEX `IX_Companies_ImportsId` ON `Companies` (`ImportsId`);

CREATE INDEX `IX_Companies_IncotermsId` ON `Companies` (`IncotermsId`);

CREATE INDEX `IX_Companies_LocationsId` ON `Companies` (`LocationsId`);

CREATE INDEX `IX_Companies_MachinesId` ON `Companies` (`MachinesId`);

CREATE INDEX `IX_Companies_MetalUnitTypesId` ON `Companies` (`MetalUnitTypesId`);

CREATE INDEX `IX_Companies_MetalUnitsId` ON `Companies` (`MetalUnitsId`);

CREATE INDEX `IX_Companies_PackingListsId` ON `Companies` (`PackingListsId`);

CREATE INDEX `IX_Companies_PaymentTermsId` ON `Companies` (`PaymentTermsId`);

CREATE INDEX `IX_Companies_PaymentTypesId` ON `Companies` (`PaymentTypesId`);

CREATE INDEX `IX_Companies_PaymentsId` ON `Companies` (`PaymentsId`);

CREATE INDEX `IX_Companies_ProcessesId` ON `Companies` (`ProcessesId`);

CREATE INDEX `IX_Companies_ProductTypesId` ON `Companies` (`ProductTypesId`);

CREATE INDEX `IX_Companies_ProductionInfosId` ON `Companies` (`ProductionInfosId`);

CREATE INDEX `IX_Companies_ProductionOrderDetailsId` ON `Companies` (`ProductionOrderDetailsId`);

CREATE INDEX `IX_Companies_ProductionOrderFilesId` ON `Companies` (`ProductionOrderFilesId`);

CREATE INDEX `IX_Companies_ProductionOrderProcessesId` ON `Companies` (`ProductionOrderProcessesId`);

CREATE INDEX `IX_Companies_ProductionOrdersId` ON `Companies` (`ProductionOrdersId`);

CREATE INDEX `IX_Companies_ProductionStopsId` ON `Companies` (`ProductionStopsId`);

CREATE INDEX `IX_Companies_ProductsId` ON `Companies` (`ProductsId`);

CREATE INDEX `IX_Companies_ShapesId` ON `Companies` (`ShapesId`);

CREATE INDEX `IX_Companies_ShiftsId` ON `Companies` (`ShiftsId`);

CREATE INDEX `IX_Companies_ShipmentsCompaniesId` ON `Companies` (`ShipmentsCompaniesId`);

CREATE INDEX `IX_Companies_StartPortsId` ON `Companies` (`StartPortsId`);

CREATE INDEX `IX_Companies_StatusId` ON `Companies` (`StatusId`);

CREATE INDEX `IX_Companies_SteelEntityId` ON `Companies` (`SteelEntityId`);

CREATE INDEX `IX_Companies_StopsCategoriesId` ON `Companies` (`StopsCategoriesId`);

CREATE INDEX `IX_Companies_StopsId` ON `Companies` (`StopsId`);

CREATE INDEX `IX_Companies_SupplierTypesId` ON `Companies` (`SupplierTypesId`);

CREATE INDEX `IX_Companies_SuppliersId` ON `Companies` (`SuppliersId`);

CREATE INDEX `IX_Companies_ThicknessEntityId` ON `Companies` (`ThicknessEntityId`);

CREATE INDEX `IX_Companies_TransportCompaniesId` ON `Companies` (`TransportCompaniesId`);

CREATE INDEX `IX_Companies_UnitsId` ON `Companies` (`UnitsId`);

CREATE INDEX `IX_Companies_WHLocationEntityId` ON `Companies` (`WHLocationEntityId`);

CREATE INDEX `IX_CommImports_ImportsId` ON `CommImports` (`ImportsId`);

CREATE INDEX `IX_CommImports_SuppliersId` ON `CommImports` (`SuppliersId`);

CREATE INDEX `IX_Containers_ContainerTypesId` ON `Containers` (`ContainerTypesId`);

CREATE INDEX `IX_Containers_ImportsId` ON `Containers` (`ImportsId`);

CREATE INDEX `IX_Employees_EmployeeTypesId` ON `Employees` (`EmployeeTypesId`);

CREATE INDEX `IX_FinishPorts_CountriesId` ON `FinishPorts` (`CountriesId`);

CREATE INDEX `IX_ImportDetails_ImportsId` ON `ImportDetails` (`ImportsId`);

CREATE INDEX `IX_ImportDetails_ProductsId` ON `ImportDetails` (`ProductsId`);

CREATE INDEX `IX_ImportFiles_ImportsId` ON `ImportFiles` (`ImportsId`);

CREATE INDEX `IX_Imports_CurrenciesId` ON `Imports` (`CurrenciesId`);

CREATE INDEX `IX_Imports_CustomsAgenciesId` ON `Imports` (`CustomsAgenciesId`);

CREATE INDEX `IX_Imports_FinishPortsId` ON `Imports` (`FinishPortsId`);

CREATE INDEX `IX_Imports_IncotermsId` ON `Imports` (`IncotermsId`);

CREATE INDEX `IX_Imports_PaymentTermsId` ON `Imports` (`PaymentTermsId`);

CREATE INDEX `IX_Imports_ShipmentCompaniesId` ON `Imports` (`ShipmentCompaniesId`);

CREATE INDEX `IX_Imports_StartPortsId` ON `Imports` (`StartPortsId`);

CREATE INDEX `IX_Imports_StatusId` ON `Imports` (`StatusId`);

CREATE INDEX `IX_Imports_SuppliersId` ON `Imports` (`SuppliersId`);

CREATE INDEX `IX_Imports_TransportCompaniesId` ON `Imports` (`TransportCompaniesId`);

CREATE INDEX `IX_Machines_BrandsId` ON `Machines` (`BrandsId`);

CREATE INDEX `IX_Machines_LocationsId` ON `Machines` (`LocationsId`);

CREATE INDEX `IX_Machines_ProcessesId` ON `Machines` (`ProcessesId`);

CREATE INDEX `IX_Machines_StatusId` ON `Machines` (`StatusId`);

CREATE INDEX `IX_MetalUnits_DimensionsId` ON `MetalUnits` (`DimensionsId`);

CREATE INDEX `IX_MetalUnits_FinishesesId` ON `MetalUnits` (`FinishesesId`);

CREATE INDEX `IX_MetalUnits_MetalUnitTypesId` ON `MetalUnits` (`MetalUnitTypesId`);

CREATE UNIQUE INDEX `IX_MetalUnits_PackingListsId` ON `MetalUnits` (`PackingListsId`);

CREATE INDEX `IX_MetalUnits_SteelsId` ON `MetalUnits` (`SteelsId`);

CREATE INDEX `IX_MetalUnits_ThicknessesId` ON `MetalUnits` (`ThicknessesId`);

CREATE INDEX `IX_MetalUnits_WHLocationsId` ON `MetalUnits` (`WHLocationsId`);

CREATE INDEX `IX_PackingLists_ImportDetailsId` ON `PackingLists` (`ImportDetailsId`);

CREATE INDEX `IX_PackingLists_ImportsId` ON `PackingLists` (`ImportsId`);

CREATE INDEX `IX_Payments_BanksId` ON `Payments` (`BanksId`);

CREATE INDEX `IX_Payments_CurrenciesId` ON `Payments` (`CurrenciesId`);

CREATE INDEX `IX_Payments_ImportsId` ON `Payments` (`ImportsId`);

CREATE INDEX `IX_Payments_PaymentTypesId` ON `Payments` (`PaymentTypesId`);

CREATE INDEX `IX_ProductionInfos_ProductionOrdersId` ON `ProductionInfos` (`ProductionOrdersId`);

CREATE INDEX `IX_ProductionInfos_ProductsId` ON `ProductionInfos` (`ProductsId`);

CREATE INDEX `IX_ProductionOrderDetails_EmployeesId` ON `ProductionOrderDetails` (`EmployeesId`);

CREATE INDEX `IX_ProductionOrderDetails_ProductionOrdersId` ON `ProductionOrderDetails` (`ProductionOrdersId`);

CREATE INDEX `IX_ProductionOrderFiles_ProductionOrdersId` ON `ProductionOrderFiles` (`ProductionOrdersId`);

CREATE INDEX `IX_ProductionOrderProcesses_EmployeesId` ON `ProductionOrderProcesses` (`EmployeesId`);

CREATE INDEX `IX_ProductionOrderProcesses_MachinesId` ON `ProductionOrderProcesses` (`MachinesId`);

CREATE INDEX `IX_ProductionOrderProcesses_ProductionOrdersId` ON `ProductionOrderProcesses` (`ProductionOrdersId`);

CREATE UNIQUE INDEX `IX_ProductionOrders_MetalUnitsId` ON `ProductionOrders` (`MetalUnitsId`);

CREATE INDEX `IX_ProductionOrders_ProductsId` ON `ProductionOrders` (`ProductsId`);

CREATE INDEX `IX_ProductionOrders_ShiftsId` ON `ProductionOrders` (`ShiftsId`);

CREATE INDEX `IX_ProductionOrders_StatusId` ON `ProductionOrders` (`StatusId`);

CREATE INDEX `IX_ProductionStops_EmployeesId` ON `ProductionStops` (`EmployeesId`);

CREATE INDEX `IX_ProductionStops_MachinesId` ON `ProductionStops` (`MachinesId`);

CREATE INDEX `IX_ProductionStops_ProductionOrdersId` ON `ProductionStops` (`ProductionOrdersId`);

CREATE INDEX `IX_ProductionStops_StopsId` ON `ProductionStops` (`StopsId`);

CREATE INDEX `IX_Products_ProductTypesId` ON `Products` (`ProductTypesId`);

CREATE INDEX `IX_Products_ShapesId` ON `Products` (`ShapesId`);

CREATE INDEX `IX_Products_UnitsId` ON `Products` (`UnitsId`);

CREATE INDEX `IX_StartPorts_CountriesId` ON `StartPorts` (`CountriesId`);

CREATE INDEX `IX_Stops_AreasId` ON `Stops` (`AreasId`);

CREATE INDEX `IX_Stops_StopsCategoriesId` ON `Stops` (`StopsCategoriesId`);

CREATE INDEX `IX_Suppliers_CountriesId` ON `Suppliers` (`CountriesId`);

CREATE INDEX `IX_Suppliers_SupplierTypesId` ON `Suppliers` (`SupplierTypesId`);

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Areas_AreasId` FOREIGN KEY (`AreasId`) REFERENCES `Areas` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Banks_BanksId` FOREIGN KEY (`BanksId`) REFERENCES `Banks` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Brands_BrandsId` FOREIGN KEY (`BrandsId`) REFERENCES `Brands` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_CommImports_CommImportsId` FOREIGN KEY (`CommImportsId`) REFERENCES `CommImports` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_ContainerTypes_ContainerTypesId` FOREIGN KEY (`ContainerTypesId`) REFERENCES `ContainerTypes` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Containers_ContainersId` FOREIGN KEY (`ContainersId`) REFERENCES `Containers` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Countries_CountriesId` FOREIGN KEY (`CountriesId`) REFERENCES `Countries` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Currencies_CurrenciesId` FOREIGN KEY (`CurrenciesId`) REFERENCES `Currencies` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_CustomsAgencies_CustomsAgenciesId` FOREIGN KEY (`CustomsAgenciesId`) REFERENCES `CustomsAgencies` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Dimensions_DimensionEntityId` FOREIGN KEY (`DimensionEntityId`) REFERENCES `Dimensions` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_EmployeeTypes_EmployeeTypesId` FOREIGN KEY (`EmployeeTypesId`) REFERENCES `EmployeeTypes` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `Employees` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Finisheses_FinishEntityId` FOREIGN KEY (`FinishEntityId`) REFERENCES `Finisheses` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_FinishPorts_FinishPortsId` FOREIGN KEY (`FinishPortsId`) REFERENCES `FinishPorts` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_ImportDetails_ImportDetailsId` FOREIGN KEY (`ImportDetailsId`) REFERENCES `ImportDetails` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_ImportFiles_ImportFilesId` FOREIGN KEY (`ImportFilesId`) REFERENCES `ImportFiles` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Imports_ImportsId` FOREIGN KEY (`ImportsId`) REFERENCES `Imports` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Incoterms_IncotermsId` FOREIGN KEY (`IncotermsId`) REFERENCES `Incoterms` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Locations_LocationsId` FOREIGN KEY (`LocationsId`) REFERENCES `Locations` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Machines_MachinesId` FOREIGN KEY (`MachinesId`) REFERENCES `Machines` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_MetalUnitTypes_MetalUnitTypesId` FOREIGN KEY (`MetalUnitTypesId`) REFERENCES `MetalUnitTypes` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_MetalUnits_MetalUnitsId` FOREIGN KEY (`MetalUnitsId`) REFERENCES `MetalUnits` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_PackingLists_PackingListsId` FOREIGN KEY (`PackingListsId`) REFERENCES `PackingLists` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_PaymentTerms_PaymentTermsId` FOREIGN KEY (`PaymentTermsId`) REFERENCES `PaymentTerms` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_PaymentTypes_PaymentTypesId` FOREIGN KEY (`PaymentTypesId`) REFERENCES `PaymentTypes` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Payments_PaymentsId` FOREIGN KEY (`PaymentsId`) REFERENCES `Payments` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Processes_ProcessesId` FOREIGN KEY (`ProcessesId`) REFERENCES `Processes` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_ProductTypes_ProductTypesId` FOREIGN KEY (`ProductTypesId`) REFERENCES `ProductTypes` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_ProductionInfos_ProductionInfosId` FOREIGN KEY (`ProductionInfosId`) REFERENCES `ProductionInfos` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_ProductionOrderDetails_ProductionOrderDetailsId` FOREIGN KEY (`ProductionOrderDetailsId`) REFERENCES `ProductionOrderDetails` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_ProductionOrderFiles_ProductionOrderFilesId` FOREIGN KEY (`ProductionOrderFilesId`) REFERENCES `ProductionOrderFiles` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_ProductionOrderProcesses_ProductionOrderProcessesId` FOREIGN KEY (`ProductionOrderProcessesId`) REFERENCES `ProductionOrderProcesses` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_ProductionOrders_ProductionOrdersId` FOREIGN KEY (`ProductionOrdersId`) REFERENCES `ProductionOrders` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_ProductionStops_ProductionStopsId` FOREIGN KEY (`ProductionStopsId`) REFERENCES `ProductionStops` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Products_ProductsId` FOREIGN KEY (`ProductsId`) REFERENCES `Products` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Shapes_ShapesId` FOREIGN KEY (`ShapesId`) REFERENCES `Shapes` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Shifts_ShiftsId` FOREIGN KEY (`ShiftsId`) REFERENCES `Shifts` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_ShipmentCompanies_ShipmentsCompaniesId` FOREIGN KEY (`ShipmentsCompaniesId`) REFERENCES `ShipmentCompanies` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_StartPorts_StartPortsId` FOREIGN KEY (`StartPortsId`) REFERENCES `StartPorts` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Status_StatusId` FOREIGN KEY (`StatusId`) REFERENCES `Status` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Steels_SteelEntityId` FOREIGN KEY (`SteelEntityId`) REFERENCES `Steels` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_StopsCategories_StopsCategoriesId` FOREIGN KEY (`StopsCategoriesId`) REFERENCES `StopsCategories` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Stops_StopsId` FOREIGN KEY (`StopsId`) REFERENCES `Stops` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_SupplierTypes_SupplierTypesId` FOREIGN KEY (`SupplierTypesId`) REFERENCES `SupplierTypes` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Suppliers_SuppliersId` FOREIGN KEY (`SuppliersId`) REFERENCES `Suppliers` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Thicknesses_ThicknessEntityId` FOREIGN KEY (`ThicknessEntityId`) REFERENCES `Thicknesses` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_TransportCompanies_TransportCompaniesId` FOREIGN KEY (`TransportCompaniesId`) REFERENCES `TransportCompanies` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Units_UnitsId` FOREIGN KEY (`UnitsId`) REFERENCES `Units` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_WHLocations_WHLocationEntityId` FOREIGN KEY (`WHLocationEntityId`) REFERENCES `WHLocations` (`Id`) ON DELETE RESTRICT;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20200916011856_NewEntities', '3.1.7');

ALTER TABLE ProductionOrders MODIFY `ProdDate` datetime NOT NULL;

ALTER TABLE ProductionOrders MODIFY `MinPackageWeight` decimal(18, 2) NOT NULL;

ALTER TABLE ProductionOrders MODIFY `MaxPackageWeight` decimal(18, 2) NOT NULL;

ALTER TABLE ProductionOrders MODIFY `Lot` int NOT NULL;

ALTER TABLE ProductionOrders MODIFY `LenghtTolerance` decimal(18, 2) NOT NULL;

ALTER TABLE ProductionOrders MODIFY `Lenght` decimal(18, 2) NOT NULL;

ALTER TABLE ProductionOrderDetails MODIFY `WasteQuantity` decimal(18,2) NOT NULL;

ALTER TABLE ProductionOrderDetails MODIFY `TuneUp` int NOT NULL;

ALTER TABLE ProductionOrderDetails MODIFY `Speed` decimal(18,2) NOT NULL;

ALTER TABLE ProductionOrderDetails MODIFY `ProdQuantity` decimal(18,2) NOT NULL;

ALTER TABLE ProductionOrderDetails MODIFY `OddmentQuantity` decimal(18,2) NOT NULL;

ALTER TABLE ProductionOrderDetails MODIFY `LenghtDifference` decimal(18,2) NOT NULL;

ALTER TABLE `AspNetUsers` ADD `FilePath` text NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20201021005254_AddAvatarUserEntity1', '3.1.7');

ALTER TABLE `Companies` ADD `CategoryModelsId` int NULL;

ALTER TABLE `Companies` ADD `EvaluationCategoriesId` int NULL;

ALTER TABLE `Companies` ADD `PlanPaymentsId` int NULL;

ALTER TABLE `Companies` ADD `SectorsId` int NULL;

ALTER TABLE `Companies` ADD `SubSectorsId` int NULL;

CREATE TABLE `CategoryModels` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ScopeNameCategory` varchar(40) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `EvaluationCategories` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `EvaluationNameCategory` varchar(40) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `PlanPayments` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CompanyId` int NOT NULL,
    `PlansId` int NOT NULL,
    `PurchaseDate` datetime NOT NULL,
    `PaymentTypesId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `CreateDate` datetime NOT NULL,
    `LastUpdateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_PlanPayments_PaymentTypes_PaymentTypesId` FOREIGN KEY (`PaymentTypesId`) REFERENCES `PaymentTypes` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_PlanPayments_Plans_PlansId` FOREIGN KEY (`PlansId`) REFERENCES `Plans` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Sectors` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Sector` varchar(150) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `CreateDate` datetime NOT NULL,
    `LastUpdateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `SubSectors` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `SectorsId` int NOT NULL,
    `SubSector` varchar(150) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `CreateDate` datetime NOT NULL,
    `LastUpdateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SubSectors_Sectors_SectorsId` FOREIGN KEY (`SectorsId`) REFERENCES `Sectors` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_Companies_CategoryModelsId` ON `Companies` (`CategoryModelsId`);

CREATE INDEX `IX_Companies_EvaluationCategoriesId` ON `Companies` (`EvaluationCategoriesId`);

CREATE INDEX `IX_Companies_PlanPaymentsId` ON `Companies` (`PlanPaymentsId`);

CREATE INDEX `IX_Companies_SectorsId` ON `Companies` (`SectorsId`);

CREATE INDEX `IX_Companies_SubSectorsId` ON `Companies` (`SubSectorsId`);

CREATE INDEX `IX_PlanPayments_PaymentTypesId` ON `PlanPayments` (`PaymentTypesId`);

CREATE INDEX `IX_PlanPayments_PlansId` ON `PlanPayments` (`PlansId`);

CREATE INDEX `IX_SubSectors_SectorsId` ON `SubSectors` (`SectorsId`);

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_CategoryModels_CategoryModelsId` FOREIGN KEY (`CategoryModelsId`) REFERENCES `CategoryModels` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_EvaluationCategories_EvaluationCategoriesId` FOREIGN KEY (`EvaluationCategoriesId`) REFERENCES `EvaluationCategories` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_PlanPayments_PlanPaymentsId` FOREIGN KEY (`PlanPaymentsId`) REFERENCES `PlanPayments` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_Sectors_SectorsId` FOREIGN KEY (`SectorsId`) REFERENCES `Sectors` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_SubSectors_SubSectorsId` FOREIGN KEY (`SubSectorsId`) REFERENCES `SubSectors` (`Id`) ON DELETE RESTRICT;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20201119012043_PlansModelEntity', '3.1.7');

ALTER TABLE `Machines` ADD `IoTMachineEntityId` int NULL;

ALTER TABLE `Companies` ADD `IoTAlertsId` int NULL;

ALTER TABLE `Companies` ADD `IoTMachinesId` int NULL;

ALTER TABLE `Companies` ADD `IoTNotificationsId` int NULL;

ALTER TABLE `Companies` ADD `IoTVariablesId` int NULL;

ALTER TABLE `Companies` ADD `IoTsId` int NULL;

CREATE TABLE `IoTMachines` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `IoTsId` int NOT NULL,
    `MachinesId` int NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `IoTs` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `CodeIoT` varchar(5) NOT NULL,
    `URLPath` varchar(100) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `IoTNotifications` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `IoTsId` int NOT NULL,
    `IoTAlertsId` int NOT NULL,
    `Emails` text NOT NULL,
    `Subject` varchar(150) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_IoTNotifications_IoTs_IoTsId` FOREIGN KEY (`IoTsId`) REFERENCES `IoTs` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `IoTVariables` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `IoTsId` int NOT NULL,
    `MinValue` decimal(18,4) NOT NULL,
    `MaxValue` decimal(18,4) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_IoTVariables_IoTs_IoTsId` FOREIGN KEY (`IoTsId`) REFERENCES `IoTs` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `IoTAlerts` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `IoTsId` int NOT NULL,
    `IoTVariablesId` int NOT NULL,
    `AlertColor` varchar(12) NULL,
    `MinAlertValue` decimal(18,4) NOT NULL,
    `MaxAlertValue` decimal(18,4) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    `IoTNotificationsId` int NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_IoTAlerts_IoTNotifications_IoTNotificationsId` FOREIGN KEY (`IoTNotificationsId`) REFERENCES `IoTNotifications` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_IoTAlerts_IoTVariables_IoTVariablesId` FOREIGN KEY (`IoTVariablesId`) REFERENCES `IoTVariables` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_IoTAlerts_IoTs_IoTsId` FOREIGN KEY (`IoTsId`) REFERENCES `IoTs` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_Machines_IoTMachineEntityId` ON `Machines` (`IoTMachineEntityId`);

CREATE INDEX `IX_Companies_IoTAlertsId` ON `Companies` (`IoTAlertsId`);

CREATE INDEX `IX_Companies_IoTMachinesId` ON `Companies` (`IoTMachinesId`);

CREATE INDEX `IX_Companies_IoTNotificationsId` ON `Companies` (`IoTNotificationsId`);

CREATE INDEX `IX_Companies_IoTVariablesId` ON `Companies` (`IoTVariablesId`);

CREATE INDEX `IX_Companies_IoTsId` ON `Companies` (`IoTsId`);

CREATE INDEX `IX_IoTAlerts_IoTNotificationsId` ON `IoTAlerts` (`IoTNotificationsId`);

CREATE INDEX `IX_IoTAlerts_IoTVariablesId` ON `IoTAlerts` (`IoTVariablesId`);

CREATE INDEX `IX_IoTAlerts_IoTsId` ON `IoTAlerts` (`IoTsId`);

CREATE INDEX `IX_IoTNotifications_IoTsId` ON `IoTNotifications` (`IoTsId`);

CREATE INDEX `IX_IoTVariables_IoTsId` ON `IoTVariables` (`IoTsId`);

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_IoTAlerts_IoTAlertsId` FOREIGN KEY (`IoTAlertsId`) REFERENCES `IoTAlerts` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_IoTMachines_IoTMachinesId` FOREIGN KEY (`IoTMachinesId`) REFERENCES `IoTMachines` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_IoTNotifications_IoTNotificationsId` FOREIGN KEY (`IoTNotificationsId`) REFERENCES `IoTNotifications` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_IoTVariables_IoTVariablesId` FOREIGN KEY (`IoTVariablesId`) REFERENCES `IoTVariables` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_IoTs_IoTsId` FOREIGN KEY (`IoTsId`) REFERENCES `IoTs` (`Id`) ON DELETE RESTRICT;

ALTER TABLE `Machines` ADD CONSTRAINT `FK_Machines_IoTMachines_IoTMachineEntityId` FOREIGN KEY (`IoTMachineEntityId`) REFERENCES `IoTMachines` (`Id`) ON DELETE RESTRICT;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20201124005228_IoTEntities', '3.1.7');

ALTER TABLE `Companies` ADD `ModelQuestionsId` int NULL;

CREATE TABLE `ModelQuestions` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `QuestionName` text NOT NULL,
    `EvaluationCategoriesId` int NOT NULL,
    `CategoryModelsId` int NOT NULL,
    `WeightQuestion` decimal(18,2) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ModelQuestions_CategoryModels_CategoryModelsId` FOREIGN KEY (`CategoryModelsId`) REFERENCES `CategoryModels` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ModelQuestions_EvaluationCategories_EvaluationCategoriesId` FOREIGN KEY (`EvaluationCategoriesId`) REFERENCES `EvaluationCategories` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_Companies_ModelQuestionsId` ON `Companies` (`ModelQuestionsId`);

CREATE INDEX `IX_ModelQuestions_CategoryModelsId` ON `ModelQuestions` (`CategoryModelsId`);

CREATE INDEX `IX_ModelQuestions_EvaluationCategoriesId` ON `ModelQuestions` (`EvaluationCategoriesId`);

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_ModelQuestions_ModelQuestionsId` FOREIGN KEY (`ModelQuestionsId`) REFERENCES `ModelQuestions` (`Id`) ON DELETE RESTRICT;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20201129182340_ModelQuestionEntity', '3.1.7');

ALTER TABLE `Companies` ADD `IdealModelQuestionsId` int NULL;

CREATE TABLE `IdealModelQuestions` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ModelQuestionsId` int NOT NULL,
    `SubSectorsId` int NOT NULL,
    `IdealExecution` decimal(18,2) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_IdealModelQuestions_ModelQuestions_ModelQuestionsId` FOREIGN KEY (`ModelQuestionsId`) REFERENCES `ModelQuestions` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_IdealModelQuestions_SubSectors_SubSectorsId` FOREIGN KEY (`SubSectorsId`) REFERENCES `SubSectors` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_Companies_IdealModelQuestionsId` ON `Companies` (`IdealModelQuestionsId`);

CREATE INDEX `IX_IdealModelQuestions_ModelQuestionsId` ON `IdealModelQuestions` (`ModelQuestionsId`);

CREATE INDEX `IX_IdealModelQuestions_SubSectorsId` ON `IdealModelQuestions` (`SubSectorsId`);

ALTER TABLE `Companies` ADD CONSTRAINT `FK_Companies_IdealModelQuestions_IdealModelQuestionsId` FOREIGN KEY (`IdealModelQuestionsId`) REFERENCES `IdealModelQuestions` (`Id`) ON DELETE RESTRICT;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20201130141112_IdealModelEntity', '3.1.7');

CREATE TABLE `Diagnostics` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `CodeDiagnostic` varchar(5) NOT NULL,
    `StatusId` int NOT NULL,
    `DiagDate` datetime NULL,
    `SubSectorsId` int NOT NULL,
    `EmployeesId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Diagnostics_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `Employees` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Diagnostics_Status_StatusId` FOREIGN KEY (`StatusId`) REFERENCES `Status` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Diagnostics_SubSectors_SubSectorsId` FOREIGN KEY (`SubSectorsId`) REFERENCES `SubSectors` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `DiagnosticDetails` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `DiagnosticsId` int NOT NULL,
    `ModelQuestionsId` int NOT NULL,
    `Execution` decimal(18,2) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_DiagnosticDetails_Diagnostics_DiagnosticsId` FOREIGN KEY (`DiagnosticsId`) REFERENCES `Diagnostics` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_DiagnosticDetails_ModelQuestions_ModelQuestionsId` FOREIGN KEY (`ModelQuestionsId`) REFERENCES `ModelQuestions` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_DiagnosticDetails_DiagnosticsId` ON `DiagnosticDetails` (`DiagnosticsId`);

CREATE INDEX `IX_DiagnosticDetails_ModelQuestionsId` ON `DiagnosticDetails` (`ModelQuestionsId`);

CREATE INDEX `IX_Diagnostics_EmployeesId` ON `Diagnostics` (`EmployeesId`);

CREATE INDEX `IX_Diagnostics_StatusId` ON `Diagnostics` (`StatusId`);

CREATE INDEX `IX_Diagnostics_SubSectorsId` ON `Diagnostics` (`SubSectorsId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20201227154554_DiagnosticEntities', '3.1.7');

ALTER TABLE `Diagnostics` ADD `EndDiagDate` datetime NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210101174806_AddEndDiagDate', '3.1.7');

CREATE TABLE `BioCareSurveyQuestions` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `QuestionName` text NOT NULL,
    `AnswerName` varchar(100) NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210117135606_SurveyQuestionsEntity', '3.1.7');

CREATE TABLE `BioCareSurveyAnswers` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `SurveyDate` datetime NULL,
    `SurveyTime` datetime NULL,
    `EmployeesId` int NOT NULL,
    `BioCareSurveyQuestionsId` int NOT NULL,
    `Answer` varchar(50) NOT NULL,
    `Temperature` decimal(18,2) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_BioCareSurveyAnswers_BioCareSurveyQuestions_BioCareSurveyQue~` FOREIGN KEY (`BioCareSurveyQuestionsId`) REFERENCES `BioCareSurveyQuestions` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_BioCareSurveyAnswers_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `Employees` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_BioCareSurveyAnswers_BioCareSurveyQuestionsId` ON `BioCareSurveyAnswers` (`BioCareSurveyQuestionsId`);

CREATE INDEX `IX_BioCareSurveyAnswers_EmployeesId` ON `BioCareSurveyAnswers` (`EmployeesId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210117143733_SurveyAnswersEntity', '3.1.7');

ALTER TABLE `Employees` ADD `IdCode` int NOT NULL DEFAULT 0;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210121120115_IdCodeEmployee', '3.1.7');

CREATE TABLE `Affectations` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `Initials` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210209143932_AffectationsEntity', '3.1.7');

CREATE TABLE `AbnormalityTypes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `AffectationsId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbnormalityTypes_Affectations_AffectationsId` FOREIGN KEY (`AffectationsId`) REFERENCES `Affectations` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_AbnormalityTypes_AffectationsId` ON `AbnormalityTypes` (`AffectationsId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210224003543_AbnormalityTypeEntity', '3.1.7');

CREATE TABLE `AbnormalityDetails` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `AbnormalityTypesId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbnormalityDetails_AbnormalityTypes_AbnormalityTypesId` FOREIGN KEY (`AbnormalityTypesId`) REFERENCES `AbnormalityTypes` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_AbnormalityDetails_AbnormalityTypesId` ON `AbnormalityDetails` (`AbnormalityTypesId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210224004425_AbnormalityDetailEntity', '3.1.7');

CREATE TABLE `AbnormalityPlaces` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `AbnormalityPlaceDetails` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `AbnormalityPlacesId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbnormalityPlaceDetails_AbnormalityPlaces_AbnormalityPlacesId` FOREIGN KEY (`AbnormalityPlacesId`) REFERENCES `AbnormalityPlaces` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_AbnormalityPlaceDetails_AbnormalityPlacesId` ON `AbnormalityPlaceDetails` (`AbnormalityPlacesId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210224005924_AbnormalityPlacesEntity', '3.1.7');

CREATE TABLE `WareHouseTypes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `WareHouses` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `WareHouseTypesId` int NOT NULL,
    `Address` varchar(100) NULL,
    `Email1` text NULL,
    `Phone` varchar(80) NULL,
    `Latitude` text NULL,
    `Longitude` text NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_WareHouses_WareHouseTypes_WareHouseTypesId` FOREIGN KEY (`WareHouseTypesId`) REFERENCES `WareHouseTypes` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_WareHouses_WareHouseTypesId` ON `WareHouses` (`WareHouseTypesId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210301235536_WarehousesEntities', '3.1.7');

CREATE TABLE `Jobs` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `ProtectionTypes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `ProtectionCategoriesId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `ToolTypes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `TaskTypes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `JobsId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_TaskTypes_Jobs_JobsId` FOREIGN KEY (`JobsId`) REFERENCES `Jobs` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `ProtectionCategories` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    `ProtectionTypesId` int NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ProtectionCategories_ProtectionTypes_ProtectionTypesId` FOREIGN KEY (`ProtectionTypesId`) REFERENCES `ProtectionTypes` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `Tools` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `ToolTypesId` int NOT NULL,
    `PurchaseDate` datetime NULL,
    `Quantity` int NOT NULL,
    `StatusId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Tools_Status_StatusId` FOREIGN KEY (`StatusId`) REFERENCES `Status` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Tools_ToolTypes_ToolTypesId` FOREIGN KEY (`ToolTypesId`) REFERENCES `ToolTypes` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_ProtectionCategories_ProtectionTypesId` ON `ProtectionCategories` (`ProtectionTypesId`);

CREATE INDEX `IX_TaskTypes_JobsId` ON `TaskTypes` (`JobsId`);

CREATE INDEX `IX_Tools_StatusId` ON `Tools` (`StatusId`);

CREATE INDEX `IX_Tools_ToolTypesId` ON `Tools` (`ToolTypesId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210302014154_TaskJobsEntities', '3.1.7');

ALTER TABLE `ProtectionCategories` DROP CONSTRAINT `FK_ProtectionCategories_ProtectionTypes_ProtectionTypesId`;

DROP INDEX IX_ProtectionCategories_ProtectionTypesId ON ProtectionCategories;

ALTER TABLE `ProtectionCategories` DROP COLUMN `ProtectionTypesId`;

CREATE INDEX `IX_ProtectionTypes_ProtectionCategoriesId` ON `ProtectionTypes` (`ProtectionCategoriesId`);

ALTER TABLE `ProtectionTypes` ADD CONSTRAINT `FK_ProtectionTypes_ProtectionCategories_ProtectionCategoriesId` FOREIGN KEY (`ProtectionCategoriesId`) REFERENCES `ProtectionCategories` (`Id`) ON DELETE CASCADE;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210304190511_UpdateRelationProtections', '3.1.7');

CREATE TABLE `ControlEPPs` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ControlEPPDate` datetime NULL,
    `Order` varchar(15) NULL,
    `StatusId` int NOT NULL,
    `EmployeesId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ControlEPPs_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `Employees` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ControlEPPs_Status_StatusId` FOREIGN KEY (`StatusId`) REFERENCES `Status` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `ProtectionElements` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Code` varchar(8) NULL,
    `Name` varchar(100) NOT NULL,
    `UnitsId` int NOT NULL,
    `CodeERP` varchar(8) NULL,
    `Minimum` decimal(18,2) NOT NULL,
    `Maximum` decimal(18,2) NOT NULL,
    `Factor1` decimal(18,2) NOT NULL,
    `Factor2` decimal(18,2) NOT NULL,
    `MaxDayAsignment` decimal(18,2) NOT NULL,
    `Weight` decimal(18,2) NOT NULL,
    `ProtectionTypesId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ProtectionElements_ProtectionTypes_ProtectionTypesId` FOREIGN KEY (`ProtectionTypesId`) REFERENCES `ProtectionTypes` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ProtectionElements_Units_UnitsId` FOREIGN KEY (`UnitsId`) REFERENCES `Units` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `ControlEPPDetails` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ControlEPPsId` int NOT NULL,
    `EmployeesId` int NOT NULL,
    `AsignmentDateTime` datetime NULL,
    `ReturnDateTime` datetime NULL,
    `ProtectionElementsId` int NOT NULL,
    `Quantity` decimal(18,2) NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ControlEPPDetails_ControlEPPs_ControlEPPsId` FOREIGN KEY (`ControlEPPsId`) REFERENCES `ControlEPPs` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ControlEPPDetails_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `Employees` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ControlEPPDetails_ProtectionElements_ProtectionElementsId` FOREIGN KEY (`ProtectionElementsId`) REFERENCES `ProtectionElements` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_ControlEPPDetails_ControlEPPsId` ON `ControlEPPDetails` (`ControlEPPsId`);

CREATE INDEX `IX_ControlEPPDetails_EmployeesId` ON `ControlEPPDetails` (`EmployeesId`);

CREATE INDEX `IX_ControlEPPDetails_ProtectionElementsId` ON `ControlEPPDetails` (`ProtectionElementsId`);

CREATE INDEX `IX_ControlEPPs_EmployeesId` ON `ControlEPPs` (`EmployeesId`);

CREATE INDEX `IX_ControlEPPs_StatusId` ON `ControlEPPs` (`StatusId`);

CREATE INDEX `IX_ProtectionElements_ProtectionTypesId` ON `ProtectionElements` (`ProtectionTypesId`);

CREATE INDEX `IX_ProtectionElements_UnitsId` ON `ProtectionElements` (`UnitsId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210305014417_ControlEPPEntities', '3.1.7');

ALTER TABLE `ProtectionElements` ADD `ImageElement` text NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210314224502_ImageProtectionElements', '3.1.7');

CREATE TABLE `RawMaterialTypes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `RawMaterials` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `RawCode` varchar(8) NULL,
    `Name` varchar(80) NULL,
    `WarehouseDate` datetime NOT NULL,
    `RawMaterialTypesId` int NOT NULL,
    `WHLocationsId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    `PackingListsId` int NOT NULL,
    `ProductionOrdersId` int NULL,
    `RawMaterialTypeEntityId` int NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_RawMaterials_PackingLists_PackingListsId` FOREIGN KEY (`PackingListsId`) REFERENCES `PackingLists` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_RawMaterials_ProductionOrders_ProductionOrdersId` FOREIGN KEY (`ProductionOrdersId`) REFERENCES `ProductionOrders` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_RawMaterials_RawMaterialTypes_RawMaterialTypeEntityId` FOREIGN KEY (`RawMaterialTypeEntityId`) REFERENCES `RawMaterialTypes` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_RawMaterials_MetalUnitTypes_RawMaterialTypesId` FOREIGN KEY (`RawMaterialTypesId`) REFERENCES `MetalUnitTypes` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_RawMaterials_WHLocations_WHLocationsId` FOREIGN KEY (`WHLocationsId`) REFERENCES `WHLocations` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_RawMaterials_PackingListsId` ON `RawMaterials` (`PackingListsId`);

CREATE INDEX `IX_RawMaterials_ProductionOrdersId` ON `RawMaterials` (`ProductionOrdersId`);

CREATE INDEX `IX_RawMaterials_RawMaterialTypeEntityId` ON `RawMaterials` (`RawMaterialTypeEntityId`);

CREATE INDEX `IX_RawMaterials_RawMaterialTypesId` ON `RawMaterials` (`RawMaterialTypesId`);

CREATE INDEX `IX_RawMaterials_WHLocationsId` ON `RawMaterials` (`WHLocationsId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210411153621_RawMaterialEntities', '3.1.7');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210418153655_EmailJobEntity', '3.1.7');

CREATE TABLE `EmailJobConfigs` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Email` text NOT NULL,
    `Password` text NOT NULL,
    `SmtpHost` text NOT NULL,
    `SmtpPort` int NOT NULL,
    `EnableSSL` bit NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `CreateDate` datetime NOT NULL,
    `LastUpdateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210418154158_EmailJobEntity2', '3.1.7');

ALTER TABLE `Stops` ADD `Cost` decimal(18,2) NOT NULL DEFAULT 0;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210502134223_StopsCost', '3.1.7');

ALTER TABLE `ImportDetails` ADD `LeadTime` datetime NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210502154017_LeadTimeImportDetail', '3.1.7');

ALTER TABLE `Imports` ADD `POFinishDate` datetime NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210502160556_POFinishDateImport', '3.1.7');

CREATE TABLE `IoTDatas` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `DispositivoIOT` int NOT NULL,
    `Nombres` varchar(80) NOT NULL,
    `Valores` varchar(50) NOT NULL,
    `Fecha` datetime NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210503152245_IoTDataEntity', '3.1.7');

ALTER TABLE `ProductionOrders` DROP CONSTRAINT `FK_ProductionOrders_MetalUnits_MetalUnitsId`;

DROP INDEX IX_ProductionOrders_MetalUnitsId ON ProductionOrders;

DROP INDEX IX_MetalUnits_PackingListsId ON MetalUnits;

ALTER TABLE `ProductionOrders` DROP COLUMN `MetalUnitsId`;

ALTER TABLE `MetalUnits` DROP COLUMN `PackingListsId`;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210530231502_PackingListProdOrder', '3.1.7');

CREATE TABLE `IoTDataAlertNotifications` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `EmployeesId` int NOT NULL,
    `Subject` text NULL,
    `Seen` bit NOT NULL,
    `EmailSent` bit NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `CreateDate` datetime NOT NULL,
    `LastUpdateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_IoTDataAlertNotifications_Employees_EmployeesId` FOREIGN KEY (`EmployeesId`) REFERENCES `Employees` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_IoTDataAlertNotifications_EmployeesId` ON `IoTDataAlertNotifications` (`EmployeesId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210617233031_IoTDataAlertNotificationEntity', '3.1.7');

ALTER TABLE `IoTVariables` ADD `DailyReset` bit NOT NULL DEFAULT FALSE;

ALTER TABLE `IoTVariables` ADD `UpdateInterval` decimal(18,4) NOT NULL DEFAULT 0;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210618190424_IoTVariableEntityInterval', '3.1.7');

ALTER TABLE `Processes` ADD `Remarks` text NULL;

CREATE TABLE `Installations` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Code` varchar(4) NOT NULL,
    `Name` varchar(80) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Methods` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Code` varchar(4) NOT NULL,
    `Name` varchar(80) NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Routes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `InstallationsId` int NOT NULL,
    `Code` varchar(30) NOT NULL,
    `Name` varchar(100) NOT NULL,
    `Active` bit NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Routes_Installations_InstallationsId` FOREIGN KEY (`InstallationsId`) REFERENCES `Installations` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `BOMs` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ProductsId` int NOT NULL,
    `InstallationsId` int NOT NULL,
    `MethodsId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_BOMs_Installations_InstallationsId` FOREIGN KEY (`InstallationsId`) REFERENCES `Installations` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_BOMs_Methods_MethodsId` FOREIGN KEY (`MethodsId`) REFERENCES `Methods` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_BOMs_Products_ProductsId` FOREIGN KEY (`ProductsId`) REFERENCES `Products` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `RouteOperations` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `RoutesId` int NOT NULL,
    `Code` int NOT NULL,
    `ProcessesId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_RouteOperations_Processes_ProcessesId` FOREIGN KEY (`ProcessesId`) REFERENCES `Processes` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_RouteOperations_Routes_RoutesId` FOREIGN KEY (`RoutesId`) REFERENCES `Routes` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `BOMDetails` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `BOMsId` int NOT NULL,
    `ProductsId` int NOT NULL,
    `BaseQuantity` decimal(18,2) NULL,
    `RequiredQuantity` decimal(18,2) NULL,
    `AdicionalQuantity` decimal(18,2) NULL,
    `WastePercentage` decimal(18,2) NULL,
    `ActivationDateTime` datetime NULL,
    `InactivationDateTime` datetime NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_BOMDetails_BOMs_BOMsId` FOREIGN KEY (`BOMsId`) REFERENCES `BOMs` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_BOMDetails_Products_ProductsId` FOREIGN KEY (`ProductsId`) REFERENCES `Products` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_BOMDetails_BOMsId` ON `BOMDetails` (`BOMsId`);

CREATE INDEX `IX_BOMDetails_ProductsId` ON `BOMDetails` (`ProductsId`);

CREATE INDEX `IX_BOMs_InstallationsId` ON `BOMs` (`InstallationsId`);

CREATE INDEX `IX_BOMs_MethodsId` ON `BOMs` (`MethodsId`);

CREATE INDEX `IX_BOMs_ProductsId` ON `BOMs` (`ProductsId`);

CREATE INDEX `IX_RouteOperations_ProcessesId` ON `RouteOperations` (`ProcessesId`);

CREATE INDEX `IX_RouteOperations_RoutesId` ON `RouteOperations` (`RoutesId`);

CREATE INDEX `IX_Routes_InstallationsId` ON `Routes` (`InstallationsId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210623005327_BOMEntities', '3.1.7');

CREATE TABLE `CalendarCategories` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Calendars` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `CalendarEvents` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CalendarsId` int NOT NULL,
    `CalendarCategoriesId` int NOT NULL,
    `Name` varchar(100) NOT NULL,
    `EventStartDate` datetime NOT NULL,
    `EventEndDate` datetime NOT NULL,
    `EventStartTime` datetime NOT NULL,
    `EventEndTime` datetime NOT NULL,
    `EventRemember` bit NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_CalendarEvents_CalendarCategories_CalendarCategoriesId` FOREIGN KEY (`CalendarCategoriesId`) REFERENCES `CalendarCategories` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_CalendarEvents_Calendars_CalendarsId` FOREIGN KEY (`CalendarsId`) REFERENCES `Calendars` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_CalendarEvents_CalendarCategoriesId` ON `CalendarEvents` (`CalendarCategoriesId`);

CREATE INDEX `IX_CalendarEvents_CalendarsId` ON `CalendarEvents` (`CalendarsId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210711130932_CalendarEntities', '3.1.7');

CREATE TABLE `ModuleCategories` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `ModuleRoles` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `SubModulesId` int NOT NULL,
    `Access` bit NOT NULL,
    `RolId` text NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Modules` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `Order` int NOT NULL,
    `ModuleCategoriesId` int NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Modules_ModuleCategories_ModuleCategoriesId` FOREIGN KEY (`ModuleCategoriesId`) REFERENCES `ModuleCategories` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `SubModules` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ModulesId` int NOT NULL,
    `Name` varchar(80) NOT NULL,
    `Order` int NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    `ModuleRolEntityId` int NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SubModules_ModuleRoles_ModuleRolEntityId` FOREIGN KEY (`ModuleRolEntityId`) REFERENCES `ModuleRoles` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_SubModules_Modules_ModulesId` FOREIGN KEY (`ModulesId`) REFERENCES `Modules` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_Modules_ModuleCategoriesId` ON `Modules` (`ModuleCategoriesId`);

CREATE INDEX `IX_SubModules_ModuleRolEntityId` ON `SubModules` (`ModuleRolEntityId`);

CREATE INDEX `IX_SubModules_ModulesId` ON `SubModules` (`ModulesId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210711141110_ModulesRolsEntities', '3.1.7');

ALTER TABLE `SubModules` DROP CONSTRAINT `FK_SubModules_ModuleRoles_ModuleRolEntityId`;

DROP INDEX IX_SubModules_ModuleRolEntityId ON SubModules;

ALTER TABLE `SubModules` DROP COLUMN `ModuleRolEntityId`;

CREATE INDEX `IX_ModuleRoles_SubModulesId` ON `ModuleRoles` (`SubModulesId`);

ALTER TABLE `ModuleRoles` ADD CONSTRAINT `FK_ModuleRoles_SubModules_SubModulesId` FOREIGN KEY (`SubModulesId`) REFERENCES `SubModules` (`Id`) ON DELETE CASCADE;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210728233326_ModuleRolRelation', '3.1.7');

ALTER TABLE `CalendarCategories` ADD `Color` varchar(20) NOT NULL DEFAULT '';

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210806002156_ColorCalendarEvent', '3.1.7');

ALTER TABLE `CalendarEvents` ADD `EmailSent` bit NOT NULL DEFAULT FALSE;

ALTER TABLE `CalendarEvents` ADD `Seen` bit NOT NULL DEFAULT FALSE;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210810142312_SeenCalendarEventEntity', '3.1.7');

ALTER TABLE `BOMDetails` ADD `ComponentsId` int NOT NULL DEFAULT 0;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210815152456_ComponentIdBOMDetailEntity', '3.1.7');

ALTER TABLE `Imports` ADD `PaymentMethodEntityId` int NULL;

CREATE TABLE `CustomerTypes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Initials` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `DiscountLists` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Initials` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `PaymentMethods` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `PriceLists` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Initials` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Taxes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Code` varchar(30) NULL,
    `Name` varchar(150) NOT NULL,
    `TaxPercentage` decimal(18,2) NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `VendorTypes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(150) NOT NULL,
    `Initials` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Vendors` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Code` varchar(30) NULL,
    `Name` varchar(150) NOT NULL,
    `VendorTypesId` int NOT NULL,
    `BlockId` int NOT NULL,
    `InstallationsId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Vendors_Installations_InstallationsId` FOREIGN KEY (`InstallationsId`) REFERENCES `Installations` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Vendors_VendorTypes_VendorTypesId` FOREIGN KEY (`VendorTypesId`) REFERENCES `VendorTypes` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Customers` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Code` varchar(30) NULL,
    `Name` varchar(150) NOT NULL,
    `Latitude` text NULL,
    `Longitude` text NULL,
    `Initials` text NULL,
    `CustomerTypesId` int NOT NULL,
    `CreditLimit` decimal(18,2) NULL,
    `BlockId` int NOT NULL,
    `VendorsId` int NOT NULL,
    `InstallationsId` int NOT NULL,
    `InvoiceDeliveryId` int NOT NULL,
    `TaxesId` int NOT NULL,
    `InvoiceCopies` decimal(18,2) NULL,
    `CurrenciesId` int NOT NULL,
    `PricesListsId` int NOT NULL,
    `DiscountListsId` int NOT NULL,
    `DownPaymentPercentage` decimal(18,2) NULL,
    `DownPaymentApId` int NOT NULL,
    `PaymentTermsId` int NOT NULL,
    `PaymentMethodsId` int NOT NULL,
    `Remarks` text NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    `PriceListsId` int NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Customers_Currencies_CurrenciesId` FOREIGN KEY (`CurrenciesId`) REFERENCES `Currencies` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Customers_CustomerTypes_CustomerTypesId` FOREIGN KEY (`CustomerTypesId`) REFERENCES `CustomerTypes` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Customers_DiscountLists_DiscountListsId` FOREIGN KEY (`DiscountListsId`) REFERENCES `DiscountLists` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Customers_Installations_InstallationsId` FOREIGN KEY (`InstallationsId`) REFERENCES `Installations` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Customers_PaymentMethods_PaymentMethodsId` FOREIGN KEY (`PaymentMethodsId`) REFERENCES `PaymentMethods` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Customers_PaymentTerms_PaymentTermsId` FOREIGN KEY (`PaymentTermsId`) REFERENCES `PaymentTerms` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Customers_PriceLists_PriceListsId` FOREIGN KEY (`PriceListsId`) REFERENCES `PriceLists` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Customers_Taxes_TaxesId` FOREIGN KEY (`TaxesId`) REFERENCES `Taxes` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Customers_Vendors_VendorsId` FOREIGN KEY (`VendorsId`) REFERENCES `Vendors` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `CustomerComms` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CustomerId` int NOT NULL,
    `DateComm` datetime NOT NULL,
    `Message` text NOT NULL,
    `Name` varchar(150) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    `CustomersId` int NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_CustomerComms_Customers_CustomersId` FOREIGN KEY (`CustomersId`) REFERENCES `Customers` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `CustomerFiles` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CustomersId` int NOT NULL,
    `Remarks` text NULL,
    `FilePath` text NULL,
    `LoadDate` datetime NOT NULL,
    `TypeFile` int NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_CustomerFiles_Customers_CustomersId` FOREIGN KEY (`CustomersId`) REFERENCES `Customers` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_Imports_PaymentMethodEntityId` ON `Imports` (`PaymentMethodEntityId`);

CREATE INDEX `IX_CustomerComms_CustomersId` ON `CustomerComms` (`CustomersId`);

CREATE INDEX `IX_CustomerFiles_CustomersId` ON `CustomerFiles` (`CustomersId`);

CREATE INDEX `IX_Customers_CurrenciesId` ON `Customers` (`CurrenciesId`);

CREATE INDEX `IX_Customers_CustomerTypesId` ON `Customers` (`CustomerTypesId`);

CREATE INDEX `IX_Customers_DiscountListsId` ON `Customers` (`DiscountListsId`);

CREATE INDEX `IX_Customers_InstallationsId` ON `Customers` (`InstallationsId`);

CREATE INDEX `IX_Customers_PaymentMethodsId` ON `Customers` (`PaymentMethodsId`);

CREATE INDEX `IX_Customers_PaymentTermsId` ON `Customers` (`PaymentTermsId`);

CREATE INDEX `IX_Customers_PriceListsId` ON `Customers` (`PriceListsId`);

CREATE INDEX `IX_Customers_TaxesId` ON `Customers` (`TaxesId`);

CREATE INDEX `IX_Customers_VendorsId` ON `Customers` (`VendorsId`);

CREATE INDEX `IX_Vendors_InstallationsId` ON `Vendors` (`InstallationsId`);

CREATE INDEX `IX_Vendors_VendorTypesId` ON `Vendors` (`VendorTypesId`);

ALTER TABLE `Imports` ADD CONSTRAINT `FK_Imports_PaymentMethods_PaymentMethodEntityId` FOREIGN KEY (`PaymentMethodEntityId`) REFERENCES `PaymentMethods` (`Id`) ON DELETE RESTRICT;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210829153647_CustomersEntitiesCRM', '3.1.7');

ALTER TABLE `SubModules` ADD `URLPath` varchar(150) NOT NULL DEFAULT '';

ALTER TABLE `Processes` ADD `ProductionTarget` decimal(18,2) NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210908182050_ProcessTarget', '3.1.7');

ALTER TABLE `ProductionOrders` ADD `ExpectedQuantity` decimal(18, 2) NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20211005201533_POExpectedQuantity', '3.1.7');

CREATE TABLE `MovementBasics` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Code` varchar(10) NOT NULL,
    `Name` varchar(80) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `MovementClasses` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Code` varchar(10) NOT NULL,
    `Distance` varchar(50) NOT NULL,
    `MotionRange` varchar(150) NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Movements` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Distance` double NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `MovementTypes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `MovementDetails` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Code` varchar(10) NOT NULL,
    `Name` varchar(80) NOT NULL,
    `MovementBasicsId` int NOT NULL,
    `CompanyId` int NOT NULL,
    `CreateUserId` text NULL,
    `UpdateUserId` text NULL,
    `LastUpdateDate` datetime NOT NULL,
    `CreateDate` datetime NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_MovementDetails_MovementBasics_MovementBasicsId` FOREIGN KEY (`MovementBasicsId`) REFERENCES `MovementBasics` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_MovementDetails_MovementBasicsId` ON `MovementDetails` (`MovementBasicsId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20211006011550_MovementsEntities', '3.1.7');

ALTER TABLE `Companies` ADD `SeederLoad` bit NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20211012002216_SeederLoad', '3.1.7');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20211019165510_Initial', '3.1.7');

