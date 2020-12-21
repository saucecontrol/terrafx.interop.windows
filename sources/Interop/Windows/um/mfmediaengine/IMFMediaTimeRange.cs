// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB71A2FC-078A-414E-9DF9-8C2531B0AA6C")]
    [NativeTypeName("struct IMFMediaTimeRange : IUnknown")]
    public unsafe partial struct IMFMediaTimeRange
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaTimeRange*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaTimeRange*, uint>)(lpVtbl[1]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaTimeRange*, uint>)(lpVtbl[2]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint GetLength()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaTimeRange*, uint>)(lpVtbl[3]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStart([NativeTypeName("DWORD")] uint index, [NativeTypeName("double *")] double* pStart)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaTimeRange*, uint, double*, int>)(lpVtbl[4]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this), index, pStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnd([NativeTypeName("DWORD")] uint index, [NativeTypeName("double *")] double* pEnd)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaTimeRange*, uint, double*, int>)(lpVtbl[5]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this), index, pEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int ContainsTime(double time)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaTimeRange*, double, int>)(lpVtbl[6]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this), time);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddRange(double startTime, double endTime)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaTimeRange*, double, double, int>)(lpVtbl[7]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this), startTime, endTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clear()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaTimeRange*, int>)(lpVtbl[8]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this));
        }
    }
}
