// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ks.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct KSDATAFORMAT
    {
        [FieldOffset(0)]
        [NativeTypeName("KSDATAFORMAT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared/ks.h:1096:5)")]
        public _Anonymous_e__Struct Anonymous;

        public unsafe ref uint FormatSize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.FormatSize, 1));
#else
                return ref ((_Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous))->FormatSize;
#endif
            }
        }

        public unsafe ref uint Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Flags, 1));
#else
                return ref ((_Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous))->Flags;
#endif
            }
        }

        public unsafe ref uint SampleSize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.SampleSize, 1));
#else
                return ref ((_Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous))->SampleSize;
#endif
            }
        }

        public unsafe ref uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Reserved, 1));
#else
                return ref ((_Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous))->Reserved;
#endif
            }
        }

        public unsafe ref Guid MajorFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.MajorFormat, 1));
#else
                return ref ((_Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous))->MajorFormat;
#endif
            }
        }

        public unsafe ref Guid SubFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.SubFormat, 1));
#else
                return ref ((_Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous))->SubFormat;
#endif
            }
        }

        public unsafe ref Guid Specifier
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Specifier, 1));
#else
                return ref ((_Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous))->Specifier;
#endif
            }
        }

        [FieldOffset(0)]
        [NativeTypeName("LONGLONG")]
        public long Alignment;

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("ULONG")]
            public uint FormatSize;

            [NativeTypeName("ULONG")]
            public uint Flags;

            [NativeTypeName("ULONG")]
            public uint SampleSize;

            [NativeTypeName("ULONG")]
            public uint Reserved;

            [NativeTypeName("GUID")]
            public Guid MajorFormat;

            [NativeTypeName("GUID")]
            public Guid SubFormat;

            [NativeTypeName("GUID")]
            public Guid Specifier;
        }
    }
}
