// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BF94C121-5B05-4E6F-8000-BA598961414D")]
    [NativeTypeName("struct IMFTransform : IUnknown")]
    public unsafe partial struct IMFTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, Guid*, void**, int>)(lpVtbl[0]))((IMFTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint>)(lpVtbl[1]))((IMFTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint>)(lpVtbl[2]))((IMFTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamLimits([NativeTypeName("DWORD *")] uint* pdwInputMinimum, [NativeTypeName("DWORD *")] uint* pdwInputMaximum, [NativeTypeName("DWORD *")] uint* pdwOutputMinimum, [NativeTypeName("DWORD *")] uint* pdwOutputMaximum)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint*, uint*, uint*, uint*, int>)(lpVtbl[3]))((IMFTransform*)Unsafe.AsPointer(ref this), pdwInputMinimum, pdwInputMaximum, pdwOutputMinimum, pdwOutputMaximum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamCount([NativeTypeName("DWORD *")] uint* pcInputStreams, [NativeTypeName("DWORD *")] uint* pcOutputStreams)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint*, uint*, int>)(lpVtbl[4]))((IMFTransform*)Unsafe.AsPointer(ref this), pcInputStreams, pcOutputStreams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamIDs([NativeTypeName("DWORD")] uint dwInputIDArraySize, [NativeTypeName("DWORD *")] uint* pdwInputIDs, [NativeTypeName("DWORD")] uint dwOutputIDArraySize, [NativeTypeName("DWORD *")] uint* pdwOutputIDs)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, uint*, uint, uint*, int>)(lpVtbl[5]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputIDArraySize, pdwInputIDs, dwOutputIDArraySize, pdwOutputIDs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputStreamInfo([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("MFT_INPUT_STREAM_INFO *")] MFT_INPUT_STREAM_INFO* pStreamInfo)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, MFT_INPUT_STREAM_INFO*, int>)(lpVtbl[6]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pStreamInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputStreamInfo([NativeTypeName("DWORD")] uint dwOutputStreamID, [NativeTypeName("MFT_OUTPUT_STREAM_INFO *")] MFT_OUTPUT_STREAM_INFO* pStreamInfo)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, MFT_OUTPUT_STREAM_INFO*, int>)(lpVtbl[7]))((IMFTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, pStreamInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttributes([NativeTypeName("IMFAttributes **")] IMFAttributes** pAttributes)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, IMFAttributes**, int>)(lpVtbl[8]))((IMFTransform*)Unsafe.AsPointer(ref this), pAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputStreamAttributes([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("IMFAttributes **")] IMFAttributes** pAttributes)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, IMFAttributes**, int>)(lpVtbl[9]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputStreamAttributes([NativeTypeName("DWORD")] uint dwOutputStreamID, [NativeTypeName("IMFAttributes **")] IMFAttributes** pAttributes)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, IMFAttributes**, int>)(lpVtbl[10]))((IMFTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, pAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteInputStream([NativeTypeName("DWORD")] uint dwStreamID)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, int>)(lpVtbl[11]))((IMFTransform*)Unsafe.AsPointer(ref this), dwStreamID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddInputStreams([NativeTypeName("DWORD")] uint cStreams, [NativeTypeName("DWORD *")] uint* adwStreamIDs)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, uint*, int>)(lpVtbl[12]))((IMFTransform*)Unsafe.AsPointer(ref this), cStreams, adwStreamIDs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputAvailableType([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("DWORD")] uint dwTypeIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, uint, IMFMediaType**, int>)(lpVtbl[13]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, dwTypeIndex, ppType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputAvailableType([NativeTypeName("DWORD")] uint dwOutputStreamID, [NativeTypeName("DWORD")] uint dwTypeIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, uint, IMFMediaType**, int>)(lpVtbl[14]))((IMFTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, dwTypeIndex, ppType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInputType([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("IMFMediaType *")] IMFMediaType* pType, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, IMFMediaType*, uint, int>)(lpVtbl[15]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pType, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputType([NativeTypeName("DWORD")] uint dwOutputStreamID, [NativeTypeName("IMFMediaType *")] IMFMediaType* pType, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, IMFMediaType*, uint, int>)(lpVtbl[16]))((IMFTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, pType, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputCurrentType([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, IMFMediaType**, int>)(lpVtbl[17]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, ppType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputCurrentType([NativeTypeName("DWORD")] uint dwOutputStreamID, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, IMFMediaType**, int>)(lpVtbl[18]))((IMFTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, ppType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputStatus([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, uint*, int>)(lpVtbl[19]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputStatus([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint*, int>)(lpVtbl[20]))((IMFTransform*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputBounds([NativeTypeName("LONGLONG")] long hnsLowerBound, [NativeTypeName("LONGLONG")] long hnsUpperBound)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, long, long, int>)(lpVtbl[21]))((IMFTransform*)Unsafe.AsPointer(ref this), hnsLowerBound, hnsUpperBound);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessEvent([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("IMFMediaEvent *")] IMFMediaEvent* pEvent)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, IMFMediaEvent*, int>)(lpVtbl[22]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessMessage(MFT_MESSAGE_TYPE eMessage, [NativeTypeName("ULONG_PTR")] nuint ulParam)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, MFT_MESSAGE_TYPE, nuint, int>)(lpVtbl[23]))((IMFTransform*)Unsafe.AsPointer(ref this), eMessage, ulParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessInput([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("IMFSample *")] IMFSample* pSample, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, IMFSample*, uint, int>)(lpVtbl[24]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pSample, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessOutput([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint cOutputBufferCount, [NativeTypeName("MFT_OUTPUT_DATA_BUFFER *")] MFT_OUTPUT_DATA_BUFFER* pOutputSamples, [NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTransform*, uint, uint, MFT_OUTPUT_DATA_BUFFER*, uint*, int>)(lpVtbl[25]))((IMFTransform*)Unsafe.AsPointer(ref this), dwFlags, cOutputBufferCount, pOutputSamples, pdwStatus);
        }
    }
}
