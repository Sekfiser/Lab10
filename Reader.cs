using System;
using System.IO;

namespace Lab10
{
    //класс для чтения файла кода из файла
    class Reader
    {
        private StreamReader reader;

        /*Метод для чтения файла по переданному пути, возвращает текст из файла ввиде строки
         *       
         */
        public string Read(string filePath) 
        {
            using (reader = new StreamReader(filePath))
            {
              /*
               * какая-то логика чтения и записи в строку
               */
            }
            throw new Exception(); //конструкция напомнит о необходимости реализации метода
        }
    }
}
