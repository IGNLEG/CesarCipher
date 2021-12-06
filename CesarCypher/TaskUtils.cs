namespace CesarCipher
{
    public class TaskUtils
    {
        public static char CipherLetter(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char upperBound = char.IsUpper(ch) ? 'A' : 'a';//Sets upper bound of alphabet to UC or LC 

            return (char)((((ch + key) - upperBound) % 26) + upperBound); //Calculates how far down the ciphered letter will be from the top of the LC or UC alphabet in ascii table
                                                                          //and adds that number to the top letter ascii code and returns ciphered letter
        }

        public static string Encipher(string input, int key)
        {
            string cipheredText = string.Empty;            

            foreach (char ch in input)
            {
                cipheredText += CipherLetter(ch, key);
            }
            return cipheredText;
        }

        public static string Decypher(string input, int key)
        {
            return Encipher(input, 26 - (key % 26)); //Since the alphabet is considered a loop here, you go forwards instead of backwards to get the decyphered message
        }
        public static int ConvertKeyIfNegativeValue(int key)
        {
            if (key < -26)
            {
                key = (key % 26) + 26;
            }
            else if (key < 0 && key > -26)
            {
                key += 26;
            }
            return key;
        }
    }
}
