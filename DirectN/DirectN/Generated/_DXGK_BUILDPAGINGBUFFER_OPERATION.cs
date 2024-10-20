﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
namespace DirectN
{
    public enum _DXGK_BUILDPAGINGBUFFER_OPERATION
    {
        DXGK_OPERATION_TRANSFER = 0,
        DXGK_OPERATION_FILL = 1,
        DXGK_OPERATION_DISCARD_CONTENT = 2,
        DXGK_OPERATION_READ_PHYSICAL = 3,
        DXGK_OPERATION_WRITE_PHYSICAL = 4,
        DXGK_OPERATION_MAP_APERTURE_SEGMENT = 5,
        DXGK_OPERATION_UNMAP_APERTURE_SEGMENT = 6,
        DXGK_OPERATION_SPECIAL_LOCK_TRANSFER = 7,
        DXGK_OPERATION_VIRTUAL_TRANSFER = 8,
        DXGK_OPERATION_VIRTUAL_FILL = 9,
        DXGK_OPERATION_INIT_CONTEXT_RESOURCE = 10,
        DXGK_OPERATION_UPDATE_PAGE_TABLE = 11,
        DXGK_OPERATION_FLUSH_TLB = 12,
        DXGK_OPERATION_UPDATE_CONTEXT_ALLOCATION = 13,
        DXGK_OPERATION_COPY_PAGE_TABLE_ENTRIES = 14,
        DXGK_OPERATION_NOTIFY_RESIDENCY = 15,
        DXGK_OPERATION_SIGNAL_MONITORED_FENCE = 16,
        DXGK_OPERATION_MAP_APERTURE_SEGMENT2 = 17,
        DXGK_OPERATION_NOTIFY_FENCE_RESIDENCY = 18,
        DXGK_OPERATION_MAP_MMU = 19,
        DXGK_OPERATION_UNMAP_MMU = 20,
        DXGK_OPERATION_NOTIFY_RESIDENCY2 = 21,
        DXGK_OPERATION_NOTIFY_ALLOC = 22,
    }
}
