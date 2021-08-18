namespace src.entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroClass)
        {
            Name = name;
            Level = level;
            HeroClass = heroClass;
            HP = 100 + (Level * 8);
            MP = 100 + (Level * 3);
        }



        
        public override string Attack()
        {
            return this.Name + " atacou com a espada.";
        }

        

        
    }

    
}