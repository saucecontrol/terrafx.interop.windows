// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7071E1F0-E84B-4B33-974F-12FA49DE65C5")]
    [NativeTypeName("struct ID3D12Tools : IUnknown")]
    public unsafe partial struct ID3D12Tools
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12Tools*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Tools*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12Tools*, uint>)(lpVtbl[1]))((ID3D12Tools*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12Tools*, uint>)(lpVtbl[2]))((ID3D12Tools*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void EnableShaderInstrumentation([NativeTypeName("BOOL")] int bEnable)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Tools*, int, void>)(lpVtbl[3]))((ID3D12Tools*)Unsafe.AsPointer(ref this), bEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int ShaderInstrumentationEnabled()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12Tools*, int>)(lpVtbl[4]))((ID3D12Tools*)Unsafe.AsPointer(ref this));
        }
    }
}
