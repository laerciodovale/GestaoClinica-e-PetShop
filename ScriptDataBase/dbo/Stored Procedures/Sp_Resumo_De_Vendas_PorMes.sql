
create PROCEDURE  [dbo].[Sp_Resumo_De_Vendas_PorMes] (  @DataInicio DATE,
@DataFim DATE )   AS BEGIN
	    
select Produto, 
[1] as Janeiro, 
[2] as Fevereiro, 
[3] as Marco, 
[4] as Abri, 
[5] as Maio, 
[6] as Junho, 
[7] as Julho, 
[8] as Agosto, 
[9] as Setembro, 
[10] as Outubro, 
[11] as Novembro, 
[12] as Dezembro 
from 
(
SELECT month(FaDt) as MesVenda, coalesce (fadesc, '_Total') as Produto,  
sum(favlr) as TotalVendas
FROM [CadVet].[dbo].[CadFaCli]  
where fadt between @DataInicio and @DataFim
group by GROUPING sets
( (fadesc, MONTH (fadt)),
 (month(FaDt))
) ) as Tab_ResumoVendas

PIVOT
(
SUM(TotalVendas)
FOR MesVenda in ([1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12]) )
as TabPivot
order by Produto
   
END