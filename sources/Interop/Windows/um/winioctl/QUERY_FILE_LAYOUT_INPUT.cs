// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct QUERY_FILE_LAYOUT_INPUT
    {
        [NativeTypeName("_QUERY_FILE_LAYOUT_INPUT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:14318:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref uint FilterEntryCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.FilterEntryCount, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->FilterEntryCount;
#endif
            }
        }

        public unsafe ref uint NumberOfPairs
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.NumberOfPairs, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->NumberOfPairs;
#endif
            }
        }

        [NativeTypeName("DWORD")]
        public uint Flags;

        public QUERY_FILE_LAYOUT_FILTER_TYPE FilterType;

        [NativeTypeName("DWORD")]
        public uint Reserved;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:14345:5)")]
        public _Filter_e__Union Filter;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint FilterEntryCount;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint NumberOfPairs;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Filter_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("CLUSTER_RANGE [1]")]
            public _ClusterRanges_e__FixedBuffer ClusterRanges;

            [FieldOffset(0)]
            [NativeTypeName("FILE_REFERENCE_RANGE [1]")]
            public _FileReferenceRanges_e__FixedBuffer FileReferenceRanges;

            [FieldOffset(0)]
            [NativeTypeName("STORAGE_RESERVE_ID [1]")]
            public _StorageReserveIds_e__FixedBuffer StorageReserveIds;

            public partial struct _ClusterRanges_e__FixedBuffer
            {
                public CLUSTER_RANGE e0;

                public unsafe ref CLUSTER_RANGE this[int index]
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return ref AsSpan(int.MaxValue)[index];
                    }
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public unsafe Span<CLUSTER_RANGE> AsSpan(int length)
                {
#if !NETSTANDARD2_0
                    return MemoryMarshal.CreateSpan(ref e0, length);
#else
                    return new Span<CLUSTER_RANGE>((CLUSTER_RANGE*)Unsafe.AsPointer(ref this), length);
#endif
                }
            }

            public partial struct _FileReferenceRanges_e__FixedBuffer
            {
                public FILE_REFERENCE_RANGE e0;

                public unsafe ref FILE_REFERENCE_RANGE this[int index]
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return ref AsSpan(int.MaxValue)[index];
                    }
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public unsafe Span<FILE_REFERENCE_RANGE> AsSpan(int length)
                {
#if !NETSTANDARD2_0
                    return MemoryMarshal.CreateSpan(ref e0, length);
#else
                    return new Span<FILE_REFERENCE_RANGE>((FILE_REFERENCE_RANGE*)Unsafe.AsPointer(ref this), length);
#endif
                }
            }

            public partial struct _StorageReserveIds_e__FixedBuffer
            {
                public STORAGE_RESERVE_ID e0;

                public unsafe ref STORAGE_RESERVE_ID this[int index]
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return ref AsSpan(int.MaxValue)[index];
                    }
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public unsafe Span<STORAGE_RESERVE_ID> AsSpan(int length)
                {
#if !NETSTANDARD2_0
                    return MemoryMarshal.CreateSpan(ref e0, length);
#else
                    return new Span<STORAGE_RESERVE_ID>((STORAGE_RESERVE_ID*)Unsafe.AsPointer(ref this), length);
#endif
                }
            }
        }
    }
}
