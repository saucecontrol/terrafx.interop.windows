// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F917BC8A-1BBA-4478-A245-1BDE03EB9431")]
    [NativeTypeName("struct IPropertyChange : IObjectWithPropertyKey")]
    public unsafe partial struct IPropertyChange
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyChange*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyChange*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyChange*, uint>)(lpVtbl[1]))((IPropertyChange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyChange*, uint>)(lpVtbl[2]))((IPropertyChange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyChange*, PROPERTYKEY*, int>)(lpVtbl[3]))((IPropertyChange*)Unsafe.AsPointer(ref this), key);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyKey([NativeTypeName("PROPERTYKEY *")] PROPERTYKEY* pkey)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyChange*, PROPERTYKEY*, int>)(lpVtbl[4]))((IPropertyChange*)Unsafe.AsPointer(ref this), pkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ApplyToPropVariant([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvarOut)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyChange*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[5]))((IPropertyChange*)Unsafe.AsPointer(ref this), propvarIn, ppropvarOut);
        }
    }
}
