// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000100-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IEnumUnknown : IUnknown")]
    public unsafe partial struct IEnumUnknown
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IEnumUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumUnknown*, uint>)(lpVtbl[1]))((IEnumUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumUnknown*, uint>)(lpVtbl[2]))((IEnumUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("IUnknown **")] IUnknown** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumUnknown*, uint, IUnknown**, uint*, int>)(lpVtbl[3]))((IEnumUnknown*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumUnknown*, uint, int>)(lpVtbl[4]))((IEnumUnknown*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumUnknown*, int>)(lpVtbl[5]))((IEnumUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppenum)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumUnknown*, IEnumUnknown**, int>)(lpVtbl[6]))((IEnumUnknown*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
