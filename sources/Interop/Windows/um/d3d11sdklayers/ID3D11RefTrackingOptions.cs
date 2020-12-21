// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("193DACDF-0DB2-4C05-A55C-EF06CAC56FD9")]
    [NativeTypeName("struct ID3D11RefTrackingOptions : IUnknown")]
    public unsafe partial struct ID3D11RefTrackingOptions
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11RefTrackingOptions*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11RefTrackingOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11RefTrackingOptions*, uint>)(lpVtbl[1]))((ID3D11RefTrackingOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11RefTrackingOptions*, uint>)(lpVtbl[2]))((ID3D11RefTrackingOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTrackingOptions([NativeTypeName("UINT")] uint uOptions)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11RefTrackingOptions*, uint, int>)(lpVtbl[3]))((ID3D11RefTrackingOptions*)Unsafe.AsPointer(ref this), uOptions);
        }
    }
}
