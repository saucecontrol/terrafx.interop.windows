// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D11_VIDEO_COLOR
    {
        [NativeTypeName("D3D11_VIDEO_COLOR::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h:10354:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref D3D11_VIDEO_COLOR_YCbCrA YCbCr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.YCbCr, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->YCbCr;
#endif
            }
        }

        public unsafe ref D3D11_VIDEO_COLOR_RGBA RGBA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.RGBA, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->RGBA;
#endif
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D11_VIDEO_COLOR_YCbCrA YCbCr;

            [FieldOffset(0)]
            public D3D11_VIDEO_COLOR_RGBA RGBA;
        }
    }
}
