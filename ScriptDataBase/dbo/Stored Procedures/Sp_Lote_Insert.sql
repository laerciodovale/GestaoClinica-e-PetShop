-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_Lote_Insert]
	-- Add the parameters for the stored procedure here
(
@NtfSe_data date,
@NtfSe_Desc varchar(45)
)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	declare @Id_Lote int

    -- Insert statements for procedure here
	insert into cadLoteNtFse ( NtfSeData, NtfSeDesc)
	values (@NtfSe_data , @NtfSe_Desc)
	set @Id_Lote = SCOPE_IDENTITY ()
	Select @Id_Lote
	
	end