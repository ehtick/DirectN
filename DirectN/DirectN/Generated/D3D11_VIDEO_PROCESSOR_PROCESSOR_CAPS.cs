﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(9998,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS
    {
        D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BLEND = 0x00000001,
        D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BOB = 0x00000002,
        D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_ADAPTIVE = 0x00000004,
        D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_MOTION_COMPENSATION = 0x00000008,
        D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_INVERSE_TELECINE = 0x00000010,
        D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_FRAME_RATE_CONVERSION = 0x00000020,
    }
}
