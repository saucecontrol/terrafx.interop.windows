// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000011E-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleCache : IUnknown")]
    public unsafe partial struct IOleCache
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IOleCache*, Guid*, void**, int>)(lpVtbl[0]))((IOleCache*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IOleCache*, uint>)(lpVtbl[1]))((IOleCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IOleCache*, uint>)(lpVtbl[2]))((IOleCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Cache([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return ((delegate* unmanaged[Stdcall]<IOleCache*, FORMATETC*, uint, uint*, int>)(lpVtbl[3]))((IOleCache*)Unsafe.AsPointer(ref this), pformatetc, advf, pdwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Uncache([NativeTypeName("DWORD")] uint dwConnection)
        {
            return ((delegate* unmanaged[Stdcall]<IOleCache*, uint, int>)(lpVtbl[4]))((IOleCache*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumCache([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumSTATDATA)
        {
            return ((delegate* unmanaged[Stdcall]<IOleCache*, IEnumSTATDATA**, int>)(lpVtbl[5]))((IOleCache*)Unsafe.AsPointer(ref this), ppenumSTATDATA);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitCache([NativeTypeName("IDataObject *")] IDataObject* pDataObject)
        {
            return ((delegate* unmanaged[Stdcall]<IOleCache*, IDataObject*, int>)(lpVtbl[6]))((IOleCache*)Unsafe.AsPointer(ref this), pDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetData([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pmedium, [NativeTypeName("BOOL")] int fRelease)
        {
            return ((delegate* unmanaged[Stdcall]<IOleCache*, FORMATETC*, STGMEDIUM*, int, int>)(lpVtbl[7]))((IOleCache*)Unsafe.AsPointer(ref this), pformatetc, pmedium, fRelease);
        }
    }
}
