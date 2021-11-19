using System;

namespace Lab10
{
    // Этот класс будет выступать в роли создателя
    class Creator 
    {
        //Связываем ввод пользователя с логической частью программы
        Parser parser;
        BufferOutput bufferOutput = new BufferOutput();
        public void Run()
        {
            //Создаём класс по введенному в консоль пути
            parser = new Parser(Console.ReadLine());
            // получаем объектный код и выведем его в буфер обмена
            bufferOutput.SetBufferText(parser.Parse());
        }
    }
}
