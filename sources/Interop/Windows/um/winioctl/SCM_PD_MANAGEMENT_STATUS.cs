// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SCM_PD_MANAGEMENT_STATUS
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        public SCM_PD_HEALTH_STATUS Health;

        [NativeTypeName("DWORD")]
        public uint NumberOfOperationalStatus;

        [NativeTypeName("DWORD")]
        public uint NumberOfAdditionalReasons;

        [NativeTypeName("SCM_PD_OPERATIONAL_STATUS [16]")]
        public _OperationalStatus_e__FixedBuffer OperationalStatus;

        [NativeTypeName("SCM_PD_OPERATIONAL_STATUS_REASON [1]")]
        public _AdditionalReasons_e__FixedBuffer AdditionalReasons;

        public partial struct _OperationalStatus_e__FixedBuffer
        {
            public SCM_PD_OPERATIONAL_STATUS e0;
            public SCM_PD_OPERATIONAL_STATUS e1;
            public SCM_PD_OPERATIONAL_STATUS e2;
            public SCM_PD_OPERATIONAL_STATUS e3;
            public SCM_PD_OPERATIONAL_STATUS e4;
            public SCM_PD_OPERATIONAL_STATUS e5;
            public SCM_PD_OPERATIONAL_STATUS e6;
            public SCM_PD_OPERATIONAL_STATUS e7;
            public SCM_PD_OPERATIONAL_STATUS e8;
            public SCM_PD_OPERATIONAL_STATUS e9;
            public SCM_PD_OPERATIONAL_STATUS e10;
            public SCM_PD_OPERATIONAL_STATUS e11;
            public SCM_PD_OPERATIONAL_STATUS e12;
            public SCM_PD_OPERATIONAL_STATUS e13;
            public SCM_PD_OPERATIONAL_STATUS e14;
            public SCM_PD_OPERATIONAL_STATUS e15;

            public unsafe ref SCM_PD_OPERATIONAL_STATUS this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<SCM_PD_OPERATIONAL_STATUS> AsSpan()
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, 16);
#else
                return new Span<SCM_PD_OPERATIONAL_STATUS>((SCM_PD_OPERATIONAL_STATUS*)Unsafe.AsPointer(ref this), 16);
#endif
            }
        }

        public partial struct _AdditionalReasons_e__FixedBuffer
        {
            public SCM_PD_OPERATIONAL_STATUS_REASON e0;

            public unsafe ref SCM_PD_OPERATIONAL_STATUS_REASON this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<SCM_PD_OPERATIONAL_STATUS_REASON> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<SCM_PD_OPERATIONAL_STATUS_REASON>((SCM_PD_OPERATIONAL_STATUS_REASON*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
