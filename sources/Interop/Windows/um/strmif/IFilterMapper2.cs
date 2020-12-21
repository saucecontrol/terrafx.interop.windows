// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B79BB0B0-33C1-11D1-ABE1-00A0C905F375")]
    [NativeTypeName("struct IFilterMapper2 : IUnknown")]
    public unsafe partial struct IFilterMapper2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterMapper2*, Guid*, void**, int>)(lpVtbl[0]))((IFilterMapper2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IFilterMapper2*, uint>)(lpVtbl[1]))((IFilterMapper2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IFilterMapper2*, uint>)(lpVtbl[2]))((IFilterMapper2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCategory([NativeTypeName("const IID &")] Guid* clsidCategory, [NativeTypeName("DWORD")] uint dwCategoryMerit, [NativeTypeName("LPCWSTR")] ushort* Description)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterMapper2*, Guid*, uint, ushort*, int>)(lpVtbl[3]))((IFilterMapper2*)Unsafe.AsPointer(ref this), clsidCategory, dwCategoryMerit, Description);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterFilter([NativeTypeName("const CLSID *")] Guid* pclsidCategory, [NativeTypeName("LPCOLESTR")] ushort* szInstance, [NativeTypeName("const IID &")] Guid* Filter)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterMapper2*, Guid*, ushort*, Guid*, int>)(lpVtbl[4]))((IFilterMapper2*)Unsafe.AsPointer(ref this), pclsidCategory, szInstance, Filter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterFilter([NativeTypeName("const IID &")] Guid* clsidFilter, [NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("IMoniker **")] IMoniker** ppMoniker, [NativeTypeName("const CLSID *")] Guid* pclsidCategory, [NativeTypeName("LPCOLESTR")] ushort* szInstance, [NativeTypeName("const REGFILTER2 *")] REGFILTER2* prf2)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterMapper2*, Guid*, ushort*, IMoniker**, Guid*, ushort*, REGFILTER2*, int>)(lpVtbl[5]))((IFilterMapper2*)Unsafe.AsPointer(ref this), clsidFilter, Name, ppMoniker, pclsidCategory, szInstance, prf2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumMatchingFilters([NativeTypeName("IEnumMoniker **")] IEnumMoniker** ppEnum, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int bExactMatch, [NativeTypeName("DWORD")] uint dwMerit, [NativeTypeName("BOOL")] int bInputNeeded, [NativeTypeName("DWORD")] uint cInputTypes, [NativeTypeName("const GUID *")] Guid* pInputTypes, [NativeTypeName("const REGPINMEDIUM *")] REGPINMEDIUM* pMedIn, [NativeTypeName("const CLSID *")] Guid* pPinCategoryIn, [NativeTypeName("BOOL")] int bRender, [NativeTypeName("BOOL")] int bOutputNeeded, [NativeTypeName("DWORD")] uint cOutputTypes, [NativeTypeName("const GUID *")] Guid* pOutputTypes, [NativeTypeName("const REGPINMEDIUM *")] REGPINMEDIUM* pMedOut, [NativeTypeName("const CLSID *")] Guid* pPinCategoryOut)
        {
            return ((delegate* unmanaged[Stdcall]<IFilterMapper2*, IEnumMoniker**, uint, int, uint, int, uint, Guid*, REGPINMEDIUM*, Guid*, int, int, uint, Guid*, REGPINMEDIUM*, Guid*, int>)(lpVtbl[6]))((IFilterMapper2*)Unsafe.AsPointer(ref this), ppEnum, dwFlags, bExactMatch, dwMerit, bInputNeeded, cInputTypes, pInputTypes, pMedIn, pPinCategoryIn, bRender, bOutputNeeded, cOutputTypes, pOutputTypes, pMedOut, pPinCategoryOut);
        }
    }
}
