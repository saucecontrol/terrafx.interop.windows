// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct DEVMODEW
    {
        [NativeTypeName("WCHAR [32]")]
        public fixed ushort dmDeviceName[32];

        [NativeTypeName("WORD")]
        public ushort dmSpecVersion;

        [NativeTypeName("WORD")]
        public ushort dmDriverVersion;

        [NativeTypeName("WORD")]
        public ushort dmSize;

        [NativeTypeName("WORD")]
        public ushort dmDriverExtra;

        [NativeTypeName("DWORD")]
        public uint dmFields;

        [NativeTypeName("_devicemodeW::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:2256:5)")]
        public _Anonymous1_e__Union Anonymous1;

        public unsafe ref short dmOrientation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous1.dmOrientation, 1));
#else
                return ref ((_Anonymous1_e__Union._Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous1.Anonymous1))->dmOrientation;
#endif
            }
        }

        public unsafe ref short dmPaperSize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous1.dmPaperSize, 1));
#else
                return ref ((_Anonymous1_e__Union._Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous1.Anonymous1))->dmPaperSize;
#endif
            }
        }

        public unsafe ref short dmPaperLength
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous1.dmPaperLength, 1));
#else
                return ref ((_Anonymous1_e__Union._Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous1.Anonymous1))->dmPaperLength;
#endif
            }
        }

        public unsafe ref short dmPaperWidth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous1.dmPaperWidth, 1));
#else
                return ref ((_Anonymous1_e__Union._Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous1.Anonymous1))->dmPaperWidth;
#endif
            }
        }

        public unsafe ref short dmScale
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous1.dmScale, 1));
#else
                return ref ((_Anonymous1_e__Union._Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous1.Anonymous1))->dmScale;
#endif
            }
        }

        public unsafe ref short dmCopies
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous1.dmCopies, 1));
#else
                return ref ((_Anonymous1_e__Union._Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous1.Anonymous1))->dmCopies;
#endif
            }
        }

        public unsafe ref short dmDefaultSource
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous1.dmDefaultSource, 1));
#else
                return ref ((_Anonymous1_e__Union._Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous1.Anonymous1))->dmDefaultSource;
#endif
            }
        }

        public unsafe ref short dmPrintQuality
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous1.dmPrintQuality, 1));
#else
                return ref ((_Anonymous1_e__Union._Anonymous1_e__Struct*)Unsafe.AsPointer(ref Anonymous1.Anonymous1))->dmPrintQuality;
#endif
            }
        }

        public unsafe ref POINTL dmPosition
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous2.dmPosition, 1));
#else
                return ref ((_Anonymous1_e__Union._Anonymous2_e__Struct*)Unsafe.AsPointer(ref Anonymous1.Anonymous2))->dmPosition;
#endif
            }
        }

        public unsafe ref uint dmDisplayOrientation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous2.dmDisplayOrientation, 1));
#else
                return ref ((_Anonymous1_e__Union._Anonymous2_e__Struct*)Unsafe.AsPointer(ref Anonymous1.Anonymous2))->dmDisplayOrientation;
#endif
            }
        }

        public unsafe ref uint dmDisplayFixedOutput
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous2.dmDisplayFixedOutput, 1));
#else
                return ref ((_Anonymous1_e__Union._Anonymous2_e__Struct*)Unsafe.AsPointer(ref Anonymous1.Anonymous2))->dmDisplayFixedOutput;
#endif
            }
        }

        public short dmColor;

        public short dmDuplex;

        public short dmYResolution;

        public short dmTTOption;

        public short dmCollate;

        [NativeTypeName("WCHAR [32]")]
        public fixed ushort dmFormName[32];

        [NativeTypeName("WORD")]
        public ushort dmLogPixels;

        [NativeTypeName("DWORD")]
        public uint dmBitsPerPel;

        [NativeTypeName("DWORD")]
        public uint dmPelsWidth;

        [NativeTypeName("DWORD")]
        public uint dmPelsHeight;

        [NativeTypeName("_devicemodeW::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:2285:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public unsafe ref uint dmDisplayFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dmDisplayFlags, 1));
#else
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->dmDisplayFlags;
#endif
            }
        }

        public unsafe ref uint dmNup
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dmNup, 1));
#else
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->dmNup;
#endif
            }
        }

        [NativeTypeName("DWORD")]
        public uint dmDisplayFrequency;

        [NativeTypeName("DWORD")]
        public uint dmICMMethod;

        [NativeTypeName("DWORD")]
        public uint dmICMIntent;

        [NativeTypeName("DWORD")]
        public uint dmMediaType;

        [NativeTypeName("DWORD")]
        public uint dmDitherType;

        [NativeTypeName("DWORD")]
        public uint dmReserved1;

        [NativeTypeName("DWORD")]
        public uint dmReserved2;

        [NativeTypeName("DWORD")]
        public uint dmPanningWidth;

        [NativeTypeName("DWORD")]
        public uint dmPanningHeight;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("_devicemodeW::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:2258:7)")]
            public _Anonymous1_e__Struct Anonymous1;

            [FieldOffset(0)]
            [NativeTypeName("_devicemodeW::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:2269:7)")]
            public _Anonymous2_e__Struct Anonymous2;

            public partial struct _Anonymous1_e__Struct
            {
                public short dmOrientation;

                public short dmPaperSize;

                public short dmPaperLength;

                public short dmPaperWidth;

                public short dmScale;

                public short dmCopies;

                public short dmDefaultSource;

                public short dmPrintQuality;
            }

            public partial struct _Anonymous2_e__Struct
            {
                public POINTL dmPosition;

                [NativeTypeName("DWORD")]
                public uint dmDisplayOrientation;

                [NativeTypeName("DWORD")]
                public uint dmDisplayFixedOutput;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dmDisplayFlags;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dmNup;
        }
    }
}
