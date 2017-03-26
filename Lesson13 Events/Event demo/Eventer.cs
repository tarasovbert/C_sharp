using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_demo
{
    public delegate void EventDelegate(string str); //1 объявить делегат события, задающий сигнатуру метода, выполняемого при наступлении события.
    public class Eventer
    {
        int counter;
        public event EventDelegate SomeEvent; //2 Объявить событие соответствующего типа.
        public void Run()
        {
            for (;;)
                if (DateTime.Now.Second % 5 == 0)
                    OnSomeEvent(ref counter);
        } //6 Создать событие

        protected virtual void OnSomeEvent(ref int counter)//3 Создать метод, генерирующий событие.
        {
            if (SomeEvent != null)//!! проверка на подписку
            {
                counter++;
                SomeEvent(String.Format("{0} Some event occured!", counter));
            }//6 Создать событие
        }
    }
}
