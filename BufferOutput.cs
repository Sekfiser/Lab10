using System.Windows.Forms;

namespace Lab10
{
    //Некое предисловие, под "выдающий объектный код в буфер" я понял выдачу в буффер обмена crtl + v
    //класс для выдачи в буфер обмена 
    class BufferOutput
    {
        /*
         * Метод для вставки в буфер обмена
         */
        public void SetBufferText(string text) 
        {
            Clipboard.SetText(text);
        }
    }
}
