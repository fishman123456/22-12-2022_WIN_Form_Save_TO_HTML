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
//����� ������ �� HTML-��������
//������� �������� ���������� ����������. ��� ����, ������� �� ������������ ��� ���������� HTML-������:
//< table > � ���, ����������� ������� ��������� �������;
//< tr > � ��� ��� �������� ������ (����) �������, ������������ ��������� � <td> ��� <th>;
//< td > � ��� ������� ������ �������;
//< th > � ��� ������-��������� �������;
//< col > � ���, ����������� ������� ������� ��� �������;
//< colgroup > � ���, ������� ���������� �������;
//< thead > � ��� ��� �������� ����������� �������;
//< tbody > � ��� �������� ����� �������;
//< tfoot > � ��� ��� ������� ����������� �������;
//< caption > � ����������� ���� ���, ����� ������ ����� ��������� ��� �������;
//colspan � ���������� ���������� ����� � ������ ��� ����������� �� �����������;
//rowspan � ���������� ���������� ����� � ������� ��� ����������� �� ���������;
//span � ���������� �������, ������������ ��� ������� ������� �����, �� ��������� ����� 1;
//border � ������ ������ ������� � ��������, �� ���������: 0 � � ����� ������ ������� ������� �� �����;
//cellpadding � ������ �� ������ ����� �� �� �����������;
//cellspacing � ������ ����� ��������� �����
//����� �������� ���������� �������, ����������� CSS-����� � � �� ������� ����� ��� ��������� ������ ������� ������,
//��� � ������ ���� ����, ������ � ����� ������.
//�������� HTML-������� � ��� ���� ���������� �����.
//������� � ����������� � �������� ��������� � ���������������� �� ���������� ��������.
//� ����������� �������� ������� �� ����� �������� � ��� ������� �������.