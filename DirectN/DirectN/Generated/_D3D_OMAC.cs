﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3d9types.h(2067,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3D_OMAC
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] Omac;
    }
}
