// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000111-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleAdviseHolder : IUnknown")]
    public unsafe partial struct IOleAdviseHolder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IOleAdviseHolder*, Guid*, void**, int>)(lpVtbl[0]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IOleAdviseHolder*, uint>)(lpVtbl[1]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IOleAdviseHolder*, uint>)(lpVtbl[2]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Advise([NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvise, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return ((delegate* unmanaged[Stdcall]<IOleAdviseHolder*, IAdviseSink*, uint*, int>)(lpVtbl[3]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), pAdvise, pdwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return ((delegate* unmanaged[Stdcall]<IOleAdviseHolder*, uint, int>)(lpVtbl[4]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumAdvise([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise)
        {
            return ((delegate* unmanaged[Stdcall]<IOleAdviseHolder*, IEnumSTATDATA**, int>)(lpVtbl[5]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SendOnRename([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            return ((delegate* unmanaged[Stdcall]<IOleAdviseHolder*, IMoniker*, int>)(lpVtbl[6]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), pmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SendOnSave()
        {
            return ((delegate* unmanaged[Stdcall]<IOleAdviseHolder*, int>)(lpVtbl[7]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SendOnClose()
        {
            return ((delegate* unmanaged[Stdcall]<IOleAdviseHolder*, int>)(lpVtbl[8]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }
    }
}
