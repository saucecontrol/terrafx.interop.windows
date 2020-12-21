// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9E184D15-CDB7-4F86-B49E-566689F4A601")]
    [NativeTypeName("struct IMFMediaEngineEMENotify : IUnknown")]
    public unsafe partial struct IMFMediaEngineEMENotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineEMENotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, uint>)(lpVtbl[1]))((IMFMediaEngineEMENotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, uint>)(lpVtbl[2]))((IMFMediaEngineEMENotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encrypted([NativeTypeName("const BYTE *")] byte* pbInitData, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("BSTR")] ushort* bstrInitDataType)
        {
            ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, ushort*, void>)(lpVtbl[3]))((IMFMediaEngineEMENotify*)Unsafe.AsPointer(ref this), pbInitData, cb, bstrInitDataType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WaitingForKey()
        {
            ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, void>)(lpVtbl[4]))((IMFMediaEngineEMENotify*)Unsafe.AsPointer(ref this));
        }
    }
}
