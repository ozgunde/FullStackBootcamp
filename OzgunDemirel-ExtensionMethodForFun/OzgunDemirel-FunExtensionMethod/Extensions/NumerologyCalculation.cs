using FunExtensionMethod.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunExtensionMethod
{
    public static class NumerologyCalculation
    {
        public static string NameNumerologyCalculator(this string name)
        {
            string nametoconvertnumber = name.Replace("a", "1").Replace("b", "2").Replace("c", "3").Replace("ç", "3").Replace("d", "4").Replace("e", "5").Replace("f", "6").Replace("g", "6").Replace("ğ", "7").Replace("h", "8").Replace("ı", "9").Replace("i", "9").Replace("j", "1").Replace("k", "2").Replace("l", "3").Replace("m", "4").Replace("n", "5").Replace("o", "6").Replace("ö", "6").Replace("p", "7").Replace("q", "8").Replace("r", "9").Replace("s", "1").Replace("ş", "1").Replace("t", "2").Replace("u", "2").Replace("ü", "3").Replace("v", "4").Replace("y", "7").Replace("z", "8");
            int result = (int)Convert.ToInt64(nametoconvertnumber) + 3; //2021 yılına ait değer 3 olarak eklenmiştir.
            int sumofdigit = SumOfDigitsUntilOneDigit.DigitSum(result);
            return sumofdigit switch
            {
                1 => "Numerolojisi 1 olan insanlar bu yıl tamamıyla iyi bir yıl geçirecekler.Olumlu titreşimlerle birlikte etrafınızda dolaşan yeni bir enerji çizgisi hissedeceksiniz.Kendinize daha çok güvenecek ve hedeflerinize ulaşmak için çok çalışacaksınız.",
                2 => "Numerolojisi 2 olan insanların bu yılı zorluklarla dolu olacak ve başarılı olmanız için mücadele vermeniz ile ilişkili ilerleyecek.Evli iseniz yada bir ilişki içerisindeyseniz ilerleme gelişme gösteriyorsunuz. Küçük farklılıklar ve tartışmalar olsa da, çözüm sakin kalmanızla gizlidir.",
                3 => "Numerolojisi 3 olan insanlar bu yıl profesyonel ve kişisel hedeflerine ulaşmak için hiç olmadığı kadar kararlı.Hiç kimse sizi etkileyemiyor.Söyledikleriniz karşısında ikna olmuşa benzemeyen bir kitle önünde bile kendinizi ufak bir tereddüt belirtisi göstermeden ifade ediyorsunuz.",
                4 => "Numerolojisi 4 olan insanlar bu yıl zorluklarla karşılaşabilir. Bu yıl ev yaşamınızı bir dereceye kadar etkileyebilir.Aşk hayatınız küçük yanlış anlamalar ve tartışmalarla dolu olacak ve biraz sıkıntılı olacaktır. Bu gibi durumlarda sakin ve sabırlı olun.",
                5 => "Numerolojisi 5 olan insanlar bu yıl çok güzel olaylara şahit olacaklar.Bazı zorluklar olacak, ancak bunları bilginiz ve kararlılığınızla azaltabileceksiniz.Bu yıl akademik, spor, tıbbi veya kamu sınavlara hazırlanıyorsanız, bunu kolayca başaracaksınız. Daha iyi sonuçlar almak için sıkı çalışmaya ve her alanı keşfetmeye devam edin.",
                6 => "Numerolojisi 6 olan insanlar ortalama bir yıl yaşayacaklar, bu yüzden zorlukların üstesinden gelmeye hazır olmalılar.Kararlılığınızı ve kendinize olan güveninizi korumanız halinde hiç bir şey imkansız olmayacaktır.",
                7 => "Numerolojisi 7 olan insanlar için ilerleyici bir yıl olacak.Umut vadeden bir yaz sizi bekliyor olacak ve yaşamınızda son derece gerekli bazı değişiklikler yapmanıza imkan sağlayacak. Acele etmeye gerek yok.",
                8 => "Numerolojisi 8 olan insanlar için sorunlar ve anlaşmazlıklar ile dolu bir yıl olacak.Hazırlanmakta olduğunuz sınavlarınızda başarılı olmak için gerçekten çok çalışmalısınız.",
                9 => "Numerolojisi 9 olan insanlar için etkili bir yıl olacak.Yavaş yavaş etkisini gösteren bir dönüşüm sizi bekliyor. Hissettiğiniz acıları, pişmanlıkları unutup daha huzurlu bir geleceğe yönelme şansına sahipsiniz.Bu düşünme sürecini en iyi şekilde değerlendirmesini bilin!",
                _ => "Üzgünüz 2021 numeroloji tahmininizi öngöremedik." 
            };
        }
    }
}
