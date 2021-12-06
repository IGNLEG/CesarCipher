using Microsoft.VisualStudio.TestTools.UnitTesting;
using CesarCipher;

namespace CesarCypherTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CipherLetter_LowerCaseLetter_ShiftsCorrectly()
        {
            int key = 3;
            char letter = 'a';
            char expectedLetter = 'd';

            char actualLetter = TaskUtils.CipherLetter(letter, key);

            Assert.AreEqual(expectedLetter, actualLetter, "Letter is not shifted correctly");
        }
        [TestMethod]
        public void CipherLetter_CapitalLetter_ShiftsCorrectly()
        {
            int key = 3;
            char letter = 'A';
            char expectedLetter = 'D';

            char actualLetter = TaskUtils.CipherLetter(letter, key);

            Assert.AreEqual(expectedLetter, actualLetter, "Letter is not shifted correctly");
        }
        [TestMethod]
        public void CipherLetter_WithSymbol_DoesntShift()
        {
            int key = 3;
            char symbol = '$';
            char expectedSymbol = '$';

            char actualSymbol = TaskUtils.CipherLetter(symbol, key);

            Assert.AreEqual(expectedSymbol, actualSymbol, "Symbol was shifted");
        }
        [TestMethod]
        public void CipherLetter_KeyMoreThan25_ShiftsCorrectly()
        {
            int key = 30;
            char letter = 'a';
            char expectedLetter = 'e';

            char actualLetter = TaskUtils.CipherLetter(letter, key);
            Assert.AreEqual(expectedLetter, actualLetter, "Letter is not shifted correctly");
        }
        [TestMethod]
        public void Encipher_MixedText_ShiftsCorrectly()
        {
            int key = 3;
            string input = "AbcD eFG$E";
            string expectedOutput = "DefG hIJ$H";

            string actualOutput = TaskUtils.Encipher(input, key);

            Assert.AreEqual(expectedOutput, actualOutput, "Message was not ciphered correctly");
        }
        [TestMethod]
        public void Decypher_MixedText_ShiftsCorrectly()
        {
            int key = 3;
            
            string input = "DefG hIJ$H";
            string expectedOutput = "AbcD eFG$E";

            string actualOutput = TaskUtils.Decypher(input, key);

            Assert.AreEqual(expectedOutput, actualOutput, "Message was not ciphered correctly");
        }
        [TestMethod]
        public void ConvertKeyIfNegativeValue_KeyIsLessThanMinus26_ConvertsCorrectly()
        {
            int key = -677;

            int expectedConversion = 25;

            int actualConversion = TaskUtils.ConvertKeyIfNegativeValue(key);

            Assert.AreEqual(expectedConversion, actualConversion, "Key was not converted correctly");
        }
        [TestMethod]
        public void ConvertKeyIfNegativeValue_KeyIsNotLessThanMinus26_ConvertsCorrectly()
        {
            int key = -25;

            int expectedConversion = 1;

            int actualConversion = TaskUtils.ConvertKeyIfNegativeValue(key);

            Assert.AreEqual(expectedConversion, actualConversion, "Key was not converted correctly");
        }

    }
}
