﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfreadwrite.h(290,1)
using System;

namespace DirectN
{
    [Flags]
    public enum MF_SOURCE_READER_FLAG
    {
        MF_SOURCE_READERF_ERROR = 0x00000001,
        MF_SOURCE_READERF_ENDOFSTREAM = 0x00000002,
        MF_SOURCE_READERF_NEWSTREAM = 0x00000004,
        MF_SOURCE_READERF_NATIVEMEDIATYPECHANGED = 0x00000010,
        MF_SOURCE_READERF_CURRENTMEDIATYPECHANGED = 0x00000020,
        MF_SOURCE_READERF_STREAMTICK = 0x00000100,
        MF_SOURCE_READERF_ALLEFFECTSREMOVED = 0x00000200,
    }
}
