// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A9B71770-D099-4A65-A698-3DEE10020F88")]
    [NativeTypeName("struct ID3D12DebugDevice1 : IUnknown")]
    public unsafe partial struct ID3D12DebugDevice1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice1*, uint>)(lpVtbl[1]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice1*, uint>)(lpVtbl[2]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint DataSize)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice1*, D3D12_DEBUG_DEVICE_PARAMETER_TYPE, void*, uint, int>)(lpVtbl[3]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, [NativeTypeName("void *")] void* pData, [NativeTypeName("UINT")] uint DataSize)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice1*, D3D12_DEBUG_DEVICE_PARAMETER_TYPE, void*, uint, int>)(lpVtbl[4]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReportLiveDeviceObjects(D3D12_RLDO_FLAGS Flags)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice1*, D3D12_RLDO_FLAGS, int>)(lpVtbl[5]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this), Flags);
        }
    }
}
