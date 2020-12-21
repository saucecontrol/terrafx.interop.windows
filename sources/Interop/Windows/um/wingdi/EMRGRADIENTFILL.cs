// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct EMRGRADIENTFILL
    {
        public EMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint nVer;

        [NativeTypeName("DWORD")]
        public uint nTri;

        [NativeTypeName("ULONG")]
        public uint ulMode;

        [NativeTypeName("TRIVERTEX [1]")]
        public _Ver_e__FixedBuffer Ver;

        public partial struct _Ver_e__FixedBuffer
        {
            public TRIVERTEX e0;

            public unsafe ref TRIVERTEX this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<TRIVERTEX> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<TRIVERTEX>((TRIVERTEX*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
