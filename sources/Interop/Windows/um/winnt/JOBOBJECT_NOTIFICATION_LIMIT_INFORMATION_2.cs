// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2
    {
        [NativeTypeName("DWORD64")]
        public ulong IoReadBytesLimit;

        [NativeTypeName("DWORD64")]
        public ulong IoWriteBytesLimit;

        public LARGE_INTEGER PerJobUserTimeLimit;

        [NativeTypeName("JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12023:5)")]
        public _Anonymous1_e__Union Anonymous1;

        public unsafe ref ulong JobHighMemoryLimit
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.JobHighMemoryLimit, 1));
#else
                return ref ((_Anonymous1_e__Union*)Unsafe.AsPointer(ref Anonymous1))->JobHighMemoryLimit;
#endif
            }
        }

        public unsafe ref ulong JobMemoryLimit
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.JobMemoryLimit, 1));
#else
                return ref ((_Anonymous1_e__Union*)Unsafe.AsPointer(ref Anonymous1))->JobMemoryLimit;
#endif
            }
        }

        [NativeTypeName("JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12028:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public unsafe ref JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.RateControlTolerance, 1));
#else
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->RateControlTolerance;
#endif
            }
        }

        public unsafe ref JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlTolerance
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.CpuRateControlTolerance, 1));
#else
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->CpuRateControlTolerance;
#endif
            }
        }

        [NativeTypeName("JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12033:5)")]
        public _Anonymous3_e__Union Anonymous3;

        public unsafe ref JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL RateControlToleranceInterval
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.RateControlToleranceInterval, 1));
#else
                return ref ((_Anonymous3_e__Union*)Unsafe.AsPointer(ref Anonymous3))->RateControlToleranceInterval;
#endif
            }
        }

        public unsafe ref JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL CpuRateControlToleranceInterval
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.CpuRateControlToleranceInterval, 1));
#else
                return ref ((_Anonymous3_e__Union*)Unsafe.AsPointer(ref Anonymous3))->CpuRateControlToleranceInterval;
#endif
            }
        }

        [NativeTypeName("DWORD")]
        public uint LimitFlags;

        public JOBOBJECT_RATE_CONTROL_TOLERANCE IoRateControlTolerance;

        [NativeTypeName("DWORD64")]
        public ulong JobLowMemoryLimit;

        public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL IoRateControlToleranceInterval;

        public JOBOBJECT_RATE_CONTROL_TOLERANCE NetRateControlTolerance;

        public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL NetRateControlToleranceInterval;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD64")]
            public ulong JobHighMemoryLimit;

            [FieldOffset(0)]
            [NativeTypeName("DWORD64")]
            public ulong JobMemoryLimit;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance;

            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlTolerance;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous3_e__Union
        {
            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL RateControlToleranceInterval;

            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL CpuRateControlToleranceInterval;
        }
    }
}
