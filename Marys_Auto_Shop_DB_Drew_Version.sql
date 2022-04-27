USE [master]
GO
/****** Object:  Database [Marys_Auto_Shop_DB]    Script Date: 4/26/2022 10:07:52 PM ******/
CREATE DATABASE [Marys_Auto_Shop_DB]
GO

USE [Marys_Auto_Shop_DB]
GO

CREATE TABLE [dbo].[Customer_Vehicles](
	[Customer_Vehicles_ID] [int] NOT NULL,
	[Customer_ID] [int] NULL,
	[Vehicle_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Customer_Vehicles_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Customer_ID] [int] NOT NULL,
	[CustomerFirstName] [varchar](50) NULL,
	[CustomerLastName] [varchar](50) NULL,
	[CustomerStreetAddress] [varchar](255) NULL,
	[CustomerCity] [varchar](100) NULL,
	[CustomerState] [varchar](2) NULL,
	[CustomerZipCode] [varchar](5) NULL,
	[CustomerPhoneAreaCode] [varchar](3) NULL,
	[CustomerPhoneNumber] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Employee_ID] [int] NOT NULL,
	[EmployeeFirstName] [varchar](50) NULL,
	[EmployeeLastName] [varchar](50) NULL,
	[JobTitle] [varchar](50) NULL,
	[HourlyWage] [money] NULL,
	[Experience] [int] NULL,
	[Invoice_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estimate]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estimate](
	[Estimate_ID] [int] NOT NULL,
	[Customer_ID] [int] NULL,
	[Order_ID] [int] NULL,
	[PriceEstimate] [money] NULL,
	[Date] [date] NULL,
	[Vehicle_ID] [int] NULL,
	[PartsCost] [money] NULL,
	[LaborCost] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Estimate_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[Invoice_ID] [int] NOT NULL,
	[Date] [date] NULL,
	[FinalPrice] [money] NULL,
	[WorkDoneDescription] [varchar](255) NULL,
	[Part_ID] [int] NULL,
	[PartsTotal] [money] NULL,
	[LaborTotal] [money] NULL,
	[Employee_ID] [int] NULL,
	[Technician] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[Invoice_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[Job_ID] [int] NOT NULL,
	[Order_ID] [int] NULL,
	[Employee_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Job_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PartsOrdered]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartsOrdered](
	[Part_ID] [int] NOT NULL,
	[PartName] [varchar](100) NULL,
	[QuantityOrdered] [int] NULL,
	[PartCost] [money] NULL,
	[Estimate_ID] [int] NULL,
	[ServiceDesc] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Part_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[Vehicle_ID] [int] NOT NULL,
	[VehicleMake] [varchar](50) NULL,
	[VehicleModel] [varchar](50) NULL,
	[VehicleTrim] [varchar](50) NULL,
	[VIN] [varchar](17) NULL,
	[VehicleLicensePlate] [varchar](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Vehicle_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Work_Order]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Work_Order](
	[Order_ID] [int] NOT NULL,
	[OrderDescription] [varchar](1000) NULL,
	[Job_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Customer_Vehicles] ([Customer_Vehicles_ID], [Customer_ID], [Vehicle_ID]) VALUES (5001, 1001, 2006)
GO
INSERT [dbo].[Customer_Vehicles] ([Customer_Vehicles_ID], [Customer_ID], [Vehicle_ID]) VALUES (5002, 1002, 2007)
GO
INSERT [dbo].[Customer_Vehicles] ([Customer_Vehicles_ID], [Customer_ID], [Vehicle_ID]) VALUES (5003, 1003, 2008)
GO
INSERT [dbo].[Customer_Vehicles] ([Customer_Vehicles_ID], [Customer_ID], [Vehicle_ID]) VALUES (5004, 1004, 2009)
GO
INSERT [dbo].[Customer_Vehicles] ([Customer_Vehicles_ID], [Customer_ID], [Vehicle_ID]) VALUES (5005, 1005, 2010)
GO
INSERT [dbo].[Customer_Vehicles] ([Customer_Vehicles_ID], [Customer_ID], [Vehicle_ID]) VALUES (5006, 1006, 2001)
GO
INSERT [dbo].[Customer_Vehicles] ([Customer_Vehicles_ID], [Customer_ID], [Vehicle_ID]) VALUES (5007, 1007, 2002)
GO
INSERT [dbo].[Customer_Vehicles] ([Customer_Vehicles_ID], [Customer_ID], [Vehicle_ID]) VALUES (5008, 1008, 2003)
GO
INSERT [dbo].[Customer_Vehicles] ([Customer_Vehicles_ID], [Customer_ID], [Vehicle_ID]) VALUES (5009, 1009, 2004)
GO
INSERT [dbo].[Customer_Vehicles] ([Customer_Vehicles_ID], [Customer_ID], [Vehicle_ID]) VALUES (5010, 1010, 2005)
GO
INSERT [dbo].[Customers] ([Customer_ID], [CustomerFirstName], [CustomerLastName], [CustomerStreetAddress], [CustomerCity], [CustomerState], [CustomerZipCode], [CustomerPhoneAreaCode], [CustomerPhoneNumber]) VALUES (1001, N'Tom', N'Clancy', N'1521 Plunkett Ave.', N'Metroville', N'MN', N'55666', N'320', N'777-8888')
GO
INSERT [dbo].[Customers] ([Customer_ID], [CustomerFirstName], [CustomerLastName], [CustomerStreetAddress], [CustomerCity], [CustomerState], [CustomerZipCode], [CustomerPhoneAreaCode], [CustomerPhoneNumber]) VALUES (1002, N'Nancy', N'Cronkite', N'2337 Wisteria Lane', N'Metroville', N'MN', N'55667', N'320', N'777-8944')
GO
INSERT [dbo].[Customers] ([Customer_ID], [CustomerFirstName], [CustomerLastName], [CustomerStreetAddress], [CustomerCity], [CustomerState], [CustomerZipCode], [CustomerPhoneAreaCode], [CustomerPhoneNumber]) VALUES (1003, N'Millie', N'deMornay', N'141 51st Ave. N.', N'Townberg', N'MN', N'55675', N'320', N'776-8555')
GO
INSERT [dbo].[Customers] ([Customer_ID], [CustomerFirstName], [CustomerLastName], [CustomerStreetAddress], [CustomerCity], [CustomerState], [CustomerZipCode], [CustomerPhoneAreaCode], [CustomerPhoneNumber]) VALUES (1004, N'Conrad', N'Pickles', N'8991 Kumquat Ct.', N'Townberg', N'MN', N'55674', N'320', N'775-8656')
GO
INSERT [dbo].[Customers] ([Customer_ID], [CustomerFirstName], [CustomerLastName], [CustomerStreetAddress], [CustomerCity], [CustomerState], [CustomerZipCode], [CustomerPhoneAreaCode], [CustomerPhoneNumber]) VALUES (1005, N'Amber', N'Yellowfin', N'833 Terpsichore Lane', N'Gardopolis', N'MN', N'55672', N'320', N'775-3655')
GO
INSERT [dbo].[Customers] ([Customer_ID], [CustomerFirstName], [CustomerLastName], [CustomerStreetAddress], [CustomerCity], [CustomerState], [CustomerZipCode], [CustomerPhoneAreaCode], [CustomerPhoneNumber]) VALUES (1006, N'Sophia', N'Garces', N'12323 Bumber St.', N'Metroville', N'MN', N'55667', N'320', N'111-1111')
GO
INSERT [dbo].[Customers] ([Customer_ID], [CustomerFirstName], [CustomerLastName], [CustomerStreetAddress], [CustomerCity], [CustomerState], [CustomerZipCode], [CustomerPhoneAreaCode], [CustomerPhoneNumber]) VALUES (1007, N'Topher', N'McAdams', N'89 Sleepy Circle', N'Metroville', N'MN', N'55667', N'320', N'773-3619')
GO
INSERT [dbo].[Customers] ([Customer_ID], [CustomerFirstName], [CustomerLastName], [CustomerStreetAddress], [CustomerCity], [CustomerState], [CustomerZipCode], [CustomerPhoneAreaCode], [CustomerPhoneNumber]) VALUES (1008, N'Tina', N'Torchrash', N'9823 Cummerbund Terrace', N'Townberg', N'MN', N'55677', N'320', N'770-0019')
GO
INSERT [dbo].[Customers] ([Customer_ID], [CustomerFirstName], [CustomerLastName], [CustomerStreetAddress], [CustomerCity], [CustomerState], [CustomerZipCode], [CustomerPhoneAreaCode], [CustomerPhoneNumber]) VALUES (1009, N'Sam', N'Iamb', N'784 Sonnet St.', N'Townberg', N'MN', N'55687', N'320', N'771-1313')
GO
INSERT [dbo].[Customers] ([Customer_ID], [CustomerFirstName], [CustomerLastName], [CustomerStreetAddress], [CustomerCity], [CustomerState], [CustomerZipCode], [CustomerPhoneAreaCode], [CustomerPhoneNumber]) VALUES (1010, N'Flash', N'Action-Hero', N'4531 Dunkirk Ave.', N'Townberg', N'MN', N'55667', N'320', N'773-3333')
GO
INSERT [dbo].[Customers] ([Customer_ID], [CustomerFirstName], [CustomerLastName], [CustomerStreetAddress], [CustomerCity], [CustomerState], [CustomerZipCode], [CustomerPhoneAreaCode], [CustomerPhoneNumber]) VALUES (1025, N'Herman', N'M', N'sdf', N'sdfs', N'sd', N'sdfsd', N'sdf', N'dfsd')
GO
INSERT [dbo].[Employee] ([Employee_ID], [EmployeeFirstName], [EmployeeLastName], [JobTitle], [HourlyWage], [Experience], [Invoice_ID]) VALUES (3001, N'Tina', N'Torquewrench', N'Senior Technician', 80.0000, 10, NULL)
GO
INSERT [dbo].[Employee] ([Employee_ID], [EmployeeFirstName], [EmployeeLastName], [JobTitle], [HourlyWage], [Experience], [Invoice_ID]) VALUES (3002, N'Brad', N'Broomhandle', N'Technician', 50.0000, 3, NULL)
GO
INSERT [dbo].[Employee] ([Employee_ID], [EmployeeFirstName], [EmployeeLastName], [JobTitle], [HourlyWage], [Experience], [Invoice_ID]) VALUES (3003, N'Wendy', N'Wheelbase', N'Trainee', 30.0000, 0, NULL)
GO
INSERT [dbo].[Estimate] ([Estimate_ID], [Customer_ID], [Order_ID], [PriceEstimate], [Date], [Vehicle_ID], [PartsCost], [LaborCost]) VALUES (4001, 1004, 6004, 150.0000, CAST(N'2021-12-18' AS Date), 2009, 60.0000, 90.0000)
GO
INSERT [dbo].[Estimate] ([Estimate_ID], [Customer_ID], [Order_ID], [PriceEstimate], [Date], [Vehicle_ID], [PartsCost], [LaborCost]) VALUES (4002, 1005, 6005, 350.0000, CAST(N'2021-11-13' AS Date), 2010, 150.0000, 200.0000)
GO
INSERT [dbo].[Estimate] ([Estimate_ID], [Customer_ID], [Order_ID], [PriceEstimate], [Date], [Vehicle_ID], [PartsCost], [LaborCost]) VALUES (4003, 1006, 6001, 375.0000, CAST(N'2021-10-04' AS Date), 2001, 135.0000, 240.0000)
GO
INSERT [dbo].[Estimate] ([Estimate_ID], [Customer_ID], [Order_ID], [PriceEstimate], [Date], [Vehicle_ID], [PartsCost], [LaborCost]) VALUES (4004, 1007, 6002, 189.8900, CAST(N'2022-03-14' AS Date), 2002, 89.8900, 100.0000)
GO
INSERT [dbo].[Estimate] ([Estimate_ID], [Customer_ID], [Order_ID], [PriceEstimate], [Date], [Vehicle_ID], [PartsCost], [LaborCost]) VALUES (4005, 1008, 6003, 315.5600, CAST(N'2022-04-07' AS Date), 2003, 115.5600, 200.0000)
GO
INSERT [dbo].[Invoice] ([Invoice_ID], [Date], [FinalPrice], [WorkDoneDescription], [Part_ID], [PartsTotal], [LaborTotal], [Employee_ID], [Technician]) VALUES (8001, CAST(N'2021-12-19' AS Date), 135.0000, N'Tune Up Special: news spark plugs, belts and fluids.', 7001, 90.0000, 45.0000, NULL, N'Wendy')
GO
INSERT [dbo].[Invoice] ([Invoice_ID], [Date], [FinalPrice], [WorkDoneDescription], [Part_ID], [PartsTotal], [LaborTotal], [Employee_ID], [Technician]) VALUES (8002, CAST(N'2021-11-13' AS Date), 365.0000, N'Install rear breaks, test and bleed system.', 7002, 185.0000, 180.0000, NULL, N'Tina')
GO
INSERT [dbo].[Invoice] ([Invoice_ID], [Date], [FinalPrice], [WorkDoneDescription], [Part_ID], [PartsTotal], [LaborTotal], [Employee_ID], [Technician]) VALUES (8003, CAST(N'2021-10-06' AS Date), 410.0000, N'Install front breaks, test and bleed system.', 7003, 215.0000, 195.0000, NULL, N'Brad')
GO
INSERT [dbo].[Invoice] ([Invoice_ID], [Date], [FinalPrice], [WorkDoneDescription], [Part_ID], [PartsTotal], [LaborTotal], [Employee_ID], [Technician]) VALUES (8004, CAST(N'2022-03-15' AS Date), 179.8900, N'Install muffler; do emission certification test.', 7004, 119.8900, 60.0000, NULL, N'Wendy')
GO
INSERT [dbo].[Invoice] ([Invoice_ID], [Date], [FinalPrice], [WorkDoneDescription], [Part_ID], [PartsTotal], [LaborTotal], [Employee_ID], [Technician]) VALUES (8005, CAST(N'2022-04-08' AS Date), 300.1000, N'Install new tires, do front-end alignment.', 7005, 220.1000, 80.0000, NULL, N'Tina')
GO
INSERT [dbo].[PartsOrdered] ([Part_ID], [PartName], [QuantityOrdered], [PartCost], [Estimate_ID], [ServiceDesc]) VALUES (7001, N'Spark Plugs', 6, 60.0000, 4001, N'Tune Up Special')
GO
INSERT [dbo].[PartsOrdered] ([Part_ID], [PartName], [QuantityOrdered], [PartCost], [Estimate_ID], [ServiceDesc]) VALUES (7002, N'Brake Pads (pair)', 1, 150.0000, 4002, N'Install Front Brakes')
GO
INSERT [dbo].[PartsOrdered] ([Part_ID], [PartName], [QuantityOrdered], [PartCost], [Estimate_ID], [ServiceDesc]) VALUES (7003, N'Brake Pads (pair)', 1, 135.0000, 4003, N'Install Front Brakes')
GO
INSERT [dbo].[PartsOrdered] ([Part_ID], [PartName], [QuantityOrdered], [PartCost], [Estimate_ID], [ServiceDesc]) VALUES (7004, N'Muffler', 1, 89.8900, 4004, N'Exhaust system install and cerfify')
GO
INSERT [dbo].[PartsOrdered] ([Part_ID], [PartName], [QuantityOrdered], [PartCost], [Estimate_ID], [ServiceDesc]) VALUES (7005, N'All-Weather Tires', 2, 115.5600, 4005, N'Install new tires and front-end alignment')
GO
INSERT [dbo].[Vehicles] ([Vehicle_ID], [VehicleMake], [VehicleModel], [VehicleTrim], [VIN], [VehicleLicensePlate]) VALUES (2001, N'Dodge', N'Charger', N'SXT', N'5FNRL38739B001353', N'LRT 543')
GO
INSERT [dbo].[Vehicles] ([Vehicle_ID], [VehicleMake], [VehicleModel], [VehicleTrim], [VIN], [VehicleLicensePlate]) VALUES (2002, N'Nissan', N'Rogue', N'Platinum', N'1G1ZD5E09CF251160', N'KME 198')
GO
INSERT [dbo].[Vehicles] ([Vehicle_ID], [VehicleMake], [VehicleModel], [VehicleTrim], [VIN], [VehicleLicensePlate]) VALUES (2003, N'Toyota', N'Camry', N'SE', N'4JGBB86E27A199749', N'OPE 822')
GO
INSERT [dbo].[Vehicles] ([Vehicle_ID], [VehicleMake], [VehicleModel], [VehicleTrim], [VIN], [VehicleLicensePlate]) VALUES (2004, N'Subaru', N'Outback', N'Premium', N'1FTSW21P75EA53447', N'PPD 377')
GO
INSERT [dbo].[Vehicles] ([Vehicle_ID], [VehicleMake], [VehicleModel], [VehicleTrim], [VIN], [VehicleLicensePlate]) VALUES (2005, N'Chevrolet', N'Camaro', N'SS', N'SCBLC37F85CX10207', N'YVF 003')
GO
INSERT [dbo].[Vehicles] ([Vehicle_ID], [VehicleMake], [VehicleModel], [VehicleTrim], [VIN], [VehicleLicensePlate]) VALUES (2006, N'Honda', N'Accord', N'LX', N'1P3BP36D3HF192068', N'NRF 883')
GO
INSERT [dbo].[Vehicles] ([Vehicle_ID], [VehicleMake], [VehicleModel], [VehicleTrim], [VIN], [VehicleLicensePlate]) VALUES (2007, N'Dodge', N'Durango', N'SRT', N'YS3AK35E4M5002999', N'IKL 487')
GO
INSERT [dbo].[Vehicles] ([Vehicle_ID], [VehicleMake], [VehicleModel], [VehicleTrim], [VIN], [VehicleLicensePlate]) VALUES (2008, N'Mini', N'Cooper', N'Classic', N'1FMZU72X6YZC22785', N'SQK 733')
GO
INSERT [dbo].[Vehicles] ([Vehicle_ID], [VehicleMake], [VehicleModel], [VehicleTrim], [VIN], [VehicleLicensePlate]) VALUES (2009, N'Chrysler', N'Pacifica', N'Limited', N'1D7HU18D54S747050', N'MTG 064')
GO
INSERT [dbo].[Vehicles] ([Vehicle_ID], [VehicleMake], [VehicleModel], [VehicleTrim], [VIN], [VehicleLicensePlate]) VALUES (2010, N'Buick', N'Encore', N'Preferred', N'WV2YB0257EH008533', N'HNN 904')
GO
INSERT [dbo].[Work_Order] ([Order_ID], [OrderDescription], [Job_ID]) VALUES (6001, N'Brake Pad inspection, install new Brake Pads, bleed system.', NULL)
GO
INSERT [dbo].[Work_Order] ([Order_ID], [OrderDescription], [Job_ID]) VALUES (6002, N'Exhaust system inspection, new muffler install, emission certification testing', NULL)
GO
INSERT [dbo].[Work_Order] ([Order_ID], [OrderDescription], [Job_ID]) VALUES (6003, N'Two new front tires, front end alignment, calibration test.', NULL)
GO
INSERT [dbo].[Work_Order] ([Order_ID], [OrderDescription], [Job_ID]) VALUES (6004, N'Tune up special, belts, spark plugs, fluids, etc.', NULL)
GO
INSERT [dbo].[Work_Order] ([Order_ID], [OrderDescription], [Job_ID]) VALUES (6005, N'Brake Pad inspection, install new Brake Pads, bleed system.', NULL)
GO
ALTER TABLE [dbo].[Customer_Vehicles]  WITH CHECK ADD FOREIGN KEY([Customer_ID])
REFERENCES [dbo].[Customers] ([Customer_ID])
GO
ALTER TABLE [dbo].[Customer_Vehicles]  WITH CHECK ADD FOREIGN KEY([Vehicle_ID])
REFERENCES [dbo].[Vehicles] ([Vehicle_ID])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([Invoice_ID])
REFERENCES [dbo].[Invoice] ([Invoice_ID])
GO
ALTER TABLE [dbo].[Estimate]  WITH CHECK ADD FOREIGN KEY([Customer_ID])
REFERENCES [dbo].[Customers] ([Customer_ID])
GO
ALTER TABLE [dbo].[Estimate]  WITH CHECK ADD FOREIGN KEY([Order_ID])
REFERENCES [dbo].[Work_Order] ([Order_ID])
GO
ALTER TABLE [dbo].[Estimate]  WITH CHECK ADD FOREIGN KEY([Vehicle_ID])
REFERENCES [dbo].[Vehicles] ([Vehicle_ID])
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Employee] ([Employee_ID])
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD FOREIGN KEY([Part_ID])
REFERENCES [dbo].[PartsOrdered] ([Part_ID])
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Employee] ([Employee_ID])
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD FOREIGN KEY([Order_ID])
REFERENCES [dbo].[Work_Order] ([Order_ID])
GO
ALTER TABLE [dbo].[PartsOrdered]  WITH CHECK ADD FOREIGN KEY([Estimate_ID])
REFERENCES [dbo].[Estimate] ([Estimate_ID])
GO
ALTER TABLE [dbo].[Work_Order]  WITH CHECK ADD FOREIGN KEY([Job_ID])
REFERENCES [dbo].[Job] ([Job_ID])
GO
/****** Object:  StoredProcedure [dbo].[Customer_Delete_Record]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customer_Delete_Record]
	@Customer_ID int
AS
BEGIN
     DELETE FROM Customers
     WHERE  Customer_ID = @Customer_ID
END
GO
/****** Object:  StoredProcedure [dbo].[Customer_GetByCity]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customer_GetByCity]
	@CustomerCity varchar(100)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Customers
	WHERE CustomerCity = @CustomerCity;
END
GO
/****** Object:  StoredProcedure [dbo].[Customer_GetByID]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customer_GetByID]
	@Customer_ID varchar(8)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Customers
	WHERE Customer_ID = @Customer_ID

END
GO
/****** Object:  StoredProcedure [dbo].[Customer_GetByLastName]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customer_GetByLastName]
	@LastName nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Customers
	WHERE CustomerLastName = @LastName;
END
GO
/****** Object:  StoredProcedure [dbo].[Customer_GetByZip]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customer_GetByZip]
	@CustomerZipCode varchar(5)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Customers
	WHERE CustomerZipCode = @CustomerZipCode;
END
GO
/****** Object:  StoredProcedure [dbo].[Customer_Insert_Record]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customer_Insert_Record]
	@Customer_ID int,
	@CustomerFirstName nvarchar(50),
	@CustomerLastName nvarchar(50),
	@CustomerStreetAddress nvarchar(255),
	@CustomerCity nvarchar(100),
	@CustomerState nvarchar(2),
	@CustomerZipCode nvarchar(5),
	@CustomerPhoneAreaCode nvarchar(3),
	@CustomerPhoneNumber nvarchar(7)
AS
BEGIN
	SET NOCOUNT ON;

            INSERT INTO Customers
                        (Customer_ID,
                         CustomerFirstName,
                         CustomerLastName,
                         CustomerStreetAddress,
                         CustomerCity,
						 CustomerState,
						 CustomerZipCode,
						 CustomerPhoneAreaCode,
						 CustomerPhoneNumber)
            VALUES     ( @Customer_ID,
                         @CustomerFirstName,
                         @CustomerLastName,
                         @CustomerStreetAddress,
						 @CustomerCity,
						 @CustomerState,
						 @CustomerZipCode,
						 @CustomerPhoneAreaCode,
                         @CustomerPhoneNumber)

END
GO
/****** Object:  StoredProcedure [dbo].[Customer_Modify_Record]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customer_Modify_Record]
	@Customer_ID int,
	@CustomerFirstName nvarchar(50),
	@CustomerLastName nvarchar(50),
	@CustomerStreetAddress nvarchar(255),
	@CustomerCity nvarchar(100),
	@CustomerState nvarchar(2),
	@CustomerZipCode nvarchar(5),
	@CustomerPhoneAreaCode nvarchar(3),
	@CustomerPhoneNumber nvarchar(8)
AS
BEGIN
	SET NOCOUNT ON;

	    DELETE FROM Customers
		WHERE  Customer_ID = @Customer_ID

            INSERT INTO Customers
                        (Customer_ID,
                         CustomerFirstName,
                         CustomerLastName,
                         CustomerStreetAddress,
                         CustomerCity,
						 CustomerState,
						 CustomerZipCode,
						 CustomerPhoneAreaCode,
						 CustomerPhoneNumber)
            VALUES     ( @Customer_ID,
                         @CustomerFirstName,
                         @CustomerLastName,
                         @CustomerStreetAddress,
						 @CustomerCity,
						 @CustomerState,
						 @CustomerZipCode,
						 @CustomerPhoneAreaCode,
                         @CustomerPhoneNumber)

END
GO
/****** Object:  StoredProcedure [dbo].[CustomerTable]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CustomerTable]
	@CustomerState varchar(2)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Customers
	WHERE CustomerState = @CustomerState;
END
GO
/****** Object:  StoredProcedure [dbo].[CustomerTable2]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CustomerTable2]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Customers

END
GO
/****** Object:  StoredProcedure [dbo].[Employee_GetByFirstName]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Employee_GetByFirstName]
	@EmployeeFirstName varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Employee
	WHERE EmployeeFirstName = @EmployeeFirstName

END
GO
/****** Object:  StoredProcedure [dbo].[Employee_GetByJobTitle]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Employee_GetByJobTitle]
	@JobTitle varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Employee
	WHERE JobTitle = @JobTitle

END
GO
/****** Object:  StoredProcedure [dbo].[Employee_GetTable]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Employee_GetTable]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Employee

END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_GetByID]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Estimate_GetByID]
	@Estimate_ID int

AS
BEGIN
	SET NOCOUNT ON;

	SELECT FORMAT (Date, 'MM-dd-yy') as date, Customers.CustomerFirstName, Customers.CustomerLastName, 
	Customers.CustomerStreetAddress, Customers.CustomerCity, 
	Customers.CustomerState, Customers.CustomerZipCode, 
	Customers.CustomerPhoneAreaCode, Customers.CustomerPhoneNumber, 
	Vehicles.VehicleMake, Vehicles.VehicleModel,
	Vehicles.VehicleTrim, Vehicles.VIN, Vehicles.VehicleLicensePlate,
	Work_Order.OrderDescription, Estimate.PartsCost, 
	Estimate.LaborCost, Estimate.PriceEstimate
FROM Estimate
JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID
JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID
JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID
WHERE Estimate.Estimate_ID = @Estimate_ID;

END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_GetTable]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Estimate_GetTable]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Estimate

END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_GetZipByID]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Estimate_GetZipByID]
	@Estimate_ID int

AS
BEGIN
	SET NOCOUNT ON;

SELECT Customers.CustomerZipCode
FROM Estimate
JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID
JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID
JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID
WHERE Estimate.Estimate_ID = @Estimate_ID;

END
GO
/****** Object:  StoredProcedure [dbo].[Invoice_GetByID]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Invoice_GetByID]
	@Invoice_ID int

AS
BEGIN
	SET NOCOUNT ON;

SELECT FORMAT (Invoice.Date, 'MM-dd-yy') as date, 
	Customers.CustomerFirstName, Customers.CustomerLastName, 
	Customers.CustomerStreetAddress, Customers.CustomerCity, 
	Customers.CustomerState, Customers.CustomerZipCode, 
	Customers.CustomerPhoneAreaCode, Customers.CustomerPhoneNumber, 
	Vehicles.VehicleMake, Vehicles.VehicleModel,
	Vehicles.VehicleTrim, Vehicles.VIN, Vehicles.VehicleLicensePlate,
	Invoice.WorkDoneDescription, PartsOrdered.PartName, 
	PartsOrdered.QuantityOrdered, PartsOrdered.PartCost,
	Invoice.Technician,
	Estimate.PriceEstimate,
	Invoice.PartsTotal, Invoice.LaborTotal, Invoice.FinalPrice

FROM Invoice
JOIN PartsOrdered ON Invoice.Part_ID = PartsOrdered.Part_ID
JOIN Estimate ON PartsOrdered.Estimate_ID = Estimate.Estimate_ID
JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID
JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID
JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID
WHERE Invoice.Invoice_ID = @Invoice_ID;

END
GO
/****** Object:  StoredProcedure [dbo].[Invoice_GetTable]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Invoice_GetTable]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Invoice

END
GO
/****** Object:  StoredProcedure [dbo].[Vehicle_Delete_Record]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Vehicle_Delete_Record]
	@Vehicle_ID int
AS
BEGIN
     DELETE FROM Vehicles
     WHERE  Vehicle_ID = @Vehicle_ID
END
GO
/****** Object:  StoredProcedure [dbo].[Vehicle_Insert_Record]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[Vehicle_Insert_Record]
	@Vehicle_ID int,
	@VehicleMake nvarchar(50),
	@VehicleModel nvarchar(50),
	@VehicleTrim nvarchar(50),
	@VIN nvarchar(17),
	@VehicleLicensePlate nvarchar(7)
AS
BEGIN
	SET NOCOUNT ON;

            INSERT INTO Vehicles
                        (Vehicle_ID,
                         VehicleMake,
                         VehicleModel,
                         VehicleTrim,
                         VIN,
						 VehicleLicensePlate)
            VALUES     ( @Vehicle_ID,
                         @VehicleMake,
                         @VehicleModel,
                         @VehicleTrim,
						 @VIN,
						 @VehicleLicensePlate)
END
GO
/****** Object:  StoredProcedure [dbo].[Vehicle_Modify_Record]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Vehicle_Modify_Record]
	@Vehicle_ID int,
	@VehicleMake nvarchar(50),
	@VehicleModel nvarchar(50),
	@VehicleTrim nvarchar(50),
	@VIN nvarchar(17),
	@VehicleLicensePlate nvarchar(7)

AS
BEGIN
	SET NOCOUNT ON;

	    DELETE FROM Vehicles
		WHERE  Vehicle_ID = @Vehicle_ID

            INSERT INTO Vehicles
                        (Vehicle_ID,
                         VehicleMake,
                         VehicleModel,
                         VehicleTrim,
                         VIN,
						 VehicleLicensePlate)
            VALUES     ( @Vehicle_ID,
                         @VehicleMake,
                         @VehicleModel,
                         @VehicleTrim,
						 @VIN,
						 @VehicleLicensePlate)
END
GO
/****** Object:  StoredProcedure [dbo].[Vehicles_GetByID]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Vehicles_GetByID]
	@Vehicle_ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Vehicles
	WHERE Vehicle_ID = @Vehicle_ID

END
GO
/****** Object:  StoredProcedure [dbo].[Vehicles_GetByMake]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Vehicles_GetByMake]
	@VehicleMake varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Vehicles
	WHERE VehicleMake = @VehicleMake

END
GO
/****** Object:  StoredProcedure [dbo].[Vehicles_GetByModel]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Vehicles_GetByModel]
	@VehicleModel varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Vehicles
	WHERE VehicleModel = @VehicleModel

END
GO
/****** Object:  StoredProcedure [dbo].[Vehicles_GetByPlate]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Vehicles_GetByPlate]
	@VehicleLicensePlate varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Vehicles
	WHERE VehicleLicensePlate = @VehicleLicensePlate

END
GO
/****** Object:  StoredProcedure [dbo].[Vehicles_GetTable]    Script Date: 4/26/2022 10:07:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Vehicles_GetTable]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Vehicles

END
GO
USE [master]
GO
ALTER DATABASE [Marys_Auto_Shop_DB] SET  READ_WRITE 
GO
