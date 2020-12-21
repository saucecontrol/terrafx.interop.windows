// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D11_DEPTH_STENCIL_VIEW_DESC
    {
        public DXGI_FORMAT Format;

        public D3D11_DSV_DIMENSION ViewDimension;

        [NativeTypeName("UINT")]
        public uint Flags;

        [NativeTypeName("D3D11_DEPTH_STENCIL_VIEW_DESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h:4308:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref D3D11_TEX1D_DSV Texture1D
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture1D, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Texture1D;
#endif
            }
        }

        public unsafe ref D3D11_TEX1D_ARRAY_DSV Texture1DArray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture1DArray, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Texture1DArray;
#endif
            }
        }

        public unsafe ref D3D11_TEX2D_DSV Texture2D
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2D, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Texture2D;
#endif
            }
        }

        public unsafe ref D3D11_TEX2D_ARRAY_DSV Texture2DArray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2DArray, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Texture2DArray;
#endif
            }
        }

        public unsafe ref D3D11_TEX2DMS_DSV Texture2DMS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2DMS, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Texture2DMS;
#endif
            }
        }

        public unsafe ref D3D11_TEX2DMS_ARRAY_DSV Texture2DMSArray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2DMSArray, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Texture2DMSArray;
#endif
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D11_TEX1D_DSV Texture1D;

            [FieldOffset(0)]
            public D3D11_TEX1D_ARRAY_DSV Texture1DArray;

            [FieldOffset(0)]
            public D3D11_TEX2D_DSV Texture2D;

            [FieldOffset(0)]
            public D3D11_TEX2D_ARRAY_DSV Texture2DArray;

            [FieldOffset(0)]
            public D3D11_TEX2DMS_DSV Texture2DMS;

            [FieldOffset(0)]
            public D3D11_TEX2DMS_ARRAY_DSV Texture2DMSArray;
        }
    }
}
