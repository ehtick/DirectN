﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(1684,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGKMDT_OPM_GET_INFO_PARAMETERS
    {
        public _DXGKMDT_OPM_OMAC omac;
        public _DXGKMDT_OPM_RANDOM_NUMBER rnRandomNumber;
        public Guid guidInformation;
        public uint ulSequenceNumber;
        public uint cbParametersSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4056)] 
        public byte[] abParameters;
    }
}
