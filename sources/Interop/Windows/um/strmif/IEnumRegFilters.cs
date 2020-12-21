// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868A4-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IEnumRegFilters : IUnknown")]
    public unsafe partial struct IEnumRegFilters
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumRegFilters*, Guid*, void**, int>)(lpVtbl[0]))((IEnumRegFilters*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumRegFilters*, uint>)(lpVtbl[1]))((IEnumRegFilters*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumRegFilters*, uint>)(lpVtbl[2]))((IEnumRegFilters*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint cFilters, [NativeTypeName("REGFILTER **")] REGFILTER** apRegFilter, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumRegFilters*, uint, REGFILTER**, uint*, int>)(lpVtbl[3]))((IEnumRegFilters*)Unsafe.AsPointer(ref this), cFilters, apRegFilter, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint cFilters)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumRegFilters*, uint, int>)(lpVtbl[4]))((IEnumRegFilters*)Unsafe.AsPointer(ref this), cFilters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumRegFilters*, int>)(lpVtbl[5]))((IEnumRegFilters*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumRegFilters **")] IEnumRegFilters** ppEnum)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumRegFilters*, IEnumRegFilters**, int>)(lpVtbl[6]))((IEnumRegFilters*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
