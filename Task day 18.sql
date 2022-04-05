use AdventureWorks2019
go
--Task 1
select FirstName,LastName from person.person where Title is not null
--Task 2
select FirstName,LastName from person.person where FirstName like '%a%' or LastName like '%a%'
--Task 3
select sales.CountryRegionCurrency.CurrencyCode,name from sales.currency,sales.CountryRegionCurrency
--Task 4
select * into HR_dept from HumanResources.Department
select * from HR_dept
--tASK 5
CREATE table details
(
Sno int identity(1,1),
FullName varchar(20),
Gender char(1),
Age varchar(2),
EmailID varchar(20))
Insert into details values ('deviMukepshene','F','22','@gmail.com')
Insert into details values ('suvetha','f','17','@gmail.com')
Insert into details values ('vijay Krishnan','M','12','@gmail.com')
select * from details

--Task 6
select dhis.BusinessEntityID,addresstypeid 
from HumanResources.EmployeeDepartmentHistory dhis
join Person.BusinessEntityAddress per 
on dhis.BusinessEntityID = per.BusinessEntityID 
join HumanResources.Department dept on dept.DepartmentID = dhis.DepartmentID

--Task 7
select distinct groupname from HumanResources.Department

--Task 8
select a.standardcost,sum(listprice),sum1.sum(a.standardcost+ListPrice)Sum2 from production.productcosthistory b on a.productID=b.productID group by a.StandardCost
--Task 9
select DATEDIFF(yy,StartDate,Enddate) as YearsOnAge from HumanResources.EmployeeDepartmentHistory
--Task 10
select sum(SalesQuota) from Sales.SalesPersonQuotaHistory where SalesQuota>5000 and SalesQuota < 100000 group by SalesQuota
--Task 11
select MAX(TaxRate)maximumtaxrate from Sales.SalesTaxRate
--Task 12
select emp.BusinessEntityID,dept.DepartmentID,ShiftID from HumanResources.Employee emp join 
HumanResources.EmployeeDepartmentHistory hdhis on emp.BusinessEntityID=hdhis on
emp.BusinessEntityID = hdhis.BusinessEntityID join HumanResources.Department dept on 
dept.DepartmentID= dept.DepartmentID select birthdate,getdate() as currentdate,DATEDIFF(YY,birthdate,GETDATE()) as Age from HumanResources.Employee
--Task 13
create view task12
as select BirthDate,getdate() as CurrentDate,datediff(YY,BirthDate,getDate()) as age from HumanResources.Employee
go
select * from task12
--Task 14
select COUNT(*)
FROM[HumanResources].[Department],[HumanResources].[Employee],[HumanResources].[EmployeeDepartmentHistory],
[HumanResources].[EmployeePayHistory],[HumanResources].[Shift]
--Task 16
select FirstName,MiddleName,Title,dhis.BusinessEntityID from Person.BusinessEntityAddress dhis left outer join Person.Person PP
on PP.BusinessEntityID = dhis.BusinessEntityID where title is not null
--Task 15
select MAX(rate) as MaxSalary,Name from HumanResources.EmployeePayHistory pay
join HumanResources.EmployeeDepartmentHistory dhis on pay.BusinessEntityID = dhis.BusinessEntityID
join HumanResources.Department dept on dept.DepartmentID = dhis.DepartmentID GRoup BY name
--Task 17
select ProductID,LocationID,Shelf from [Production].[ProductInventory] where ProductID>300 and ProductID<=350 and LocationID=50
--Task 18
select p1.LocationID,Shelf,Name from [Production].[ProductInventory] PP
join[Production].[Location] p1 on pp.LocationID=p1.LocationID
--Task 19
select AddressID,AddressLine1,AddressLine2,pa.StateProvinceID,StateProvinceCode,CountryRegionCode from Person.StateProvince psp join Person.Address Pa
on psp.StateProvinceID=pa.StateProvinceID
--Task 20
select sum([SubTotal]),sum([TaxAmt]) from[Sales].[CountryRegionCurrency] crc join[Sales].[SalesTerritory] st on crc.[CountryRegionCode]
= st.[CountryRegionCode] join [Sales].[SalesOrderHeader] soh on st.[TerritoryID] = soh.[TerritoryID] group by st.[TerritoryID]