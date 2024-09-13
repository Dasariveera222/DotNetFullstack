/* Joins on cart and Products*/
use ShoppingCartDb

/*Write a Query to display the results from the above two tables:
			CartId,  ProductName, Quantity, UnitPrice*/

Select C.CartId,P.ProductName,C.Quantity,P.UnitPrice 
from Cart C
Inner join  Products P
On C.ProductId=P.ProductId

Select C.CartId,P.ProductName,C.Quantity,P.UnitPrice 
from Cart C
Left join  Products P
On C.ProductId=P.ProductId

Select C.CartId,P.ProductName,C.Quantity,P.UnitPrice 
from Cart C
Right join  Products P
On C.ProductId=P.ProductId

Select C.CartId,P.ProductName,C.Quantity,P.UnitPrice 
from Cart C
Full join  Products P
On C.ProductId=P.ProductId

/*creation of Student table*/
Create a table Called "Student"  table with the following columns:
							StudentId,  StudentName,  CourseName,  CityName, 

CREATE TABLE Student (
	StudentId INT PRIMARY KEY,
	StudentName VARCHAR(30) Not NUll ,
	CourseName VARCHAR(30) ,
	CityName VARCHAR(30) )

INSERT INTO Student VALUES (1,'Mani','Java','Nuzvid')
INSERT INTO Student VALUES (2,'veera','Python','Giddalur')
INSERT INTO Student VALUES (3,'Kalyan','DBMS','Vijayawada')
INSERT INTO Student VALUES (4,'Hari','Javascript','Vijayawada')
INSERT INTO Student VALUES (5,'Varun','Angular','hyderabad')
INSERT INTO Student VALUES (6,'Akash','C','hyderabad')
INSERT INTO Student VALUES (7,'Kowshik','C++','hyderabad')
INSERT INTO Student VALUES (8,'Dinesh','Sql','Vijayawada')
INSERT INTO Student VALUES (9,'Abbu','Devops','Giddalur')
INSERT INTO Student VALUES (10,'Prem','Angular','Chennai')



select * from Student
/*Find out how many Students are joined for "Angular"  Course*/

select Count(*) from Student where CourseName = 'Angular'

/*	b.   Find out how many Students are joined from  "Hyderabad"  City*/
select Count(*) from Student where CityName = 'Hyderabad'

/*	c.    Display No. of Students are join from each  City based */

select CityName,Count(*) as No_of_students from Student group by CityName order by No_of_students;

/*	d.    Display No. of Students are join from each  Course  based */
select CourseName,Count(*) as No_of_students from Student group by CourseName order by No_of_students;

/*	e.     Display the counts  by grouping based on  city, course */
select CityName,CourseName,Count(*) as No_of_students from Student group by CityName,CourseName

/*			a.   Display the products if any items exists in the cart table*/
select * from Products where  exists  (select ProductId from Cart where Cart.ProductId=Products.ProductId)

/*			b.   Display the cart items whoe product price greater than 5000 */
select * from Products where ProductId in (select ProductId from cart) and UnitPrice>5000;

