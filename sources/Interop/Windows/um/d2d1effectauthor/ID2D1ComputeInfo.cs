// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5598B14B-9FD7-48B7-9BDB-8F0964EB38BC")]
    [NativeTypeName("struct ID2D1ComputeInfo : ID2D1RenderInfo")]
    public unsafe partial struct ID2D1ComputeInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint>)(lpVtbl[1]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint>)(lpVtbl[2]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInputDescription([NativeTypeName("UINT32")] uint inputIndex, D2D1_INPUT_DESCRIPTION inputDescription)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint, D2D1_INPUT_DESCRIPTION, int>)(lpVtbl[3]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), inputIndex, inputDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH, int>)(lpVtbl[4]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetCached([NativeTypeName("BOOL")] int isCached)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, int, void>)(lpVtbl[5]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), isCached);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetInstructionCountHint([NativeTypeName("UINT32")] uint instructionCount)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint, void>)(lpVtbl[6]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), instructionCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetComputeShaderConstantBuffer([NativeTypeName("const BYTE *")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, byte*, uint, int>)(lpVtbl[7]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), buffer, bufferCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetComputeShader([NativeTypeName("const GUID &")] Guid* shaderId)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, Guid*, int>)(lpVtbl[8]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), shaderId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetResourceTexture([NativeTypeName("UINT32")] uint textureIndex, [NativeTypeName("ID2D1ResourceTexture *")] ID2D1ResourceTexture* resourceTexture)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint, ID2D1ResourceTexture*, int>)(lpVtbl[9]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), textureIndex, resourceTexture);
        }
    }
}
