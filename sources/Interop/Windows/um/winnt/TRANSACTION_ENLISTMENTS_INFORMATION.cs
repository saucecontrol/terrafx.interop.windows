// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct TRANSACTION_ENLISTMENTS_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint NumberOfEnlistments;

        [NativeTypeName("TRANSACTION_ENLISTMENT_PAIR [1]")]
        public _EnlistmentPair_e__FixedBuffer EnlistmentPair;

        public partial struct _EnlistmentPair_e__FixedBuffer
        {
            public TRANSACTION_ENLISTMENT_PAIR e0;

            public unsafe ref TRANSACTION_ENLISTMENT_PAIR this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<TRANSACTION_ENLISTMENT_PAIR> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<TRANSACTION_ENLISTMENT_PAIR>((TRANSACTION_ENLISTMENT_PAIR*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
