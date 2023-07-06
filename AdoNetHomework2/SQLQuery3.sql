USE SKLADPRODUCTOV





INSERT INTO NAME(Name) VALUES (N'Milk')
insert into TYPE(Type) VALUES (N'Dairy',1)
insert into PRDODUCTQUALITY(Quantity,ID) VALUES (5,1)
insert into COSTPRICE(PRICE,ID) values (2,1)
insert into  DATADELIVERY(DATA,ID) VALUES (30-01-2023,1)
insert into SUPPLIER( SupplierName,id) VALUES (N'Hochland',1)

SELECT * FROM Name
union
select * from SUPPLIER



INSERT INTO NAME(Name) VALUES (N'Kefir');
insert into TYPE(Type) VALUES (N'Dairy');
insert into PRDODUCTQUALITY(Quantity) VALUES (10);
insert into COSTPRICE(PRICE) values (3);
insert into  DATADELIVERY(DATA) VALUES (27-01-2023)
insert into SUPPLIER( SupplierName) VALUES ('Hochland')


INSERT INTO NAME(Name) VALUES (N'Sausage');
insert into TYPE(Type) VALUES (N'Meat Product');
insert into PRDODUCTQUALITY(Quantity) VALUES (7);
insert into COSTPRICE(PRICE) values (11);
insert into  DATADELIVERY(DATA) VALUES (20-01-2023)
insert into SUPPLIER( SupplierName) VALUES ('Sevimli Dad')




INSERT INTO NAME(Name) VALUES (N'Meat');
insert into TYPE(Type) VALUES (N'Meat Product');
insert into PRDODUCTQUALITY(Quantity) VALUES (15);
insert into COSTPRICE(PRICE) values (13);
insert into  DATADELIVERY(DATA) VALUES (30-01-2023)
insert into SUPPLIER( SupplierName) VALUES ('Qoç ət')



INSERT INTO NAME(Name) VALUES (N'Cheese');
insert into TYPE(Type) VALUES (N'Dairy');
insert into PRDODUCTQUALITY(Quantity) VALUES (8);
insert into COSTPRICE(PRICE) values (9);
insert into  DATADELIVERY(DATA) VALUES (27-01-2023)
insert into SUPPLIER( SupplierName) VALUES ('Hochland')



INSERT INTO NAME(Name) VALUES (N'Croissant');
insert into TYPE(Type) VALUES (N'Bakery Product');
insert into PRDODUCTQUALITY(Quantity) VALUES (5);
insert into COSTPRICE(PRICE) values (0.70);
insert into  DATADELIVERY(DATA) VALUES (30-01-2023)
insert into SUPPLIER( SupplierName) VALUES ('Binə Zvod')


INSERT INTO NAME(Name) VALUES (N'Bread');
insert into TYPE(Type) VALUES (N'Bakery Product');
insert into PRDODUCTQUALITY(Quantity) VALUES (40);
insert into COSTPRICE(PRICE) values (0.50);
insert into  DATADELIVERY(DATA) VALUES (31-01-2023)
insert into SUPPLIER( SupplierName) VALUES ('Binə Zvod')



INSERT INTO NAME(Name) VALUES (N'Cigarettes');
insert into TYPE(Type) VALUES (N'Tobacco Product');
insert into PRDODUCTQUALITY(Quantity) VALUES (20);
insert into COSTPRICE(PRICE) values (3.20);
insert into  DATADELIVERY(DATA) VALUES (30-01-2023)
insert into SUPPLIER( SupplierName) VALUES ('Sobraniye')



INSERT INTO NAME(Name) VALUES (N'Pasta');
insert into TYPE(Type) VALUES (N'Bakery Product');
insert into PRDODUCTQUALITY(Quantity) VALUES (10);
insert into COSTPRICE(PRICE) values (2);
insert into  DATADELIVERY(DATA) VALUES (30-01-2023)
insert into SUPPLIER( SupplierName) VALUES ('Tatlı')
