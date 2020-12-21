// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct NT_TIB64
    {
        [NativeTypeName("DWORD64")]
        public ulong ExceptionList;

        [NativeTypeName("DWORD64")]
        public ulong StackBase;

        [NativeTypeName("DWORD64")]
        public ulong StackLimit;

        [NativeTypeName("DWORD64")]
        public ulong SubSystemTib;

        [NativeTypeName("_NT_TIB64::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11531:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref ulong FiberData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.FiberData, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->FiberData;
#endif
            }
        }

        public unsafe ref uint Version
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Version, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Version;
#endif
            }
        }

        [NativeTypeName("DWORD64")]
        public ulong ArbitraryUserPointer;

        [NativeTypeName("DWORD64")]
        public ulong Self;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD64")]
            public ulong FiberData;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Version;
        }
    }
}
