using System;
using System.Collections.Generic;
using BracketPair.Src.DocumentDecorationManager.BaseFiles;
namespace BracketPair.Src.DocumentDecorationManager.IColorIndexes
{
    public interface IColorIndex
    {
        int GetPreviousIndex() { get; set; }
        void SetCurrent(int colorIndex) { get; set; }
        int getCurrentLength( bracketPair BracketPair) { get; set; }
        // getCurrentColorIndex(bracketPair: BracketPair, range: Range)
        //getScope(position: Position) : Scope | undefined;
        string GetOpenBrackets(string value) { get; set; }
        int clone() : IColorIndex {get; set;}
    }
}
