using System;
using System.Windows.Forms;
using System.Threading;

namespace ExamRandomizer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Thread thread;
        private bool flgStart = false;
        private delegate void SetStringValue(string str);

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            flgStart = !flgStart;

            if (flgStart)
            {
                btnStartStop.Text = "Остановить";
                numTickets.Enabled = false;
                thread = new Thread(runRandomizer);
                thread.Start();
            }
            else
            {
                btnStartStop.Text = "Запустить";
                numTickets.Enabled = true;
                thread.Abort();
            }
        }

        private void runRandomizer()
        {
            Random rnd = new Random();
            string strResult;
            while (true)
            {
                //Проверено: ноль не выпадает, указанный максимум выпадает
                //сверх максимума не выпадает
                strResult = rnd.Next(1, (int)numTickets.Value + 1).ToString();
                if (strResult.Length < 2) strResult = "0" + strResult;
                //Без делегирования не обойтись, поскольку в потоке элемент не
                //этого потока напрямую использован быть не может.
                //Обёртка сделана из-за lblDynamic
                if (lblDynamic.InvokeRequired)
                {
                    SetStringValue SSV = new SetStringValue(strVal);
                    Invoke(SSV, new object[] { strResult });
                }
                else
                    lblDynamic.Text = strResult;
                //пустой цикл: норма 5000 
                //для вялого просмотра перебора: int.MaxValue / 4
                for (int i = 0; i < 5000; i++) ;
            }
        }

        //Метод для делегирования
        private void strVal(string str)
        {
            lblDynamic.Text = str;
        }
    }
}
