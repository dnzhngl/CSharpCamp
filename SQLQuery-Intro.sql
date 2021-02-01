--ANSII Strandardı Sorgular
--SQL case insensitive'dir.

--Select 
-- * tüm kolonları getirir
select * from products
-- belirttiğin kolonları getirir.
select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

--Where  --> Filtreleme Sorgusu
select * from Customers where City = 'Berlin'
select * from Products where CategoryID = 1
--or --> yada
select * from Products where CategoryID = 1 or CategoryID = 3
--and --> ve
select * from Products where CategoryID = 1 and UnitPrice < 10
-- <> ' belirtilen değerden farklı olan
select * from Products where UnitPrice <> 10

--order by --> sırala
select * from Products order by ProductName
-- order by birden fazla değer verme --> önce CategoryID'ye göre, onlarıda kendi içerisinde ürünün adına göre sırala
select * from Products order by CategoryIdD, ProductName
-- asc --> ascending (artan)
select * from Products order by UnitPrice asc 
-- desc --> descending (azalan /düşen)
select * from Products order by UnitPrice desc 

select * from Products where CategoryID = 1 order by UnitPrice desc 

-- count(*) --> toplam satır sayısı 
select count(*) from Products
-- CategoryId'si 2 olan ürünlerin sayısı
select count(*) Adet from Products where CategoryID = 2

--group by --> grupla :  select ettiğin kolon(lar) sadece group by da kullandığın kolon(lar) olabilir veya/ve cumulative sorgular (count,sum,avg) olur.
select CategoryID, count(*) Adet from Products group by CategoryID
-- having --> group by da kullanılan cumulative sorguya atanan koşuldur
select CategoryID, count(*) Adet from Products group by CategoryID having count(*) < 10 -- categoriId'sine göre ürünleri grupla bunlar içerisidne ürün sayısı 10'dan az olanları göster.

-- Products tablosunda UnitPrice'i 20'den fazla olanları seç. Bunları CategoryId'ye göre sırala. Bunların içerisinde adet'i(count(*))'ı 10'dan az olanları listele.
select CategoryID, count(*) Adet from Products where UnitPrice > 20 
group by CategoryID having count(*) < 10

--Joins
-- inner join :  iki tabloda da eşleşen kayıtları getirir. 
-- Product tablosunu Category tablosuyu joinledik.
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
--DTO : Data Transformation Object

-- birden fazla taloyu bağlama
select * from Products p 
inner join [Order Details] od on p.ProductID = od.ProductID
inner join Orders o on o.OrderID = od.OrderID


select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10

-- left join : yazıma göre soldaki tabloda olup, sağdaki tabloda olmayanları da getir.
select * from Products p left join [Order Details] od on p.ProductID = od.ProductID

-- Hem inner join olanları (eşleşenleri), hemde Orders'da olmasada Customers tablosunda olanları(eşleşmeyenleri) getirir.
select * from Customers c left join Orders o on c.CustomerID = o.CustomerID
-- Üye olmuş ama ürün almamış.
select * from Customers c left join Orders o on c.CustomerID = o.CustomerID
where o.OrderID is null

-- Her bir üründen toplamda ne kadar para kazandığımızı bulunuz.
select p.ProductName, Sum((od.UnitPrice * od.Quantity) * (1 - od.Discount)) from Products p 
inner join [Order Details] od on p.ProductID = od.ProductID
group by ProductName
order by ProductName


select p.ProductName, Sum(((od.UnitPrice - p.UnitPrice) * od.Quantity) * (1 - od.Discount)) from Products p 
inner join [Order Details] od on p.ProductID = od.ProductID
group by ProductName
order by ProductName