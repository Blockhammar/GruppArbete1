namespace GruppArbete1.Models
{
    public class BandsService
    {
        List<Band> bandList = new List<Band>
        {
            new Band { Id = 1, Name = "Kreator", Description = "Kreator is a German thrash metal band from Essen, formed in 1982. Their current lineup consists of lead vocalist and rhythm guitarist Miland \"Mille\" Petrozza, drummer Jürgen \"Ventor\" Reil, lead guitarist Sami Yli-Sirniö, and bassist Frédéric Leclercq. The band's lineup has changed multiple times over its 40-year career, most noticeably with their bassists and lead guitarists."},
            new Band { Id = 2, Name = "Beatles", Description = "The Beatles were an English rock band, formed in Liverpool in 1960, that comprised John Lennon, Paul McCartney, George Harrison and Ringo Starr. They are regarded as the most influential band of all time[1] and were integral to the development of 1960s counterculture and popular music's recognition as an art form.[2] Rooted in skiffle, beat and 1950s rock 'n' roll, their sound incorporated elements of classical music and traditional pop in innovative ways; the band also explored music styles ranging from folk and Indian music to psychedelia and hard rock. "},
            new Band { Id = 3, Name = "Backstreet Boys", Description = "The Backstreet Boys (often abbreviated as BSB)[3] is an American vocal group[4] consisting of Nick Carter, Howie Dorough, AJ McLean, and cousins Brian Littrell and Kevin Richardson. Lou Pearlman formed the group in 1993 in Orlando, Florida.\r\n\r\nThe group rose to fame with their international debut album, Backstreet Boys (1996). In the following year, they released their second international album Backstreet's Back (1997), along with their self-titled U.S. debut album, Backstreet Boys (1997), which continued the group's success worldwide. They rose to superstardom with their third studio album Millennium (1999) and its follow-up album, Black & Blue (2000). "}
        };

        public Band[] GetAllBands()
        {
            return bandList
                .OrderBy(x => x.Id)
                .ToArray();
        }

        public Band GetBandById(int id)
        {
            return bandList
                 .FirstOrDefault(x => x.Id == id);
        }


    }
}
