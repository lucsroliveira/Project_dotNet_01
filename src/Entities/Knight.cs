using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType){
            this.name = name;
            this.level = level;
            this.heroType = heroType;

        }  

      public virtual string attack(){
          return this.name + " Atacou com a sua espada";

      }    
    }
}