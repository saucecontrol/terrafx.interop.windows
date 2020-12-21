// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DCFBDCF6-0DC2-45F5-9AB2-7C330EA09C29")]
    [NativeTypeName("struct IFilterChain : IUnknown")]
    public unsafe partial struct IFilterChain
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterChain*, Guid*, void**, int>)(lpVtbl[0]))((IFilterChain*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IFilterChain*, uint>)(lpVtbl[1]))((IFilterChain*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IFilterChain*, uint>)(lpVtbl[2]))((IFilterChain*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StartChain([NativeTypeName("IBaseFilter *")] IBaseFilter* pStartFilter, [NativeTypeName("IBaseFilter *")] IBaseFilter* pEndFilter)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterChain*, IBaseFilter*, IBaseFilter*, int>)(lpVtbl[3]))((IFilterChain*)Unsafe.AsPointer(ref this), pStartFilter, pEndFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PauseChain([NativeTypeName("IBaseFilter *")] IBaseFilter* pStartFilter, [NativeTypeName("IBaseFilter *")] IBaseFilter* pEndFilter)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterChain*, IBaseFilter*, IBaseFilter*, int>)(lpVtbl[4]))((IFilterChain*)Unsafe.AsPointer(ref this), pStartFilter, pEndFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StopChain([NativeTypeName("IBaseFilter *")] IBaseFilter* pStartFilter, [NativeTypeName("IBaseFilter *")] IBaseFilter* pEndFilter)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterChain*, IBaseFilter*, IBaseFilter*, int>)(lpVtbl[5]))((IFilterChain*)Unsafe.AsPointer(ref this), pStartFilter, pEndFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveChain([NativeTypeName("IBaseFilter *")] IBaseFilter* pStartFilter, [NativeTypeName("IBaseFilter *")] IBaseFilter* pEndFilter)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterChain*, IBaseFilter*, IBaseFilter*, int>)(lpVtbl[6]))((IFilterChain*)Unsafe.AsPointer(ref this), pStartFilter, pEndFilter);
        }
    }
}
