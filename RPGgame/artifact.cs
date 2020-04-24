using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame
{
    public abstract class artifact : ICollector
    {   //поля:
        public int pover;
        public bool renewability;
        public artifact() { }
        virtual public void UseArtifact(int Damage, ref MagicCharacter person)
        {
            //person.CurrentMagicPower -= Damage;
            //if (person.CurrentMagicPower < 0)
            //    person.CurrentMagicPower = 0;
        }

        public void UseArtifact() { }
    }
}
