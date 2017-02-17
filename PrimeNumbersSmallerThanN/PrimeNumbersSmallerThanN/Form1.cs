using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbersSmallerThanN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            listPrimes.DataSource = null; // при всяко ново натискане изчистваме списъка

            int endNum = 0; // дефинираме променливата извън try-catch блока за да можем да я използваме извън него

            try
            {
                endNum = int.Parse(this.textBoxInput.Text); // парсваме текста от textBoxInput
                textBoxStatus.Text = "Number is OK.";
            }
            catch (Exception)
            {
                textBoxStatus.Text = "Invalid Number!"; // ако не успеем да парснем уведомяваме
            }


            List<int> primeNums = new List<int>();

            for (int curentNum = 2; curentNum < endNum; curentNum++) // въртим до крайното число 
            {
                bool isPrime = true; // дефинираме булева променлиза за проверка за просто число 

                for (int devider = 2; devider < curentNum; devider++) // въртим делителя
                {
                    if (curentNum % devider == 0)
                    {
                        isPrime = false;
                        break; // ако числото се дели без остатък не е просто и няма смисъл да продължаваме цикъла
                    }
                }

                if (isPrime)
                    primeNums.Add(curentNum); // ако числото е просто добавяме в списък 
            }

            listPrimes.DataSource = primeNums; // принтираме числата в списъка
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listPrimes.DataSource = null; // изчистваме списъка
            textBoxInput.Text = null; // изчистваме полето за въвеждане
        }
    }
}
