﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1.h(861,9)
using System;

namespace DirectN
{
    [Flags]
    public enum D2D1_PRESENT_OPTIONS
    {
        D2D1_PRESENT_OPTIONS_NONE = 0x00000000,
        D2D1_PRESENT_OPTIONS_RETAIN_CONTENTS = 0x00000001,
        D2D1_PRESENT_OPTIONS_IMMEDIATELY = 0x00000002,
        D2D1_PRESENT_OPTIONS_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}