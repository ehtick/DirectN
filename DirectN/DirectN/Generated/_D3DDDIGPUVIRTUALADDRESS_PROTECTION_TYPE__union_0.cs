﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1355,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIGPUVIRTUALADDRESS_PROTECTION_TYPE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public _D3DDDIGPUVIRTUALADDRESS_PROTECTION_TYPE__union_0__struct_0 __field_0 => InteropRuntime.Get<_D3DDDIGPUVIRTUALADDRESS_PROTECTION_TYPE__union_0__struct_0>(__bits, 0, 64);
        public ulong Value => InteropRuntime.GetUInt6s(__bits, 0, 64);
    }
}