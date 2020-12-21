// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DE9A6157-F660-4643-B56A-DF9F7998C7CD")]
    [NativeTypeName("struct IMFTopoLoader : IUnknown")]
    public unsafe partial struct IMFTopoLoader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopoLoader*, Guid*, void**, int>)(lpVtbl[0]))((IMFTopoLoader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopoLoader*, uint>)(lpVtbl[1]))((IMFTopoLoader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopoLoader*, uint>)(lpVtbl[2]))((IMFTopoLoader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IMFTopology *")] IMFTopology* pInputTopo, [NativeTypeName("IMFTopology **")] IMFTopology** ppOutputTopo, [NativeTypeName("IMFTopology *")] IMFTopology* pCurrentTopo)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopoLoader*, IMFTopology*, IMFTopology**, IMFTopology*, int>)(lpVtbl[3]))((IMFTopoLoader*)Unsafe.AsPointer(ref this), pInputTopo, ppOutputTopo, pCurrentTopo);
        }
    }
}
