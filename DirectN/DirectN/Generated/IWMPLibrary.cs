﻿// generated from <Windows SDK Path>\um\wmp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3df47861-7df1-4c1f-a81b-4c26f0f7a7c6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPLibrary
    {
        [PreserveSig]
        HRESULT get_name(/* [retval][out] */ out IntPtr pbstrName);
        
        [PreserveSig]
        HRESULT get_type(/* [retval][out] */ out WMPLibraryType pwmplt);
        
        [PreserveSig]
        HRESULT get_mediaCollection(/* [retval][out] */ out IWMPMediaCollection ppIWMPMediaCollection);
        
        [PreserveSig]
        HRESULT isIdentical(/* [in] */ IWMPLibrary pIWMPLibrary, /* [retval][out] */ out bool pvbool);
    }
}
