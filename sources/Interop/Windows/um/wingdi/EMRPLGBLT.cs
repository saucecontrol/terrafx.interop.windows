// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct EMRPLGBLT
    {
        public EMR emr;

        public RECTL rclBounds;

        [NativeTypeName("POINTL [3]")]
        public _aptlDest_e__FixedBuffer aptlDest;

        [NativeTypeName("LONG")]
        public int xSrc;

        [NativeTypeName("LONG")]
        public int ySrc;

        [NativeTypeName("LONG")]
        public int cxSrc;

        [NativeTypeName("LONG")]
        public int cySrc;

        public XFORM xformSrc;

        [NativeTypeName("COLORREF")]
        public uint crBkColorSrc;

        [NativeTypeName("DWORD")]
        public uint iUsageSrc;

        [NativeTypeName("DWORD")]
        public uint offBmiSrc;

        [NativeTypeName("DWORD")]
        public uint cbBmiSrc;

        [NativeTypeName("DWORD")]
        public uint offBitsSrc;

        [NativeTypeName("DWORD")]
        public uint cbBitsSrc;

        [NativeTypeName("LONG")]
        public int xMask;

        [NativeTypeName("LONG")]
        public int yMask;

        [NativeTypeName("DWORD")]
        public uint iUsageMask;

        [NativeTypeName("DWORD")]
        public uint offBmiMask;

        [NativeTypeName("DWORD")]
        public uint cbBmiMask;

        [NativeTypeName("DWORD")]
        public uint offBitsMask;

        [NativeTypeName("DWORD")]
        public uint cbBitsMask;

        public partial struct _aptlDest_e__FixedBuffer
        {
            public POINTL e0;
            public POINTL e1;
            public POINTL e2;

            public unsafe ref POINTL this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<POINTL> AsSpan()
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, 3);
#else
                return new Span<POINTL>((POINTL*)Unsafe.AsPointer(ref this), 3);
#endif
            }
        }
    }
}
