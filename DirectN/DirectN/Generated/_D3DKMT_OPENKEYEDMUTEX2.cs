﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(3463,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OPENKEYEDMUTEX2
    {
        public uint hSharedHandle;
        public uint hKeyedMutex;
        public IntPtr pPrivateRuntimeData;
        public uint PrivateRuntimeDataSize;
    }
}
