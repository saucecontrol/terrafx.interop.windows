// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_XML_READER_STREAM_INPUT
    {
        public WS_XML_READER_INPUT input;

        [NativeTypeName("WS_READ_CALLBACK")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, int> readCallback;
#else
        public void* _readCallback;

        public delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, int> readCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, int>)_readCallback;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _readCallback = value;
            }
        }
#endif

        [NativeTypeName("void *")]
        public void* readCallbackState;
    }
}
