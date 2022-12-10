# MathArea

# Задание 1:
Библиотека которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам, а также проверяет является ли треугольник равнобедренным.

# Задание 2:
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
SQL запрос:

Создание таблиц  
Таблица категорий  
```
  CREATE TABLE Category (  
  	ID	int,  
    Name	varchar(100),  
  	PRIMARY KEY(ID)  
  );  
```
Таблица продуктов  
```
  CREATE TABLE Product (  
  	ID	int,  
    Name	varchar(100),  
  	PRIMARY KEY(ID)  
  );  
```
Пересечение  
```
  CREATE TABLE ProductCategory (  
  	ID	int,  
  	ProductID	int,  
  	CategoryID	int,  
  	PRIMARY KEY(ID),  
  	FOREIGN KEY(ProductID) REFERENCES Product,  
  	FOREIGN KEY(CategoryID) REFERENCES Category(ID)  
  );  
```  
Заполннение таблиц  
```
  INSERT INTO Category(ID,name) VALUES (1, 'Home');  
  INSERT INTO Category(ID,name) VALUES (2, 'Child');  
  INSERT INTO Category(ID,name) VALUES (3, 'Grocery');  
  INSERT INTO Product(ID,name) VALUES (1, 'Milk');  
  INSERT INTO Product(ID,name) VALUES (2, 'Pasta');  
  INSERT INTO Product(ID,name) VALUES (3, 'Agusha');  
  INSERT INTO ProductCategory(ID,ProductID, CategoryID) VALUES (1, 2, 3);  
  INSERT INTO ProductCategory(ID,ProductID, CategoryID) VALUES (2, 3, 2);  
```
Запрос для извлечение всех пересечений  
```
  SELECT
     p.ID AS ProductID
     ,CategoryID
  FROM
     Product p 
     LEFT JOIN ProductCategory pc ON ProductID = p.ID
  UNION	  
  SELECT  
     ProductID  
     ,c.ID AS CategoryID  
  FROM   
     Category c  
     LEFT JOIN ProductCategory pc On CategoryID = c.ID  
  GO  
```
