﻿// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using LPDDRAWI_DDRAWPALETTE_INT = DirectN._DDRAWI_DDRAWPALETTE_INT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWSURFACE_LCL__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr lpDDPalette {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public IntPtr lp16DDPalette {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
    }
}
