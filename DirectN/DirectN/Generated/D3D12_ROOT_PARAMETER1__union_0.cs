﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(3450,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_ROOT_PARAMETER1__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_ROOT_DESCRIPTOR_TABLE1 DescriptorTable { get => InteropRuntime.Get<D3D12_ROOT_DESCRIPTOR_TABLE1>(__bits, 0, 384); set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<D3D12_ROOT_DESCRIPTOR_TABLE1>(value, __bits, 0, 384); } }
        public D3D12_ROOT_CONSTANTS Constants { get => InteropRuntime.Get<D3D12_ROOT_CONSTANTS>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<D3D12_ROOT_CONSTANTS>(value, __bits, 0, 96); } }
        public D3D12_ROOT_DESCRIPTOR1 Descriptor { get => InteropRuntime.Get<D3D12_ROOT_DESCRIPTOR1>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<D3D12_ROOT_DESCRIPTOR1>(value, __bits, 0, 96); } }
    }
}
