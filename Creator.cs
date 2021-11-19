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
            //Создём класс по введенному в консоль пути
            parser = new Parser(Console.ReadLine());
            // получаем объектный код и выдвем его в буффер обмена
            bufferOutput.SetBufferText(parser.Parse());
        }
    }
}
