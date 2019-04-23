using System;
using System.Threading;
using System.IO.Ports;
using System.Configuration;
using System.Windows.Forms;

namespace AccessControlSystem
{ 
    class ArduinoRW
    {
        private bool cancelled = false;
        private bool errorEnd = false;
        private SerialPort serialArduino;
        public ArduinoRW()
        {
            serialArduino = new SerialPort();
            serialArduino.PortName = (string)ConfigurationManager.AppSettings["ComPort"].ToLower();
            serialArduino.BaudRate = 9600;

            try
            {
                if (!serialArduino.IsOpen)
                    serialArduino.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка инициализации Com-порта.\nТекст ошибки: " + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Cancel()
        {
            this.cancelled = true;
        }

        public void ResendUID() // отправка команды на повторную отправку UID 
        {
            this.SendCommand("r");
        }

        public void DontOpenTheGate() // отправка команды на неоткрывание запирающего устройства
        {
            this.SendCommand("d");
        }

        public void OpenTheGate() // отправка команды на открытие запирающего устройства
        {
            this.SendCommand("o");
        }

        public void ClearBufer() // отправка команды на очищение запомненного ключа
        {
            this.SendCommand("c");
        }

        public void ReadUID() // отправка команды на чтения UID ключа
        {
            this.SendCommand("w");
        }

        private void SendCommand(string command)
        {
            /*
             * Список команд:
                 * c (clearTemp) - очистить буфер 
                 * o (openTheGate) - открыть запирающее устройство
                 * d (dontOpenTheGate) - не открывать запирающее устройство
                 * w (waitRFID) - ожидать RFID ключ, считать с него UID и отправить в программу
                 * r (resendUID) - повторить отправку UID ключа
             */
            try
            {
                serialArduino.WriteLine(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка отправки команды.\nТекст ошибки: " + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Start()
        {
            Thread.Sleep(200); // Ждем пока загрузится основная форма

            while (!this.cancelled)
            {
                string message = "";
                try
                {
                    if (serialArduino.BytesToRead > 0)
                        message = serialArduino.ReadLine();
                        if (message != null && message != String.Empty) ArduinoReadUID(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка чтения.\n Текст ошибки: " + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorEnd = true;
                    break;
                }
                if (this.cancelled)
                    break;
            }
            
            if (serialArduino.IsOpen)
                serialArduino.Close();
            if (!cancelled)
            ArduinoPortClose(errorEnd);
        }
        public event Action<string> ArduinoReadUID; // событие прочтения UID 
        public event Action<bool> ArduinoPortClose; // событие закрытия порта
    }
}