// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5ACD6AA0-F482-11CE-8B67-00AA00A3F1A6")]
    [NativeTypeName("struct IConfigAviMux : IUnknown")]
    public unsafe partial struct IConfigAviMux
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IConfigAviMux*, Guid*, void**, int>)(lpVtbl[0]))((IConfigAviMux*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IConfigAviMux*, uint>)(lpVtbl[1]))((IConfigAviMux*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IConfigAviMux*, uint>)(lpVtbl[2]))((IConfigAviMux*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMasterStream([NativeTypeName("LONG")] int iStream)
        {
            return ((delegate* unmanaged[Stdcall]<IConfigAviMux*, int, int>)(lpVtbl[3]))((IConfigAviMux*)Unsafe.AsPointer(ref this), iStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMasterStream([NativeTypeName("LONG *")] int* pStream)
        {
            return ((delegate* unmanaged[Stdcall]<IConfigAviMux*, int*, int>)(lpVtbl[4]))((IConfigAviMux*)Unsafe.AsPointer(ref this), pStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputCompatibilityIndex([NativeTypeName("BOOL")] int fOldIndex)
        {
            return ((delegate* unmanaged[Stdcall]<IConfigAviMux*, int, int>)(lpVtbl[5]))((IConfigAviMux*)Unsafe.AsPointer(ref this), fOldIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputCompatibilityIndex([NativeTypeName("BOOL *")] int* pfOldIndex)
        {
            return ((delegate* unmanaged[Stdcall]<IConfigAviMux*, int*, int>)(lpVtbl[6]))((IConfigAviMux*)Unsafe.AsPointer(ref this), pfOldIndex);
        }
    }
}
