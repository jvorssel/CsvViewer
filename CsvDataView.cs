using System.Windows.Forms;

namespace CsvViewer
{
    public  class CsvDataView : DataGridView
    {
        public CsvDataView()
        {
            if (!SystemInformation.TerminalServerSession)
                DoubleBuffered = true;
        }
    }
}
