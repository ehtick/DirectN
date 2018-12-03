﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wincodec.h(3446,5)
using System;
using System.Runtime.InteropServices;
using WICPixelFormatGUID = System.Guid;

namespace DirectN
{
    [Guid("00000105-a8f2-4877-ba0a-fd2b6645fb94"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICBitmapFrameEncode
    {
        [PreserveSig]
        HRESULT Initialize(/* optional(IPropertyBag2) */ IntPtr pIEncoderOptions);
        
        [PreserveSig]
        HRESULT SetSize(/* [in] */ uint uiWidth, /* [in] */ uint uiHeight);
        
        [PreserveSig]
        HRESULT SetResolution(/* [in] */ double dpiX, /* [in] */ double dpiY);
        
        [PreserveSig]
        HRESULT SetPixelFormat(/* [out][in] __RPC__inout */ ref WICPixelFormatGUID pPixelFormat);
        
        [PreserveSig]
        HRESULT SetColorContexts(/* [in] */ uint cCount, /* [size_is][in] __RPC__in_ecount_full(cCount) */ out IntPtr ppIColorContext);
        
        [PreserveSig]
        HRESULT SetPalette(/* [in] __RPC__in_opt */ IWICPalette pIPalette);
        
        [PreserveSig]
        HRESULT SetThumbnail(/* [in] __RPC__in_opt */ IWICBitmapSource pIThumbnail);
        
        [PreserveSig]
        HRESULT WritePixels(/* [in] */ uint lineCount, /* [in] */ uint cbStride, /* [in] */ uint cbBufferSize, /* [size_is][in] __RPC__in_ecount_full(cbBufferSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pbPixels);
        
        [PreserveSig]
        HRESULT WriteSource(/* [in] __RPC__in_opt */ IWICBitmapSource pIBitmapSource, /* optional(WICRect) */ IntPtr prc);
        
        [PreserveSig]
        HRESULT Commit();
        
        [PreserveSig]
        HRESULT GetMetadataQueryWriter(/* [out] __RPC__deref_out_opt */ out IWICMetadataQueryWriter ppIMetadataQueryWriter);
    }
}