// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B66F034F-D0E2-40AB-B436-6DE39E321A94")]
    [NativeTypeName("struct IWICColorTransform : IWICBitmapSource")]
    public unsafe partial struct IWICColorTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Guid*, void**, int>)(lpVtbl[0]))((IWICColorTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint>)(lpVtbl[1]))((IWICColorTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint>)(lpVtbl[2]))((IWICColorTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint*, uint*, int>)(lpVtbl[3]))((IWICColorTransform*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Guid*, int>)(lpVtbl[4]))((IWICColorTransform*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResolution([NativeTypeName("double *")] double* pDpiX, [NativeTypeName("double *")] double* pDpiY)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, double*, double*, int>)(lpVtbl[5]))((IWICColorTransform*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICPalette*, int>)(lpVtbl[6]))((IWICColorTransform*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, WICRect*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICColorTransform*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIBitmapSource, [NativeTypeName("IWICColorContext *")] IWICColorContext* pIContextSource, [NativeTypeName("IWICColorContext *")] IWICColorContext* pIContextDest, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFmtDest)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)(lpVtbl[8]))((IWICColorTransform*)Unsafe.AsPointer(ref this), pIBitmapSource, pIContextSource, pIContextDest, pixelFmtDest);
        }
    }
}
