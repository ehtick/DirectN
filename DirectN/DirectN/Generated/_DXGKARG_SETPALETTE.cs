﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(1426,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETPALETTE
    {
        public uint VidPnSourceId;
        public uint FirstEntry;
        public uint NumEntries;
        public IntPtr pLookupTable;
    }
}
