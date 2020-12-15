Az adatbázisom egy drogéria háztatrtási mosó és tisztitószer eladásait tartalmazzák historikusan, 
2014-2019 között éves bontásban.
5 táblát készítettem:
1. Category: a temékkategóriákat tartalmazza (ID, Category_name)
2. Producer: a termékgyártókat tartlamazza (ID, Product_name)
3. Brand: a márkákat tartalmazza (ID, Brand_name)
4. Product: a termékeket gyűjti (ID, CategoryFK, ProducerFK, BrandFK, EAN, Poduct_description)
5. Sale: ID, ProductFK, Sales_2014, Sales_2014, Sales_2015, Sales_2016, ales_2017, Sales_2018, Sales_2019)

