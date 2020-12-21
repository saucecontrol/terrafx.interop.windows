// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SP_NEWDEVICEWIZARD_DATA
    {
        public SP_CLASSINSTALL_HEADER ClassInstallHeader;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("HPROPSHEETPAGE [20]")]
        public _DynamicPages_e__FixedBuffer DynamicPages;

        [NativeTypeName("DWORD")]
        public uint NumDynamicPages;

        [NativeTypeName("HWND")]
        public IntPtr hwndWizardDlg;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _DynamicPages_e__FixedBuffer
        {
            public IntPtr e0;
            public IntPtr e1;
            public IntPtr e2;
            public IntPtr e3;
            public IntPtr e4;
            public IntPtr e5;
            public IntPtr e6;
            public IntPtr e7;
            public IntPtr e8;
            public IntPtr e9;
            public IntPtr e10;
            public IntPtr e11;
            public IntPtr e12;
            public IntPtr e13;
            public IntPtr e14;
            public IntPtr e15;
            public IntPtr e16;
            public IntPtr e17;
            public IntPtr e18;
            public IntPtr e19;

            public unsafe ref IntPtr this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<IntPtr> AsSpan()
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, 20);
#else
                return new Span<IntPtr>((IntPtr*)Unsafe.AsPointer(ref this), 20);
#endif
            }
        }
    }
}
