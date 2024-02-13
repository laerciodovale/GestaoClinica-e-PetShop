CREATE procedure [dbo].[Sp_FinA_Insert] 
(
@FaCli as integer,
@FaAni as integer,
@FaNssNro as integer,
@FaEv as nvarchar(20),
@FaDesc as nvarchar(50),
@FaQtd as decimal(10, 3),
@FaVlrU as decimal(12, 2),
@FaDcto as decimal(12, 2),
@FaVlr as decimal(12,2),
@FaFunc as integer,
@FaDt as date, 
@FaVlrAd as decimal(12, 2))
AS
BEGIN
 
	SET NOCOUNT ON

	INSERT  INTO CadFaCli
	(FaCli, FaAni, FaNssNro, FaEv, FaDesc, FaQtd, FaVlrU, FaDcto, FaVlr, FaFunc, FaDt, FaVlrAd) 
	VALUES
	(@FaCli, @FaAni,@FaNssNro,@FaEv,@FaDesc,@FaQtd,@FaVlrU,@FaDcto, @FaVlr, @FaFunc, @FaDt,  @FaVlrAd) 
   
END