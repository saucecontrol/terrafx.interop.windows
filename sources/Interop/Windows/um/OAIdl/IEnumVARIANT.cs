// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020404-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IEnumVARIANT : IUnknown")]
    public unsafe partial struct IEnumVARIANT
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IEnumVARIANT*, Guid*, void**, int>)(lpVtbl[0]))((IEnumVARIANT*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IEnumVARIANT*, uint>)(lpVtbl[1]))((IEnumVARIANT*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IEnumVARIANT*, uint>)(lpVtbl[2]))((IEnumVARIANT*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("VARIANT *")] VARIANT* rgVar, [NativeTypeName("ULONG *")] uint* pCeltFetched)
        {
            return ((delegate* stdcall<IEnumVARIANT*, uint, VARIANT*, uint*, int>)(lpVtbl[3]))((IEnumVARIANT*)Unsafe.AsPointer(ref this), celt, rgVar, pCeltFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* stdcall<IEnumVARIANT*, uint, int>)(lpVtbl[4]))((IEnumVARIANT*)Unsafe.AsPointer(ref this), celt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* stdcall<IEnumVARIANT*, int>)(lpVtbl[5]))((IEnumVARIANT*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumVARIANT **")] IEnumVARIANT** ppEnum)
        {
            return ((delegate* stdcall<IEnumVARIANT*, IEnumVARIANT**, int>)(lpVtbl[6]))((IEnumVARIANT*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
