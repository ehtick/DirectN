﻿// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ADJUSTFULLSCREENGAMMA
    {
        public uint hAdapter;
        public uint VidPnSourceId;
        public D3DDDI_DXGI_RGB Scale;
        public D3DDDI_DXGI_RGB Offset;
    }
}
