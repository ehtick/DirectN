﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawint.h(1989,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_DESTROYDDLOCALDATA
    {
        public uint dwFlags;
        public IntPtr pDDLcl;
        public HRESULT ddRVal;
    }
}
