﻿// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VIDMEM__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr lpHeap {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public uint dwHeight {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
