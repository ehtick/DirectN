﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(10980,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_AUTHENTICATED_CONFIGURE_PROTECTION_INPUT
    {
        public D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;
        public D3D11_AUTHENTICATED_PROTECTION_FLAGS Protections;
    }
}
