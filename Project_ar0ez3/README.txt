Az adatbázisom egy drogéria háztatrtási mosó és tisztitószer eladásait tartalmazzák historikusan, 
2014-2019 között éves bontásban.
5 táblát készítettem:
1. Category: a temékkategóriákat tartalmazza (ID, Category_name)
2. Producer: a termékgyártókat tartlamazza (ID, Product_name)
3. Brand: a márkákat tartalmazza (ID, Brand_name)
4. Product: a termékeket gyűjti (ID, CategoryFK, ProducerFK, BrandFK, EAN, Poduct_description)
5. Sale: ID, ProductFK, Sales_2014, Sales_2014, Sales_2015, Sales_2016, ales_2017, Sales_2018, Sales_2019)

A kiinduló formon két gomb találhtó (ha újból rájuk katinttunk bezárja mait felhoz)
1. Product Assortment: megjelenít egy dataGridView-t, ami behívja a product tábla EAN és Poduct_description oszlopait.
2. Data Analysis: három gombot nyit meg:
	1. Brand
	2. Category
	3. Producer
 A három gomb mindegyike egy-egy formot generál, melyek azonos felépítésűek. 
	Elemiek:
		1. ComboBox
		2. DataGridView (nem visible)
		3. Chart
		4. Labelek (7 állandó, 6 kódból generált)

Funkció: a ComboBoxban kiválasztott 
		Brand Formon esetén,  márka
		Category Formon esetén,  termék kategória
		Producer Formon esetén, gyártó
	-hoz tartozó összes product ID-t behúztam egy not visible DataGridViewba linq lekérdezés segítségével.
	A DGW oszlopai így szummázhatóak a CalculateLabel osztály példányosított elemibe.
	Ez azért kell mert a charton való ábrázoláshoz a példányosított labelek határozzák meg az Y koordinátákat, míg az évszámok az X-ek lesznek.

