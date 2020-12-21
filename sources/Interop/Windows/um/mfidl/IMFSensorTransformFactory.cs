// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EED9C2EE-66B4-4F18-A697-AC7D3960215C")]
    [NativeTypeName("struct IMFSensorTransformFactory : IUnknown")]
    public unsafe partial struct IMFSensorTransformFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorTransformFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorTransformFactory*, uint>)(lpVtbl[1]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorTransformFactory*, uint>)(lpVtbl[2]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFactoryAttributes([NativeTypeName("IMFAttributes **")] IMFAttributes** ppAttributes)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorTransformFactory*, IMFAttributes**, int>)(lpVtbl[3]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), ppAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFactory([NativeTypeName("DWORD")] uint dwMaxTransformCount, [NativeTypeName("IMFCollection *")] IMFCollection* pSensorDevices, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorTransformFactory*, uint, IMFCollection*, IMFAttributes*, int>)(lpVtbl[4]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), dwMaxTransformCount, pSensorDevices, pAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTransformCount([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorTransformFactory*, uint*, int>)(lpVtbl[5]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTransformInformation([NativeTypeName("DWORD")] uint TransformIndex, [NativeTypeName("GUID *")] Guid* pguidTransformId, [NativeTypeName("IMFAttributes **")] IMFAttributes** ppAttributes, [NativeTypeName("IMFCollection **")] IMFCollection** ppStreamInformation)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorTransformFactory*, uint, Guid*, IMFAttributes**, IMFCollection**, int>)(lpVtbl[6]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), TransformIndex, pguidTransformId, ppAttributes, ppStreamInformation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTransform([NativeTypeName("const GUID &")] Guid* guidSensorTransformID, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFDeviceTransform **")] IMFDeviceTransform** ppDeviceMFT)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSensorTransformFactory*, Guid*, IMFAttributes*, IMFDeviceTransform**, int>)(lpVtbl[7]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), guidSensorTransformID, pAttributes, ppDeviceMFT);
        }
    }
}
