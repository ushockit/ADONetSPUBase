SELECT * FROM Orders
SELECT COUNT(*) FROM Orders WHERE ShipName = 'La maison d''Asie'
exec dbo.[Sales by Year] '1996-01-01', '1997-12-31';
go

create or alter proc sp_GetMinMaxOrderDates(@minDate datetime output, 
											@maxDate datetime output)
	as
begin
	select @minDate = MIN(OrderDate), @maxDate = MAX(OrderDate) from Orders;
end
go

declare @minDate datetime, @maxDate datetime;
exec sp_GetMinMaxOrderDates @minDate output, @maxDate output;
print @minDate;
print @maxDate;
