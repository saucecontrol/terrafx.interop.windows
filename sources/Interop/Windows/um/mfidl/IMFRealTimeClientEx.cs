// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("03910848-AB16-4611-B100-17B88AE2F248")]
    [NativeTypeName("struct IMFRealTimeClientEx : IUnknown")]
    public unsafe partial struct IMFRealTimeClientEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFRealTimeClientEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFRealTimeClientEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFRealTimeClientEx*, uint>)(lpVtbl[1]))((IMFRealTimeClientEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFRealTimeClientEx*, uint>)(lpVtbl[2]))((IMFRealTimeClientEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterThreadsEx([NativeTypeName("DWORD *")] uint* pdwTaskIndex, [NativeTypeName("LPCWSTR")] ushort* wszClassName, [NativeTypeName("LONG")] int lBasePriority)
        {
            return ((delegate* unmanaged[Stdcall]<IMFRealTimeClientEx*, uint*, ushort*, int, int>)(lpVtbl[3]))((IMFRealTimeClientEx*)Unsafe.AsPointer(ref this), pdwTaskIndex, wszClassName, lBasePriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterThreads()
        {
            return ((delegate* unmanaged[Stdcall]<IMFRealTimeClientEx*, int>)(lpVtbl[4]))((IMFRealTimeClientEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWorkQueueEx([NativeTypeName("DWORD")] uint dwMultithreadedWorkQueueId, [NativeTypeName("LONG")] int lWorkItemBasePriority)
        {
            return ((delegate* unmanaged[Stdcall]<IMFRealTimeClientEx*, uint, int, int>)(lpVtbl[5]))((IMFRealTimeClientEx*)Unsafe.AsPointer(ref this), dwMultithreadedWorkQueueId, lWorkItemBasePriority);
        }
    }
}
