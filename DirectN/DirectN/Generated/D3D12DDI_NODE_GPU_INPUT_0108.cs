﻿// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_NODE_GPU_INPUT_0108
    {
        public uint EntrypointIndex;
        public uint NumRecords;
        public D3D12DDI_GPU_VIRTUAL_ADDRESS_AND_STRIDE Records;
    }
}
