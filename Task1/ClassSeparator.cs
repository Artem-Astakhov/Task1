using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    public class ClassSeparator
    {
        private List<char> pattern = new List<char>() { '!', '@', '#', '$', '%', '^', '&', '*', '?', '/', '|', '1', '2', '3','4','5','6','7','8','9','0' }; 
               
        public string ReverseWordWithoutSymbol(string text)
        {
            Dictionary<int, string> repositorySymbol = new Dictionary<int, string>();
            List<string> editedText = new List<string>();

            for(int i = 0; i<text.Length; i++)
            {               
                if (pattern.Contains(text[i]))
                {
                    repositorySymbol.Add(i, text[i].ToString());                  
                }
                else
                {
                    editedText.Add(text[i].ToString());
                }
            }

            string changedText = String.Join("", editedText.ToArray());

            changedText = WordsReverse(changedText);

            foreach(var item in repositorySymbol)
            {
                changedText = changedText.Insert(item.Key, item.Value);
            }

            return changedText;
        }
        
        public int IndexOf(string text, int startIndex, char[] separators, out char currentSeparator)
        {
            currentSeparator = ' ';
            for (var i = startIndex; i < text.Length; i++)
            {
                for (var j = 0; j < separators.Length; j++)
                {
                    if (text[i] == separators[j])
                    {
                        currentSeparator = separators[j];
                        return i;
                    }
                }
            }

            return -1;
        }

        public string WordsReverse(string text)
        {
            var textLength = text.Length;
            var retValue = new char[textLength];
            var wordStartIndex = 0;

            while (wordStartIndex < textLength)
            {
                var separatorIndex = IndexOf(text, wordStartIndex, new[] { ' ', ',', '.' }, out char currentSeparator);
                if (separatorIndex == -1)
                {
                    separatorIndex = text.Length;
                }
                else
                {
                    retValue[separatorIndex] = currentSeparator;
                }

                var currentIndex = wordStartIndex;
                for (var i = separatorIndex - 1; i >= wordStartIndex; i--)
                {
                    retValue[currentIndex] = text[i];
                    currentIndex++;
                }

                wordStartIndex = separatorIndex + 1;
            }

            return new string(retValue);
        }
    }
}
