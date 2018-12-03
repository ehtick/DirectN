﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(4642,1)
using System;
using System.Runtime.InteropServices;
using RECT = DirectN.tagRECT;

namespace DirectN
{
    [Guid("7d97dbf7-e085-42d4-81e3-6a883bded118"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteGlyphRunAnalysis
    {
        [PreserveSig]
        HRESULT GetAlphaTextureBounds(DWRITE_TEXTURE_TYPE textureType, /* _Out_ */ out RECT textureBounds);
        
        [PreserveSig]
        HRESULT CreateAlphaTexture(DWRITE_TEXTURE_TYPE textureType, /* _In_ */ ref RECT textureBounds, /* _Out_writes_bytes_(bufferSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] alphaValues, uint bufferSize);
        
        [PreserveSig]
        HRESULT GetAlphaBlendParams(/* _In_ */ IDWriteRenderingParams renderingParams, /* _Out_ */ out float blendGamma, /* _Out_ */ out float blendEnhancedContrast, /* _Out_ */ out float blendClearTypeLevel);
    }
}