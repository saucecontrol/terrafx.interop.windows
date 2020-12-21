// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DRIVE_LAYOUT_INFORMATION_EX
    {
        [NativeTypeName("DWORD")]
        public uint PartitionStyle;

        [NativeTypeName("DWORD")]
        public uint PartitionCount;

        [NativeTypeName("_DRIVE_LAYOUT_INFORMATION_EX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:8568:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref DRIVE_LAYOUT_INFORMATION_MBR Mbr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Mbr, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Mbr;
#endif
            }
        }

        public unsafe ref DRIVE_LAYOUT_INFORMATION_GPT Gpt
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Gpt, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Gpt;
#endif
            }
        }

        [NativeTypeName("PARTITION_INFORMATION_EX [1]")]
        public _PartitionEntry_e__FixedBuffer PartitionEntry;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public DRIVE_LAYOUT_INFORMATION_MBR Mbr;

            [FieldOffset(0)]
            public DRIVE_LAYOUT_INFORMATION_GPT Gpt;
        }

        public partial struct _PartitionEntry_e__FixedBuffer
        {
            public PARTITION_INFORMATION_EX e0;

            public unsafe ref PARTITION_INFORMATION_EX this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<PARTITION_INFORMATION_EX> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<PARTITION_INFORMATION_EX>((PARTITION_INFORMATION_EX*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
