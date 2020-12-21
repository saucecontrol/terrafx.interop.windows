// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("11E1FBF9-2D56-4A6B-8DB3-7CD193A471F2")]
    [NativeTypeName("struct IPropertyEnumType : IUnknown")]
    public unsafe partial struct IPropertyEnumType
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyEnumType*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyEnumType*, uint>)(lpVtbl[1]))((IPropertyEnumType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyEnumType*, uint>)(lpVtbl[2]))((IPropertyEnumType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumType([NativeTypeName("PROPENUMTYPE *")] PROPENUMTYPE* penumtype)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyEnumType*, PROPENUMTYPE*, int>)(lpVtbl[3]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), penumtype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyEnumType*, PROPVARIANT*, int>)(lpVtbl[4]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), ppropvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRangeMinValue([NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvarMin)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyEnumType*, PROPVARIANT*, int>)(lpVtbl[5]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), ppropvarMin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRangeSetValue([NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvarSet)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyEnumType*, PROPVARIANT*, int>)(lpVtbl[6]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), ppropvarSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayText([NativeTypeName("LPWSTR *")] ushort** ppszDisplay)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyEnumType*, ushort**, int>)(lpVtbl[7]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), ppszDisplay);
        }
    }
}
