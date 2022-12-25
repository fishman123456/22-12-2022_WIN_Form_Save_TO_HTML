using System.Drawing;

namespace _22_12_2022_WIN_Form_Save_TO_HTML
{
    public partial class Form1 : Form
    {
        string htmlS;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файл браузера (*.html)|*.html|Все файлы (*.*)|*.*";
            //string fProg = "  < body class = "content"> <table class="table1" border="1" cellspacing="0" cellpadding="1"><tr><td class = "td1" valign="top" align="center"><p class = "t0"> <font size = "6" >";

            //string fProg = "  < body > <table> {border: 1px dashed grey;} <tr><td><p>";
            //string fProg2 = " </tr></table><p><font size = \"5\"></body></html> ";
          string style = "<style> {width:2600px; height:2339px; } table {border: 1px dashed grey;}td {border: 1px solid grey;} </style >";
            string body = "<table> <tbody>   <tr>  ";  /* 1.6em = 16px */
            string body2 = "Моя первая таблица </p>";
            string body3 = " </tr></tbody> </table>";
            List<string> list = new List<string>();

            List<string> t = new List<string>(textBox1.Text.Split(new String[] { "\n" }, StringSplitOptions.RemoveEmptyEntries));

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(style+body);
                foreach (string item in t)
                {
                   // streamWriter.WriteLine( fProg+item + "</td>");
                    streamWriter.WriteLine("<td>"  + "<p>" +"<font size = 4>"+ item + "</font>"+ "</p>" + "</td>");
                   // streamWriter.WriteLine(item);
                    
                }
                streamWriter.WriteLine( body3);
                streamWriter.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      public  string htm() {
            return  htmlS = "<!DOCTYPE HTML> " +
                "<html>  " +
                "<head>  " +
                "<meta charset=\"utf-8\">" +
                "<title>наклейки</title>" +
                "<style> " +
                ".t0 " +
                "{" +
                "margin-top: 0.1em;" +
                "margin-bottom: 0.1em;" +
                "}" +
                ".t1 " +
                "{" +
                "transform: scale(-1);" +
                " margin-top: 0.1em;" +
                " margin-bottom: 1.5em;} " +
                ".content " +
                "{" +
                "width:1654px;" +
                "height:2339px;" +
                "margin:auto; " +
                "background-color:#FFFFFF;}" +
                ".td1 {width:260px; " +
                "height:140px; " +
                "border-bottom-style:dashed; " +
                "border-top-style:dashed; " +
                "border-left-style:dashed; " +
                "border-right-style:dashed;}" +
                ".table1 {border-bottom-style:none;" +
                " border-top-style:none;" +
                " border-left-style:none;" +
                " border-right-style:none;} " +
                "</style> " +
                "</head>";
        }
    }
}