// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SUBSCRIBE_GENERIC_TLS_EXTENSION
    {
        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint SubscriptionsCount;

        [NativeTypeName("TLS_EXTENSION_SUBSCRIPTION [1]")]
        public _Subscriptions_e__FixedBuffer Subscriptions;

        public partial struct _Subscriptions_e__FixedBuffer
        {
            public TLS_EXTENSION_SUBSCRIPTION e0;

            public unsafe ref TLS_EXTENSION_SUBSCRIPTION this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<TLS_EXTENSION_SUBSCRIPTION> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<TLS_EXTENSION_SUBSCRIPTION>((TLS_EXTENSION_SUBSCRIPTION*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
