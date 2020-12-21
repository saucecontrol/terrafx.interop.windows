// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BEBEE9CB-83B0-4DCC-8132-B0AAA55EAC96")]
    [NativeTypeName("struct IWICPlanarFormatConverter : IWICBitmapSource")]
    public unsafe partial struct IWICPlanarFormatConverter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, void**, int>)(lpVtbl[0]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, uint>)(lpVtbl[1]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, uint>)(lpVtbl[2]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, uint*, uint*, int>)(lpVtbl[3]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, int>)(lpVtbl[4]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResolution([NativeTypeName("double *")] double* pDpiX, [NativeTypeName("double *")] double* pDpiY)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, double*, double*, int>)(lpVtbl[5]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, IWICPalette*, int>)(lpVtbl[6]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, WICRect*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** ppPlanes, [NativeTypeName("UINT")] uint cPlanes, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat, WICBitmapDitherType dither, [NativeTypeName("IWICPalette *")] IWICPalette* pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, IWICBitmapSource**, uint, Guid*, WICBitmapDitherType, IWICPalette*, double, WICBitmapPaletteType, int>)(lpVtbl[8]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), ppPlanes, cPlanes, dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CanConvert([NativeTypeName("const WICPixelFormatGUID *")] Guid* pSrcPixelFormats, [NativeTypeName("UINT")] uint cSrcPlanes, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstPixelFormat, [NativeTypeName("BOOL *")] int* pfCanConvert)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPlanarFormatConverter*, Guid*, uint, Guid*, int*, int>)(lpVtbl[9]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pSrcPixelFormats, cSrcPlanes, dstPixelFormat, pfCanConvert);
        }
    }
}
