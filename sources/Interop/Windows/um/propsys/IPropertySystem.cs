// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CA724E8A-C3E6-442B-88A4-6FB0DB8035A3")]
    [NativeTypeName("struct IPropertySystem : IUnknown")]
    public unsafe partial struct IPropertySystem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertySystem*, Guid*, void**, int>)(lpVtbl[0]))((IPropertySystem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertySystem*, uint>)(lpVtbl[1]))((IPropertySystem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertySystem*, uint>)(lpVtbl[2]))((IPropertySystem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyDescription([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertySystem*, PROPERTYKEY*, Guid*, void**, int>)(lpVtbl[3]))((IPropertySystem*)Unsafe.AsPointer(ref this), propkey, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyDescriptionByName([NativeTypeName("LPCWSTR")] ushort* pszCanonicalName, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertySystem*, ushort*, Guid*, void**, int>)(lpVtbl[4]))((IPropertySystem*)Unsafe.AsPointer(ref this), pszCanonicalName, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyDescriptionListFromString([NativeTypeName("LPCWSTR")] ushort* pszPropList, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertySystem*, ushort*, Guid*, void**, int>)(lpVtbl[5]))((IPropertySystem*)Unsafe.AsPointer(ref this), pszPropList, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumeratePropertyDescriptions(PROPDESC_ENUMFILTER filterOn, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertySystem*, PROPDESC_ENUMFILTER, Guid*, void**, int>)(lpVtbl[6]))((IPropertySystem*)Unsafe.AsPointer(ref this), filterOn, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FormatForDisplay([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdff, [NativeTypeName("LPWSTR")] ushort* pszText, [NativeTypeName("DWORD")] uint cchText)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertySystem*, PROPERTYKEY*, PROPVARIANT*, PROPDESC_FORMAT_FLAGS, ushort*, uint, int>)(lpVtbl[7]))((IPropertySystem*)Unsafe.AsPointer(ref this), key, propvar, pdff, pszText, cchText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FormatForDisplayAlloc([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdff, [NativeTypeName("LPWSTR *")] ushort** ppszDisplay)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertySystem*, PROPERTYKEY*, PROPVARIANT*, PROPDESC_FORMAT_FLAGS, ushort**, int>)(lpVtbl[8]))((IPropertySystem*)Unsafe.AsPointer(ref this), key, propvar, pdff, ppszDisplay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterPropertySchema([NativeTypeName("LPCWSTR")] ushort* pszPath)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertySystem*, ushort*, int>)(lpVtbl[9]))((IPropertySystem*)Unsafe.AsPointer(ref this), pszPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterPropertySchema([NativeTypeName("LPCWSTR")] ushort* pszPath)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertySystem*, ushort*, int>)(lpVtbl[10]))((IPropertySystem*)Unsafe.AsPointer(ref this), pszPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RefreshPropertySchema()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertySystem*, int>)(lpVtbl[11]))((IPropertySystem*)Unsafe.AsPointer(ref this));
        }
    }
}
