﻿// generated from <Windows SDK Path>\um\dwrite.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Shaping output properties per input character.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_SHAPING_TEXT_PROPERTIES
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        /// <summary>
        /// This character can be shaped independently from the others (usually set for the space character).
        /// </summary>
        public ushort isShapedAlone {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 0, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 0, 1); } }
        /// <summary>
        /// Reserved for use by shaping engine.
        /// </summary>
        public ushort reserved1 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 1, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 1, 1); } }
        /// <summary>
        /// Glyph shaping can be cut after this point without affecting shaping before or after it. Otherwise, splitting a call to GetGlyphs would cause a reflow of glyph advances and shapes.
        /// </summary>
        public ushort canBreakShapingAfter {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 2, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 2, 1); } }
        /// <summary>
        /// Reserved for use by shaping engine.
        /// </summary>
        public ushort reserved {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 3, 13);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 3, 13); } }
    }
}
