// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct wireSAFEARRAY
    {
        [NativeTypeName("USHORT")]
        public ushort cDims;

        [NativeTypeName("USHORT")]
        public ushort fFeatures;

        [NativeTypeName("ULONG")]
        public uint cbElements;

        [NativeTypeName("ULONG")]
        public uint cLocks;

        public SAFEARRAYUNION uArrayStructs;

        [NativeTypeName("SAFEARRAYBOUND [1]")]
        public _rgsabound_e__FixedBuffer rgsabound;

        public partial struct _rgsabound_e__FixedBuffer
        {
            public SAFEARRAYBOUND e0;

            public unsafe ref SAFEARRAYBOUND this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<SAFEARRAYBOUND> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<SAFEARRAYBOUND>((SAFEARRAYBOUND*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
