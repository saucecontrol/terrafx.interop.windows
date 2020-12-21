// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A410B984-9839-4819-A0BE-2856AE6B3ADB")]
    [NativeTypeName("struct IXAPO : IUnknown")]
    public unsafe partial struct IXAPO
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IXAPO*, Guid*, void**, int>)(lpVtbl[0]))((IXAPO*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IXAPO*, uint>)(lpVtbl[1]))((IXAPO*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IXAPO*, uint>)(lpVtbl[2]))((IXAPO*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRegistrationProperties([NativeTypeName("XAPO_REGISTRATION_PROPERTIES **")] XAPO_REGISTRATION_PROPERTIES** ppRegistrationProperties)
        {
            return ((delegate* unmanaged[Stdcall]<IXAPO*, XAPO_REGISTRATION_PROPERTIES**, int>)(lpVtbl[3]))((IXAPO*)Unsafe.AsPointer(ref this), ppRegistrationProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsInputFormatSupported([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pOutputFormat, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pRequestedInputFormat, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppSupportedInputFormat)
        {
            return ((delegate* unmanaged[Stdcall]<IXAPO*, WAVEFORMATEX*, WAVEFORMATEX*, WAVEFORMATEX**, int>)(lpVtbl[4]))((IXAPO*)Unsafe.AsPointer(ref this), pOutputFormat, pRequestedInputFormat, ppSupportedInputFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsOutputFormatSupported([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pInputFormat, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pRequestedOutputFormat, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppSupportedOutputFormat)
        {
            return ((delegate* unmanaged[Stdcall]<IXAPO*, WAVEFORMATEX*, WAVEFORMATEX*, WAVEFORMATEX**, int>)(lpVtbl[5]))((IXAPO*)Unsafe.AsPointer(ref this), pInputFormat, pRequestedOutputFormat, ppSupportedOutputFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT32")] uint DataByteSize)
        {
            return ((delegate* unmanaged[Stdcall]<IXAPO*, void*, uint, int>)(lpVtbl[6]))((IXAPO*)Unsafe.AsPointer(ref this), pData, DataByteSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            ((delegate* unmanaged[Stdcall]<IXAPO*, void>)(lpVtbl[7]))((IXAPO*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockForProcess([NativeTypeName("UINT32")] uint InputLockedParameterCount, [NativeTypeName("const XAPO_LOCKFORPROCESS_PARAMETERS *")] XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS* pInputLockedParameters, [NativeTypeName("UINT32")] uint OutputLockedParameterCount, [NativeTypeName("const XAPO_LOCKFORPROCESS_PARAMETERS *")] XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS* pOutputLockedParameters)
        {
            return ((delegate* unmanaged[Stdcall]<IXAPO*, uint, XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS*, uint, XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS*, int>)(lpVtbl[8]))((IXAPO*)Unsafe.AsPointer(ref this), InputLockedParameterCount, pInputLockedParameters, OutputLockedParameterCount, pOutputLockedParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void UnlockForProcess()
        {
            ((delegate* unmanaged[Stdcall]<IXAPO*, void>)(lpVtbl[9]))((IXAPO*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Process([NativeTypeName("UINT32")] uint InputProcessParameterCount, [NativeTypeName("const XAPO_PROCESS_BUFFER_PARAMETERS *")] XAPO_PROCESS_BUFFER_PARAMETERS* pInputProcessParameters, [NativeTypeName("UINT32")] uint OutputProcessParameterCount, [NativeTypeName("XAPO_PROCESS_BUFFER_PARAMETERS *")] XAPO_PROCESS_BUFFER_PARAMETERS* pOutputProcessParameters, [NativeTypeName("BOOL")] int IsEnabled)
        {
            ((delegate* unmanaged[Stdcall]<IXAPO*, uint, XAPO_PROCESS_BUFFER_PARAMETERS*, uint, XAPO_PROCESS_BUFFER_PARAMETERS*, int, void>)(lpVtbl[10]))((IXAPO*)Unsafe.AsPointer(ref this), InputProcessParameterCount, pInputProcessParameters, OutputProcessParameterCount, pOutputProcessParameters, IsEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint CalcInputFrames([NativeTypeName("UINT32")] uint OutputFrameCount)
        {
            return ((delegate* unmanaged[Stdcall]<IXAPO*, uint, uint>)(lpVtbl[11]))((IXAPO*)Unsafe.AsPointer(ref this), OutputFrameCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint CalcOutputFrames([NativeTypeName("UINT32")] uint InputFrameCount)
        {
            return ((delegate* unmanaged[Stdcall]<IXAPO*, uint, uint>)(lpVtbl[12]))((IXAPO*)Unsafe.AsPointer(ref this), InputFrameCount);
        }
    }
}
