﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(2242,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDSURFACEDESC__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint dwMipMapCount => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dwZBufferBitDepth => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dwRefreshRate => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}