﻿// generated from <Windows SDK Path>\um\audioengineendpoint.h
using System;
using System.Runtime.InteropServices;
using boolean = System.Byte;

namespace DirectN
{
    [ComImport, Guid("dfe21355-5ec2-40e0-8d6b-710ac3c00249"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioEndpointOffloadStreamMute
    {
        [PreserveSig]
        HRESULT SetMute(/* [in] */ byte bMuted);
        
        [PreserveSig]
        HRESULT GetMute(/* [out] */ out boolean pbMuted);
    }
}
