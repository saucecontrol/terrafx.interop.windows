// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct XSTATE_CONFIGURATION
    {
        [NativeTypeName("DWORD64")]
        public ulong EnabledFeatures;

        [NativeTypeName("DWORD64")]
        public ulong EnabledVolatileFeatures;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("_XSTATE_CONFIGURATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12817:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref uint ControlFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ControlFlags, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->ControlFlags;
#endif
            }
        }

        public unsafe uint OptimizedSave
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.OptimizedSave;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.OptimizedSave = value;
            }
        }

        public unsafe uint CompactionEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.CompactionEnabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.CompactionEnabled = value;
            }
        }

        [NativeTypeName("XSTATE_FEATURE [64]")]
        public _Features_e__FixedBuffer Features;

        [NativeTypeName("DWORD64")]
        public ulong EnabledSupervisorFeatures;

        [NativeTypeName("DWORD64")]
        public ulong AlignedFeatures;

        [NativeTypeName("DWORD")]
        public uint AllFeatureSize;

        [NativeTypeName("DWORD [64]")]
        public fixed uint AllFeatures[64];

        [NativeTypeName("DWORD64")]
        public ulong EnabledUserVisibleSupervisorFeatures;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint ControlFlags;

            [FieldOffset(0)]
            [NativeTypeName("_XSTATE_CONFIGURATION::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12819:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("DWORD : 1")]
                public uint OptimizedSave
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint CompactionEnabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 1) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                    }
                }
            }
        }

        public partial struct _Features_e__FixedBuffer
        {
            public XSTATE_FEATURE e0;
            public XSTATE_FEATURE e1;
            public XSTATE_FEATURE e2;
            public XSTATE_FEATURE e3;
            public XSTATE_FEATURE e4;
            public XSTATE_FEATURE e5;
            public XSTATE_FEATURE e6;
            public XSTATE_FEATURE e7;
            public XSTATE_FEATURE e8;
            public XSTATE_FEATURE e9;
            public XSTATE_FEATURE e10;
            public XSTATE_FEATURE e11;
            public XSTATE_FEATURE e12;
            public XSTATE_FEATURE e13;
            public XSTATE_FEATURE e14;
            public XSTATE_FEATURE e15;
            public XSTATE_FEATURE e16;
            public XSTATE_FEATURE e17;
            public XSTATE_FEATURE e18;
            public XSTATE_FEATURE e19;
            public XSTATE_FEATURE e20;
            public XSTATE_FEATURE e21;
            public XSTATE_FEATURE e22;
            public XSTATE_FEATURE e23;
            public XSTATE_FEATURE e24;
            public XSTATE_FEATURE e25;
            public XSTATE_FEATURE e26;
            public XSTATE_FEATURE e27;
            public XSTATE_FEATURE e28;
            public XSTATE_FEATURE e29;
            public XSTATE_FEATURE e30;
            public XSTATE_FEATURE e31;
            public XSTATE_FEATURE e32;
            public XSTATE_FEATURE e33;
            public XSTATE_FEATURE e34;
            public XSTATE_FEATURE e35;
            public XSTATE_FEATURE e36;
            public XSTATE_FEATURE e37;
            public XSTATE_FEATURE e38;
            public XSTATE_FEATURE e39;
            public XSTATE_FEATURE e40;
            public XSTATE_FEATURE e41;
            public XSTATE_FEATURE e42;
            public XSTATE_FEATURE e43;
            public XSTATE_FEATURE e44;
            public XSTATE_FEATURE e45;
            public XSTATE_FEATURE e46;
            public XSTATE_FEATURE e47;
            public XSTATE_FEATURE e48;
            public XSTATE_FEATURE e49;
            public XSTATE_FEATURE e50;
            public XSTATE_FEATURE e51;
            public XSTATE_FEATURE e52;
            public XSTATE_FEATURE e53;
            public XSTATE_FEATURE e54;
            public XSTATE_FEATURE e55;
            public XSTATE_FEATURE e56;
            public XSTATE_FEATURE e57;
            public XSTATE_FEATURE e58;
            public XSTATE_FEATURE e59;
            public XSTATE_FEATURE e60;
            public XSTATE_FEATURE e61;
            public XSTATE_FEATURE e62;
            public XSTATE_FEATURE e63;

            public unsafe ref XSTATE_FEATURE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<XSTATE_FEATURE> AsSpan()
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, 64);
#else
                return new Span<XSTATE_FEATURE>((XSTATE_FEATURE*)Unsafe.AsPointer(ref this), 64);
#endif
            }
        }
    }
}
