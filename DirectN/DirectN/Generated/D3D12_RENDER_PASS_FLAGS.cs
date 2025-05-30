﻿// generated from <Windows SDK Path>\um\d3d12.h
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12_RENDER_PASS_FLAGS
    {
        D3D12_RENDER_PASS_FLAG_NONE = 0x00000000,
        D3D12_RENDER_PASS_FLAG_ALLOW_UAV_WRITES = 0x00000001,
        D3D12_RENDER_PASS_FLAG_SUSPENDING_PASS = 0x00000002,
        D3D12_RENDER_PASS_FLAG_RESUMING_PASS = 0x00000004,
        D3D12_RENDER_PASS_FLAG_BIND_READ_ONLY_DEPTH = 0x00000008,
        D3D12_RENDER_PASS_FLAG_BIND_READ_ONLY_STENCIL = 0x00000010,
    }
}
