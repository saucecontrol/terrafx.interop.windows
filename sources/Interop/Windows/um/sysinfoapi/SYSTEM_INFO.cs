// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sysinfoapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct SYSTEM_INFO
    {
        [NativeTypeName("_SYSTEM_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/sysinfoapi.h:48:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref uint dwOemId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwOemId, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->dwOemId;
#endif
            }
        }

        public unsafe ref ushort wProcessorArchitecture
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.wProcessorArchitecture, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous))->wProcessorArchitecture;
#endif
            }
        }

        public unsafe ref ushort wReserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.wReserved, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous))->wReserved;
#endif
            }
        }

        [NativeTypeName("DWORD")]
        public uint dwPageSize;

        [NativeTypeName("LPVOID")]
        public void* lpMinimumApplicationAddress;

        [NativeTypeName("LPVOID")]
        public void* lpMaximumApplicationAddress;

        [NativeTypeName("DWORD_PTR")]
        public nuint dwActiveProcessorMask;

        [NativeTypeName("DWORD")]
        public uint dwNumberOfProcessors;

        [NativeTypeName("DWORD")]
        public uint dwProcessorType;

        [NativeTypeName("DWORD")]
        public uint dwAllocationGranularity;

        [NativeTypeName("WORD")]
        public ushort wProcessorLevel;

        [NativeTypeName("WORD")]
        public ushort wProcessorRevision;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwOemId;

            [FieldOffset(0)]
            [NativeTypeName("_SYSTEM_INFO::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/sysinfoapi.h:50:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("WORD")]
                public ushort wProcessorArchitecture;

                [NativeTypeName("WORD")]
                public ushort wReserved;
            }
        }
    }
}
