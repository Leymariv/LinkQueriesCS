using System;
using System.Windows.Forms;
using MyProjects.LinkStart.View;

namespace LinqWinformProject.LinkStart
{
    public static class ProgramLinq
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LinkQueriesForm());
        }
    }
}