// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct SLIST_HEADER
    {
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong Alignment;

        [FieldOffset(0)]
        [NativeTypeName("_SLIST_HEADER::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:19893:5)")]
        public _Anonymous_e__Struct Anonymous;

        public unsafe ref SINGLE_LIST_ENTRY Next
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Next, 1));
#else
                return ref ((_Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous))->Next;
#endif
            }
        }

        public unsafe ref ushort Depth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Depth, 1));
#else
                return ref ((_Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous))->Depth;
#endif
            }
        }

        public unsafe ref ushort CpuId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.CpuId, 1));
#else
                return ref ((_Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous))->CpuId;
#endif
            }
        }

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("SLIST_ENTRY")]
            public SINGLE_LIST_ENTRY Next;

            [NativeTypeName("WORD")]
            public ushort Depth;

            [NativeTypeName("WORD")]
            public ushort CpuId;
        }
    }
}
