
namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запускаем исполнение нашей программы
            Execute programm = new Execute();
            programm.execute();
        }

        /*
         * Просто вложенный класс для более правильной структуры
         * Чтобы в случае чего передать его метод в отдельный поток и разделить логику и пользовательский интерфейс
         */
        class Execute
        {
            public void execute() 
            {
                Controller controller = new Controller();
                controller.GetBufferProgramm();
            }
        }
    }
}
