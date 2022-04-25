--WHERE KOMUTU

select * from Products

-- Product tablosundaki fiyat� 50'den fazla olan �r�nleri listele

select * from Products as p where p.UnitPrice > 50

-- Product tablosundaki fiyat� 20'den az olan �r�nleri listele

select * from Products as p where p.UnitPrice < 20

-- Product tablosundaki fiyat� 20'den az olan �r�nlerin sadece isim ve fiyatlar�n� listele

select p.ProductName,p.UnitPrice from Products as p where p.UnitPrice < 20

-- Product tablosundaki fiyat� 30'dan b�y�k ve 60'dan k���k olan �r�nlerin sadece isim ve fiyatlar�n� listele

select p.ProductName,p.UnitPrice from Products as p where p.UnitPrice < 60 and p.UnitPrice > 30

-- Soru 1 - Stokta kalmam�� �r�nlerin isim, stok ve fiyat bilgisini listeleyin. ( UnitsInStock kolonu )

select p.ProductName,p.UnitsInStock,p.UnitPrice from Products as p where p.UnitsInStock = 0

--Soru 2 - Fiyat� 20 ile 50 aras�nda ve stokta en az 1 tane kalm�� �r�nleri listeleyin.

select * from Products as p where p.UnitPrice >= 20 and p.UnitPrice <= 50 and p.UnitsInStock >= 1

--Soru 3 - Londrada oturan �al��anlar� listeleyin. ( Employee tablosu, City kolonu)

select * from Employees as e where e.City = 'London'

--Soru 4 - Sat�� m�d�r�m�z�n ismi ne? ( Employee tablosu, Title kolonu)

select e.FirstName from Employees as e where e.Title = 'Sales Manager'

--LIKE KOMUTU

-- �smi c ile ba�layan �r�nleri listele

select * from Products as p where p.ProductName like 'c%'

-- ismi i�erisinde tiger ge�en �r�nleri listele

select * from Products as p where p.ProductName like '%tiger%'

-- ismi c ile ba�layan 3. karakteri a olan �r�nleri listele

select * from Products as p where p.ProductName like 'c_a%'

-- ismi c ile ba�layan 4. karakteri n veya r olan �r�nleri listele

select * from Products as p where p.ProductName like 'c__[nr]%'

--ismi c ile ba�layan 4. karakteri n ile t aras�nda olan envanterleri listele

select * from Products as p where p.ProductName like 'c__[n-t]%'

--ismi c ile ba�layan ama 3. karakteri a olmayan �r�nleri listele

select * from Products as p where p.ProductName like 'c_[^a]%' 

-- ORDER BY (ASC - DESC)

select p.ProductName, p.UnitPrice from Products as p order by p.UnitPrice desc

select * from Products as p order by p.UnitPrice asc

select top 3 p.ProductName,p.UnitPrice from Products as p order by p.UnitPrice desc

select top 5 p.ProductName, p.UnitPrice from Products as p order by p.UnitPrice asc

select * from Products as p where p.UnitsInStock = 1 order by p.UnitPrice desc

select * from Products as p where (p.UnitsInStock > 0 and p.UnitsInStock <= 10) order by p.UnitsInStock asc 

/*
AGGREGATE FUNCT�ONS - B�T�NLE��K FONKS�YONLAR
------------------------------------------------
SUM - Bir kolondaki de�erleri toplar
COUNT - Sat�rlar� sayar
AVG - Ortalama Al�r
MAX - Kolondaki en b�y�k de�eri getirir
MIN - Kolondaki en d���k de�eri getirir

*/

select sum(p.UnitPrice) as "Toplam Fiyat" from Products as p

select COUNT(*) as "Toplam Sipari� Say�s�" from Orders

select Count(*) as "Toplam �al��an Say�s�" from Employees

select Avg(orde.UnitPrice) as "Ortalama Sipari� Tutar�" from [Order Details] as orde

select max(p.UnitPrice) as "En pahal� �r�n" from Products as p

select min(emp.BirthDate) as "En Ya�l� Eleman" from Employees as emp

--1- Toplam ka� farkl� kategori bulunuyor.

select count(*) as "Categori Say�s�" from Categories as cate

--2- Her sipari�te ortalama ka� adet �r�n sat�lm��t�r. ( Order Detail tablosu | Quantity kolonu )

select AVG(od.Quantity) from [Order Details] as od

--3- Bir �r�nden en fazla ka� tane stok yapm��t�r

select max(p.UnitsInStock) from Products as p

-- JOIN --

select p.ProductName,c.CategoryName from Products as p join Categories as c on p.CategoryID = c.CategoryID

select p.ProductName, s.CompanyName from  Products as p join Suppliers as s on p.SupplierID = s.SupplierID

select p.ProductName,c.CategoryName,s.CompanyName from Products as p
join Categories as c on p.CategoryID = c.CategoryID
join Suppliers as s on p.SupplierID = s.SupplierID

select p.ProductName,c.CompanyName from Products as p
join [Order Details] as orde on p.ProductID = orde.ProductID
join Orders as ord on orde.OrderID = ord.OrderID
join Customers as c on ord.CustomerID = c.CustomerID

select p.ProductName,s.Region from Products as p 
left join Suppliers as s on p.CategoryID = s.SupplierID

select p.ProductName,s.Region from Products as p 
right join Suppliers as s on p.CategoryID = s.SupplierID

-- GROUP BY --

select c.CategoryName, sum(p.UnitPrice) as "Toplam �cret" from Products as p
join Categories as c on p.CategoryID = c.CategoryID 
group by c.CategoryName 

select c.CategoryName, count(*) as "Toplam �r�n" from Products as p
join Categories as c on p.CategoryID = c.CategoryID where p.UnitsInStock > 0
group by c.CategoryName 

select emp.City,count(*) from Employees as emp
group by emp.City

select top 1 c.ContactName,count(*) as "Sipari� Say�s�" from Orders as ord
join Customers as c on ord.CustomerID = c.CustomerID
group by c.ContactName
order by 2 desc

-- INSERT -- 

insert into Categories Values('Test','A��klama Alan�',null)

insert into Categories (CategoryName,Description) Values ('Test2','A��klama 2')

-- UPDATE --

update Categories set Description = 'Alan G�ncellenmi�tir' where Categories.CategoryName = 'Test'

-- DELETE -- 

delete from Categories where CategoryName = 'Test2'




