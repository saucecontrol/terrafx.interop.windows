// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROCESSOR_POWER_POLICY
    {
        [NativeTypeName("DWORD")]
        public uint Revision;

        [NativeTypeName("BYTE")]
        public byte DynamicThrottle;

        [NativeTypeName("BYTE [3]")]
        public fixed byte Spare[3];

        public uint _bitfield;

        [NativeTypeName("DWORD : 1")]
        public uint DisableCStates
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
            }
        }

        [NativeTypeName("DWORD : 31")]
        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 1) & 0x7FFFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
            }
        }

        [NativeTypeName("DWORD")]
        public uint PolicyCount;

        [NativeTypeName("PROCESSOR_POWER_POLICY_INFO [3]")]
        public _Policy_e__FixedBuffer Policy;

        public partial struct _Policy_e__FixedBuffer
        {
            public PROCESSOR_POWER_POLICY_INFO e0;
            public PROCESSOR_POWER_POLICY_INFO e1;
            public PROCESSOR_POWER_POLICY_INFO e2;

            public unsafe ref PROCESSOR_POWER_POLICY_INFO this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<PROCESSOR_POWER_POLICY_INFO> AsSpan()
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, 3);
#else
                return new Span<PROCESSOR_POWER_POLICY_INFO>((PROCESSOR_POWER_POLICY_INFO*)Unsafe.AsPointer(ref this), 3);
#endif
            }
        }
    }
}
