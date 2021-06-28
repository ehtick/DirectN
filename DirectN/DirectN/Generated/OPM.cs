﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ksopmapi.h(59,1)
using System;

namespace DirectN
{
    [Flags]
    public enum OPM
    {
        OPM_OMAC_SIZE = 0x00000010,
        OPM_128_BIT_RANDOM_NUMBER_SIZE = 0x00000010,
        OPM_ENCRYPTED_INITIALIZATION_PARAMETERS_SIZE = 0x00000100,
        OPM_CONFIGURE_SETTING_DATA_SIZE = 0x00000FD8,
        OPM_GET_INFORMATION_PARAMETERS_SIZE = 0x00000FD8,
        OPM_REQUESTED_INFORMATION_SIZE = 0x00000FEC,
        OPM_HDCP_KEY_SELECTION_VECTOR_SIZE = 0x00000005,
        OPM_PROTECTION_TYPE_SIZE = 0x00000004,
        OPM_BUS_TYPE_MASK = 0x0000FFFF,
        OPM_BUS_IMPLEMENTATION_MODIFIER_MASK = 0x00007FFF,
    }
}
