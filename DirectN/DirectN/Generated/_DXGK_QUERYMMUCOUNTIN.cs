﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_QUERYMMUCOUNTIN
    {
        public ushort PhysicalAdapterIndex;
        public ushort Padding;
        public uint Reserved;
    }
}
