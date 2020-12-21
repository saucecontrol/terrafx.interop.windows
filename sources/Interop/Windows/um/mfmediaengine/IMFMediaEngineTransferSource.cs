// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("24230452-FE54-40CC-94F3-FCC394C340D6")]
    [NativeTypeName("struct IMFMediaEngineTransferSource : IUnknown")]
    public unsafe partial struct IMFMediaEngineTransferSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineTransferSource*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineTransferSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineTransferSource*, uint>)(lpVtbl[1]))((IMFMediaEngineTransferSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineTransferSource*, uint>)(lpVtbl[2]))((IMFMediaEngineTransferSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TransferSourceToMediaEngine([NativeTypeName("IMFMediaEngine *")] IMFMediaEngine* destination)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineTransferSource*, IMFMediaEngine*, int>)(lpVtbl[3]))((IMFMediaEngineTransferSource*)Unsafe.AsPointer(ref this), destination);
        }
    }
}
