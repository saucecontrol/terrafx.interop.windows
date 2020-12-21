// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B8AAB0CF-346F-49D8-9499-C8B03F161D51")]
    [NativeTypeName("struct ISpObjectTokenInit : ISpObjectToken")]
    public unsafe partial struct ISpObjectTokenInit
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, Guid*, void**, int>)(lpVtbl[0]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, uint>)(lpVtbl[1]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, uint>)(lpVtbl[2]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG")] uint cbData, [NativeTypeName("const BYTE *")] byte* pData)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, ushort*, uint, byte*, int>)(lpVtbl[3]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszValueName, cbData, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG *")] uint* pcbData, [NativeTypeName("BYTE *")] byte* pData)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, ushort*, uint*, byte*, int>)(lpVtbl[4]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszValueName, pcbData, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPCWSTR")] ushort* pszValue)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, ushort*, ushort*, int>)(lpVtbl[5]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszValueName, pszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPWSTR *")] ushort** ppszValue)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, ushort*, ushort**, int>)(lpVtbl[6]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszValueName, ppszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD")] uint dwValue)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, ushort*, uint, int>)(lpVtbl[7]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszValueName, dwValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD *")] uint* pdwValue)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, ushort*, uint*, int>)(lpVtbl[8]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszValueName, pdwValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenKey([NativeTypeName("LPCWSTR")] ushort* pszSubKeyName, [NativeTypeName("ISpDataKey **")] ISpDataKey** ppSubKey)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, ushort*, ISpDataKey**, int>)(lpVtbl[9]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszSubKeyName, ppSubKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey, [NativeTypeName("ISpDataKey **")] ISpDataKey** ppSubKey)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, ushort*, ISpDataKey**, int>)(lpVtbl[10]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszSubKey, ppSubKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, ushort*, int>)(lpVtbl[11]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszSubKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteValue([NativeTypeName("LPCWSTR")] ushort* pszValueName)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, ushort*, int>)(lpVtbl[12]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszValueName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumKeys([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszSubKeyName)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, uint, ushort**, int>)(lpVtbl[13]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), Index, ppszSubKeyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumValues([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszValueName)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, uint, ushort**, int>)(lpVtbl[14]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), Index, ppszValueName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetId([NativeTypeName("LPCWSTR")] ushort* pszCategoryId, [NativeTypeName("LPCWSTR")] ushort* pszTokenId, [NativeTypeName("BOOL")] int fCreateIfNotExist)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, ushort*, ushort*, int, int>)(lpVtbl[15]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszCategoryId, pszTokenId, fCreateIfNotExist);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetId([NativeTypeName("LPWSTR *")] ushort** ppszCoMemTokenId)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, ushort**, int>)(lpVtbl[16]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), ppszCoMemTokenId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCategory([NativeTypeName("ISpObjectTokenCategory **")] ISpObjectTokenCategory** ppTokenCategory)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, ISpObjectTokenCategory**, int>)(lpVtbl[17]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), ppTokenCategory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, IUnknown*, uint, Guid*, void**, int>)(lpVtbl[18]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pUnkOuter, dwClsContext, riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStorageFileName([NativeTypeName("const IID &")] Guid* clsidCaller, [NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPCWSTR")] ushort* pszFileNameSpecifier, [NativeTypeName("ULONG")] uint nFolder, [NativeTypeName("LPWSTR *")] ushort** ppszFilePath)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, Guid*, ushort*, ushort*, uint, ushort**, int>)(lpVtbl[19]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), clsidCaller, pszValueName, pszFileNameSpecifier, nFolder, ppszFilePath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveStorageFileName([NativeTypeName("const IID &")] Guid* clsidCaller, [NativeTypeName("LPCWSTR")] ushort* pszKeyName, [NativeTypeName("BOOL")] int fDeleteFile)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, Guid*, ushort*, int, int>)(lpVtbl[20]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), clsidCaller, pszKeyName, fDeleteFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Remove([NativeTypeName("const CLSID *")] Guid* pclsidCaller)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, Guid*, int>)(lpVtbl[21]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pclsidCaller);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsUISupported([NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, [NativeTypeName("void *")] void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, [NativeTypeName("IUnknown *")] IUnknown* punkObject, [NativeTypeName("BOOL *")] int* pfSupported)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, ushort*, void*, uint, IUnknown*, int*, int>)(lpVtbl[22]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszTypeOfUI, pvExtraData, cbExtraData, punkObject, pfSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DisplayUI([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, [NativeTypeName("void *")] void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, [NativeTypeName("IUnknown *")] IUnknown* punkObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, IntPtr, ushort*, ushort*, void*, uint, IUnknown*, int>)(lpVtbl[23]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), hwndParent, pszTitle, pszTypeOfUI, pvExtraData, cbExtraData, punkObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MatchesAttributes([NativeTypeName("LPCWSTR")] ushort* pszAttributes, [NativeTypeName("BOOL *")] int* pfMatches)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, ushort*, int*, int>)(lpVtbl[24]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszAttributes, pfMatches);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitFromDataKey([NativeTypeName("LPCWSTR")] ushort* pszCategoryId, [NativeTypeName("LPCWSTR")] ushort* pszTokenId, [NativeTypeName("ISpDataKey *")] ISpDataKey* pDataKey)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectTokenInit*, ushort*, ushort*, ISpDataKey*, int>)(lpVtbl[25]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszCategoryId, pszTokenId, pDataKey);
        }
    }
}
