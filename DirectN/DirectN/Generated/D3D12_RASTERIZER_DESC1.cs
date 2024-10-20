﻿// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RASTERIZER_DESC1
    {
        public D3D12_FILL_MODE FillMode;
        public D3D12_CULL_MODE CullMode;
        public bool FrontCounterClockwise;
        public float DepthBias;
        public float DepthBiasClamp;
        public float SlopeScaledDepthBias;
        public bool DepthClipEnable;
        public bool MultisampleEnable;
        public bool AntialiasedLineEnable;
        public uint ForcedSampleCount;
        public D3D12_CONSERVATIVE_RASTERIZATION_MODE ConservativeRaster;
    }
}
