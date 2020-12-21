// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E8EDA601-3D48-431A-AB44-69059BE88BBE")]
    [NativeTypeName("struct IWICPixelFormatInfo : IWICComponentInfo")]
    public unsafe partial struct IWICPixelFormatInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint>)(lpVtbl[1]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint>)(lpVtbl[2]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComponentType([NativeTypeName("WICComponentType *")] WICComponentType* pType)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, Guid*, int>)(lpVtbl[4]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint*, int>)(lpVtbl[5]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID *")] Guid* pguidVendor)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, Guid*, int>)(lpVtbl[7]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFormatGUID([NativeTypeName("GUID *")] Guid* pFormat)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, Guid*, int>)(lpVtbl[11]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorContext([NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContext)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, IWICColorContext**, int>)(lpVtbl[12]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), ppIColorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBitsPerPixel([NativeTypeName("UINT *")] uint* puiBitsPerPixel)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint*, int>)(lpVtbl[13]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), puiBitsPerPixel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount([NativeTypeName("UINT *")] uint* puiChannelCount)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint*, int>)(lpVtbl[14]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), puiChannelCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelMask([NativeTypeName("UINT")] uint uiChannelIndex, [NativeTypeName("UINT")] uint cbMaskBuffer, [NativeTypeName("BYTE *")] byte* pbMaskBuffer, [NativeTypeName("UINT *")] uint* pcbActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint, uint, byte*, uint*, int>)(lpVtbl[15]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), uiChannelIndex, cbMaskBuffer, pbMaskBuffer, pcbActual);
        }
    }
}
