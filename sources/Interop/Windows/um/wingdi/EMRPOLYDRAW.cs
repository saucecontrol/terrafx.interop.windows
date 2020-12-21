// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct EMRPOLYDRAW
    {
        public EMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint cptl;

        [NativeTypeName("POINTL [1]")]
        public _aptl_e__FixedBuffer aptl;

        [NativeTypeName("BYTE [1]")]
        public fixed byte abTypes[1];

        public partial struct _aptl_e__FixedBuffer
        {
            public POINTL e0;

            public unsafe ref POINTL this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<POINTL> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<POINTL>((POINTL*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
