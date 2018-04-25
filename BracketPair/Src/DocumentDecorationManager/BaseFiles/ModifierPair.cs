using System;
namespace BracketPair.Src.DocumentDecorationManager.BaseFiles
{
    public class ModifierPair
    {
        public readonly string openingCharacter;
        public int counter = 0;
        public readonly string closingCharacter;

        public ModifierPair(string openingCharacter, string closingCharacter, int? counter)
        {
            this.openingCharacter = openingCharacter;
            this.closingCharacter = closingCharacter;

            if(counter != null){
                this.counter = counter;
            }
        }

        public Clone(){
            return new ModifierPair(this.openingCharacter, this.closingCharacter, this.counter);
        }
    }
}
