// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_TEXTURE_COPY_LOCATION
    {
        [NativeTypeName("ID3D12Resource *")]
        public ID3D12Resource* pResource;

        public D3D12_TEXTURE_COPY_TYPE Type;

        [NativeTypeName("D3D12_TEXTURE_COPY_LOCATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d12.h:2788:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref D3D12_PLACED_SUBRESOURCE_FOOTPRINT PlacedFootprint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.PlacedFootprint, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->PlacedFootprint;
#endif
            }
        }

        public unsafe ref uint SubresourceIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.SubresourceIndex, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->SubresourceIndex;
#endif
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D12_PLACED_SUBRESOURCE_FOOTPRINT PlacedFootprint;

            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint SubresourceIndex;
        }
    }
}
