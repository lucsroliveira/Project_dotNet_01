using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Entities
{
    public class Hero
    {

      public Hero(string name, int level, string heroType){
            this.name = name;
            this.level = level;
            this.heroType = heroType;

      }    
      public string name; 
      public int level;
      public string heroType;
      
      public override string ToString(){
          return this.name + " " + this.level + " " + this.heroType;
      }

      public virtual string attack(){
          return this.name + " Atacou com a sua espada";
      } 

    }
}