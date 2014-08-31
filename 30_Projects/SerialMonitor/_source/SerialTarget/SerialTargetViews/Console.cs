using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPlayer.API.Views;
using TCPlayer.API.Target;
using System.IO.Ports;

namespace De.Bitmarker.Target.Serial.Views
{
    public partial class Console : UserControl, IView
    {
        private IViewTimer _timer;
        private ITarget _target;
        private ISerialTarget _serialTarget;
        private SerialPort _serialPort;

        public Console()
        {
            InitializeComponent();
        }

        public string Ident
        {
            get { return "De.Bitmarker.Target.Serial.Views.Console"; }
        }

        public void LoadPlugin(TCPlayer.API.IProgressEx Progress)
        {
            _target = PluginHost.GetComponent<ITarget>();

            _serialTarget = (ISerialTarget)_target;

            _serialPort = _serialTarget.GetSerialPort();

            _timer = PluginHost.CreateTimer();
            
            _timer.Tick += _timer_Tick;

            _timer.Interval = 500;

            _timer.RunOnlyWhenOnline = false;
            _timer.RunOnlyWhenOnline = true;

            _timer.Start();
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            string data = _serialPort.ReadExisting();

            data = data.Replace("\n\r", "\r\n");

            serialOutput.AppendText(data);
        }

        public IViewHost PluginHost
        {
            get;
            set;
        }

        public void UnloadPlugin(TCPlayer.API.IProgressEx Progress)
        {

        }
    }
}
