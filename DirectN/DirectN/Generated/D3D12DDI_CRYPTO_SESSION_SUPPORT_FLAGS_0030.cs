﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(8778,9)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12DDI_CRYPTO_SESSION_SUPPORT_FLAGS_0030
    {
        D3D12DDI_CRYPTO_SESSION_SUPPORT_FLAG_0030_NONE = 0x00000000,
        D3D12DDI_CRYPTO_SESSION_SUPPORT_FLAG_0030_SUPPORTED = 0x00000001,
        D3D12DDI_CRYPTO_SESSION_SUPPORT_FLAG_0030_HEADER_DECRYPTION_REQUIRED = 0x00000002,
        D3D12DDI_CRYPTO_SESSION_SUPPORT_FLAG_0030_INDEPENDENT_DECRYPTION_REQUIRED = 0x00000004,
        D3D12DDI_CRYPTO_SESSION_SUPPORT_FLAG_0030_TRANSCRYPTION_REQUIRED = 0x00000010,
    }
}