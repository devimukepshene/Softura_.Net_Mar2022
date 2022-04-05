use AdventureWorks2019
go


SELECT COUNT(BusinessEntityID)
FROM Person.Person

SELECT SUM(BusinessEntityID)
FROM Person.Person
SELECT DATEDIFF(year, '2009-01-07 00:00:00.000', '2009-01-09 00:00:00.000') AS ModifiedDate
select ModifiedDate from Person.PersonPhone


SELECT DATEADD(year, 1, '2009-01-07 00:00:00.000') AS ModifiedDate

SELECT CONVERT(float, 25.65)
SELECT CONVERT(int, 25.65)
 
 select * from HumanResources.Employee
 select LEFT(JobTitle,BusinessEntityID) as Employee from HumanResources.Employee


 select len(JobTitle) from HumanResources.Employee


 SELECT REVERSE(JobTitle) from HumanResources.Employee
 --2nd Query
 select ModifiedDate,'$'+convert(varchar,EndOfDayRate) as PaymentAmount
from Sales.CurrencyRate
--5th query
select Name , DaysToManufacture
from Production.Product
where DaysToManufacture in (select DaysToManufacture from Production.Product where Name='blade')
--3 query
CREATE VIEW currency AS
SELECT CurrencyCode, Name,ModifiedDate
FROM Sales.Currency
WHERE CurrencyCode = '%A'
Insert Into currency Select 'EAI','devin Thomas',GETDATE()
Insert Into Sales.Currency(CurrencyCode,Name,ModifiedDate) values('FAT','glory',GETDATE())
select * from Sales.Currency

--4th Query
use trial
go
select * from dbo.tbl_just
create proc taskIns_sp
@name varchar(50),
@gender char(1)
as
insert into tbl_just(name,gender)
values(@name,@gender)

taskIns_sp 'Max','M'
create proc taskup_sp
@sno int,
@age int,
@name varchar(50)
as
update tbl_just set sno=@sno,age=@age where name = @name

task1_sp 1,19,'Max'
create proc taskDel_sp
@sno int
as
delete from tbl_just where sno = @sno
taskDel_sp 1
--Task5
select name, DaysToManufacture
from Production.Product 
where name = ('blade')(select b.Name,b.DaysToManufacture from Production.Product b
where b.DaysToManufacture like('1'))
--Task6
select Name
from Production.Product
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max(Weight) as Maxweight,ProductModelID
from  Production.Product
GRoup By ProductModelID

--Task7
select FirstName,LastName
from Person.Person
select name
from Sales.SalesTerritory sst
join Sales.SalesPerson sp
on sp.TerritoryID=sst.TerritoryID
select max(SalesLastYear),Name
from Sales.SalesTerritory
group by Name