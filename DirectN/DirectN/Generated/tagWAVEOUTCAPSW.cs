﻿// generated from <Windows SDK Path>\um\mmeapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct tagWAVEOUTCAPSW
    {
        public ushort wMid;
        public ushort wPid;
        public uint vDriverVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string szPname;
        public uint dwFormats;
        public ushort wChannels;
        public ushort wReserved1;
        public uint dwSupport;
    }
}
