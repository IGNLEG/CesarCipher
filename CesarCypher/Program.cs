using System;

namespace CesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your message you want to encrypt: ");
            try
            {
                string InputMessage = Console.ReadLine();
                Console.WriteLine("Enter your key  (negative numbers are left shift, positive right shift): ");
            
                int Key = Convert.ToInt32(Console.ReadLine());
                Key = TaskUtils.ConvertKeyIfNegativeValue(Key);


                string Encrypted = TaskUtils.Encipher(InputMessage, Key);
                string Decrypted = TaskUtils.Decypher(Encrypted, Key);
                Console.WriteLine("Encrypted message: {0} \n", Encrypted);
                Console.WriteLine("Decrypted message: {0} \n", Decrypted);
            }
            catch 
            {
                throw new ArgumentException("Invalid key entered.");
            }
            return;
        }      

    }
}
