/*
create database Cafeteria_Management_System
*/
/*
Create table Staff(
Username nvarchar(50) Not Null Primary Key,
Password nvarchar(50)
);

Create table Attendance(
Attendance_ID nvarchar(50) Not Null Primary Key,
Date date,
Clock_In time,
Clock_Out time,
Username nvarchar(50) Foreign Key References Staff(Username)
);

Create table Items(
Item_Code nvarchar(50) Not Null Primary Key,
Category nvarchar(50),
Name nvarchar(50),
Price int
);

Create table Customers(
Customer_ID nvarchar(50) Not Null Primary Key,
Name nvarchar(50),
Contact_Number int
);

Create table Orders(
Order_ID nvarchar(50) Not Null Primary Key,
Table_Code nvarchar(50),
Customer_ID nvarchar(50) Foreign Key References Customers(Customer_ID),
Date date,
Time_Order_Is_Made time,
Username nvarchar(50) Foreign Key References Staff(Username)
);

Create table Receipt_Details(
RD_ID nvarchar(50) Not Null Primary Key,
Total int,
Tax int,
Total_Payable_Amount int,
Received int,
Change int,
Order_ID nvarchar(50) Foreign Key References Orders(Order_ID)
);

Create table Order_Details(
OD_ID nvarchar(50) Not Null Primary Key,
Order_ID nvarchar(50) Foreign Key References Orders(Order_ID),
Item_Code nvarchar(50) Foreign Key References Items(Item_Code),
Quantity int,
Status nvarchar(50)
);

Create table Receipts(
Receipt_ID nvarchar(50) Not Null Primary Key,
RD_ID nvarchar(50) Foreign Key References Receipt_Details(RD_ID)
);

ALTER TABLE Receipt_Details
ADD Receipt_ID nvarchar(50) Foreign Key References Receipts(Receipt_ID);

Insert into Staff values
('Kayson','Geyshiet');

ALter Authorization on Database::Cafeteria_Management_System to [sa];

ALTER TABLE Customers
ADD Table_Code nvarchar(50);

Create table Category(
Category nvarchar(50) Not Null Primary Key
);

Create table Status(
Status nvarchar(50) Not Null Primary Key
);

ALTER TABLE Order_Details
DROP COLUMN Status;

ALTER TABLE Order_Details
ADD Status nvarchar(50) Foreign Key References Status(Status);

ALTER TABLE Items
DROP COLUMN Category;

ALTER TABLE Items
ADD Category nvarchar(50) Foreign Key References Category(Category);

ALTER TABLE Orders
DROP COLUMN Time_Order_Is_Made;

ALTER TABLE Orders
DROP COLUMN Date;
*/

/*
ALTER TABLE Order_Details
ALTER COLUMN Status nvarchar(50) Foreign Key References Status(Status);


Insert into Tables values
('A01','Pearson','0123456789'),
('A02','Deitel','0104356734'),
('B01','Rainbow','0189413678');

Insert into Orders values
('S01','Maths','50','A01'),
('S02','Science','100','B01'),
('S03','English','89','A02'),
('S04','Biology','150','A02');
*/
