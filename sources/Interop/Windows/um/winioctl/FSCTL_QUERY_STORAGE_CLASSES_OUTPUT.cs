// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct FSCTL_QUERY_STORAGE_CLASSES_OUTPUT
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint TotalNumberOfTiers;

        [NativeTypeName("DWORD")]
        public uint NumberOfTiersReturned;

        [NativeTypeName("FILE_STORAGE_TIER [1]")]
        public _Tiers_e__FixedBuffer Tiers;

        public partial struct _Tiers_e__FixedBuffer
        {
            public FILE_STORAGE_TIER e0;

            public unsafe ref FILE_STORAGE_TIER this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<FILE_STORAGE_TIER> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<FILE_STORAGE_TIER>((FILE_STORAGE_TIER*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
