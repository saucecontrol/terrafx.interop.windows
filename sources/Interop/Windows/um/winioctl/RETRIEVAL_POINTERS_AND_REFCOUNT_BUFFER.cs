// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct RETRIEVAL_POINTERS_AND_REFCOUNT_BUFFER
    {
        [NativeTypeName("DWORD")]
        public uint ExtentCount;

        public LARGE_INTEGER StartingVcn;

        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:10603:5) [1]")]
        public _Extents_e__FixedBuffer Extents;

        public partial struct _Anonymous_e__Struct
        {
            public LARGE_INTEGER NextVcn;

            public LARGE_INTEGER Lcn;

            [NativeTypeName("DWORD")]
            public uint ReferenceCount;
        }

        public partial struct _Extents_e__FixedBuffer
        {
            public _Anonymous_e__Struct e0;

            public unsafe ref _Anonymous_e__Struct this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<_Anonymous_e__Struct> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<_Anonymous_e__Struct>((_Anonymous_e__Struct*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
