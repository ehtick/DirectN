﻿// generated from <Windows SDK Path>\um\dxvahd.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_BLT_STATE_OUTPUT_COLOR_SPACE_DATA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXVAHD_BLT_STATE_OUTPUT_COLOR_SPACE_DATA__union_0__struct_0 __field_0 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXVAHD_BLT_STATE_OUTPUT_COLOR_SPACE_DATA__union_0__struct_0>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXVAHD_BLT_STATE_OUTPUT_COLOR_SPACE_DATA__union_0__struct_0>(value, __bits, 0, 32); } }
        public uint Value {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
