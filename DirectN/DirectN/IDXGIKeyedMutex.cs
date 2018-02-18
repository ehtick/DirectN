﻿using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9d8e1289-d7b3-465f-8126-250e349af85d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIKeyedMutex : IDXGIDeviceSubObject
    {
        // IDXGIObject
        [PreserveSig]
        new HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, int DataSize, IntPtr pData);

        [PreserveSig]
        new HRESULT SetPrivateDataInterface([MarshalAs(UnmanagedType.LPStruct)] Guid Name, [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);

        [PreserveSig]
        new HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, out int pDataSize, IntPtr pData);

        [PreserveSig]
        new HRESULT GetParent([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppParent);

        // IDXGIDeviceSubObject
        [PreserveSig]
        new int GetDevice([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppDevice);

        // IDXGIKeyedMutex
        [PreserveSig]
        HRESULT AcquireSync(long Key, int dwMilliseconds);

        [PreserveSig]
        HRESULT ReleaseSync(long Key);
    }
}
