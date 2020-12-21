// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION
    {
        [NativeTypeName("ULONG_PTR")]
        public nuint ProcessorMask;

        public LOGICAL_PROCESSOR_RELATIONSHIP Relationship;

        [NativeTypeName("_SYSTEM_LOGICAL_PROCESSOR_INFORMATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12514:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref _Anonymous_e__Union._ProcessorCore_e__Struct ProcessorCore
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ProcessorCore, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->ProcessorCore;
#endif
            }
        }

        public unsafe ref _Anonymous_e__Union._NumaNode_e__Struct NumaNode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.NumaNode, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->NumaNode;
#endif
            }
        }

        public unsafe ref CACHE_DESCRIPTOR Cache
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Cache, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Cache;
#endif
            }
        }

        public unsafe Span<ulong> Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref Anonymous.Reserved[0], 2);
#else
                return new Span<ulong>(((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Reserved, 2);
#endif
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12515:9)")]
            public _ProcessorCore_e__Struct ProcessorCore;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12518:9)")]
            public _NumaNode_e__Struct NumaNode;

            [FieldOffset(0)]
            public CACHE_DESCRIPTOR Cache;

            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG [2]")]
            public fixed ulong Reserved[2];

            public partial struct _ProcessorCore_e__Struct
            {
                [NativeTypeName("BYTE")]
                public byte Flags;
            }

            public partial struct _NumaNode_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint NodeNumber;
            }
        }
    }
}
