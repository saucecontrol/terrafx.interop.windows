// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint HeaderData;

        [FieldOffset(0)]
        [NativeTypeName("IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18778:5)")]
        public _Anonymous_e__Struct Anonymous;

        public unsafe uint FunctionLength
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.FunctionLength;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.FunctionLength = value;
            }
        }

        public unsafe uint Version
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Version;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Version = value;
            }
        }

        public unsafe uint ExceptionDataPresent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.ExceptionDataPresent;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.ExceptionDataPresent = value;
            }
        }

        public unsafe uint EpilogInHeader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.EpilogInHeader;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.EpilogInHeader = value;
            }
        }

        public unsafe uint EpilogCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.EpilogCount;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.EpilogCount = value;
            }
        }

        public unsafe uint CodeWords
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.CodeWords;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.CodeWords = value;
            }
        }

        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("DWORD : 18")]
            public uint FunctionLength
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0x3FFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0x3FFFFu) | (value & 0x3FFFFu);
                }
            }

            [NativeTypeName("DWORD : 2")]
            public uint Version
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 18) & 0x3u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x3u << 18)) | ((value & 0x3u) << 18);
                }
            }

            [NativeTypeName("DWORD : 1")]
            public uint ExceptionDataPresent
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 20) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 20)) | ((value & 0x1u) << 20);
                }
            }

            [NativeTypeName("DWORD : 1")]
            public uint EpilogInHeader
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 21) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 21)) | ((value & 0x1u) << 21);
                }
            }

            [NativeTypeName("DWORD : 5")]
            public uint EpilogCount
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 22) & 0x1Fu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1Fu << 22)) | ((value & 0x1Fu) << 22);
                }
            }

            [NativeTypeName("DWORD : 5")]
            public uint CodeWords
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 27) & 0x1Fu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1Fu << 27)) | ((value & 0x1Fu) << 27);
                }
            }
        }
    }
}
