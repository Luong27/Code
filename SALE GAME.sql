create table Category(
	Category_ID int primary key identity(1,1),
	nameCategory nvarchar(100) NOT NULL

);

INSERT INTO [dbo].[Category] VALUES ('Horror'),
									('Exploration'),
									('Defender');
SELECT * FROM [dbo].[Category]


create table Customer(
	Customer_ID int primary key identity(1,1),
	Customer_Name nvarchar(100) NOT NULL,
	PhoneNumber nvarchar(20),
	Email nvarchar(50),
	Gender nvarchar(50)

);

INSERT INTO [dbo].[Customer] VALUES ('Hai','98312','hai9831@gmail.com','male'),
									('Tai','12849','tai0193@gmail.com','male'),
									('Quyen','81515','quyen5931@gmail.com','female');
SELECT * FROM [dbo].[Customer]

create table Staff(
	Staff_ID int primary key identity(1,1),
	StaffCode nvarchar(50) NOT NULL,
	nameStaff nvarchar(100) NOT NULL,
	Position nvarchar(50),
	AuthorityLevel nvarchar(50) NOT NULL,
	Username nvarchar(50) NOT NULL,
	Password nvarchar(50) NOT NULL,
	Passwordchanged bit default 0

);

INSERT INTO [dbo].[Staff] VALUES ('Emp1','Nguyen Van A', 'Admin','Admin','admin1','123456',1),
								 ('Emp2','Nguyen Van B', 'Warehouse Manager','Warehouse Manager','warehousemanager1','123456',1),
								 ('Emp3','Nguyen Van C', 'Sale','Sale','sale1','123456',0);

SELECT * FROM [dbo].[Staff]

create table Orders(
	Orders_ID int primary key identity(1,1),
	Staff_ID int,
	foreign key (Staff_ID) references [dbo].[Staff] (Staff_ID),
	Customer_ID int,
	foreign key (Customer_ID) references [dbo].[Customer] (Customer_ID),

);

SELECT * FROM [dbo].[Orders]

create table Game(
	Game_ID int primary key identity(1,1),
	nameGame nvarchar(100)NOT NULL,
	Selling_Price decimal(10,2) NOT NULL,
	Game_Code nvarchar(100)NOT NULL

);

create table Import(
	Import_ID int primary key identity(1,1),
	Import_Date datetime not null,
	Staff_ID int,
	foreign key (Staff_ID) references [dbo].[Staff] (Staff_ID),

);

create table ImportDetail(
	ImportDetail_ID int primary key identity(1,1),
	Game_ID int,
	foreign key (Game_ID) references [dbo].[Game] (Game_ID),
	Import_ID int,
	foreign key (Import_ID) references [dbo].[Import] (Import_ID),
	Import_Quantity nvarchar(100),
	Import_Cost nvarchar(50)

);

create table CategoryGame(
	CategoryGame_ID int primary key identity(1,1),
	Category_ID int,
	foreign key (Category_ID) references [dbo].[Category] (Category_ID),
	Game_ID int,
	foreign key (Game_ID) references [dbo].[Game] (Game_ID)

);

create table OrderDetail(
	OrderDetail_ID int primary key identity(1,1),
	Game_ID int,
	foreign key (Game_ID) references [dbo].[Game] (Game_ID),
	Orders_ID int,
	foreign key (Orders_ID) references [dbo].[Orders] (Orders_ID),
	Order_Quantity nvarchar (100)

);

SELECT
	o.Orders_ID,
	o.Staff_ID,
	s.nameStaff,
	o.Customer_ID,
	c.Customer_Name
FROM
	Orders o
INNER JOIN
	Staff s ON o.Staff_ID = s.Staff_ID
INNER JOIN 
	Customer c ON o.Customer_ID = c.Customer_ID;