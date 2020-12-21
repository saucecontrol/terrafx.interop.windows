// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct READ_ELEMENT_ADDRESS_INFO
    {
        [NativeTypeName("DWORD")]
        public uint NumberOfElements;

        [NativeTypeName("CHANGER_ELEMENT_STATUS [1]")]
        public _ElementStatus_e__FixedBuffer ElementStatus;

        public partial struct _ElementStatus_e__FixedBuffer
        {
            public CHANGER_ELEMENT_STATUS e0;

            public unsafe ref CHANGER_ELEMENT_STATUS this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<CHANGER_ELEMENT_STATUS> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<CHANGER_ELEMENT_STATUS>((CHANGER_ELEMENT_STATUS*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
