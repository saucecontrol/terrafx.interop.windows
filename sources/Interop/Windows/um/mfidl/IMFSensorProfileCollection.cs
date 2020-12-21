// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C95EA55B-0187-48BE-9353-8D2507662351")]
    [NativeTypeName("struct IMFSensorProfileCollection : IUnknown")]
    public unsafe partial struct IMFSensorProfileCollection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorProfileCollection*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorProfileCollection*, uint>)(lpVtbl[1]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorProfileCollection*, uint>)(lpVtbl[2]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint GetProfileCount()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorProfileCollection*, uint>)(lpVtbl[3]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProfile([NativeTypeName("DWORD")] uint Index, [NativeTypeName("IMFSensorProfile **")] IMFSensorProfile** ppProfile)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorProfileCollection*, uint, IMFSensorProfile**, int>)(lpVtbl[4]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this), Index, ppProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddProfile([NativeTypeName("IMFSensorProfile *")] IMFSensorProfile* pProfile)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorProfileCollection*, IMFSensorProfile*, int>)(lpVtbl[5]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this), pProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindProfile([NativeTypeName("SENSORPROFILEID *")] SENSORPROFILEID* ProfileId, [NativeTypeName("IMFSensorProfile **")] IMFSensorProfile** ppProfile)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorProfileCollection*, SENSORPROFILEID*, IMFSensorProfile**, int>)(lpVtbl[6]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this), ProfileId, ppProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RemoveProfileByIndex([NativeTypeName("DWORD")] uint Index)
        {
            ((delegate* unmanaged[Stdcall]<IMFSensorProfileCollection*, uint, void>)(lpVtbl[7]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RemoveProfile([NativeTypeName("SENSORPROFILEID *")] SENSORPROFILEID* ProfileId)
        {
            ((delegate* unmanaged[Stdcall]<IMFSensorProfileCollection*, SENSORPROFILEID*, void>)(lpVtbl[8]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this), ProfileId);
        }
    }
}
