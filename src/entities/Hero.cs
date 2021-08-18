namespace src.entities
{
    public abstract class Hero
    {
        public string Name;
        public int Level, HP, MP;
        public string HeroClass;
        

        public Hero()
        {

        }

        public Hero(string name, int level, string heroClass)
        {
            Name = name;
            Level = level;
            HeroClass = heroClass;
            
            
        }



        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroClass;
        }

        public virtual string Attack()
        {
            return this.Name + " atacou com sua espada.";
        }


        public string GetHP()
        {
            return this.Name + " HP: " + HP;
        }


        public string GetMP()
        {
            return this.Name + " MP: " + MP;
        }





    }
}