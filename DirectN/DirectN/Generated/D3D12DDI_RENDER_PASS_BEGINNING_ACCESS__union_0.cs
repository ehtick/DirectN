﻿// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RENDER_PASS_BEGINNING_ACCESS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS Clear {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS>(__bits, 0, 160);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[20]; InteropRuntime.Set<D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS>(value, __bits, 0, 160); } }
        public D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_RESUME_LOCAL_READ_PARAMETERS ResumeLocalRead {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_RESUME_LOCAL_READ_PARAMETERS>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[20]; InteropRuntime.Set<D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_RESUME_LOCAL_READ_PARAMETERS>(value, __bits, 0, 64); } }
    }
}
