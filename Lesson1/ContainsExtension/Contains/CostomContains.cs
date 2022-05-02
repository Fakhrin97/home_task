using System;

namespace Contains
{
    static class CostomContains
    {
        public static void costomContains(this string word , string searchword)
        {
            bool result = false;
            for (int i = 0; i < word.Length - searchword.Length + 1; i++)
            {
                string clone = word.Substring(i, searchword.Length);
                if (clone.ToLower() == searchword.ToLower())
                {
                    result = true;
                    break;
                }
            }
            Console.WriteLine($"{(result==true?"True":"False")}");     

        }
    }
}
