
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/12/2023 15:16:23
-- Generated from EDMX file: C:\Users\yashfsab\Downloads\Api\DbCompany.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBCompany];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Employee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employee];
GO
IF OBJECT_ID(N'[dbo].[tblEmployee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblEmployee];
GO
IF OBJECT_ID(N'[DBCompanyModelStoreContainer].[Incentives]', 'U') IS NOT NULL
    DROP TABLE [DBCompanyModelStoreContainer].[Incentives];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [EMPLOYEE_ID] int IDENTITY(1,1) NOT NULL,
    [FIRST_NAME] nvarchar(50)  NULL,
    [LAST_NAME] nvarchar(50)  NULL,
    [SALARY] int  NULL,
    [JOINING_DATE] nvarchar(100)  NULL,
    [DEPARTMENT] nvarchar(20)  NULL
);
GO

-- Creating table 'tblEmployees'
CREATE TABLE [dbo].[tblEmployees] (
    [EmployeeId] int  NOT NULL,
    [Name] nvarchar(20)  NULL,
    [ManagerId] int  NULL
);
GO

-- Creating table 'Incentives'
CREATE TABLE [dbo].[Incentives] (
    [EMPLOYEE_REF_ID] nchar(10)  NOT NULL,
    [INCENTIVE_DATE] nvarchar(50)  NULL,
    [INCENTIVE_AMOUNT] int  NULL,
    [Total] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [EMPLOYEE_ID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([EMPLOYEE_ID] ASC);
GO

-- Creating primary key on [EmployeeId] in table 'tblEmployees'
ALTER TABLE [dbo].[tblEmployees]
ADD CONSTRAINT [PK_tblEmployees]
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC);
GO

-- Creating primary key on [EMPLOYEE_REF_ID] in table 'Incentives'
ALTER TABLE [dbo].[Incentives]
ADD CONSTRAINT [PK_Incentives]
    PRIMARY KEY CLUSTERED ([EMPLOYEE_REF_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------