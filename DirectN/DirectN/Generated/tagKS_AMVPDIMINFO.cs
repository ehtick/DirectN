﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(7500,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_AMVPDIMINFO
    {
        public uint dwFieldWidth;
        public uint dwFieldHeight;
        public uint dwVBIWidth;
        public uint dwVBIHeight;
        public tagRECT rcValidRegion;
    }
}
