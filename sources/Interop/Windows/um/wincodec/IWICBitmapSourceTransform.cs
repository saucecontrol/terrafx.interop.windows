// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3B16811B-6A43-4EC9-B713-3D5A0C13B940")]
    [NativeTypeName("struct IWICBitmapSourceTransform : IUnknown")]
    public unsafe partial struct IWICBitmapSourceTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, uint>)(lpVtbl[1]))((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, uint>)(lpVtbl[2]))((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat, WICBitmapTransformOptions dstTransform, [NativeTypeName("UINT")] uint nStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, WICRect*, uint, uint, Guid*, WICBitmapTransformOptions, uint, uint, byte*, int>)(lpVtbl[3]))((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClosestSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, uint*, uint*, int>)(lpVtbl[4]))((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClosestPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Guid*, int>)(lpVtbl[5]))((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), pguidDstFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportTransform(WICBitmapTransformOptions dstTransform, [NativeTypeName("BOOL *")] int* pfIsSupported)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, WICBitmapTransformOptions, int*, int>)(lpVtbl[6]))((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), dstTransform, pfIsSupported);
        }
    }
}
