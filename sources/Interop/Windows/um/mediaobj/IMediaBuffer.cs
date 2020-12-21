// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("59EFF8B9-938C-4A26-82F2-95CB84CDC837")]
    [NativeTypeName("struct IMediaBuffer : IUnknown")]
    public unsafe partial struct IMediaBuffer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IMediaBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMediaBuffer*, uint>)(lpVtbl[1]))((IMediaBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMediaBuffer*, uint>)(lpVtbl[2]))((IMediaBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLength([NativeTypeName("DWORD")] uint cbLength)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaBuffer*, uint, int>)(lpVtbl[3]))((IMediaBuffer*)Unsafe.AsPointer(ref this), cbLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaxLength([NativeTypeName("DWORD *")] uint* pcbMaxLength)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaBuffer*, uint*, int>)(lpVtbl[4]))((IMediaBuffer*)Unsafe.AsPointer(ref this), pcbMaxLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBufferAndLength([NativeTypeName("BYTE **")] byte** ppBuffer, [NativeTypeName("DWORD *")] uint* pcbLength)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaBuffer*, byte**, uint*, int>)(lpVtbl[5]))((IMediaBuffer*)Unsafe.AsPointer(ref this), ppBuffer, pcbLength);
        }
    }
}
