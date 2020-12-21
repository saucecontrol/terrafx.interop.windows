// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DE5072EE-DBE3-46DC-8A87-B6F631194751")]
    [NativeTypeName("struct IMFSensorActivitiesReportCallback : IUnknown")]
    public unsafe partial struct IMFSensorActivitiesReportCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorActivitiesReportCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorActivitiesReportCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorActivitiesReportCallback*, uint>)(lpVtbl[1]))((IMFSensorActivitiesReportCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorActivitiesReportCallback*, uint>)(lpVtbl[2]))((IMFSensorActivitiesReportCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnActivitiesReport([NativeTypeName("IMFSensorActivitiesReport *")] IMFSensorActivitiesReport* sensorActivitiesReport)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorActivitiesReportCallback*, IMFSensorActivitiesReport*, int>)(lpVtbl[3]))((IMFSensorActivitiesReportCallback*)Unsafe.AsPointer(ref this), sensorActivitiesReport);
        }
    }
}
