// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("94C9B4EE-A09F-4F92-8A1E-4A9BCE7E76FB")]
    [NativeTypeName("struct IWICBitmapEncoderInfo : IWICBitmapCodecInfo")]
    public unsafe partial struct IWICBitmapEncoderInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint>)(lpVtbl[1]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint>)(lpVtbl[2]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComponentType([NativeTypeName("WICComponentType *")] WICComponentType* pType)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, int>)(lpVtbl[4]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint*, int>)(lpVtbl[5]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID *")] Guid* pguidVendor)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, int>)(lpVtbl[7]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, int>)(lpVtbl[11]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormats([NativeTypeName("UINT")] uint cFormats, [NativeTypeName("GUID *")] Guid* pguidPixelFormats, [NativeTypeName("UINT *")] uint* pcActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, Guid*, uint*, int>)(lpVtbl[12]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cFormats, pguidPixelFormats, pcActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorManagementVersion([NativeTypeName("UINT")] uint cchColorManagementVersion, [NativeTypeName("WCHAR *")] ushort* wzColorManagementVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[13]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchColorManagementVersion, wzColorManagementVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer([NativeTypeName("UINT")] uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[14]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels([NativeTypeName("UINT")] uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[15]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMimeTypes([NativeTypeName("UINT")] uint cchMimeTypes, [NativeTypeName("WCHAR *")] ushort* wzMimeTypes, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[16]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchMimeTypes, wzMimeTypes, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileExtensions([NativeTypeName("UINT")] uint cchFileExtensions, [NativeTypeName("WCHAR *")] ushort* wzFileExtensions, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[17]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchFileExtensions, wzFileExtensions, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportAnimation([NativeTypeName("BOOL *")] int* pfSupportAnimation)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, int*, int>)(lpVtbl[18]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportAnimation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportChromakey([NativeTypeName("BOOL *")] int* pfSupportChromakey)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, int*, int>)(lpVtbl[19]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportChromakey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportLossless([NativeTypeName("BOOL *")] int* pfSupportLossless)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, int*, int>)(lpVtbl[20]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportLossless);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportMultiframe([NativeTypeName("BOOL *")] int* pfSupportMultiframe)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, int*, int>)(lpVtbl[21]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportMultiframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MatchesMimeType([NativeTypeName("LPCWSTR")] ushort* wzMimeType, [NativeTypeName("BOOL *")] int* pfMatches)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, ushort*, int*, int>)(lpVtbl[22]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), wzMimeType, pfMatches);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IWICBitmapEncoder **")] IWICBitmapEncoder** ppIBitmapEncoder)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, IWICBitmapEncoder**, int>)(lpVtbl[23]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), ppIBitmapEncoder);
        }
    }
}
