﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(12513,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO
    {
        public ulong ResultDataMaxSizeInBytes;
        public ulong ScratchDataSizeInBytes;
        public ulong UpdateScratchDataSizeInBytes;
    }
}
