using System;

namespace Lab10
{
    //так как интерфейса у нас нет, то этот класс будет отвечать за обработку входных сообщений c консоли
    public class Controller
    {
        /*
         * Можем обратиться к методу и получить объектный код
         */
        public void GetBufferProgramm() 
        {
            Console.ReadLine();
            Creator creator = new Creator();
            creator.Run();
        }

        /*
         * Еще методы получения нужных данных
         */
    }
}
