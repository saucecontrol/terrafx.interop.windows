// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct DEVICEDUMP_STORAGESTACK_PUBLIC_DUMP
    {
        public DEVICEDUMP_STRUCTURE_VERSION Descriptor;

        [NativeTypeName("DWORD")]
        public uint dwReasonForCollection;

        [NativeTypeName("BYTE [16]")]
        public fixed byte cDriverName[16];

        [NativeTypeName("DWORD")]
        public uint uiNumRecords;

        [NativeTypeName("DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD [1]")]
        public _RecordArray_e__FixedBuffer RecordArray;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _RecordArray_e__FixedBuffer
        {
            public DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD e0;

            public unsafe ref DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD>((DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
