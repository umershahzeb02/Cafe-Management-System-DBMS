# 📋 Functional Requirements of Each Module

## 1. Staff Management System 🧑‍💼
- **Add New Staff Member**: The admin can add a new staff member by providing details such as first name, last name, contact information, address, salary, role (cashier, manager, inventory manager), username, and password.
- **Update Staff Information**: Admin can modify staff details like name, contact, address, and salary.
- **Remove a Staff Member**: The system allows deactivating or removing staff members while keeping historical data.
- **View All Staff Members**: A list of all staff, including roles, contact information, and performance history, is displayed.

## 2. Customer Management Module 👥
- **Add New Customer**: Staff can register new customers by entering their details and loyalty points.
- **Update Customer Information**: Modify existing customer details like name, contact information, and loyalty points.
- **View All Customers**: Display a list of all registered customers along with their loyalty points.

## 3. Inventory Management Module 📦
- **Add New Item to Inventory**: Add new items to the inventory with details like name, description, quantity, price, category, and unit price.
- **Update Item Information**: Modify item details such as quantity, price, and attributes.
- **Remove Item from Inventory**: The system allows removing an item.
- **View All Items**: Display a full list of inventory items, including quantity and price.

## 4. Order Management System 🛒
- **Place New Order**: Staff can create orders by selecting items from the menu and specifying quantities.
- **View All Orders**: Display all orders with details like order ID, items, quantities, and total price.

## 5. Menu Management Module 🍽️
- **Create New Menu Item**: Add new items to the menu by specifying details like name, category, description, and price.
- **Update Menu Item Information**: Modify existing menu items.
- **Remove a Menu Item**: The system allows staff to remove items from the menu.
- **View All Menu Items**: A comprehensive list of all menu items is displayed.

## 6. Transaction Management Module 💵
- **Record New Transaction**: Staff can record transaction details such as payment method, amount, customer ID, and staff ID.
- **View Transaction History**: Display all past transactions, including details like transaction ID, date, payment method, and amount.
- **Generate Sales Reports**: The system can generate reports on sales (daily, weekly, or monthly).

## 7. Security Module 🔐
- **User Authentication & Authorization**: Ensure secure access for authorized users.
- **Role-Based Access Control**: Assign roles (cashier, manager, inventory manager) with specific access permissions.

---
## 📊 Entity Relationship Diagram (ERD) & Enhanced Entity Relationship Diagram (EERD)

<div style="display: flex; justify-content: space-between;">
  <img src="https://github.com/user-attachments/assets/993d796e-d441-44f3-ad68-e164f3dc5099" alt="ERD" width="45%" />
  <img src="https://github.com/user-attachments/assets/2b4b4440-096d-4cc4-bf15-436b603db7be" alt="EERD" width="45%" />
</div>

## 📸 Screenshots

<div style="display: flex; justify-content: space-between;">
  <img src="https://github.com/user-attachments/assets/c64baa80-da92-46f2-b272-3d3543c158d5" alt="Screenshot 1" width="45%" />
  <img src="https://github.com/user-attachments/assets/c1ef5d4f-4a98-4728-a3ac-c669379ef2cc" alt="Screenshot 2" width="45%" />
</div>

## 🗄️ Relational Schema
```sql
CREATE TABLE Staff (
    StaffID INT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    StContact VARCHAR(100) NOT NULL,
    Address VARCHAR(200),
    Salary INT,
    Role VARCHAR(50) NOT NULL,
    Username VARCHAR(100) UNIQUE NOT NULL,
    Password VARCHAR(50) NOT NULL
);

CREATE TABLE Customer (
    CstID INT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    CstContact VARCHAR(100),
    LoyaltyPoints INT DEFAULT 0
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    OrderPrice INT NOT NULL,
    OrderDate DATE DEFAULT GETDATE(),
    OrderStatus VARCHAR(50) NOT NULL,
    CstID INT,
    FOREIGN KEY (CstID) REFERENCES Customer(CstID)
);

CREATE TABLE Inventory (
    InventID INT PRIMARY KEY,
    InventName VARCHAR(100) NOT NULL,
    InventDescription VARCHAR(255),
    Quantity INT NOT NULL,
    Category VARCHAR(100),
    UnitPrice INT NOT NULL,
    Point INT,
    InventMgr INT,
    FOREIGN KEY (InventMgr) REFERENCES Staff(StaffID)
);

CREATE TABLE OrderItem (
    CstID INT,
    OrderID INT,
    ItemID INT NOT NULL,
    Quantity INT,
    ItemPrice INT NOT NULL,
    PRIMARY KEY (CstID, OrderID),
    FOREIGN KEY (CstID) REFERENCES Customer(CstID),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ItemID) REFERENCES Inventory(InventID)
);

CREATE TABLE Transactions (
    TransID INT PRIMARY KEY,
    TransDate DATE DEFAULT GETDATE(),
    PaymentMethod VARCHAR(50) NOT NULL,
    Amount INT NOT NULL,
    CstID INT,
    CashierID INT,
    OrderID INT,
    FOREIGN KEY (CstID) REFERENCES Customer(CstID),
    FOREIGN KEY (CashierID) REFERENCES Staff(StaffID),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);

CREATE TABLE Menu (
    MenuItemID INT PRIMARY KEY,
    InventID INT,
    MenuMgr INT NOT NULL,
    FOREIGN KEY (MenuMgr) REFERENCES Staff(StaffID),
    FOREIGN KEY (InventID) REFERENCES Inventory(InventID)
);
```
## 📜 Audit Trail
We implemented an Audit Trail by using triggers on every table to record any insertion into a dedicated Audit Trail table.
