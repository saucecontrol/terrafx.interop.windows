// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("52F547EF-5B03-49B5-82D6-565F1EE0DD49")]
    [NativeTypeName("struct ITensorNative : IUnknown")]
    public unsafe partial struct ITensorNative
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ITensorNative*, Guid*, void**, int>)(lpVtbl[0]))((ITensorNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ITensorNative*, uint>)(lpVtbl[1]))((ITensorNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ITensorNative*, uint>)(lpVtbl[2]))((ITensorNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("BYTE **")] byte** value, [NativeTypeName("UINT32 *")] uint* capacity)
        {
            return ((delegate* unmanaged[Stdcall]<ITensorNative*, byte**, uint*, int>)(lpVtbl[3]))((ITensorNative*)Unsafe.AsPointer(ref this), value, capacity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetD3D12Resource([NativeTypeName("ID3D12Resource **")] ID3D12Resource** result)
        {
            return ((delegate* unmanaged[Stdcall]<ITensorNative*, ID3D12Resource**, int>)(lpVtbl[4]))((ITensorNative*)Unsafe.AsPointer(ref this), result);
        }
    }
}
