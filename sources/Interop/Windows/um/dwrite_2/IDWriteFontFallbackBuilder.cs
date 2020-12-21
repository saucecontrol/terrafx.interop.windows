// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FD882D06-8ABA-4FB8-B849-8BE8B73E14DE")]
    [NativeTypeName("struct IDWriteFontFallbackBuilder : IUnknown")]
    public unsafe partial struct IDWriteFontFallbackBuilder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, uint>)(lpVtbl[1]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, uint>)(lpVtbl[2]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddMapping([NativeTypeName("const DWRITE_UNICODE_RANGE *")] DWRITE_UNICODE_RANGE* ranges, [NativeTypeName("UINT32")] uint rangesCount, [NativeTypeName("const WCHAR **")] ushort** targetFamilyNames, [NativeTypeName("UINT32")] uint targetFamilyNamesCount, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* fontCollection = null, [NativeTypeName("const WCHAR *")] ushort* localeName = null, [NativeTypeName("const WCHAR *")] ushort* baseFamilyName = null, [NativeTypeName("FLOAT")] float scale = 1.0f)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, DWRITE_UNICODE_RANGE*, uint, ushort**, uint, IDWriteFontCollection*, ushort*, ushort*, float, int>)(lpVtbl[3]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddMappings([NativeTypeName("IDWriteFontFallback *")] IDWriteFontFallback* fontFallback)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, IDWriteFontFallback*, int>)(lpVtbl[4]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFallback([NativeTypeName("IDWriteFontFallback **")] IDWriteFontFallback** fontFallback)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, IDWriteFontFallback**, int>)(lpVtbl[5]))((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), fontFallback);
        }
    }
}
