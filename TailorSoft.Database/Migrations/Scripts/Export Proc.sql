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


