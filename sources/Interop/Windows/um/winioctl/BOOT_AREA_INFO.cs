// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct BOOT_AREA_INFO
    {
        [NativeTypeName("DWORD")]
        public uint BootSectorCount;

        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:13108:5) [2]")]
        public _BootSectors_e__FixedBuffer BootSectors;

        public partial struct _Anonymous_e__Struct
        {
            public LARGE_INTEGER Offset;
        }

        public partial struct _BootSectors_e__FixedBuffer
        {
            public _Anonymous_e__Struct e0;
            public _Anonymous_e__Struct e1;

            public unsafe ref _Anonymous_e__Struct this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<_Anonymous_e__Struct> AsSpan()
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, 2);
#else
                return new Span<_Anonymous_e__Struct>((_Anonymous_e__Struct*)Unsafe.AsPointer(ref this), 2);
#endif
            }
        }
    }
}
