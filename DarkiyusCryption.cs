namespace DarkiyusCryptionLib
{
    public class Darkiyus
    {

        public static string Crypter(int operation, string Input)
        {

            var ec = new Darkiyus();
            int loopPass = 2;

            if (operation == 0) //Encryption
            {
                for (int i = 0; i < loopPass; i++) //encrypted twice for better security
                {
                    Input = ec.Encryption(Input);
                }
                string encryption = Input;


                return encryption;
            }
            if (operation == 1) //Decryption
            {
                for (int i = 0; i < loopPass; i++) //decrypts twice
                {
                    Input = ec.Decryption(Input);
                }
                string decryption = Input;

                return decryption;

            }
            else
            {
                return "Error - Please enter an operation number between 0 and 1!";
            }





        }
        //Here you can make settings
        private int Variablen(string var)
        {

            int TableCharacter = 85;


            if (var == "TableCharacter")
            {
                return TableCharacter;
            }

            else
            {
                return 0;
            }
        }

        //Table with the encryption codex
        private string Table(int Typ, int Stelle)
        {

            string[,] table = new string[2, 85]
            {
            {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N","O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "@", ".", ",", "-", "_", "?", "!", "%", "&", "#", "+", "*", "ß", "Ä", "Ü", "Ö", "ä", "ü", "ö", " ", ":", @"\", "/" }, //Reale Zeichen
            {"66","51","23","70","79","81","63","95","47","86","12","77","08","07","35","67","74","29","22","45","60","97","19","69","76","90","46","33","59","01","39","43","94","10","75","53","28","16","89","17","88","11","30","68","34","83","41","64","13","06","96","05","14","92","15","03","71","02","85","26","32","36","91","27","24","38","04","58","37","98","55","44","87","78","57","50","72","84","25","56","61","09","49","40","54" } //Kodiert
            };

            return table[Typ, Stelle];
        }

        private string Encryption(string InputString)
        {
            string stringEncrypted = ""; //End-result
            char[] stringChar = InputString.ToCharArray(); //Inputstring to Char
            int InputStringLength = InputString.Length; //Length from Inputstrings
            var ec = new Darkiyus();
            int TableCharacters = Variablen("TableCharacter"); //Table character length


            for (int i = 0; i < InputStringLength; i++) //Does this as long as the string to be encrypted goes
            {
                for (int y = 0; y < TableCharacters; y++) //Goes through the table and looks for the character and virtually replaces it with the encoded value
                {


                    char place = Convert.ToChar(Table(0, y));
                    if (stringChar[i] == place)
                    {

                        stringEncrypted = stringEncrypted + Table(1, y);
                    }



                }
            }





            return stringEncrypted;
        }
        private string Decryption(string encryptedString)
        {
            string stringDecrypted = ""; //End-result
            int decryptedStringLength = encryptedString.Length / 2; //length of the original string
            string[] cryptedZiffer = new string[decryptedStringLength];

            var ec = new Darkiyus();
            int TableCharacters = Variablen("TableCharacter"); //Table character length


            for (int i = 0; i < decryptedStringLength; i++) //Goes as long as the original string was long
            {

                cryptedZiffer[i] = encryptedString.Substring(i * 2, 2); //Pulls out the two characters




            }

            for (int z = 0; z < decryptedStringLength; z++) //Goes as long as the original string was long
            {
                for (int y = 0; y < TableCharacters; y++) //Goes through the table
                {



                    if (cryptedZiffer[z] == Table(1, y)) //Substitutes the encoded values to the correct values!
                    {

                        stringDecrypted = stringDecrypted + Table(0, y);
                    }



                }
            }

            return stringDecrypted;

        }

    }
}