﻿#region Copyright (c) 2014 Leonid Lezner. All rights reserved.
// Copyright (C) 2013-2014 Leonid Lezner
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCPlayer.API.Target;

namespace De.Bitmarker.Target.Serial
{
    public class Target : ITarget, ISerialTarget
    {
        private SerialPort _serial;

        public void Connect(TCPlayer.API.IProgressEx Progress)
        {
            _serial.PortName = PluginHost.GetProperty("Port", "COM1");
            _serial.BaudRate = PluginHost.GetProperty<int>("Baud", 9600);
            _serial.Open();
        }

        public void Disconnect(TCPlayer.API.IProgressEx Progress)
        {
            _serial.Close();
        }

        public bool IsConnected()
        {
            return _serial.IsOpen;
        }

        public string ReadableAddress
        {
            get { return _serial.PortName + "@" + _serial.BaudRate.ToString() + " baud"; }
        }

        public string Ident
        {
            get { return "De.Bitmarker.Target.Serial"; }
        }

        public void LoadPlugin(TCPlayer.API.IProgressEx Progress)
        {
            _serial = new SerialPort();
        }

        public TCPlayer.API.Components.IComponentHost PluginHost
        {
            get;
            set;
        }

        public void UnloadPlugin(TCPlayer.API.IProgressEx Progress)
        {
            
        }

        public SerialPort GetSerialPort()
        {
            return _serial;
        }
    }
}
