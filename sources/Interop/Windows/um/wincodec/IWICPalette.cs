// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000040-A8F2-4877-BA0A-FD2B6645FB94")]
    [NativeTypeName("struct IWICPalette : IUnknown")]
    public unsafe partial struct IWICPalette
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPalette*, Guid*, void**, int>)(lpVtbl[0]))((IWICPalette*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IWICPalette*, uint>)(lpVtbl[1]))((IWICPalette*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IWICPalette*, uint>)(lpVtbl[2]))((IWICPalette*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializePredefined(WICBitmapPaletteType ePaletteType, [NativeTypeName("BOOL")] int fAddTransparentColor)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPalette*, WICBitmapPaletteType, int, int>)(lpVtbl[3]))((IWICPalette*)Unsafe.AsPointer(ref this), ePaletteType, fAddTransparentColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeCustom([NativeTypeName("WICColor *")] uint* pColors, [NativeTypeName("UINT")] uint cCount)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPalette*, uint*, uint, int>)(lpVtbl[4]))((IWICPalette*)Unsafe.AsPointer(ref this), pColors, cCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pISurface, [NativeTypeName("UINT")] uint cCount, [NativeTypeName("BOOL")] int fAddTransparentColor)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPalette*, IWICBitmapSource*, uint, int, int>)(lpVtbl[5]))((IWICPalette*)Unsafe.AsPointer(ref this), pISurface, cCount, fAddTransparentColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPalette*, IWICPalette*, int>)(lpVtbl[6]))((IWICPalette*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetType([NativeTypeName("WICBitmapPaletteType *")] WICBitmapPaletteType* pePaletteType)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPalette*, WICBitmapPaletteType*, int>)(lpVtbl[7]))((IWICPalette*)Unsafe.AsPointer(ref this), pePaletteType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorCount([NativeTypeName("UINT *")] uint* pcCount)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPalette*, uint*, int>)(lpVtbl[8]))((IWICPalette*)Unsafe.AsPointer(ref this), pcCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColors([NativeTypeName("UINT")] uint cCount, [NativeTypeName("WICColor *")] uint* pColors, [NativeTypeName("UINT *")] uint* pcActualColors)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPalette*, uint, uint*, uint*, int>)(lpVtbl[9]))((IWICPalette*)Unsafe.AsPointer(ref this), cCount, pColors, pcActualColors);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsBlackWhite([NativeTypeName("BOOL *")] int* pfIsBlackWhite)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPalette*, int*, int>)(lpVtbl[10]))((IWICPalette*)Unsafe.AsPointer(ref this), pfIsBlackWhite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsGrayscale([NativeTypeName("BOOL *")] int* pfIsGrayscale)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPalette*, int*, int>)(lpVtbl[11]))((IWICPalette*)Unsafe.AsPointer(ref this), pfIsGrayscale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HasAlpha([NativeTypeName("BOOL *")] int* pfHasAlpha)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPalette*, int*, int>)(lpVtbl[12]))((IWICPalette*)Unsafe.AsPointer(ref this), pfHasAlpha);
        }
    }
}
