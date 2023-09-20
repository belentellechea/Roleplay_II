using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook : IMagicItems
    {
        public Spell[] Spells { get; set; }
        
        public int AttackMagicValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }

        public int DefenseMagicValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.DefenseValue;
                }
                return value;
            }
        }
    }
}