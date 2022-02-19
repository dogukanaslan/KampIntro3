----Select

--Select CompanyName Adi,ContactName Sirketadi,Phone Numara from Customers

--Select * from Customers where City = 'London'

----case insensitive

select * from Products where CategoryID = 1 or CategoryID = 3

select * from Products where CategoryID = 1 and UnitPrice<=10

select * from Products order by CategoryID,ProductName

select * from Products where CategoryID = 1 order by UnitPrice desc

select count(*) Adet from Products where CategoryID = 8

select categoryID,count(*) from Products group by CategoryID

select categoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10 

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID = Categories.CategoryID where Products.UnitPrice>10

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null
--Buradaki sonuç 832 tane müşteriden 2 tanesi hiç sipariş vermemiş.

--1 tabloda sadece 1 tane primary key olabilir.

--* buradaki yıldız kolon demek.Tüm kolonlar

--Select -- from -- => Bu kod bir tablodur.

--Where koşuldur. Filtremede kullanılır.

--<> ... dan farklı olanlar
-->= ... dan büyük eşit olanlar
--or iki şarttan herhangi birisinin geçerli olması yeterli
--and iki şartın da ikisi de geçerli olmak zorunda

--order by sırala demek.Sıralamayı asc şeklinde yapar. (asc = ascending yani artan demek) Bir de desc(descending = azalan) var 

--CategoryID,ProductName şeklinde order yaparsak önce CategoryID yi sıralar sonra CategoryID içindeki ProductName leri sıralar.

--count(*) kaç tane satır var onu gösterir.Products ı conut yaparsan ürün sayısını gösterir. Bunu istersen where ile entegre edebilirsin.

--select * from Prdoucts group by CategoryID dediğimizde bu çalışmaz. Oradaki kolon yani * sadece ve sadece group by daki categoryID olur.

--on durumunda demek.

--inner join iki tabloda da eşleşenleri getirir, eşleşmeyenleri getirmez.

--left join solda olup sağda olmayanları da getir demek

--bir koda birden fazla inner join ekleyebilirsin.