﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\mmreg.h(3000,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct g721_adpcmwaveformat_tag
    {
        public tWAVEFORMATEX wfx;
        public ushort nAuxBlockSize;
    }
}
