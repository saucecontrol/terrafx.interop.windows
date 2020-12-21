// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6C4E655D-EAD8-4421-B6B9-54DCDBBDF820")]
    [NativeTypeName("struct IMFPMPClient : IUnknown")]
    public unsafe partial struct IMFPMPClient
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMPClient*, Guid*, void**, int>)(lpVtbl[0]))((IMFPMPClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMPClient*, uint>)(lpVtbl[1]))((IMFPMPClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMPClient*, uint>)(lpVtbl[2]))((IMFPMPClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPMPHost([NativeTypeName("IMFPMPHost *")] IMFPMPHost* pPMPHost)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMPClient*, IMFPMPHost*, int>)(lpVtbl[3]))((IMFPMPClient*)Unsafe.AsPointer(ref this), pPMPHost);
        }
    }
}
