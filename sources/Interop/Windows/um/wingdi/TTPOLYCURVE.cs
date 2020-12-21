// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct TTPOLYCURVE
    {
        [NativeTypeName("WORD")]
        public ushort wType;

        [NativeTypeName("WORD")]
        public ushort cpfx;

        [NativeTypeName("POINTFX [1]")]
        public _apfx_e__FixedBuffer apfx;

        public partial struct _apfx_e__FixedBuffer
        {
            public POINTFX e0;

            public unsafe ref POINTFX this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<POINTFX> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<POINTFX>((POINTFX*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
