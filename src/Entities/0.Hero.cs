namespace Projeto_RPG.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public Hero(){}
        public override string ToString(){
            return $"{this.Name}, de nivel {this.Level}, da classe {this.HeroType}.";
        } 
        public virtual string Attack(){
            return $"{this.Name} atacou com sua espada!";
        }
        public string Name;
        public int Level;
        public string HeroType;
    }
}