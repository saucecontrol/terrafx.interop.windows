// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5BC8A76B-869A-46A3-9B03-FA218A66AEBE")]
    [NativeTypeName("struct IMFCollection : IUnknown")]
    public unsafe partial struct IMFCollection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFCollection*, Guid*, void**, int>)(lpVtbl[0]))((IMFCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFCollection*, uint>)(lpVtbl[1]))((IMFCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFCollection*, uint>)(lpVtbl[2]))((IMFCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetElementCount([NativeTypeName("DWORD *")] uint* pcElements)
        {
            return ((delegate* unmanaged[Stdcall]<IMFCollection*, uint*, int>)(lpVtbl[3]))((IMFCollection*)Unsafe.AsPointer(ref this), pcElements);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetElement([NativeTypeName("DWORD")] uint dwElementIndex, [NativeTypeName("IUnknown **")] IUnknown** ppUnkElement)
        {
            return ((delegate* unmanaged[Stdcall]<IMFCollection*, uint, IUnknown**, int>)(lpVtbl[4]))((IMFCollection*)Unsafe.AsPointer(ref this), dwElementIndex, ppUnkElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddElement([NativeTypeName("IUnknown *")] IUnknown* pUnkElement)
        {
            return ((delegate* unmanaged[Stdcall]<IMFCollection*, IUnknown*, int>)(lpVtbl[5]))((IMFCollection*)Unsafe.AsPointer(ref this), pUnkElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveElement([NativeTypeName("DWORD")] uint dwElementIndex, [NativeTypeName("IUnknown **")] IUnknown** ppUnkElement)
        {
            return ((delegate* unmanaged[Stdcall]<IMFCollection*, uint, IUnknown**, int>)(lpVtbl[6]))((IMFCollection*)Unsafe.AsPointer(ref this), dwElementIndex, ppUnkElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertElementAt([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged[Stdcall]<IMFCollection*, uint, IUnknown*, int>)(lpVtbl[7]))((IMFCollection*)Unsafe.AsPointer(ref this), dwIndex, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllElements()
        {
            return ((delegate* unmanaged[Stdcall]<IMFCollection*, int>)(lpVtbl[8]))((IMFCollection*)Unsafe.AsPointer(ref this));
        }
    }
}
