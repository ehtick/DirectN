﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(2732,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_REQUEST_MACHINE_CRASH_ESCAPE
    {
        public IntPtr Param1;
        public IntPtr Param2;
        public IntPtr Param3;
    }
}
