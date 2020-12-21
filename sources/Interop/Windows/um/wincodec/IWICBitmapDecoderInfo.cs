// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D8CD007F-D08F-4191-9BFC-236EA7F0E4B5")]
    [NativeTypeName("struct IWICBitmapDecoderInfo : IWICBitmapCodecInfo")]
    public unsafe partial struct IWICBitmapDecoderInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint>)(lpVtbl[1]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint>)(lpVtbl[2]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComponentType([NativeTypeName("WICComponentType *")] WICComponentType* pType)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Guid*, int>)(lpVtbl[4]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint*, int>)(lpVtbl[5]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID *")] Guid* pguidVendor)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Guid*, int>)(lpVtbl[7]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Guid*, int>)(lpVtbl[11]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormats([NativeTypeName("UINT")] uint cFormats, [NativeTypeName("GUID *")] Guid* pguidPixelFormats, [NativeTypeName("UINT *")] uint* pcActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, Guid*, uint*, int>)(lpVtbl[12]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cFormats, pguidPixelFormats, pcActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorManagementVersion([NativeTypeName("UINT")] uint cchColorManagementVersion, [NativeTypeName("WCHAR *")] ushort* wzColorManagementVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[13]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchColorManagementVersion, wzColorManagementVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer([NativeTypeName("UINT")] uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[14]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels([NativeTypeName("UINT")] uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[15]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMimeTypes([NativeTypeName("UINT")] uint cchMimeTypes, [NativeTypeName("WCHAR *")] ushort* wzMimeTypes, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[16]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchMimeTypes, wzMimeTypes, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileExtensions([NativeTypeName("UINT")] uint cchFileExtensions, [NativeTypeName("WCHAR *")] ushort* wzFileExtensions, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[17]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchFileExtensions, wzFileExtensions, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportAnimation([NativeTypeName("BOOL *")] int* pfSupportAnimation)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, int*, int>)(lpVtbl[18]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportAnimation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportChromakey([NativeTypeName("BOOL *")] int* pfSupportChromakey)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, int*, int>)(lpVtbl[19]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportChromakey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportLossless([NativeTypeName("BOOL *")] int* pfSupportLossless)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, int*, int>)(lpVtbl[20]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportLossless);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportMultiframe([NativeTypeName("BOOL *")] int* pfSupportMultiframe)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, int*, int>)(lpVtbl[21]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportMultiframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MatchesMimeType([NativeTypeName("LPCWSTR")] ushort* wzMimeType, [NativeTypeName("BOOL *")] int* pfMatches)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, ushort*, int*, int>)(lpVtbl[22]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), wzMimeType, pfMatches);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPatterns([NativeTypeName("UINT")] uint cbSizePatterns, [NativeTypeName("WICBitmapPattern *")] WICBitmapPattern* pPatterns, [NativeTypeName("UINT *")] uint* pcPatterns, [NativeTypeName("UINT *")] uint* pcbPatternsActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, WICBitmapPattern*, uint*, uint*, int>)(lpVtbl[23]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cbSizePatterns, pPatterns, pcPatterns, pcbPatternsActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MatchesPattern([NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("BOOL *")] int* pfMatches)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, IStream*, int*, int>)(lpVtbl[24]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pIStream, pfMatches);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIBitmapDecoder)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, IWICBitmapDecoder**, int>)(lpVtbl[25]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), ppIBitmapDecoder);
        }
    }
}
