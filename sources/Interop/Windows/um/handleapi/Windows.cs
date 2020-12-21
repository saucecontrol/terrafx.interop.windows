// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/handleapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseHandle([NativeTypeName("HANDLE")] IntPtr hObject);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DuplicateHandle([NativeTypeName("HANDLE")] IntPtr hSourceProcessHandle, [NativeTypeName("HANDLE")] IntPtr hSourceHandle, [NativeTypeName("HANDLE")] IntPtr hTargetProcessHandle, [NativeTypeName("LPHANDLE")] IntPtr* lpTargetHandle, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("DWORD")] uint dwOptions);

        [DllImport("KernelBase", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CompareObjectHandles([NativeTypeName("HANDLE")] IntPtr hFirstObjectHandle, [NativeTypeName("HANDLE")] IntPtr hSecondObjectHandle);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetHandleInformation([NativeTypeName("HANDLE")] IntPtr hObject, [NativeTypeName("LPDWORD")] uint* lpdwFlags);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetHandleInformation([NativeTypeName("HANDLE")] IntPtr hObject, [NativeTypeName("DWORD")] uint dwMask, [NativeTypeName("DWORD")] uint dwFlags);

        [NativeTypeName("#define INVALID_HANDLE_VALUE ((HANDLE)(LONG_PTR)-1)")]
        public static readonly IntPtr INVALID_HANDLE_VALUE = ((IntPtr)((nint)(-1)));
    }
}
