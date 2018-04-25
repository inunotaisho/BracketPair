using System;
namespace BracketPair.Src.DocumentDecorationManager.BaseFiles
{
    public class BracketPair
    {
        public readonly string openCharacter;
        public readonly string closeCharacter;
        public readonly string[] colors;
        public readonly string orphanColor;

        public BracketPair(string firstBracket, string lastBracket, string[] colors, string orphanColor)
        {
            this.openCharacter = firstBracket;
            this.closeCharacter = lastBracket;
            this.colors = colors;
            this.orphanColor = orphanColor;
        }
    }
}
