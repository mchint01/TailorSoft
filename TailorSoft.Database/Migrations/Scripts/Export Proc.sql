USE [TailorSoft]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spGetMonthlyBookingBillDetails]
(
	@startDate DATETIME,
	@endDate DATETIME
)

AS

BEGIN

	SELECT
		c.Name AS CustomerName,
		b.BillNumber,
		b.billDt AS BillDt,
		b.BillStatus,
		b.NumberOfSuits,
		b.SuitRate,
		b.NumberOfSuits * b.SuitRate AS AmountForSuits,
		b.NumberOfJackets,
		b.JacketRate,
		b.NumberOfJackets * b.JacketRate AS AmountForJackets,
		b.NumberOfSafary,
		b.SafaryRate,
		b.NumberOfSafary * b.SafaryRate AS AmountForSafaries,
		b.NumberOfTrousers,
		b.TrouserRate,
		b.NumberOfTrousers * b.TrouserRate AS AmountForTrousers,
		b.NumberOfShirts,
		b.ShirtRate,
		b.NumberOfShirts * b.ShirtRate AS AmountForShirts,
		b.NumberOfOthers,
		b.OtherRate,
		b.NumberOfOthers * b.OtherRate AS AmountForOthers,
		c.Id AS CustomerId,
		b.Id AS BillId
	FROM dbo.Bills b
	INNER JOIN dbo.Customers c ON c.Id = b.CustomerId
	WHERE
		b.DeletedDt IS NULL AND
		b.billDt BETWEEN @startDate AND @endDate
	ORDER BY b.BillNumber

END


GO

-----------------------


USE [TailorSoft]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spGetMonthlyDeliveredBillDetails]
(
	@startDate DATETIME,
	@endDate DATETIME
)

AS

BEGIN

	SELECT
		c.Name AS CustomerName,
		b.BillNumber,
		b.billDt AS BillDt,
		b.BillStatus,
		b.NumberOfSuits,
		b.SuitRate,
		b.NumberOfSuits * b.SuitRate AS AmountForSuits,
		b.NumberOfJackets,
		b.JacketRate,
		b.NumberOfJackets * b.JacketRate AS AmountForJackets,
		b.NumberOfSafary,
		b.SafaryRate,
		b.NumberOfSafary * b.SafaryRate AS AmountForSafaries,
		b.NumberOfTrousers,
		b.TrouserRate,
		b.NumberOfTrousers * b.TrouserRate AS AmountForTrousers,
		b.NumberOfShirts,
		b.ShirtRate,
		b.NumberOfShirts * b.ShirtRate AS AmountForShirts,
		b.NumberOfOthers,
		b.OtherRate,
		b.NumberOfOthers * b.OtherRate AS AmountForOthers,
		c.Id AS CustomerId,
		b.Id AS BillId
	FROM dbo.Bills b
	INNER JOIN dbo.Customers c ON c.Id = b.CustomerId
	WHERE
		b.DeletedDt IS NULL AND
		b.BillStatus = 'Delivered' AND
		b.DeliveredDt BETWEEN @startDate AND @endDate
	ORDER BY b.BillNumber

END



GO


-------------------------------------------------

USE [TailorSoft]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spGetLatestCustomerMeasurements]
(
	@customerId UNIQUEIDENTIFIER
)

AS

BEGIN

DECLARE @SuitMeasurements NVARCHAR(450)
DECLARE @JacketMeasurements NVARCHAR(450)
DECLARE @SafaryMeasurements NVARCHAR(450)
DECLARE @TrouserMeasurements NVARCHAR(450)
DECLARE @ShirtMeasurements NVARCHAR(450)
DECLARE @OtherMeasurements NVARCHAR(450)

	SELECT TOP 1 @SuitMeasurements = b.SuitMeasurements FROM dbo.Bills b
	WHERE b.CustomerId = @customerId
		AND b.DeletedDt IS NULL
		AND b.SuitMeasurements IS NOT NULL
	ORDER BY b.BillDt DESC

	SELECT TOP 1 @JacketMeasurements = b.JacketMeasurements FROM dbo.Bills b
	WHERE b.CustomerId = @customerId
		AND b.DeletedDt IS NULL
		AND b.JacketMeasurements IS NOT NULL
	ORDER BY b.BillDt DESC

	SELECT TOP 1 @SafaryMeasurements = b.SafaryMeasurements FROM dbo.Bills b
	WHERE b.CustomerId = @customerId
		AND b.DeletedDt IS NULL
		AND b.SafaryMeasurements IS NOT NULL
	ORDER BY b.BillDt DESC

	SELECT TOP 1 @TrouserMeasurements = b.TrouserMeasurements FROM dbo.Bills b
	WHERE b.CustomerId = @customerId
		AND b.DeletedDt IS NULL
		AND b.TrouserMeasurements IS NOT NULL
	ORDER BY b.BillDt DESC

	SELECT TOP 1 @ShirtMeasurements = b.ShirtMeasurements FROM dbo.Bills b
	WHERE b.CustomerId = @customerId
		AND b.DeletedDt IS NULL
		AND b.ShirtMeasurements IS NOT NULL
	ORDER BY b.BillDt DESC

	SELECT TOP 1 @OtherMeasurements = b.OtherMeasurements FROM dbo.Bills b
	WHERE b.CustomerId = @customerId
		AND b.DeletedDt IS NULL
		AND b.OtherMeasurements IS NOT NULL
	ORDER BY b.BillDt DESC

  SELECT
	@SuitMeasurements AS SuitMeasurements,
	@JacketMeasurements AS JacketMeasurements,
	@SafaryMeasurements AS SafaryMeasurements,
	@TrouserMeasurements AS TrouserMeasurements,
	@ShirtMeasurements AS ShirtMeasurements,
	@OtherMeasurements AS OtherMeasurements

END

--------------------------------------------------------