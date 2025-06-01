using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui2
{
    public class DesignableForm : BaseForm
    {
        //private readonly Label dummyPitch = new Label();
        //private readonly Label dummyRoll = new Label();

        protected override Label PitchLabel => new Label();
        protected override Label RollLabel => new Label();


        protected override string UdpIp => "";
        protected override int UdpPort => 0;
        protected override string SourceIp => "";
        protected override int SourcePort => 0;

        protected override (float, float) GetSensorData() => (0f, 0f);
    }
}