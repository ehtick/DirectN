﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva2api.h(600,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA2_AES_CTR_IV
    {
        public ulong IV;
        public ulong Count;
    }
}
