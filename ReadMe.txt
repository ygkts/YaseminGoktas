	Kullanýlan Teknolojiler
	
	- Visual Studio Enterprise 2015
	- Microsoft SQL Server 2014
	- Ado.net
	- c#
	----------------------------
	Programýn Çalýþtýrýlma Aþamalarý

	- FORM1 : Kullacýný programý ilk kez çalýþtýrdýðýnda AYVANSARAY TURÝZM ekranýyla (ilk form) karþýlaþýr. Burada programýn amacýna yönetlik iþlemlerin yapýlmasý için butonlar kullanýlmýþtýr. Bu butonlara týklandýðýnda butonun iþlevine dair yazýlýmcýlar tarafýndan belirlene form ekraný karþýmýza çýkmaktadýr. 

	- BÝLET KES formu : Bu formda, kullanýcý kalkýþ yeri, varýþ yeri ve kullanýlacak otobüsü sýrasýyla seçebilmesi saðlanmýþtýr. En son Otobüs seçildiðinde o otobüse ait boþ koltuklar ekranda belirecektir.  Otobüs her seçildiðinde koltuklar o plakaya göre güncel olarak gelmektedir ve her seferinde o plakaya ait resim ekranýn sað üstünde pictureboxlar ile gösterilmektedir. Kýrmýzý renkteki koltuklara bilet kesilemez. Diðer renkten bir koltuk seçilince kullanýcýdan isim ve soyisim bilgisi istenir ve bilet kesilme iþlemi tamamlanýr. Veritabanýnda Otobus tablosunda koltuklarýn dolu olup olmama durum 1-0 mantýðý ile saklanmaktadýr. Her bilet kesilme iþeminde tablo güncellenmektedir.

	- KONTROL FORMU : Burada bilet kontrolü yapýlmasý amaçlanmýþtýr. Þirket bilet iþlemlerini yapan kullanýcý bu formu her plakaya ait hasýlatý hesaplamak için veya alýnan biletlerin tablosundan kontrol yapmaktadýr. Ýstenilirse tüm þirket hasýlatýný görmek için otobüs combobox'ýndan Hepsi deðeri seçilebilir. 

	- ARAÇ TAKÝP FORMU : Burada amaçlanan þey, kullanýcýnýn hareket saati gelen otobüsü yola çýkarmasý ve bunu yaptýðýnda ise asýl tablodan bu otomobil seferinin çýkarýlmasýdýr. comboboxtan seçilen plakaya göre  kiþi sayýsý ve sefer textbox'larý doldurulur. Araç Hareketlendir butonu seçilen otomobil plakasý datagridde yer alan tanloya ve veritabanýndaki Hareket tablosuna eklenir.  Araç Durum Kaydet butonu ile  günlük seferleri listbox'a listeleme amacý vardýr. Günlük Arþiv butonu ise bir txt dosyasý oluþturarak bunun içinde tüm listeyi depolama amacý ile yapýlmýþtýr.  
	
	----------------------------
	Notlar
	NOT:  Araç takip fromunda bazý eksiklikler mevcuttur. Hedeflerden sadece comboboxtan seçilen plakaya göre textboxlar doldurulmaktadýr. Diðer hedefler süre yetersizliði nedeniyle tamamlanamamýþtýr.  Fakat diðer formlar tüm hedeflerine uþalýr ve çalýþýr durumdadýr.

	NOT: Veri tabaný back up dosyasý .bak uzantýlý olup DB klasöründe ve projede kullanýlan resimler ise .png uzantýlý olup Images klasörü altýnda bulunmaktadýr. 

	----------------------------
	Grup Üyeleri

	- Yasemin Göktaþ ( yaseminngoktass@gmail.com )
	- Sýddýk Bozbek ( bozbeksddk@gmail.com ) 

	----------------------------
	Tarih 

	29 Ocak 2019 Salý - Saat : 21.00