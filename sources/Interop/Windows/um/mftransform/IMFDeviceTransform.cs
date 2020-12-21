// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D818FBD8-FC46-42F2-87AC-1EA2D1F9BF32")]
    [NativeTypeName("struct IMFDeviceTransform : IUnknown")]
    public unsafe partial struct IMFDeviceTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, Guid*, void**, int>)(lpVtbl[0]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint>)(lpVtbl[1]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint>)(lpVtbl[2]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeTransform([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, IMFAttributes*, int>)(lpVtbl[3]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), pAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputAvailableType([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("DWORD")] uint dwTypeIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** pMediaType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, uint, IMFMediaType**, int>)(lpVtbl[4]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, dwTypeIndex, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputCurrentType([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("IMFMediaType **")] IMFMediaType** pMediaType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, IMFMediaType**, int>)(lpVtbl[5]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputStreamAttributes([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("IMFAttributes **")] IMFAttributes** ppAttributes)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, IMFAttributes**, int>)(lpVtbl[6]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, ppAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputAvailableType([NativeTypeName("DWORD")] uint dwOutputStreamID, [NativeTypeName("DWORD")] uint dwTypeIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** pMediaType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, uint, IMFMediaType**, int>)(lpVtbl[7]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, dwTypeIndex, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputCurrentType([NativeTypeName("DWORD")] uint dwOutputStreamID, [NativeTypeName("IMFMediaType **")] IMFMediaType** pMediaType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, IMFMediaType**, int>)(lpVtbl[8]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputStreamAttributes([NativeTypeName("DWORD")] uint dwOutputStreamID, [NativeTypeName("IMFAttributes **")] IMFAttributes** ppAttributes)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, IMFAttributes**, int>)(lpVtbl[9]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, ppAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamCount([NativeTypeName("DWORD *")] uint* pcInputStreams, [NativeTypeName("DWORD *")] uint* pcOutputStreams)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint*, uint*, int>)(lpVtbl[10]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), pcInputStreams, pcOutputStreams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamIDs([NativeTypeName("DWORD")] uint dwInputIDArraySize, [NativeTypeName("DWORD *")] uint* pdwInputStreamIds, [NativeTypeName("DWORD")] uint dwOutputIDArraySize, [NativeTypeName("DWORD *")] uint* pdwOutputStreamIds)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, uint*, uint, uint*, int>)(lpVtbl[11]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputIDArraySize, pdwInputStreamIds, dwOutputIDArraySize, pdwOutputStreamIds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessEvent([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("IMFMediaEvent *")] IMFMediaEvent* pEvent)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, IMFMediaEvent*, int>)(lpVtbl[12]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessInput([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("IMFSample *")] IMFSample* pSample, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, IMFSample*, uint, int>)(lpVtbl[13]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pSample, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessMessage(MFT_MESSAGE_TYPE eMessage, [NativeTypeName("ULONG_PTR")] nuint ulParam)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, MFT_MESSAGE_TYPE, nuint, int>)(lpVtbl[14]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), eMessage, ulParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessOutput([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint cOutputBufferCount, [NativeTypeName("MFT_OUTPUT_DATA_BUFFER *")] MFT_OUTPUT_DATA_BUFFER* pOutputSample, [NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, uint, MFT_OUTPUT_DATA_BUFFER*, uint*, int>)(lpVtbl[15]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwFlags, cOutputBufferCount, pOutputSample, pdwStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInputStreamState([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType, DeviceStreamState value, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, IMFMediaType*, DeviceStreamState, uint, int>)(lpVtbl[16]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamID, pMediaType, value, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputStreamState([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("DeviceStreamState *")] DeviceStreamState* value)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, DeviceStreamState*, int>)(lpVtbl[17]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamID, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputStreamState([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType, DeviceStreamState value, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, IMFMediaType*, DeviceStreamState, uint, int>)(lpVtbl[18]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamID, pMediaType, value, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputStreamState([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("DeviceStreamState *")] DeviceStreamState* value)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, DeviceStreamState*, int>)(lpVtbl[19]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamID, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputStreamPreferredState([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("DeviceStreamState *")] DeviceStreamState* value, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMediaType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, DeviceStreamState*, IMFMediaType**, int>)(lpVtbl[20]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamID, value, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FlushInputStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, uint, int>)(lpVtbl[21]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamIndex, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FlushOutputStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDeviceTransform*, uint, uint, int>)(lpVtbl[22]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamIndex, dwFlags);
        }
    }
}
