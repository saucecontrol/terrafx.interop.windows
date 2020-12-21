// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("654A6BB3-E1A3-424A-9908-53A43A0DFDA0")]
    [NativeTypeName("struct IMFMediaEngineSrcElementsEx : IMFMediaEngineSrcElements")]
    public unsafe partial struct IMFMediaEngineSrcElementsEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint>)(lpVtbl[1]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint>)(lpVtbl[2]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint GetLength()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint>)(lpVtbl[3]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetURL([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pURL)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint, ushort**, int>)(lpVtbl[4]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this), index, pURL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetType([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint, ushort**, int>)(lpVtbl[5]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this), index, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMedia([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pMedia)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint, ushort**, int>)(lpVtbl[6]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this), index, pMedia);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddElement([NativeTypeName("BSTR")] ushort* pURL, [NativeTypeName("BSTR")] ushort* pType, [NativeTypeName("BSTR")] ushort* pMedia)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, ushort*, ushort*, ushort*, int>)(lpVtbl[7]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this), pURL, pType, pMedia);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllElements()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, int>)(lpVtbl[8]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddElementEx([NativeTypeName("BSTR")] ushort* pURL, [NativeTypeName("BSTR")] ushort* pType, [NativeTypeName("BSTR")] ushort* pMedia, [NativeTypeName("BSTR")] ushort* keySystem)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, ushort*, ushort*, ushort*, ushort*, int>)(lpVtbl[9]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this), pURL, pType, pMedia, keySystem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetKeySystem([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElementsEx*, uint, ushort**, int>)(lpVtbl[10]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this), index, pType);
        }
    }
}
