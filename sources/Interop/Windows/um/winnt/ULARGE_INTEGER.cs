// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct ULARGE_INTEGER
    {
        [FieldOffset(0)]
        [NativeTypeName("_ULARGE_INTEGER::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:871:5)")]
        public _Anonymous_e__Struct Anonymous;

        public unsafe ref uint LowPart
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.LowPart, 1));
#else
                return ref ((_Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous))->LowPart;
#endif
            }
        }

        public unsafe ref uint HighPart
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.HighPart, 1));
#else
                return ref ((_Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous))->HighPart;
#endif
            }
        }

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:875:5)")]
        public _u_e__Struct u;

        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong QuadPart;

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint LowPart;

            [NativeTypeName("DWORD")]
            public uint HighPart;
        }

        public partial struct _u_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint LowPart;

            [NativeTypeName("DWORD")]
            public uint HighPart;
        }
    }
}
