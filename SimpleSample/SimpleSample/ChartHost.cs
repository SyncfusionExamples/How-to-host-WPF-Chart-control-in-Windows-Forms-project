using System.ComponentModel.Design.Serialization;
using System.ComponentModel;
using WindowsFormsControlLibrary;

namespace SimpleSample
{
    [Designer("System.Windows.Forms.Design.ControlDesigner, System.Design")]
    [DesignerSerializer("System.ComponentModel.Design.Serialization.TypeCodeDomSerializer , System.Design", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design")]
    public class ChartHost : System.Windows.Forms.Integration.ElementHost
    {
        protected SfChartControl m_WPFSfChart = new();
        public ChartHost()
        {
            base.Child = m_WPFSfChart;
        }
    }
}
