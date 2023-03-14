
using Tour_de_heroes.Models;

namespace Tour_de_heroes.IServices
{
    public interface IHeroService
    {
        public List<Hero> SearchHero(string nameHero);

        public void addHero(Hero hero);
    }
}
