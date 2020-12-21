// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("777D4A3B-F6FF-4A26-85DC-68D7CDEDA1D4")]
    [NativeTypeName("struct ISpatialAudioMetadataClient : IUnknown")]
    public unsafe partial struct ISpatialAudioMetadataClient
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataClient*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataClient*, uint>)(lpVtbl[1]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataClient*, uint>)(lpVtbl[2]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateSpatialAudioMetadataItems([NativeTypeName("UINT16")] ushort maxItemCount, [NativeTypeName("UINT16")] ushort frameCount, [NativeTypeName("ISpatialAudioMetadataItemsBuffer **")] ISpatialAudioMetadataItemsBuffer** metadataItemsBuffer, [NativeTypeName("ISpatialAudioMetadataItems **")] ISpatialAudioMetadataItems** metadataItems)
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataClient*, ushort, ushort, ISpatialAudioMetadataItemsBuffer**, ISpatialAudioMetadataItems**, int>)(lpVtbl[3]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), maxItemCount, frameCount, metadataItemsBuffer, metadataItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpatialAudioMetadataItemsBufferLength([NativeTypeName("UINT16")] ushort maxItemCount, [NativeTypeName("UINT32 *")] uint* bufferLength)
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataClient*, ushort, uint*, int>)(lpVtbl[4]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), maxItemCount, bufferLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateSpatialAudioMetadataWriter(SpatialAudioMetadataWriterOverflowMode overflowMode, [NativeTypeName("ISpatialAudioMetadataWriter **")] ISpatialAudioMetadataWriter** metadataWriter)
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataClient*, SpatialAudioMetadataWriterOverflowMode, ISpatialAudioMetadataWriter**, int>)(lpVtbl[5]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), overflowMode, metadataWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateSpatialAudioMetadataCopier([NativeTypeName("ISpatialAudioMetadataCopier **")] ISpatialAudioMetadataCopier** metadataCopier)
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataClient*, ISpatialAudioMetadataCopier**, int>)(lpVtbl[6]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), metadataCopier);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateSpatialAudioMetadataReader([NativeTypeName("ISpatialAudioMetadataReader **")] ISpatialAudioMetadataReader** metadataReader)
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataClient*, ISpatialAudioMetadataReader**, int>)(lpVtbl[7]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), metadataReader);
        }
    }
}
