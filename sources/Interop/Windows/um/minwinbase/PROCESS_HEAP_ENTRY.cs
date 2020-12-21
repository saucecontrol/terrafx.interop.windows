// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROCESS_HEAP_ENTRY
    {
        [NativeTypeName("PVOID")]
        public void* lpData;

        [NativeTypeName("DWORD")]
        public uint cbData;

        [NativeTypeName("BYTE")]
        public byte cbOverhead;

        [NativeTypeName("BYTE")]
        public byte iRegionIndex;

        [NativeTypeName("WORD")]
        public ushort wFlags;

        [NativeTypeName("_PROCESS_HEAP_ENTRY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/minwinbase.h:244:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref _Anonymous_e__Union._Block_e__Struct Block
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Block, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Block;
#endif
            }
        }

        public unsafe ref _Anonymous_e__Union._Region_e__Struct Region
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Region, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Region;
#endif
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/minwinbase.h:245:9)")]
            public _Block_e__Struct Block;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/minwinbase.h:249:9)")]
            public _Region_e__Struct Region;

            public unsafe partial struct _Block_e__Struct
            {
                [NativeTypeName("HANDLE")]
                public IntPtr hMem;

                [NativeTypeName("DWORD [3]")]
                public fixed uint dwReserved[3];
            }

            public unsafe partial struct _Region_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint dwCommittedSize;

                [NativeTypeName("DWORD")]
                public uint dwUnCommittedSize;

                [NativeTypeName("LPVOID")]
                public void* lpFirstBlock;

                [NativeTypeName("LPVOID")]
                public void* lpLastBlock;
            }
        }
    }
}
