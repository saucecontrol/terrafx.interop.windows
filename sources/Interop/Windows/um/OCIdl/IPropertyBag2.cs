// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22F55882-280B-11D0-A8A9-00A0C90C2004")]
    [NativeTypeName("struct IPropertyBag2 : IUnknown")]
    public unsafe partial struct IPropertyBag2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyBag2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, uint>)(lpVtbl[1]))((IPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, uint>)(lpVtbl[2]))((IPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2 *")] PROPBAG2* pPropBag, [NativeTypeName("IErrorLog *")] IErrorLog* pErrLog, [NativeTypeName("VARIANT *")] VARIANT* pvarValue, [NativeTypeName("HRESULT *")] int* phrError)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, uint, PROPBAG2*, IErrorLog*, VARIANT*, int*, int>)(lpVtbl[3]))((IPropertyBag2*)Unsafe.AsPointer(ref this), cProperties, pPropBag, pErrLog, pvarValue, phrError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2 *")] PROPBAG2* pPropBag, [NativeTypeName("VARIANT *")] VARIANT* pvarValue)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, uint, PROPBAG2*, VARIANT*, int>)(lpVtbl[4]))((IPropertyBag2*)Unsafe.AsPointer(ref this), cProperties, pPropBag, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CountProperties([NativeTypeName("ULONG *")] uint* pcProperties)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, uint*, int>)(lpVtbl[5]))((IPropertyBag2*)Unsafe.AsPointer(ref this), pcProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyInfo([NativeTypeName("ULONG")] uint iProperty, [NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2 *")] PROPBAG2* pPropBag, [NativeTypeName("ULONG *")] uint* pcProperties)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, uint, uint, PROPBAG2*, uint*, int>)(lpVtbl[6]))((IPropertyBag2*)Unsafe.AsPointer(ref this), iProperty, cProperties, pPropBag, pcProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadObject([NativeTypeName("LPCOLESTR")] ushort* pstrName, [NativeTypeName("DWORD")] uint dwHint, [NativeTypeName("IUnknown *")] IUnknown* pUnkObject, [NativeTypeName("IErrorLog *")] IErrorLog* pErrLog)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, ushort*, uint, IUnknown*, IErrorLog*, int>)(lpVtbl[7]))((IPropertyBag2*)Unsafe.AsPointer(ref this), pstrName, dwHint, pUnkObject, pErrLog);
        }
    }
}
