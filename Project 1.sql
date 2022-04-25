use Trial
go

create Table ProductTable(
prodID int identity(1,1),
prodName varchar(250),
price money,
Dateofpurchase Date,
EXpiryDate Date)

select * from ProductTable;

create table CustomerTbl
(
custID int identity(1,1),
Namee varchar(200),
Gender varchar(150),
Dob varchar(20),
Conno varchar(20),
EmailID varchar(50),
City Varchar(50))

create table PurchaseTbl1(
BillNo int identity(1,1),
Quantity int,
Amount int,
custID int,
prodID int,
Constraint fk_ref3 foreign key(prodID) references ProductTable(prodID),
constraint fk_ref4 foreign key(custID) references CustomerTbl(custID))

select * from PurchaseTbl1
Alter table ProductTable
add constraint Pk primary key(prodID)
Alter Table CustomerTbl
add constraint Pri primary key(custID)
alter table purchaseTable
Add constraint prima Primary key(BillNo) 
insert into ProductTable values('AirPods',1700,GETDATE(),60+GETDATE())
insert into ProductTable values('smartWatch',8000,GETDATE(),60+GETDATE())
insert into ProductTable values('Bluetooth speakers',800,GETDATE(),60+GETDATE())
insert into ProductTable values('Bluetooth Headphones',1200,GETDATE(),60+GETDATE())
insert into CustomerTbl values('me','female','3 jan','754556436434','@gmail.com','Chennai')
insert into CustomerTbl values('rytuu','male','16 jan','75455685746','abc@gmail.com','mumbai')
insert into CustomerTbl values('gloria','female','23 jan','58766436434','def@gmail.com','trivandrum')
select * from CustomerTbl
use Trial
go

	select PurchaseTbl1.quantity*ProductTable.price as Amt,price,Quantity,BillNo,custID FROM PurchaseTbl1,ProductTable WHERE 
	PurchaseTbl1.BillNo=ProductTable.prodID 
	
	delete from ProductTable where prodID=4
	Select * from ProductTable
