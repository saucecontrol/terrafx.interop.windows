// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("57D2EDED-5062-400E-B107-5DAE79FE57A6")]
    [NativeTypeName("struct IPropertyDescription2 : IPropertyDescription")]
    public unsafe partial struct IPropertyDescription2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, uint>)(lpVtbl[1]))((IPropertyDescription2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, uint>)(lpVtbl[2]))((IPropertyDescription2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyKey([NativeTypeName("PROPERTYKEY *")] PROPERTYKEY* pkey)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, PROPERTYKEY*, int>)(lpVtbl[3]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), pkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCanonicalName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, ushort**, int>)(lpVtbl[4]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), ppszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyType([NativeTypeName("VARTYPE *")] ushort* pvartype)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, ushort*, int>)(lpVtbl[5]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), pvartype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, ushort**, int>)(lpVtbl[6]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), ppszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEditInvitation([NativeTypeName("LPWSTR *")] ushort** ppszInvite)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, ushort**, int>)(lpVtbl[7]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), ppszInvite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeFlags(PROPDESC_TYPE_FLAGS mask, [NativeTypeName("PROPDESC_TYPE_FLAGS *")] PROPDESC_TYPE_FLAGS* ppdtFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, PROPDESC_TYPE_FLAGS, PROPDESC_TYPE_FLAGS*, int>)(lpVtbl[8]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), mask, ppdtFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewFlags([NativeTypeName("PROPDESC_VIEW_FLAGS *")] PROPDESC_VIEW_FLAGS* ppdvFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, PROPDESC_VIEW_FLAGS*, int>)(lpVtbl[9]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), ppdvFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultColumnWidth([NativeTypeName("UINT *")] uint* pcxChars)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, uint*, int>)(lpVtbl[10]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), pcxChars);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayType([NativeTypeName("PROPDESC_DISPLAYTYPE *")] PROPDESC_DISPLAYTYPE* pdisplaytype)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, PROPDESC_DISPLAYTYPE*, int>)(lpVtbl[11]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), pdisplaytype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColumnState([NativeTypeName("SHCOLSTATEF *")] uint* pcsFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, uint*, int>)(lpVtbl[12]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), pcsFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGroupingRange([NativeTypeName("PROPDESC_GROUPING_RANGE *")] PROPDESC_GROUPING_RANGE* pgr)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, PROPDESC_GROUPING_RANGE*, int>)(lpVtbl[13]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), pgr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRelativeDescriptionType([NativeTypeName("PROPDESC_RELATIVEDESCRIPTION_TYPE *")] PROPDESC_RELATIVEDESCRIPTION_TYPE* prdt)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, PROPDESC_RELATIVEDESCRIPTION_TYPE*, int>)(lpVtbl[14]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), prdt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRelativeDescription([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar1, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar2, [NativeTypeName("LPWSTR *")] ushort** ppszDesc1, [NativeTypeName("LPWSTR *")] ushort** ppszDesc2)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, PROPVARIANT*, PROPVARIANT*, ushort**, ushort**, int>)(lpVtbl[15]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), propvar1, propvar2, ppszDesc1, ppszDesc2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSortDescription([NativeTypeName("PROPDESC_SORTDESCRIPTION *")] PROPDESC_SORTDESCRIPTION* psd)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, PROPDESC_SORTDESCRIPTION*, int>)(lpVtbl[16]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), psd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSortDescriptionLabel([NativeTypeName("BOOL")] int fDescending, [NativeTypeName("LPWSTR *")] ushort** ppszDescription)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, int, ushort**, int>)(lpVtbl[17]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), fDescending, ppszDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAggregationType([NativeTypeName("PROPDESC_AGGREGATION_TYPE *")] PROPDESC_AGGREGATION_TYPE* paggtype)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, PROPDESC_AGGREGATION_TYPE*, int>)(lpVtbl[18]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), paggtype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetConditionType([NativeTypeName("PROPDESC_CONDITION_TYPE *")] PROPDESC_CONDITION_TYPE* pcontype, [NativeTypeName("CONDITION_OPERATION *")] CONDITION_OPERATION* popDefault)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, PROPDESC_CONDITION_TYPE*, CONDITION_OPERATION*, int>)(lpVtbl[19]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), pcontype, popDefault);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumTypeList([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, Guid*, void**, int>)(lpVtbl[20]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CoerceToCanonicalValue([NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, PROPVARIANT*, int>)(lpVtbl[21]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), ppropvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FormatForDisplay([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdfFlags, [NativeTypeName("LPWSTR *")] ushort** ppszDisplay)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, PROPVARIANT*, PROPDESC_FORMAT_FLAGS, ushort**, int>)(lpVtbl[22]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), propvar, pdfFlags, ppszDisplay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsValueCanonical([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, PROPVARIANT*, int>)(lpVtbl[23]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), propvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetImageReferenceForValue([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("LPWSTR *")] ushort** ppszImageRes)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescription2*, PROPVARIANT*, ushort**, int>)(lpVtbl[24]))((IPropertyDescription2*)Unsafe.AsPointer(ref this), propvar, ppszImageRes);
        }
    }
}
