// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E667AF9F-CD56-4F46-83CE-032E595D70A8")]
    [NativeTypeName("struct ID3D12LifetimeOwner : IUnknown")]
    public unsafe partial struct ID3D12LifetimeOwner
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12LifetimeOwner*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12LifetimeOwner*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12LifetimeOwner*, uint>)(lpVtbl[1]))((ID3D12LifetimeOwner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12LifetimeOwner*, uint>)(lpVtbl[2]))((ID3D12LifetimeOwner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void LifetimeStateUpdated(D3D12_LIFETIME_STATE NewState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12LifetimeOwner*, D3D12_LIFETIME_STATE, void>)(lpVtbl[3]))((ID3D12LifetimeOwner*)Unsafe.AsPointer(ref this), NewState);
        }
    }
}
