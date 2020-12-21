// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct IMAGE_RELOCATION
    {
        [NativeTypeName("_IMAGE_RELOCATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17622:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref uint VirtualAddress
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.VirtualAddress, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->VirtualAddress;
#endif
            }
        }

        public unsafe ref uint RelocCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.RelocCount, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->RelocCount;
#endif
            }
        }

        [NativeTypeName("DWORD")]
        public uint SymbolTableIndex;

        [NativeTypeName("WORD")]
        public ushort Type;

        [StructLayout(LayoutKind.Explicit, Pack = 2)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint VirtualAddress;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint RelocCount;
        }
    }
}
