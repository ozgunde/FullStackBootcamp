# OzgunDemirel-React
 
Props ve State Kavramlar�

Props ve State kavram�n� anlat�rken kullanaca��m�z componentler, uygulamay� tekrar kullan�labilir par�alara ay�rman�za ve her bir par�ay� ayr� ayr� kullanabilmenize izin verir.

Bir�ok kaynakta componentler kavramsal olarak, JavaScript fonksiyonlar�na benzedi�i belirtilmektedir.

Bunlar rasgele girdileri kabul eder ve ekranda neler g�r�nece�ini a��klayan React elementleri return ederler.

Props Kavram�

Props, yukar�da da belirtilen rastgele girdilerin ya da olu�turdu�umuz React component�lerin �zelliklerine ait datay� tutan nesnedir. 

Props de�erleri d�� componetden external olarak gelir ve ilgili component i�ersinde readonly dir. 

Birbirinden farkl� componentler aras�ndaki veri ileti�imini props ile sa�lar�z. 

State Kavram�

Componentlerin durumunu belirlerler. Component i�ersindeki internal durumlar� tutan kavramlar�d�r.

State yaln�zca classlar i�in kullan�labilen ve de�i�me durumu olabilen bir �zelliktir.

Props vs State 

State�ler bulundu�u component i�ersinde kullan�lan de�erlerdir ve de�i�tirilebilir, fakat props�lar farkl� componentlerden de�er al�r ve kullan�lan component i�ersinde de�i�irilmeyen ifadelerdir.

�rnek bir senaryo d���nelim. �ngilizce ��renmek i�in kelime kartlar�m�z�n oldu�u bir sayfa d���nelim. Her kelime, bir kart i�inde g�sterilsin. Kart�n �zerinde yazan kelimenin anlam� tahmin edilsin. Do�ru tahmin edilirse karta t�klans�n ve kart�n rengi ye�ile d�ns�n ve ezberlendi olarak i�aretlensin.

Bu kartlar tasar�m olarak birbirinin ayn�s� olacak (Component), sadece kelimenin ad�, kelimenin c�mle kullan�m� gibi belirli �zellikleri (Props) kendilerine ait olacak. Kartlar�n �zerine t�klan�ld���nda da kelimenin ezberlendi/ezberlenmedi durumu(State) de�i�ecek.

�rnek senaryodan da anla��ld��� gibi Props, olu�turdu�umuz component�lerin �zelliklerini tutarken, State ise sayfan�n ya da bir componentin durumunu tutuyor.

�zet olarak, propslar� asla de�i�tirmeye kalkm�yoruz. Propslar sadece okunabilir.Propslar state�lerden de�eri �eker, de�eri de�i�tirmek istedi�imizde state�i de�i�tiririz. Bu sayede Props da de�i�mi� olacak.