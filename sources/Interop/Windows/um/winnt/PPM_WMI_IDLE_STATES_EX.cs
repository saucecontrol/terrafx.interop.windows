// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PPM_WMI_IDLE_STATES_EX
    {
        [NativeTypeName("DWORD")]
        public uint Type;

        [NativeTypeName("DWORD")]
        public uint Count;

        [NativeTypeName("DWORD")]
        public uint TargetState;

        [NativeTypeName("DWORD")]
        public uint OldState;

        [NativeTypeName("PVOID")]
        public void* TargetProcessors;

        [NativeTypeName("PPM_WMI_IDLE_STATE [1]")]
        public _State_e__FixedBuffer State;

        public partial struct _State_e__FixedBuffer
        {
            public PPM_WMI_IDLE_STATE e0;

            public unsafe ref PPM_WMI_IDLE_STATE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<PPM_WMI_IDLE_STATE> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<PPM_WMI_IDLE_STATE>((PPM_WMI_IDLE_STATE*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
