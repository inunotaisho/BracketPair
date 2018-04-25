using System;
using Microsoft.VisualStudio.Workspace;
namespace BracketPair.Src.DocumentDecorationManager.BaseFiles
{
    public class Bracket
    {
        public readonly string character;
        public readonly int colorIndex;
        public Bracket(string character, int colorIndex)
        {
            this.character = character;

            this.colorIndex = colorIndex;
        }
    }
}
