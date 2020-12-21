// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct VOLUME_DISK_EXTENTS
    {
        [NativeTypeName("DWORD")]
        public uint NumberOfDiskExtents;

        [NativeTypeName("DISK_EXTENT [1]")]
        public _Extents_e__FixedBuffer Extents;

        public partial struct _Extents_e__FixedBuffer
        {
            public DISK_EXTENT e0;

            public unsafe ref DISK_EXTENT this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<DISK_EXTENT> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<DISK_EXTENT>((DISK_EXTENT*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
