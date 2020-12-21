// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct TITLEBARINFOEX
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public RECT rcTitleBar;

        [NativeTypeName("DWORD [6]")]
        public fixed uint rgstate[6];

        [NativeTypeName("RECT [6]")]
        public _rgrect_e__FixedBuffer rgrect;

        public partial struct _rgrect_e__FixedBuffer
        {
            public RECT e0;
            public RECT e1;
            public RECT e2;
            public RECT e3;
            public RECT e4;
            public RECT e5;

            public unsafe ref RECT this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<RECT> AsSpan()
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, 6);
#else
                return new Span<RECT>((RECT*)Unsafe.AsPointer(ref this), 6);
#endif
            }
        }
    }
}
