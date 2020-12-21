// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct MEM_EXTENDED_PARAMETER
    {
        [NativeTypeName("MEM_EXTENDED_PARAMETER::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:13032:5)")]
        public _Anonymous1_e__Struct Anonymous1;

        public unsafe ulong Type
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous1.Type;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous1.Type = value;
            }
        }

        public unsafe ulong Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous1.Reserved;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous1.Reserved = value;
            }
        }

        [NativeTypeName("MEM_EXTENDED_PARAMETER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:13037:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public unsafe ref ulong ULong64
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.ULong64, 1));
#else
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->ULong64;
#endif
            }
        }

        public unsafe ref void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->Pointer;
            }
        }

        public unsafe ref nuint Size
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.Size, 1));
#else
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->Size;
#endif
            }
        }

        public unsafe ref IntPtr Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.Handle, 1));
#else
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->Handle;
#endif
            }
        }

        public unsafe ref uint ULong
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.ULong, 1));
#else
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->ULong;
#endif
            }
        }

        public partial struct _Anonymous1_e__Struct
        {
            public ulong _bitfield;

            [NativeTypeName("DWORD64 : 8")]
            public ulong Type
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0xFFUL;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0xFFUL) | (value & 0xFFUL);
                }
            }

            [NativeTypeName("DWORD64 : 56")]
            public ulong Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 8) & 0xFFFFFFUL;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0xFFFFFFUL << 8)) | ((value & 0xFFFFFFUL) << 8);
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD64")]
            public ulong ULong64;

            [FieldOffset(0)]
            [NativeTypeName("PVOID")]
            public void* Pointer;

            [FieldOffset(0)]
            [NativeTypeName("SIZE_T")]
            public nuint Size;

            [FieldOffset(0)]
            [NativeTypeName("HANDLE")]
            public IntPtr Handle;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint ULong;
        }
    }
}
