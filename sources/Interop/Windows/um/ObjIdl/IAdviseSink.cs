// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000010F-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IAdviseSink : IUnknown")]
    public unsafe partial struct IAdviseSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAdviseSink*, Guid*, void**, int>)(lpVtbl[0]))((IAdviseSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAdviseSink*, uint>)(lpVtbl[1]))((IAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAdviseSink*, uint>)(lpVtbl[2]))((IAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnDataChange([NativeTypeName("FORMATETC *")] FORMATETC* pFormatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pStgmed)
        {
            ((delegate* unmanaged[Stdcall]<IAdviseSink*, FORMATETC*, STGMEDIUM*, void>)(lpVtbl[3]))((IAdviseSink*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
        {
            ((delegate* unmanaged[Stdcall]<IAdviseSink*, uint, int, void>)(lpVtbl[4]))((IAdviseSink*)Unsafe.AsPointer(ref this), dwAspect, lindex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnRename([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            ((delegate* unmanaged[Stdcall]<IAdviseSink*, IMoniker*, void>)(lpVtbl[5]))((IAdviseSink*)Unsafe.AsPointer(ref this), pmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnSave()
        {
            ((delegate* unmanaged[Stdcall]<IAdviseSink*, void>)(lpVtbl[6]))((IAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnClose()
        {
            ((delegate* unmanaged[Stdcall]<IAdviseSink*, void>)(lpVtbl[7]))((IAdviseSink*)Unsafe.AsPointer(ref this));
        }
    }
}
