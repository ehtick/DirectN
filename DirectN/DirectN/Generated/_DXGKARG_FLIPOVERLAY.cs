﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_FLIPOVERLAY
    {
        public IntPtr hSource;
        public long SrcPhysicalAddress;
        public uint SrcSegmentId;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
    }
}
