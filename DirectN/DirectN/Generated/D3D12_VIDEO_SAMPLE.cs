﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12video.h(227,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_SAMPLE
    {
        public uint Width;
        public uint Height;
        public D3D12_VIDEO_FORMAT Format;
    }
}
