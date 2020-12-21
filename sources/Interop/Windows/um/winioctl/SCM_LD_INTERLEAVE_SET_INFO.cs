// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SCM_LD_INTERLEAVE_SET_INFO
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint InterleaveSetSize;

        [NativeTypeName("SCM_INTERLEAVED_PD_INFO [1]")]
        public _InterleaveSet_e__FixedBuffer InterleaveSet;

        public partial struct _InterleaveSet_e__FixedBuffer
        {
            public SCM_INTERLEAVED_PD_INFO e0;

            public unsafe ref SCM_INTERLEAVED_PD_INFO this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<SCM_INTERLEAVED_PD_INFO> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<SCM_INTERLEAVED_PD_INFO>((SCM_INTERLEAVED_PD_INFO*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
