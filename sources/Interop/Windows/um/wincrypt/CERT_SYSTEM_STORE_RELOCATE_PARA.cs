// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_SYSTEM_STORE_RELOCATE_PARA
    {
        [NativeTypeName("_CERT_SYSTEM_STORE_RELOCATE_PARA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:9483:5)")]
        public _Anonymous1_e__Union Anonymous1;

        public unsafe ref IntPtr hKeyBase
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.hKeyBase, 1));
#else
                return ref ((_Anonymous1_e__Union*)Unsafe.AsPointer(ref Anonymous1))->hKeyBase;
#endif
            }
        }

        public unsafe ref void* pvBase
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous1_e__Union*)Unsafe.AsPointer(ref Anonymous1))->pvBase;
            }
        }

        [NativeTypeName("_CERT_SYSTEM_STORE_RELOCATE_PARA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:9487:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public unsafe ref void* pvSystemStore
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->pvSystemStore;
            }
        }

        public unsafe ref sbyte* pszSystemStore
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->pszSystemStore;
            }
        }

        public unsafe ref ushort* pwszSystemStore
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->pwszSystemStore;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HKEY")]
            public IntPtr hKeyBase;

            [FieldOffset(0)]
            [NativeTypeName("void *")]
            public void* pvBase;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("void *")]
            public void* pvSystemStore;

            [FieldOffset(0)]
            [NativeTypeName("LPCSTR")]
            public sbyte* pszSystemStore;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pwszSystemStore;
        }
    }
}
