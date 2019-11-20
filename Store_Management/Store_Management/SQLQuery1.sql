

CREATE PROCEDURE USP_Search
(
@Title       varchar(50), 
@name        varchar(50), 
@BeforeDate  varchar(50), 
@AfterDate	 varchar(50)
)

AS
if (@name = "Date")
begin
	if (@Title = "Date")
	begin
			SELECT * FROM SaleBill WHERE Date BETWEEN @BeforeDate AND  @AfterDate
	end
	else if (@Title = "After")
	begin
		select * from SaleBill where [Date] >= @AfterDate
	end										   
	else									   
	begin									   
		select * from SaleBill where [Date] <= @BeforeDate
	end
end
else if (@Title = null)
begin
	if (@name != null)
	begin
		select * from SaleBill where Party= @name 
	end
	else
	begin
		 select * from SaleBill
	end
end
else
begin
	if (@Title = "DateFull")
	begin
		SELECT * FROM SaleBill WHERE Date BETWEEN @BeforeDate AND @AfterDate and Party= @name 
	end
	else if (@Title = "DateAfter")
	begin
		 select * from SaleBill where [Date] >= @AfterDate and Party= @name 
	end
	else
	begin
		 select * from SaleBill where [Date] <= @BeforeDate and Party= @name 
	end
end
