﻿// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DEVICE_CONFIGURATION_DESC
    {
        public D3D12_DEVICE_FLAGS Flags;
        public uint GpuBasedValidationFlags;
        public uint SDKVersion;
        public uint NumEnabledExperimentalFeatures;
    }
}
