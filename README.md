# TestCase
 sahneyi olusturduktan sonra zemin ve karakter icin add component kismindan collider 2D ozelligi ekledim
 
 png leri piksel art oldugu icin no filter ve compression i none sectim
 
 karakter icin rigidbody 2D ekleyip fiziki ozellik kazandirdim
 
 animasyonlari ayarlayip animatore ekledim 
 
 movement,enemy kodunu chatgpt ye yazdirdim hata verdigi kisimlari yine chatgpt yardimiyla degistirip duzelttim
 
 damage interface i olusturup enemy script i interface olarak ekledim (damage fonksiyonu oldugundan emin olmak icin)
 
 enemy inin colliderini trigger sectikten sonra player ontriggerenter a girdiginde other objenin tagi 'player' ise  damage fonksiyonunu cagirdim
 
 uygun animasyonlari oynatmak icin animatorda transitionlari ayarladim (speed isimli float ve attack isimli trigger olusturdum)
 
 karakter sola dondugunde arkasini donsun diye rotation da y yi 180 yaptim else i 0 yaptim
 
