﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dhal.h(1120,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_DP2UPDATEPALETTE
    {
        public uint dwPaletteHandle;
        public ushort wStartIndex;
        public ushort wNumEntries;
    }
}
