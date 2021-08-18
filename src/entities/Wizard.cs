namespace src.entities
{
    public class Wizard : Hero
    {


        public Wizard(string name, int level, string heroClass)
        {
            Name = name;
            Level = level;
            HeroClass = heroClass;
            HP = 100 + (Level * 6);
            MP = 100 + (Level * 7);
        }

        public Wizard()
        {

        }
        
    




        public override string Attack()
        {
            return this.Name + " lançou uma magia.";
        }


    }
}