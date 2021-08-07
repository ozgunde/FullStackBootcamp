# OzgunDemirel-React
 
Props ve State Kavramlarý

Props ve State kavramýný anlatýrken kullanacaðýmýz componentler, uygulamayý tekrar kullanýlabilir parçalara ayýrmanýza ve her bir parçayý ayrý ayrý kullanabilmenize izin verir.

Birçok kaynakta componentler kavramsal olarak, JavaScript fonksiyonlarýna benzediði belirtilmektedir.

Bunlar rasgele girdileri kabul eder ve ekranda neler görüneceðini açýklayan React elementleri return ederler.

Props Kavramý

Props, yukarýda da belirtilen rastgele girdilerin ya da oluþturduðumuz React component’lerin özelliklerine ait datayý tutan nesnedir. 

Props deðerleri dýþ componetden external olarak gelir ve ilgili component içersinde readonly dir. 

Birbirinden farklý componentler arasýndaki veri iletiþimini props ile saðlarýz. 

State Kavramý

Componentlerin durumunu belirlerler. Component içersindeki internal durumlarý tutan kavramlarýdýr.

State yalnýzca classlar için kullanýlabilen ve deðiþme durumu olabilen bir özelliktir.

Props vs State 

State’ler bulunduðu component içersinde kullanýlan deðerlerdir ve deðiþtirilebilir, fakat props’lar farklý componentlerden deðer alýr ve kullanýlan component içersinde deðiþirilmeyen ifadelerdir.

Örnek bir senaryo düþünelim. Ýngilizce öðrenmek için kelime kartlarýmýzýn olduðu bir sayfa düþünelim. Her kelime, bir kart içinde gösterilsin. Kartýn üzerinde yazan kelimenin anlamý tahmin edilsin. Doðru tahmin edilirse karta týklansýn ve kartýn rengi yeþile dönsün ve ezberlendi olarak iþaretlensin.

Bu kartlar tasarým olarak birbirinin aynýsý olacak (Component), sadece kelimenin adý, kelimenin cümle kullanýmý gibi belirli özellikleri (Props) kendilerine ait olacak. Kartlarýn üzerine týklanýldýðýnda da kelimenin ezberlendi/ezberlenmedi durumu(State) deðiþecek.

Örnek senaryodan da anlaþýldýðý gibi Props, oluþturduðumuz component’lerin özelliklerini tutarken, State ise sayfanýn ya da bir componentin durumunu tutuyor.

Özet olarak, propslarý asla deðiþtirmeye kalkmýyoruz. Propslar sadece okunabilir.Propslar state’lerden deðeri çeker, deðeri deðiþtirmek istediðimizde state’i deðiþtiririz. Bu sayede Props da deðiþmiþ olacak.