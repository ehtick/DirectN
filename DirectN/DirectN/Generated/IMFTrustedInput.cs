﻿// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("542612c4-a1b8-4632-b521-de11ea64a0b0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTrustedInput
    {
        [PreserveSig]
        HRESULT GetInputTrustAuthority(/* [in] */ uint dwStreamID, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppunkObject);
    }
}
