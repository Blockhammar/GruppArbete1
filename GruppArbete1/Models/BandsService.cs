namespace GruppArbete1.Models
{
    public class BandsService
    {
        List<Band> bandList = new List<Band>
        {
            new Band { Id = 1, Name = "Creator", Description = "RockBand"},
            new Band { Id = 2, Name = "Beatles", Description = "Boy Band"},
            new Band { Id = 3, Name = "Backstreet Boys", Description = "Young band"}
        };

        public Band[] GetAll()
        {
            return bandList
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Description)
                .ToArray();
        }
    }
}
