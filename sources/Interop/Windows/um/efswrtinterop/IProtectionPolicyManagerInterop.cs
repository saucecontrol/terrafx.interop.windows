// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/efswrtinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4652651D-C1FE-4BA1-9F0A-C0F56596F721")]
    [NativeTypeName("struct IProtectionPolicyManagerInterop : IInspectable")]
    public unsafe partial struct IProtectionPolicyManagerInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IProtectionPolicyManagerInterop*, Guid*, void**, int>)(lpVtbl[0]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IProtectionPolicyManagerInterop*, uint>)(lpVtbl[1]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IProtectionPolicyManagerInterop*, uint>)(lpVtbl[2]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged[Stdcall]<IProtectionPolicyManagerInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged[Stdcall]<IProtectionPolicyManagerInterop*, IntPtr*, int>)(lpVtbl[4]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged[Stdcall]<IProtectionPolicyManagerInterop*, TrustLevel*, int>)(lpVtbl[5]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestAccessForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("HSTRING")] IntPtr sourceIdentity, [NativeTypeName("HSTRING")] IntPtr targetIdentity, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** asyncOperation)
        {
            return ((delegate* unmanaged[Stdcall]<IProtectionPolicyManagerInterop*, IntPtr, IntPtr, IntPtr, Guid*, void**, int>)(lpVtbl[6]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), appWindow, sourceIdentity, targetIdentity, riid, asyncOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForWindow([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** result)
        {
            return ((delegate* unmanaged[Stdcall]<IProtectionPolicyManagerInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[7]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), appWindow, riid, result);
        }
    }
}
