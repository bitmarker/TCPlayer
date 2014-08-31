using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.Bitmarker.Target.Serial
{
    public interface ISerialTarget
    {
        SerialPort GetSerialPort();
    }
}
