CREATE DATABASE ShoppingCartDb;

USE ShoppingCartDb;

/*Creation of tables */

CREATE TABLE Users (
	UserId INT IDENTITY ,
	UserName VARCHAR(30),
	Passwords VARCHAR(30),
	ContactNumber INT,
	City VARCHAR(30),

)

/*Insertion into table Users */
 alter table users alter column ContactNumber BIGINT
INSERT INTO USERS VALUES ('veera','veera@123',9387478312,'hyderabad')
INSERT INTO USERS VALUES ('Kalyan','vKalyan@123',9381248312,'Krishna')
INSERT INTO USERS VALUES ('Hari','Hari@123',9384578312,'Krishna')
INSERT INTO USERS VALUES ('Mani','Mani@123',9345478312,'Nuzvid')
INSERT INTO USERS VALUES ('Varun','Varun@123',9345478332,'Hyderabad')



/*Creation of product table */

CREATE TABLE Products (
	ProductId INT ,
	ProductName VARCHAR(30) NOT NULL,
	QuantityInStock INT NOT NULL,
	UnitPrice INT NOT NULL,
	Category VARCHAR(30) NOT NULL,

	CONSTRAINT PK_Products_PID PRIMARY KEY(ProductId),
	CONSTRAINT Check_Products_Stock Check(QuantityInStock>0),
	CONSTRAINT check_Products_Price Check(UnitPrice>0)
)
 
 /*Insertion into table Products */

 INSERT INTO Products VALUES (1,'Mouse',5,100,'Electronics')
 INSERT INTO Products VALUES (2,'CPU',3,100000,'Electronics')
 INSERT INTO Products VALUES (3,'Bottle',5,100,'Plastic')
 INSERT INTO Products VALUES (4,'Bench',10,10000,'Furniture')
 INSERT INTO Products VALUES (5,'chair',6,2000,'Furniture')

 /*Creation of Cart table */
 
 CREATE TABLE Cart (
	Id INT ,
	CartId INT NOT NULL,
	ProductId INT ,
	Quantity INT NOT NULL,
	
	CONSTRAINT PK_Cart_ID PRIMARY KEY(Id),
	CONSTRAINT Check_Cart_Quantity Check(Quantity>0),
	CONSTRAINT fK_Cart_ProductID FOREIGN KEY(ProductId) REFERENCES Products(ProductId)
	ON DELETE CASCADE
	ON UPDATE CASCADE
)

 /*Insertion into table Cart */
 INSERT INTO Cart VALUES (1,1,1,5)
 INSERT INTO Cart VALUES (2,1,2,10)
 INSERT INTO Cart VALUES (3,2,3,100)
 INSERT INTO Cart VALUES (4,2,3,3)
 INSERT INTO Cart VALUES (5,3,4,8)

 SELECT * FROM Products;
 /*Display Products belongs to particular category*/
 SELECT * FROM Products WHERE Category = 'Furniture'

  /*Display the products which price between 1000 to 10000*/
  SELECT * FROM Products WHERE UnitPrice BETWEEN 1000 AND 10000

  /* ORDER BY {Display the product details based on the ProductId}*/
  SELECT * FROM Products ORDER BY ProductId

  /*Display data based on the given CartId */
    SELECT * FROM Cart ORDER BY CartId
 
  /*Check is there any products added in Cart based on the ProductId*/
      SELECT * FROM Products WHERE ProductId IN (SELECT ProductId from Cart)

/*Display All users */
SELECT * FROM Users;

/* Display user details based on ContactNumber */
SELECT * FROM Users ORDER BY ContactNumber
/* Display user details based on UserId */
SELECT * FROM Users ORDER BY UserId


   
			
			


