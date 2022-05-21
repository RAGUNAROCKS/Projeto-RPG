namespace Projeto_RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return $"{this.Name} atacou com a magia!";
        }
        public string Attack(int bonus){
            if(bonus > 6)
            return $"{this.Name} lançou a magia super efetiva com bonus de {bonus} de dano";
            else
            return $"{this.Name} lançou a magia fraca com bonus de {bonus} de dano";
        }
    }
}