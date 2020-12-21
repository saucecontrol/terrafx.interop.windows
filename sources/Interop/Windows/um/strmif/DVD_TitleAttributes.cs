// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DVD_TitleAttributes
    {
        [NativeTypeName("tagDVD_TitleMainAttributes::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/strmif.h:21262:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref DVD_TITLE_APPMODE AppMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.AppMode, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->AppMode;
#endif
            }
        }

        public unsafe ref DVD_HMSF_TIMECODE TitleLength
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.TitleLength, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->TitleLength;
#endif
            }
        }

        public DVD_VideoAttributes VideoAttributes;

        [NativeTypeName("ULONG")]
        public uint ulNumberOfAudioStreams;

        [NativeTypeName("DVD_AudioAttributes [8]")]
        public _AudioAttributes_e__FixedBuffer AudioAttributes;

        [NativeTypeName("DVD_MultichannelAudioAttributes [8]")]
        public _MultichannelAudioAttributes_e__FixedBuffer MultichannelAudioAttributes;

        [NativeTypeName("ULONG")]
        public uint ulNumberOfSubpictureStreams;

        [NativeTypeName("DVD_SubpictureAttributes [32]")]
        public _SubpictureAttributes_e__FixedBuffer SubpictureAttributes;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public DVD_TITLE_APPMODE AppMode;

            [FieldOffset(0)]
            public DVD_HMSF_TIMECODE TitleLength;
        }

        public partial struct _AudioAttributes_e__FixedBuffer
        {
            public DVD_AudioAttributes e0;
            public DVD_AudioAttributes e1;
            public DVD_AudioAttributes e2;
            public DVD_AudioAttributes e3;
            public DVD_AudioAttributes e4;
            public DVD_AudioAttributes e5;
            public DVD_AudioAttributes e6;
            public DVD_AudioAttributes e7;

            public unsafe ref DVD_AudioAttributes this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<DVD_AudioAttributes> AsSpan()
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, 8);
#else
                return new Span<DVD_AudioAttributes>((DVD_AudioAttributes*)Unsafe.AsPointer(ref this), 8);
#endif
            }
        }

        public partial struct _MultichannelAudioAttributes_e__FixedBuffer
        {
            public DVD_MultichannelAudioAttributes e0;
            public DVD_MultichannelAudioAttributes e1;
            public DVD_MultichannelAudioAttributes e2;
            public DVD_MultichannelAudioAttributes e3;
            public DVD_MultichannelAudioAttributes e4;
            public DVD_MultichannelAudioAttributes e5;
            public DVD_MultichannelAudioAttributes e6;
            public DVD_MultichannelAudioAttributes e7;

            public unsafe ref DVD_MultichannelAudioAttributes this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<DVD_MultichannelAudioAttributes> AsSpan()
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, 8);
#else
                return new Span<DVD_MultichannelAudioAttributes>((DVD_MultichannelAudioAttributes*)Unsafe.AsPointer(ref this), 8);
#endif
            }
        }

        public partial struct _SubpictureAttributes_e__FixedBuffer
        {
            public DVD_SubpictureAttributes e0;
            public DVD_SubpictureAttributes e1;
            public DVD_SubpictureAttributes e2;
            public DVD_SubpictureAttributes e3;
            public DVD_SubpictureAttributes e4;
            public DVD_SubpictureAttributes e5;
            public DVD_SubpictureAttributes e6;
            public DVD_SubpictureAttributes e7;
            public DVD_SubpictureAttributes e8;
            public DVD_SubpictureAttributes e9;
            public DVD_SubpictureAttributes e10;
            public DVD_SubpictureAttributes e11;
            public DVD_SubpictureAttributes e12;
            public DVD_SubpictureAttributes e13;
            public DVD_SubpictureAttributes e14;
            public DVD_SubpictureAttributes e15;
            public DVD_SubpictureAttributes e16;
            public DVD_SubpictureAttributes e17;
            public DVD_SubpictureAttributes e18;
            public DVD_SubpictureAttributes e19;
            public DVD_SubpictureAttributes e20;
            public DVD_SubpictureAttributes e21;
            public DVD_SubpictureAttributes e22;
            public DVD_SubpictureAttributes e23;
            public DVD_SubpictureAttributes e24;
            public DVD_SubpictureAttributes e25;
            public DVD_SubpictureAttributes e26;
            public DVD_SubpictureAttributes e27;
            public DVD_SubpictureAttributes e28;
            public DVD_SubpictureAttributes e29;
            public DVD_SubpictureAttributes e30;
            public DVD_SubpictureAttributes e31;

            public unsafe ref DVD_SubpictureAttributes this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<DVD_SubpictureAttributes> AsSpan()
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, 32);
#else
                return new Span<DVD_SubpictureAttributes>((DVD_SubpictureAttributes*)Unsafe.AsPointer(ref this), 32);
#endif
            }
        }
    }
}
