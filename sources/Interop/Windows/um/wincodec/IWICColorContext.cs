// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3C613A02-34B2-44EA-9A7C-45AEA9C6FD6D")]
    [NativeTypeName("struct IWICColorContext : IUnknown")]
    public unsafe partial struct IWICColorContext
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, Guid*, void**, int>)(lpVtbl[0]))((IWICColorContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint>)(lpVtbl[1]))((IWICColorContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint>)(lpVtbl[2]))((IWICColorContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFilename)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, ushort*, int>)(lpVtbl[3]))((IWICColorContext*)Unsafe.AsPointer(ref this), wzFilename);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromMemory([NativeTypeName("const BYTE *")] byte* pbBuffer, [NativeTypeName("UINT")] uint cbBufferSize)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, byte*, uint, int>)(lpVtbl[4]))((IWICColorContext*)Unsafe.AsPointer(ref this), pbBuffer, cbBufferSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromExifColorSpace([NativeTypeName("UINT")] uint value)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, int>)(lpVtbl[5]))((IWICColorContext*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetType([NativeTypeName("WICColorContextType *")] WICColorContextType* pType)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, WICColorContextType*, int>)(lpVtbl[6]))((IWICColorContext*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProfileBytes([NativeTypeName("UINT")] uint cbBuffer, [NativeTypeName("BYTE *")] byte* pbBuffer, [NativeTypeName("UINT *")] uint* pcbActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, byte*, uint*, int>)(lpVtbl[7]))((IWICColorContext*)Unsafe.AsPointer(ref this), cbBuffer, pbBuffer, pcbActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetExifColorSpace([NativeTypeName("UINT *")] uint* pValue)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint*, int>)(lpVtbl[8]))((IWICColorContext*)Unsafe.AsPointer(ref this), pValue);
        }
    }
}
