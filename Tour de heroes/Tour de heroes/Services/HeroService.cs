
using Tour_de_heroes.IServices;
using Tour_de_heroes.Models;
using System.Linq;

namespace Tour_de_heroes.Services
{
    public class HeroService: IHeroService
    {
        public List<Hero> Heroes { get; } = new List<Hero>();


        public List<Hero> SearchHero(string nameHero)
        {
            List<Hero> HeroFound = Heroes.Where(hero => hero.Nombre.Equals(nameHero)).ToList();
            return HeroFound;
        }

        public void addHero(Hero hero)
        {
            Heroes.Add(hero);
        }

        public void DeleteHero(Hero hero)
        {
            Heroes.Remove(hero);
        }
    }
}
