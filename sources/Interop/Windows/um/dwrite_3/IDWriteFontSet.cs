// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("53585141-D9F8-4095-8321-D73CF6BD116B")]
    [NativeTypeName("struct IDWriteFontSet : IUnknown")]
    public unsafe partial struct IDWriteFontSet
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint>)(lpVtbl[1]))((IDWriteFontSet*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint>)(lpVtbl[2]))((IDWriteFontSet*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontCount()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint>)(lpVtbl[3]))((IDWriteFontSet*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint, IDWriteFontFaceReference**, int>)(lpVtbl[4]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindFontFaceReference([NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference, [NativeTypeName("UINT32 *")] uint* listIndex, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFaceReference*, uint*, int*, int>)(lpVtbl[5]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), fontFaceReference, listIndex, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindFontFace([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("UINT32 *")] uint* listIndex, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFace*, uint*, int*, int>)(lpVtbl[6]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), fontFace, listIndex, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyValues([NativeTypeName("UINT32")] uint listIndex, DWRITE_FONT_PROPERTY_ID propertyId, [NativeTypeName("BOOL *")] int* exists, [NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** values)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint, DWRITE_FONT_PROPERTY_ID, int*, IDWriteLocalizedStrings**, int>)(lpVtbl[7]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), listIndex, propertyId, exists, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, [NativeTypeName("const WCHAR *")] ushort* preferredLocaleNames, [NativeTypeName("IDWriteStringList **")] IDWriteStringList** values)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, DWRITE_FONT_PROPERTY_ID, ushort*, IDWriteStringList**, int>)(lpVtbl[8]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), propertyID, preferredLocaleNames, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, [NativeTypeName("IDWriteStringList **")] IDWriteStringList** values)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, DWRITE_FONT_PROPERTY_ID, IDWriteStringList**, int>)(lpVtbl[9]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), propertyID, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyOccurrenceCount([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* property, [NativeTypeName("UINT32 *")] uint* propertyOccurrenceCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, DWRITE_FONT_PROPERTY*, uint*, int>)(lpVtbl[10]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), property, propertyOccurrenceCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, [NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** filteredSet)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, DWRITE_FONT_PROPERTY*, uint, IDWriteFontSet**, int>)(lpVtbl[11]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), properties, propertyCount, filteredSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts([NativeTypeName("const WCHAR *")] ushort* familyName, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, [NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** filteredSet)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, ushort*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontSet**, int>)(lpVtbl[12]))((IDWriteFontSet*)Unsafe.AsPointer(ref this), familyName, fontWeight, fontStretch, fontStyle, filteredSet);
        }
    }
}
