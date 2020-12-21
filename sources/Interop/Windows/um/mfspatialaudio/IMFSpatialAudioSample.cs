// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfspatialaudio.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ABF28A9B-3393-4290-BA79-5FFC46D986B2")]
    [NativeTypeName("struct IMFSpatialAudioSample : IMFSample")]
    public unsafe partial struct IMFSpatialAudioSample
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, void**, int>)(lpVtbl[0]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, uint>)(lpVtbl[1]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, uint>)(lpVtbl[2]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("MF_ATTRIBUTE_TYPE *")] MF_ATTRIBUTE_TYPE* pType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, PROPVARIANT*, int*, int>)(lpVtbl[5]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Compare([NativeTypeName("IMFAttributes *")] IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, int*, int>)(lpVtbl[6]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, uint*, int>)(lpVtbl[7]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("double *")] double* pfValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, double*, int>)(lpVtbl[9]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, pfValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("GUID *")] Guid* pguidValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, uint*, int>)(lpVtbl[11]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, uint*, int>)(lpVtbl[14]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, int>)(lpVtbl[19]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteAllItems()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, int>)(lpVtbl[20]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, uint, int>)(lpVtbl[21]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, ulong, int>)(lpVtbl[22]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, double, int>)(lpVtbl[23]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, fValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, guidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, wszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockStore()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, int>)(lpVtbl[28]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockStore()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, int>)(lpVtbl[29]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, uint*, int>)(lpVtbl[30]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), pcItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, [NativeTypeName("GUID *")] Guid* pguidKey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyAllItems([NativeTypeName("IMFAttributes *")] IMFAttributes* pDest)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, IMFAttributes*, int>)(lpVtbl[32]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), pDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSampleFlags([NativeTypeName("DWORD *")] uint* pdwSampleFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, uint*, int>)(lpVtbl[33]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), pdwSampleFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSampleFlags([NativeTypeName("DWORD")] uint dwSampleFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, uint, int>)(lpVtbl[34]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), dwSampleFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSampleTime([NativeTypeName("LONGLONG *")] long* phnsSampleTime)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, long*, int>)(lpVtbl[35]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), phnsSampleTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSampleTime([NativeTypeName("LONGLONG")] long hnsSampleTime)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, long, int>)(lpVtbl[36]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), hnsSampleTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSampleDuration([NativeTypeName("LONGLONG *")] long* phnsSampleDuration)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, long*, int>)(lpVtbl[37]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), phnsSampleDuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSampleDuration([NativeTypeName("LONGLONG")] long hnsSampleDuration)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, long, int>)(lpVtbl[38]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), hnsSampleDuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBufferCount([NativeTypeName("DWORD *")] uint* pdwBufferCount)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, uint*, int>)(lpVtbl[39]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), pdwBufferCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBufferByIndex([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, uint, IMFMediaBuffer**, int>)(lpVtbl[40]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), dwIndex, ppBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ConvertToContiguousBuffer([NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, IMFMediaBuffer**, int>)(lpVtbl[41]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), ppBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddBuffer([NativeTypeName("IMFMediaBuffer *")] IMFMediaBuffer* pBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, IMFMediaBuffer*, int>)(lpVtbl[42]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), pBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveBufferByIndex([NativeTypeName("DWORD")] uint dwIndex)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, uint, int>)(lpVtbl[43]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), dwIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllBuffers()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, int>)(lpVtbl[44]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTotalLength([NativeTypeName("DWORD *")] uint* pcbTotalLength)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, uint*, int>)(lpVtbl[45]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), pcbTotalLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyToBuffer([NativeTypeName("IMFMediaBuffer *")] IMFMediaBuffer* pBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, IMFMediaBuffer*, int>)(lpVtbl[46]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), pBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetObjectCount([NativeTypeName("DWORD *")] uint* pdwObjectCount)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, uint*, int>)(lpVtbl[47]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), pdwObjectCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddSpatialAudioObject([NativeTypeName("IMFSpatialAudioObjectBuffer *")] IMFSpatialAudioObjectBuffer* pAudioObjBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, IMFSpatialAudioObjectBuffer*, int>)(lpVtbl[48]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), pAudioObjBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpatialAudioObjectByIndex([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("IMFSpatialAudioObjectBuffer **")] IMFSpatialAudioObjectBuffer** ppAudioObjBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSpatialAudioSample*, uint, IMFSpatialAudioObjectBuffer**, int>)(lpVtbl[49]))((IMFSpatialAudioSample*)Unsafe.AsPointer(ref this), dwIndex, ppAudioObjBuffer);
        }
    }
}
