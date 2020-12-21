// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct MIXERCONTROLA
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("DWORD")]
        public uint dwControlID;

        [NativeTypeName("DWORD")]
        public uint dwControlType;

        [NativeTypeName("DWORD")]
        public uint fdwControl;

        [NativeTypeName("DWORD")]
        public uint cMultipleItems;

        [NativeTypeName("CHAR [16]")]
        public fixed sbyte szShortName[16];

        [NativeTypeName("CHAR [64]")]
        public fixed sbyte szName[64];

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/mmeapi.h:2088:5)")]
        public _Bounds_e__Union Bounds;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/mmeapi.h:2099:5)")]
        public _Metrics_e__Union Metrics;

        [StructLayout(LayoutKind.Explicit, Pack = 1)]
        public unsafe partial struct _Bounds_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("tagMIXERCONTROLA::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/mmeapi.h:2089:9)")]
            public _Anonymous1_e__Struct Anonymous1;

            public unsafe ref int lMinimum
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
#if !NETSTANDARD2_0
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.lMinimum, 1));
#else
                    return ref ((_Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous1))->lMinimum;
#endif
                }
            }

            public unsafe ref int lMaximum
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
#if !NETSTANDARD2_0
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.lMaximum, 1));
#else
                    return ref ((_Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous1))->lMaximum;
#endif
                }
            }

            [FieldOffset(0)]
            [NativeTypeName("tagMIXERCONTROLA::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/mmeapi.h:2093:9)")]
            public _Anonymous2_e__Struct Anonymous2;

            public unsafe ref uint dwMinimum
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
#if !NETSTANDARD2_0
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwMinimum, 1));
#else
                    return ref ((_Anonymous2_e__Struct*)Unsafe.AsPointer(ref Anonymous2))->dwMinimum;
#endif
                }
            }

            public unsafe ref uint dwMaximum
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
#if !NETSTANDARD2_0
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwMaximum, 1));
#else
                    return ref ((_Anonymous2_e__Struct*)Unsafe.AsPointer(ref Anonymous2))->dwMaximum;
#endif
                }
            }

            [FieldOffset(0)]
            [NativeTypeName("DWORD [6]")]
            public fixed uint dwReserved[6];

            [StructLayout(LayoutKind.Sequential, Pack = 1)]
            public partial struct _Anonymous1_e__Struct
            {
                [NativeTypeName("LONG")]
                public int lMinimum;

                [NativeTypeName("LONG")]
                public int lMaximum;
            }

            [StructLayout(LayoutKind.Sequential, Pack = 1)]
            public partial struct _Anonymous2_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint dwMinimum;

                [NativeTypeName("DWORD")]
                public uint dwMaximum;
            }
        }

        [StructLayout(LayoutKind.Explicit, Pack = 1)]
        public unsafe partial struct _Metrics_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint cSteps;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint cbCustomData;

            [FieldOffset(0)]
            [NativeTypeName("DWORD [6]")]
            public fixed uint dwReserved[6];
        }
    }
}
