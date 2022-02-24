using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType){
            this.name = name;
            this.level = level;
            this.heroType = heroType;

      }    
        public override string attack(){
          return this.name + " Lançou magia";
      } 

      public string attack(int Bonus){

        if(Bonus > 6){
        return this.name + "Lançou Magia com bonus de ataque de " + Bonus;
        } 
        else {
          return this.name + "Lançou uma magia com força fraca com bonus de " + Bonus;
        }
      }
    }
}