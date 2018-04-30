--create database FakeAmazon

-- Table Creation
--create table Customer
--(
--custId int primary key identity(1,1),
--custFirstName nvarchar(100) not null,
--custLastName nvarchar(100) not null,
--cardNumber int not null
--);

--create table Product
--(
--productId int primary key identity(1,1),
--productName nvarchar(100) not null,
--price decimal(5,2)
--);

--create table Orders
--(
--orderId int primary key identity(1,1),
--fk_custId int not null,
--fk_productId int not null,
--foreign key(fk_custId) references Customer(custId),
--foreign key(fk_productId) references Product(productId)
--);

-- Insert at least 3 records into each table
--insert into Customer(custFirstName, custLastName, cardNumber)
--values('John', 'Doe', 123456789)

--insert into Customer(custFirstName, custLastName, cardNumber)
--values('Jane', 'Smith', 987654321)

--insert into Customer(custFirstName, custLastName, cardNumber)
--values('Henry', 'Blanks', 456789123)

--insert into Product(productName, price)
--values('iPhone', 200.00)

--insert into Product(productName, price)
--values('drone', 175.00)

--insert into Product(productName, price)
--values('radio', 65.25)

--insert into Orders(fk_custId, fk_productId)
--values(2, 3)

--insert into Orders(fk_custId, fk_productId)
--values(1, 2)

--insert into Orders(fk_custId, fk_productId)
--values(2, 3)

-- Add Tina Smith
--insert into Customer(custFirstName, custLastName, cardNumber)
--values('Tina', 'Smith', 987065431)

--insert into Orders(fk_custId, fk_productId)
--values(4,1)

--select * from Customer
--select * from Product
select * from Orders where fk_custId=4
