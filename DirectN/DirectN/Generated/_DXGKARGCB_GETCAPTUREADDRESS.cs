﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_GETCAPTUREADDRESS
    {
        public uint hAllocation;
        public uint SegmentId;
        public long PhysicalAddress;
    }
}
