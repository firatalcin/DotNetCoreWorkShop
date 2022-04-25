--WHERE KOMUTU

select * from Products

-- Product tablosundaki fiyatý 50'den fazla olan ürünleri listele

select * from Products as p where p.UnitPrice > 50

-- Product tablosundaki fiyatý 20'den az olan ürünleri listele

select * from Products as p where p.UnitPrice < 20

-- Product tablosundaki fiyatý 20'den az olan ürünlerin sadece isim ve fiyatlarýný listele

select p.ProductName,p.UnitPrice from Products as p where p.UnitPrice < 20

-- Product tablosundaki fiyatý 30'dan büyük ve 60'dan küçük olan ürünlerin sadece isim ve fiyatlarýný listele

select p.ProductName,p.UnitPrice from Products as p where p.UnitPrice < 60 and p.UnitPrice > 30

-- Soru 1 - Stokta kalmamýþ ürünlerin isim, stok ve fiyat bilgisini listeleyin. ( UnitsInStock kolonu )

select p.ProductName,p.UnitsInStock,p.UnitPrice from Products as p where p.UnitsInStock = 0

--Soru 2 - Fiyatý 20 ile 50 arasýnda ve stokta en az 1 tane kalmýþ ürünleri listeleyin.

select * from Products as p where p.UnitPrice >= 20 and p.UnitPrice <= 50 and p.UnitsInStock >= 1

--Soru 3 - Londrada oturan çalýþanlarý listeleyin. ( Employee tablosu, City kolonu)

select * from Employees as e where e.City = 'London'

--Soru 4 - Satýþ müdürümüzün ismi ne? ( Employee tablosu, Title kolonu)

select e.FirstName from Employees as e where e.Title = 'Sales Manager'

--LIKE KOMUTU

-- Ýsmi c ile baþlayan ürünleri listele

select * from Products as p where p.ProductName like 'c%'

-- ismi içerisinde tiger geçen ürünleri listele

select * from Products as p where p.ProductName like '%tiger%'

-- ismi c ile baþlayan 3. karakteri a olan ürünleri listele

select * from Products as p where p.ProductName like 'c_a%'

-- ismi c ile baþlayan 4. karakteri n veya r olan ürünleri listele

select * from Products as p where p.ProductName like 'c__[nr]%'

--ismi c ile baþlayan 4. karakteri n ile t arasýnda olan envanterleri listele

select * from Products as p where p.ProductName like 'c__[n-t]%'

--ismi c ile baþlayan ama 3. karakteri a olmayan ürünleri listele

select * from Products as p where p.ProductName like 'c_[^a]%' 

-- ORDER BY (ASC - DESC)

select p.ProductName, p.UnitPrice from Products as p order by p.UnitPrice desc

select * from Products as p order by p.UnitPrice asc

select top 3 p.ProductName,p.UnitPrice from Products as p order by p.UnitPrice desc

select top 5 p.ProductName, p.UnitPrice from Products as p order by p.UnitPrice asc

select * from Products as p where p.UnitsInStock = 1 order by p.UnitPrice desc

select * from Products as p where (p.UnitsInStock > 0 and p.UnitsInStock <= 10) order by p.UnitsInStock asc 

/*
AGGREGATE FUNCTÝONS - BÜTÜNLEÞÝK FONKSÝYONLAR
------------------------------------------------
SUM - Bir kolondaki deðerleri toplar
COUNT - Satýrlarý sayar
AVG - Ortalama Alýr
MAX - Kolondaki en büyük deðeri getirir
MIN - Kolondaki en düþük deðeri getirir

*/

select sum(p.UnitPrice) as "Toplam Fiyat" from Products as p

select COUNT(*) as "Toplam Sipariþ Sayýsý" from Orders

select Count(*) as "Toplam Çalýþan Sayýsý" from Employees

select Avg(orde.UnitPrice) as "Ortalama Sipariþ Tutarý" from [Order Details] as orde

select max(p.UnitPrice) as "En pahalý Ürün" from Products as p

select min(emp.BirthDate) as "En Yaþlý Eleman" from Employees as emp

--1- Toplam kaç farklý kategori bulunuyor.

select count(*) as "Categori Sayýsý" from Categories as cate

--2- Her sipariþte ortalama kaç adet ürün satýlmýþtýr. ( Order Detail tablosu | Quantity kolonu )

select AVG(od.Quantity) from [Order Details] as od

--3- Bir üründen en fazla kaç tane stok yapmýþtýr

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

select c.CategoryName, sum(p.UnitPrice) as "Toplam Ücret" from Products as p
join Categories as c on p.CategoryID = c.CategoryID 
group by c.CategoryName 

select c.CategoryName, count(*) as "Toplam Ürün" from Products as p
join Categories as c on p.CategoryID = c.CategoryID where p.UnitsInStock > 0
group by c.CategoryName 

select emp.City,count(*) from Employees as emp
group by emp.City

select top 1 c.ContactName,count(*) as "Sipariþ Sayýsý" from Orders as ord
join Customers as c on ord.CustomerID = c.CustomerID
group by c.ContactName
order by 2 desc

-- INSERT -- 

insert into Categories Values('Test','Açýklama Alaný',null)

insert into Categories (CategoryName,Description) Values ('Test2','Açýklama 2')

-- UPDATE --

update Categories set Description = 'Alan Güncellenmiþtir' where Categories.CategoryName = 'Test'

-- DELETE -- 

delete from Categories where CategoryName = 'Test2'




