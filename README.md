# Simple-Encryption-
A simple encryption, to include in your project!

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





