﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(7433,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT
    {
        public uint MaxGPUVirtualAddressBitsPerResource;
        public uint MaxGPUVirtualAddressBitsPerProcess;
    }
}
