﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_0 DmaCompleted {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_0>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_0>(value, __bits, 0, 96); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_1 DmaPreempted {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_1>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_1>(value, __bits, 0, 128); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_2 DmaFaulted {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_2>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_2>(value, __bits, 0, 128); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_3 CrtcVsync {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_3>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_3>(value, __bits, 0, 192); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_4 DisplayOnlyVsync {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_4>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_4>(value, __bits, 0, 32); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_5 CrtcVsyncWithMultiPlaneOverlay {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_5>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_5>(value, __bits, 0, 192); } }
        public _DXGKARGCB_PRESENT_DISPLAYONLY_PROGRESS DisplayOnlyPresentProgress {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_PRESENT_DISPLAYONLY_PROGRESS>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_PRESENT_DISPLAYONLY_PROGRESS>(value, __bits, 0, 64); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_6 MiracastEncodeChunkCompleted {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_6>(__bits, 0, 384);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_6>(value, __bits, 0, 384); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_7 DmaPageFaulted {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_7>(__bits, 0, 512);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_7>(value, __bits, 0, 512); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_8 CrtcVsyncWithMultiPlaneOverlay2 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_8>(__bits, 0, 320);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_8>(value, __bits, 0, 320); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_9 MonitoredFenceSignaled {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_9>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_9>(value, __bits, 0, 64); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_10 HwContextListSwitchCompleted {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_10>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_10>(value, __bits, 0, 128); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_11 HwQueuePageFaulted {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_11>(__bits, 0, 512);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_11>(value, __bits, 0, 512); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_12 PeriodicMonitoredFenceSignaled {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_12>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_12>(value, __bits, 0, 64); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_13 SchedulingLogInterrupt {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_13>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_13>(value, __bits, 0, 64); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_14 GpuEngineTimeout {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_14>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_14>(value, __bits, 0, 64); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_15 SuspendContextCompleted {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_15>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_15>(value, __bits, 0, 128); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_16 CrtcVsyncWithMultiPlaneOverlay3 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_16>(__bits, 0, 320);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_16>(value, __bits, 0, 320); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_17 NativeFenceSignaled {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_17>(__bits, 0, 256);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_17>(value, __bits, 0, 256); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_18 EngineStateChange {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_18>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_18>(value, __bits, 0, 96); } }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_19 Reserved {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_19>(__bits, 0, 512);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_19>(value, __bits, 0, 512); } }
    }
}
