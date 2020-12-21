// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B78E86A2-31D9-4C32-94D2-7DF40FC7EBEC")]
    [NativeTypeName("struct ISpatialAudioMetadataReader : IUnknown")]
    public unsafe partial struct ISpatialAudioMetadataReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataReader*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataReader*, uint>)(lpVtbl[1]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataReader*, uint>)(lpVtbl[2]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Open([NativeTypeName("ISpatialAudioMetadataItems *")] ISpatialAudioMetadataItems* metadataItems)
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataReader*, ISpatialAudioMetadataItems*, int>)(lpVtbl[3]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this), metadataItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadNextItem([NativeTypeName("UINT8 *")] byte* commandCount, [NativeTypeName("UINT16 *")] ushort* frameOffset)
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataReader*, byte*, ushort*, int>)(lpVtbl[4]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this), commandCount, frameOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadNextItemCommand([NativeTypeName("BYTE *")] byte* commandID, [NativeTypeName("void *")] void* valueBuffer, [NativeTypeName("UINT32")] uint maxValueBufferLength, [NativeTypeName("UINT32 *")] uint* valueBufferLength)
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataReader*, byte*, void*, uint, uint*, int>)(lpVtbl[5]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this), commandID, valueBuffer, maxValueBufferLength, valueBufferLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataReader*, int>)(lpVtbl[6]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this));
        }
    }
}
