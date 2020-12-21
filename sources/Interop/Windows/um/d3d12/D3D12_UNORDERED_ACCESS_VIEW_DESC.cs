// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D12_UNORDERED_ACCESS_VIEW_DESC
    {
        public DXGI_FORMAT Format;

        public D3D12_UAV_DIMENSION ViewDimension;

        [NativeTypeName("D3D12_UNORDERED_ACCESS_VIEW_DESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d12.h:3180:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref D3D12_BUFFER_UAV Buffer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Buffer, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Buffer;
#endif
            }
        }

        public unsafe ref D3D12_TEX1D_UAV Texture1D
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

        public unsafe ref D3D12_TEX1D_ARRAY_UAV Texture1DArray
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

        public unsafe ref D3D12_TEX2D_UAV Texture2D
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

        public unsafe ref D3D12_TEX2D_ARRAY_UAV Texture2DArray
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

        public unsafe ref D3D12_TEX3D_UAV Texture3D
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture3D, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Texture3D;
#endif
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D12_BUFFER_UAV Buffer;

            [FieldOffset(0)]
            public D3D12_TEX1D_UAV Texture1D;

            [FieldOffset(0)]
            public D3D12_TEX1D_ARRAY_UAV Texture1DArray;

            [FieldOffset(0)]
            public D3D12_TEX2D_UAV Texture2D;

            [FieldOffset(0)]
            public D3D12_TEX2D_ARRAY_UAV Texture2DArray;

            [FieldOffset(0)]
            public D3D12_TEX3D_UAV Texture3D;
        }
    }
}
