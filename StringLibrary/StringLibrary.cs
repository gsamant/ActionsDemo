using System;

namespace UtilityLibraries
{
    public static class StringLibrary
    {
        public static bool StartsWithUpper(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

<<<<<<< HEAD
            char ch = str[0];
            return char.IsLower(ch);
=======
            char chr = str[0];
            return char.IsUpper(chr);
>>>>>>> cb34ed596f2f65f77411aa51f8d9ba592513d6d7
        }
    }
}