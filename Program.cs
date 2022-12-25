using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing;
using System.Security.Policy;
using System.Threading;

namespace _22_12_2022_WIN_Form_Save_TO_HTML
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

          
        }
    }
}
//ќбща€ сводка по HTML-таблицам
//ƒавайте закрепим полученную информацию. ¬от теги, которые мы использовали при построении HTML-таблиц:
//< table > Ц тег, позвол€ющий создать контейнер таблицы;
//< tr > Ц тег дл€ создани€ строки (р€да) таблицы, используемый совместно с <td> или <th>;
//< td > Ц тег обычной €чейки таблицы;
//< th > Ц тег €чейки-заголовка таблицы;
//< col > Ц тег, позвол€ющий создать колонки дл€ таблицы;
//< colgroup > Ц тег, который группирует колонки;
//< thead > Ц тег дл€ верхнего колонтитула таблицы;
//< tbody > Ц тег основной части таблицы;
//< tfoot > Ц тег дл€ нижнего колонтитула таблицы;
//< caption > Ц используйте этот тег, чтобы задать общий заголовок дл€ таблицы;
//colspan Ц показывает количество €чеек в строке дл€ объединени€ по горизонтали;
//rowspan Ц показывает количество €чеек в столбце дл€ объединени€ по вертикали;
//span Ц количество колонок, объедин€емых дл€ задани€ единого стил€, по умолчанию равно 1;
//border Ц ширина границ таблицы в пиксел€х, по умолчанию: 0 Ц в таком случае обводка таблицы не видна;
//cellpadding Ц отступ от границ €чеек до их содержимого;
//cellspacing Ц отступ между границами €чеек
//„тобы добавить визуальные эффекты, используйте CSS-стили Ц с их помощью можно как увеличить размер обводки границ,
//так и задать цвет фона, размер и шрифт текста.
//—оздание HTML-таблицы Ц это дело нескольких минут.
//√лавное Ц разобратьс€ с базовыми пон€ти€ми и попрактиковатьс€ на нескольких примерах.
//¬ последующем создание таблицы не будет вызывать у вас никаких проблем.