# Simple-Encryption by Darkiyus
A simple string encryption, to include in your project!


# How do I use this?

Put the Darkiyus-CrypterMain.cs into your project
(That's all you need!)

To decrypt or encrypt a string use the following:

    DarkiyusCryption.Main(int operation, string Input);

The function expects two values!
The first value determines what you want to do:
0 = encrypt
1 = decrypt

The second value is the string you want to encrypt!

# Example from a WinForm project

    private void Encrypted_Click(object sender, EventArgs e)
        {
            string Text = textBox1.Text;
            textBox1.Text = DarkiyusCryption.Main(0, Text);
        }
    private void Decrypted_Click(object sender, EventArgs e)
        {
            string Text = textBox1.Text;
            textBox1.Text = DarkiyusCryption.Main(1, Text);
        }
# What characters can all be encrypted?

A total of 85 characters can currently be encrypted.

    A-Z, a-z, Ä-Ö, ä-ö, 0-9 and the following special characters:
    @.,-_?!%&#+*ß:\/ additionally spaces
    
# Settings
You can add more characters, for this you would only have to change the last digit of the array to the desired length in the Table() function and insert your additional characters there (in the first array column).

Furthermore you would have to change the int TableCharacter in the function Variables to the new length.

If you want to change the encoding, currently this is limited to two characters, you would have to change this a bit more complex in the function Decryption(), if you want to use more characters.
If you want to stay with two characters and only exchange the numbers or assign letters instead of numbers, you can also simply change this in the Table() (Second array column).

In the Main function you can change the Int value loopPass if you want to have more encryption passes!
Currently this is set to two, which means four times the character length of the original string!






