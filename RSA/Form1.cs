using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace RSA
{
    public partial class Form1 : Form
    {
        public KeyGeneration keyGeneration;
        public Encryption encryption;
        public Decoding decoding;
        public int maxNumber = 10000; // Максимальное значение p и q при рандомной генерации

        public Form1()
        {
            InitializeComponent();
        }

        private void encryptionButton_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            keyGeneration = null;
            encryption = null;

            try
            {
                if (message.Text == "Сообщение..." || message.Text == "") throw new Exception("Поле сообщения не должно быть пустым!");
                {
                    if (!(justNumberP.Text != "" && justNumberQ.Text != "")) throw new Exception("Поля p и q не должны быть пустыми.");
                    {
                        
                        long P = Convert.ToInt64(justNumberP.Text);
                        long Q = Convert.ToInt64(justNumberQ.Text);

                        if (!(Algorithm.simplicity(P) && Algorithm.simplicity(Q))) throw new Exception("Числа p и q дожны быть простыми.");
                        {
                            if (!(P > 1 && Q > 1) || !(P < maxNumber && Q < maxNumber)) throw new Exception($"Числа p и q дожны быть больше 1 и меньше {maxNumber}.");
                            {
                                keyGeneration = new KeyGeneration(P, Q);
                                encryption = new Encryption(keyGeneration, message.Text);
                                printLogs();
                            }
                        }
                    }
                }
                
            }
            catch (Exception exception){

                MessageBox.Show(exception.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                justNumberP.Clear();
                justNumberQ.Clear();
            }
        }

        private void decodingButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(encryption != null)) throw new Exception("Ошибка расшифровки! Сначала зашифруйте сообщение.");
                {
                    richTextBox.Text += "Сообщение расшифровывается...\n";
                    decoding = new Decoding(keyGeneration, encryption);
                    richTextBox.Text += "Расшифрованное сообщение: \n";
                    richTextBox.Text += $"{decoding.decryptedMessage}\n";
                }
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

            decoding = null;
        }

        private void printLogs()
        {
            int waitCalculations = 2000;
            int waitMessage = 1500;
            if (decoding == null)
            {
                richTextBox.Text += "Вычисляется произведение p и q:\n";
                Task.Delay(waitCalculations).Wait();
                richTextBox.Text += $"n = {keyGeneration.compositionPQ}\n";

                Task.Delay(waitMessage).Wait();
                richTextBox.Text += "Вычисляется фукнция Эйлера:\n";
                Task.Delay(waitCalculations).Wait();
                richTextBox.Text += $"ф(n) = {keyGeneration.funcEuler}\n";

                Task.Delay(waitMessage).Wait();
                richTextBox.Text += "Вычисляется e:\n";
                Task.Delay(waitCalculations).Wait();
                richTextBox.Text += $"e = {keyGeneration.e}\n";

                Task.Delay(waitMessage).Wait();
                richTextBox.Text += "Вычисляется d:\n";
                Task.Delay(waitCalculations).Wait();
                richTextBox.Text += $"d = {keyGeneration.d}\n\n";

                Task.Delay(waitMessage).Wait();
                richTextBox.Text += $"Открытый ключ: [{keyGeneration.e}, {keyGeneration.compositionPQ}]\n";
                richTextBox.Text += $"Закрытый ключ: [{keyGeneration.d}, {keyGeneration.compositionPQ}]\n\n";

                Task.Delay(waitMessage).Wait();
                richTextBox.Text += "Шифруется сообщение...\n";
                Task.Delay(waitCalculations).Wait();
                richTextBox.Text += "Шифрованное сообщение: \n";
                richTextBox.Text += $"{encryption.encryptedMessage}\n\n";
            }
        }

        bool[] firstClick = new bool[3];
        private void justNumberP_MouseDown(object sender, MouseEventArgs e)
        {
            if (firstClick[0] == false)
            {
                justNumberP.Clear();
                firstClick[0] = true;
            }
        }

        private void justNumberQ_MouseDown(object sender, MouseEventArgs e)
        {
            if (firstClick[1] == false)
            {
                justNumberQ.Clear();
                firstClick[1] = true;
            }
        }

        private void message_MouseDown(object sender, MouseEventArgs e)
        {
            if (firstClick[2] == false)
            {
                message.Clear();
                firstClick[2] = true;
            }
        }

        private void clearMessage_Click(object sender, EventArgs e)
        {
            message.Clear();
        }

        private void message_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || ((e.KeyChar >= 'а' && e.KeyChar <= 'я')))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            richTextBox.SelectionStart = richTextBox.Text.Length;
            richTextBox.ScrollToCaret();
        }

        private void rundNumbers_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int numberP = rand.Next(maxNumber);
            int numberQ = rand.Next(maxNumber);

            while (Algorithm.simplicity(numberP) == false)
                numberP = rand.Next(maxNumber);

            while (Algorithm.simplicity(numberQ) == false || numberQ == numberP)
                numberQ = rand.Next(maxNumber);
            
            justNumberP.Text = numberP.ToString();
            justNumberQ.Text = numberQ.ToString();

            for (int i = 0; i < firstClick.Length - 1; i++)
                firstClick[i] = false;
        }
    }
}
