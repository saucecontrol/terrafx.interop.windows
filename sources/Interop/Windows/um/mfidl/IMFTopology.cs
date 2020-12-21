// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("83CF873A-F6DA-4BC8-823F-BACFD55DC433")]
    [NativeTypeName("struct IMFTopology : IMFAttributes")]
    public unsafe partial struct IMFTopology
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, void**, int>)(lpVtbl[0]))((IMFTopology*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, uint>)(lpVtbl[1]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, uint>)(lpVtbl[2]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("MF_ATTRIBUTE_TYPE *")] MF_ATTRIBUTE_TYPE* pType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, PROPVARIANT*, int*, int>)(lpVtbl[5]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Compare([NativeTypeName("IMFAttributes *")] IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, int*, int>)(lpVtbl[6]))((IMFTopology*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, uint*, int>)(lpVtbl[7]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("double *")] double* pfValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, double*, int>)(lpVtbl[9]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pfValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("GUID *")] Guid* pguidValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, uint*, int>)(lpVtbl[11]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, uint*, int>)(lpVtbl[14]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, int>)(lpVtbl[19]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteAllItems()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, int>)(lpVtbl[20]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, uint, int>)(lpVtbl[21]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, ulong, int>)(lpVtbl[22]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, double, int>)(lpVtbl[23]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, fValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, guidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, wszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockStore()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, int>)(lpVtbl[28]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockStore()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, int>)(lpVtbl[29]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, uint*, int>)(lpVtbl[30]))((IMFTopology*)Unsafe.AsPointer(ref this), pcItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, [NativeTypeName("GUID *")] Guid* pguidKey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFTopology*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyAllItems([NativeTypeName("IMFAttributes *")] IMFAttributes* pDest)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, IMFAttributes*, int>)(lpVtbl[32]))((IMFTopology*)Unsafe.AsPointer(ref this), pDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTopologyID([NativeTypeName("TOPOID *")] ulong* pID)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, ulong*, int>)(lpVtbl[33]))((IMFTopology*)Unsafe.AsPointer(ref this), pID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddNode([NativeTypeName("IMFTopologyNode *")] IMFTopologyNode* pNode)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, IMFTopologyNode*, int>)(lpVtbl[34]))((IMFTopology*)Unsafe.AsPointer(ref this), pNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveNode([NativeTypeName("IMFTopologyNode *")] IMFTopologyNode* pNode)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, IMFTopologyNode*, int>)(lpVtbl[35]))((IMFTopology*)Unsafe.AsPointer(ref this), pNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNodeCount([NativeTypeName("WORD *")] ushort* pwNodes)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, ushort*, int>)(lpVtbl[36]))((IMFTopology*)Unsafe.AsPointer(ref this), pwNodes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNode([NativeTypeName("WORD")] ushort wIndex, [NativeTypeName("IMFTopologyNode **")] IMFTopologyNode** ppNode)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, ushort, IMFTopologyNode**, int>)(lpVtbl[37]))((IMFTopology*)Unsafe.AsPointer(ref this), wIndex, ppNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clear()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, int>)(lpVtbl[38]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CloneFrom([NativeTypeName("IMFTopology *")] IMFTopology* pTopology)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, IMFTopology*, int>)(lpVtbl[39]))((IMFTopology*)Unsafe.AsPointer(ref this), pTopology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNodeByID([NativeTypeName("TOPOID")] ulong qwTopoNodeID, [NativeTypeName("IMFTopologyNode **")] IMFTopologyNode** ppNode)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, ulong, IMFTopologyNode**, int>)(lpVtbl[40]))((IMFTopology*)Unsafe.AsPointer(ref this), qwTopoNodeID, ppNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourceNodeCollection([NativeTypeName("IMFCollection **")] IMFCollection** ppCollection)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, IMFCollection**, int>)(lpVtbl[41]))((IMFTopology*)Unsafe.AsPointer(ref this), ppCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputNodeCollection([NativeTypeName("IMFCollection **")] IMFCollection** ppCollection)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTopology*, IMFCollection**, int>)(lpVtbl[42]))((IMFTopology*)Unsafe.AsPointer(ref this), ppCollection);
        }
    }
}
