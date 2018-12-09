﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmp.h(4518,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0e6b01d1-d407-4c85-bf5f-1c01f6150280"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPPlayer2 : IWMPCore
    {
        // IWMPCore
        [PreserveSig]
        new HRESULT close();
        
        [PreserveSig]
        new HRESULT get_URL(/* [retval][out] */ out IntPtr pbstrURL);
        
        [PreserveSig]
        new HRESULT put_URL(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrURL);
        
        [PreserveSig]
        new HRESULT get_openState(/* [retval][out] */ out WMPOpenState pwmpos);
        
        [PreserveSig]
        new HRESULT get_playState(/* [retval][out] */ out WMPPlayState pwmpps);
        
        [PreserveSig]
        new HRESULT get_controls(/* [retval][out] */ out IWMPControls ppControl);
        
        [PreserveSig]
        new HRESULT get_settings(/* [retval][out] */ out IWMPSettings ppSettings);
        
        [PreserveSig]
        new HRESULT get_currentMedia(/* [retval][out] */ out IWMPMedia ppMedia);
        
        [PreserveSig]
        new HRESULT put_currentMedia(/* [in] */ IWMPMedia pMedia);
        
        [PreserveSig]
        new HRESULT get_mediaCollection(/* [retval][out] */ out IWMPMediaCollection ppMediaCollection);
        
        [PreserveSig]
        new HRESULT get_playlistCollection(/* [retval][out] */ out IWMPPlaylistCollection ppPlaylistCollection);
        
        [PreserveSig]
        new HRESULT get_versionInfo(/* [retval][out] */ out IntPtr pbstrVersionInfo);
        
        [PreserveSig]
        new HRESULT launchURL(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrURL);
        
        [PreserveSig]
        new HRESULT get_network(/* [retval][out] */ out IWMPNetwork ppQNI);
        
        [PreserveSig]
        new HRESULT get_currentPlaylist(/* [retval][out] */ out IWMPPlaylist ppPL);
        
        [PreserveSig]
        new HRESULT put_currentPlaylist(/* [in] */ IWMPPlaylist pPL);
        
        [PreserveSig]
        new HRESULT get_cdromCollection(/* [retval][out] */ out IWMPCdromCollection ppCdromCollection);
        
        [PreserveSig]
        new HRESULT get_closedCaption(/* [retval][out] */ out IWMPClosedCaption ppClosedCaption);
        
        [PreserveSig]
        new HRESULT get_isOnline(/* [retval][out] */ out VARIANT_BOOL pfOnline);
        
        [PreserveSig]
        new HRESULT get_error(/* [retval][out] */ out IWMPError ppError);
        
        [PreserveSig]
        new HRESULT get_status(/* [retval][out] */ out IntPtr pbstrStatus);
        
        // IWMPPlayer2
        [PreserveSig]
        HRESULT get_enabled(/* [retval][out] */ out VARIANT_BOOL pbEnabled);
        
        [PreserveSig]
        HRESULT put_enabled(/* [in] */ short bEnabled);
        
        [PreserveSig]
        HRESULT get_fullScreen(/* [retval][out] */ out VARIANT_BOOL pbFullScreen);
        
        [PreserveSig]
        HRESULT put_fullScreen(short bFullScreen);
        
        [PreserveSig]
        HRESULT get_enableContextMenu(/* [retval][out] */ out VARIANT_BOOL pbEnableContextMenu);
        
        [PreserveSig]
        HRESULT put_enableContextMenu(short bEnableContextMenu);
        
        [PreserveSig]
        HRESULT put_uiMode(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrMode);
        
        [PreserveSig]
        HRESULT get_uiMode(/* [retval][out] */ out IntPtr pbstrMode);
        
        [PreserveSig]
        HRESULT get_stretchToFit(/* [retval][out] */ out VARIANT_BOOL pbEnabled);
        
        [PreserveSig]
        HRESULT put_stretchToFit(/* [in] */ short bEnabled);
        
        [PreserveSig]
        HRESULT get_windowlessVideo(/* [retval][out] */ out VARIANT_BOOL pbEnabled);
        
        [PreserveSig]
        HRESULT put_windowlessVideo(/* [in] */ short bEnabled);
    }
}