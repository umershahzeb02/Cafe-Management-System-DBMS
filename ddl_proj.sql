
create table staff(
	staffID int identity(101,1) primary key,
	firstName varchar(50) not null,
	lastName varchar(50) not null,
	stContact varchar(100) not null,
	address varchar(200),
	salary int,
	role varchar(50) not null,
	username varchar(100) unique not null,
	passsword varchar(50) not null
);


create table costumer(
	CstID int identity(1000,1) primary key,
	firstName varchar(50) not null,
	lastName varchar(50) not null,
	CstContact varchar(100),
	loyalityPoints int default 0,
	--CashierID int not null foreign key references staff(staffID)
);

create table orders(
	orderID int identity(200,1) primary key,
	orderPrice int not null,
	orderDate date default GETDATE(),
	orderStatus varchar(50) not null,
	CstID int foreign key references costumer(CstID),
	--orderItem foreign key references orderItem(
	--orderItemID int foreign key references orderItem(ordItemID)
);

create table inventory(
	inventID int identity(10,1),
	inventName varchar(100)  not null,
	inventDescription varchar(255),
	quantity int not null,
	category varchar(100),
	UnitPrice int not null,
	point int,
	PRIMARY KEY (inventID),
	inventMgr int foreign key references staff(staffID)
);

create table orderItem(
	--ordItemID int identity(200,1),
	CstID int foreign key references costumer(CstID),
	orderID int foreign key references orders(orderID),
	primary key(CstID,orderID),
	itemID int not null,
	itemPrice int not null,
	FOREIGN KEY (itemID) REFERENCES inventory(inventID)

);
alter table orderitem add quantity int 
select * from orderItem

create table transactions(
	transID int identity(10001,1) primary key,
	transDate date default GETDATE(),
	paymentMethod varchar(50) not null,
	amount int not null,
	CstID int foreign key references costumer(CstID),
	CashierID int foreign key references staff(staffID),
	orderID int foreign key references orders(orderID),
);


create table menu(
	menuItemID INT IDENTITY(300, 1) PRIMARY KEY,
    inventID INT,
	menuMgr int not null,
	foreign key (menuMgr) references staff(staffID),
    FOREIGN KEY (inventID) REFERENCES inventory(inventID)
);
INSERT INTO menu (inventID, menuMgr)
VALUES
    (10, 101 );
	SELECT inventID FROM menu WHERE menuItemID = 301

create table itemDisplay(
	inventID INT primary key,
	quantity int default 1,
    FOREIGN KEY (inventID) REFERENCES inventory(inventID)
);
select * from transactions
select * from costumer
select * from orders
select * from itemDisplay



CREATE TABLE AuditTrail (
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    TableName VARCHAR(150) NOT NULL,
    ActionType VARCHAR(20) NOT NULL,
    ActionDate DATETIME NOT NULL,
    UserName VARCHAR(100) NOT NULL
);



create trigger AuditTrailTrigger6
on menu
for insert, update, delete
AS
BEGIN
    DECLARE @TableName NVARCHAR(128)
    SET @TableName = OBJECT_NAME(@@PROCID)

    -- Insert audit records
    INSERT INTO AuditTrail (TableName, ActionType, ActionDate, UserName)
    VALUES (@TableName, 
            CASE 
                WHEN EXISTS (SELECT * FROM deleted) AND EXISTS (SELECT * FROM inserted) THEN 'UPDATE'
                WHEN EXISTS (SELECT * FROM deleted) THEN 'DELETE'
                WHEN EXISTS (SELECT * FROM inserted) THEN 'INSERT'
            END,
            GETDATE(),
            SUSER_SNAME())
END;

-- Create the trigger
create trigger SubtractInventoryTrigger
on itemDisplay
after insert
as
begin
    declare @inventID INT, @quantity INT

    -- Get the inserted inventID and quantity
    select @inventID = inventID, @quantity = quantity
    from inserted

    -- Subtract the quantity in the inventory
    update inventory
    set quantity = quantity - @quantity
    where inventID = @inventID
end;
