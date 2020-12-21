// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9FD52741-176D-4B36-8F51-CA8F933223BE")]
    [NativeTypeName("struct IAMClockSlave : IUnknown")]
    public unsafe partial struct IAMClockSlave
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAMClockSlave*, Guid*, void**, int>)(lpVtbl[0]))((IAMClockSlave*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAMClockSlave*, uint>)(lpVtbl[1]))((IAMClockSlave*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAMClockSlave*, uint>)(lpVtbl[2]))((IAMClockSlave*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetErrorTolerance([NativeTypeName("DWORD")] uint dwTolerance)
        {
            return ((delegate* unmanaged[Stdcall]<IAMClockSlave*, uint, int>)(lpVtbl[3]))((IAMClockSlave*)Unsafe.AsPointer(ref this), dwTolerance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetErrorTolerance([NativeTypeName("DWORD *")] uint* pdwTolerance)
        {
            return ((delegate* unmanaged[Stdcall]<IAMClockSlave*, uint*, int>)(lpVtbl[4]))((IAMClockSlave*)Unsafe.AsPointer(ref this), pdwTolerance);
        }
    }
}
