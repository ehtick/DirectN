﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(823,3)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_MBctrl_H264__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public _DXVA_MBctrl_H264__union_0__struct_0 __field_0 => InteropRuntime.Get<_DXVA_MBctrl_H264__union_0__struct_0>(__bits, 0, 32);
        public uint dwMBtype => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}