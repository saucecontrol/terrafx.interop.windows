// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.POWER_PLATFORM_ROLE;
using static TerraFX.Interop.SECURITY_IMPERSONATION_LEVEL;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_MAX_POWER_SAVINGS = new Guid(0xA1841308, 0x3541, 0x4FAB, 0xBC, 0x81, 0xF7, 0x15, 0x56, 0xF2, 0x0B, 0x4A);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_MIN_POWER_SAVINGS = new Guid(0x8C5E7FDA, 0xE8BF, 0x4A96, 0x9A, 0x85, 0xA6, 0xE2, 0x3A, 0x8C, 0x63, 0x5C);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_TYPICAL_POWER_SAVINGS = new Guid(0x381B4222, 0xF694, 0x41F0, 0x96, 0x85, 0xFF, 0x5B, 0xB2, 0x60, 0xDF, 0x2E);

        [NativeTypeName("const GUID")]
        public static readonly Guid NO_SUBGROUP_GUID = new Guid(0xFEA3413E, 0x7E05, 0x4911, 0x9A, 0x71, 0x70, 0x03, 0x31, 0xF1, 0xC2, 0x94);

        [NativeTypeName("const GUID")]
        public static readonly Guid ALL_POWERSCHEMES_GUID = new Guid(0x68A1E95E, 0x13EA, 0x41E1, 0x80, 0x11, 0x0C, 0x49, 0x6C, 0xA4, 0x90, 0xB0);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_POWERSCHEME_PERSONALITY = new Guid(0x245D8541, 0x3943, 0x4422, 0xB0, 0x25, 0x13, 0xA7, 0x84, 0xF6, 0x79, 0xB7);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ACTIVE_POWERSCHEME = new Guid(0x31F9F286, 0x5084, 0x42FE, 0xB7, 0x20, 0x2B, 0x02, 0x64, 0x99, 0x37, 0x63);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_IDLE_RESILIENCY_SUBGROUP = new Guid(0x2e601130, 0x5351, 0x4d9d, 0x8e, 0x4, 0x25, 0x29, 0x66, 0xba, 0xd0, 0x54);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_IDLE_RESILIENCY_PERIOD = new Guid(0xc42b79aa, 0xaa3a, 0x484b, 0xa9, 0x8f, 0x2c, 0xf3, 0x2a, 0xa9, 0xa, 0x28);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_DEEP_SLEEP_ENABLED = new Guid(0xd502f7ee, 0x1dc7, 0x4efd, 0xa5, 0x5d, 0xf0, 0x4b, 0x6f, 0x5c, 0x5, 0x45);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_DEEP_SLEEP_PLATFORM_STATE = new Guid(0xd23f2fb8, 0x9536, 0x4038, 0x9c, 0x94, 0x1c, 0xe0, 0x2e, 0x5c, 0x21, 0x52);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_DISK_COALESCING_POWERDOWN_TIMEOUT = new Guid(0xc36f0eb4, 0x2988, 0x4a70, 0x8e, 0xee, 0x8, 0x84, 0xfc, 0x2c, 0x24, 0x33);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_EXECUTION_REQUIRED_REQUEST_TIMEOUT = new Guid(0x3166bc41, 0x7e98, 0x4e03, 0xb3, 0x4e, 0xec, 0xf, 0x5f, 0x2b, 0x21, 0x8e);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_VIDEO_SUBGROUP = new Guid(0x7516B95F, 0xF776, 0x4464, 0x8C, 0x53, 0x06, 0x16, 0x7F, 0x40, 0xCC, 0x99);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_VIDEO_POWERDOWN_TIMEOUT = new Guid(0x3C0BC021, 0xC8A8, 0x4E07, 0xA9, 0x73, 0x6B, 0x14, 0xCB, 0xCB, 0x2B, 0x7E);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_VIDEO_ANNOYANCE_TIMEOUT = new Guid(0x82DBCF2D, 0xCD67, 0x40C5, 0xBF, 0xDC, 0x9F, 0x1A, 0x5C, 0xCD, 0x46, 0x63);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_VIDEO_ADAPTIVE_PERCENT_INCREASE = new Guid(0xEED904DF, 0xB142, 0x4183, 0xB1, 0x0B, 0x5A, 0x11, 0x97, 0xA3, 0x78, 0x64);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_VIDEO_DIM_TIMEOUT = new Guid(0x17aaa29b, 0x8b43, 0x4b94, 0xaa, 0xfe, 0x35, 0xf6, 0x4d, 0xaa, 0xf1, 0xee);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_VIDEO_ADAPTIVE_POWERDOWN = new Guid(0x90959D22, 0xD6A1, 0x49B9, 0xAF, 0x93, 0xBC, 0xE8, 0x85, 0xAD, 0x33, 0x5B);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_MONITOR_POWER_ON = new Guid(0x02731015, 0x4510, 0x4526, 0x99, 0xE6, 0xE5, 0xA1, 0x7E, 0xBD, 0x1A, 0xEA);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_DEVICE_POWER_POLICY_VIDEO_BRIGHTNESS = new Guid(0xaded5e82, 0xb909, 0x4619, 0x99, 0x49, 0xf5, 0xd7, 0x1d, 0xac, 0x0b, 0xcb);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_DEVICE_POWER_POLICY_VIDEO_DIM_BRIGHTNESS = new Guid(0xf1fbfde2, 0xa960, 0x4165, 0x9f, 0x88, 0x50, 0x66, 0x79, 0x11, 0xce, 0x96);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_VIDEO_CURRENT_MONITOR_BRIGHTNESS = new Guid(0x8ffee2c6, 0x2d01, 0x46be, 0xad, 0xb9, 0x39, 0x8a, 0xdd, 0xc5, 0xb4, 0xff);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_VIDEO_ADAPTIVE_DISPLAY_BRIGHTNESS = new Guid(0xFBD9AA66, 0x9553, 0x4097, 0xBA, 0x44, 0xED, 0x6E, 0x9D, 0x65, 0xEA, 0xB8);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_CONSOLE_DISPLAY_STATE = new Guid(0x6fe69556, 0x704a, 0x47a0, 0x8f, 0x24, 0xc2, 0x8d, 0x93, 0x6f, 0xda, 0x47);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ALLOW_DISPLAY_REQUIRED = new Guid(0xA9CEB8DA, 0xCD46, 0x44FB, 0xA9, 0x8B, 0x02, 0xAF, 0x69, 0xDE, 0x46, 0x23);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_VIDEO_CONSOLE_LOCK_TIMEOUT = new Guid(0x8ec4b3a5, 0x6868, 0x48c2, 0xbe, 0x75, 0x4f, 0x30, 0x44, 0xbe, 0x88, 0xa7);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ADVANCED_COLOR_QUALITY_BIAS = new Guid(0x684c3e69, 0xa4f7, 0x4014, 0x87, 0x54, 0xd4, 0x51, 0x79, 0xa5, 0x61, 0x67);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ADAPTIVE_POWER_BEHAVIOR_SUBGROUP = new Guid(0x8619b916, 0xe004, 0x4dd8, 0x9b, 0x66, 0xda, 0xe8, 0x6f, 0x80, 0x66, 0x98);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_NON_ADAPTIVE_INPUT_TIMEOUT = new Guid(0x5adbbfbc, 0x74e, 0x4da1, 0xba, 0x38, 0xdb, 0x8b, 0x36, 0xb2, 0xc8, 0xf3);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ADAPTIVE_INPUT_CONTROLLER_STATE = new Guid(0xe98fae9, 0xf45a, 0x4de1, 0xa7, 0x57, 0x60, 0x31, 0xf1, 0x97, 0xf6, 0xea);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_DISK_SUBGROUP = new Guid(0x0012EE47, 0x9041, 0x4B5D, 0x9B, 0x77, 0x53, 0x5F, 0xBA, 0x8B, 0x14, 0x42);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_DISK_MAX_POWER = new Guid(0x51dea550, 0xbb38, 0x4bc4, 0x99, 0x1b, 0xea, 0xcf, 0x37, 0xbe, 0x5e, 0xc8);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_DISK_POWERDOWN_TIMEOUT = new Guid(0x6738E2C4, 0xE8A5, 0x4A42, 0xB1, 0x6A, 0xE0, 0x40, 0xE7, 0x69, 0x75, 0x6E);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_DISK_IDLE_TIMEOUT = new Guid(0x58E39BA8, 0xB8E6, 0x4EF6, 0x90, 0xD0, 0x89, 0xAE, 0x32, 0xB2, 0x58, 0xD6);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_DISK_BURST_IGNORE_THRESHOLD = new Guid(0x80e3c60e, 0xbb94, 0x4ad8, 0xbb, 0xe0, 0x0d, 0x31, 0x95, 0xef, 0xc6, 0x63);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_DISK_ADAPTIVE_POWERDOWN = new Guid(0x396A32E1, 0x499A, 0x40B2, 0x91, 0x24, 0xA9, 0x6A, 0xFE, 0x70, 0x76, 0x67);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_DISK_NVME_NOPPME = new Guid(0xfc7372b6, 0xab2d, 0x43ee, 0x87, 0x97, 0x15, 0xe9, 0x84, 0x1f, 0x2c, 0xca);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_SLEEP_SUBGROUP = new Guid(0x238C9FA8, 0x0AAD, 0x41ED, 0x83, 0xF4, 0x97, 0xBE, 0x24, 0x2C, 0x8F, 0x20);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_SLEEP_IDLE_THRESHOLD = new Guid(0x81cd32e0, 0x7833, 0x44f3, 0x87, 0x37, 0x70, 0x81, 0xf3, 0x8d, 0x1f, 0x70);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_STANDBY_TIMEOUT = new Guid(0x29F6C1DB, 0x86DA, 0x48C5, 0x9F, 0xDB, 0xF2, 0xB6, 0x7B, 0x1F, 0x44, 0xDA);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_UNATTEND_SLEEP_TIMEOUT = new Guid(0x7bc4a2f9, 0xd8fc, 0x4469, 0xb0, 0x7b, 0x33, 0xeb, 0x78, 0x5a, 0xac, 0xa0);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_HIBERNATE_TIMEOUT = new Guid(0x9D7815A6, 0x7EE4, 0x497E, 0x88, 0x88, 0x51, 0x5A, 0x05, 0xF0, 0x23, 0x64);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_HIBERNATE_FASTS4_POLICY = new Guid(0x94AC6D29, 0x73CE, 0x41A6, 0x80, 0x9F, 0x63, 0x63, 0xBA, 0x21, 0xB4, 0x7E);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_CRITICAL_POWER_TRANSITION = new Guid(0xB7A27025, 0xE569, 0x46c2, 0xA5, 0x04, 0x2B, 0x96, 0xCA, 0xD2, 0x25, 0xA1);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_SYSTEM_AWAYMODE = new Guid(0x98A7F580, 0x01F7, 0x48AA, 0x9C, 0x0F, 0x44, 0x35, 0x2C, 0x29, 0xE5, 0xC0);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ALLOW_AWAYMODE = new Guid(0x25dfa149, 0x5dd1, 0x4736, 0xb5, 0xab, 0xe8, 0xa3, 0x7b, 0x5b, 0x81, 0x87);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_USER_PRESENCE_PREDICTION = new Guid(0x82011705, 0xfb95, 0x4d46, 0x8d, 0x35, 0x40, 0x42, 0xb1, 0xd2, 0xd, 0xef);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_STANDBY_BUDGET_GRACE_PERIOD = new Guid(0x60c07fe1, 0x0556, 0x45cf, 0x99, 0x03, 0xd5, 0x6e, 0x32, 0x21, 0x2, 0x42);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_STANDBY_BUDGET_PERCENT = new Guid(0x9fe527be, 0x1b70, 0x48da, 0x93, 0x0d, 0x7b, 0xcf, 0x17, 0xb4, 0x49, 0x90);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_STANDBY_RESERVE_GRACE_PERIOD = new Guid(0xc763ee92, 0x71e8, 0x4127, 0x84, 0xeb, 0xf6, 0xed, 0x04, 0x3a, 0x3e, 0x3d);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_STANDBY_RESERVE_TIME = new Guid(0x468FE7E5, 0x1158, 0x46EC, 0x88, 0xbc, 0x5b, 0x96, 0xc9, 0xe4, 0x4f, 0xd0);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_STANDBY_RESET_PERCENT = new Guid(0x49cb11a5, 0x56e2, 0x4afb, 0x9d, 0x38, 0x3d, 0xf4, 0x78, 0x72, 0xe2, 0x1b);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ALLOW_STANDBY_STATES = new Guid(0xabfc2519, 0x3608, 0x4c2a, 0x94, 0xea, 0x17, 0x1b, 0x0e, 0xd5, 0x46, 0xab);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ALLOW_RTC_WAKE = new Guid(0xBD3B718A, 0x0680, 0x4D9D, 0x8A, 0xB2, 0xE1, 0xD2, 0xB4, 0xAC, 0x80, 0x6D);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_LEGACY_RTC_MITIGATION = new Guid(0x1A34BDC3, 0x7E6B, 0x442E, 0xA9, 0xD0, 0x64, 0xB6, 0xEF, 0x37, 0x8E, 0x84);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ALLOW_SYSTEM_REQUIRED = new Guid(0xA4B195F5, 0x8225, 0x47D8, 0x80, 0x12, 0x9D, 0x41, 0x36, 0x97, 0x86, 0xE2);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_POWER_SAVING_STATUS = new Guid(0xe00958c0, 0xc213, 0x4ace, 0xac, 0x77, 0xfe, 0xcc, 0xed, 0x2e, 0xee, 0xa5);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ENERGY_SAVER_SUBGROUP = new Guid(0xDE830923, 0xA562, 0x41AF, 0xA0, 0x86, 0xE3, 0xA2, 0xC6, 0xBA, 0xD2, 0xDA);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ENERGY_SAVER_BATTERY_THRESHOLD = new Guid(0xE69653CA, 0xCF7F, 0x4F05, 0xAA, 0x73, 0xCB, 0x83, 0x3F, 0xA9, 0x0A, 0xD4);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ENERGY_SAVER_BRIGHTNESS = new Guid(0x13D09884, 0xF74E, 0x474A, 0xA8, 0x52, 0xB6, 0xBD, 0xE8, 0xAD, 0x03, 0xA8);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ENERGY_SAVER_POLICY = new Guid(0x5c5bb349, 0xad29, 0x4ee2, 0x9d, 0xb, 0x2b, 0x25, 0x27, 0xf, 0x7a, 0x81);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_SYSTEM_BUTTON_SUBGROUP = new Guid(0x4F971E89, 0xEEBD, 0x4455, 0xA8, 0xDE, 0x9E, 0x59, 0x04, 0x0E, 0x73, 0x47);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_POWERBUTTON_ACTION = new Guid(0x7648EFA3, 0xDD9C, 0x4E3E, 0xB5, 0x66, 0x50, 0xF9, 0x29, 0x38, 0x62, 0x80);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_SLEEPBUTTON_ACTION = new Guid(0x96996BC0, 0xAD50, 0x47EC, 0x92, 0x3B, 0x6F, 0x41, 0x87, 0x4D, 0xD9, 0xEB);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_USERINTERFACEBUTTON_ACTION = new Guid(0xA7066653, 0x8D6C, 0x40A8, 0x91, 0x0E, 0xA1, 0xF5, 0x4B, 0x84, 0xC7, 0xE5);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_LIDCLOSE_ACTION = new Guid(0x5CA83367, 0x6E45, 0x459F, 0xA2, 0x7B, 0x47, 0x6B, 0x1D, 0x01, 0xC9, 0x36);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_LIDOPEN_POWERSTATE = new Guid(0x99FF10E7, 0x23B1, 0x4C07, 0xA9, 0xD1, 0x5C, 0x32, 0x06, 0xD7, 0x41, 0xB4);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_BATTERY_SUBGROUP = new Guid(0xE73A048D, 0xBF27, 0x4F12, 0x97, 0x31, 0x8B, 0x20, 0x76, 0xE8, 0x89, 0x1F);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_BATTERY_DISCHARGE_ACTION_0 = new Guid(0x637EA02F, 0xBBCB, 0x4015, 0x8E, 0x2C, 0xA1, 0xC7, 0xB9, 0xC0, 0xB5, 0x46);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_0 = new Guid(0x9A66D8D7, 0x4FF7, 0x4EF9, 0xB5, 0xA2, 0x5A, 0x32, 0x6C, 0xA2, 0xA4, 0x69);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_0 = new Guid(0x5dbb7c9f, 0x38e9, 0x40d2, 0x97, 0x49, 0x4f, 0x8a, 0x0e, 0x9f, 0x64, 0x0f);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_BATTERY_DISCHARGE_ACTION_1 = new Guid(0xD8742DCB, 0x3E6A, 0x4B3C, 0xB3, 0xFE, 0x37, 0x46, 0x23, 0xCD, 0xCF, 0x06);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_1 = new Guid(0x8183BA9A, 0xE910, 0x48DA, 0x87, 0x69, 0x14, 0xAE, 0x6D, 0xC1, 0x17, 0x0A);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_1 = new Guid(0xbcded951, 0x187b, 0x4d05, 0xbc, 0xcc, 0xf7, 0xe5, 0x19, 0x60, 0xc2, 0x58);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_BATTERY_DISCHARGE_ACTION_2 = new Guid(0x421CBA38, 0x1A8E, 0x4881, 0xAC, 0x89, 0xE3, 0x3A, 0x8B, 0x04, 0xEC, 0xE4);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_2 = new Guid(0x07A07CA2, 0xADAF, 0x40D7, 0xB0, 0x77, 0x53, 0x3A, 0xAD, 0xED, 0x1B, 0xFA);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_2 = new Guid(0x7fd2f0c4, 0xfeb7, 0x4da3, 0x81, 0x17, 0xe3, 0xfb, 0xed, 0xc4, 0x65, 0x82);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_BATTERY_DISCHARGE_ACTION_3 = new Guid(0x80472613, 0x9780, 0x455E, 0xB3, 0x08, 0x72, 0xD3, 0x00, 0x3C, 0xF2, 0xF8);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_3 = new Guid(0x58AFD5A6, 0xC2DD, 0x47D2, 0x9F, 0xBF, 0xEF, 0x70, 0xCC, 0x5C, 0x59, 0x65);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_3 = new Guid(0x73613ccf, 0xdbfa, 0x4279, 0x83, 0x56, 0x49, 0x35, 0xf6, 0xbf, 0x62, 0xf3);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_SETTINGS_SUBGROUP = new Guid(0x54533251, 0x82BE, 0x4824, 0x96, 0xC1, 0x47, 0xB6, 0x0B, 0x74, 0x0D, 0x00);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_THROTTLE_POLICY = new Guid(0x57027304, 0x4AF6, 0x4104, 0x92, 0x60, 0xE3, 0xD9, 0x52, 0x48, 0xFC, 0x36);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_THROTTLE_MAXIMUM = new Guid(0xBC5038F7, 0x23E0, 0x4960, 0x96, 0xDA, 0x33, 0xAB, 0xAF, 0x59, 0x35, 0xEC);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_THROTTLE_MAXIMUM_1 = new Guid(0xBC5038F7, 0x23E0, 0x4960, 0x96, 0xDA, 0x33, 0xAB, 0xAF, 0x59, 0x35, 0xED);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_THROTTLE_MINIMUM = new Guid(0x893DEE8E, 0x2BEF, 0x41E0, 0x89, 0xC6, 0xB5, 0x5D, 0x09, 0x29, 0x96, 0x4C);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_THROTTLE_MINIMUM_1 = new Guid(0x893DEE8E, 0x2BEF, 0x41E0, 0x89, 0xC6, 0xB5, 0x5D, 0x09, 0x29, 0x96, 0x4D);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_FREQUENCY_LIMIT = new Guid(0x75b0ae3f, 0xbce0, 0x45a7, 0x8c, 0x89, 0xc9, 0x61, 0x1c, 0x25, 0xe1, 0x00);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_FREQUENCY_LIMIT_1 = new Guid(0x75b0ae3f, 0xbce0, 0x45a7, 0x8c, 0x89, 0xc9, 0x61, 0x1c, 0x25, 0xe1, 0x01);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_ALLOW_THROTTLING = new Guid(0x3b04d4fd, 0x1cc7, 0x4f23, 0xab, 0x1c, 0xd1, 0x33, 0x78, 0x19, 0xc4, 0xbb);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_IDLESTATE_POLICY = new Guid(0x68f262a7, 0xf621, 0x4069, 0xb9, 0xa5, 0x48, 0x74, 0x16, 0x9b, 0xe2, 0x3c);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERFSTATE_POLICY = new Guid(0xBBDC3814, 0x18E9, 0x4463, 0x8A, 0x55, 0xD1, 0x97, 0x32, 0x7C, 0x45, 0xC0);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_THRESHOLD = new Guid(0x06cadf0e, 0x64ed, 0x448a, 0x89, 0x27, 0xce, 0x7b, 0xf9, 0x0e, 0xb3, 0x5d);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_THRESHOLD_1 = new Guid(0x06cadf0e, 0x64ed, 0x448a, 0x89, 0x27, 0xce, 0x7b, 0xf9, 0x0e, 0xb3, 0x5e);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_THRESHOLD = new Guid(0x12a0ab44, 0xfe28, 0x4fa9, 0xb3, 0xbd, 0x4b, 0x64, 0xf4, 0x49, 0x60, 0xa6);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_THRESHOLD_1 = new Guid(0x12a0ab44, 0xfe28, 0x4fa9, 0xb3, 0xbd, 0x4b, 0x64, 0xf4, 0x49, 0x60, 0xa7);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_POLICY = new Guid(0x465e1f50, 0xb610, 0x473a, 0xab, 0x58, 0x0, 0xd1, 0x7, 0x7d, 0xc4, 0x18);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_POLICY_1 = new Guid(0x465e1f50, 0xb610, 0x473a, 0xab, 0x58, 0x0, 0xd1, 0x7, 0x7d, 0xc4, 0x19);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_POLICY = new Guid(0x40fbefc7, 0x2e9d, 0x4d25, 0xa1, 0x85, 0xc, 0xfd, 0x85, 0x74, 0xba, 0xc6);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_POLICY_1 = new Guid(0x40fbefc7, 0x2e9d, 0x4d25, 0xa1, 0x85, 0xc, 0xfd, 0x85, 0x74, 0xba, 0xc7);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_TIME = new Guid(0x984cf492, 0x3bed, 0x4488, 0xa8, 0xf9, 0x42, 0x86, 0xc9, 0x7b, 0xf5, 0xaa);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_TIME_1 = new Guid(0x984cf492, 0x3bed, 0x4488, 0xa8, 0xf9, 0x42, 0x86, 0xc9, 0x7b, 0xf5, 0xab);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_TIME = new Guid(0xd8edeb9b, 0x95cf, 0x4f95, 0xa7, 0x3c, 0xb0, 0x61, 0x97, 0x36, 0x93, 0xc8);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_TIME_1 = new Guid(0xd8edeb9b, 0x95cf, 0x4f95, 0xa7, 0x3c, 0xb0, 0x61, 0x97, 0x36, 0x93, 0xc9);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_TIME_CHECK = new Guid(0x4d2b0152, 0x7d5c, 0x498b, 0x88, 0xe2, 0x34, 0x34, 0x53, 0x92, 0xa2, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_BOOST_POLICY = new Guid(0x45bcc044, 0xd885, 0x43e2, 0x86, 0x5, 0xee, 0xe, 0xc6, 0xe9, 0x6b, 0x59);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_BOOST_MODE = new Guid(0xbe337238, 0xd82, 0x4146, 0xa9, 0x60, 0x4f, 0x37, 0x49, 0xd4, 0x70, 0xc7);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_AUTONOMOUS_MODE = new Guid(0x8baa4a8a, 0x14c6, 0x4451, 0x8e, 0x8b, 0x14, 0xbd, 0xbd, 0x19, 0x75, 0x37);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCE = new Guid(0x36687f9e, 0xe3a5, 0x4dbf, 0xb1, 0xdc, 0x15, 0xeb, 0x38, 0x1c, 0x68, 0x63);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCE_1 = new Guid(0x36687f9e, 0xe3a5, 0x4dbf, 0xb1, 0xdc, 0x15, 0xeb, 0x38, 0x1c, 0x68, 0x64);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_AUTONOMOUS_ACTIVITY_WINDOW = new Guid(0xcfeda3d0, 0x7697, 0x4566, 0xa9, 0x22, 0xa9, 0x8, 0x6c, 0xd4, 0x9d, 0xfa);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_DUTY_CYCLING = new Guid(0x4e4450b3, 0x6179, 0x4e91, 0xb8, 0xf1, 0x5b, 0xb9, 0x93, 0x8f, 0x81, 0xa1);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_IDLE_ALLOW_SCALING = new Guid(0x6c2993b0, 0x8f48, 0x481f, 0xbc, 0xc6, 0x0, 0xdd, 0x27, 0x42, 0xaa, 0x6);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_IDLE_DISABLE = new Guid(0x5d76a2ca, 0xe8c0, 0x402f, 0xa1, 0x33, 0x21, 0x58, 0x49, 0x2d, 0x58, 0xad);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_IDLE_STATE_MAXIMUM = new Guid(0x9943e905, 0x9a30, 0x4ec1, 0x9b, 0x99, 0x44, 0xdd, 0x3b, 0x76, 0xf7, 0xa2);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_IDLE_TIME_CHECK = new Guid(0xc4581c31, 0x89ab, 0x4597, 0x8e, 0x2b, 0x9c, 0x9c, 0xab, 0x44, 0xe, 0x6b);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_IDLE_DEMOTE_THRESHOLD = new Guid(0x4b92d758, 0x5a24, 0x4851, 0xa4, 0x70, 0x81, 0x5d, 0x78, 0xae, 0xe1, 0x19);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_IDLE_PROMOTE_THRESHOLD = new Guid(0x7b224883, 0xb3cc, 0x4d79, 0x81, 0x9f, 0x83, 0x74, 0x15, 0x2c, 0xbe, 0x7c);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_INCREASE_THRESHOLD = new Guid(0xdf142941, 0x20f3, 0x4edf, 0x9a, 0x4a, 0x9c, 0x83, 0xd3, 0xd7, 0x17, 0xd1);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_DECREASE_THRESHOLD = new Guid(0x68dd2f27, 0xa4ce, 0x4e11, 0x84, 0x87, 0x37, 0x94, 0xe4, 0x13, 0x5d, 0xfa);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_INCREASE_POLICY = new Guid(0xc7be0679, 0x2817, 0x4d69, 0x9d, 0x02, 0x51, 0x9a, 0x53, 0x7e, 0xd0, 0xc6);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_DECREASE_POLICY = new Guid(0x71021b41, 0xc749, 0x4d21, 0xbe, 0x74, 0xa0, 0x0f, 0x33, 0x5d, 0x58, 0x2b);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_MAX_CORES = new Guid(0xea062031, 0x0e34, 0x4ff1, 0x9b, 0x6d, 0xeb, 0x10, 0x59, 0x33, 0x40, 0x28);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_MAX_CORES_1 = new Guid(0xea062031, 0x0e34, 0x4ff1, 0x9b, 0x6d, 0xeb, 0x10, 0x59, 0x33, 0x40, 0x29);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_MIN_CORES = new Guid(0x0cc5b647, 0xc1df, 0x4637, 0x89, 0x1a, 0xde, 0xc3, 0x5c, 0x31, 0x85, 0x83);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_MIN_CORES_1 = new Guid(0x0cc5b647, 0xc1df, 0x4637, 0x89, 0x1a, 0xde, 0xc3, 0x5c, 0x31, 0x85, 0x84);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_INCREASE_TIME = new Guid(0x2ddd5a84, 0x5a71, 0x437e, 0x91, 0x2a, 0xdb, 0x0b, 0x8c, 0x78, 0x87, 0x32);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_DECREASE_TIME = new Guid(0xdfd10d17, 0xd5eb, 0x45dd, 0x87, 0x7a, 0x9a, 0x34, 0xdd, 0xd1, 0x5c, 0x82);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_DECREASE_FACTOR = new Guid(0x8f7b45e3, 0xc393, 0x480a, 0x87, 0x8c, 0xf6, 0x7a, 0xc3, 0xd0, 0x70, 0x82);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_THRESHOLD = new Guid(0x5b33697b, 0xe89d, 0x4d38, 0xaa, 0x46, 0x9e, 0x7d, 0xfb, 0x7c, 0xd2, 0xf9);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_AFFINITY_WEIGHTING = new Guid(0xe70867f1, 0xfa2f, 0x4f4e, 0xae, 0xa1, 0x4d, 0x8a, 0x0b, 0xa2, 0x3b, 0x20);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_DECREASE_FACTOR = new Guid(0x1299023c, 0xbc28, 0x4f0a, 0x81, 0xec, 0xd3, 0x29, 0x5a, 0x8d, 0x81, 0x5d);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_THRESHOLD = new Guid(0x9ac18e92, 0xaa3c, 0x4e27, 0xb3, 0x07, 0x01, 0xae, 0x37, 0x30, 0x71, 0x29);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_WEIGHTING = new Guid(0x8809c2d8, 0xb155, 0x42d4, 0xbc, 0xda, 0x0d, 0x34, 0x56, 0x51, 0xb1, 0xdb);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_THRESHOLD = new Guid(0x943c8cb6, 0x6f93, 0x4227, 0xad, 0x87, 0xe9, 0xa3, 0xfe, 0xec, 0x08, 0xd1);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PARKING_CORE_OVERRIDE = new Guid(0xa55612aa, 0xf624, 0x42c6, 0xa4, 0x43, 0x73, 0x97, 0xd0, 0x64, 0xc0, 0x4f);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PARKING_PERF_STATE = new Guid(0x447235c7, 0x6a8d, 0x4cc0, 0x8e, 0x24, 0x9e, 0xaf, 0x70, 0xb9, 0x6e, 0x2b);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PARKING_PERF_STATE_1 = new Guid(0x447235c7, 0x6a8d, 0x4cc0, 0x8e, 0x24, 0x9e, 0xaf, 0x70, 0xb9, 0x6e, 0x2c);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PARKING_CONCURRENCY_THRESHOLD = new Guid(0x2430ab6f, 0xa520, 0x44a2, 0x96, 0x01, 0xf7, 0xf2, 0x3b, 0x51, 0x34, 0xb1);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PARKING_HEADROOM_THRESHOLD = new Guid(0xf735a673, 0x2066, 0x4f80, 0xa0, 0xc5, 0xdd, 0xee, 0x0c, 0xf1, 0xbf, 0x5d);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PARKING_DISTRIBUTION_THRESHOLD = new Guid(0x4bdaf4e9, 0xd103, 0x46d7, 0xa5, 0xf0, 0x62, 0x80, 0x12, 0x16, 0x16, 0xef);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_SOFT_PARKING_LATENCY = new Guid(0x97cfac41, 0x2217, 0x47eb, 0x99, 0x2d, 0x61, 0x8b, 0x19, 0x77, 0xc9, 0x7);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_HISTORY = new Guid(0x7d24baa7, 0x0b84, 0x480f, 0x84, 0x0c, 0x1b, 0x07, 0x43, 0xc0, 0x0f, 0x5f);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_HISTORY_1 = new Guid(0x7d24baa7, 0x0b84, 0x480f, 0x84, 0x0c, 0x1b, 0x07, 0x43, 0xc0, 0x0f, 0x60);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_HISTORY = new Guid(0x99b3ef01, 0x752f, 0x46a1, 0x80, 0xfb, 0x77, 0x30, 0x1, 0x1f, 0x23, 0x54);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_HISTORY = new Guid(0x300f6f8, 0xabd6, 0x45a9, 0xb7, 0x4f, 0x49, 0x8, 0x69, 0x1a, 0x40, 0xb5);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_CORE_PARKING_HISTORY = new Guid(0x77d7f282, 0x8f1a, 0x42cd, 0x85, 0x37, 0x45, 0x45, 0xa, 0x83, 0x9b, 0xe8);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_LATENCY_HINT = new Guid(0x0822df31, 0x9c83, 0x441c, 0xa0, 0x79, 0x0d, 0xe4, 0xcf, 0x00, 0x9c, 0x7b);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_LATENCY_HINT_PERF = new Guid(0x619b7505, 0x3b, 0x4e82, 0xb7, 0xa6, 0x4d, 0xd2, 0x9c, 0x30, 0x9, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_PERF_LATENCY_HINT_PERF_1 = new Guid(0x619b7505, 0x3b, 0x4e82, 0xb7, 0xa6, 0x4d, 0xd2, 0x9c, 0x30, 0x9, 0x72);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK = new Guid(0x616cdaa5, 0x695e, 0x4545, 0x97, 0xad, 0x97, 0xdc, 0x2d, 0x1b, 0xdd, 0x88);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK_1 = new Guid(0x616cdaa5, 0x695e, 0x4545, 0x97, 0xad, 0x97, 0xdc, 0x2d, 0x1b, 0xdd, 0x89);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_DISTRIBUTE_UTILITY = new Guid(0xe0007330, 0xf589, 0x42ed, 0xa4, 0x01, 0x5d, 0xdb, 0x10, 0xe7, 0x85, 0xd3);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_HETEROGENEOUS_POLICY = new Guid(0x7f2f5cfa, 0xf10c, 0x4823, 0xb5, 0xe1, 0xe9, 0x3a, 0xe8, 0x5f, 0x46, 0xb5);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_HETERO_DECREASE_TIME = new Guid(0x7f2492b6, 0x60b1, 0x45e5, 0xae, 0x55, 0x77, 0x3f, 0x8c, 0xd5, 0xca, 0xec);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_HETERO_INCREASE_TIME = new Guid(0x4009efa7, 0xe72d, 0x4cba, 0x9e, 0xdf, 0x91, 0x08, 0x4e, 0xa8, 0xcb, 0xc3);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_HETERO_DECREASE_THRESHOLD = new Guid(0xf8861c27, 0x95e7, 0x475c, 0x86, 0x5b, 0x13, 0xc0, 0xcb, 0x3f, 0x9d, 0x6b);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_HETERO_INCREASE_THRESHOLD = new Guid(0xb000397d, 0x9b0b, 0x483d, 0x98, 0xc9, 0x69, 0x2a, 0x60, 0x60, 0xcf, 0xbf);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CLASS0_FLOOR_PERF = new Guid(0xfddc842b, 0x8364, 0x4edc, 0x94, 0xcf, 0xc1, 0x7f, 0x60, 0xde, 0x1c, 0x80);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_CLASS1_INITIAL_PERF = new Guid(0x1facfc65, 0xa930, 0x4bc5, 0x9f, 0x38, 0x50, 0x4e, 0xc0, 0x97, 0xbb, 0xc0);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_THREAD_SCHEDULING_POLICY = new Guid(0x93b8b6dc, 0x698, 0x4d1c, 0x9e, 0xe4, 0x6, 0x44, 0xe9, 0x0, 0xc8, 0x5d);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_SHORT_THREAD_SCHEDULING_POLICY = new Guid(0xbae08b81, 0x2d5e, 0x4688, 0xad, 0x6a, 0x13, 0x24, 0x33, 0x56, 0x65, 0x4b);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_SYSTEM_COOLING_POLICY = new Guid(0x94D3A615, 0xA899, 0x4AC5, 0xAE, 0x2B, 0xE4, 0xD8, 0xF6, 0x34, 0x36, 0x7F);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_DISABLE_THRESHOLD = new Guid(0x38b8383d, 0xcce0, 0x4c79, 0x9e, 0x3e, 0x56, 0xa4, 0xf1, 0x7c, 0xc4, 0x80);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_DISABLE_THRESHOLD_1 = new Guid(0x38b8383d, 0xcce0, 0x4c79, 0x9e, 0x3e, 0x56, 0xa4, 0xf1, 0x7c, 0xc4, 0x81);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_ENABLE_THRESHOLD = new Guid(0x3d44e256, 0x7222, 0x4415, 0xa9, 0xed, 0x9c, 0x45, 0xfa, 0x3d, 0xd8, 0x30);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_ENABLE_THRESHOLD_1 = new Guid(0x3d44e256, 0x7222, 0x4415, 0xa9, 0xed, 0x9c, 0x45, 0xfa, 0x3d, 0xd8, 0x31);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_DISABLE_TIME = new Guid(0xf565999f, 0x3fb0, 0x411a, 0xa2, 0x26, 0x3f, 0x1, 0x98, 0xde, 0xc1, 0x30);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_DISABLE_TIME_1 = new Guid(0xf565999f, 0x3fb0, 0x411a, 0xa2, 0x26, 0x3f, 0x1, 0x98, 0xde, 0xc1, 0x31);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_ENABLE_TIME = new Guid(0x3d915188, 0x7830, 0x49ae, 0xa7, 0x9a, 0xf, 0xb0, 0xa1, 0xe5, 0xa2, 0x0);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_ENABLE_TIME_1 = new Guid(0x3d915188, 0x7830, 0x49ae, 0xa7, 0x9a, 0xf, 0xb0, 0xa1, 0xe5, 0xa2, 0x1);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_EPP_CEILING = new Guid(0x4427c73b, 0x9756, 0x4a5c, 0xb8, 0x4b, 0xc7, 0xbd, 0xa7, 0x9c, 0x73, 0x20);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_EPP_CEILING_1 = new Guid(0x4427c73b, 0x9756, 0x4a5c, 0xb8, 0x4b, 0xc7, 0xbd, 0xa7, 0x9c, 0x73, 0x21);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_PERF_FLOOR = new Guid(0xce8e92ee, 0x6a86, 0x4572, 0xbf, 0xe0, 0x20, 0xc2, 0x1d, 0x3, 0xcd, 0x40);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_PERF_FLOOR_1 = new Guid(0xce8e92ee, 0x6a86, 0x4572, 0xbf, 0xe0, 0x20, 0xc2, 0x1d, 0x3, 0xcd, 0x41);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_LOCK_CONSOLE_ON_WAKE = new Guid(0x0E796BDB, 0x100D, 0x47D6, 0xA2, 0xD5, 0xF7, 0xD2, 0xDA, 0xA5, 0x1F, 0x51);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_DEVICE_IDLE_POLICY = new Guid(0x4faab71a, 0x92e5, 0x4726, 0xb5, 0x31, 0x22, 0x45, 0x59, 0x67, 0x2d, 0x19);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_CONNECTIVITY_IN_STANDBY = new Guid(0xF15576E8, 0x98B7, 0x4186, 0xB9, 0x44, 0xEA, 0xFA, 0x66, 0x44, 0x02, 0xD9);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_DISCONNECTED_STANDBY_MODE = new Guid(0x68AFB2D9, 0xEE95, 0x47A8, 0x8F, 0x50, 0x41, 0x15, 0x08, 0x80, 0x73, 0xB1);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ACDC_POWER_SOURCE = new Guid(0x5D3E9A59, 0xE9D5, 0x4B00, 0xA6, 0xBD, 0xFF, 0x34, 0xFF, 0x51, 0x65, 0x48);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_LIDSWITCH_STATE_CHANGE = new Guid(0xBA3E0F4D, 0xB817, 0x4094, 0xA2, 0xD1, 0xD5, 0x63, 0x79, 0xE6, 0xA0, 0xF3);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_BATTERY_PERCENTAGE_REMAINING = new Guid(0xA7AD8041, 0xB45A, 0x4CAE, 0x87, 0xA3, 0xEE, 0xCB, 0xB4, 0x68, 0xA9, 0xE1);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_BATTERY_COUNT = new Guid(0x7d263f15, 0xfca4, 0x49e5, 0x85, 0x4b, 0xa9, 0xf2, 0xbf, 0xbd, 0x5c, 0x24);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_GLOBAL_USER_PRESENCE = new Guid(0x786e8a1d, 0xb427, 0x4344, 0x92, 0x7, 0x9, 0xe7, 0xb, 0xdc, 0xbe, 0xa9);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_SESSION_DISPLAY_STATUS = new Guid(0x2b84c20e, 0xad23, 0x4ddf, 0x93, 0xdb, 0x5, 0xff, 0xbd, 0x7e, 0xfc, 0xa5);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_SESSION_USER_PRESENCE = new Guid(0x3c0f4548, 0xc03f, 0x4c4d, 0xb9, 0xf2, 0x23, 0x7e, 0xde, 0x68, 0x63, 0x76);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_IDLE_BACKGROUND_TASK = new Guid(0x515C31D8, 0xF734, 0x163D, 0xA0, 0xFD, 0x11, 0xA0, 0x8C, 0x91, 0xE8, 0xF1);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_BACKGROUND_TASK_NOTIFICATION = new Guid(0xCF23F240, 0x2A54, 0x48D8, 0xB1, 0x14, 0xDE, 0x15, 0x18, 0xFF, 0x05, 0x2E);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_APPLAUNCH_BUTTON = new Guid(0x1A689231, 0x7399, 0x4E9A, 0x8F, 0x99, 0xB7, 0x1F, 0x99, 0x9D, 0xB3, 0xFA);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PCIEXPRESS_SETTINGS_SUBGROUP = new Guid(0x501a4d13, 0x42af, 0x4429, 0x9f, 0xd1, 0xa8, 0x21, 0x8c, 0x26, 0x8e, 0x20);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PCIEXPRESS_ASPM_POLICY = new Guid(0xee12f906, 0xd277, 0x404b, 0xb6, 0xda, 0xe5, 0xfa, 0x1a, 0x57, 0x6d, 0xf5);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ENABLE_SWITCH_FORCED_SHUTDOWN = new Guid(0x833a6b62, 0xdfa4, 0x46d1, 0x82, 0xf8, 0xe0, 0x9e, 0x34, 0xd0, 0x29, 0xd6);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_INTSTEER_SUBGROUP = new Guid(0x48672f38, 0x7a9a, 0x4bb2, 0x8b, 0xf8, 0x3d, 0x85, 0xbe, 0x19, 0xde, 0x4e);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_INTSTEER_MODE = new Guid(0x2bfc24f9, 0x5ea2, 0x4801, 0x82, 0x13, 0x3d, 0xba, 0xe0, 0x1a, 0xa3, 0x9d);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_INTSTEER_LOAD_PER_PROC_TRIGGER = new Guid(0x73cde64d, 0xd720, 0x4bb2, 0xa8, 0x60, 0xc7, 0x55, 0xaf, 0xe7, 0x7e, 0xf2);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_INTSTEER_TIME_UNPARK_TRIGGER = new Guid(0xd6ba4903, 0x386f, 0x4c2c, 0x8a, 0xdb, 0x5c, 0x21, 0xb3, 0x32, 0x8d, 0x25);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_GRAPHICS_SUBGROUP = new Guid(0x5fb4938d, 0x1ee8, 0x4b0f, 0x9a, 0x3c, 0x50, 0x36, 0xb0, 0xab, 0x99, 0x5c);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_GPU_PREFERENCE_POLICY = new Guid(0xdd848b2a, 0x8a5d, 0x4451, 0x9a, 0xe2, 0x39, 0xcd, 0x41, 0x65, 0x8f, 0x6c);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_MIXED_REALITY_MODE = new Guid(0x1e626b4e, 0xcf04, 0x4f8d, 0x9c, 0xc7, 0xc9, 0x7c, 0x5b, 0xf, 0x23, 0x91);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_SPR_ACTIVE_SESSION_CHANGE = new Guid(0xe24ce38, 0xc393, 0x4742, 0xbd, 0xb1, 0x74, 0x4f, 0x4b, 0x9e, 0xe0, 0x8e);

        [NativeTypeName("const GUID")]
        public static readonly Guid PPM_PERFSTATE_CHANGE_GUID = new Guid(0xa5b32ddd, 0x7f39, 0x4abc, 0xb8, 0x92, 0x90, 0xe, 0x43, 0xb5, 0x9e, 0xbb);

        [NativeTypeName("const GUID")]
        public static readonly Guid PPM_PERFSTATE_DOMAIN_CHANGE_GUID = new Guid(0x995e6b7f, 0xd653, 0x497a, 0xb9, 0x78, 0x36, 0xa3, 0xc, 0x29, 0xbf, 0x1);

        [NativeTypeName("const GUID")]
        public static readonly Guid PPM_IDLESTATE_CHANGE_GUID = new Guid(0x4838fe4f, 0xf71c, 0x4e51, 0x9e, 0xcc, 0x84, 0x30, 0xa7, 0xac, 0x4c, 0x6c);

        [NativeTypeName("const GUID")]
        public static readonly Guid PPM_PERFSTATES_DATA_GUID = new Guid(0x5708cc20, 0x7d40, 0x4bf4, 0xb4, 0xaa, 0x2b, 0x01, 0x33, 0x8d, 0x01, 0x26);

        [NativeTypeName("const GUID")]
        public static readonly Guid PPM_IDLESTATES_DATA_GUID = new Guid(0xba138e10, 0xe250, 0x4ad7, 0x86, 0x16, 0xcf, 0x1a, 0x7a, 0xd4, 0x10, 0xe7);

        [NativeTypeName("const GUID")]
        public static readonly Guid PPM_IDLE_ACCOUNTING_GUID = new Guid(0xe2a26f78, 0xae07, 0x4ee0, 0xa3, 0x0f, 0xce, 0x54, 0xf5, 0x5a, 0x94, 0xcd);

        [NativeTypeName("const GUID")]
        public static readonly Guid PPM_IDLE_ACCOUNTING_EX_GUID = new Guid(0xd67abd39, 0x81f8, 0x4a5e, 0x81, 0x52, 0x72, 0xe3, 0x1e, 0xc9, 0x12, 0xee);

        [NativeTypeName("const GUID")]
        public static readonly Guid PPM_THERMALCONSTRAINT_GUID = new Guid(0xa852c2c8, 0x1a4c, 0x423b, 0x8c, 0x2c, 0xf3, 0x0d, 0x82, 0x93, 0x1a, 0x88);

        [NativeTypeName("const GUID")]
        public static readonly Guid PPM_PERFMON_PERFSTATE_GUID = new Guid(0x7fd18652, 0xcfe, 0x40d2, 0xb0, 0xa1, 0xb, 0x6, 0x6a, 0x87, 0x75, 0x9e);

        [NativeTypeName("const GUID")]
        public static readonly Guid PPM_THERMAL_POLICY_CHANGE_GUID = new Guid(0x48f377b8, 0x6880, 0x4c7b, 0x8b, 0xdc, 0x38, 0x1, 0x76, 0xc6, 0x65, 0x4d);

        [return: NativeTypeName("DWORD")]
        public static uint HEAP_MAKE_TAG_FLAGS([NativeTypeName("DWORD")] uint TagBase, [NativeTypeName("DWORD")] uint Tag)
        {
            return ((uint)((TagBase) + ((Tag) << 18)));
        }

        [NativeTypeName("#define ANYSIZE_ARRAY 1")]
        public const int ANYSIZE_ARRAY = 1;

        [NativeTypeName("#define MAX_NATURAL_ALIGNMENT sizeof(DWORD)")]
        public const uint MAX_NATURAL_ALIGNMENT = unchecked(4);

        [NativeTypeName("#define MEMORY_ALLOCATION_ALIGNMENT 8")]
        public const int MEMORY_ALLOCATION_ALIGNMENT = 8;

        [NativeTypeName("#define SYSTEM_CACHE_ALIGNMENT_SIZE 64")]
        public const int SYSTEM_CACHE_ALIGNMENT_SIZE = 64;

        [NativeTypeName("#define PRAGMA_DEPRECATED_DDK 0")]
        public const int PRAGMA_DEPRECATED_DDK = 0;

        [NativeTypeName("#define UCSCHAR_INVALID_CHARACTER (0xffffffff)")]
        public const uint UCSCHAR_INVALID_CHARACTER = (0xffffffff);

        [NativeTypeName("#define MIN_UCSCHAR (0)")]
        public const int MIN_UCSCHAR = (0);

        [NativeTypeName("#define MAX_UCSCHAR (0x0010FFFF)")]
        public const int MAX_UCSCHAR = (0x0010FFFF);

        [NativeTypeName("#define ALL_PROCESSOR_GROUPS 0xffff")]
        public const int ALL_PROCESSOR_GROUPS = 0xffff;

        [NativeTypeName("#define MAXIMUM_PROC_PER_GROUP 32")]
        public const int MAXIMUM_PROC_PER_GROUP = 32;

        [NativeTypeName("#define MAXIMUM_PROCESSORS MAXIMUM_PROC_PER_GROUP")]
        public const int MAXIMUM_PROCESSORS = 32;

        [NativeTypeName("#define APPLICATION_ERROR_MASK 0x20000000")]
        public const int APPLICATION_ERROR_MASK = 0x20000000;

        [NativeTypeName("#define ERROR_SEVERITY_SUCCESS 0x00000000")]
        public const int ERROR_SEVERITY_SUCCESS = 0x00000000;

        [NativeTypeName("#define ERROR_SEVERITY_INFORMATIONAL 0x40000000")]
        public const int ERROR_SEVERITY_INFORMATIONAL = 0x40000000;

        [NativeTypeName("#define ERROR_SEVERITY_WARNING 0x80000000")]
        public const uint ERROR_SEVERITY_WARNING = 0x80000000;

        [NativeTypeName("#define ERROR_SEVERITY_ERROR 0xC0000000")]
        public const uint ERROR_SEVERITY_ERROR = 0xC0000000;

        [NativeTypeName("#define MAXLONGLONG (0x7fffffffffffffff)")]
        public const long MAXLONGLONG = (0x7fffffffffffffff);

        [NativeTypeName("#define ANSI_NULL ((CHAR)0)")]
        public const sbyte ANSI_NULL = ((sbyte)(0));

        [NativeTypeName("#define UNICODE_NULL ((WCHAR)0)")]
        public const ushort UNICODE_NULL = ((ushort)(0));

        [NativeTypeName("#define UNICODE_STRING_MAX_BYTES ((WORD  ) 65534)")]
        public const ushort UNICODE_STRING_MAX_BYTES = ((ushort)(65534));

        [NativeTypeName("#define UNICODE_STRING_MAX_CHARS (32767)")]
        public const int UNICODE_STRING_MAX_CHARS = (32767);

        [NativeTypeName("#define MINCHAR 0x80")]
        public const int MINCHAR = 0x80;

        [NativeTypeName("#define MAXCHAR 0x7f")]
        public const int MAXCHAR = 0x7f;

        [NativeTypeName("#define MINSHORT 0x8000")]
        public const int MINSHORT = 0x8000;

        [NativeTypeName("#define MAXSHORT 0x7fff")]
        public const int MAXSHORT = 0x7fff;

        [NativeTypeName("#define MINLONG 0x80000000")]
        public const uint MINLONG = 0x80000000;

        [NativeTypeName("#define MAXLONG 0x7fffffff")]
        public const int MAXLONG = 0x7fffffff;

        [NativeTypeName("#define MAXBYTE 0xff")]
        public const int MAXBYTE = 0xff;

        [NativeTypeName("#define MAXWORD 0xffff")]
        public const int MAXWORD = 0xffff;

        [NativeTypeName("#define MAXDWORD 0xffffffff")]
        public const uint MAXDWORD = 0xffffffff;

        [NativeTypeName("#define ENCLAVE_SHORT_ID_LENGTH 16")]
        public const int ENCLAVE_SHORT_ID_LENGTH = 16;

        [NativeTypeName("#define ENCLAVE_LONG_ID_LENGTH 32")]
        public const int ENCLAVE_LONG_ID_LENGTH = 32;

        [NativeTypeName("#define VER_SERVER_NT 0x80000000")]
        public const uint VER_SERVER_NT = 0x80000000;

        [NativeTypeName("#define VER_WORKSTATION_NT 0x40000000")]
        public const int VER_WORKSTATION_NT = 0x40000000;

        [NativeTypeName("#define VER_SUITE_SMALLBUSINESS 0x00000001")]
        public const int VER_SUITE_SMALLBUSINESS = 0x00000001;

        [NativeTypeName("#define VER_SUITE_ENTERPRISE 0x00000002")]
        public const int VER_SUITE_ENTERPRISE = 0x00000002;

        [NativeTypeName("#define VER_SUITE_BACKOFFICE 0x00000004")]
        public const int VER_SUITE_BACKOFFICE = 0x00000004;

        [NativeTypeName("#define VER_SUITE_COMMUNICATIONS 0x00000008")]
        public const int VER_SUITE_COMMUNICATIONS = 0x00000008;

        [NativeTypeName("#define VER_SUITE_TERMINAL 0x00000010")]
        public const int VER_SUITE_TERMINAL = 0x00000010;

        [NativeTypeName("#define VER_SUITE_SMALLBUSINESS_RESTRICTED 0x00000020")]
        public const int VER_SUITE_SMALLBUSINESS_RESTRICTED = 0x00000020;

        [NativeTypeName("#define VER_SUITE_EMBEDDEDNT 0x00000040")]
        public const int VER_SUITE_EMBEDDEDNT = 0x00000040;

        [NativeTypeName("#define VER_SUITE_DATACENTER 0x00000080")]
        public const int VER_SUITE_DATACENTER = 0x00000080;

        [NativeTypeName("#define VER_SUITE_SINGLEUSERTS 0x00000100")]
        public const int VER_SUITE_SINGLEUSERTS = 0x00000100;

        [NativeTypeName("#define VER_SUITE_PERSONAL 0x00000200")]
        public const int VER_SUITE_PERSONAL = 0x00000200;

        [NativeTypeName("#define VER_SUITE_BLADE 0x00000400")]
        public const int VER_SUITE_BLADE = 0x00000400;

        [NativeTypeName("#define VER_SUITE_EMBEDDED_RESTRICTED 0x00000800")]
        public const int VER_SUITE_EMBEDDED_RESTRICTED = 0x00000800;

        [NativeTypeName("#define VER_SUITE_SECURITY_APPLIANCE 0x00001000")]
        public const int VER_SUITE_SECURITY_APPLIANCE = 0x00001000;

        [NativeTypeName("#define VER_SUITE_STORAGE_SERVER 0x00002000")]
        public const int VER_SUITE_STORAGE_SERVER = 0x00002000;

        [NativeTypeName("#define VER_SUITE_COMPUTE_SERVER 0x00004000")]
        public const int VER_SUITE_COMPUTE_SERVER = 0x00004000;

        [NativeTypeName("#define VER_SUITE_WH_SERVER 0x00008000")]
        public const int VER_SUITE_WH_SERVER = 0x00008000;

        [NativeTypeName("#define VER_SUITE_MULTIUSERTS 0x00020000")]
        public const int VER_SUITE_MULTIUSERTS = 0x00020000;

        [NativeTypeName("#define PRODUCT_UNDEFINED 0x00000000")]
        public const int PRODUCT_UNDEFINED = 0x00000000;

        [NativeTypeName("#define PRODUCT_ULTIMATE 0x00000001")]
        public const int PRODUCT_ULTIMATE = 0x00000001;

        [NativeTypeName("#define PRODUCT_HOME_BASIC 0x00000002")]
        public const int PRODUCT_HOME_BASIC = 0x00000002;

        [NativeTypeName("#define PRODUCT_HOME_PREMIUM 0x00000003")]
        public const int PRODUCT_HOME_PREMIUM = 0x00000003;

        [NativeTypeName("#define PRODUCT_ENTERPRISE 0x00000004")]
        public const int PRODUCT_ENTERPRISE = 0x00000004;

        [NativeTypeName("#define PRODUCT_HOME_BASIC_N 0x00000005")]
        public const int PRODUCT_HOME_BASIC_N = 0x00000005;

        [NativeTypeName("#define PRODUCT_BUSINESS 0x00000006")]
        public const int PRODUCT_BUSINESS = 0x00000006;

        [NativeTypeName("#define PRODUCT_STANDARD_SERVER 0x00000007")]
        public const int PRODUCT_STANDARD_SERVER = 0x00000007;

        [NativeTypeName("#define PRODUCT_DATACENTER_SERVER 0x00000008")]
        public const int PRODUCT_DATACENTER_SERVER = 0x00000008;

        [NativeTypeName("#define PRODUCT_SMALLBUSINESS_SERVER 0x00000009")]
        public const int PRODUCT_SMALLBUSINESS_SERVER = 0x00000009;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_SERVER 0x0000000A")]
        public const int PRODUCT_ENTERPRISE_SERVER = 0x0000000A;

        [NativeTypeName("#define PRODUCT_STARTER 0x0000000B")]
        public const int PRODUCT_STARTER = 0x0000000B;

        [NativeTypeName("#define PRODUCT_DATACENTER_SERVER_CORE 0x0000000C")]
        public const int PRODUCT_DATACENTER_SERVER_CORE = 0x0000000C;

        [NativeTypeName("#define PRODUCT_STANDARD_SERVER_CORE 0x0000000D")]
        public const int PRODUCT_STANDARD_SERVER_CORE = 0x0000000D;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_SERVER_CORE 0x0000000E")]
        public const int PRODUCT_ENTERPRISE_SERVER_CORE = 0x0000000E;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_SERVER_IA64 0x0000000F")]
        public const int PRODUCT_ENTERPRISE_SERVER_IA64 = 0x0000000F;

        [NativeTypeName("#define PRODUCT_BUSINESS_N 0x00000010")]
        public const int PRODUCT_BUSINESS_N = 0x00000010;

        [NativeTypeName("#define PRODUCT_WEB_SERVER 0x00000011")]
        public const int PRODUCT_WEB_SERVER = 0x00000011;

        [NativeTypeName("#define PRODUCT_CLUSTER_SERVER 0x00000012")]
        public const int PRODUCT_CLUSTER_SERVER = 0x00000012;

        [NativeTypeName("#define PRODUCT_HOME_SERVER 0x00000013")]
        public const int PRODUCT_HOME_SERVER = 0x00000013;

        [NativeTypeName("#define PRODUCT_STORAGE_EXPRESS_SERVER 0x00000014")]
        public const int PRODUCT_STORAGE_EXPRESS_SERVER = 0x00000014;

        [NativeTypeName("#define PRODUCT_STORAGE_STANDARD_SERVER 0x00000015")]
        public const int PRODUCT_STORAGE_STANDARD_SERVER = 0x00000015;

        [NativeTypeName("#define PRODUCT_STORAGE_WORKGROUP_SERVER 0x00000016")]
        public const int PRODUCT_STORAGE_WORKGROUP_SERVER = 0x00000016;

        [NativeTypeName("#define PRODUCT_STORAGE_ENTERPRISE_SERVER 0x00000017")]
        public const int PRODUCT_STORAGE_ENTERPRISE_SERVER = 0x00000017;

        [NativeTypeName("#define PRODUCT_SERVER_FOR_SMALLBUSINESS 0x00000018")]
        public const int PRODUCT_SERVER_FOR_SMALLBUSINESS = 0x00000018;

        [NativeTypeName("#define PRODUCT_SMALLBUSINESS_SERVER_PREMIUM 0x00000019")]
        public const int PRODUCT_SMALLBUSINESS_SERVER_PREMIUM = 0x00000019;

        [NativeTypeName("#define PRODUCT_HOME_PREMIUM_N 0x0000001A")]
        public const int PRODUCT_HOME_PREMIUM_N = 0x0000001A;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_N 0x0000001B")]
        public const int PRODUCT_ENTERPRISE_N = 0x0000001B;

        [NativeTypeName("#define PRODUCT_ULTIMATE_N 0x0000001C")]
        public const int PRODUCT_ULTIMATE_N = 0x0000001C;

        [NativeTypeName("#define PRODUCT_WEB_SERVER_CORE 0x0000001D")]
        public const int PRODUCT_WEB_SERVER_CORE = 0x0000001D;

        [NativeTypeName("#define PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT 0x0000001E")]
        public const int PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT = 0x0000001E;

        [NativeTypeName("#define PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY 0x0000001F")]
        public const int PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY = 0x0000001F;

        [NativeTypeName("#define PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING 0x00000020")]
        public const int PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING = 0x00000020;

        [NativeTypeName("#define PRODUCT_SERVER_FOUNDATION 0x00000021")]
        public const int PRODUCT_SERVER_FOUNDATION = 0x00000021;

        [NativeTypeName("#define PRODUCT_HOME_PREMIUM_SERVER 0x00000022")]
        public const int PRODUCT_HOME_PREMIUM_SERVER = 0x00000022;

        [NativeTypeName("#define PRODUCT_SERVER_FOR_SMALLBUSINESS_V 0x00000023")]
        public const int PRODUCT_SERVER_FOR_SMALLBUSINESS_V = 0x00000023;

        [NativeTypeName("#define PRODUCT_STANDARD_SERVER_V 0x00000024")]
        public const int PRODUCT_STANDARD_SERVER_V = 0x00000024;

        [NativeTypeName("#define PRODUCT_DATACENTER_SERVER_V 0x00000025")]
        public const int PRODUCT_DATACENTER_SERVER_V = 0x00000025;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_SERVER_V 0x00000026")]
        public const int PRODUCT_ENTERPRISE_SERVER_V = 0x00000026;

        [NativeTypeName("#define PRODUCT_DATACENTER_SERVER_CORE_V 0x00000027")]
        public const int PRODUCT_DATACENTER_SERVER_CORE_V = 0x00000027;

        [NativeTypeName("#define PRODUCT_STANDARD_SERVER_CORE_V 0x00000028")]
        public const int PRODUCT_STANDARD_SERVER_CORE_V = 0x00000028;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_SERVER_CORE_V 0x00000029")]
        public const int PRODUCT_ENTERPRISE_SERVER_CORE_V = 0x00000029;

        [NativeTypeName("#define PRODUCT_HYPERV 0x0000002A")]
        public const int PRODUCT_HYPERV = 0x0000002A;

        [NativeTypeName("#define PRODUCT_STORAGE_EXPRESS_SERVER_CORE 0x0000002B")]
        public const int PRODUCT_STORAGE_EXPRESS_SERVER_CORE = 0x0000002B;

        [NativeTypeName("#define PRODUCT_STORAGE_STANDARD_SERVER_CORE 0x0000002C")]
        public const int PRODUCT_STORAGE_STANDARD_SERVER_CORE = 0x0000002C;

        [NativeTypeName("#define PRODUCT_STORAGE_WORKGROUP_SERVER_CORE 0x0000002D")]
        public const int PRODUCT_STORAGE_WORKGROUP_SERVER_CORE = 0x0000002D;

        [NativeTypeName("#define PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE 0x0000002E")]
        public const int PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE = 0x0000002E;

        [NativeTypeName("#define PRODUCT_STARTER_N 0x0000002F")]
        public const int PRODUCT_STARTER_N = 0x0000002F;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL 0x00000030")]
        public const int PRODUCT_PROFESSIONAL = 0x00000030;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL_N 0x00000031")]
        public const int PRODUCT_PROFESSIONAL_N = 0x00000031;

        [NativeTypeName("#define PRODUCT_SB_SOLUTION_SERVER 0x00000032")]
        public const int PRODUCT_SB_SOLUTION_SERVER = 0x00000032;

        [NativeTypeName("#define PRODUCT_SERVER_FOR_SB_SOLUTIONS 0x00000033")]
        public const int PRODUCT_SERVER_FOR_SB_SOLUTIONS = 0x00000033;

        [NativeTypeName("#define PRODUCT_STANDARD_SERVER_SOLUTIONS 0x00000034")]
        public const int PRODUCT_STANDARD_SERVER_SOLUTIONS = 0x00000034;

        [NativeTypeName("#define PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE 0x00000035")]
        public const int PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE = 0x00000035;

        [NativeTypeName("#define PRODUCT_SB_SOLUTION_SERVER_EM 0x00000036")]
        public const int PRODUCT_SB_SOLUTION_SERVER_EM = 0x00000036;

        [NativeTypeName("#define PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM 0x00000037")]
        public const int PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM = 0x00000037;

        [NativeTypeName("#define PRODUCT_SOLUTION_EMBEDDEDSERVER 0x00000038")]
        public const int PRODUCT_SOLUTION_EMBEDDEDSERVER = 0x00000038;

        [NativeTypeName("#define PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE 0x00000039")]
        public const int PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE = 0x00000039;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL_EMBEDDED 0x0000003A")]
        public const int PRODUCT_PROFESSIONAL_EMBEDDED = 0x0000003A;

        [NativeTypeName("#define PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT 0x0000003B")]
        public const int PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT = 0x0000003B;

        [NativeTypeName("#define PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL 0x0000003C")]
        public const int PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL = 0x0000003C;

        [NativeTypeName("#define PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC 0x0000003D")]
        public const int PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC = 0x0000003D;

        [NativeTypeName("#define PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC 0x0000003E")]
        public const int PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC = 0x0000003E;

        [NativeTypeName("#define PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE 0x0000003F")]
        public const int PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE = 0x0000003F;

        [NativeTypeName("#define PRODUCT_CLUSTER_SERVER_V 0x00000040")]
        public const int PRODUCT_CLUSTER_SERVER_V = 0x00000040;

        [NativeTypeName("#define PRODUCT_EMBEDDED 0x00000041")]
        public const int PRODUCT_EMBEDDED = 0x00000041;

        [NativeTypeName("#define PRODUCT_STARTER_E 0x00000042")]
        public const int PRODUCT_STARTER_E = 0x00000042;

        [NativeTypeName("#define PRODUCT_HOME_BASIC_E 0x00000043")]
        public const int PRODUCT_HOME_BASIC_E = 0x00000043;

        [NativeTypeName("#define PRODUCT_HOME_PREMIUM_E 0x00000044")]
        public const int PRODUCT_HOME_PREMIUM_E = 0x00000044;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL_E 0x00000045")]
        public const int PRODUCT_PROFESSIONAL_E = 0x00000045;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_E 0x00000046")]
        public const int PRODUCT_ENTERPRISE_E = 0x00000046;

        [NativeTypeName("#define PRODUCT_ULTIMATE_E 0x00000047")]
        public const int PRODUCT_ULTIMATE_E = 0x00000047;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_EVALUATION 0x00000048")]
        public const int PRODUCT_ENTERPRISE_EVALUATION = 0x00000048;

        [NativeTypeName("#define PRODUCT_MULTIPOINT_STANDARD_SERVER 0x0000004C")]
        public const int PRODUCT_MULTIPOINT_STANDARD_SERVER = 0x0000004C;

        [NativeTypeName("#define PRODUCT_MULTIPOINT_PREMIUM_SERVER 0x0000004D")]
        public const int PRODUCT_MULTIPOINT_PREMIUM_SERVER = 0x0000004D;

        [NativeTypeName("#define PRODUCT_STANDARD_EVALUATION_SERVER 0x0000004F")]
        public const int PRODUCT_STANDARD_EVALUATION_SERVER = 0x0000004F;

        [NativeTypeName("#define PRODUCT_DATACENTER_EVALUATION_SERVER 0x00000050")]
        public const int PRODUCT_DATACENTER_EVALUATION_SERVER = 0x00000050;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_N_EVALUATION 0x00000054")]
        public const int PRODUCT_ENTERPRISE_N_EVALUATION = 0x00000054;

        [NativeTypeName("#define PRODUCT_EMBEDDED_AUTOMOTIVE 0x00000055")]
        public const int PRODUCT_EMBEDDED_AUTOMOTIVE = 0x00000055;

        [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY_A 0x00000056")]
        public const int PRODUCT_EMBEDDED_INDUSTRY_A = 0x00000056;

        [NativeTypeName("#define PRODUCT_THINPC 0x00000057")]
        public const int PRODUCT_THINPC = 0x00000057;

        [NativeTypeName("#define PRODUCT_EMBEDDED_A 0x00000058")]
        public const int PRODUCT_EMBEDDED_A = 0x00000058;

        [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY 0x00000059")]
        public const int PRODUCT_EMBEDDED_INDUSTRY = 0x00000059;

        [NativeTypeName("#define PRODUCT_EMBEDDED_E 0x0000005A")]
        public const int PRODUCT_EMBEDDED_E = 0x0000005A;

        [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY_E 0x0000005B")]
        public const int PRODUCT_EMBEDDED_INDUSTRY_E = 0x0000005B;

        [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY_A_E 0x0000005C")]
        public const int PRODUCT_EMBEDDED_INDUSTRY_A_E = 0x0000005C;

        [NativeTypeName("#define PRODUCT_STORAGE_WORKGROUP_EVALUATION_SERVER 0x0000005F")]
        public const int PRODUCT_STORAGE_WORKGROUP_EVALUATION_SERVER = 0x0000005F;

        [NativeTypeName("#define PRODUCT_STORAGE_STANDARD_EVALUATION_SERVER 0x00000060")]
        public const int PRODUCT_STORAGE_STANDARD_EVALUATION_SERVER = 0x00000060;

        [NativeTypeName("#define PRODUCT_CORE_ARM 0x00000061")]
        public const int PRODUCT_CORE_ARM = 0x00000061;

        [NativeTypeName("#define PRODUCT_CORE_N 0x00000062")]
        public const int PRODUCT_CORE_N = 0x00000062;

        [NativeTypeName("#define PRODUCT_CORE_COUNTRYSPECIFIC 0x00000063")]
        public const int PRODUCT_CORE_COUNTRYSPECIFIC = 0x00000063;

        [NativeTypeName("#define PRODUCT_CORE_SINGLELANGUAGE 0x00000064")]
        public const int PRODUCT_CORE_SINGLELANGUAGE = 0x00000064;

        [NativeTypeName("#define PRODUCT_CORE 0x00000065")]
        public const int PRODUCT_CORE = 0x00000065;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL_WMC 0x00000067")]
        public const int PRODUCT_PROFESSIONAL_WMC = 0x00000067;

        [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY_EVAL 0x00000069")]
        public const int PRODUCT_EMBEDDED_INDUSTRY_EVAL = 0x00000069;

        [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY_E_EVAL 0x0000006A")]
        public const int PRODUCT_EMBEDDED_INDUSTRY_E_EVAL = 0x0000006A;

        [NativeTypeName("#define PRODUCT_EMBEDDED_EVAL 0x0000006B")]
        public const int PRODUCT_EMBEDDED_EVAL = 0x0000006B;

        [NativeTypeName("#define PRODUCT_EMBEDDED_E_EVAL 0x0000006C")]
        public const int PRODUCT_EMBEDDED_E_EVAL = 0x0000006C;

        [NativeTypeName("#define PRODUCT_NANO_SERVER 0x0000006D")]
        public const int PRODUCT_NANO_SERVER = 0x0000006D;

        [NativeTypeName("#define PRODUCT_CLOUD_STORAGE_SERVER 0x0000006E")]
        public const int PRODUCT_CLOUD_STORAGE_SERVER = 0x0000006E;

        [NativeTypeName("#define PRODUCT_CORE_CONNECTED 0x0000006F")]
        public const int PRODUCT_CORE_CONNECTED = 0x0000006F;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL_STUDENT 0x00000070")]
        public const int PRODUCT_PROFESSIONAL_STUDENT = 0x00000070;

        [NativeTypeName("#define PRODUCT_CORE_CONNECTED_N 0x00000071")]
        public const int PRODUCT_CORE_CONNECTED_N = 0x00000071;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL_STUDENT_N 0x00000072")]
        public const int PRODUCT_PROFESSIONAL_STUDENT_N = 0x00000072;

        [NativeTypeName("#define PRODUCT_CORE_CONNECTED_SINGLELANGUAGE 0x00000073")]
        public const int PRODUCT_CORE_CONNECTED_SINGLELANGUAGE = 0x00000073;

        [NativeTypeName("#define PRODUCT_CORE_CONNECTED_COUNTRYSPECIFIC 0x00000074")]
        public const int PRODUCT_CORE_CONNECTED_COUNTRYSPECIFIC = 0x00000074;

        [NativeTypeName("#define PRODUCT_CONNECTED_CAR 0x00000075")]
        public const int PRODUCT_CONNECTED_CAR = 0x00000075;

        [NativeTypeName("#define PRODUCT_INDUSTRY_HANDHELD 0x00000076")]
        public const int PRODUCT_INDUSTRY_HANDHELD = 0x00000076;

        [NativeTypeName("#define PRODUCT_PPI_PRO 0x00000077")]
        public const int PRODUCT_PPI_PRO = 0x00000077;

        [NativeTypeName("#define PRODUCT_ARM64_SERVER 0x00000078")]
        public const int PRODUCT_ARM64_SERVER = 0x00000078;

        [NativeTypeName("#define PRODUCT_EDUCATION 0x00000079")]
        public const int PRODUCT_EDUCATION = 0x00000079;

        [NativeTypeName("#define PRODUCT_EDUCATION_N 0x0000007A")]
        public const int PRODUCT_EDUCATION_N = 0x0000007A;

        [NativeTypeName("#define PRODUCT_IOTUAP 0x0000007B")]
        public const int PRODUCT_IOTUAP = 0x0000007B;

        [NativeTypeName("#define PRODUCT_CLOUD_HOST_INFRASTRUCTURE_SERVER 0x0000007C")]
        public const int PRODUCT_CLOUD_HOST_INFRASTRUCTURE_SERVER = 0x0000007C;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_S 0x0000007D")]
        public const int PRODUCT_ENTERPRISE_S = 0x0000007D;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_S_N 0x0000007E")]
        public const int PRODUCT_ENTERPRISE_S_N = 0x0000007E;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL_S 0x0000007F")]
        public const int PRODUCT_PROFESSIONAL_S = 0x0000007F;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL_S_N 0x00000080")]
        public const int PRODUCT_PROFESSIONAL_S_N = 0x00000080;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_S_EVALUATION 0x00000081")]
        public const int PRODUCT_ENTERPRISE_S_EVALUATION = 0x00000081;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_S_N_EVALUATION 0x00000082")]
        public const int PRODUCT_ENTERPRISE_S_N_EVALUATION = 0x00000082;

        [NativeTypeName("#define PRODUCT_HOLOGRAPHIC 0x00000087")]
        public const int PRODUCT_HOLOGRAPHIC = 0x00000087;

        [NativeTypeName("#define PRODUCT_HOLOGRAPHIC_BUSINESS 0x00000088")]
        public const int PRODUCT_HOLOGRAPHIC_BUSINESS = 0x00000088;

        [NativeTypeName("#define PRODUCT_PRO_SINGLE_LANGUAGE 0x0000008A")]
        public const int PRODUCT_PRO_SINGLE_LANGUAGE = 0x0000008A;

        [NativeTypeName("#define PRODUCT_PRO_CHINA 0x0000008B")]
        public const int PRODUCT_PRO_CHINA = 0x0000008B;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_SUBSCRIPTION 0x0000008C")]
        public const int PRODUCT_ENTERPRISE_SUBSCRIPTION = 0x0000008C;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_SUBSCRIPTION_N 0x0000008D")]
        public const int PRODUCT_ENTERPRISE_SUBSCRIPTION_N = 0x0000008D;

        [NativeTypeName("#define PRODUCT_DATACENTER_NANO_SERVER 0x0000008F")]
        public const int PRODUCT_DATACENTER_NANO_SERVER = 0x0000008F;

        [NativeTypeName("#define PRODUCT_STANDARD_NANO_SERVER 0x00000090")]
        public const int PRODUCT_STANDARD_NANO_SERVER = 0x00000090;

        [NativeTypeName("#define PRODUCT_DATACENTER_A_SERVER_CORE 0x00000091")]
        public const int PRODUCT_DATACENTER_A_SERVER_CORE = 0x00000091;

        [NativeTypeName("#define PRODUCT_STANDARD_A_SERVER_CORE 0x00000092")]
        public const int PRODUCT_STANDARD_A_SERVER_CORE = 0x00000092;

        [NativeTypeName("#define PRODUCT_DATACENTER_WS_SERVER_CORE 0x00000093")]
        public const int PRODUCT_DATACENTER_WS_SERVER_CORE = 0x00000093;

        [NativeTypeName("#define PRODUCT_STANDARD_WS_SERVER_CORE 0x00000094")]
        public const int PRODUCT_STANDARD_WS_SERVER_CORE = 0x00000094;

        [NativeTypeName("#define PRODUCT_UTILITY_VM 0x00000095")]
        public const int PRODUCT_UTILITY_VM = 0x00000095;

        [NativeTypeName("#define PRODUCT_DATACENTER_EVALUATION_SERVER_CORE 0x0000009F")]
        public const int PRODUCT_DATACENTER_EVALUATION_SERVER_CORE = 0x0000009F;

        [NativeTypeName("#define PRODUCT_STANDARD_EVALUATION_SERVER_CORE 0x000000A0")]
        public const int PRODUCT_STANDARD_EVALUATION_SERVER_CORE = 0x000000A0;

        [NativeTypeName("#define PRODUCT_PRO_WORKSTATION 0x000000A1")]
        public const int PRODUCT_PRO_WORKSTATION = 0x000000A1;

        [NativeTypeName("#define PRODUCT_PRO_WORKSTATION_N 0x000000A2")]
        public const int PRODUCT_PRO_WORKSTATION_N = 0x000000A2;

        [NativeTypeName("#define PRODUCT_PRO_FOR_EDUCATION 0x000000A4")]
        public const int PRODUCT_PRO_FOR_EDUCATION = 0x000000A4;

        [NativeTypeName("#define PRODUCT_PRO_FOR_EDUCATION_N 0x000000A5")]
        public const int PRODUCT_PRO_FOR_EDUCATION_N = 0x000000A5;

        [NativeTypeName("#define PRODUCT_AZURE_SERVER_CORE 0x000000A8")]
        public const int PRODUCT_AZURE_SERVER_CORE = 0x000000A8;

        [NativeTypeName("#define PRODUCT_AZURE_NANO_SERVER 0x000000A9")]
        public const int PRODUCT_AZURE_NANO_SERVER = 0x000000A9;

        [NativeTypeName("#define PRODUCT_ENTERPRISEG 0x000000AB")]
        public const int PRODUCT_ENTERPRISEG = 0x000000AB;

        [NativeTypeName("#define PRODUCT_ENTERPRISEGN 0x000000AC")]
        public const int PRODUCT_ENTERPRISEGN = 0x000000AC;

        [NativeTypeName("#define PRODUCT_SERVERRDSH 0x000000AF")]
        public const int PRODUCT_SERVERRDSH = 0x000000AF;

        [NativeTypeName("#define PRODUCT_CLOUD 0x000000B2")]
        public const int PRODUCT_CLOUD = 0x000000B2;

        [NativeTypeName("#define PRODUCT_CLOUDN 0x000000B3")]
        public const int PRODUCT_CLOUDN = 0x000000B3;

        [NativeTypeName("#define PRODUCT_HUBOS 0x000000B4")]
        public const int PRODUCT_HUBOS = 0x000000B4;

        [NativeTypeName("#define PRODUCT_ONECOREUPDATEOS 0x000000B6")]
        public const int PRODUCT_ONECOREUPDATEOS = 0x000000B6;

        [NativeTypeName("#define PRODUCT_CLOUDE 0x000000B7")]
        public const int PRODUCT_CLOUDE = 0x000000B7;

        [NativeTypeName("#define PRODUCT_ANDROMEDA 0x000000B8")]
        public const int PRODUCT_ANDROMEDA = 0x000000B8;

        [NativeTypeName("#define PRODUCT_IOTOS 0x000000B9")]
        public const int PRODUCT_IOTOS = 0x000000B9;

        [NativeTypeName("#define PRODUCT_CLOUDEN 0x000000BA")]
        public const int PRODUCT_CLOUDEN = 0x000000BA;

        [NativeTypeName("#define PRODUCT_IOTEDGEOS 0x000000BB")]
        public const int PRODUCT_IOTEDGEOS = 0x000000BB;

        [NativeTypeName("#define PRODUCT_IOTENTERPRISE 0x000000BC")]
        public const int PRODUCT_IOTENTERPRISE = 0x000000BC;

        [NativeTypeName("#define PRODUCT_LITE 0x000000BD")]
        public const int PRODUCT_LITE = 0x000000BD;

        [NativeTypeName("#define PRODUCT_IOTENTERPRISES 0x000000BF")]
        public const int PRODUCT_IOTENTERPRISES = 0x000000BF;

        [NativeTypeName("#define PRODUCT_XBOX_SYSTEMOS 0x000000C0")]
        public const int PRODUCT_XBOX_SYSTEMOS = 0x000000C0;

        [NativeTypeName("#define PRODUCT_XBOX_NATIVEOS 0x000000C1")]
        public const int PRODUCT_XBOX_NATIVEOS = 0x000000C1;

        [NativeTypeName("#define PRODUCT_XBOX_GAMEOS 0x000000C2")]
        public const int PRODUCT_XBOX_GAMEOS = 0x000000C2;

        [NativeTypeName("#define PRODUCT_XBOX_ERAOS 0x000000C3")]
        public const int PRODUCT_XBOX_ERAOS = 0x000000C3;

        [NativeTypeName("#define PRODUCT_XBOX_DURANGOHOSTOS 0x000000C4")]
        public const int PRODUCT_XBOX_DURANGOHOSTOS = 0x000000C4;

        [NativeTypeName("#define PRODUCT_XBOX_SCARLETTHOSTOS 0x000000C5")]
        public const int PRODUCT_XBOX_SCARLETTHOSTOS = 0x000000C5;

        [NativeTypeName("#define PRODUCT_UNLICENSED 0xABCDABCD")]
        public const uint PRODUCT_UNLICENSED = 0xABCDABCD;

        [NativeTypeName("#define LANG_NEUTRAL 0x00")]
        public const int LANG_NEUTRAL = 0x00;

        [NativeTypeName("#define LANG_INVARIANT 0x7f")]
        public const int LANG_INVARIANT = 0x7f;

        [NativeTypeName("#define LANG_AFRIKAANS 0x36")]
        public const int LANG_AFRIKAANS = 0x36;

        [NativeTypeName("#define LANG_ALBANIAN 0x1c")]
        public const int LANG_ALBANIAN = 0x1c;

        [NativeTypeName("#define LANG_ALSATIAN 0x84")]
        public const int LANG_ALSATIAN = 0x84;

        [NativeTypeName("#define LANG_AMHARIC 0x5e")]
        public const int LANG_AMHARIC = 0x5e;

        [NativeTypeName("#define LANG_ARABIC 0x01")]
        public const int LANG_ARABIC = 0x01;

        [NativeTypeName("#define LANG_ARMENIAN 0x2b")]
        public const int LANG_ARMENIAN = 0x2b;

        [NativeTypeName("#define LANG_ASSAMESE 0x4d")]
        public const int LANG_ASSAMESE = 0x4d;

        [NativeTypeName("#define LANG_AZERI 0x2c")]
        public const int LANG_AZERI = 0x2c;

        [NativeTypeName("#define LANG_AZERBAIJANI 0x2c")]
        public const int LANG_AZERBAIJANI = 0x2c;

        [NativeTypeName("#define LANG_BANGLA 0x45")]
        public const int LANG_BANGLA = 0x45;

        [NativeTypeName("#define LANG_BASHKIR 0x6d")]
        public const int LANG_BASHKIR = 0x6d;

        [NativeTypeName("#define LANG_BASQUE 0x2d")]
        public const int LANG_BASQUE = 0x2d;

        [NativeTypeName("#define LANG_BELARUSIAN 0x23")]
        public const int LANG_BELARUSIAN = 0x23;

        [NativeTypeName("#define LANG_BENGALI 0x45")]
        public const int LANG_BENGALI = 0x45;

        [NativeTypeName("#define LANG_BRETON 0x7e")]
        public const int LANG_BRETON = 0x7e;

        [NativeTypeName("#define LANG_BOSNIAN 0x1a")]
        public const int LANG_BOSNIAN = 0x1a;

        [NativeTypeName("#define LANG_BOSNIAN_NEUTRAL 0x781a")]
        public const int LANG_BOSNIAN_NEUTRAL = 0x781a;

        [NativeTypeName("#define LANG_BULGARIAN 0x02")]
        public const int LANG_BULGARIAN = 0x02;

        [NativeTypeName("#define LANG_CATALAN 0x03")]
        public const int LANG_CATALAN = 0x03;

        [NativeTypeName("#define LANG_CENTRAL_KURDISH 0x92")]
        public const int LANG_CENTRAL_KURDISH = 0x92;

        [NativeTypeName("#define LANG_CHEROKEE 0x5c")]
        public const int LANG_CHEROKEE = 0x5c;

        [NativeTypeName("#define LANG_CHINESE 0x04")]
        public const int LANG_CHINESE = 0x04;

        [NativeTypeName("#define LANG_CHINESE_SIMPLIFIED 0x04")]
        public const int LANG_CHINESE_SIMPLIFIED = 0x04;

        [NativeTypeName("#define LANG_CHINESE_TRADITIONAL 0x7c04")]
        public const int LANG_CHINESE_TRADITIONAL = 0x7c04;

        [NativeTypeName("#define LANG_CORSICAN 0x83")]
        public const int LANG_CORSICAN = 0x83;

        [NativeTypeName("#define LANG_CROATIAN 0x1a")]
        public const int LANG_CROATIAN = 0x1a;

        [NativeTypeName("#define LANG_CZECH 0x05")]
        public const int LANG_CZECH = 0x05;

        [NativeTypeName("#define LANG_DANISH 0x06")]
        public const int LANG_DANISH = 0x06;

        [NativeTypeName("#define LANG_DARI 0x8c")]
        public const int LANG_DARI = 0x8c;

        [NativeTypeName("#define LANG_DIVEHI 0x65")]
        public const int LANG_DIVEHI = 0x65;

        [NativeTypeName("#define LANG_DUTCH 0x13")]
        public const int LANG_DUTCH = 0x13;

        [NativeTypeName("#define LANG_ENGLISH 0x09")]
        public const int LANG_ENGLISH = 0x09;

        [NativeTypeName("#define LANG_ESTONIAN 0x25")]
        public const int LANG_ESTONIAN = 0x25;

        [NativeTypeName("#define LANG_FAEROESE 0x38")]
        public const int LANG_FAEROESE = 0x38;

        [NativeTypeName("#define LANG_FARSI 0x29")]
        public const int LANG_FARSI = 0x29;

        [NativeTypeName("#define LANG_FILIPINO 0x64")]
        public const int LANG_FILIPINO = 0x64;

        [NativeTypeName("#define LANG_FINNISH 0x0b")]
        public const int LANG_FINNISH = 0x0b;

        [NativeTypeName("#define LANG_FRENCH 0x0c")]
        public const int LANG_FRENCH = 0x0c;

        [NativeTypeName("#define LANG_FRISIAN 0x62")]
        public const int LANG_FRISIAN = 0x62;

        [NativeTypeName("#define LANG_FULAH 0x67")]
        public const int LANG_FULAH = 0x67;

        [NativeTypeName("#define LANG_GALICIAN 0x56")]
        public const int LANG_GALICIAN = 0x56;

        [NativeTypeName("#define LANG_GEORGIAN 0x37")]
        public const int LANG_GEORGIAN = 0x37;

        [NativeTypeName("#define LANG_GERMAN 0x07")]
        public const int LANG_GERMAN = 0x07;

        [NativeTypeName("#define LANG_GREEK 0x08")]
        public const int LANG_GREEK = 0x08;

        [NativeTypeName("#define LANG_GREENLANDIC 0x6f")]
        public const int LANG_GREENLANDIC = 0x6f;

        [NativeTypeName("#define LANG_GUJARATI 0x47")]
        public const int LANG_GUJARATI = 0x47;

        [NativeTypeName("#define LANG_HAUSA 0x68")]
        public const int LANG_HAUSA = 0x68;

        [NativeTypeName("#define LANG_HAWAIIAN 0x75")]
        public const int LANG_HAWAIIAN = 0x75;

        [NativeTypeName("#define LANG_HEBREW 0x0d")]
        public const int LANG_HEBREW = 0x0d;

        [NativeTypeName("#define LANG_HINDI 0x39")]
        public const int LANG_HINDI = 0x39;

        [NativeTypeName("#define LANG_HUNGARIAN 0x0e")]
        public const int LANG_HUNGARIAN = 0x0e;

        [NativeTypeName("#define LANG_ICELANDIC 0x0f")]
        public const int LANG_ICELANDIC = 0x0f;

        [NativeTypeName("#define LANG_IGBO 0x70")]
        public const int LANG_IGBO = 0x70;

        [NativeTypeName("#define LANG_INDONESIAN 0x21")]
        public const int LANG_INDONESIAN = 0x21;

        [NativeTypeName("#define LANG_INUKTITUT 0x5d")]
        public const int LANG_INUKTITUT = 0x5d;

        [NativeTypeName("#define LANG_IRISH 0x3c")]
        public const int LANG_IRISH = 0x3c;

        [NativeTypeName("#define LANG_ITALIAN 0x10")]
        public const int LANG_ITALIAN = 0x10;

        [NativeTypeName("#define LANG_JAPANESE 0x11")]
        public const int LANG_JAPANESE = 0x11;

        [NativeTypeName("#define LANG_KANNADA 0x4b")]
        public const int LANG_KANNADA = 0x4b;

        [NativeTypeName("#define LANG_KASHMIRI 0x60")]
        public const int LANG_KASHMIRI = 0x60;

        [NativeTypeName("#define LANG_KAZAK 0x3f")]
        public const int LANG_KAZAK = 0x3f;

        [NativeTypeName("#define LANG_KHMER 0x53")]
        public const int LANG_KHMER = 0x53;

        [NativeTypeName("#define LANG_KICHE 0x86")]
        public const int LANG_KICHE = 0x86;

        [NativeTypeName("#define LANG_KINYARWANDA 0x87")]
        public const int LANG_KINYARWANDA = 0x87;

        [NativeTypeName("#define LANG_KONKANI 0x57")]
        public const int LANG_KONKANI = 0x57;

        [NativeTypeName("#define LANG_KOREAN 0x12")]
        public const int LANG_KOREAN = 0x12;

        [NativeTypeName("#define LANG_KYRGYZ 0x40")]
        public const int LANG_KYRGYZ = 0x40;

        [NativeTypeName("#define LANG_LAO 0x54")]
        public const int LANG_LAO = 0x54;

        [NativeTypeName("#define LANG_LATVIAN 0x26")]
        public const int LANG_LATVIAN = 0x26;

        [NativeTypeName("#define LANG_LITHUANIAN 0x27")]
        public const int LANG_LITHUANIAN = 0x27;

        [NativeTypeName("#define LANG_LOWER_SORBIAN 0x2e")]
        public const int LANG_LOWER_SORBIAN = 0x2e;

        [NativeTypeName("#define LANG_LUXEMBOURGISH 0x6e")]
        public const int LANG_LUXEMBOURGISH = 0x6e;

        [NativeTypeName("#define LANG_MACEDONIAN 0x2f")]
        public const int LANG_MACEDONIAN = 0x2f;

        [NativeTypeName("#define LANG_MALAY 0x3e")]
        public const int LANG_MALAY = 0x3e;

        [NativeTypeName("#define LANG_MALAYALAM 0x4c")]
        public const int LANG_MALAYALAM = 0x4c;

        [NativeTypeName("#define LANG_MALTESE 0x3a")]
        public const int LANG_MALTESE = 0x3a;

        [NativeTypeName("#define LANG_MANIPURI 0x58")]
        public const int LANG_MANIPURI = 0x58;

        [NativeTypeName("#define LANG_MAORI 0x81")]
        public const int LANG_MAORI = 0x81;

        [NativeTypeName("#define LANG_MAPUDUNGUN 0x7a")]
        public const int LANG_MAPUDUNGUN = 0x7a;

        [NativeTypeName("#define LANG_MARATHI 0x4e")]
        public const int LANG_MARATHI = 0x4e;

        [NativeTypeName("#define LANG_MOHAWK 0x7c")]
        public const int LANG_MOHAWK = 0x7c;

        [NativeTypeName("#define LANG_MONGOLIAN 0x50")]
        public const int LANG_MONGOLIAN = 0x50;

        [NativeTypeName("#define LANG_NEPALI 0x61")]
        public const int LANG_NEPALI = 0x61;

        [NativeTypeName("#define LANG_NORWEGIAN 0x14")]
        public const int LANG_NORWEGIAN = 0x14;

        [NativeTypeName("#define LANG_OCCITAN 0x82")]
        public const int LANG_OCCITAN = 0x82;

        [NativeTypeName("#define LANG_ODIA 0x48")]
        public const int LANG_ODIA = 0x48;

        [NativeTypeName("#define LANG_ORIYA 0x48")]
        public const int LANG_ORIYA = 0x48;

        [NativeTypeName("#define LANG_PASHTO 0x63")]
        public const int LANG_PASHTO = 0x63;

        [NativeTypeName("#define LANG_PERSIAN 0x29")]
        public const int LANG_PERSIAN = 0x29;

        [NativeTypeName("#define LANG_POLISH 0x15")]
        public const int LANG_POLISH = 0x15;

        [NativeTypeName("#define LANG_PORTUGUESE 0x16")]
        public const int LANG_PORTUGUESE = 0x16;

        [NativeTypeName("#define LANG_PULAR 0x67")]
        public const int LANG_PULAR = 0x67;

        [NativeTypeName("#define LANG_PUNJABI 0x46")]
        public const int LANG_PUNJABI = 0x46;

        [NativeTypeName("#define LANG_QUECHUA 0x6b")]
        public const int LANG_QUECHUA = 0x6b;

        [NativeTypeName("#define LANG_ROMANIAN 0x18")]
        public const int LANG_ROMANIAN = 0x18;

        [NativeTypeName("#define LANG_ROMANSH 0x17")]
        public const int LANG_ROMANSH = 0x17;

        [NativeTypeName("#define LANG_RUSSIAN 0x19")]
        public const int LANG_RUSSIAN = 0x19;

        [NativeTypeName("#define LANG_SAKHA 0x85")]
        public const int LANG_SAKHA = 0x85;

        [NativeTypeName("#define LANG_SAMI 0x3b")]
        public const int LANG_SAMI = 0x3b;

        [NativeTypeName("#define LANG_SANSKRIT 0x4f")]
        public const int LANG_SANSKRIT = 0x4f;

        [NativeTypeName("#define LANG_SCOTTISH_GAELIC 0x91")]
        public const int LANG_SCOTTISH_GAELIC = 0x91;

        [NativeTypeName("#define LANG_SERBIAN 0x1a")]
        public const int LANG_SERBIAN = 0x1a;

        [NativeTypeName("#define LANG_SERBIAN_NEUTRAL 0x7c1a")]
        public const int LANG_SERBIAN_NEUTRAL = 0x7c1a;

        [NativeTypeName("#define LANG_SINDHI 0x59")]
        public const int LANG_SINDHI = 0x59;

        [NativeTypeName("#define LANG_SINHALESE 0x5b")]
        public const int LANG_SINHALESE = 0x5b;

        [NativeTypeName("#define LANG_SLOVAK 0x1b")]
        public const int LANG_SLOVAK = 0x1b;

        [NativeTypeName("#define LANG_SLOVENIAN 0x24")]
        public const int LANG_SLOVENIAN = 0x24;

        [NativeTypeName("#define LANG_SOTHO 0x6c")]
        public const int LANG_SOTHO = 0x6c;

        [NativeTypeName("#define LANG_SPANISH 0x0a")]
        public const int LANG_SPANISH = 0x0a;

        [NativeTypeName("#define LANG_SWAHILI 0x41")]
        public const int LANG_SWAHILI = 0x41;

        [NativeTypeName("#define LANG_SWEDISH 0x1d")]
        public const int LANG_SWEDISH = 0x1d;

        [NativeTypeName("#define LANG_SYRIAC 0x5a")]
        public const int LANG_SYRIAC = 0x5a;

        [NativeTypeName("#define LANG_TAJIK 0x28")]
        public const int LANG_TAJIK = 0x28;

        [NativeTypeName("#define LANG_TAMAZIGHT 0x5f")]
        public const int LANG_TAMAZIGHT = 0x5f;

        [NativeTypeName("#define LANG_TAMIL 0x49")]
        public const int LANG_TAMIL = 0x49;

        [NativeTypeName("#define LANG_TATAR 0x44")]
        public const int LANG_TATAR = 0x44;

        [NativeTypeName("#define LANG_TELUGU 0x4a")]
        public const int LANG_TELUGU = 0x4a;

        [NativeTypeName("#define LANG_THAI 0x1e")]
        public const int LANG_THAI = 0x1e;

        [NativeTypeName("#define LANG_TIBETAN 0x51")]
        public const int LANG_TIBETAN = 0x51;

        [NativeTypeName("#define LANG_TIGRIGNA 0x73")]
        public const int LANG_TIGRIGNA = 0x73;

        [NativeTypeName("#define LANG_TIGRINYA 0x73")]
        public const int LANG_TIGRINYA = 0x73;

        [NativeTypeName("#define LANG_TSWANA 0x32")]
        public const int LANG_TSWANA = 0x32;

        [NativeTypeName("#define LANG_TURKISH 0x1f")]
        public const int LANG_TURKISH = 0x1f;

        [NativeTypeName("#define LANG_TURKMEN 0x42")]
        public const int LANG_TURKMEN = 0x42;

        [NativeTypeName("#define LANG_UIGHUR 0x80")]
        public const int LANG_UIGHUR = 0x80;

        [NativeTypeName("#define LANG_UKRAINIAN 0x22")]
        public const int LANG_UKRAINIAN = 0x22;

        [NativeTypeName("#define LANG_UPPER_SORBIAN 0x2e")]
        public const int LANG_UPPER_SORBIAN = 0x2e;

        [NativeTypeName("#define LANG_URDU 0x20")]
        public const int LANG_URDU = 0x20;

        [NativeTypeName("#define LANG_UZBEK 0x43")]
        public const int LANG_UZBEK = 0x43;

        [NativeTypeName("#define LANG_VALENCIAN 0x03")]
        public const int LANG_VALENCIAN = 0x03;

        [NativeTypeName("#define LANG_VIETNAMESE 0x2a")]
        public const int LANG_VIETNAMESE = 0x2a;

        [NativeTypeName("#define LANG_WELSH 0x52")]
        public const int LANG_WELSH = 0x52;

        [NativeTypeName("#define LANG_WOLOF 0x88")]
        public const int LANG_WOLOF = 0x88;

        [NativeTypeName("#define LANG_XHOSA 0x34")]
        public const int LANG_XHOSA = 0x34;

        [NativeTypeName("#define LANG_YAKUT 0x85")]
        public const int LANG_YAKUT = 0x85;

        [NativeTypeName("#define LANG_YI 0x78")]
        public const int LANG_YI = 0x78;

        [NativeTypeName("#define LANG_YORUBA 0x6a")]
        public const int LANG_YORUBA = 0x6a;

        [NativeTypeName("#define LANG_ZULU 0x35")]
        public const int LANG_ZULU = 0x35;

        [NativeTypeName("#define SUBLANG_NEUTRAL 0x00")]
        public const int SUBLANG_NEUTRAL = 0x00;

        [NativeTypeName("#define SUBLANG_DEFAULT 0x01")]
        public const int SUBLANG_DEFAULT = 0x01;

        [NativeTypeName("#define SUBLANG_SYS_DEFAULT 0x02")]
        public const int SUBLANG_SYS_DEFAULT = 0x02;

        [NativeTypeName("#define SUBLANG_CUSTOM_DEFAULT 0x03")]
        public const int SUBLANG_CUSTOM_DEFAULT = 0x03;

        [NativeTypeName("#define SUBLANG_CUSTOM_UNSPECIFIED 0x04")]
        public const int SUBLANG_CUSTOM_UNSPECIFIED = 0x04;

        [NativeTypeName("#define SUBLANG_UI_CUSTOM_DEFAULT 0x05")]
        public const int SUBLANG_UI_CUSTOM_DEFAULT = 0x05;

        [NativeTypeName("#define SUBLANG_AFRIKAANS_SOUTH_AFRICA 0x01")]
        public const int SUBLANG_AFRIKAANS_SOUTH_AFRICA = 0x01;

        [NativeTypeName("#define SUBLANG_ALBANIAN_ALBANIA 0x01")]
        public const int SUBLANG_ALBANIAN_ALBANIA = 0x01;

        [NativeTypeName("#define SUBLANG_ALSATIAN_FRANCE 0x01")]
        public const int SUBLANG_ALSATIAN_FRANCE = 0x01;

        [NativeTypeName("#define SUBLANG_AMHARIC_ETHIOPIA 0x01")]
        public const int SUBLANG_AMHARIC_ETHIOPIA = 0x01;

        [NativeTypeName("#define SUBLANG_ARABIC_SAUDI_ARABIA 0x01")]
        public const int SUBLANG_ARABIC_SAUDI_ARABIA = 0x01;

        [NativeTypeName("#define SUBLANG_ARABIC_IRAQ 0x02")]
        public const int SUBLANG_ARABIC_IRAQ = 0x02;

        [NativeTypeName("#define SUBLANG_ARABIC_EGYPT 0x03")]
        public const int SUBLANG_ARABIC_EGYPT = 0x03;

        [NativeTypeName("#define SUBLANG_ARABIC_LIBYA 0x04")]
        public const int SUBLANG_ARABIC_LIBYA = 0x04;

        [NativeTypeName("#define SUBLANG_ARABIC_ALGERIA 0x05")]
        public const int SUBLANG_ARABIC_ALGERIA = 0x05;

        [NativeTypeName("#define SUBLANG_ARABIC_MOROCCO 0x06")]
        public const int SUBLANG_ARABIC_MOROCCO = 0x06;

        [NativeTypeName("#define SUBLANG_ARABIC_TUNISIA 0x07")]
        public const int SUBLANG_ARABIC_TUNISIA = 0x07;

        [NativeTypeName("#define SUBLANG_ARABIC_OMAN 0x08")]
        public const int SUBLANG_ARABIC_OMAN = 0x08;

        [NativeTypeName("#define SUBLANG_ARABIC_YEMEN 0x09")]
        public const int SUBLANG_ARABIC_YEMEN = 0x09;

        [NativeTypeName("#define SUBLANG_ARABIC_SYRIA 0x0a")]
        public const int SUBLANG_ARABIC_SYRIA = 0x0a;

        [NativeTypeName("#define SUBLANG_ARABIC_JORDAN 0x0b")]
        public const int SUBLANG_ARABIC_JORDAN = 0x0b;

        [NativeTypeName("#define SUBLANG_ARABIC_LEBANON 0x0c")]
        public const int SUBLANG_ARABIC_LEBANON = 0x0c;

        [NativeTypeName("#define SUBLANG_ARABIC_KUWAIT 0x0d")]
        public const int SUBLANG_ARABIC_KUWAIT = 0x0d;

        [NativeTypeName("#define SUBLANG_ARABIC_UAE 0x0e")]
        public const int SUBLANG_ARABIC_UAE = 0x0e;

        [NativeTypeName("#define SUBLANG_ARABIC_BAHRAIN 0x0f")]
        public const int SUBLANG_ARABIC_BAHRAIN = 0x0f;

        [NativeTypeName("#define SUBLANG_ARABIC_QATAR 0x10")]
        public const int SUBLANG_ARABIC_QATAR = 0x10;

        [NativeTypeName("#define SUBLANG_ARMENIAN_ARMENIA 0x01")]
        public const int SUBLANG_ARMENIAN_ARMENIA = 0x01;

        [NativeTypeName("#define SUBLANG_ASSAMESE_INDIA 0x01")]
        public const int SUBLANG_ASSAMESE_INDIA = 0x01;

        [NativeTypeName("#define SUBLANG_AZERI_LATIN 0x01")]
        public const int SUBLANG_AZERI_LATIN = 0x01;

        [NativeTypeName("#define SUBLANG_AZERI_CYRILLIC 0x02")]
        public const int SUBLANG_AZERI_CYRILLIC = 0x02;

        [NativeTypeName("#define SUBLANG_AZERBAIJANI_AZERBAIJAN_LATIN 0x01")]
        public const int SUBLANG_AZERBAIJANI_AZERBAIJAN_LATIN = 0x01;

        [NativeTypeName("#define SUBLANG_AZERBAIJANI_AZERBAIJAN_CYRILLIC 0x02")]
        public const int SUBLANG_AZERBAIJANI_AZERBAIJAN_CYRILLIC = 0x02;

        [NativeTypeName("#define SUBLANG_BANGLA_INDIA 0x01")]
        public const int SUBLANG_BANGLA_INDIA = 0x01;

        [NativeTypeName("#define SUBLANG_BANGLA_BANGLADESH 0x02")]
        public const int SUBLANG_BANGLA_BANGLADESH = 0x02;

        [NativeTypeName("#define SUBLANG_BASHKIR_RUSSIA 0x01")]
        public const int SUBLANG_BASHKIR_RUSSIA = 0x01;

        [NativeTypeName("#define SUBLANG_BASQUE_BASQUE 0x01")]
        public const int SUBLANG_BASQUE_BASQUE = 0x01;

        [NativeTypeName("#define SUBLANG_BELARUSIAN_BELARUS 0x01")]
        public const int SUBLANG_BELARUSIAN_BELARUS = 0x01;

        [NativeTypeName("#define SUBLANG_BENGALI_INDIA 0x01")]
        public const int SUBLANG_BENGALI_INDIA = 0x01;

        [NativeTypeName("#define SUBLANG_BENGALI_BANGLADESH 0x02")]
        public const int SUBLANG_BENGALI_BANGLADESH = 0x02;

        [NativeTypeName("#define SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_LATIN 0x05")]
        public const int SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_LATIN = 0x05;

        [NativeTypeName("#define SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_CYRILLIC 0x08")]
        public const int SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_CYRILLIC = 0x08;

        [NativeTypeName("#define SUBLANG_BRETON_FRANCE 0x01")]
        public const int SUBLANG_BRETON_FRANCE = 0x01;

        [NativeTypeName("#define SUBLANG_BULGARIAN_BULGARIA 0x01")]
        public const int SUBLANG_BULGARIAN_BULGARIA = 0x01;

        [NativeTypeName("#define SUBLANG_CATALAN_CATALAN 0x01")]
        public const int SUBLANG_CATALAN_CATALAN = 0x01;

        [NativeTypeName("#define SUBLANG_CENTRAL_KURDISH_IRAQ 0x01")]
        public const int SUBLANG_CENTRAL_KURDISH_IRAQ = 0x01;

        [NativeTypeName("#define SUBLANG_CHEROKEE_CHEROKEE 0x01")]
        public const int SUBLANG_CHEROKEE_CHEROKEE = 0x01;

        [NativeTypeName("#define SUBLANG_CHINESE_TRADITIONAL 0x01")]
        public const int SUBLANG_CHINESE_TRADITIONAL = 0x01;

        [NativeTypeName("#define SUBLANG_CHINESE_SIMPLIFIED 0x02")]
        public const int SUBLANG_CHINESE_SIMPLIFIED = 0x02;

        [NativeTypeName("#define SUBLANG_CHINESE_HONGKONG 0x03")]
        public const int SUBLANG_CHINESE_HONGKONG = 0x03;

        [NativeTypeName("#define SUBLANG_CHINESE_SINGAPORE 0x04")]
        public const int SUBLANG_CHINESE_SINGAPORE = 0x04;

        [NativeTypeName("#define SUBLANG_CHINESE_MACAU 0x05")]
        public const int SUBLANG_CHINESE_MACAU = 0x05;

        [NativeTypeName("#define SUBLANG_CORSICAN_FRANCE 0x01")]
        public const int SUBLANG_CORSICAN_FRANCE = 0x01;

        [NativeTypeName("#define SUBLANG_CZECH_CZECH_REPUBLIC 0x01")]
        public const int SUBLANG_CZECH_CZECH_REPUBLIC = 0x01;

        [NativeTypeName("#define SUBLANG_CROATIAN_CROATIA 0x01")]
        public const int SUBLANG_CROATIAN_CROATIA = 0x01;

        [NativeTypeName("#define SUBLANG_CROATIAN_BOSNIA_HERZEGOVINA_LATIN 0x04")]
        public const int SUBLANG_CROATIAN_BOSNIA_HERZEGOVINA_LATIN = 0x04;

        [NativeTypeName("#define SUBLANG_DANISH_DENMARK 0x01")]
        public const int SUBLANG_DANISH_DENMARK = 0x01;

        [NativeTypeName("#define SUBLANG_DARI_AFGHANISTAN 0x01")]
        public const int SUBLANG_DARI_AFGHANISTAN = 0x01;

        [NativeTypeName("#define SUBLANG_DIVEHI_MALDIVES 0x01")]
        public const int SUBLANG_DIVEHI_MALDIVES = 0x01;

        [NativeTypeName("#define SUBLANG_DUTCH 0x01")]
        public const int SUBLANG_DUTCH = 0x01;

        [NativeTypeName("#define SUBLANG_DUTCH_BELGIAN 0x02")]
        public const int SUBLANG_DUTCH_BELGIAN = 0x02;

        [NativeTypeName("#define SUBLANG_ENGLISH_US 0x01")]
        public const int SUBLANG_ENGLISH_US = 0x01;

        [NativeTypeName("#define SUBLANG_ENGLISH_UK 0x02")]
        public const int SUBLANG_ENGLISH_UK = 0x02;

        [NativeTypeName("#define SUBLANG_ENGLISH_AUS 0x03")]
        public const int SUBLANG_ENGLISH_AUS = 0x03;

        [NativeTypeName("#define SUBLANG_ENGLISH_CAN 0x04")]
        public const int SUBLANG_ENGLISH_CAN = 0x04;

        [NativeTypeName("#define SUBLANG_ENGLISH_NZ 0x05")]
        public const int SUBLANG_ENGLISH_NZ = 0x05;

        [NativeTypeName("#define SUBLANG_ENGLISH_EIRE 0x06")]
        public const int SUBLANG_ENGLISH_EIRE = 0x06;

        [NativeTypeName("#define SUBLANG_ENGLISH_SOUTH_AFRICA 0x07")]
        public const int SUBLANG_ENGLISH_SOUTH_AFRICA = 0x07;

        [NativeTypeName("#define SUBLANG_ENGLISH_JAMAICA 0x08")]
        public const int SUBLANG_ENGLISH_JAMAICA = 0x08;

        [NativeTypeName("#define SUBLANG_ENGLISH_CARIBBEAN 0x09")]
        public const int SUBLANG_ENGLISH_CARIBBEAN = 0x09;

        [NativeTypeName("#define SUBLANG_ENGLISH_BELIZE 0x0a")]
        public const int SUBLANG_ENGLISH_BELIZE = 0x0a;

        [NativeTypeName("#define SUBLANG_ENGLISH_TRINIDAD 0x0b")]
        public const int SUBLANG_ENGLISH_TRINIDAD = 0x0b;

        [NativeTypeName("#define SUBLANG_ENGLISH_ZIMBABWE 0x0c")]
        public const int SUBLANG_ENGLISH_ZIMBABWE = 0x0c;

        [NativeTypeName("#define SUBLANG_ENGLISH_PHILIPPINES 0x0d")]
        public const int SUBLANG_ENGLISH_PHILIPPINES = 0x0d;

        [NativeTypeName("#define SUBLANG_ENGLISH_INDIA 0x10")]
        public const int SUBLANG_ENGLISH_INDIA = 0x10;

        [NativeTypeName("#define SUBLANG_ENGLISH_MALAYSIA 0x11")]
        public const int SUBLANG_ENGLISH_MALAYSIA = 0x11;

        [NativeTypeName("#define SUBLANG_ENGLISH_SINGAPORE 0x12")]
        public const int SUBLANG_ENGLISH_SINGAPORE = 0x12;

        [NativeTypeName("#define SUBLANG_ESTONIAN_ESTONIA 0x01")]
        public const int SUBLANG_ESTONIAN_ESTONIA = 0x01;

        [NativeTypeName("#define SUBLANG_FAEROESE_FAROE_ISLANDS 0x01")]
        public const int SUBLANG_FAEROESE_FAROE_ISLANDS = 0x01;

        [NativeTypeName("#define SUBLANG_FILIPINO_PHILIPPINES 0x01")]
        public const int SUBLANG_FILIPINO_PHILIPPINES = 0x01;

        [NativeTypeName("#define SUBLANG_FINNISH_FINLAND 0x01")]
        public const int SUBLANG_FINNISH_FINLAND = 0x01;

        [NativeTypeName("#define SUBLANG_FRENCH 0x01")]
        public const int SUBLANG_FRENCH = 0x01;

        [NativeTypeName("#define SUBLANG_FRENCH_BELGIAN 0x02")]
        public const int SUBLANG_FRENCH_BELGIAN = 0x02;

        [NativeTypeName("#define SUBLANG_FRENCH_CANADIAN 0x03")]
        public const int SUBLANG_FRENCH_CANADIAN = 0x03;

        [NativeTypeName("#define SUBLANG_FRENCH_SWISS 0x04")]
        public const int SUBLANG_FRENCH_SWISS = 0x04;

        [NativeTypeName("#define SUBLANG_FRENCH_LUXEMBOURG 0x05")]
        public const int SUBLANG_FRENCH_LUXEMBOURG = 0x05;

        [NativeTypeName("#define SUBLANG_FRENCH_MONACO 0x06")]
        public const int SUBLANG_FRENCH_MONACO = 0x06;

        [NativeTypeName("#define SUBLANG_FRISIAN_NETHERLANDS 0x01")]
        public const int SUBLANG_FRISIAN_NETHERLANDS = 0x01;

        [NativeTypeName("#define SUBLANG_FULAH_SENEGAL 0x02")]
        public const int SUBLANG_FULAH_SENEGAL = 0x02;

        [NativeTypeName("#define SUBLANG_GALICIAN_GALICIAN 0x01")]
        public const int SUBLANG_GALICIAN_GALICIAN = 0x01;

        [NativeTypeName("#define SUBLANG_GEORGIAN_GEORGIA 0x01")]
        public const int SUBLANG_GEORGIAN_GEORGIA = 0x01;

        [NativeTypeName("#define SUBLANG_GERMAN 0x01")]
        public const int SUBLANG_GERMAN = 0x01;

        [NativeTypeName("#define SUBLANG_GERMAN_SWISS 0x02")]
        public const int SUBLANG_GERMAN_SWISS = 0x02;

        [NativeTypeName("#define SUBLANG_GERMAN_AUSTRIAN 0x03")]
        public const int SUBLANG_GERMAN_AUSTRIAN = 0x03;

        [NativeTypeName("#define SUBLANG_GERMAN_LUXEMBOURG 0x04")]
        public const int SUBLANG_GERMAN_LUXEMBOURG = 0x04;

        [NativeTypeName("#define SUBLANG_GERMAN_LIECHTENSTEIN 0x05")]
        public const int SUBLANG_GERMAN_LIECHTENSTEIN = 0x05;

        [NativeTypeName("#define SUBLANG_GREEK_GREECE 0x01")]
        public const int SUBLANG_GREEK_GREECE = 0x01;

        [NativeTypeName("#define SUBLANG_GREENLANDIC_GREENLAND 0x01")]
        public const int SUBLANG_GREENLANDIC_GREENLAND = 0x01;

        [NativeTypeName("#define SUBLANG_GUJARATI_INDIA 0x01")]
        public const int SUBLANG_GUJARATI_INDIA = 0x01;

        [NativeTypeName("#define SUBLANG_HAUSA_NIGERIA_LATIN 0x01")]
        public const int SUBLANG_HAUSA_NIGERIA_LATIN = 0x01;

        [NativeTypeName("#define SUBLANG_HAWAIIAN_US 0x01")]
        public const int SUBLANG_HAWAIIAN_US = 0x01;

        [NativeTypeName("#define SUBLANG_HEBREW_ISRAEL 0x01")]
        public const int SUBLANG_HEBREW_ISRAEL = 0x01;

        [NativeTypeName("#define SUBLANG_HINDI_INDIA 0x01")]
        public const int SUBLANG_HINDI_INDIA = 0x01;

        [NativeTypeName("#define SUBLANG_HUNGARIAN_HUNGARY 0x01")]
        public const int SUBLANG_HUNGARIAN_HUNGARY = 0x01;

        [NativeTypeName("#define SUBLANG_ICELANDIC_ICELAND 0x01")]
        public const int SUBLANG_ICELANDIC_ICELAND = 0x01;

        [NativeTypeName("#define SUBLANG_IGBO_NIGERIA 0x01")]
        public const int SUBLANG_IGBO_NIGERIA = 0x01;

        [NativeTypeName("#define SUBLANG_INDONESIAN_INDONESIA 0x01")]
        public const int SUBLANG_INDONESIAN_INDONESIA = 0x01;

        [NativeTypeName("#define SUBLANG_INUKTITUT_CANADA 0x01")]
        public const int SUBLANG_INUKTITUT_CANADA = 0x01;

        [NativeTypeName("#define SUBLANG_INUKTITUT_CANADA_LATIN 0x02")]
        public const int SUBLANG_INUKTITUT_CANADA_LATIN = 0x02;

        [NativeTypeName("#define SUBLANG_IRISH_IRELAND 0x02")]
        public const int SUBLANG_IRISH_IRELAND = 0x02;

        [NativeTypeName("#define SUBLANG_ITALIAN 0x01")]
        public const int SUBLANG_ITALIAN = 0x01;

        [NativeTypeName("#define SUBLANG_ITALIAN_SWISS 0x02")]
        public const int SUBLANG_ITALIAN_SWISS = 0x02;

        [NativeTypeName("#define SUBLANG_JAPANESE_JAPAN 0x01")]
        public const int SUBLANG_JAPANESE_JAPAN = 0x01;

        [NativeTypeName("#define SUBLANG_KANNADA_INDIA 0x01")]
        public const int SUBLANG_KANNADA_INDIA = 0x01;

        [NativeTypeName("#define SUBLANG_KASHMIRI_SASIA 0x02")]
        public const int SUBLANG_KASHMIRI_SASIA = 0x02;

        [NativeTypeName("#define SUBLANG_KASHMIRI_INDIA 0x02")]
        public const int SUBLANG_KASHMIRI_INDIA = 0x02;

        [NativeTypeName("#define SUBLANG_KAZAK_KAZAKHSTAN 0x01")]
        public const int SUBLANG_KAZAK_KAZAKHSTAN = 0x01;

        [NativeTypeName("#define SUBLANG_KHMER_CAMBODIA 0x01")]
        public const int SUBLANG_KHMER_CAMBODIA = 0x01;

        [NativeTypeName("#define SUBLANG_KICHE_GUATEMALA 0x01")]
        public const int SUBLANG_KICHE_GUATEMALA = 0x01;

        [NativeTypeName("#define SUBLANG_KINYARWANDA_RWANDA 0x01")]
        public const int SUBLANG_KINYARWANDA_RWANDA = 0x01;

        [NativeTypeName("#define SUBLANG_KONKANI_INDIA 0x01")]
        public const int SUBLANG_KONKANI_INDIA = 0x01;

        [NativeTypeName("#define SUBLANG_KOREAN 0x01")]
        public const int SUBLANG_KOREAN = 0x01;

        [NativeTypeName("#define SUBLANG_KYRGYZ_KYRGYZSTAN 0x01")]
        public const int SUBLANG_KYRGYZ_KYRGYZSTAN = 0x01;

        [NativeTypeName("#define SUBLANG_LAO_LAO 0x01")]
        public const int SUBLANG_LAO_LAO = 0x01;

        [NativeTypeName("#define SUBLANG_LATVIAN_LATVIA 0x01")]
        public const int SUBLANG_LATVIAN_LATVIA = 0x01;

        [NativeTypeName("#define SUBLANG_LITHUANIAN 0x01")]
        public const int SUBLANG_LITHUANIAN = 0x01;

        [NativeTypeName("#define SUBLANG_LOWER_SORBIAN_GERMANY 0x02")]
        public const int SUBLANG_LOWER_SORBIAN_GERMANY = 0x02;

        [NativeTypeName("#define SUBLANG_LUXEMBOURGISH_LUXEMBOURG 0x01")]
        public const int SUBLANG_LUXEMBOURGISH_LUXEMBOURG = 0x01;

        [NativeTypeName("#define SUBLANG_MACEDONIAN_MACEDONIA 0x01")]
        public const int SUBLANG_MACEDONIAN_MACEDONIA = 0x01;

        [NativeTypeName("#define SUBLANG_MALAY_MALAYSIA 0x01")]
        public const int SUBLANG_MALAY_MALAYSIA = 0x01;

        [NativeTypeName("#define SUBLANG_MALAY_BRUNEI_DARUSSALAM 0x02")]
        public const int SUBLANG_MALAY_BRUNEI_DARUSSALAM = 0x02;

        [NativeTypeName("#define SUBLANG_MALAYALAM_INDIA 0x01")]
        public const int SUBLANG_MALAYALAM_INDIA = 0x01;

        [NativeTypeName("#define SUBLANG_MALTESE_MALTA 0x01")]
        public const int SUBLANG_MALTESE_MALTA = 0x01;

        [NativeTypeName("#define SUBLANG_MAORI_NEW_ZEALAND 0x01")]
        public const int SUBLANG_MAORI_NEW_ZEALAND = 0x01;

        [NativeTypeName("#define SUBLANG_MAPUDUNGUN_CHILE 0x01")]
        public const int SUBLANG_MAPUDUNGUN_CHILE = 0x01;

        [NativeTypeName("#define SUBLANG_MARATHI_INDIA 0x01")]
        public const int SUBLANG_MARATHI_INDIA = 0x01;

        [NativeTypeName("#define SUBLANG_MOHAWK_MOHAWK 0x01")]
        public const int SUBLANG_MOHAWK_MOHAWK = 0x01;

        [NativeTypeName("#define SUBLANG_MONGOLIAN_CYRILLIC_MONGOLIA 0x01")]
        public const int SUBLANG_MONGOLIAN_CYRILLIC_MONGOLIA = 0x01;

        [NativeTypeName("#define SUBLANG_MONGOLIAN_PRC 0x02")]
        public const int SUBLANG_MONGOLIAN_PRC = 0x02;

        [NativeTypeName("#define SUBLANG_NEPALI_INDIA 0x02")]
        public const int SUBLANG_NEPALI_INDIA = 0x02;

        [NativeTypeName("#define SUBLANG_NEPALI_NEPAL 0x01")]
        public const int SUBLANG_NEPALI_NEPAL = 0x01;

        [NativeTypeName("#define SUBLANG_NORWEGIAN_BOKMAL 0x01")]
        public const int SUBLANG_NORWEGIAN_BOKMAL = 0x01;

        [NativeTypeName("#define SUBLANG_NORWEGIAN_NYNORSK 0x02")]
        public const int SUBLANG_NORWEGIAN_NYNORSK = 0x02;

        [NativeTypeName("#define SUBLANG_OCCITAN_FRANCE 0x01")]
        public const int SUBLANG_OCCITAN_FRANCE = 0x01;

        [NativeTypeName("#define SUBLANG_ODIA_INDIA 0x01")]
        public const int SUBLANG_ODIA_INDIA = 0x01;

        [NativeTypeName("#define SUBLANG_ORIYA_INDIA 0x01")]
        public const int SUBLANG_ORIYA_INDIA = 0x01;

        [NativeTypeName("#define SUBLANG_PASHTO_AFGHANISTAN 0x01")]
        public const int SUBLANG_PASHTO_AFGHANISTAN = 0x01;

        [NativeTypeName("#define SUBLANG_PERSIAN_IRAN 0x01")]
        public const int SUBLANG_PERSIAN_IRAN = 0x01;

        [NativeTypeName("#define SUBLANG_POLISH_POLAND 0x01")]
        public const int SUBLANG_POLISH_POLAND = 0x01;

        [NativeTypeName("#define SUBLANG_PORTUGUESE 0x02")]
        public const int SUBLANG_PORTUGUESE = 0x02;

        [NativeTypeName("#define SUBLANG_PORTUGUESE_BRAZILIAN 0x01")]
        public const int SUBLANG_PORTUGUESE_BRAZILIAN = 0x01;

        [NativeTypeName("#define SUBLANG_PULAR_SENEGAL 0x02")]
        public const int SUBLANG_PULAR_SENEGAL = 0x02;

        [NativeTypeName("#define SUBLANG_PUNJABI_INDIA 0x01")]
        public const int SUBLANG_PUNJABI_INDIA = 0x01;

        [NativeTypeName("#define SUBLANG_PUNJABI_PAKISTAN 0x02")]
        public const int SUBLANG_PUNJABI_PAKISTAN = 0x02;

        [NativeTypeName("#define SUBLANG_QUECHUA_BOLIVIA 0x01")]
        public const int SUBLANG_QUECHUA_BOLIVIA = 0x01;

        [NativeTypeName("#define SUBLANG_QUECHUA_ECUADOR 0x02")]
        public const int SUBLANG_QUECHUA_ECUADOR = 0x02;

        [NativeTypeName("#define SUBLANG_QUECHUA_PERU 0x03")]
        public const int SUBLANG_QUECHUA_PERU = 0x03;

        [NativeTypeName("#define SUBLANG_ROMANIAN_ROMANIA 0x01")]
        public const int SUBLANG_ROMANIAN_ROMANIA = 0x01;

        [NativeTypeName("#define SUBLANG_ROMANSH_SWITZERLAND 0x01")]
        public const int SUBLANG_ROMANSH_SWITZERLAND = 0x01;

        [NativeTypeName("#define SUBLANG_RUSSIAN_RUSSIA 0x01")]
        public const int SUBLANG_RUSSIAN_RUSSIA = 0x01;

        [NativeTypeName("#define SUBLANG_SAKHA_RUSSIA 0x01")]
        public const int SUBLANG_SAKHA_RUSSIA = 0x01;

        [NativeTypeName("#define SUBLANG_SAMI_NORTHERN_NORWAY 0x01")]
        public const int SUBLANG_SAMI_NORTHERN_NORWAY = 0x01;

        [NativeTypeName("#define SUBLANG_SAMI_NORTHERN_SWEDEN 0x02")]
        public const int SUBLANG_SAMI_NORTHERN_SWEDEN = 0x02;

        [NativeTypeName("#define SUBLANG_SAMI_NORTHERN_FINLAND 0x03")]
        public const int SUBLANG_SAMI_NORTHERN_FINLAND = 0x03;

        [NativeTypeName("#define SUBLANG_SAMI_LULE_NORWAY 0x04")]
        public const int SUBLANG_SAMI_LULE_NORWAY = 0x04;

        [NativeTypeName("#define SUBLANG_SAMI_LULE_SWEDEN 0x05")]
        public const int SUBLANG_SAMI_LULE_SWEDEN = 0x05;

        [NativeTypeName("#define SUBLANG_SAMI_SOUTHERN_NORWAY 0x06")]
        public const int SUBLANG_SAMI_SOUTHERN_NORWAY = 0x06;

        [NativeTypeName("#define SUBLANG_SAMI_SOUTHERN_SWEDEN 0x07")]
        public const int SUBLANG_SAMI_SOUTHERN_SWEDEN = 0x07;

        [NativeTypeName("#define SUBLANG_SAMI_SKOLT_FINLAND 0x08")]
        public const int SUBLANG_SAMI_SKOLT_FINLAND = 0x08;

        [NativeTypeName("#define SUBLANG_SAMI_INARI_FINLAND 0x09")]
        public const int SUBLANG_SAMI_INARI_FINLAND = 0x09;

        [NativeTypeName("#define SUBLANG_SANSKRIT_INDIA 0x01")]
        public const int SUBLANG_SANSKRIT_INDIA = 0x01;

        [NativeTypeName("#define SUBLANG_SCOTTISH_GAELIC 0x01")]
        public const int SUBLANG_SCOTTISH_GAELIC = 0x01;

        [NativeTypeName("#define SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_LATIN 0x06")]
        public const int SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_LATIN = 0x06;

        [NativeTypeName("#define SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_CYRILLIC 0x07")]
        public const int SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_CYRILLIC = 0x07;

        [NativeTypeName("#define SUBLANG_SERBIAN_MONTENEGRO_LATIN 0x0b")]
        public const int SUBLANG_SERBIAN_MONTENEGRO_LATIN = 0x0b;

        [NativeTypeName("#define SUBLANG_SERBIAN_MONTENEGRO_CYRILLIC 0x0c")]
        public const int SUBLANG_SERBIAN_MONTENEGRO_CYRILLIC = 0x0c;

        [NativeTypeName("#define SUBLANG_SERBIAN_SERBIA_LATIN 0x09")]
        public const int SUBLANG_SERBIAN_SERBIA_LATIN = 0x09;

        [NativeTypeName("#define SUBLANG_SERBIAN_SERBIA_CYRILLIC 0x0a")]
        public const int SUBLANG_SERBIAN_SERBIA_CYRILLIC = 0x0a;

        [NativeTypeName("#define SUBLANG_SERBIAN_CROATIA 0x01")]
        public const int SUBLANG_SERBIAN_CROATIA = 0x01;

        [NativeTypeName("#define SUBLANG_SERBIAN_LATIN 0x02")]
        public const int SUBLANG_SERBIAN_LATIN = 0x02;

        [NativeTypeName("#define SUBLANG_SERBIAN_CYRILLIC 0x03")]
        public const int SUBLANG_SERBIAN_CYRILLIC = 0x03;

        [NativeTypeName("#define SUBLANG_SINDHI_INDIA 0x01")]
        public const int SUBLANG_SINDHI_INDIA = 0x01;

        [NativeTypeName("#define SUBLANG_SINDHI_PAKISTAN 0x02")]
        public const int SUBLANG_SINDHI_PAKISTAN = 0x02;

        [NativeTypeName("#define SUBLANG_SINDHI_AFGHANISTAN 0x02")]
        public const int SUBLANG_SINDHI_AFGHANISTAN = 0x02;

        [NativeTypeName("#define SUBLANG_SINHALESE_SRI_LANKA 0x01")]
        public const int SUBLANG_SINHALESE_SRI_LANKA = 0x01;

        [NativeTypeName("#define SUBLANG_SOTHO_NORTHERN_SOUTH_AFRICA 0x01")]
        public const int SUBLANG_SOTHO_NORTHERN_SOUTH_AFRICA = 0x01;

        [NativeTypeName("#define SUBLANG_SLOVAK_SLOVAKIA 0x01")]
        public const int SUBLANG_SLOVAK_SLOVAKIA = 0x01;

        [NativeTypeName("#define SUBLANG_SLOVENIAN_SLOVENIA 0x01")]
        public const int SUBLANG_SLOVENIAN_SLOVENIA = 0x01;

        [NativeTypeName("#define SUBLANG_SPANISH 0x01")]
        public const int SUBLANG_SPANISH = 0x01;

        [NativeTypeName("#define SUBLANG_SPANISH_MEXICAN 0x02")]
        public const int SUBLANG_SPANISH_MEXICAN = 0x02;

        [NativeTypeName("#define SUBLANG_SPANISH_MODERN 0x03")]
        public const int SUBLANG_SPANISH_MODERN = 0x03;

        [NativeTypeName("#define SUBLANG_SPANISH_GUATEMALA 0x04")]
        public const int SUBLANG_SPANISH_GUATEMALA = 0x04;

        [NativeTypeName("#define SUBLANG_SPANISH_COSTA_RICA 0x05")]
        public const int SUBLANG_SPANISH_COSTA_RICA = 0x05;

        [NativeTypeName("#define SUBLANG_SPANISH_PANAMA 0x06")]
        public const int SUBLANG_SPANISH_PANAMA = 0x06;

        [NativeTypeName("#define SUBLANG_SPANISH_DOMINICAN_REPUBLIC 0x07")]
        public const int SUBLANG_SPANISH_DOMINICAN_REPUBLIC = 0x07;

        [NativeTypeName("#define SUBLANG_SPANISH_VENEZUELA 0x08")]
        public const int SUBLANG_SPANISH_VENEZUELA = 0x08;

        [NativeTypeName("#define SUBLANG_SPANISH_COLOMBIA 0x09")]
        public const int SUBLANG_SPANISH_COLOMBIA = 0x09;

        [NativeTypeName("#define SUBLANG_SPANISH_PERU 0x0a")]
        public const int SUBLANG_SPANISH_PERU = 0x0a;

        [NativeTypeName("#define SUBLANG_SPANISH_ARGENTINA 0x0b")]
        public const int SUBLANG_SPANISH_ARGENTINA = 0x0b;

        [NativeTypeName("#define SUBLANG_SPANISH_ECUADOR 0x0c")]
        public const int SUBLANG_SPANISH_ECUADOR = 0x0c;

        [NativeTypeName("#define SUBLANG_SPANISH_CHILE 0x0d")]
        public const int SUBLANG_SPANISH_CHILE = 0x0d;

        [NativeTypeName("#define SUBLANG_SPANISH_URUGUAY 0x0e")]
        public const int SUBLANG_SPANISH_URUGUAY = 0x0e;

        [NativeTypeName("#define SUBLANG_SPANISH_PARAGUAY 0x0f")]
        public const int SUBLANG_SPANISH_PARAGUAY = 0x0f;

        [NativeTypeName("#define SUBLANG_SPANISH_BOLIVIA 0x10")]
        public const int SUBLANG_SPANISH_BOLIVIA = 0x10;

        [NativeTypeName("#define SUBLANG_SPANISH_EL_SALVADOR 0x11")]
        public const int SUBLANG_SPANISH_EL_SALVADOR = 0x11;

        [NativeTypeName("#define SUBLANG_SPANISH_HONDURAS 0x12")]
        public const int SUBLANG_SPANISH_HONDURAS = 0x12;

        [NativeTypeName("#define SUBLANG_SPANISH_NICARAGUA 0x13")]
        public const int SUBLANG_SPANISH_NICARAGUA = 0x13;

        [NativeTypeName("#define SUBLANG_SPANISH_PUERTO_RICO 0x14")]
        public const int SUBLANG_SPANISH_PUERTO_RICO = 0x14;

        [NativeTypeName("#define SUBLANG_SPANISH_US 0x15")]
        public const int SUBLANG_SPANISH_US = 0x15;

        [NativeTypeName("#define SUBLANG_SWAHILI_KENYA 0x01")]
        public const int SUBLANG_SWAHILI_KENYA = 0x01;

        [NativeTypeName("#define SUBLANG_SWEDISH 0x01")]
        public const int SUBLANG_SWEDISH = 0x01;

        [NativeTypeName("#define SUBLANG_SWEDISH_FINLAND 0x02")]
        public const int SUBLANG_SWEDISH_FINLAND = 0x02;

        [NativeTypeName("#define SUBLANG_SYRIAC_SYRIA 0x01")]
        public const int SUBLANG_SYRIAC_SYRIA = 0x01;

        [NativeTypeName("#define SUBLANG_TAJIK_TAJIKISTAN 0x01")]
        public const int SUBLANG_TAJIK_TAJIKISTAN = 0x01;

        [NativeTypeName("#define SUBLANG_TAMAZIGHT_ALGERIA_LATIN 0x02")]
        public const int SUBLANG_TAMAZIGHT_ALGERIA_LATIN = 0x02;

        [NativeTypeName("#define SUBLANG_TAMAZIGHT_MOROCCO_TIFINAGH 0x04")]
        public const int SUBLANG_TAMAZIGHT_MOROCCO_TIFINAGH = 0x04;

        [NativeTypeName("#define SUBLANG_TAMIL_INDIA 0x01")]
        public const int SUBLANG_TAMIL_INDIA = 0x01;

        [NativeTypeName("#define SUBLANG_TAMIL_SRI_LANKA 0x02")]
        public const int SUBLANG_TAMIL_SRI_LANKA = 0x02;

        [NativeTypeName("#define SUBLANG_TATAR_RUSSIA 0x01")]
        public const int SUBLANG_TATAR_RUSSIA = 0x01;

        [NativeTypeName("#define SUBLANG_TELUGU_INDIA 0x01")]
        public const int SUBLANG_TELUGU_INDIA = 0x01;

        [NativeTypeName("#define SUBLANG_THAI_THAILAND 0x01")]
        public const int SUBLANG_THAI_THAILAND = 0x01;

        [NativeTypeName("#define SUBLANG_TIBETAN_PRC 0x01")]
        public const int SUBLANG_TIBETAN_PRC = 0x01;

        [NativeTypeName("#define SUBLANG_TIGRIGNA_ERITREA 0x02")]
        public const int SUBLANG_TIGRIGNA_ERITREA = 0x02;

        [NativeTypeName("#define SUBLANG_TIGRINYA_ERITREA 0x02")]
        public const int SUBLANG_TIGRINYA_ERITREA = 0x02;

        [NativeTypeName("#define SUBLANG_TIGRINYA_ETHIOPIA 0x01")]
        public const int SUBLANG_TIGRINYA_ETHIOPIA = 0x01;

        [NativeTypeName("#define SUBLANG_TSWANA_BOTSWANA 0x02")]
        public const int SUBLANG_TSWANA_BOTSWANA = 0x02;

        [NativeTypeName("#define SUBLANG_TSWANA_SOUTH_AFRICA 0x01")]
        public const int SUBLANG_TSWANA_SOUTH_AFRICA = 0x01;

        [NativeTypeName("#define SUBLANG_TURKISH_TURKEY 0x01")]
        public const int SUBLANG_TURKISH_TURKEY = 0x01;

        [NativeTypeName("#define SUBLANG_TURKMEN_TURKMENISTAN 0x01")]
        public const int SUBLANG_TURKMEN_TURKMENISTAN = 0x01;

        [NativeTypeName("#define SUBLANG_UIGHUR_PRC 0x01")]
        public const int SUBLANG_UIGHUR_PRC = 0x01;

        [NativeTypeName("#define SUBLANG_UKRAINIAN_UKRAINE 0x01")]
        public const int SUBLANG_UKRAINIAN_UKRAINE = 0x01;

        [NativeTypeName("#define SUBLANG_UPPER_SORBIAN_GERMANY 0x01")]
        public const int SUBLANG_UPPER_SORBIAN_GERMANY = 0x01;

        [NativeTypeName("#define SUBLANG_URDU_PAKISTAN 0x01")]
        public const int SUBLANG_URDU_PAKISTAN = 0x01;

        [NativeTypeName("#define SUBLANG_URDU_INDIA 0x02")]
        public const int SUBLANG_URDU_INDIA = 0x02;

        [NativeTypeName("#define SUBLANG_UZBEK_LATIN 0x01")]
        public const int SUBLANG_UZBEK_LATIN = 0x01;

        [NativeTypeName("#define SUBLANG_UZBEK_CYRILLIC 0x02")]
        public const int SUBLANG_UZBEK_CYRILLIC = 0x02;

        [NativeTypeName("#define SUBLANG_VALENCIAN_VALENCIA 0x02")]
        public const int SUBLANG_VALENCIAN_VALENCIA = 0x02;

        [NativeTypeName("#define SUBLANG_VIETNAMESE_VIETNAM 0x01")]
        public const int SUBLANG_VIETNAMESE_VIETNAM = 0x01;

        [NativeTypeName("#define SUBLANG_WELSH_UNITED_KINGDOM 0x01")]
        public const int SUBLANG_WELSH_UNITED_KINGDOM = 0x01;

        [NativeTypeName("#define SUBLANG_WOLOF_SENEGAL 0x01")]
        public const int SUBLANG_WOLOF_SENEGAL = 0x01;

        [NativeTypeName("#define SUBLANG_XHOSA_SOUTH_AFRICA 0x01")]
        public const int SUBLANG_XHOSA_SOUTH_AFRICA = 0x01;

        [NativeTypeName("#define SUBLANG_YAKUT_RUSSIA 0x01")]
        public const int SUBLANG_YAKUT_RUSSIA = 0x01;

        [NativeTypeName("#define SUBLANG_YI_PRC 0x01")]
        public const int SUBLANG_YI_PRC = 0x01;

        [NativeTypeName("#define SUBLANG_YORUBA_NIGERIA 0x01")]
        public const int SUBLANG_YORUBA_NIGERIA = 0x01;

        [NativeTypeName("#define SUBLANG_ZULU_SOUTH_AFRICA 0x01")]
        public const int SUBLANG_ZULU_SOUTH_AFRICA = 0x01;

        [NativeTypeName("#define SORT_DEFAULT 0x0")]
        public const int SORT_DEFAULT = 0x0;

        [NativeTypeName("#define SORT_INVARIANT_MATH 0x1")]
        public const int SORT_INVARIANT_MATH = 0x1;

        [NativeTypeName("#define SORT_JAPANESE_XJIS 0x0")]
        public const int SORT_JAPANESE_XJIS = 0x0;

        [NativeTypeName("#define SORT_JAPANESE_UNICODE 0x1")]
        public const int SORT_JAPANESE_UNICODE = 0x1;

        [NativeTypeName("#define SORT_JAPANESE_RADICALSTROKE 0x4")]
        public const int SORT_JAPANESE_RADICALSTROKE = 0x4;

        [NativeTypeName("#define SORT_CHINESE_BIG5 0x0")]
        public const int SORT_CHINESE_BIG5 = 0x0;

        [NativeTypeName("#define SORT_CHINESE_PRCP 0x0")]
        public const int SORT_CHINESE_PRCP = 0x0;

        [NativeTypeName("#define SORT_CHINESE_UNICODE 0x1")]
        public const int SORT_CHINESE_UNICODE = 0x1;

        [NativeTypeName("#define SORT_CHINESE_PRC 0x2")]
        public const int SORT_CHINESE_PRC = 0x2;

        [NativeTypeName("#define SORT_CHINESE_BOPOMOFO 0x3")]
        public const int SORT_CHINESE_BOPOMOFO = 0x3;

        [NativeTypeName("#define SORT_CHINESE_RADICALSTROKE 0x4")]
        public const int SORT_CHINESE_RADICALSTROKE = 0x4;

        [NativeTypeName("#define SORT_KOREAN_KSC 0x0")]
        public const int SORT_KOREAN_KSC = 0x0;

        [NativeTypeName("#define SORT_KOREAN_UNICODE 0x1")]
        public const int SORT_KOREAN_UNICODE = 0x1;

        [NativeTypeName("#define SORT_GERMAN_PHONE_BOOK 0x1")]
        public const int SORT_GERMAN_PHONE_BOOK = 0x1;

        [NativeTypeName("#define SORT_HUNGARIAN_DEFAULT 0x0")]
        public const int SORT_HUNGARIAN_DEFAULT = 0x0;

        [NativeTypeName("#define SORT_HUNGARIAN_TECHNICAL 0x1")]
        public const int SORT_HUNGARIAN_TECHNICAL = 0x1;

        [NativeTypeName("#define SORT_GEORGIAN_TRADITIONAL 0x0")]
        public const int SORT_GEORGIAN_TRADITIONAL = 0x0;

        [NativeTypeName("#define SORT_GEORGIAN_MODERN 0x1")]
        public const int SORT_GEORGIAN_MODERN = 0x1;

        [NativeTypeName("#define NLS_VALID_LOCALE_MASK 0x000fffff")]
        public const int NLS_VALID_LOCALE_MASK = 0x000fffff;

        [NativeTypeName("#define LOCALE_NAME_MAX_LENGTH 85")]
        public const int LOCALE_NAME_MAX_LENGTH = 85;

        [NativeTypeName("#define LANG_SYSTEM_DEFAULT (MAKELANGID(LANG_NEUTRAL, SUBLANG_SYS_DEFAULT))")]
        public const int LANG_SYSTEM_DEFAULT = unchecked(((((ushort)(0x02)) << 10) | (ushort)(0x00)));

        [NativeTypeName("#define LANG_USER_DEFAULT (MAKELANGID(LANG_NEUTRAL, SUBLANG_DEFAULT))")]
        public const int LANG_USER_DEFAULT = unchecked(((((ushort)(0x01)) << 10) | (ushort)(0x00)));

        [NativeTypeName("#define LOCALE_SYSTEM_DEFAULT (MAKELCID(LANG_SYSTEM_DEFAULT, SORT_DEFAULT))")]
        public const uint LOCALE_SYSTEM_DEFAULT = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)((((((ushort)(0x02)) << 10) | (ushort)(0x00)))))))));

        [NativeTypeName("#define LOCALE_USER_DEFAULT (MAKELCID(LANG_USER_DEFAULT, SORT_DEFAULT))")]
        public const uint LOCALE_USER_DEFAULT = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)((((((ushort)(0x01)) << 10) | (ushort)(0x00)))))))));

        [NativeTypeName("#define LOCALE_CUSTOM_DEFAULT (MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_CUSTOM_DEFAULT), SORT_DEFAULT))")]
        public const uint LOCALE_CUSTOM_DEFAULT = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(((((ushort)(0x03)) << 10) | (ushort)(0x00))))))));

        [NativeTypeName("#define LOCALE_CUSTOM_UNSPECIFIED (MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_CUSTOM_UNSPECIFIED), SORT_DEFAULT))")]
        public const uint LOCALE_CUSTOM_UNSPECIFIED = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(((((ushort)(0x04)) << 10) | (ushort)(0x00))))))));

        [NativeTypeName("#define LOCALE_CUSTOM_UI_DEFAULT (MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_UI_CUSTOM_DEFAULT), SORT_DEFAULT))")]
        public const uint LOCALE_CUSTOM_UI_DEFAULT = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(((((ushort)(0x05)) << 10) | (ushort)(0x00))))))));

        [NativeTypeName("#define LOCALE_NEUTRAL (MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_NEUTRAL), SORT_DEFAULT))")]
        public const uint LOCALE_NEUTRAL = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(((((ushort)(0x00)) << 10) | (ushort)(0x00))))))));

        [NativeTypeName("#define LOCALE_INVARIANT (MAKELCID(MAKELANGID(LANG_INVARIANT, SUBLANG_NEUTRAL), SORT_DEFAULT))")]
        public const uint LOCALE_INVARIANT = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(((((ushort)(0x00)) << 10) | (ushort)(0x7f))))))));

        [NativeTypeName("#define LOCALE_TRANSIENT_KEYBOARD1 0x2000")]
        public const int LOCALE_TRANSIENT_KEYBOARD1 = 0x2000;

        [NativeTypeName("#define LOCALE_TRANSIENT_KEYBOARD2 0x2400")]
        public const int LOCALE_TRANSIENT_KEYBOARD2 = 0x2400;

        [NativeTypeName("#define LOCALE_TRANSIENT_KEYBOARD3 0x2800")]
        public const int LOCALE_TRANSIENT_KEYBOARD3 = 0x2800;

        [NativeTypeName("#define LOCALE_TRANSIENT_KEYBOARD4 0x2c00")]
        public const int LOCALE_TRANSIENT_KEYBOARD4 = 0x2c00;

        [NativeTypeName("#define LOCALE_UNASSIGNED_LCID LOCALE_CUSTOM_UNSPECIFIED")]
        public const uint LOCALE_UNASSIGNED_LCID = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(((((ushort)(0x04)) << 10) | (ushort)(0x00))))))));

        [NativeTypeName("#define STATUS_WAIT_0 ((DWORD   )0x00000000L)")]
        public const uint STATUS_WAIT_0 = ((uint)(0x00000000));

        [NativeTypeName("#define STATUS_ABANDONED_WAIT_0 ((DWORD   )0x00000080L)")]
        public const uint STATUS_ABANDONED_WAIT_0 = ((uint)(0x00000080));

        [NativeTypeName("#define STATUS_USER_APC ((DWORD   )0x000000C0L)")]
        public const uint STATUS_USER_APC = ((uint)(0x000000C0));

        [NativeTypeName("#define STATUS_TIMEOUT ((DWORD   )0x00000102L)")]
        public const uint STATUS_TIMEOUT = ((uint)(0x00000102));

        [NativeTypeName("#define STATUS_PENDING ((DWORD   )0x00000103L)")]
        public const uint STATUS_PENDING = ((uint)(0x00000103));

        [NativeTypeName("#define DBG_EXCEPTION_HANDLED ((DWORD   )0x00010001L)")]
        public const uint DBG_EXCEPTION_HANDLED = ((uint)(0x00010001));

        [NativeTypeName("#define DBG_CONTINUE ((DWORD   )0x00010002L)")]
        public const uint DBG_CONTINUE = ((uint)(0x00010002));

        [NativeTypeName("#define STATUS_SEGMENT_NOTIFICATION ((DWORD   )0x40000005L)")]
        public const uint STATUS_SEGMENT_NOTIFICATION = ((uint)(0x40000005));

        [NativeTypeName("#define STATUS_FATAL_APP_EXIT ((DWORD   )0x40000015L)")]
        public const uint STATUS_FATAL_APP_EXIT = ((uint)(0x40000015));

        [NativeTypeName("#define DBG_REPLY_LATER ((DWORD   )0x40010001L)")]
        public const uint DBG_REPLY_LATER = ((uint)(0x40010001));

        [NativeTypeName("#define DBG_TERMINATE_THREAD ((DWORD   )0x40010003L)")]
        public const uint DBG_TERMINATE_THREAD = ((uint)(0x40010003));

        [NativeTypeName("#define DBG_TERMINATE_PROCESS ((DWORD   )0x40010004L)")]
        public const uint DBG_TERMINATE_PROCESS = ((uint)(0x40010004));

        [NativeTypeName("#define DBG_CONTROL_C ((DWORD   )0x40010005L)")]
        public const uint DBG_CONTROL_C = ((uint)(0x40010005));

        [NativeTypeName("#define DBG_PRINTEXCEPTION_C ((DWORD   )0x40010006L)")]
        public const uint DBG_PRINTEXCEPTION_C = ((uint)(0x40010006));

        [NativeTypeName("#define DBG_RIPEXCEPTION ((DWORD   )0x40010007L)")]
        public const uint DBG_RIPEXCEPTION = ((uint)(0x40010007));

        [NativeTypeName("#define DBG_CONTROL_BREAK ((DWORD   )0x40010008L)")]
        public const uint DBG_CONTROL_BREAK = ((uint)(0x40010008));

        [NativeTypeName("#define DBG_COMMAND_EXCEPTION ((DWORD   )0x40010009L)")]
        public const uint DBG_COMMAND_EXCEPTION = ((uint)(0x40010009));

        [NativeTypeName("#define DBG_PRINTEXCEPTION_WIDE_C ((DWORD   )0x4001000AL)")]
        public const uint DBG_PRINTEXCEPTION_WIDE_C = ((uint)(0x4001000A));

        [NativeTypeName("#define STATUS_GUARD_PAGE_VIOLATION ((DWORD   )0x80000001L)")]
        public const uint STATUS_GUARD_PAGE_VIOLATION = ((uint)(0x80000001));

        [NativeTypeName("#define STATUS_DATATYPE_MISALIGNMENT ((DWORD   )0x80000002L)")]
        public const uint STATUS_DATATYPE_MISALIGNMENT = ((uint)(0x80000002));

        [NativeTypeName("#define STATUS_BREAKPOINT ((DWORD   )0x80000003L)")]
        public const uint STATUS_BREAKPOINT = ((uint)(0x80000003));

        [NativeTypeName("#define STATUS_SINGLE_STEP ((DWORD   )0x80000004L)")]
        public const uint STATUS_SINGLE_STEP = ((uint)(0x80000004));

        [NativeTypeName("#define STATUS_LONGJUMP ((DWORD   )0x80000026L)")]
        public const uint STATUS_LONGJUMP = ((uint)(0x80000026));

        [NativeTypeName("#define STATUS_UNWIND_CONSOLIDATE ((DWORD   )0x80000029L)")]
        public const uint STATUS_UNWIND_CONSOLIDATE = ((uint)(0x80000029));

        [NativeTypeName("#define DBG_EXCEPTION_NOT_HANDLED ((DWORD   )0x80010001L)")]
        public const uint DBG_EXCEPTION_NOT_HANDLED = ((uint)(0x80010001));

        [NativeTypeName("#define STATUS_ACCESS_VIOLATION ((DWORD   )0xC0000005L)")]
        public const uint STATUS_ACCESS_VIOLATION = ((uint)(0xC0000005));

        [NativeTypeName("#define STATUS_IN_PAGE_ERROR ((DWORD   )0xC0000006L)")]
        public const uint STATUS_IN_PAGE_ERROR = ((uint)(0xC0000006));

        [NativeTypeName("#define STATUS_INVALID_HANDLE ((DWORD   )0xC0000008L)")]
        public const uint STATUS_INVALID_HANDLE = ((uint)(0xC0000008));

        [NativeTypeName("#define STATUS_INVALID_PARAMETER ((DWORD   )0xC000000DL)")]
        public const uint STATUS_INVALID_PARAMETER = ((uint)(0xC000000D));

        [NativeTypeName("#define STATUS_NO_MEMORY ((DWORD   )0xC0000017L)")]
        public const uint STATUS_NO_MEMORY = ((uint)(0xC0000017));

        [NativeTypeName("#define STATUS_ILLEGAL_INSTRUCTION ((DWORD   )0xC000001DL)")]
        public const uint STATUS_ILLEGAL_INSTRUCTION = ((uint)(0xC000001D));

        [NativeTypeName("#define STATUS_NONCONTINUABLE_EXCEPTION ((DWORD   )0xC0000025L)")]
        public const uint STATUS_NONCONTINUABLE_EXCEPTION = ((uint)(0xC0000025));

        [NativeTypeName("#define STATUS_INVALID_DISPOSITION ((DWORD   )0xC0000026L)")]
        public const uint STATUS_INVALID_DISPOSITION = ((uint)(0xC0000026));

        [NativeTypeName("#define STATUS_ARRAY_BOUNDS_EXCEEDED ((DWORD   )0xC000008CL)")]
        public const uint STATUS_ARRAY_BOUNDS_EXCEEDED = ((uint)(0xC000008C));

        [NativeTypeName("#define STATUS_FLOAT_DENORMAL_OPERAND ((DWORD   )0xC000008DL)")]
        public const uint STATUS_FLOAT_DENORMAL_OPERAND = ((uint)(0xC000008D));

        [NativeTypeName("#define STATUS_FLOAT_DIVIDE_BY_ZERO ((DWORD   )0xC000008EL)")]
        public const uint STATUS_FLOAT_DIVIDE_BY_ZERO = ((uint)(0xC000008E));

        [NativeTypeName("#define STATUS_FLOAT_INEXACT_RESULT ((DWORD   )0xC000008FL)")]
        public const uint STATUS_FLOAT_INEXACT_RESULT = ((uint)(0xC000008F));

        [NativeTypeName("#define STATUS_FLOAT_INVALID_OPERATION ((DWORD   )0xC0000090L)")]
        public const uint STATUS_FLOAT_INVALID_OPERATION = ((uint)(0xC0000090));

        [NativeTypeName("#define STATUS_FLOAT_OVERFLOW ((DWORD   )0xC0000091L)")]
        public const uint STATUS_FLOAT_OVERFLOW = ((uint)(0xC0000091));

        [NativeTypeName("#define STATUS_FLOAT_STACK_CHECK ((DWORD   )0xC0000092L)")]
        public const uint STATUS_FLOAT_STACK_CHECK = ((uint)(0xC0000092));

        [NativeTypeName("#define STATUS_FLOAT_UNDERFLOW ((DWORD   )0xC0000093L)")]
        public const uint STATUS_FLOAT_UNDERFLOW = ((uint)(0xC0000093));

        [NativeTypeName("#define STATUS_INTEGER_DIVIDE_BY_ZERO ((DWORD   )0xC0000094L)")]
        public const uint STATUS_INTEGER_DIVIDE_BY_ZERO = ((uint)(0xC0000094));

        [NativeTypeName("#define STATUS_INTEGER_OVERFLOW ((DWORD   )0xC0000095L)")]
        public const uint STATUS_INTEGER_OVERFLOW = ((uint)(0xC0000095));

        [NativeTypeName("#define STATUS_PRIVILEGED_INSTRUCTION ((DWORD   )0xC0000096L)")]
        public const uint STATUS_PRIVILEGED_INSTRUCTION = ((uint)(0xC0000096));

        [NativeTypeName("#define STATUS_STACK_OVERFLOW ((DWORD   )0xC00000FDL)")]
        public const uint STATUS_STACK_OVERFLOW = ((uint)(0xC00000FD));

        [NativeTypeName("#define STATUS_DLL_NOT_FOUND ((DWORD   )0xC0000135L)")]
        public const uint STATUS_DLL_NOT_FOUND = ((uint)(0xC0000135));

        [NativeTypeName("#define STATUS_ORDINAL_NOT_FOUND ((DWORD   )0xC0000138L)")]
        public const uint STATUS_ORDINAL_NOT_FOUND = ((uint)(0xC0000138));

        [NativeTypeName("#define STATUS_ENTRYPOINT_NOT_FOUND ((DWORD   )0xC0000139L)")]
        public const uint STATUS_ENTRYPOINT_NOT_FOUND = ((uint)(0xC0000139));

        [NativeTypeName("#define STATUS_CONTROL_C_EXIT ((DWORD   )0xC000013AL)")]
        public const uint STATUS_CONTROL_C_EXIT = ((uint)(0xC000013A));

        [NativeTypeName("#define STATUS_DLL_INIT_FAILED ((DWORD   )0xC0000142L)")]
        public const uint STATUS_DLL_INIT_FAILED = ((uint)(0xC0000142));

        [NativeTypeName("#define STATUS_CONTROL_STACK_VIOLATION ((DWORD   )0xC00001B2L)")]
        public const uint STATUS_CONTROL_STACK_VIOLATION = ((uint)(0xC00001B2));

        [NativeTypeName("#define STATUS_FLOAT_MULTIPLE_FAULTS ((DWORD   )0xC00002B4L)")]
        public const uint STATUS_FLOAT_MULTIPLE_FAULTS = ((uint)(0xC00002B4));

        [NativeTypeName("#define STATUS_FLOAT_MULTIPLE_TRAPS ((DWORD   )0xC00002B5L)")]
        public const uint STATUS_FLOAT_MULTIPLE_TRAPS = ((uint)(0xC00002B5));

        [NativeTypeName("#define STATUS_REG_NAT_CONSUMPTION ((DWORD   )0xC00002C9L)")]
        public const uint STATUS_REG_NAT_CONSUMPTION = ((uint)(0xC00002C9));

        [NativeTypeName("#define STATUS_HEAP_CORRUPTION ((DWORD   )0xC0000374L)")]
        public const uint STATUS_HEAP_CORRUPTION = ((uint)(0xC0000374));

        [NativeTypeName("#define STATUS_STACK_BUFFER_OVERRUN ((DWORD   )0xC0000409L)")]
        public const uint STATUS_STACK_BUFFER_OVERRUN = ((uint)(0xC0000409));

        [NativeTypeName("#define STATUS_INVALID_CRUNTIME_PARAMETER ((DWORD   )0xC0000417L)")]
        public const uint STATUS_INVALID_CRUNTIME_PARAMETER = ((uint)(0xC0000417));

        [NativeTypeName("#define STATUS_ASSERTION_FAILURE ((DWORD   )0xC0000420L)")]
        public const uint STATUS_ASSERTION_FAILURE = ((uint)(0xC0000420));

        [NativeTypeName("#define STATUS_ENCLAVE_VIOLATION ((DWORD   )0xC00004A2L)")]
        public const uint STATUS_ENCLAVE_VIOLATION = ((uint)(0xC00004A2));

        [NativeTypeName("#define STATUS_INTERRUPTED ((DWORD   )0xC0000515L)")]
        public const uint STATUS_INTERRUPTED = ((uint)(0xC0000515));

        [NativeTypeName("#define STATUS_THREAD_NOT_RUNNING ((DWORD   )0xC0000516L)")]
        public const uint STATUS_THREAD_NOT_RUNNING = ((uint)(0xC0000516));

        [NativeTypeName("#define STATUS_ALREADY_REGISTERED ((DWORD   )0xC0000718L)")]
        public const uint STATUS_ALREADY_REGISTERED = ((uint)(0xC0000718));

        [NativeTypeName("#define STATUS_SXS_EARLY_DEACTIVATION ((DWORD   )0xC015000FL)")]
        public const uint STATUS_SXS_EARLY_DEACTIVATION = ((uint)(0xC015000F));

        [NativeTypeName("#define STATUS_SXS_INVALID_DEACTIVATION ((DWORD   )0xC0150010L)")]
        public const uint STATUS_SXS_INVALID_DEACTIVATION = ((uint)(0xC0150010));

        [NativeTypeName("#define MAXIMUM_WAIT_OBJECTS 64")]
        public const int MAXIMUM_WAIT_OBJECTS = 64;

        [NativeTypeName("#define MAXIMUM_SUSPEND_COUNT MAXCHAR")]
        public const int MAXIMUM_SUSPEND_COUNT = 0x7f;

        [NativeTypeName("#define _MM_HINT_T0 1")]
        public const int _MM_HINT_T0 = 1;

        [NativeTypeName("#define _MM_HINT_T1 2")]
        public const int _MM_HINT_T1 = 2;

        [NativeTypeName("#define _MM_HINT_T2 3")]
        public const int _MM_HINT_T2 = 3;

        [NativeTypeName("#define _MM_HINT_NTA 0")]
        public const int _MM_HINT_NTA = 0;

        [NativeTypeName("#define PF_TEMPORAL_LEVEL_1 _MM_HINT_T0")]
        public const int PF_TEMPORAL_LEVEL_1 = 1;

        [NativeTypeName("#define PF_TEMPORAL_LEVEL_2 _MM_HINT_T1")]
        public const int PF_TEMPORAL_LEVEL_2 = 2;

        [NativeTypeName("#define PF_TEMPORAL_LEVEL_3 _MM_HINT_T2")]
        public const int PF_TEMPORAL_LEVEL_3 = 3;

        [NativeTypeName("#define PF_NON_TEMPORAL_LEVEL_ALL _MM_HINT_NTA")]
        public const int PF_NON_TEMPORAL_LEVEL_ALL = 0;

        [NativeTypeName("#define EXCEPTION_READ_FAULT 0")]
        public const int EXCEPTION_READ_FAULT = 0;

        [NativeTypeName("#define EXCEPTION_WRITE_FAULT 1")]
        public const int EXCEPTION_WRITE_FAULT = 1;

        [NativeTypeName("#define EXCEPTION_EXECUTE_FAULT 8")]
        public const int EXCEPTION_EXECUTE_FAULT = 8;

        [NativeTypeName("#define SIZE_OF_80387_REGISTERS 80")]
        public const int SIZE_OF_80387_REGISTERS = 80;

        [NativeTypeName("#define CONTEXT_i386 0x00010000L")]
        public const int CONTEXT_i386 = 0x00010000;

        [NativeTypeName("#define CONTEXT_i486 0x00010000L")]
        public const int CONTEXT_i486 = 0x00010000;

        [NativeTypeName("#define CONTEXT_CONTROL (CONTEXT_i386 | 0x00000001L)")]
        public const int CONTEXT_CONTROL = (0x00010000 | 0x00000001);

        [NativeTypeName("#define CONTEXT_INTEGER (CONTEXT_i386 | 0x00000002L)")]
        public const int CONTEXT_INTEGER = (0x00010000 | 0x00000002);

        [NativeTypeName("#define CONTEXT_SEGMENTS (CONTEXT_i386 | 0x00000004L)")]
        public const int CONTEXT_SEGMENTS = (0x00010000 | 0x00000004);

        [NativeTypeName("#define CONTEXT_FLOATING_POINT (CONTEXT_i386 | 0x00000008L)")]
        public const int CONTEXT_FLOATING_POINT = (0x00010000 | 0x00000008);

        [NativeTypeName("#define CONTEXT_DEBUG_REGISTERS (CONTEXT_i386 | 0x00000010L)")]
        public const int CONTEXT_DEBUG_REGISTERS = (0x00010000 | 0x00000010);

        [NativeTypeName("#define CONTEXT_EXTENDED_REGISTERS (CONTEXT_i386 | 0x00000020L)")]
        public const int CONTEXT_EXTENDED_REGISTERS = (0x00010000 | 0x00000020);

        [NativeTypeName("#define CONTEXT_FULL (CONTEXT_CONTROL | CONTEXT_INTEGER |\\\r\n                      CONTEXT_SEGMENTS)")]
        public const int CONTEXT_FULL = ((0x00010000 | 0x00000001) | (0x00010000 | 0x00000002) | (0x00010000 | 0x00000004));

        [NativeTypeName("#define CONTEXT_ALL (CONTEXT_CONTROL | CONTEXT_INTEGER | CONTEXT_SEGMENTS | \\\r\n                                 CONTEXT_FLOATING_POINT | CONTEXT_DEBUG_REGISTERS | \\\r\n                                 CONTEXT_EXTENDED_REGISTERS)")]
        public const int CONTEXT_ALL = ((0x00010000 | 0x00000001) | (0x00010000 | 0x00000002) | (0x00010000 | 0x00000004) | (0x00010000 | 0x00000008) | (0x00010000 | 0x00000010) | (0x00010000 | 0x00000020));

        [NativeTypeName("#define CONTEXT_XSTATE (CONTEXT_i386 | 0x00000040L)")]
        public const int CONTEXT_XSTATE = (0x00010000 | 0x00000040);

        [NativeTypeName("#define CONTEXT_EXCEPTION_ACTIVE 0x08000000L")]
        public const int CONTEXT_EXCEPTION_ACTIVE = 0x08000000;

        [NativeTypeName("#define CONTEXT_SERVICE_ACTIVE 0x10000000L")]
        public const int CONTEXT_SERVICE_ACTIVE = 0x10000000;

        [NativeTypeName("#define CONTEXT_EXCEPTION_REQUEST 0x40000000L")]
        public const int CONTEXT_EXCEPTION_REQUEST = 0x40000000;

        [NativeTypeName("#define CONTEXT_EXCEPTION_REPORTING 0x80000000L")]
        public const uint CONTEXT_EXCEPTION_REPORTING = 0x80000000;

        [NativeTypeName("#define MAXIMUM_SUPPORTED_EXTENSION 512")]
        public const int MAXIMUM_SUPPORTED_EXTENSION = 512;

        [NativeTypeName("#define WOW64_CONTEXT_i386 0x00010000")]
        public const int WOW64_CONTEXT_i386 = 0x00010000;

        [NativeTypeName("#define WOW64_CONTEXT_i486 0x00010000")]
        public const int WOW64_CONTEXT_i486 = 0x00010000;

        [NativeTypeName("#define WOW64_CONTEXT_CONTROL (WOW64_CONTEXT_i386 | 0x00000001L)")]
        public const int WOW64_CONTEXT_CONTROL = (0x00010000 | 0x00000001);

        [NativeTypeName("#define WOW64_CONTEXT_INTEGER (WOW64_CONTEXT_i386 | 0x00000002L)")]
        public const int WOW64_CONTEXT_INTEGER = (0x00010000 | 0x00000002);

        [NativeTypeName("#define WOW64_CONTEXT_SEGMENTS (WOW64_CONTEXT_i386 | 0x00000004L)")]
        public const int WOW64_CONTEXT_SEGMENTS = (0x00010000 | 0x00000004);

        [NativeTypeName("#define WOW64_CONTEXT_FLOATING_POINT (WOW64_CONTEXT_i386 | 0x00000008L)")]
        public const int WOW64_CONTEXT_FLOATING_POINT = (0x00010000 | 0x00000008);

        [NativeTypeName("#define WOW64_CONTEXT_DEBUG_REGISTERS (WOW64_CONTEXT_i386 | 0x00000010L)")]
        public const int WOW64_CONTEXT_DEBUG_REGISTERS = (0x00010000 | 0x00000010);

        [NativeTypeName("#define WOW64_CONTEXT_EXTENDED_REGISTERS (WOW64_CONTEXT_i386 | 0x00000020L)")]
        public const int WOW64_CONTEXT_EXTENDED_REGISTERS = (0x00010000 | 0x00000020);

        [NativeTypeName("#define WOW64_CONTEXT_FULL (WOW64_CONTEXT_CONTROL | WOW64_CONTEXT_INTEGER | WOW64_CONTEXT_SEGMENTS)")]
        public const int WOW64_CONTEXT_FULL = ((0x00010000 | 0x00000001) | (0x00010000 | 0x00000002) | (0x00010000 | 0x00000004));

        [NativeTypeName("#define WOW64_CONTEXT_ALL (WOW64_CONTEXT_CONTROL | WOW64_CONTEXT_INTEGER | WOW64_CONTEXT_SEGMENTS | \\\r\n                                 WOW64_CONTEXT_FLOATING_POINT | WOW64_CONTEXT_DEBUG_REGISTERS | \\\r\n                                 WOW64_CONTEXT_EXTENDED_REGISTERS)")]
        public const int WOW64_CONTEXT_ALL = ((0x00010000 | 0x00000001) | (0x00010000 | 0x00000002) | (0x00010000 | 0x00000004) | (0x00010000 | 0x00000008) | (0x00010000 | 0x00000010) | (0x00010000 | 0x00000020));

        [NativeTypeName("#define WOW64_CONTEXT_XSTATE (WOW64_CONTEXT_i386 | 0x00000040L)")]
        public const int WOW64_CONTEXT_XSTATE = (0x00010000 | 0x00000040);

        [NativeTypeName("#define WOW64_CONTEXT_EXCEPTION_ACTIVE 0x08000000")]
        public const int WOW64_CONTEXT_EXCEPTION_ACTIVE = 0x08000000;

        [NativeTypeName("#define WOW64_CONTEXT_SERVICE_ACTIVE 0x10000000")]
        public const int WOW64_CONTEXT_SERVICE_ACTIVE = 0x10000000;

        [NativeTypeName("#define WOW64_CONTEXT_EXCEPTION_REQUEST 0x40000000")]
        public const int WOW64_CONTEXT_EXCEPTION_REQUEST = 0x40000000;

        [NativeTypeName("#define WOW64_CONTEXT_EXCEPTION_REPORTING 0x80000000")]
        public const uint WOW64_CONTEXT_EXCEPTION_REPORTING = 0x80000000;

        [NativeTypeName("#define WOW64_SIZE_OF_80387_REGISTERS 80")]
        public const int WOW64_SIZE_OF_80387_REGISTERS = 80;

        [NativeTypeName("#define WOW64_MAXIMUM_SUPPORTED_EXTENSION 512")]
        public const int WOW64_MAXIMUM_SUPPORTED_EXTENSION = 512;

        [NativeTypeName("#define EXCEPTION_NONCONTINUABLE 0x1")]
        public const int EXCEPTION_NONCONTINUABLE = 0x1;

        [NativeTypeName("#define EXCEPTION_UNWINDING 0x2")]
        public const int EXCEPTION_UNWINDING = 0x2;

        [NativeTypeName("#define EXCEPTION_EXIT_UNWIND 0x4")]
        public const int EXCEPTION_EXIT_UNWIND = 0x4;

        [NativeTypeName("#define EXCEPTION_STACK_INVALID 0x8")]
        public const int EXCEPTION_STACK_INVALID = 0x8;

        [NativeTypeName("#define EXCEPTION_NESTED_CALL 0x10")]
        public const int EXCEPTION_NESTED_CALL = 0x10;

        [NativeTypeName("#define EXCEPTION_TARGET_UNWIND 0x20")]
        public const int EXCEPTION_TARGET_UNWIND = 0x20;

        [NativeTypeName("#define EXCEPTION_COLLIDED_UNWIND 0x40")]
        public const int EXCEPTION_COLLIDED_UNWIND = 0x40;

        [NativeTypeName("#define EXCEPTION_UNWIND (EXCEPTION_UNWINDING | EXCEPTION_EXIT_UNWIND | \\\r\n                          EXCEPTION_TARGET_UNWIND | EXCEPTION_COLLIDED_UNWIND)")]
        public const int EXCEPTION_UNWIND = (0x2 | 0x4 | 0x20 | 0x40);

        [NativeTypeName("#define EXCEPTION_MAXIMUM_PARAMETERS 15")]
        public const int EXCEPTION_MAXIMUM_PARAMETERS = 15;

        [NativeTypeName("#define DELETE (0x00010000L)")]
        public const int DELETE = (0x00010000);

        [NativeTypeName("#define READ_CONTROL (0x00020000L)")]
        public const int READ_CONTROL = (0x00020000);

        [NativeTypeName("#define WRITE_DAC (0x00040000L)")]
        public const int WRITE_DAC = (0x00040000);

        [NativeTypeName("#define WRITE_OWNER (0x00080000L)")]
        public const int WRITE_OWNER = (0x00080000);

        [NativeTypeName("#define SYNCHRONIZE (0x00100000L)")]
        public const int SYNCHRONIZE = (0x00100000);

        [NativeTypeName("#define STANDARD_RIGHTS_REQUIRED (0x000F0000L)")]
        public const int STANDARD_RIGHTS_REQUIRED = (0x000F0000);

        [NativeTypeName("#define STANDARD_RIGHTS_READ (READ_CONTROL)")]
        public const int STANDARD_RIGHTS_READ = ((0x00020000));

        [NativeTypeName("#define STANDARD_RIGHTS_WRITE (READ_CONTROL)")]
        public const int STANDARD_RIGHTS_WRITE = ((0x00020000));

        [NativeTypeName("#define STANDARD_RIGHTS_EXECUTE (READ_CONTROL)")]
        public const int STANDARD_RIGHTS_EXECUTE = ((0x00020000));

        [NativeTypeName("#define STANDARD_RIGHTS_ALL (0x001F0000L)")]
        public const int STANDARD_RIGHTS_ALL = (0x001F0000);

        [NativeTypeName("#define SPECIFIC_RIGHTS_ALL (0x0000FFFFL)")]
        public const int SPECIFIC_RIGHTS_ALL = (0x0000FFFF);

        [NativeTypeName("#define ACCESS_SYSTEM_SECURITY (0x01000000L)")]
        public const int ACCESS_SYSTEM_SECURITY = (0x01000000);

        [NativeTypeName("#define MAXIMUM_ALLOWED (0x02000000L)")]
        public const int MAXIMUM_ALLOWED = (0x02000000);

        [NativeTypeName("#define GENERIC_READ (0x80000000L)")]
        public const uint GENERIC_READ = (0x80000000);

        [NativeTypeName("#define GENERIC_WRITE (0x40000000L)")]
        public const int GENERIC_WRITE = (0x40000000);

        [NativeTypeName("#define GENERIC_EXECUTE (0x20000000L)")]
        public const int GENERIC_EXECUTE = (0x20000000);

        [NativeTypeName("#define GENERIC_ALL (0x10000000L)")]
        public const int GENERIC_ALL = (0x10000000);

        [NativeTypeName("#define SID_REVISION (1)")]
        public const int SID_REVISION = (1);

        [NativeTypeName("#define SID_MAX_SUB_AUTHORITIES (15)")]
        public const int SID_MAX_SUB_AUTHORITIES = (15);

        [NativeTypeName("#define SID_RECOMMENDED_SUB_AUTHORITIES (1)")]
        public const int SID_RECOMMENDED_SUB_AUTHORITIES = (1);

        [NativeTypeName("#define SECURITY_MAX_SID_SIZE (sizeof(SID) - sizeof(DWORD) + (SID_MAX_SUB_AUTHORITIES * sizeof(DWORD)))")]
        public const uint SECURITY_MAX_SID_SIZE = unchecked(12 - 4 + ((15) * 4));

        [NativeTypeName("#define SECURITY_MAX_SID_STRING_CHARACTERS (2 + 4 + 15 + (11 * SID_MAX_SUB_AUTHORITIES) + 1)")]
        public const int SECURITY_MAX_SID_STRING_CHARACTERS = (2 + 4 + 15 + (11 * (15)) + 1);

        [NativeTypeName("#define SID_HASH_SIZE 32")]
        public const int SID_HASH_SIZE = 32;

        [NativeTypeName("#define SECURITY_NULL_RID (0x00000000L)")]
        public const int SECURITY_NULL_RID = (0x00000000);

        [NativeTypeName("#define SECURITY_WORLD_RID (0x00000000L)")]
        public const int SECURITY_WORLD_RID = (0x00000000);

        [NativeTypeName("#define SECURITY_LOCAL_RID (0x00000000L)")]
        public const int SECURITY_LOCAL_RID = (0x00000000);

        [NativeTypeName("#define SECURITY_LOCAL_LOGON_RID (0x00000001L)")]
        public const int SECURITY_LOCAL_LOGON_RID = (0x00000001);

        [NativeTypeName("#define SECURITY_CREATOR_OWNER_RID (0x00000000L)")]
        public const int SECURITY_CREATOR_OWNER_RID = (0x00000000);

        [NativeTypeName("#define SECURITY_CREATOR_GROUP_RID (0x00000001L)")]
        public const int SECURITY_CREATOR_GROUP_RID = (0x00000001);

        [NativeTypeName("#define SECURITY_CREATOR_OWNER_SERVER_RID (0x00000002L)")]
        public const int SECURITY_CREATOR_OWNER_SERVER_RID = (0x00000002);

        [NativeTypeName("#define SECURITY_CREATOR_GROUP_SERVER_RID (0x00000003L)")]
        public const int SECURITY_CREATOR_GROUP_SERVER_RID = (0x00000003);

        [NativeTypeName("#define SECURITY_CREATOR_OWNER_RIGHTS_RID (0x00000004L)")]
        public const int SECURITY_CREATOR_OWNER_RIGHTS_RID = (0x00000004);

        [NativeTypeName("#define SECURITY_DIALUP_RID (0x00000001L)")]
        public const int SECURITY_DIALUP_RID = (0x00000001);

        [NativeTypeName("#define SECURITY_NETWORK_RID (0x00000002L)")]
        public const int SECURITY_NETWORK_RID = (0x00000002);

        [NativeTypeName("#define SECURITY_BATCH_RID (0x00000003L)")]
        public const int SECURITY_BATCH_RID = (0x00000003);

        [NativeTypeName("#define SECURITY_INTERACTIVE_RID (0x00000004L)")]
        public const int SECURITY_INTERACTIVE_RID = (0x00000004);

        [NativeTypeName("#define SECURITY_LOGON_IDS_RID (0x00000005L)")]
        public const int SECURITY_LOGON_IDS_RID = (0x00000005);

        [NativeTypeName("#define SECURITY_LOGON_IDS_RID_COUNT (3L)")]
        public const int SECURITY_LOGON_IDS_RID_COUNT = (3);

        [NativeTypeName("#define SECURITY_SERVICE_RID (0x00000006L)")]
        public const int SECURITY_SERVICE_RID = (0x00000006);

        [NativeTypeName("#define SECURITY_ANONYMOUS_LOGON_RID (0x00000007L)")]
        public const int SECURITY_ANONYMOUS_LOGON_RID = (0x00000007);

        [NativeTypeName("#define SECURITY_PROXY_RID (0x00000008L)")]
        public const int SECURITY_PROXY_RID = (0x00000008);

        [NativeTypeName("#define SECURITY_ENTERPRISE_CONTROLLERS_RID (0x00000009L)")]
        public const int SECURITY_ENTERPRISE_CONTROLLERS_RID = (0x00000009);

        [NativeTypeName("#define SECURITY_SERVER_LOGON_RID SECURITY_ENTERPRISE_CONTROLLERS_RID")]
        public const int SECURITY_SERVER_LOGON_RID = (0x00000009);

        [NativeTypeName("#define SECURITY_PRINCIPAL_SELF_RID (0x0000000AL)")]
        public const int SECURITY_PRINCIPAL_SELF_RID = (0x0000000A);

        [NativeTypeName("#define SECURITY_AUTHENTICATED_USER_RID (0x0000000BL)")]
        public const int SECURITY_AUTHENTICATED_USER_RID = (0x0000000B);

        [NativeTypeName("#define SECURITY_RESTRICTED_CODE_RID (0x0000000CL)")]
        public const int SECURITY_RESTRICTED_CODE_RID = (0x0000000C);

        [NativeTypeName("#define SECURITY_TERMINAL_SERVER_RID (0x0000000DL)")]
        public const int SECURITY_TERMINAL_SERVER_RID = (0x0000000D);

        [NativeTypeName("#define SECURITY_REMOTE_LOGON_RID (0x0000000EL)")]
        public const int SECURITY_REMOTE_LOGON_RID = (0x0000000E);

        [NativeTypeName("#define SECURITY_THIS_ORGANIZATION_RID (0x0000000FL)")]
        public const int SECURITY_THIS_ORGANIZATION_RID = (0x0000000F);

        [NativeTypeName("#define SECURITY_IUSER_RID (0x00000011L)")]
        public const int SECURITY_IUSER_RID = (0x00000011);

        [NativeTypeName("#define SECURITY_LOCAL_SYSTEM_RID (0x00000012L)")]
        public const int SECURITY_LOCAL_SYSTEM_RID = (0x00000012);

        [NativeTypeName("#define SECURITY_LOCAL_SERVICE_RID (0x00000013L)")]
        public const int SECURITY_LOCAL_SERVICE_RID = (0x00000013);

        [NativeTypeName("#define SECURITY_NETWORK_SERVICE_RID (0x00000014L)")]
        public const int SECURITY_NETWORK_SERVICE_RID = (0x00000014);

        [NativeTypeName("#define SECURITY_NT_NON_UNIQUE (0x00000015L)")]
        public const int SECURITY_NT_NON_UNIQUE = (0x00000015);

        [NativeTypeName("#define SECURITY_NT_NON_UNIQUE_SUB_AUTH_COUNT (3L)")]
        public const int SECURITY_NT_NON_UNIQUE_SUB_AUTH_COUNT = (3);

        [NativeTypeName("#define SECURITY_ENTERPRISE_READONLY_CONTROLLERS_RID (0x00000016L)")]
        public const int SECURITY_ENTERPRISE_READONLY_CONTROLLERS_RID = (0x00000016);

        [NativeTypeName("#define SECURITY_BUILTIN_DOMAIN_RID (0x00000020L)")]
        public const int SECURITY_BUILTIN_DOMAIN_RID = (0x00000020);

        [NativeTypeName("#define SECURITY_WRITE_RESTRICTED_CODE_RID (0x00000021L)")]
        public const int SECURITY_WRITE_RESTRICTED_CODE_RID = (0x00000021);

        [NativeTypeName("#define SECURITY_PACKAGE_BASE_RID (0x00000040L)")]
        public const int SECURITY_PACKAGE_BASE_RID = (0x00000040);

        [NativeTypeName("#define SECURITY_PACKAGE_RID_COUNT (2L)")]
        public const int SECURITY_PACKAGE_RID_COUNT = (2);

        [NativeTypeName("#define SECURITY_PACKAGE_NTLM_RID (0x0000000AL)")]
        public const int SECURITY_PACKAGE_NTLM_RID = (0x0000000A);

        [NativeTypeName("#define SECURITY_PACKAGE_SCHANNEL_RID (0x0000000EL)")]
        public const int SECURITY_PACKAGE_SCHANNEL_RID = (0x0000000E);

        [NativeTypeName("#define SECURITY_PACKAGE_DIGEST_RID (0x00000015L)")]
        public const int SECURITY_PACKAGE_DIGEST_RID = (0x00000015);

        [NativeTypeName("#define SECURITY_CRED_TYPE_BASE_RID (0x00000041L)")]
        public const int SECURITY_CRED_TYPE_BASE_RID = (0x00000041);

        [NativeTypeName("#define SECURITY_CRED_TYPE_RID_COUNT (2L)")]
        public const int SECURITY_CRED_TYPE_RID_COUNT = (2);

        [NativeTypeName("#define SECURITY_CRED_TYPE_THIS_ORG_CERT_RID (0x00000001L)")]
        public const int SECURITY_CRED_TYPE_THIS_ORG_CERT_RID = (0x00000001);

        [NativeTypeName("#define SECURITY_MIN_BASE_RID (0x00000050L)")]
        public const int SECURITY_MIN_BASE_RID = (0x00000050);

        [NativeTypeName("#define SECURITY_SERVICE_ID_BASE_RID (0x00000050L)")]
        public const int SECURITY_SERVICE_ID_BASE_RID = (0x00000050);

        [NativeTypeName("#define SECURITY_SERVICE_ID_RID_COUNT (6L)")]
        public const int SECURITY_SERVICE_ID_RID_COUNT = (6);

        [NativeTypeName("#define SECURITY_RESERVED_ID_BASE_RID (0x00000051L)")]
        public const int SECURITY_RESERVED_ID_BASE_RID = (0x00000051);

        [NativeTypeName("#define SECURITY_APPPOOL_ID_BASE_RID (0x00000052L)")]
        public const int SECURITY_APPPOOL_ID_BASE_RID = (0x00000052);

        [NativeTypeName("#define SECURITY_APPPOOL_ID_RID_COUNT (6L)")]
        public const int SECURITY_APPPOOL_ID_RID_COUNT = (6);

        [NativeTypeName("#define SECURITY_VIRTUALSERVER_ID_BASE_RID (0x00000053L)")]
        public const int SECURITY_VIRTUALSERVER_ID_BASE_RID = (0x00000053);

        [NativeTypeName("#define SECURITY_VIRTUALSERVER_ID_RID_COUNT (6L)")]
        public const int SECURITY_VIRTUALSERVER_ID_RID_COUNT = (6);

        [NativeTypeName("#define SECURITY_USERMODEDRIVERHOST_ID_BASE_RID (0x00000054L)")]
        public const int SECURITY_USERMODEDRIVERHOST_ID_BASE_RID = (0x00000054);

        [NativeTypeName("#define SECURITY_USERMODEDRIVERHOST_ID_RID_COUNT (6L)")]
        public const int SECURITY_USERMODEDRIVERHOST_ID_RID_COUNT = (6);

        [NativeTypeName("#define SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_BASE_RID (0x00000055L)")]
        public const int SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_BASE_RID = (0x00000055);

        [NativeTypeName("#define SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_RID_COUNT (6L)")]
        public const int SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_RID_COUNT = (6);

        [NativeTypeName("#define SECURITY_WMIHOST_ID_BASE_RID (0x00000056L)")]
        public const int SECURITY_WMIHOST_ID_BASE_RID = (0x00000056);

        [NativeTypeName("#define SECURITY_WMIHOST_ID_RID_COUNT (6L)")]
        public const int SECURITY_WMIHOST_ID_RID_COUNT = (6);

        [NativeTypeName("#define SECURITY_TASK_ID_BASE_RID (0x00000057L)")]
        public const int SECURITY_TASK_ID_BASE_RID = (0x00000057);

        [NativeTypeName("#define SECURITY_NFS_ID_BASE_RID (0x00000058L)")]
        public const int SECURITY_NFS_ID_BASE_RID = (0x00000058);

        [NativeTypeName("#define SECURITY_COM_ID_BASE_RID (0x00000059L)")]
        public const int SECURITY_COM_ID_BASE_RID = (0x00000059);

        [NativeTypeName("#define SECURITY_WINDOW_MANAGER_BASE_RID (0x0000005AL)")]
        public const int SECURITY_WINDOW_MANAGER_BASE_RID = (0x0000005A);

        [NativeTypeName("#define SECURITY_RDV_GFX_BASE_RID (0x0000005BL)")]
        public const int SECURITY_RDV_GFX_BASE_RID = (0x0000005B);

        [NativeTypeName("#define SECURITY_DASHOST_ID_BASE_RID (0x0000005CL)")]
        public const int SECURITY_DASHOST_ID_BASE_RID = (0x0000005C);

        [NativeTypeName("#define SECURITY_DASHOST_ID_RID_COUNT (6L)")]
        public const int SECURITY_DASHOST_ID_RID_COUNT = (6);

        [NativeTypeName("#define SECURITY_USERMANAGER_ID_BASE_RID (0x0000005DL)")]
        public const int SECURITY_USERMANAGER_ID_BASE_RID = (0x0000005D);

        [NativeTypeName("#define SECURITY_USERMANAGER_ID_RID_COUNT (6L)")]
        public const int SECURITY_USERMANAGER_ID_RID_COUNT = (6);

        [NativeTypeName("#define SECURITY_WINRM_ID_BASE_RID (0x0000005EL)")]
        public const int SECURITY_WINRM_ID_BASE_RID = (0x0000005E);

        [NativeTypeName("#define SECURITY_WINRM_ID_RID_COUNT (6L)")]
        public const int SECURITY_WINRM_ID_RID_COUNT = (6);

        [NativeTypeName("#define SECURITY_CCG_ID_BASE_RID (0x0000005FL)")]
        public const int SECURITY_CCG_ID_BASE_RID = (0x0000005F);

        [NativeTypeName("#define SECURITY_UMFD_BASE_RID (0x00000060L)")]
        public const int SECURITY_UMFD_BASE_RID = (0x00000060);

        [NativeTypeName("#define SECURITY_VIRTUALACCOUNT_ID_RID_COUNT (6L)")]
        public const int SECURITY_VIRTUALACCOUNT_ID_RID_COUNT = (6);

        [NativeTypeName("#define SECURITY_MAX_BASE_RID (0x0000006FL)")]
        public const int SECURITY_MAX_BASE_RID = (0x0000006F);

        [NativeTypeName("#define SECURITY_MAX_ALWAYS_FILTERED (0x000003E7L)")]
        public const int SECURITY_MAX_ALWAYS_FILTERED = (0x000003E7);

        [NativeTypeName("#define SECURITY_MIN_NEVER_FILTERED (0x000003E8L)")]
        public const int SECURITY_MIN_NEVER_FILTERED = (0x000003E8);

        [NativeTypeName("#define SECURITY_OTHER_ORGANIZATION_RID (0x000003E8L)")]
        public const int SECURITY_OTHER_ORGANIZATION_RID = (0x000003E8);

        [NativeTypeName("#define SECURITY_WINDOWSMOBILE_ID_BASE_RID (0x00000070L)")]
        public const int SECURITY_WINDOWSMOBILE_ID_BASE_RID = (0x00000070);

        [NativeTypeName("#define SECURITY_INSTALLER_GROUP_CAPABILITY_BASE (0x20)")]
        public const int SECURITY_INSTALLER_GROUP_CAPABILITY_BASE = (0x20);

        [NativeTypeName("#define SECURITY_INSTALLER_GROUP_CAPABILITY_RID_COUNT (9)")]
        public const int SECURITY_INSTALLER_GROUP_CAPABILITY_RID_COUNT = (9);

        [NativeTypeName("#define SECURITY_INSTALLER_CAPABILITY_RID_COUNT (10)")]
        public const int SECURITY_INSTALLER_CAPABILITY_RID_COUNT = (10);

        [NativeTypeName("#define SECURITY_LOCAL_ACCOUNT_RID (0x00000071L)")]
        public const int SECURITY_LOCAL_ACCOUNT_RID = (0x00000071);

        [NativeTypeName("#define SECURITY_LOCAL_ACCOUNT_AND_ADMIN_RID (0x00000072L)")]
        public const int SECURITY_LOCAL_ACCOUNT_AND_ADMIN_RID = (0x00000072);

        [NativeTypeName("#define DOMAIN_GROUP_RID_AUTHORIZATION_DATA_IS_COMPOUNDED (0x000001F0L)")]
        public const int DOMAIN_GROUP_RID_AUTHORIZATION_DATA_IS_COMPOUNDED = (0x000001F0);

        [NativeTypeName("#define DOMAIN_GROUP_RID_AUTHORIZATION_DATA_CONTAINS_CLAIMS (0x000001F1L)")]
        public const int DOMAIN_GROUP_RID_AUTHORIZATION_DATA_CONTAINS_CLAIMS = (0x000001F1);

        [NativeTypeName("#define DOMAIN_GROUP_RID_ENTERPRISE_READONLY_DOMAIN_CONTROLLERS (0x000001F2L)")]
        public const int DOMAIN_GROUP_RID_ENTERPRISE_READONLY_DOMAIN_CONTROLLERS = (0x000001F2);

        [NativeTypeName("#define FOREST_USER_RID_MAX (0x000001F3L)")]
        public const int FOREST_USER_RID_MAX = (0x000001F3);

        [NativeTypeName("#define DOMAIN_USER_RID_ADMIN (0x000001F4L)")]
        public const int DOMAIN_USER_RID_ADMIN = (0x000001F4);

        [NativeTypeName("#define DOMAIN_USER_RID_GUEST (0x000001F5L)")]
        public const int DOMAIN_USER_RID_GUEST = (0x000001F5);

        [NativeTypeName("#define DOMAIN_USER_RID_KRBTGT (0x000001F6L)")]
        public const int DOMAIN_USER_RID_KRBTGT = (0x000001F6);

        [NativeTypeName("#define DOMAIN_USER_RID_DEFAULT_ACCOUNT (0x000001F7L)")]
        public const int DOMAIN_USER_RID_DEFAULT_ACCOUNT = (0x000001F7);

        [NativeTypeName("#define DOMAIN_USER_RID_WDAG_ACCOUNT (0x000001F8L)")]
        public const int DOMAIN_USER_RID_WDAG_ACCOUNT = (0x000001F8);

        [NativeTypeName("#define DOMAIN_USER_RID_MAX (0x000003E7L)")]
        public const int DOMAIN_USER_RID_MAX = (0x000003E7);

        [NativeTypeName("#define DOMAIN_GROUP_RID_ADMINS (0x00000200L)")]
        public const int DOMAIN_GROUP_RID_ADMINS = (0x00000200);

        [NativeTypeName("#define DOMAIN_GROUP_RID_USERS (0x00000201L)")]
        public const int DOMAIN_GROUP_RID_USERS = (0x00000201);

        [NativeTypeName("#define DOMAIN_GROUP_RID_GUESTS (0x00000202L)")]
        public const int DOMAIN_GROUP_RID_GUESTS = (0x00000202);

        [NativeTypeName("#define DOMAIN_GROUP_RID_COMPUTERS (0x00000203L)")]
        public const int DOMAIN_GROUP_RID_COMPUTERS = (0x00000203);

        [NativeTypeName("#define DOMAIN_GROUP_RID_CONTROLLERS (0x00000204L)")]
        public const int DOMAIN_GROUP_RID_CONTROLLERS = (0x00000204);

        [NativeTypeName("#define DOMAIN_GROUP_RID_CERT_ADMINS (0x00000205L)")]
        public const int DOMAIN_GROUP_RID_CERT_ADMINS = (0x00000205);

        [NativeTypeName("#define DOMAIN_GROUP_RID_SCHEMA_ADMINS (0x00000206L)")]
        public const int DOMAIN_GROUP_RID_SCHEMA_ADMINS = (0x00000206);

        [NativeTypeName("#define DOMAIN_GROUP_RID_ENTERPRISE_ADMINS (0x00000207L)")]
        public const int DOMAIN_GROUP_RID_ENTERPRISE_ADMINS = (0x00000207);

        [NativeTypeName("#define DOMAIN_GROUP_RID_POLICY_ADMINS (0x00000208L)")]
        public const int DOMAIN_GROUP_RID_POLICY_ADMINS = (0x00000208);

        [NativeTypeName("#define DOMAIN_GROUP_RID_READONLY_CONTROLLERS (0x00000209L)")]
        public const int DOMAIN_GROUP_RID_READONLY_CONTROLLERS = (0x00000209);

        [NativeTypeName("#define DOMAIN_GROUP_RID_CLONEABLE_CONTROLLERS (0x0000020AL)")]
        public const int DOMAIN_GROUP_RID_CLONEABLE_CONTROLLERS = (0x0000020A);

        [NativeTypeName("#define DOMAIN_GROUP_RID_CDC_RESERVED (0x0000020CL)")]
        public const int DOMAIN_GROUP_RID_CDC_RESERVED = (0x0000020C);

        [NativeTypeName("#define DOMAIN_GROUP_RID_PROTECTED_USERS (0x0000020DL)")]
        public const int DOMAIN_GROUP_RID_PROTECTED_USERS = (0x0000020D);

        [NativeTypeName("#define DOMAIN_GROUP_RID_KEY_ADMINS (0x0000020EL)")]
        public const int DOMAIN_GROUP_RID_KEY_ADMINS = (0x0000020E);

        [NativeTypeName("#define DOMAIN_GROUP_RID_ENTERPRISE_KEY_ADMINS (0x0000020FL)")]
        public const int DOMAIN_GROUP_RID_ENTERPRISE_KEY_ADMINS = (0x0000020F);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_ADMINS (0x00000220L)")]
        public const int DOMAIN_ALIAS_RID_ADMINS = (0x00000220);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_USERS (0x00000221L)")]
        public const int DOMAIN_ALIAS_RID_USERS = (0x00000221);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_GUESTS (0x00000222L)")]
        public const int DOMAIN_ALIAS_RID_GUESTS = (0x00000222);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_POWER_USERS (0x00000223L)")]
        public const int DOMAIN_ALIAS_RID_POWER_USERS = (0x00000223);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_ACCOUNT_OPS (0x00000224L)")]
        public const int DOMAIN_ALIAS_RID_ACCOUNT_OPS = (0x00000224);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_SYSTEM_OPS (0x00000225L)")]
        public const int DOMAIN_ALIAS_RID_SYSTEM_OPS = (0x00000225);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_PRINT_OPS (0x00000226L)")]
        public const int DOMAIN_ALIAS_RID_PRINT_OPS = (0x00000226);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_BACKUP_OPS (0x00000227L)")]
        public const int DOMAIN_ALIAS_RID_BACKUP_OPS = (0x00000227);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_REPLICATOR (0x00000228L)")]
        public const int DOMAIN_ALIAS_RID_REPLICATOR = (0x00000228);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_RAS_SERVERS (0x00000229L)")]
        public const int DOMAIN_ALIAS_RID_RAS_SERVERS = (0x00000229);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_PREW2KCOMPACCESS (0x0000022AL)")]
        public const int DOMAIN_ALIAS_RID_PREW2KCOMPACCESS = (0x0000022A);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_REMOTE_DESKTOP_USERS (0x0000022BL)")]
        public const int DOMAIN_ALIAS_RID_REMOTE_DESKTOP_USERS = (0x0000022B);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_NETWORK_CONFIGURATION_OPS (0x0000022CL)")]
        public const int DOMAIN_ALIAS_RID_NETWORK_CONFIGURATION_OPS = (0x0000022C);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_INCOMING_FOREST_TRUST_BUILDERS (0x0000022DL)")]
        public const int DOMAIN_ALIAS_RID_INCOMING_FOREST_TRUST_BUILDERS = (0x0000022D);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_MONITORING_USERS (0x0000022EL)")]
        public const int DOMAIN_ALIAS_RID_MONITORING_USERS = (0x0000022E);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_LOGGING_USERS (0x0000022FL)")]
        public const int DOMAIN_ALIAS_RID_LOGGING_USERS = (0x0000022F);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_AUTHORIZATIONACCESS (0x00000230L)")]
        public const int DOMAIN_ALIAS_RID_AUTHORIZATIONACCESS = (0x00000230);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_TS_LICENSE_SERVERS (0x00000231L)")]
        public const int DOMAIN_ALIAS_RID_TS_LICENSE_SERVERS = (0x00000231);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_DCOM_USERS (0x00000232L)")]
        public const int DOMAIN_ALIAS_RID_DCOM_USERS = (0x00000232);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_IUSERS (0x00000238L)")]
        public const int DOMAIN_ALIAS_RID_IUSERS = (0x00000238);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_CRYPTO_OPERATORS (0x00000239L)")]
        public const int DOMAIN_ALIAS_RID_CRYPTO_OPERATORS = (0x00000239);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_CACHEABLE_PRINCIPALS_GROUP (0x0000023BL)")]
        public const int DOMAIN_ALIAS_RID_CACHEABLE_PRINCIPALS_GROUP = (0x0000023B);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_NON_CACHEABLE_PRINCIPALS_GROUP (0x0000023CL)")]
        public const int DOMAIN_ALIAS_RID_NON_CACHEABLE_PRINCIPALS_GROUP = (0x0000023C);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_EVENT_LOG_READERS_GROUP (0x0000023DL)")]
        public const int DOMAIN_ALIAS_RID_EVENT_LOG_READERS_GROUP = (0x0000023D);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_CERTSVC_DCOM_ACCESS_GROUP (0x0000023EL)")]
        public const int DOMAIN_ALIAS_RID_CERTSVC_DCOM_ACCESS_GROUP = (0x0000023E);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_RDS_REMOTE_ACCESS_SERVERS (0x0000023FL)")]
        public const int DOMAIN_ALIAS_RID_RDS_REMOTE_ACCESS_SERVERS = (0x0000023F);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_RDS_ENDPOINT_SERVERS (0x00000240L)")]
        public const int DOMAIN_ALIAS_RID_RDS_ENDPOINT_SERVERS = (0x00000240);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_RDS_MANAGEMENT_SERVERS (0x00000241L)")]
        public const int DOMAIN_ALIAS_RID_RDS_MANAGEMENT_SERVERS = (0x00000241);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_HYPER_V_ADMINS (0x00000242L)")]
        public const int DOMAIN_ALIAS_RID_HYPER_V_ADMINS = (0x00000242);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_ACCESS_CONTROL_ASSISTANCE_OPS (0x00000243L)")]
        public const int DOMAIN_ALIAS_RID_ACCESS_CONTROL_ASSISTANCE_OPS = (0x00000243);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_REMOTE_MANAGEMENT_USERS (0x00000244L)")]
        public const int DOMAIN_ALIAS_RID_REMOTE_MANAGEMENT_USERS = (0x00000244);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_DEFAULT_ACCOUNT (0x00000245L)")]
        public const int DOMAIN_ALIAS_RID_DEFAULT_ACCOUNT = (0x00000245);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_STORAGE_REPLICA_ADMINS (0x00000246L)")]
        public const int DOMAIN_ALIAS_RID_STORAGE_REPLICA_ADMINS = (0x00000246);

        [NativeTypeName("#define DOMAIN_ALIAS_RID_DEVICE_OWNERS (0x00000247L)")]
        public const int DOMAIN_ALIAS_RID_DEVICE_OWNERS = (0x00000247);

        [NativeTypeName("#define SECURITY_APP_PACKAGE_BASE_RID (0x00000002L)")]
        public const int SECURITY_APP_PACKAGE_BASE_RID = (0x00000002);

        [NativeTypeName("#define SECURITY_BUILTIN_APP_PACKAGE_RID_COUNT (2L)")]
        public const int SECURITY_BUILTIN_APP_PACKAGE_RID_COUNT = (2);

        [NativeTypeName("#define SECURITY_APP_PACKAGE_RID_COUNT (8L)")]
        public const int SECURITY_APP_PACKAGE_RID_COUNT = (8);

        [NativeTypeName("#define SECURITY_CAPABILITY_BASE_RID (0x00000003L)")]
        public const int SECURITY_CAPABILITY_BASE_RID = (0x00000003);

        [NativeTypeName("#define SECURITY_CAPABILITY_APP_RID (0x000000400)")]
        public const int SECURITY_CAPABILITY_APP_RID = (0x000000400);

        [NativeTypeName("#define SECURITY_BUILTIN_CAPABILITY_RID_COUNT (2L)")]
        public const int SECURITY_BUILTIN_CAPABILITY_RID_COUNT = (2);

        [NativeTypeName("#define SECURITY_CAPABILITY_RID_COUNT (5L)")]
        public const int SECURITY_CAPABILITY_RID_COUNT = (5);

        [NativeTypeName("#define SECURITY_PARENT_PACKAGE_RID_COUNT (SECURITY_APP_PACKAGE_RID_COUNT)")]
        public const int SECURITY_PARENT_PACKAGE_RID_COUNT = ((8));

        [NativeTypeName("#define SECURITY_CHILD_PACKAGE_RID_COUNT (12L)")]
        public const int SECURITY_CHILD_PACKAGE_RID_COUNT = (12);

        [NativeTypeName("#define SECURITY_BUILTIN_PACKAGE_ANY_PACKAGE (0x00000001L)")]
        public const int SECURITY_BUILTIN_PACKAGE_ANY_PACKAGE = (0x00000001);

        [NativeTypeName("#define SECURITY_BUILTIN_PACKAGE_ANY_RESTRICTED_PACKAGE (0x00000002L)")]
        public const int SECURITY_BUILTIN_PACKAGE_ANY_RESTRICTED_PACKAGE = (0x00000002);

        [NativeTypeName("#define SECURITY_CAPABILITY_INTERNET_CLIENT (0x00000001L)")]
        public const int SECURITY_CAPABILITY_INTERNET_CLIENT = (0x00000001);

        [NativeTypeName("#define SECURITY_CAPABILITY_INTERNET_CLIENT_SERVER (0x00000002L)")]
        public const int SECURITY_CAPABILITY_INTERNET_CLIENT_SERVER = (0x00000002);

        [NativeTypeName("#define SECURITY_CAPABILITY_PRIVATE_NETWORK_CLIENT_SERVER (0x00000003L)")]
        public const int SECURITY_CAPABILITY_PRIVATE_NETWORK_CLIENT_SERVER = (0x00000003);

        [NativeTypeName("#define SECURITY_CAPABILITY_PICTURES_LIBRARY (0x00000004L)")]
        public const int SECURITY_CAPABILITY_PICTURES_LIBRARY = (0x00000004);

        [NativeTypeName("#define SECURITY_CAPABILITY_VIDEOS_LIBRARY (0x00000005L)")]
        public const int SECURITY_CAPABILITY_VIDEOS_LIBRARY = (0x00000005);

        [NativeTypeName("#define SECURITY_CAPABILITY_MUSIC_LIBRARY (0x00000006L)")]
        public const int SECURITY_CAPABILITY_MUSIC_LIBRARY = (0x00000006);

        [NativeTypeName("#define SECURITY_CAPABILITY_DOCUMENTS_LIBRARY (0x00000007L)")]
        public const int SECURITY_CAPABILITY_DOCUMENTS_LIBRARY = (0x00000007);

        [NativeTypeName("#define SECURITY_CAPABILITY_ENTERPRISE_AUTHENTICATION (0x00000008L)")]
        public const int SECURITY_CAPABILITY_ENTERPRISE_AUTHENTICATION = (0x00000008);

        [NativeTypeName("#define SECURITY_CAPABILITY_SHARED_USER_CERTIFICATES (0x00000009L)")]
        public const int SECURITY_CAPABILITY_SHARED_USER_CERTIFICATES = (0x00000009);

        [NativeTypeName("#define SECURITY_CAPABILITY_REMOVABLE_STORAGE (0x0000000AL)")]
        public const int SECURITY_CAPABILITY_REMOVABLE_STORAGE = (0x0000000A);

        [NativeTypeName("#define SECURITY_CAPABILITY_APPOINTMENTS (0x0000000BL)")]
        public const int SECURITY_CAPABILITY_APPOINTMENTS = (0x0000000B);

        [NativeTypeName("#define SECURITY_CAPABILITY_CONTACTS (0x0000000CL)")]
        public const int SECURITY_CAPABILITY_CONTACTS = (0x0000000C);

        [NativeTypeName("#define SECURITY_CAPABILITY_INTERNET_EXPLORER (0x00001000L)")]
        public const int SECURITY_CAPABILITY_INTERNET_EXPLORER = (0x00001000);

        [NativeTypeName("#define SECURITY_MANDATORY_UNTRUSTED_RID (0x00000000L)")]
        public const int SECURITY_MANDATORY_UNTRUSTED_RID = (0x00000000);

        [NativeTypeName("#define SECURITY_MANDATORY_LOW_RID (0x00001000L)")]
        public const int SECURITY_MANDATORY_LOW_RID = (0x00001000);

        [NativeTypeName("#define SECURITY_MANDATORY_MEDIUM_RID (0x00002000L)")]
        public const int SECURITY_MANDATORY_MEDIUM_RID = (0x00002000);

        [NativeTypeName("#define SECURITY_MANDATORY_MEDIUM_PLUS_RID (SECURITY_MANDATORY_MEDIUM_RID + 0x100)")]
        public const int SECURITY_MANDATORY_MEDIUM_PLUS_RID = ((0x00002000) + 0x100);

        [NativeTypeName("#define SECURITY_MANDATORY_HIGH_RID (0x00003000L)")]
        public const int SECURITY_MANDATORY_HIGH_RID = (0x00003000);

        [NativeTypeName("#define SECURITY_MANDATORY_SYSTEM_RID (0x00004000L)")]
        public const int SECURITY_MANDATORY_SYSTEM_RID = (0x00004000);

        [NativeTypeName("#define SECURITY_MANDATORY_PROTECTED_PROCESS_RID (0x00005000L)")]
        public const int SECURITY_MANDATORY_PROTECTED_PROCESS_RID = (0x00005000);

        [NativeTypeName("#define SECURITY_MANDATORY_MAXIMUM_USER_RID SECURITY_MANDATORY_SYSTEM_RID")]
        public const int SECURITY_MANDATORY_MAXIMUM_USER_RID = (0x00004000);

        [NativeTypeName("#define SECURITY_AUTHENTICATION_AUTHORITY_RID_COUNT (1L)")]
        public const int SECURITY_AUTHENTICATION_AUTHORITY_RID_COUNT = (1);

        [NativeTypeName("#define SECURITY_AUTHENTICATION_AUTHORITY_ASSERTED_RID (0x00000001L)")]
        public const int SECURITY_AUTHENTICATION_AUTHORITY_ASSERTED_RID = (0x00000001);

        [NativeTypeName("#define SECURITY_AUTHENTICATION_SERVICE_ASSERTED_RID (0x00000002L)")]
        public const int SECURITY_AUTHENTICATION_SERVICE_ASSERTED_RID = (0x00000002);

        [NativeTypeName("#define SECURITY_AUTHENTICATION_FRESH_KEY_AUTH_RID (0x00000003L)")]
        public const int SECURITY_AUTHENTICATION_FRESH_KEY_AUTH_RID = (0x00000003);

        [NativeTypeName("#define SECURITY_AUTHENTICATION_KEY_TRUST_RID (0x00000004L)")]
        public const int SECURITY_AUTHENTICATION_KEY_TRUST_RID = (0x00000004);

        [NativeTypeName("#define SECURITY_AUTHENTICATION_KEY_PROPERTY_MFA_RID (0x00000005L)")]
        public const int SECURITY_AUTHENTICATION_KEY_PROPERTY_MFA_RID = (0x00000005);

        [NativeTypeName("#define SECURITY_AUTHENTICATION_KEY_PROPERTY_ATTESTATION_RID (0x00000006L)")]
        public const int SECURITY_AUTHENTICATION_KEY_PROPERTY_ATTESTATION_RID = (0x00000006);

        [NativeTypeName("#define SECURITY_PROCESS_TRUST_AUTHORITY_RID_COUNT (2L)")]
        public const int SECURITY_PROCESS_TRUST_AUTHORITY_RID_COUNT = (2);

        [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_TYPE_FULL_RID (0x00000400L)")]
        public const int SECURITY_PROCESS_PROTECTION_TYPE_FULL_RID = (0x00000400);

        [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_TYPE_LITE_RID (0x00000200L)")]
        public const int SECURITY_PROCESS_PROTECTION_TYPE_LITE_RID = (0x00000200);

        [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_TYPE_NONE_RID (0x00000000L)")]
        public const int SECURITY_PROCESS_PROTECTION_TYPE_NONE_RID = (0x00000000);

        [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_LEVEL_WINTCB_RID (0x00002000L)")]
        public const int SECURITY_PROCESS_PROTECTION_LEVEL_WINTCB_RID = (0x00002000);

        [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_LEVEL_WINDOWS_RID (0x00001000L)")]
        public const int SECURITY_PROCESS_PROTECTION_LEVEL_WINDOWS_RID = (0x00001000);

        [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_LEVEL_APP_RID (0x00000800L)")]
        public const int SECURITY_PROCESS_PROTECTION_LEVEL_APP_RID = (0x00000800);

        [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_LEVEL_ANTIMALWARE_RID (0x00000600L)")]
        public const int SECURITY_PROCESS_PROTECTION_LEVEL_ANTIMALWARE_RID = (0x00000600);

        [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_LEVEL_AUTHENTICODE_RID (0x00000400L)")]
        public const int SECURITY_PROCESS_PROTECTION_LEVEL_AUTHENTICODE_RID = (0x00000400);

        [NativeTypeName("#define SECURITY_PROCESS_PROTECTION_LEVEL_NONE_RID (0x00000000L)")]
        public const int SECURITY_PROCESS_PROTECTION_LEVEL_NONE_RID = (0x00000000);

        [NativeTypeName("#define SECURITY_TRUSTED_INSTALLER_RID1 956008885")]
        public const int SECURITY_TRUSTED_INSTALLER_RID1 = 956008885;

        [NativeTypeName("#define SECURITY_TRUSTED_INSTALLER_RID2 3418522649")]
        public const long SECURITY_TRUSTED_INSTALLER_RID2 = 3418522649;

        [NativeTypeName("#define SECURITY_TRUSTED_INSTALLER_RID3 1831038044")]
        public const int SECURITY_TRUSTED_INSTALLER_RID3 = 1831038044;

        [NativeTypeName("#define SECURITY_TRUSTED_INSTALLER_RID4 1853292631")]
        public const int SECURITY_TRUSTED_INSTALLER_RID4 = 1853292631;

        [NativeTypeName("#define SECURITY_TRUSTED_INSTALLER_RID5 2271478464")]
        public const long SECURITY_TRUSTED_INSTALLER_RID5 = 2271478464;

        [NativeTypeName("#define SE_GROUP_MANDATORY (0x00000001L)")]
        public const int SE_GROUP_MANDATORY = (0x00000001);

        [NativeTypeName("#define SE_GROUP_ENABLED_BY_DEFAULT (0x00000002L)")]
        public const int SE_GROUP_ENABLED_BY_DEFAULT = (0x00000002);

        [NativeTypeName("#define SE_GROUP_ENABLED (0x00000004L)")]
        public const int SE_GROUP_ENABLED = (0x00000004);

        [NativeTypeName("#define SE_GROUP_OWNER (0x00000008L)")]
        public const int SE_GROUP_OWNER = (0x00000008);

        [NativeTypeName("#define SE_GROUP_USE_FOR_DENY_ONLY (0x00000010L)")]
        public const int SE_GROUP_USE_FOR_DENY_ONLY = (0x00000010);

        [NativeTypeName("#define SE_GROUP_INTEGRITY (0x00000020L)")]
        public const int SE_GROUP_INTEGRITY = (0x00000020);

        [NativeTypeName("#define SE_GROUP_INTEGRITY_ENABLED (0x00000040L)")]
        public const int SE_GROUP_INTEGRITY_ENABLED = (0x00000040);

        [NativeTypeName("#define SE_GROUP_LOGON_ID (0xC0000000L)")]
        public const uint SE_GROUP_LOGON_ID = (0xC0000000);

        [NativeTypeName("#define SE_GROUP_RESOURCE (0x20000000L)")]
        public const int SE_GROUP_RESOURCE = (0x20000000);

        [NativeTypeName("#define SE_GROUP_VALID_ATTRIBUTES (SE_GROUP_MANDATORY          | \\\r\n                                            SE_GROUP_ENABLED_BY_DEFAULT | \\\r\n                                            SE_GROUP_ENABLED            | \\\r\n                                            SE_GROUP_OWNER              | \\\r\n                                            SE_GROUP_USE_FOR_DENY_ONLY  | \\\r\n                                            SE_GROUP_LOGON_ID           | \\\r\n                                            SE_GROUP_RESOURCE           | \\\r\n                                            SE_GROUP_INTEGRITY          | \\\r\n                                            SE_GROUP_INTEGRITY_ENABLED)")]
        public const uint SE_GROUP_VALID_ATTRIBUTES = ((0x00000001) | (0x00000002) | (0x00000004) | (0x00000008) | (0x00000010) | (0xC0000000) | (0x20000000) | (0x00000020) | (0x00000040));

        [NativeTypeName("#define ACL_REVISION (2)")]
        public const int ACL_REVISION = (2);

        [NativeTypeName("#define ACL_REVISION_DS (4)")]
        public const int ACL_REVISION_DS = (4);

        [NativeTypeName("#define ACL_REVISION1 (1)")]
        public const int ACL_REVISION1 = (1);

        [NativeTypeName("#define MIN_ACL_REVISION ACL_REVISION2")]
        public const int MIN_ACL_REVISION = (2);

        [NativeTypeName("#define ACL_REVISION2 (2)")]
        public const int ACL_REVISION2 = (2);

        [NativeTypeName("#define ACL_REVISION3 (3)")]
        public const int ACL_REVISION3 = (3);

        [NativeTypeName("#define ACL_REVISION4 (4)")]
        public const int ACL_REVISION4 = (4);

        [NativeTypeName("#define MAX_ACL_REVISION ACL_REVISION4")]
        public const int MAX_ACL_REVISION = (4);

        [NativeTypeName("#define ACCESS_MIN_MS_ACE_TYPE (0x0)")]
        public const int ACCESS_MIN_MS_ACE_TYPE = (0x0);

        [NativeTypeName("#define ACCESS_ALLOWED_ACE_TYPE (0x0)")]
        public const int ACCESS_ALLOWED_ACE_TYPE = (0x0);

        [NativeTypeName("#define ACCESS_DENIED_ACE_TYPE (0x1)")]
        public const int ACCESS_DENIED_ACE_TYPE = (0x1);

        [NativeTypeName("#define SYSTEM_AUDIT_ACE_TYPE (0x2)")]
        public const int SYSTEM_AUDIT_ACE_TYPE = (0x2);

        [NativeTypeName("#define SYSTEM_ALARM_ACE_TYPE (0x3)")]
        public const int SYSTEM_ALARM_ACE_TYPE = (0x3);

        [NativeTypeName("#define ACCESS_MAX_MS_V2_ACE_TYPE (0x3)")]
        public const int ACCESS_MAX_MS_V2_ACE_TYPE = (0x3);

        [NativeTypeName("#define ACCESS_ALLOWED_COMPOUND_ACE_TYPE (0x4)")]
        public const int ACCESS_ALLOWED_COMPOUND_ACE_TYPE = (0x4);

        [NativeTypeName("#define ACCESS_MAX_MS_V3_ACE_TYPE (0x4)")]
        public const int ACCESS_MAX_MS_V3_ACE_TYPE = (0x4);

        [NativeTypeName("#define ACCESS_MIN_MS_OBJECT_ACE_TYPE (0x5)")]
        public const int ACCESS_MIN_MS_OBJECT_ACE_TYPE = (0x5);

        [NativeTypeName("#define ACCESS_ALLOWED_OBJECT_ACE_TYPE (0x5)")]
        public const int ACCESS_ALLOWED_OBJECT_ACE_TYPE = (0x5);

        [NativeTypeName("#define ACCESS_DENIED_OBJECT_ACE_TYPE (0x6)")]
        public const int ACCESS_DENIED_OBJECT_ACE_TYPE = (0x6);

        [NativeTypeName("#define SYSTEM_AUDIT_OBJECT_ACE_TYPE (0x7)")]
        public const int SYSTEM_AUDIT_OBJECT_ACE_TYPE = (0x7);

        [NativeTypeName("#define SYSTEM_ALARM_OBJECT_ACE_TYPE (0x8)")]
        public const int SYSTEM_ALARM_OBJECT_ACE_TYPE = (0x8);

        [NativeTypeName("#define ACCESS_MAX_MS_OBJECT_ACE_TYPE (0x8)")]
        public const int ACCESS_MAX_MS_OBJECT_ACE_TYPE = (0x8);

        [NativeTypeName("#define ACCESS_MAX_MS_V4_ACE_TYPE (0x8)")]
        public const int ACCESS_MAX_MS_V4_ACE_TYPE = (0x8);

        [NativeTypeName("#define ACCESS_MAX_MS_ACE_TYPE (0x8)")]
        public const int ACCESS_MAX_MS_ACE_TYPE = (0x8);

        [NativeTypeName("#define ACCESS_ALLOWED_CALLBACK_ACE_TYPE (0x9)")]
        public const int ACCESS_ALLOWED_CALLBACK_ACE_TYPE = (0x9);

        [NativeTypeName("#define ACCESS_DENIED_CALLBACK_ACE_TYPE (0xA)")]
        public const int ACCESS_DENIED_CALLBACK_ACE_TYPE = (0xA);

        [NativeTypeName("#define ACCESS_ALLOWED_CALLBACK_OBJECT_ACE_TYPE (0xB)")]
        public const int ACCESS_ALLOWED_CALLBACK_OBJECT_ACE_TYPE = (0xB);

        [NativeTypeName("#define ACCESS_DENIED_CALLBACK_OBJECT_ACE_TYPE (0xC)")]
        public const int ACCESS_DENIED_CALLBACK_OBJECT_ACE_TYPE = (0xC);

        [NativeTypeName("#define SYSTEM_AUDIT_CALLBACK_ACE_TYPE (0xD)")]
        public const int SYSTEM_AUDIT_CALLBACK_ACE_TYPE = (0xD);

        [NativeTypeName("#define SYSTEM_ALARM_CALLBACK_ACE_TYPE (0xE)")]
        public const int SYSTEM_ALARM_CALLBACK_ACE_TYPE = (0xE);

        [NativeTypeName("#define SYSTEM_AUDIT_CALLBACK_OBJECT_ACE_TYPE (0xF)")]
        public const int SYSTEM_AUDIT_CALLBACK_OBJECT_ACE_TYPE = (0xF);

        [NativeTypeName("#define SYSTEM_ALARM_CALLBACK_OBJECT_ACE_TYPE (0x10)")]
        public const int SYSTEM_ALARM_CALLBACK_OBJECT_ACE_TYPE = (0x10);

        [NativeTypeName("#define SYSTEM_MANDATORY_LABEL_ACE_TYPE (0x11)")]
        public const int SYSTEM_MANDATORY_LABEL_ACE_TYPE = (0x11);

        [NativeTypeName("#define SYSTEM_RESOURCE_ATTRIBUTE_ACE_TYPE (0x12)")]
        public const int SYSTEM_RESOURCE_ATTRIBUTE_ACE_TYPE = (0x12);

        [NativeTypeName("#define SYSTEM_SCOPED_POLICY_ID_ACE_TYPE (0x13)")]
        public const int SYSTEM_SCOPED_POLICY_ID_ACE_TYPE = (0x13);

        [NativeTypeName("#define SYSTEM_PROCESS_TRUST_LABEL_ACE_TYPE (0x14)")]
        public const int SYSTEM_PROCESS_TRUST_LABEL_ACE_TYPE = (0x14);

        [NativeTypeName("#define SYSTEM_ACCESS_FILTER_ACE_TYPE (0x15)")]
        public const int SYSTEM_ACCESS_FILTER_ACE_TYPE = (0x15);

        [NativeTypeName("#define ACCESS_MAX_MS_V5_ACE_TYPE (0x15)")]
        public const int ACCESS_MAX_MS_V5_ACE_TYPE = (0x15);

        [NativeTypeName("#define OBJECT_INHERIT_ACE (0x1)")]
        public const int OBJECT_INHERIT_ACE = (0x1);

        [NativeTypeName("#define CONTAINER_INHERIT_ACE (0x2)")]
        public const int CONTAINER_INHERIT_ACE = (0x2);

        [NativeTypeName("#define NO_PROPAGATE_INHERIT_ACE (0x4)")]
        public const int NO_PROPAGATE_INHERIT_ACE = (0x4);

        [NativeTypeName("#define INHERIT_ONLY_ACE (0x8)")]
        public const int INHERIT_ONLY_ACE = (0x8);

        [NativeTypeName("#define INHERITED_ACE (0x10)")]
        public const int INHERITED_ACE = (0x10);

        [NativeTypeName("#define VALID_INHERIT_FLAGS (0x1F)")]
        public const int VALID_INHERIT_FLAGS = (0x1F);

        [NativeTypeName("#define CRITICAL_ACE_FLAG (0x20)")]
        public const int CRITICAL_ACE_FLAG = (0x20);

        [NativeTypeName("#define SUCCESSFUL_ACCESS_ACE_FLAG (0x40)")]
        public const int SUCCESSFUL_ACCESS_ACE_FLAG = (0x40);

        [NativeTypeName("#define FAILED_ACCESS_ACE_FLAG (0x80)")]
        public const int FAILED_ACCESS_ACE_FLAG = (0x80);

        [NativeTypeName("#define TRUST_PROTECTED_FILTER_ACE_FLAG (0x40)")]
        public const int TRUST_PROTECTED_FILTER_ACE_FLAG = (0x40);

        [NativeTypeName("#define SYSTEM_MANDATORY_LABEL_NO_WRITE_UP 0x1")]
        public const int SYSTEM_MANDATORY_LABEL_NO_WRITE_UP = 0x1;

        [NativeTypeName("#define SYSTEM_MANDATORY_LABEL_NO_READ_UP 0x2")]
        public const int SYSTEM_MANDATORY_LABEL_NO_READ_UP = 0x2;

        [NativeTypeName("#define SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP 0x4")]
        public const int SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP = 0x4;

        [NativeTypeName("#define SYSTEM_MANDATORY_LABEL_VALID_MASK (SYSTEM_MANDATORY_LABEL_NO_WRITE_UP   | \\\r\n                                           SYSTEM_MANDATORY_LABEL_NO_READ_UP    | \\\r\n                                           SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP)")]
        public const int SYSTEM_MANDATORY_LABEL_VALID_MASK = (0x1 | 0x2 | 0x4);

        [NativeTypeName("#define SYSTEM_PROCESS_TRUST_LABEL_VALID_MASK 0x00ffffff")]
        public const int SYSTEM_PROCESS_TRUST_LABEL_VALID_MASK = 0x00ffffff;

        [NativeTypeName("#define SYSTEM_PROCESS_TRUST_NOCONSTRAINT_MASK 0xffffffff")]
        public const uint SYSTEM_PROCESS_TRUST_NOCONSTRAINT_MASK = 0xffffffff;

        [NativeTypeName("#define SYSTEM_ACCESS_FILTER_VALID_MASK 0x00ffffff")]
        public const int SYSTEM_ACCESS_FILTER_VALID_MASK = 0x00ffffff;

        [NativeTypeName("#define SYSTEM_ACCESS_FILTER_NOCONSTRAINT_MASK 0xffffffff")]
        public const uint SYSTEM_ACCESS_FILTER_NOCONSTRAINT_MASK = 0xffffffff;

        [NativeTypeName("#define ACE_OBJECT_TYPE_PRESENT 0x1")]
        public const int ACE_OBJECT_TYPE_PRESENT = 0x1;

        [NativeTypeName("#define ACE_INHERITED_OBJECT_TYPE_PRESENT 0x2")]
        public const int ACE_INHERITED_OBJECT_TYPE_PRESENT = 0x2;

        [NativeTypeName("#define SECURITY_DESCRIPTOR_REVISION (1)")]
        public const int SECURITY_DESCRIPTOR_REVISION = (1);

        [NativeTypeName("#define SECURITY_DESCRIPTOR_REVISION1 (1)")]
        public const int SECURITY_DESCRIPTOR_REVISION1 = (1);

        [NativeTypeName("#define SECURITY_DESCRIPTOR_MIN_LENGTH (sizeof(SECURITY_DESCRIPTOR))")]
        public static readonly uint SECURITY_DESCRIPTOR_MIN_LENGTH = unchecked((uint)(sizeof(SECURITY_DESCRIPTOR)));

        [NativeTypeName("#define SE_OWNER_DEFAULTED (0x0001)")]
        public const int SE_OWNER_DEFAULTED = (0x0001);

        [NativeTypeName("#define SE_GROUP_DEFAULTED (0x0002)")]
        public const int SE_GROUP_DEFAULTED = (0x0002);

        [NativeTypeName("#define SE_DACL_PRESENT (0x0004)")]
        public const int SE_DACL_PRESENT = (0x0004);

        [NativeTypeName("#define SE_DACL_DEFAULTED (0x0008)")]
        public const int SE_DACL_DEFAULTED = (0x0008);

        [NativeTypeName("#define SE_SACL_PRESENT (0x0010)")]
        public const int SE_SACL_PRESENT = (0x0010);

        [NativeTypeName("#define SE_SACL_DEFAULTED (0x0020)")]
        public const int SE_SACL_DEFAULTED = (0x0020);

        [NativeTypeName("#define SE_DACL_AUTO_INHERIT_REQ (0x0100)")]
        public const int SE_DACL_AUTO_INHERIT_REQ = (0x0100);

        [NativeTypeName("#define SE_SACL_AUTO_INHERIT_REQ (0x0200)")]
        public const int SE_SACL_AUTO_INHERIT_REQ = (0x0200);

        [NativeTypeName("#define SE_DACL_AUTO_INHERITED (0x0400)")]
        public const int SE_DACL_AUTO_INHERITED = (0x0400);

        [NativeTypeName("#define SE_SACL_AUTO_INHERITED (0x0800)")]
        public const int SE_SACL_AUTO_INHERITED = (0x0800);

        [NativeTypeName("#define SE_DACL_PROTECTED (0x1000)")]
        public const int SE_DACL_PROTECTED = (0x1000);

        [NativeTypeName("#define SE_SACL_PROTECTED (0x2000)")]
        public const int SE_SACL_PROTECTED = (0x2000);

        [NativeTypeName("#define SE_RM_CONTROL_VALID (0x4000)")]
        public const int SE_RM_CONTROL_VALID = (0x4000);

        [NativeTypeName("#define SE_SELF_RELATIVE (0x8000)")]
        public const int SE_SELF_RELATIVE = (0x8000);

        [NativeTypeName("#define ACCESS_OBJECT_GUID 0")]
        public const int ACCESS_OBJECT_GUID = 0;

        [NativeTypeName("#define ACCESS_PROPERTY_SET_GUID 1")]
        public const int ACCESS_PROPERTY_SET_GUID = 1;

        [NativeTypeName("#define ACCESS_PROPERTY_GUID 2")]
        public const int ACCESS_PROPERTY_GUID = 2;

        [NativeTypeName("#define ACCESS_MAX_LEVEL 4")]
        public const int ACCESS_MAX_LEVEL = 4;

        [NativeTypeName("#define AUDIT_ALLOW_NO_PRIVILEGE 0x1")]
        public const int AUDIT_ALLOW_NO_PRIVILEGE = 0x1;

        [NativeTypeName("#define ACCESS_DS_SOURCE_A \"DS\"")]
        public static ReadOnlySpan<byte> ACCESS_DS_SOURCE_A => new byte[] { 0x44, 0x53, 0x00 };

        [NativeTypeName("#define ACCESS_DS_SOURCE_W L\"DS\"")]
        public const string ACCESS_DS_SOURCE_W = "DS";

        [NativeTypeName("#define ACCESS_DS_OBJECT_TYPE_NAME_A \"Directory Service Object\"")]
        public static ReadOnlySpan<byte> ACCESS_DS_OBJECT_TYPE_NAME_A => new byte[] { 0x44, 0x69, 0x72, 0x65, 0x63, 0x74, 0x6F, 0x72, 0x79, 0x20, 0x53, 0x65, 0x72, 0x76, 0x69, 0x63, 0x65, 0x20, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        [NativeTypeName("#define ACCESS_DS_OBJECT_TYPE_NAME_W L\"Directory Service Object\"")]
        public const string ACCESS_DS_OBJECT_TYPE_NAME_W = "Directory Service Object";

        [NativeTypeName("#define SE_PRIVILEGE_ENABLED_BY_DEFAULT (0x00000001L)")]
        public const int SE_PRIVILEGE_ENABLED_BY_DEFAULT = (0x00000001);

        [NativeTypeName("#define SE_PRIVILEGE_ENABLED (0x00000002L)")]
        public const int SE_PRIVILEGE_ENABLED = (0x00000002);

        [NativeTypeName("#define SE_PRIVILEGE_REMOVED (0X00000004L)")]
        public const int SE_PRIVILEGE_REMOVED = (0X00000004);

        [NativeTypeName("#define SE_PRIVILEGE_USED_FOR_ACCESS (0x80000000L)")]
        public const uint SE_PRIVILEGE_USED_FOR_ACCESS = (0x80000000);

        [NativeTypeName("#define SE_PRIVILEGE_VALID_ATTRIBUTES (SE_PRIVILEGE_ENABLED_BY_DEFAULT | \\\r\n                                         SE_PRIVILEGE_ENABLED            | \\\r\n                                         SE_PRIVILEGE_REMOVED            | \\\r\n                                         SE_PRIVILEGE_USED_FOR_ACCESS)")]
        public const uint SE_PRIVILEGE_VALID_ATTRIBUTES = ((0x00000001) | (0x00000002) | (0X00000004) | (0x80000000));

        [NativeTypeName("#define PRIVILEGE_SET_ALL_NECESSARY (1)")]
        public const int PRIVILEGE_SET_ALL_NECESSARY = (1);

        [NativeTypeName("#define ACCESS_REASON_TYPE_MASK 0x00ff0000")]
        public const int ACCESS_REASON_TYPE_MASK = 0x00ff0000;

        [NativeTypeName("#define ACCESS_REASON_DATA_MASK 0x0000ffff")]
        public const int ACCESS_REASON_DATA_MASK = 0x0000ffff;

        [NativeTypeName("#define ACCESS_REASON_STAGING_MASK 0x80000000")]
        public const uint ACCESS_REASON_STAGING_MASK = 0x80000000;

        [NativeTypeName("#define ACCESS_REASON_EXDATA_MASK 0x7f000000")]
        public const int ACCESS_REASON_EXDATA_MASK = 0x7f000000;

        [NativeTypeName("#define SE_SECURITY_DESCRIPTOR_FLAG_NO_OWNER_ACE 0x00000001")]
        public const int SE_SECURITY_DESCRIPTOR_FLAG_NO_OWNER_ACE = 0x00000001;

        [NativeTypeName("#define SE_SECURITY_DESCRIPTOR_FLAG_NO_LABEL_ACE 0x00000002")]
        public const int SE_SECURITY_DESCRIPTOR_FLAG_NO_LABEL_ACE = 0x00000002;

        [NativeTypeName("#define SE_SECURITY_DESCRIPTOR_FLAG_NO_ACCESS_FILTER_ACE 0x00000004")]
        public const int SE_SECURITY_DESCRIPTOR_FLAG_NO_ACCESS_FILTER_ACE = 0x00000004;

        [NativeTypeName("#define SE_SECURITY_DESCRIPTOR_VALID_FLAGS 0x00000007")]
        public const int SE_SECURITY_DESCRIPTOR_VALID_FLAGS = 0x00000007;

        [NativeTypeName("#define SE_ACCESS_CHECK_FLAG_NO_LEARNING_MODE_LOGGING 0x00000008")]
        public const int SE_ACCESS_CHECK_FLAG_NO_LEARNING_MODE_LOGGING = 0x00000008;

        [NativeTypeName("#define SE_ACCESS_CHECK_VALID_FLAGS 0x00000008")]
        public const int SE_ACCESS_CHECK_VALID_FLAGS = 0x00000008;

        [NativeTypeName("#define SE_CREATE_TOKEN_NAME TEXT(\"SeCreateTokenPrivilege\")")]
        public const string SE_CREATE_TOKEN_NAME = "SeCreateTokenPrivilege";

        [NativeTypeName("#define SE_ASSIGNPRIMARYTOKEN_NAME TEXT(\"SeAssignPrimaryTokenPrivilege\")")]
        public const string SE_ASSIGNPRIMARYTOKEN_NAME = "SeAssignPrimaryTokenPrivilege";

        [NativeTypeName("#define SE_LOCK_MEMORY_NAME TEXT(\"SeLockMemoryPrivilege\")")]
        public const string SE_LOCK_MEMORY_NAME = "SeLockMemoryPrivilege";

        [NativeTypeName("#define SE_INCREASE_QUOTA_NAME TEXT(\"SeIncreaseQuotaPrivilege\")")]
        public const string SE_INCREASE_QUOTA_NAME = "SeIncreaseQuotaPrivilege";

        [NativeTypeName("#define SE_UNSOLICITED_INPUT_NAME TEXT(\"SeUnsolicitedInputPrivilege\")")]
        public const string SE_UNSOLICITED_INPUT_NAME = "SeUnsolicitedInputPrivilege";

        [NativeTypeName("#define SE_MACHINE_ACCOUNT_NAME TEXT(\"SeMachineAccountPrivilege\")")]
        public const string SE_MACHINE_ACCOUNT_NAME = "SeMachineAccountPrivilege";

        [NativeTypeName("#define SE_TCB_NAME TEXT(\"SeTcbPrivilege\")")]
        public const string SE_TCB_NAME = "SeTcbPrivilege";

        [NativeTypeName("#define SE_SECURITY_NAME TEXT(\"SeSecurityPrivilege\")")]
        public const string SE_SECURITY_NAME = "SeSecurityPrivilege";

        [NativeTypeName("#define SE_TAKE_OWNERSHIP_NAME TEXT(\"SeTakeOwnershipPrivilege\")")]
        public const string SE_TAKE_OWNERSHIP_NAME = "SeTakeOwnershipPrivilege";

        [NativeTypeName("#define SE_LOAD_DRIVER_NAME TEXT(\"SeLoadDriverPrivilege\")")]
        public const string SE_LOAD_DRIVER_NAME = "SeLoadDriverPrivilege";

        [NativeTypeName("#define SE_SYSTEM_PROFILE_NAME TEXT(\"SeSystemProfilePrivilege\")")]
        public const string SE_SYSTEM_PROFILE_NAME = "SeSystemProfilePrivilege";

        [NativeTypeName("#define SE_SYSTEMTIME_NAME TEXT(\"SeSystemtimePrivilege\")")]
        public const string SE_SYSTEMTIME_NAME = "SeSystemtimePrivilege";

        [NativeTypeName("#define SE_PROF_SINGLE_PROCESS_NAME TEXT(\"SeProfileSingleProcessPrivilege\")")]
        public const string SE_PROF_SINGLE_PROCESS_NAME = "SeProfileSingleProcessPrivilege";

        [NativeTypeName("#define SE_INC_BASE_PRIORITY_NAME TEXT(\"SeIncreaseBasePriorityPrivilege\")")]
        public const string SE_INC_BASE_PRIORITY_NAME = "SeIncreaseBasePriorityPrivilege";

        [NativeTypeName("#define SE_CREATE_PAGEFILE_NAME TEXT(\"SeCreatePagefilePrivilege\")")]
        public const string SE_CREATE_PAGEFILE_NAME = "SeCreatePagefilePrivilege";

        [NativeTypeName("#define SE_CREATE_PERMANENT_NAME TEXT(\"SeCreatePermanentPrivilege\")")]
        public const string SE_CREATE_PERMANENT_NAME = "SeCreatePermanentPrivilege";

        [NativeTypeName("#define SE_BACKUP_NAME TEXT(\"SeBackupPrivilege\")")]
        public const string SE_BACKUP_NAME = "SeBackupPrivilege";

        [NativeTypeName("#define SE_RESTORE_NAME TEXT(\"SeRestorePrivilege\")")]
        public const string SE_RESTORE_NAME = "SeRestorePrivilege";

        [NativeTypeName("#define SE_SHUTDOWN_NAME TEXT(\"SeShutdownPrivilege\")")]
        public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

        [NativeTypeName("#define SE_DEBUG_NAME TEXT(\"SeDebugPrivilege\")")]
        public const string SE_DEBUG_NAME = "SeDebugPrivilege";

        [NativeTypeName("#define SE_AUDIT_NAME TEXT(\"SeAuditPrivilege\")")]
        public const string SE_AUDIT_NAME = "SeAuditPrivilege";

        [NativeTypeName("#define SE_SYSTEM_ENVIRONMENT_NAME TEXT(\"SeSystemEnvironmentPrivilege\")")]
        public const string SE_SYSTEM_ENVIRONMENT_NAME = "SeSystemEnvironmentPrivilege";

        [NativeTypeName("#define SE_CHANGE_NOTIFY_NAME TEXT(\"SeChangeNotifyPrivilege\")")]
        public const string SE_CHANGE_NOTIFY_NAME = "SeChangeNotifyPrivilege";

        [NativeTypeName("#define SE_REMOTE_SHUTDOWN_NAME TEXT(\"SeRemoteShutdownPrivilege\")")]
        public const string SE_REMOTE_SHUTDOWN_NAME = "SeRemoteShutdownPrivilege";

        [NativeTypeName("#define SE_UNDOCK_NAME TEXT(\"SeUndockPrivilege\")")]
        public const string SE_UNDOCK_NAME = "SeUndockPrivilege";

        [NativeTypeName("#define SE_SYNC_AGENT_NAME TEXT(\"SeSyncAgentPrivilege\")")]
        public const string SE_SYNC_AGENT_NAME = "SeSyncAgentPrivilege";

        [NativeTypeName("#define SE_ENABLE_DELEGATION_NAME TEXT(\"SeEnableDelegationPrivilege\")")]
        public const string SE_ENABLE_DELEGATION_NAME = "SeEnableDelegationPrivilege";

        [NativeTypeName("#define SE_MANAGE_VOLUME_NAME TEXT(\"SeManageVolumePrivilege\")")]
        public const string SE_MANAGE_VOLUME_NAME = "SeManageVolumePrivilege";

        [NativeTypeName("#define SE_IMPERSONATE_NAME TEXT(\"SeImpersonatePrivilege\")")]
        public const string SE_IMPERSONATE_NAME = "SeImpersonatePrivilege";

        [NativeTypeName("#define SE_CREATE_GLOBAL_NAME TEXT(\"SeCreateGlobalPrivilege\")")]
        public const string SE_CREATE_GLOBAL_NAME = "SeCreateGlobalPrivilege";

        [NativeTypeName("#define SE_TRUSTED_CREDMAN_ACCESS_NAME TEXT(\"SeTrustedCredManAccessPrivilege\")")]
        public const string SE_TRUSTED_CREDMAN_ACCESS_NAME = "SeTrustedCredManAccessPrivilege";

        [NativeTypeName("#define SE_RELABEL_NAME TEXT(\"SeRelabelPrivilege\")")]
        public const string SE_RELABEL_NAME = "SeRelabelPrivilege";

        [NativeTypeName("#define SE_INC_WORKING_SET_NAME TEXT(\"SeIncreaseWorkingSetPrivilege\")")]
        public const string SE_INC_WORKING_SET_NAME = "SeIncreaseWorkingSetPrivilege";

        [NativeTypeName("#define SE_TIME_ZONE_NAME TEXT(\"SeTimeZonePrivilege\")")]
        public const string SE_TIME_ZONE_NAME = "SeTimeZonePrivilege";

        [NativeTypeName("#define SE_CREATE_SYMBOLIC_LINK_NAME TEXT(\"SeCreateSymbolicLinkPrivilege\")")]
        public const string SE_CREATE_SYMBOLIC_LINK_NAME = "SeCreateSymbolicLinkPrivilege";

        [NativeTypeName("#define SE_DELEGATE_SESSION_USER_IMPERSONATE_NAME TEXT(\"SeDelegateSessionUserImpersonatePrivilege\")")]
        public const string SE_DELEGATE_SESSION_USER_IMPERSONATE_NAME = "SeDelegateSessionUserImpersonatePrivilege";

        [NativeTypeName("#define SE_ACTIVATE_AS_USER_CAPABILITY L\"activateAsUser\"")]
        public const string SE_ACTIVATE_AS_USER_CAPABILITY = "activateAsUser";

        [NativeTypeName("#define SE_CONSTRAINED_IMPERSONATION_CAPABILITY L\"constrainedImpersonation\"")]
        public const string SE_CONSTRAINED_IMPERSONATION_CAPABILITY = "constrainedImpersonation";

        [NativeTypeName("#define SE_SESSION_IMPERSONATION_CAPABILITY L\"sessionImpersonation\"")]
        public const string SE_SESSION_IMPERSONATION_CAPABILITY = "sessionImpersonation";

        [NativeTypeName("#define SE_MUMA_CAPABILITY L\"muma\"")]
        public const string SE_MUMA_CAPABILITY = "muma";

        [NativeTypeName("#define SE_DEVELOPMENT_MODE_NETWORK_CAPABILITY L\"developmentModeNetwork\"")]
        public const string SE_DEVELOPMENT_MODE_NETWORK_CAPABILITY = "developmentModeNetwork";

        [NativeTypeName("#define SECURITY_MAX_IMPERSONATION_LEVEL SecurityDelegation")]
        public const SECURITY_IMPERSONATION_LEVEL SECURITY_MAX_IMPERSONATION_LEVEL = SecurityDelegation;

        [NativeTypeName("#define SECURITY_MIN_IMPERSONATION_LEVEL SecurityAnonymous")]
        public const SECURITY_IMPERSONATION_LEVEL SECURITY_MIN_IMPERSONATION_LEVEL = SecurityAnonymous;

        [NativeTypeName("#define DEFAULT_IMPERSONATION_LEVEL SecurityImpersonation")]
        public const SECURITY_IMPERSONATION_LEVEL DEFAULT_IMPERSONATION_LEVEL = SecurityImpersonation;

        [NativeTypeName("#define TOKEN_ASSIGN_PRIMARY (0x0001)")]
        public const int TOKEN_ASSIGN_PRIMARY = (0x0001);

        [NativeTypeName("#define TOKEN_DUPLICATE (0x0002)")]
        public const int TOKEN_DUPLICATE = (0x0002);

        [NativeTypeName("#define TOKEN_IMPERSONATE (0x0004)")]
        public const int TOKEN_IMPERSONATE = (0x0004);

        [NativeTypeName("#define TOKEN_QUERY (0x0008)")]
        public const int TOKEN_QUERY = (0x0008);

        [NativeTypeName("#define TOKEN_QUERY_SOURCE (0x0010)")]
        public const int TOKEN_QUERY_SOURCE = (0x0010);

        [NativeTypeName("#define TOKEN_ADJUST_PRIVILEGES (0x0020)")]
        public const int TOKEN_ADJUST_PRIVILEGES = (0x0020);

        [NativeTypeName("#define TOKEN_ADJUST_GROUPS (0x0040)")]
        public const int TOKEN_ADJUST_GROUPS = (0x0040);

        [NativeTypeName("#define TOKEN_ADJUST_DEFAULT (0x0080)")]
        public const int TOKEN_ADJUST_DEFAULT = (0x0080);

        [NativeTypeName("#define TOKEN_ADJUST_SESSIONID (0x0100)")]
        public const int TOKEN_ADJUST_SESSIONID = (0x0100);

        [NativeTypeName("#define TOKEN_ALL_ACCESS_P (STANDARD_RIGHTS_REQUIRED  |\\\r\n                          TOKEN_ASSIGN_PRIMARY      |\\\r\n                          TOKEN_DUPLICATE           |\\\r\n                          TOKEN_IMPERSONATE         |\\\r\n                          TOKEN_QUERY               |\\\r\n                          TOKEN_QUERY_SOURCE        |\\\r\n                          TOKEN_ADJUST_PRIVILEGES   |\\\r\n                          TOKEN_ADJUST_GROUPS       |\\\r\n                          TOKEN_ADJUST_DEFAULT )")]
        public const int TOKEN_ALL_ACCESS_P = ((0x000F0000) | (0x0001) | (0x0002) | (0x0004) | (0x0008) | (0x0010) | (0x0020) | (0x0040) | (0x0080));

        [NativeTypeName("#define TOKEN_ALL_ACCESS (TOKEN_ALL_ACCESS_P |\\\r\n                          TOKEN_ADJUST_SESSIONID )")]
        public const int TOKEN_ALL_ACCESS = (((0x000F0000) | (0x0001) | (0x0002) | (0x0004) | (0x0008) | (0x0010) | (0x0020) | (0x0040) | (0x0080)) | (0x0100));

        [NativeTypeName("#define TOKEN_READ (STANDARD_RIGHTS_READ      |\\\r\n                          TOKEN_QUERY)")]
        public const int TOKEN_READ = (((0x00020000)) | (0x0008));

        [NativeTypeName("#define TOKEN_WRITE (STANDARD_RIGHTS_WRITE     |\\\r\n                          TOKEN_ADJUST_PRIVILEGES   |\\\r\n                          TOKEN_ADJUST_GROUPS       |\\\r\n                          TOKEN_ADJUST_DEFAULT)")]
        public const int TOKEN_WRITE = (((0x00020000)) | (0x0020) | (0x0040) | (0x0080));

        [NativeTypeName("#define TOKEN_EXECUTE (STANDARD_RIGHTS_EXECUTE)")]
        public const int TOKEN_EXECUTE = (((0x00020000)));

        [NativeTypeName("#define TOKEN_TRUST_CONSTRAINT_MASK (STANDARD_RIGHTS_READ  | \\\r\n                                       TOKEN_QUERY  |\\\r\n                                       TOKEN_QUERY_SOURCE )")]
        public const int TOKEN_TRUST_CONSTRAINT_MASK = (((0x00020000)) | (0x0008) | (0x0010));

        [NativeTypeName("#define TOKEN_ACCESS_PSEUDO_HANDLE_WIN8 (TOKEN_QUERY | TOKEN_QUERY_SOURCE)")]
        public const int TOKEN_ACCESS_PSEUDO_HANDLE_WIN8 = ((0x0008) | (0x0010));

        [NativeTypeName("#define TOKEN_ACCESS_PSEUDO_HANDLE TOKEN_ACCESS_PSEUDO_HANDLE_WIN8")]
        public const int TOKEN_ACCESS_PSEUDO_HANDLE = ((0x0008) | (0x0010));

        [NativeTypeName("#define TOKEN_USER_MAX_SIZE (sizeof(TOKEN_USER) + SECURITY_MAX_SID_SIZE)")]
        public static readonly uint TOKEN_USER_MAX_SIZE = unchecked((uint)(sizeof(TOKEN_USER)) + (12 - 4 + ((15) * 4)));

        [NativeTypeName("#define TOKEN_OWNER_MAX_SIZE (sizeof(TOKEN_OWNER) + SECURITY_MAX_SID_SIZE)")]
        public static readonly uint TOKEN_OWNER_MAX_SIZE = unchecked((uint)(sizeof(TOKEN_OWNER)) + (12 - 4 + ((15) * 4)));

        [NativeTypeName("#define TOKEN_MANDATORY_POLICY_OFF 0x0")]
        public const int TOKEN_MANDATORY_POLICY_OFF = 0x0;

        [NativeTypeName("#define TOKEN_MANDATORY_POLICY_NO_WRITE_UP 0x1")]
        public const int TOKEN_MANDATORY_POLICY_NO_WRITE_UP = 0x1;

        [NativeTypeName("#define TOKEN_MANDATORY_POLICY_NEW_PROCESS_MIN 0x2")]
        public const int TOKEN_MANDATORY_POLICY_NEW_PROCESS_MIN = 0x2;

        [NativeTypeName("#define TOKEN_MANDATORY_POLICY_VALID_MASK (TOKEN_MANDATORY_POLICY_NO_WRITE_UP | \\\r\n                                                TOKEN_MANDATORY_POLICY_NEW_PROCESS_MIN)")]
        public const int TOKEN_MANDATORY_POLICY_VALID_MASK = (0x1 | 0x2);

        [NativeTypeName("#define TOKEN_INTEGRITY_LEVEL_MAX_SIZE ((((DWORD)(sizeof(TOKEN_MANDATORY_LABEL)) + sizeof(PVOID) - 1) & ~(sizeof(PVOID)-1)) + SECURITY_MAX_SID_SIZE)")]
        public static readonly uint TOKEN_INTEGRITY_LEVEL_MAX_SIZE = unchecked((((uint)((uint)(sizeof(TOKEN_MANDATORY_LABEL))) + (uint)(sizeof(void*)) - 1) & ~((uint)(sizeof(void*)) - 1)) + (12 - 4 + ((15) * 4)));

        [NativeTypeName("#define POLICY_AUDIT_SUBCATEGORY_COUNT (59)")]
        public const int POLICY_AUDIT_SUBCATEGORY_COUNT = (59);

        [NativeTypeName("#define TOKEN_SOURCE_LENGTH 8")]
        public const int TOKEN_SOURCE_LENGTH = 8;

        [NativeTypeName("#define TOKEN_APPCONTAINER_SID_MAX_SIZE (sizeof(TOKEN_APPCONTAINER_INFORMATION) + SECURITY_MAX_SID_SIZE)")]
        public static readonly uint TOKEN_APPCONTAINER_SID_MAX_SIZE = unchecked((uint)(sizeof(TOKEN_APPCONTAINER_INFORMATION)) + (12 - 4 + ((15) * 4)));

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_INVALID 0x00")]
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_INVALID = 0x00;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64 0x01")]
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64 = 0x01;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64 0x02")]
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64 = 0x02;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING 0x03")]
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING = 0x03;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN 0x04")]
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN = 0x04;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_SID 0x05")]
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_SID = 0x05;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_BOOLEAN 0x06")]
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_BOOLEAN = 0x06;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING 0x10")]
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING = 0x10;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE 0x0001")]
        public const int CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE = 0x0001;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE 0x0002")]
        public const int CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE = 0x0002;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY 0x0004")]
        public const int CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY = 0x0004;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT 0x0008")]
        public const int CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT = 0x0008;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_DISABLED 0x0010")]
        public const int CLAIM_SECURITY_ATTRIBUTE_DISABLED = 0x0010;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_MANDATORY 0x0020")]
        public const int CLAIM_SECURITY_ATTRIBUTE_MANDATORY = 0x0020;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_VALID_FLAGS (    \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE       |  \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE  |  \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY     |  \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT   |  \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_DISABLED              |  \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_MANDATORY )")]
        public const int CLAIM_SECURITY_ATTRIBUTE_VALID_FLAGS = (0x0001 | 0x0002 | 0x0004 | 0x0008 | 0x0010 | 0x0020);

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_CUSTOM_FLAGS 0xFFFF0000")]
        public const uint CLAIM_SECURITY_ATTRIBUTE_CUSTOM_FLAGS = 0xFFFF0000;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1 1")]
        public const int CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1 = 1;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1")]
        public const int CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION = 1;

        [NativeTypeName("#define SECURITY_DYNAMIC_TRACKING (TRUE)")]
        public const int SECURITY_DYNAMIC_TRACKING = (1);

        [NativeTypeName("#define SECURITY_STATIC_TRACKING (FALSE)")]
        public const int SECURITY_STATIC_TRACKING = (0);

        [NativeTypeName("#define DISABLE_MAX_PRIVILEGE 0x1")]
        public const int DISABLE_MAX_PRIVILEGE = 0x1;

        [NativeTypeName("#define SANDBOX_INERT 0x2")]
        public const int SANDBOX_INERT = 0x2;

        [NativeTypeName("#define LUA_TOKEN 0x4")]
        public const int LUA_TOKEN = 0x4;

        [NativeTypeName("#define WRITE_RESTRICTED 0x8")]
        public const int WRITE_RESTRICTED = 0x8;

        [NativeTypeName("#define OWNER_SECURITY_INFORMATION (0x00000001L)")]
        public const int OWNER_SECURITY_INFORMATION = (0x00000001);

        [NativeTypeName("#define GROUP_SECURITY_INFORMATION (0x00000002L)")]
        public const int GROUP_SECURITY_INFORMATION = (0x00000002);

        [NativeTypeName("#define DACL_SECURITY_INFORMATION (0x00000004L)")]
        public const int DACL_SECURITY_INFORMATION = (0x00000004);

        [NativeTypeName("#define SACL_SECURITY_INFORMATION (0x00000008L)")]
        public const int SACL_SECURITY_INFORMATION = (0x00000008);

        [NativeTypeName("#define LABEL_SECURITY_INFORMATION (0x00000010L)")]
        public const int LABEL_SECURITY_INFORMATION = (0x00000010);

        [NativeTypeName("#define ATTRIBUTE_SECURITY_INFORMATION (0x00000020L)")]
        public const int ATTRIBUTE_SECURITY_INFORMATION = (0x00000020);

        [NativeTypeName("#define SCOPE_SECURITY_INFORMATION (0x00000040L)")]
        public const int SCOPE_SECURITY_INFORMATION = (0x00000040);

        [NativeTypeName("#define PROCESS_TRUST_LABEL_SECURITY_INFORMATION (0x00000080L)")]
        public const int PROCESS_TRUST_LABEL_SECURITY_INFORMATION = (0x00000080);

        [NativeTypeName("#define ACCESS_FILTER_SECURITY_INFORMATION (0x00000100L)")]
        public const int ACCESS_FILTER_SECURITY_INFORMATION = (0x00000100);

        [NativeTypeName("#define BACKUP_SECURITY_INFORMATION (0x00010000L)")]
        public const int BACKUP_SECURITY_INFORMATION = (0x00010000);

        [NativeTypeName("#define PROTECTED_DACL_SECURITY_INFORMATION (0x80000000L)")]
        public const uint PROTECTED_DACL_SECURITY_INFORMATION = (0x80000000);

        [NativeTypeName("#define PROTECTED_SACL_SECURITY_INFORMATION (0x40000000L)")]
        public const int PROTECTED_SACL_SECURITY_INFORMATION = (0x40000000);

        [NativeTypeName("#define UNPROTECTED_DACL_SECURITY_INFORMATION (0x20000000L)")]
        public const int UNPROTECTED_DACL_SECURITY_INFORMATION = (0x20000000);

        [NativeTypeName("#define UNPROTECTED_SACL_SECURITY_INFORMATION (0x10000000L)")]
        public const int UNPROTECTED_SACL_SECURITY_INFORMATION = (0x10000000);

        [NativeTypeName("#define SE_SIGNING_LEVEL_UNCHECKED 0x00000000")]
        public const int SE_SIGNING_LEVEL_UNCHECKED = 0x00000000;

        [NativeTypeName("#define SE_SIGNING_LEVEL_UNSIGNED 0x00000001")]
        public const int SE_SIGNING_LEVEL_UNSIGNED = 0x00000001;

        [NativeTypeName("#define SE_SIGNING_LEVEL_ENTERPRISE 0x00000002")]
        public const int SE_SIGNING_LEVEL_ENTERPRISE = 0x00000002;

        [NativeTypeName("#define SE_SIGNING_LEVEL_CUSTOM_1 0x00000003")]
        public const int SE_SIGNING_LEVEL_CUSTOM_1 = 0x00000003;

        [NativeTypeName("#define SE_SIGNING_LEVEL_DEVELOPER SE_SIGNING_LEVEL_CUSTOM_1")]
        public const int SE_SIGNING_LEVEL_DEVELOPER = 0x00000003;

        [NativeTypeName("#define SE_SIGNING_LEVEL_AUTHENTICODE 0x00000004")]
        public const int SE_SIGNING_LEVEL_AUTHENTICODE = 0x00000004;

        [NativeTypeName("#define SE_SIGNING_LEVEL_CUSTOM_2 0x00000005")]
        public const int SE_SIGNING_LEVEL_CUSTOM_2 = 0x00000005;

        [NativeTypeName("#define SE_SIGNING_LEVEL_STORE 0x00000006")]
        public const int SE_SIGNING_LEVEL_STORE = 0x00000006;

        [NativeTypeName("#define SE_SIGNING_LEVEL_CUSTOM_3 0x00000007")]
        public const int SE_SIGNING_LEVEL_CUSTOM_3 = 0x00000007;

        [NativeTypeName("#define SE_SIGNING_LEVEL_ANTIMALWARE SE_SIGNING_LEVEL_CUSTOM_3")]
        public const int SE_SIGNING_LEVEL_ANTIMALWARE = 0x00000007;

        [NativeTypeName("#define SE_SIGNING_LEVEL_MICROSOFT 0x00000008")]
        public const int SE_SIGNING_LEVEL_MICROSOFT = 0x00000008;

        [NativeTypeName("#define SE_SIGNING_LEVEL_CUSTOM_4 0x00000009")]
        public const int SE_SIGNING_LEVEL_CUSTOM_4 = 0x00000009;

        [NativeTypeName("#define SE_SIGNING_LEVEL_CUSTOM_5 0x0000000A")]
        public const int SE_SIGNING_LEVEL_CUSTOM_5 = 0x0000000A;

        [NativeTypeName("#define SE_SIGNING_LEVEL_DYNAMIC_CODEGEN 0x0000000B")]
        public const int SE_SIGNING_LEVEL_DYNAMIC_CODEGEN = 0x0000000B;

        [NativeTypeName("#define SE_SIGNING_LEVEL_WINDOWS 0x0000000C")]
        public const int SE_SIGNING_LEVEL_WINDOWS = 0x0000000C;

        [NativeTypeName("#define SE_SIGNING_LEVEL_CUSTOM_7 0x0000000D")]
        public const int SE_SIGNING_LEVEL_CUSTOM_7 = 0x0000000D;

        [NativeTypeName("#define SE_SIGNING_LEVEL_WINDOWS_TCB 0x0000000E")]
        public const int SE_SIGNING_LEVEL_WINDOWS_TCB = 0x0000000E;

        [NativeTypeName("#define SE_SIGNING_LEVEL_CUSTOM_6 0x0000000F")]
        public const int SE_SIGNING_LEVEL_CUSTOM_6 = 0x0000000F;

        [NativeTypeName("#define SE_LEARNING_MODE_FLAG_PERMISSIVE 0x00000001")]
        public const int SE_LEARNING_MODE_FLAG_PERMISSIVE = 0x00000001;

        [NativeTypeName("#define PROCESS_TERMINATE (0x0001)")]
        public const int PROCESS_TERMINATE = (0x0001);

        [NativeTypeName("#define PROCESS_CREATE_THREAD (0x0002)")]
        public const int PROCESS_CREATE_THREAD = (0x0002);

        [NativeTypeName("#define PROCESS_SET_SESSIONID (0x0004)")]
        public const int PROCESS_SET_SESSIONID = (0x0004);

        [NativeTypeName("#define PROCESS_VM_OPERATION (0x0008)")]
        public const int PROCESS_VM_OPERATION = (0x0008);

        [NativeTypeName("#define PROCESS_VM_READ (0x0010)")]
        public const int PROCESS_VM_READ = (0x0010);

        [NativeTypeName("#define PROCESS_VM_WRITE (0x0020)")]
        public const int PROCESS_VM_WRITE = (0x0020);

        [NativeTypeName("#define PROCESS_DUP_HANDLE (0x0040)")]
        public const int PROCESS_DUP_HANDLE = (0x0040);

        [NativeTypeName("#define PROCESS_CREATE_PROCESS (0x0080)")]
        public const int PROCESS_CREATE_PROCESS = (0x0080);

        [NativeTypeName("#define PROCESS_SET_QUOTA (0x0100)")]
        public const int PROCESS_SET_QUOTA = (0x0100);

        [NativeTypeName("#define PROCESS_SET_INFORMATION (0x0200)")]
        public const int PROCESS_SET_INFORMATION = (0x0200);

        [NativeTypeName("#define PROCESS_QUERY_INFORMATION (0x0400)")]
        public const int PROCESS_QUERY_INFORMATION = (0x0400);

        [NativeTypeName("#define PROCESS_SUSPEND_RESUME (0x0800)")]
        public const int PROCESS_SUSPEND_RESUME = (0x0800);

        [NativeTypeName("#define PROCESS_QUERY_LIMITED_INFORMATION (0x1000)")]
        public const int PROCESS_QUERY_LIMITED_INFORMATION = (0x1000);

        [NativeTypeName("#define PROCESS_SET_LIMITED_INFORMATION (0x2000)")]
        public const int PROCESS_SET_LIMITED_INFORMATION = (0x2000);

        [NativeTypeName("#define PROCESS_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | \\\r\n                                   0xFFFF)")]
        public const int PROCESS_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0xFFFF);

        [NativeTypeName("#define THREAD_TERMINATE (0x0001)")]
        public const int THREAD_TERMINATE = (0x0001);

        [NativeTypeName("#define THREAD_SUSPEND_RESUME (0x0002)")]
        public const int THREAD_SUSPEND_RESUME = (0x0002);

        [NativeTypeName("#define THREAD_GET_CONTEXT (0x0008)")]
        public const int THREAD_GET_CONTEXT = (0x0008);

        [NativeTypeName("#define THREAD_SET_CONTEXT (0x0010)")]
        public const int THREAD_SET_CONTEXT = (0x0010);

        [NativeTypeName("#define THREAD_QUERY_INFORMATION (0x0040)")]
        public const int THREAD_QUERY_INFORMATION = (0x0040);

        [NativeTypeName("#define THREAD_SET_INFORMATION (0x0020)")]
        public const int THREAD_SET_INFORMATION = (0x0020);

        [NativeTypeName("#define THREAD_SET_THREAD_TOKEN (0x0080)")]
        public const int THREAD_SET_THREAD_TOKEN = (0x0080);

        [NativeTypeName("#define THREAD_IMPERSONATE (0x0100)")]
        public const int THREAD_IMPERSONATE = (0x0100);

        [NativeTypeName("#define THREAD_DIRECT_IMPERSONATION (0x0200)")]
        public const int THREAD_DIRECT_IMPERSONATION = (0x0200);

        [NativeTypeName("#define THREAD_SET_LIMITED_INFORMATION (0x0400)")]
        public const int THREAD_SET_LIMITED_INFORMATION = (0x0400);

        [NativeTypeName("#define THREAD_QUERY_LIMITED_INFORMATION (0x0800)")]
        public const int THREAD_QUERY_LIMITED_INFORMATION = (0x0800);

        [NativeTypeName("#define THREAD_RESUME (0x1000)")]
        public const int THREAD_RESUME = (0x1000);

        [NativeTypeName("#define THREAD_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | \\\r\n                                   0xFFFF)")]
        public const int THREAD_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0xFFFF);

        [NativeTypeName("#define JOB_OBJECT_ASSIGN_PROCESS (0x0001)")]
        public const int JOB_OBJECT_ASSIGN_PROCESS = (0x0001);

        [NativeTypeName("#define JOB_OBJECT_SET_ATTRIBUTES (0x0002)")]
        public const int JOB_OBJECT_SET_ATTRIBUTES = (0x0002);

        [NativeTypeName("#define JOB_OBJECT_QUERY (0x0004)")]
        public const int JOB_OBJECT_QUERY = (0x0004);

        [NativeTypeName("#define JOB_OBJECT_TERMINATE (0x0008)")]
        public const int JOB_OBJECT_TERMINATE = (0x0008);

        [NativeTypeName("#define JOB_OBJECT_SET_SECURITY_ATTRIBUTES (0x0010)")]
        public const int JOB_OBJECT_SET_SECURITY_ATTRIBUTES = (0x0010);

        [NativeTypeName("#define JOB_OBJECT_IMPERSONATE (0x0020)")]
        public const int JOB_OBJECT_IMPERSONATE = (0x0020);

        [NativeTypeName("#define JOB_OBJECT_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | \\\r\n                                        0x3F )")]
        public const int JOB_OBJECT_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x3F);

        [NativeTypeName("#define FLS_MAXIMUM_AVAILABLE 4080")]
        public const int FLS_MAXIMUM_AVAILABLE = 4080;

        [NativeTypeName("#define TLS_MINIMUM_AVAILABLE 64")]
        public const int TLS_MINIMUM_AVAILABLE = 64;

        [NativeTypeName("#define THREAD_DYNAMIC_CODE_ALLOW 1")]
        public const int THREAD_DYNAMIC_CODE_ALLOW = 1;

        [NativeTypeName("#define THREAD_BASE_PRIORITY_LOWRT 15")]
        public const int THREAD_BASE_PRIORITY_LOWRT = 15;

        [NativeTypeName("#define THREAD_BASE_PRIORITY_MAX 2")]
        public const int THREAD_BASE_PRIORITY_MAX = 2;

        [NativeTypeName("#define THREAD_BASE_PRIORITY_MIN (-2)")]
        public const int THREAD_BASE_PRIORITY_MIN = (-2);

        [NativeTypeName("#define THREAD_BASE_PRIORITY_IDLE (-15)")]
        public const int THREAD_BASE_PRIORITY_IDLE = (-15);

        [NativeTypeName("#define MEMORY_PRIORITY_LOWEST 0")]
        public const int MEMORY_PRIORITY_LOWEST = 0;

        [NativeTypeName("#define MEMORY_PRIORITY_VERY_LOW 1")]
        public const int MEMORY_PRIORITY_VERY_LOW = 1;

        [NativeTypeName("#define MEMORY_PRIORITY_LOW 2")]
        public const int MEMORY_PRIORITY_LOW = 2;

        [NativeTypeName("#define MEMORY_PRIORITY_MEDIUM 3")]
        public const int MEMORY_PRIORITY_MEDIUM = 3;

        [NativeTypeName("#define MEMORY_PRIORITY_BELOW_NORMAL 4")]
        public const int MEMORY_PRIORITY_BELOW_NORMAL = 4;

        [NativeTypeName("#define MEMORY_PRIORITY_NORMAL 5")]
        public const int MEMORY_PRIORITY_NORMAL = 5;

        [NativeTypeName("#define DYNAMIC_EH_CONTINUATION_TARGET_ADD (0x00000001)")]
        public const int DYNAMIC_EH_CONTINUATION_TARGET_ADD = (0x00000001);

        [NativeTypeName("#define DYNAMIC_EH_CONTINUATION_TARGET_PROCESSED (0x00000002)")]
        public const int DYNAMIC_EH_CONTINUATION_TARGET_PROCESSED = (0x00000002);

        [NativeTypeName("#define QUOTA_LIMITS_HARDWS_MIN_ENABLE 0x00000001")]
        public const int QUOTA_LIMITS_HARDWS_MIN_ENABLE = 0x00000001;

        [NativeTypeName("#define QUOTA_LIMITS_HARDWS_MIN_DISABLE 0x00000002")]
        public const int QUOTA_LIMITS_HARDWS_MIN_DISABLE = 0x00000002;

        [NativeTypeName("#define QUOTA_LIMITS_HARDWS_MAX_ENABLE 0x00000004")]
        public const int QUOTA_LIMITS_HARDWS_MAX_ENABLE = 0x00000004;

        [NativeTypeName("#define QUOTA_LIMITS_HARDWS_MAX_DISABLE 0x00000008")]
        public const int QUOTA_LIMITS_HARDWS_MAX_DISABLE = 0x00000008;

        [NativeTypeName("#define QUOTA_LIMITS_USE_DEFAULT_LIMITS 0x00000010")]
        public const int QUOTA_LIMITS_USE_DEFAULT_LIMITS = 0x00000010;

        [NativeTypeName("#define MAX_HW_COUNTERS 16")]
        public const int MAX_HW_COUNTERS = 16;

        [NativeTypeName("#define THREAD_PROFILING_FLAG_DISPATCH 0x00000001")]
        public const int THREAD_PROFILING_FLAG_DISPATCH = 0x00000001;

        [NativeTypeName("#define JOB_OBJECT_NET_RATE_CONTROL_MAX_DSCP_TAG 64")]
        public const int JOB_OBJECT_NET_RATE_CONTROL_MAX_DSCP_TAG = 64;

        [NativeTypeName("#define JOB_OBJECT_TERMINATE_AT_END_OF_JOB 0")]
        public const int JOB_OBJECT_TERMINATE_AT_END_OF_JOB = 0;

        [NativeTypeName("#define JOB_OBJECT_POST_AT_END_OF_JOB 1")]
        public const int JOB_OBJECT_POST_AT_END_OF_JOB = 1;

        [NativeTypeName("#define JOB_OBJECT_MSG_END_OF_JOB_TIME 1")]
        public const int JOB_OBJECT_MSG_END_OF_JOB_TIME = 1;

        [NativeTypeName("#define JOB_OBJECT_MSG_END_OF_PROCESS_TIME 2")]
        public const int JOB_OBJECT_MSG_END_OF_PROCESS_TIME = 2;

        [NativeTypeName("#define JOB_OBJECT_MSG_ACTIVE_PROCESS_LIMIT 3")]
        public const int JOB_OBJECT_MSG_ACTIVE_PROCESS_LIMIT = 3;

        [NativeTypeName("#define JOB_OBJECT_MSG_ACTIVE_PROCESS_ZERO 4")]
        public const int JOB_OBJECT_MSG_ACTIVE_PROCESS_ZERO = 4;

        [NativeTypeName("#define JOB_OBJECT_MSG_NEW_PROCESS 6")]
        public const int JOB_OBJECT_MSG_NEW_PROCESS = 6;

        [NativeTypeName("#define JOB_OBJECT_MSG_EXIT_PROCESS 7")]
        public const int JOB_OBJECT_MSG_EXIT_PROCESS = 7;

        [NativeTypeName("#define JOB_OBJECT_MSG_ABNORMAL_EXIT_PROCESS 8")]
        public const int JOB_OBJECT_MSG_ABNORMAL_EXIT_PROCESS = 8;

        [NativeTypeName("#define JOB_OBJECT_MSG_PROCESS_MEMORY_LIMIT 9")]
        public const int JOB_OBJECT_MSG_PROCESS_MEMORY_LIMIT = 9;

        [NativeTypeName("#define JOB_OBJECT_MSG_JOB_MEMORY_LIMIT 10")]
        public const int JOB_OBJECT_MSG_JOB_MEMORY_LIMIT = 10;

        [NativeTypeName("#define JOB_OBJECT_MSG_NOTIFICATION_LIMIT 11")]
        public const int JOB_OBJECT_MSG_NOTIFICATION_LIMIT = 11;

        [NativeTypeName("#define JOB_OBJECT_MSG_JOB_CYCLE_TIME_LIMIT 12")]
        public const int JOB_OBJECT_MSG_JOB_CYCLE_TIME_LIMIT = 12;

        [NativeTypeName("#define JOB_OBJECT_MSG_SILO_TERMINATED 13")]
        public const int JOB_OBJECT_MSG_SILO_TERMINATED = 13;

        [NativeTypeName("#define JOB_OBJECT_MSG_MINIMUM 1")]
        public const int JOB_OBJECT_MSG_MINIMUM = 1;

        [NativeTypeName("#define JOB_OBJECT_MSG_MAXIMUM 13")]
        public const int JOB_OBJECT_MSG_MAXIMUM = 13;

        [NativeTypeName("#define JOB_OBJECT_VALID_COMPLETION_FILTER (((1UL << (JOB_OBJECT_MSG_MAXIMUM + 1)) - 1) - \\\r\n     ((1UL << JOB_OBJECT_MSG_MINIMUM) - 1))")]
        public const uint JOB_OBJECT_VALID_COMPLETION_FILTER = (((1U << (13 + 1)) - 1) - ((1U << 1) - 1));

        [NativeTypeName("#define JOB_OBJECT_LIMIT_WORKINGSET 0x00000001")]
        public const int JOB_OBJECT_LIMIT_WORKINGSET = 0x00000001;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_PROCESS_TIME 0x00000002")]
        public const int JOB_OBJECT_LIMIT_PROCESS_TIME = 0x00000002;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_JOB_TIME 0x00000004")]
        public const int JOB_OBJECT_LIMIT_JOB_TIME = 0x00000004;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_ACTIVE_PROCESS 0x00000008")]
        public const int JOB_OBJECT_LIMIT_ACTIVE_PROCESS = 0x00000008;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_AFFINITY 0x00000010")]
        public const int JOB_OBJECT_LIMIT_AFFINITY = 0x00000010;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_PRIORITY_CLASS 0x00000020")]
        public const int JOB_OBJECT_LIMIT_PRIORITY_CLASS = 0x00000020;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_PRESERVE_JOB_TIME 0x00000040")]
        public const int JOB_OBJECT_LIMIT_PRESERVE_JOB_TIME = 0x00000040;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_SCHEDULING_CLASS 0x00000080")]
        public const int JOB_OBJECT_LIMIT_SCHEDULING_CLASS = 0x00000080;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_PROCESS_MEMORY 0x00000100")]
        public const int JOB_OBJECT_LIMIT_PROCESS_MEMORY = 0x00000100;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_JOB_MEMORY 0x00000200")]
        public const int JOB_OBJECT_LIMIT_JOB_MEMORY = 0x00000200;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH JOB_OBJECT_LIMIT_JOB_MEMORY")]
        public const int JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH = 0x00000200;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_DIE_ON_UNHANDLED_EXCEPTION 0x00000400")]
        public const int JOB_OBJECT_LIMIT_DIE_ON_UNHANDLED_EXCEPTION = 0x00000400;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_BREAKAWAY_OK 0x00000800")]
        public const int JOB_OBJECT_LIMIT_BREAKAWAY_OK = 0x00000800;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_SILENT_BREAKAWAY_OK 0x00001000")]
        public const int JOB_OBJECT_LIMIT_SILENT_BREAKAWAY_OK = 0x00001000;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE 0x00002000")]
        public const int JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE = 0x00002000;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_SUBSET_AFFINITY 0x00004000")]
        public const int JOB_OBJECT_LIMIT_SUBSET_AFFINITY = 0x00004000;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_JOB_MEMORY_LOW 0x00008000")]
        public const int JOB_OBJECT_LIMIT_JOB_MEMORY_LOW = 0x00008000;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_JOB_READ_BYTES 0x00010000")]
        public const int JOB_OBJECT_LIMIT_JOB_READ_BYTES = 0x00010000;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_JOB_WRITE_BYTES 0x00020000")]
        public const int JOB_OBJECT_LIMIT_JOB_WRITE_BYTES = 0x00020000;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_RATE_CONTROL 0x00040000")]
        public const int JOB_OBJECT_LIMIT_RATE_CONTROL = 0x00040000;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_CPU_RATE_CONTROL JOB_OBJECT_LIMIT_RATE_CONTROL")]
        public const int JOB_OBJECT_LIMIT_CPU_RATE_CONTROL = 0x00040000;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_IO_RATE_CONTROL 0x00080000")]
        public const int JOB_OBJECT_LIMIT_IO_RATE_CONTROL = 0x00080000;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_NET_RATE_CONTROL 0x00100000")]
        public const int JOB_OBJECT_LIMIT_NET_RATE_CONTROL = 0x00100000;

        [NativeTypeName("#define JOB_OBJECT_LIMIT_VALID_FLAGS 0x0007ffff")]
        public const int JOB_OBJECT_LIMIT_VALID_FLAGS = 0x0007ffff;

        [NativeTypeName("#define JOB_OBJECT_BASIC_LIMIT_VALID_FLAGS 0x000000ff")]
        public const int JOB_OBJECT_BASIC_LIMIT_VALID_FLAGS = 0x000000ff;

        [NativeTypeName("#define JOB_OBJECT_EXTENDED_LIMIT_VALID_FLAGS 0x00007fff")]
        public const int JOB_OBJECT_EXTENDED_LIMIT_VALID_FLAGS = 0x00007fff;

        [NativeTypeName("#define JOB_OBJECT_NOTIFICATION_LIMIT_VALID_FLAGS (JOB_OBJECT_LIMIT_JOB_READ_BYTES | \\\r\n     JOB_OBJECT_LIMIT_JOB_WRITE_BYTES | \\\r\n     JOB_OBJECT_LIMIT_JOB_TIME | \\\r\n     JOB_OBJECT_LIMIT_JOB_MEMORY_LOW | \\\r\n     JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH | \\\r\n     JOB_OBJECT_LIMIT_CPU_RATE_CONTROL | \\\r\n     JOB_OBJECT_LIMIT_IO_RATE_CONTROL | \\\r\n     JOB_OBJECT_LIMIT_NET_RATE_CONTROL)")]
        public const int JOB_OBJECT_NOTIFICATION_LIMIT_VALID_FLAGS = (0x00010000 | 0x00020000 | 0x00000004 | 0x00008000 | 0x00000200 | 0x00040000 | 0x00080000 | 0x00100000);

        [NativeTypeName("#define JOB_OBJECT_UILIMIT_NONE 0x00000000")]
        public const int JOB_OBJECT_UILIMIT_NONE = 0x00000000;

        [NativeTypeName("#define JOB_OBJECT_UILIMIT_HANDLES 0x00000001")]
        public const int JOB_OBJECT_UILIMIT_HANDLES = 0x00000001;

        [NativeTypeName("#define JOB_OBJECT_UILIMIT_READCLIPBOARD 0x00000002")]
        public const int JOB_OBJECT_UILIMIT_READCLIPBOARD = 0x00000002;

        [NativeTypeName("#define JOB_OBJECT_UILIMIT_WRITECLIPBOARD 0x00000004")]
        public const int JOB_OBJECT_UILIMIT_WRITECLIPBOARD = 0x00000004;

        [NativeTypeName("#define JOB_OBJECT_UILIMIT_SYSTEMPARAMETERS 0x00000008")]
        public const int JOB_OBJECT_UILIMIT_SYSTEMPARAMETERS = 0x00000008;

        [NativeTypeName("#define JOB_OBJECT_UILIMIT_DISPLAYSETTINGS 0x00000010")]
        public const int JOB_OBJECT_UILIMIT_DISPLAYSETTINGS = 0x00000010;

        [NativeTypeName("#define JOB_OBJECT_UILIMIT_GLOBALATOMS 0x00000020")]
        public const int JOB_OBJECT_UILIMIT_GLOBALATOMS = 0x00000020;

        [NativeTypeName("#define JOB_OBJECT_UILIMIT_DESKTOP 0x00000040")]
        public const int JOB_OBJECT_UILIMIT_DESKTOP = 0x00000040;

        [NativeTypeName("#define JOB_OBJECT_UILIMIT_EXITWINDOWS 0x00000080")]
        public const int JOB_OBJECT_UILIMIT_EXITWINDOWS = 0x00000080;

        [NativeTypeName("#define JOB_OBJECT_UILIMIT_ALL 0x000000FF")]
        public const int JOB_OBJECT_UILIMIT_ALL = 0x000000FF;

        [NativeTypeName("#define JOB_OBJECT_UI_VALID_FLAGS 0x000000FF")]
        public const int JOB_OBJECT_UI_VALID_FLAGS = 0x000000FF;

        [NativeTypeName("#define JOB_OBJECT_SECURITY_NO_ADMIN 0x00000001")]
        public const int JOB_OBJECT_SECURITY_NO_ADMIN = 0x00000001;

        [NativeTypeName("#define JOB_OBJECT_SECURITY_RESTRICTED_TOKEN 0x00000002")]
        public const int JOB_OBJECT_SECURITY_RESTRICTED_TOKEN = 0x00000002;

        [NativeTypeName("#define JOB_OBJECT_SECURITY_ONLY_TOKEN 0x00000004")]
        public const int JOB_OBJECT_SECURITY_ONLY_TOKEN = 0x00000004;

        [NativeTypeName("#define JOB_OBJECT_SECURITY_FILTER_TOKENS 0x00000008")]
        public const int JOB_OBJECT_SECURITY_FILTER_TOKENS = 0x00000008;

        [NativeTypeName("#define JOB_OBJECT_SECURITY_VALID_FLAGS 0x0000000f")]
        public const int JOB_OBJECT_SECURITY_VALID_FLAGS = 0x0000000f;

        [NativeTypeName("#define JOB_OBJECT_CPU_RATE_CONTROL_ENABLE 0x1")]
        public const int JOB_OBJECT_CPU_RATE_CONTROL_ENABLE = 0x1;

        [NativeTypeName("#define JOB_OBJECT_CPU_RATE_CONTROL_WEIGHT_BASED 0x2")]
        public const int JOB_OBJECT_CPU_RATE_CONTROL_WEIGHT_BASED = 0x2;

        [NativeTypeName("#define JOB_OBJECT_CPU_RATE_CONTROL_HARD_CAP 0x4")]
        public const int JOB_OBJECT_CPU_RATE_CONTROL_HARD_CAP = 0x4;

        [NativeTypeName("#define JOB_OBJECT_CPU_RATE_CONTROL_NOTIFY 0x8")]
        public const int JOB_OBJECT_CPU_RATE_CONTROL_NOTIFY = 0x8;

        [NativeTypeName("#define JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE 0x10")]
        public const int JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE = 0x10;

        [NativeTypeName("#define JOB_OBJECT_CPU_RATE_CONTROL_VALID_FLAGS 0x1f")]
        public const int JOB_OBJECT_CPU_RATE_CONTROL_VALID_FLAGS = 0x1f;

        [NativeTypeName("#define EVENT_MODIFY_STATE 0x0002")]
        public const int EVENT_MODIFY_STATE = 0x0002;

        [NativeTypeName("#define EVENT_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|0x3)")]
        public const int EVENT_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x3);

        [NativeTypeName("#define MUTANT_QUERY_STATE 0x0001")]
        public const int MUTANT_QUERY_STATE = 0x0001;

        [NativeTypeName("#define MUTANT_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|\\\r\n                          MUTANT_QUERY_STATE)")]
        public const int MUTANT_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x0001);

        [NativeTypeName("#define SEMAPHORE_MODIFY_STATE 0x0002")]
        public const int SEMAPHORE_MODIFY_STATE = 0x0002;

        [NativeTypeName("#define SEMAPHORE_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|0x3)")]
        public const int SEMAPHORE_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x3);

        [NativeTypeName("#define TIMER_QUERY_STATE 0x0001")]
        public const int TIMER_QUERY_STATE = 0x0001;

        [NativeTypeName("#define TIMER_MODIFY_STATE 0x0002")]
        public const int TIMER_MODIFY_STATE = 0x0002;

        [NativeTypeName("#define TIMER_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|\\\r\n                          TIMER_QUERY_STATE|TIMER_MODIFY_STATE)")]
        public const int TIMER_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x0001 | 0x0002);

        [NativeTypeName("#define TIME_ZONE_ID_UNKNOWN 0")]
        public const int TIME_ZONE_ID_UNKNOWN = 0;

        [NativeTypeName("#define TIME_ZONE_ID_STANDARD 1")]
        public const int TIME_ZONE_ID_STANDARD = 1;

        [NativeTypeName("#define TIME_ZONE_ID_DAYLIGHT 2")]
        public const int TIME_ZONE_ID_DAYLIGHT = 2;

        [NativeTypeName("#define LTP_PC_SMT 0x1")]
        public const int LTP_PC_SMT = 0x1;

        [NativeTypeName("#define CACHE_FULLY_ASSOCIATIVE 0xFF")]
        public const int CACHE_FULLY_ASSOCIATIVE = 0xFF;

        [NativeTypeName("#define SYSTEM_CPU_SET_INFORMATION_PARKED 0x1")]
        public const int SYSTEM_CPU_SET_INFORMATION_PARKED = 0x1;

        [NativeTypeName("#define SYSTEM_CPU_SET_INFORMATION_ALLOCATED 0x2")]
        public const int SYSTEM_CPU_SET_INFORMATION_ALLOCATED = 0x2;

        [NativeTypeName("#define SYSTEM_CPU_SET_INFORMATION_ALLOCATED_TO_TARGET_PROCESS 0x4")]
        public const int SYSTEM_CPU_SET_INFORMATION_ALLOCATED_TO_TARGET_PROCESS = 0x4;

        [NativeTypeName("#define SYSTEM_CPU_SET_INFORMATION_REALTIME 0x8")]
        public const int SYSTEM_CPU_SET_INFORMATION_REALTIME = 0x8;

        [NativeTypeName("#define PROCESSOR_INTEL_386 386")]
        public const int PROCESSOR_INTEL_386 = 386;

        [NativeTypeName("#define PROCESSOR_INTEL_486 486")]
        public const int PROCESSOR_INTEL_486 = 486;

        [NativeTypeName("#define PROCESSOR_INTEL_PENTIUM 586")]
        public const int PROCESSOR_INTEL_PENTIUM = 586;

        [NativeTypeName("#define PROCESSOR_INTEL_IA64 2200")]
        public const int PROCESSOR_INTEL_IA64 = 2200;

        [NativeTypeName("#define PROCESSOR_AMD_X8664 8664")]
        public const int PROCESSOR_AMD_X8664 = 8664;

        [NativeTypeName("#define PROCESSOR_MIPS_R4000 4000")]
        public const int PROCESSOR_MIPS_R4000 = 4000;

        [NativeTypeName("#define PROCESSOR_ALPHA_21064 21064")]
        public const int PROCESSOR_ALPHA_21064 = 21064;

        [NativeTypeName("#define PROCESSOR_PPC_601 601")]
        public const int PROCESSOR_PPC_601 = 601;

        [NativeTypeName("#define PROCESSOR_PPC_603 603")]
        public const int PROCESSOR_PPC_603 = 603;

        [NativeTypeName("#define PROCESSOR_PPC_604 604")]
        public const int PROCESSOR_PPC_604 = 604;

        [NativeTypeName("#define PROCESSOR_PPC_620 620")]
        public const int PROCESSOR_PPC_620 = 620;

        [NativeTypeName("#define PROCESSOR_HITACHI_SH3 10003")]
        public const int PROCESSOR_HITACHI_SH3 = 10003;

        [NativeTypeName("#define PROCESSOR_HITACHI_SH3E 10004")]
        public const int PROCESSOR_HITACHI_SH3E = 10004;

        [NativeTypeName("#define PROCESSOR_HITACHI_SH4 10005")]
        public const int PROCESSOR_HITACHI_SH4 = 10005;

        [NativeTypeName("#define PROCESSOR_MOTOROLA_821 821")]
        public const int PROCESSOR_MOTOROLA_821 = 821;

        [NativeTypeName("#define PROCESSOR_SHx_SH3 103")]
        public const int PROCESSOR_SHx_SH3 = 103;

        [NativeTypeName("#define PROCESSOR_SHx_SH4 104")]
        public const int PROCESSOR_SHx_SH4 = 104;

        [NativeTypeName("#define PROCESSOR_STRONGARM 2577")]
        public const int PROCESSOR_STRONGARM = 2577;

        [NativeTypeName("#define PROCESSOR_ARM720 1824")]
        public const int PROCESSOR_ARM720 = 1824;

        [NativeTypeName("#define PROCESSOR_ARM820 2080")]
        public const int PROCESSOR_ARM820 = 2080;

        [NativeTypeName("#define PROCESSOR_ARM920 2336")]
        public const int PROCESSOR_ARM920 = 2336;

        [NativeTypeName("#define PROCESSOR_ARM_7TDMI 70001")]
        public const int PROCESSOR_ARM_7TDMI = 70001;

        [NativeTypeName("#define PROCESSOR_OPTIL 0x494f")]
        public const int PROCESSOR_OPTIL = 0x494f;

        [NativeTypeName("#define PROCESSOR_ARCHITECTURE_INTEL 0")]
        public const int PROCESSOR_ARCHITECTURE_INTEL = 0;

        [NativeTypeName("#define PROCESSOR_ARCHITECTURE_MIPS 1")]
        public const int PROCESSOR_ARCHITECTURE_MIPS = 1;

        [NativeTypeName("#define PROCESSOR_ARCHITECTURE_ALPHA 2")]
        public const int PROCESSOR_ARCHITECTURE_ALPHA = 2;

        [NativeTypeName("#define PROCESSOR_ARCHITECTURE_PPC 3")]
        public const int PROCESSOR_ARCHITECTURE_PPC = 3;

        [NativeTypeName("#define PROCESSOR_ARCHITECTURE_SHX 4")]
        public const int PROCESSOR_ARCHITECTURE_SHX = 4;

        [NativeTypeName("#define PROCESSOR_ARCHITECTURE_ARM 5")]
        public const int PROCESSOR_ARCHITECTURE_ARM = 5;

        [NativeTypeName("#define PROCESSOR_ARCHITECTURE_IA64 6")]
        public const int PROCESSOR_ARCHITECTURE_IA64 = 6;

        [NativeTypeName("#define PROCESSOR_ARCHITECTURE_ALPHA64 7")]
        public const int PROCESSOR_ARCHITECTURE_ALPHA64 = 7;

        [NativeTypeName("#define PROCESSOR_ARCHITECTURE_MSIL 8")]
        public const int PROCESSOR_ARCHITECTURE_MSIL = 8;

        [NativeTypeName("#define PROCESSOR_ARCHITECTURE_AMD64 9")]
        public const int PROCESSOR_ARCHITECTURE_AMD64 = 9;

        [NativeTypeName("#define PROCESSOR_ARCHITECTURE_IA32_ON_WIN64 10")]
        public const int PROCESSOR_ARCHITECTURE_IA32_ON_WIN64 = 10;

        [NativeTypeName("#define PROCESSOR_ARCHITECTURE_NEUTRAL 11")]
        public const int PROCESSOR_ARCHITECTURE_NEUTRAL = 11;

        [NativeTypeName("#define PROCESSOR_ARCHITECTURE_ARM64 12")]
        public const int PROCESSOR_ARCHITECTURE_ARM64 = 12;

        [NativeTypeName("#define PROCESSOR_ARCHITECTURE_ARM32_ON_WIN64 13")]
        public const int PROCESSOR_ARCHITECTURE_ARM32_ON_WIN64 = 13;

        [NativeTypeName("#define PROCESSOR_ARCHITECTURE_IA32_ON_ARM64 14")]
        public const int PROCESSOR_ARCHITECTURE_IA32_ON_ARM64 = 14;

        [NativeTypeName("#define PROCESSOR_ARCHITECTURE_UNKNOWN 0xFFFF")]
        public const int PROCESSOR_ARCHITECTURE_UNKNOWN = 0xFFFF;

        [NativeTypeName("#define PF_FLOATING_POINT_PRECISION_ERRATA 0")]
        public const int PF_FLOATING_POINT_PRECISION_ERRATA = 0;

        [NativeTypeName("#define PF_FLOATING_POINT_EMULATED 1")]
        public const int PF_FLOATING_POINT_EMULATED = 1;

        [NativeTypeName("#define PF_COMPARE_EXCHANGE_DOUBLE 2")]
        public const int PF_COMPARE_EXCHANGE_DOUBLE = 2;

        [NativeTypeName("#define PF_MMX_INSTRUCTIONS_AVAILABLE 3")]
        public const int PF_MMX_INSTRUCTIONS_AVAILABLE = 3;

        [NativeTypeName("#define PF_PPC_MOVEMEM_64BIT_OK 4")]
        public const int PF_PPC_MOVEMEM_64BIT_OK = 4;

        [NativeTypeName("#define PF_ALPHA_BYTE_INSTRUCTIONS 5")]
        public const int PF_ALPHA_BYTE_INSTRUCTIONS = 5;

        [NativeTypeName("#define PF_XMMI_INSTRUCTIONS_AVAILABLE 6")]
        public const int PF_XMMI_INSTRUCTIONS_AVAILABLE = 6;

        [NativeTypeName("#define PF_3DNOW_INSTRUCTIONS_AVAILABLE 7")]
        public const int PF_3DNOW_INSTRUCTIONS_AVAILABLE = 7;

        [NativeTypeName("#define PF_RDTSC_INSTRUCTION_AVAILABLE 8")]
        public const int PF_RDTSC_INSTRUCTION_AVAILABLE = 8;

        [NativeTypeName("#define PF_PAE_ENABLED 9")]
        public const int PF_PAE_ENABLED = 9;

        [NativeTypeName("#define PF_XMMI64_INSTRUCTIONS_AVAILABLE 10")]
        public const int PF_XMMI64_INSTRUCTIONS_AVAILABLE = 10;

        [NativeTypeName("#define PF_SSE_DAZ_MODE_AVAILABLE 11")]
        public const int PF_SSE_DAZ_MODE_AVAILABLE = 11;

        [NativeTypeName("#define PF_NX_ENABLED 12")]
        public const int PF_NX_ENABLED = 12;

        [NativeTypeName("#define PF_SSE3_INSTRUCTIONS_AVAILABLE 13")]
        public const int PF_SSE3_INSTRUCTIONS_AVAILABLE = 13;

        [NativeTypeName("#define PF_COMPARE_EXCHANGE128 14")]
        public const int PF_COMPARE_EXCHANGE128 = 14;

        [NativeTypeName("#define PF_COMPARE64_EXCHANGE128 15")]
        public const int PF_COMPARE64_EXCHANGE128 = 15;

        [NativeTypeName("#define PF_CHANNELS_ENABLED 16")]
        public const int PF_CHANNELS_ENABLED = 16;

        [NativeTypeName("#define PF_XSAVE_ENABLED 17")]
        public const int PF_XSAVE_ENABLED = 17;

        [NativeTypeName("#define PF_ARM_VFP_32_REGISTERS_AVAILABLE 18")]
        public const int PF_ARM_VFP_32_REGISTERS_AVAILABLE = 18;

        [NativeTypeName("#define PF_ARM_NEON_INSTRUCTIONS_AVAILABLE 19")]
        public const int PF_ARM_NEON_INSTRUCTIONS_AVAILABLE = 19;

        [NativeTypeName("#define PF_SECOND_LEVEL_ADDRESS_TRANSLATION 20")]
        public const int PF_SECOND_LEVEL_ADDRESS_TRANSLATION = 20;

        [NativeTypeName("#define PF_VIRT_FIRMWARE_ENABLED 21")]
        public const int PF_VIRT_FIRMWARE_ENABLED = 21;

        [NativeTypeName("#define PF_RDWRFSGSBASE_AVAILABLE 22")]
        public const int PF_RDWRFSGSBASE_AVAILABLE = 22;

        [NativeTypeName("#define PF_FASTFAIL_AVAILABLE 23")]
        public const int PF_FASTFAIL_AVAILABLE = 23;

        [NativeTypeName("#define PF_ARM_DIVIDE_INSTRUCTION_AVAILABLE 24")]
        public const int PF_ARM_DIVIDE_INSTRUCTION_AVAILABLE = 24;

        [NativeTypeName("#define PF_ARM_64BIT_LOADSTORE_ATOMIC 25")]
        public const int PF_ARM_64BIT_LOADSTORE_ATOMIC = 25;

        [NativeTypeName("#define PF_ARM_EXTERNAL_CACHE_AVAILABLE 26")]
        public const int PF_ARM_EXTERNAL_CACHE_AVAILABLE = 26;

        [NativeTypeName("#define PF_ARM_FMAC_INSTRUCTIONS_AVAILABLE 27")]
        public const int PF_ARM_FMAC_INSTRUCTIONS_AVAILABLE = 27;

        [NativeTypeName("#define PF_RDRAND_INSTRUCTION_AVAILABLE 28")]
        public const int PF_RDRAND_INSTRUCTION_AVAILABLE = 28;

        [NativeTypeName("#define PF_ARM_V8_INSTRUCTIONS_AVAILABLE 29")]
        public const int PF_ARM_V8_INSTRUCTIONS_AVAILABLE = 29;

        [NativeTypeName("#define PF_ARM_V8_CRYPTO_INSTRUCTIONS_AVAILABLE 30")]
        public const int PF_ARM_V8_CRYPTO_INSTRUCTIONS_AVAILABLE = 30;

        [NativeTypeName("#define PF_ARM_V8_CRC32_INSTRUCTIONS_AVAILABLE 31")]
        public const int PF_ARM_V8_CRC32_INSTRUCTIONS_AVAILABLE = 31;

        [NativeTypeName("#define PF_RDTSCP_INSTRUCTION_AVAILABLE 32")]
        public const int PF_RDTSCP_INSTRUCTION_AVAILABLE = 32;

        [NativeTypeName("#define PF_RDPID_INSTRUCTION_AVAILABLE 33")]
        public const int PF_RDPID_INSTRUCTION_AVAILABLE = 33;

        [NativeTypeName("#define PF_ARM_V81_ATOMIC_INSTRUCTIONS_AVAILABLE 34")]
        public const int PF_ARM_V81_ATOMIC_INSTRUCTIONS_AVAILABLE = 34;

        [NativeTypeName("#define PF_MONITORX_INSTRUCTION_AVAILABLE 35")]
        public const int PF_MONITORX_INSTRUCTION_AVAILABLE = 35;

        [NativeTypeName("#define PF_SSSE3_INSTRUCTIONS_AVAILABLE 36")]
        public const int PF_SSSE3_INSTRUCTIONS_AVAILABLE = 36;

        [NativeTypeName("#define PF_SSE4_1_INSTRUCTIONS_AVAILABLE 37")]
        public const int PF_SSE4_1_INSTRUCTIONS_AVAILABLE = 37;

        [NativeTypeName("#define PF_SSE4_2_INSTRUCTIONS_AVAILABLE 38")]
        public const int PF_SSE4_2_INSTRUCTIONS_AVAILABLE = 38;

        [NativeTypeName("#define PF_AVX_INSTRUCTIONS_AVAILABLE 39")]
        public const int PF_AVX_INSTRUCTIONS_AVAILABLE = 39;

        [NativeTypeName("#define PF_AVX2_INSTRUCTIONS_AVAILABLE 40")]
        public const int PF_AVX2_INSTRUCTIONS_AVAILABLE = 40;

        [NativeTypeName("#define PF_AVX512F_INSTRUCTIONS_AVAILABLE 41")]
        public const int PF_AVX512F_INSTRUCTIONS_AVAILABLE = 41;

        [NativeTypeName("#define XSTATE_LEGACY_FLOATING_POINT (0)")]
        public const int XSTATE_LEGACY_FLOATING_POINT = (0);

        [NativeTypeName("#define XSTATE_LEGACY_SSE (1)")]
        public const int XSTATE_LEGACY_SSE = (1);

        [NativeTypeName("#define XSTATE_GSSE (2)")]
        public const int XSTATE_GSSE = (2);

        [NativeTypeName("#define XSTATE_AVX (XSTATE_GSSE)")]
        public const int XSTATE_AVX = ((2));

        [NativeTypeName("#define XSTATE_MPX_BNDREGS (3)")]
        public const int XSTATE_MPX_BNDREGS = (3);

        [NativeTypeName("#define XSTATE_MPX_BNDCSR (4)")]
        public const int XSTATE_MPX_BNDCSR = (4);

        [NativeTypeName("#define XSTATE_AVX512_KMASK (5)")]
        public const int XSTATE_AVX512_KMASK = (5);

        [NativeTypeName("#define XSTATE_AVX512_ZMM_H (6)")]
        public const int XSTATE_AVX512_ZMM_H = (6);

        [NativeTypeName("#define XSTATE_AVX512_ZMM (7)")]
        public const int XSTATE_AVX512_ZMM = (7);

        [NativeTypeName("#define XSTATE_IPT (8)")]
        public const int XSTATE_IPT = (8);

        [NativeTypeName("#define XSTATE_CET_U (11)")]
        public const int XSTATE_CET_U = (11);

        [NativeTypeName("#define XSTATE_LWP (62)")]
        public const int XSTATE_LWP = (62);

        [NativeTypeName("#define MAXIMUM_XSTATE_FEATURES (64)")]
        public const int MAXIMUM_XSTATE_FEATURES = (64);

        [NativeTypeName("#define XSTATE_MASK_LEGACY_FLOATING_POINT (1ui64 << (XSTATE_LEGACY_FLOATING_POINT))")]
        public const ulong XSTATE_MASK_LEGACY_FLOATING_POINT = (1UL << ((0)));

        [NativeTypeName("#define XSTATE_MASK_LEGACY_SSE (1ui64 << (XSTATE_LEGACY_SSE))")]
        public const ulong XSTATE_MASK_LEGACY_SSE = (1UL << ((1)));

        [NativeTypeName("#define XSTATE_MASK_LEGACY (XSTATE_MASK_LEGACY_FLOATING_POINT | \\\r\n                                             XSTATE_MASK_LEGACY_SSE)")]
        public const ulong XSTATE_MASK_LEGACY = ((1UL << ((0))) | (1UL << ((1))));

        [NativeTypeName("#define XSTATE_MASK_GSSE (1ui64 << (XSTATE_GSSE))")]
        public const ulong XSTATE_MASK_GSSE = (1UL << ((2)));

        [NativeTypeName("#define XSTATE_MASK_AVX (XSTATE_MASK_GSSE)")]
        public const ulong XSTATE_MASK_AVX = ((1UL << ((2))));

        [NativeTypeName("#define XSTATE_MASK_MPX ((1ui64 << (XSTATE_MPX_BNDREGS)) | \\\r\n                                             (1ui64 << (XSTATE_MPX_BNDCSR)))")]
        public const ulong XSTATE_MASK_MPX = ((1UL << ((3))) | (1UL << ((4))));

        [NativeTypeName("#define XSTATE_MASK_AVX512 ((1ui64 << (XSTATE_AVX512_KMASK)) | \\\r\n                                             (1ui64 << (XSTATE_AVX512_ZMM_H)) | \\\r\n                                             (1ui64 << (XSTATE_AVX512_ZMM)))")]
        public const ulong XSTATE_MASK_AVX512 = ((1UL << ((5))) | (1UL << ((6))) | (1UL << ((7))));

        [NativeTypeName("#define XSTATE_MASK_IPT (1ui64 << (XSTATE_IPT))")]
        public const ulong XSTATE_MASK_IPT = (1UL << ((8)));

        [NativeTypeName("#define XSTATE_MASK_CET_U (1ui64 << (XSTATE_CET_U))")]
        public const ulong XSTATE_MASK_CET_U = (1UL << ((11)));

        [NativeTypeName("#define XSTATE_MASK_LWP (1ui64 << (XSTATE_LWP))")]
        public const ulong XSTATE_MASK_LWP = (1UL << ((62)));

        [NativeTypeName("#define XSTATE_MASK_ALLOWED (XSTATE_MASK_LEGACY | \\\r\n                                             XSTATE_MASK_AVX | \\\r\n                                             XSTATE_MASK_MPX | \\\r\n                                             XSTATE_MASK_AVX512 | \\\r\n                                             XSTATE_MASK_IPT | \\\r\n                                             XSTATE_MASK_CET_U | \\\r\n                                             XSTATE_MASK_LWP)")]
        public const ulong XSTATE_MASK_ALLOWED = (((1UL << ((0))) | (1UL << ((1)))) | ((1UL << ((2)))) | ((1UL << ((3))) | (1UL << ((4)))) | ((1UL << ((5))) | (1UL << ((6))) | (1UL << ((7)))) | (1UL << ((8))) | (1UL << ((11))) | (1UL << ((62))));

        [NativeTypeName("#define XSTATE_MASK_PERSISTENT ((1ui64 << (XSTATE_MPX_BNDCSR)) | \\\r\n                                             XSTATE_MASK_LWP)")]
        public const ulong XSTATE_MASK_PERSISTENT = ((1UL << ((4))) | (1UL << ((62))));

        [NativeTypeName("#define XSTATE_MASK_USER_VISIBLE_SUPERVISOR (XSTATE_MASK_CET_U)")]
        public const ulong XSTATE_MASK_USER_VISIBLE_SUPERVISOR = ((1UL << ((11))));

        [NativeTypeName("#define XSTATE_COMPACTION_ENABLE (63)")]
        public const int XSTATE_COMPACTION_ENABLE = (63);

        [NativeTypeName("#define XSTATE_COMPACTION_ENABLE_MASK (1ui64 << (XSTATE_COMPACTION_ENABLE))")]
        public const ulong XSTATE_COMPACTION_ENABLE_MASK = (1UL << ((63)));

        [NativeTypeName("#define XSTATE_ALIGN_BIT (1)")]
        public const int XSTATE_ALIGN_BIT = (1);

        [NativeTypeName("#define XSTATE_ALIGN_MASK (1ui64 << (XSTATE_ALIGN_BIT))")]
        public const ulong XSTATE_ALIGN_MASK = (1UL << ((1)));

        [NativeTypeName("#define XSTATE_CONTROLFLAG_XSAVEOPT_MASK (1)")]
        public const int XSTATE_CONTROLFLAG_XSAVEOPT_MASK = (1);

        [NativeTypeName("#define XSTATE_CONTROLFLAG_XSAVEC_MASK (2)")]
        public const int XSTATE_CONTROLFLAG_XSAVEC_MASK = (2);

        [NativeTypeName("#define XSTATE_CONTROLFLAG_VALID_MASK (XSTATE_CONTROLFLAG_XSAVEOPT_MASK | \\\r\n                                             XSTATE_CONTROLFLAG_XSAVEC_MASK)")]
        public const int XSTATE_CONTROLFLAG_VALID_MASK = ((1) | (2));

        [NativeTypeName("#define CFG_CALL_TARGET_VALID (0x00000001)")]
        public const int CFG_CALL_TARGET_VALID = (0x00000001);

        [NativeTypeName("#define CFG_CALL_TARGET_PROCESSED (0x00000002)")]
        public const int CFG_CALL_TARGET_PROCESSED = (0x00000002);

        [NativeTypeName("#define CFG_CALL_TARGET_CONVERT_EXPORT_SUPPRESSED_TO_VALID (0x00000004)")]
        public const int CFG_CALL_TARGET_CONVERT_EXPORT_SUPPRESSED_TO_VALID = (0x00000004);

        [NativeTypeName("#define SECTION_QUERY 0x0001")]
        public const int SECTION_QUERY = 0x0001;

        [NativeTypeName("#define SECTION_MAP_WRITE 0x0002")]
        public const int SECTION_MAP_WRITE = 0x0002;

        [NativeTypeName("#define SECTION_MAP_READ 0x0004")]
        public const int SECTION_MAP_READ = 0x0004;

        [NativeTypeName("#define SECTION_MAP_EXECUTE 0x0008")]
        public const int SECTION_MAP_EXECUTE = 0x0008;

        [NativeTypeName("#define SECTION_EXTEND_SIZE 0x0010")]
        public const int SECTION_EXTEND_SIZE = 0x0010;

        [NativeTypeName("#define SECTION_MAP_EXECUTE_EXPLICIT 0x0020")]
        public const int SECTION_MAP_EXECUTE_EXPLICIT = 0x0020;

        [NativeTypeName("#define SECTION_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SECTION_QUERY|\\\r\n                            SECTION_MAP_WRITE |      \\\r\n                            SECTION_MAP_READ |       \\\r\n                            SECTION_MAP_EXECUTE |    \\\r\n                            SECTION_EXTEND_SIZE)")]
        public const int SECTION_ALL_ACCESS = ((0x000F0000) | 0x0001 | 0x0002 | 0x0004 | 0x0008 | 0x0010);

        [NativeTypeName("#define SESSION_QUERY_ACCESS 0x0001")]
        public const int SESSION_QUERY_ACCESS = 0x0001;

        [NativeTypeName("#define SESSION_MODIFY_ACCESS 0x0002")]
        public const int SESSION_MODIFY_ACCESS = 0x0002;

        [NativeTypeName("#define SESSION_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED |  \\\r\n                            SESSION_QUERY_ACCESS |             \\\r\n                            SESSION_MODIFY_ACCESS)")]
        public const int SESSION_ALL_ACCESS = ((0x000F0000) | 0x0001 | 0x0002);

        [NativeTypeName("#define PAGE_NOACCESS 0x01")]
        public const int PAGE_NOACCESS = 0x01;

        [NativeTypeName("#define PAGE_READONLY 0x02")]
        public const int PAGE_READONLY = 0x02;

        [NativeTypeName("#define PAGE_READWRITE 0x04")]
        public const int PAGE_READWRITE = 0x04;

        [NativeTypeName("#define PAGE_WRITECOPY 0x08")]
        public const int PAGE_WRITECOPY = 0x08;

        [NativeTypeName("#define PAGE_EXECUTE 0x10")]
        public const int PAGE_EXECUTE = 0x10;

        [NativeTypeName("#define PAGE_EXECUTE_READ 0x20")]
        public const int PAGE_EXECUTE_READ = 0x20;

        [NativeTypeName("#define PAGE_EXECUTE_READWRITE 0x40")]
        public const int PAGE_EXECUTE_READWRITE = 0x40;

        [NativeTypeName("#define PAGE_EXECUTE_WRITECOPY 0x80")]
        public const int PAGE_EXECUTE_WRITECOPY = 0x80;

        [NativeTypeName("#define PAGE_GUARD 0x100")]
        public const int PAGE_GUARD = 0x100;

        [NativeTypeName("#define PAGE_NOCACHE 0x200")]
        public const int PAGE_NOCACHE = 0x200;

        [NativeTypeName("#define PAGE_WRITECOMBINE 0x400")]
        public const int PAGE_WRITECOMBINE = 0x400;

        [NativeTypeName("#define PAGE_GRAPHICS_NOACCESS 0x0800")]
        public const int PAGE_GRAPHICS_NOACCESS = 0x0800;

        [NativeTypeName("#define PAGE_GRAPHICS_READONLY 0x1000")]
        public const int PAGE_GRAPHICS_READONLY = 0x1000;

        [NativeTypeName("#define PAGE_GRAPHICS_READWRITE 0x2000")]
        public const int PAGE_GRAPHICS_READWRITE = 0x2000;

        [NativeTypeName("#define PAGE_GRAPHICS_EXECUTE 0x4000")]
        public const int PAGE_GRAPHICS_EXECUTE = 0x4000;

        [NativeTypeName("#define PAGE_GRAPHICS_EXECUTE_READ 0x8000")]
        public const int PAGE_GRAPHICS_EXECUTE_READ = 0x8000;

        [NativeTypeName("#define PAGE_GRAPHICS_EXECUTE_READWRITE 0x10000")]
        public const int PAGE_GRAPHICS_EXECUTE_READWRITE = 0x10000;

        [NativeTypeName("#define PAGE_GRAPHICS_COHERENT 0x20000")]
        public const int PAGE_GRAPHICS_COHERENT = 0x20000;

        [NativeTypeName("#define PAGE_GRAPHICS_NOCACHE 0x40000")]
        public const int PAGE_GRAPHICS_NOCACHE = 0x40000;

        [NativeTypeName("#define PAGE_ENCLAVE_THREAD_CONTROL 0x80000000")]
        public const uint PAGE_ENCLAVE_THREAD_CONTROL = 0x80000000;

        [NativeTypeName("#define PAGE_REVERT_TO_FILE_MAP 0x80000000")]
        public const uint PAGE_REVERT_TO_FILE_MAP = 0x80000000;

        [NativeTypeName("#define PAGE_TARGETS_NO_UPDATE 0x40000000")]
        public const int PAGE_TARGETS_NO_UPDATE = 0x40000000;

        [NativeTypeName("#define PAGE_TARGETS_INVALID 0x40000000")]
        public const int PAGE_TARGETS_INVALID = 0x40000000;

        [NativeTypeName("#define PAGE_ENCLAVE_UNVALIDATED 0x20000000")]
        public const int PAGE_ENCLAVE_UNVALIDATED = 0x20000000;

        [NativeTypeName("#define PAGE_ENCLAVE_MASK 0x10000000")]
        public const int PAGE_ENCLAVE_MASK = 0x10000000;

        [NativeTypeName("#define PAGE_ENCLAVE_DECOMMIT (PAGE_ENCLAVE_MASK | 0)")]
        public const int PAGE_ENCLAVE_DECOMMIT = (0x10000000 | 0);

        [NativeTypeName("#define PAGE_ENCLAVE_SS_FIRST (PAGE_ENCLAVE_MASK | 1)")]
        public const int PAGE_ENCLAVE_SS_FIRST = (0x10000000 | 1);

        [NativeTypeName("#define PAGE_ENCLAVE_SS_REST (PAGE_ENCLAVE_MASK | 2)")]
        public const int PAGE_ENCLAVE_SS_REST = (0x10000000 | 2);

        [NativeTypeName("#define MEM_COMMIT 0x00001000")]
        public const int MEM_COMMIT = 0x00001000;

        [NativeTypeName("#define MEM_RESERVE 0x00002000")]
        public const int MEM_RESERVE = 0x00002000;

        [NativeTypeName("#define MEM_REPLACE_PLACEHOLDER 0x00004000")]
        public const int MEM_REPLACE_PLACEHOLDER = 0x00004000;

        [NativeTypeName("#define MEM_RESERVE_PLACEHOLDER 0x00040000")]
        public const int MEM_RESERVE_PLACEHOLDER = 0x00040000;

        [NativeTypeName("#define MEM_RESET 0x00080000")]
        public const int MEM_RESET = 0x00080000;

        [NativeTypeName("#define MEM_TOP_DOWN 0x00100000")]
        public const int MEM_TOP_DOWN = 0x00100000;

        [NativeTypeName("#define MEM_WRITE_WATCH 0x00200000")]
        public const int MEM_WRITE_WATCH = 0x00200000;

        [NativeTypeName("#define MEM_PHYSICAL 0x00400000")]
        public const int MEM_PHYSICAL = 0x00400000;

        [NativeTypeName("#define MEM_ROTATE 0x00800000")]
        public const int MEM_ROTATE = 0x00800000;

        [NativeTypeName("#define MEM_DIFFERENT_IMAGE_BASE_OK 0x00800000")]
        public const int MEM_DIFFERENT_IMAGE_BASE_OK = 0x00800000;

        [NativeTypeName("#define MEM_RESET_UNDO 0x01000000")]
        public const int MEM_RESET_UNDO = 0x01000000;

        [NativeTypeName("#define MEM_LARGE_PAGES 0x20000000")]
        public const int MEM_LARGE_PAGES = 0x20000000;

        [NativeTypeName("#define MEM_4MB_PAGES 0x80000000")]
        public const uint MEM_4MB_PAGES = 0x80000000;

        [NativeTypeName("#define MEM_64K_PAGES (MEM_LARGE_PAGES | MEM_PHYSICAL)")]
        public const int MEM_64K_PAGES = (0x20000000 | 0x00400000);

        [NativeTypeName("#define MEM_UNMAP_WITH_TRANSIENT_BOOST 0x00000001")]
        public const int MEM_UNMAP_WITH_TRANSIENT_BOOST = 0x00000001;

        [NativeTypeName("#define MEM_COALESCE_PLACEHOLDERS 0x00000001")]
        public const int MEM_COALESCE_PLACEHOLDERS = 0x00000001;

        [NativeTypeName("#define MEM_PRESERVE_PLACEHOLDER 0x00000002")]
        public const int MEM_PRESERVE_PLACEHOLDER = 0x00000002;

        [NativeTypeName("#define MEM_DECOMMIT 0x00004000")]
        public const int MEM_DECOMMIT = 0x00004000;

        [NativeTypeName("#define MEM_RELEASE 0x00008000")]
        public const int MEM_RELEASE = 0x00008000;

        [NativeTypeName("#define MEM_FREE 0x00010000")]
        public const int MEM_FREE = 0x00010000;

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_GRAPHICS 0x00000001")]
        public const int MEM_EXTENDED_PARAMETER_GRAPHICS = 0x00000001;

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_NONPAGED 0x00000002")]
        public const int MEM_EXTENDED_PARAMETER_NONPAGED = 0x00000002;

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_ZERO_PAGES_OPTIONAL 0x00000004")]
        public const int MEM_EXTENDED_PARAMETER_ZERO_PAGES_OPTIONAL = 0x00000004;

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_NONPAGED_LARGE 0x00000008")]
        public const int MEM_EXTENDED_PARAMETER_NONPAGED_LARGE = 0x00000008;

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_NONPAGED_HUGE 0x00000010")]
        public const int MEM_EXTENDED_PARAMETER_NONPAGED_HUGE = 0x00000010;

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_SOFT_FAULT_PAGES 0x00000020")]
        public const int MEM_EXTENDED_PARAMETER_SOFT_FAULT_PAGES = 0x00000020;

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_NUMA_NODE_MANDATORY MINLONG64")]
        public const long MEM_EXTENDED_PARAMETER_NUMA_NODE_MANDATORY = unchecked((long)(~((long)(((ulong)(~((ulong)(0)))) >> 1))));

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_TYPE_BITS 8")]
        public const int MEM_EXTENDED_PARAMETER_TYPE_BITS = 8;

        [NativeTypeName("#define SEC_PARTITION_OWNER_HANDLE 0x00040000")]
        public const int SEC_PARTITION_OWNER_HANDLE = 0x00040000;

        [NativeTypeName("#define SEC_64K_PAGES 0x00080000")]
        public const int SEC_64K_PAGES = 0x00080000;

        [NativeTypeName("#define SEC_FILE 0x00800000")]
        public const int SEC_FILE = 0x00800000;

        [NativeTypeName("#define SEC_IMAGE 0x01000000")]
        public const int SEC_IMAGE = 0x01000000;

        [NativeTypeName("#define SEC_PROTECTED_IMAGE 0x02000000")]
        public const int SEC_PROTECTED_IMAGE = 0x02000000;

        [NativeTypeName("#define SEC_RESERVE 0x04000000")]
        public const int SEC_RESERVE = 0x04000000;

        [NativeTypeName("#define SEC_COMMIT 0x08000000")]
        public const int SEC_COMMIT = 0x08000000;

        [NativeTypeName("#define SEC_NOCACHE 0x10000000")]
        public const int SEC_NOCACHE = 0x10000000;

        [NativeTypeName("#define SEC_WRITECOMBINE 0x40000000")]
        public const int SEC_WRITECOMBINE = 0x40000000;

        [NativeTypeName("#define SEC_LARGE_PAGES 0x80000000")]
        public const uint SEC_LARGE_PAGES = 0x80000000;

        [NativeTypeName("#define SEC_IMAGE_NO_EXECUTE (SEC_IMAGE | SEC_NOCACHE)")]
        public const int SEC_IMAGE_NO_EXECUTE = (0x01000000 | 0x10000000);

        [NativeTypeName("#define MEM_PRIVATE 0x00020000")]
        public const int MEM_PRIVATE = 0x00020000;

        [NativeTypeName("#define MEM_MAPPED 0x00040000")]
        public const int MEM_MAPPED = 0x00040000;

        [NativeTypeName("#define MEM_IMAGE 0x01000000")]
        public const int MEM_IMAGE = 0x01000000;

        [NativeTypeName("#define WRITE_WATCH_FLAG_RESET 0x01")]
        public const int WRITE_WATCH_FLAG_RESET = 0x01;

        [NativeTypeName("#define ENCLAVE_TYPE_SGX 0x00000001")]
        public const int ENCLAVE_TYPE_SGX = 0x00000001;

        [NativeTypeName("#define ENCLAVE_TYPE_SGX2 0x00000002")]
        public const int ENCLAVE_TYPE_SGX2 = 0x00000002;

        [NativeTypeName("#define ENCLAVE_TYPE_VBS 0x00000010")]
        public const int ENCLAVE_TYPE_VBS = 0x00000010;

        [NativeTypeName("#define ENCLAVE_VBS_FLAG_DEBUG 0x00000001")]
        public const int ENCLAVE_VBS_FLAG_DEBUG = 0x00000001;

        [NativeTypeName("#define ENCLAVE_TYPE_VBS_BASIC 0x00000011")]
        public const int ENCLAVE_TYPE_VBS_BASIC = 0x00000011;

        [NativeTypeName("#define VBS_BASIC_PAGE_MEASURED_DATA 0x00000001")]
        public const int VBS_BASIC_PAGE_MEASURED_DATA = 0x00000001;

        [NativeTypeName("#define VBS_BASIC_PAGE_UNMEASURED_DATA 0x00000002")]
        public const int VBS_BASIC_PAGE_UNMEASURED_DATA = 0x00000002;

        [NativeTypeName("#define VBS_BASIC_PAGE_ZERO_FILL 0x00000003")]
        public const int VBS_BASIC_PAGE_ZERO_FILL = 0x00000003;

        [NativeTypeName("#define VBS_BASIC_PAGE_THREAD_DESCRIPTOR 0x00000004")]
        public const int VBS_BASIC_PAGE_THREAD_DESCRIPTOR = 0x00000004;

        [NativeTypeName("#define VBS_BASIC_PAGE_SYSTEM_CALL 0x00000005")]
        public const int VBS_BASIC_PAGE_SYSTEM_CALL = 0x00000005;

        [NativeTypeName("#define FILE_READ_DATA ( 0x0001 )")]
        public const int FILE_READ_DATA = (0x0001);

        [NativeTypeName("#define FILE_LIST_DIRECTORY ( 0x0001 )")]
        public const int FILE_LIST_DIRECTORY = (0x0001);

        [NativeTypeName("#define FILE_WRITE_DATA ( 0x0002 )")]
        public const int FILE_WRITE_DATA = (0x0002);

        [NativeTypeName("#define FILE_ADD_FILE ( 0x0002 )")]
        public const int FILE_ADD_FILE = (0x0002);

        [NativeTypeName("#define FILE_APPEND_DATA ( 0x0004 )")]
        public const int FILE_APPEND_DATA = (0x0004);

        [NativeTypeName("#define FILE_ADD_SUBDIRECTORY ( 0x0004 )")]
        public const int FILE_ADD_SUBDIRECTORY = (0x0004);

        [NativeTypeName("#define FILE_CREATE_PIPE_INSTANCE ( 0x0004 )")]
        public const int FILE_CREATE_PIPE_INSTANCE = (0x0004);

        [NativeTypeName("#define FILE_READ_EA ( 0x0008 )")]
        public const int FILE_READ_EA = (0x0008);

        [NativeTypeName("#define FILE_WRITE_EA ( 0x0010 )")]
        public const int FILE_WRITE_EA = (0x0010);

        [NativeTypeName("#define FILE_EXECUTE ( 0x0020 )")]
        public const int FILE_EXECUTE = (0x0020);

        [NativeTypeName("#define FILE_TRAVERSE ( 0x0020 )")]
        public const int FILE_TRAVERSE = (0x0020);

        [NativeTypeName("#define FILE_DELETE_CHILD ( 0x0040 )")]
        public const int FILE_DELETE_CHILD = (0x0040);

        [NativeTypeName("#define FILE_READ_ATTRIBUTES ( 0x0080 )")]
        public const int FILE_READ_ATTRIBUTES = (0x0080);

        [NativeTypeName("#define FILE_WRITE_ATTRIBUTES ( 0x0100 )")]
        public const int FILE_WRITE_ATTRIBUTES = (0x0100);

        [NativeTypeName("#define FILE_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x1FF)")]
        public const int FILE_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x1FF);

        [NativeTypeName("#define FILE_GENERIC_READ (STANDARD_RIGHTS_READ     |\\\r\n                                   FILE_READ_DATA           |\\\r\n                                   FILE_READ_ATTRIBUTES     |\\\r\n                                   FILE_READ_EA             |\\\r\n                                   SYNCHRONIZE)")]
        public const int FILE_GENERIC_READ = (((0x00020000)) | (0x0001) | (0x0080) | (0x0008) | (0x00100000));

        [NativeTypeName("#define FILE_GENERIC_WRITE (STANDARD_RIGHTS_WRITE    |\\\r\n                                   FILE_WRITE_DATA          |\\\r\n                                   FILE_WRITE_ATTRIBUTES    |\\\r\n                                   FILE_WRITE_EA            |\\\r\n                                   FILE_APPEND_DATA         |\\\r\n                                   SYNCHRONIZE)")]
        public const int FILE_GENERIC_WRITE = (((0x00020000)) | (0x0002) | (0x0100) | (0x0010) | (0x0004) | (0x00100000));

        [NativeTypeName("#define FILE_GENERIC_EXECUTE (STANDARD_RIGHTS_EXECUTE  |\\\r\n                                   FILE_READ_ATTRIBUTES     |\\\r\n                                   FILE_EXECUTE             |\\\r\n                                   SYNCHRONIZE)")]
        public const int FILE_GENERIC_EXECUTE = (((0x00020000)) | (0x0080) | (0x0020) | (0x00100000));

        [NativeTypeName("#define FILE_SHARE_READ 0x00000001")]
        public const int FILE_SHARE_READ = 0x00000001;

        [NativeTypeName("#define FILE_SHARE_WRITE 0x00000002")]
        public const int FILE_SHARE_WRITE = 0x00000002;

        [NativeTypeName("#define FILE_SHARE_DELETE 0x00000004")]
        public const int FILE_SHARE_DELETE = 0x00000004;

        [NativeTypeName("#define FILE_ATTRIBUTE_READONLY 0x00000001")]
        public const int FILE_ATTRIBUTE_READONLY = 0x00000001;

        [NativeTypeName("#define FILE_ATTRIBUTE_HIDDEN 0x00000002")]
        public const int FILE_ATTRIBUTE_HIDDEN = 0x00000002;

        [NativeTypeName("#define FILE_ATTRIBUTE_SYSTEM 0x00000004")]
        public const int FILE_ATTRIBUTE_SYSTEM = 0x00000004;

        [NativeTypeName("#define FILE_ATTRIBUTE_DIRECTORY 0x00000010")]
        public const int FILE_ATTRIBUTE_DIRECTORY = 0x00000010;

        [NativeTypeName("#define FILE_ATTRIBUTE_ARCHIVE 0x00000020")]
        public const int FILE_ATTRIBUTE_ARCHIVE = 0x00000020;

        [NativeTypeName("#define FILE_ATTRIBUTE_DEVICE 0x00000040")]
        public const int FILE_ATTRIBUTE_DEVICE = 0x00000040;

        [NativeTypeName("#define FILE_ATTRIBUTE_NORMAL 0x00000080")]
        public const int FILE_ATTRIBUTE_NORMAL = 0x00000080;

        [NativeTypeName("#define FILE_ATTRIBUTE_TEMPORARY 0x00000100")]
        public const int FILE_ATTRIBUTE_TEMPORARY = 0x00000100;

        [NativeTypeName("#define FILE_ATTRIBUTE_SPARSE_FILE 0x00000200")]
        public const int FILE_ATTRIBUTE_SPARSE_FILE = 0x00000200;

        [NativeTypeName("#define FILE_ATTRIBUTE_REPARSE_POINT 0x00000400")]
        public const int FILE_ATTRIBUTE_REPARSE_POINT = 0x00000400;

        [NativeTypeName("#define FILE_ATTRIBUTE_COMPRESSED 0x00000800")]
        public const int FILE_ATTRIBUTE_COMPRESSED = 0x00000800;

        [NativeTypeName("#define FILE_ATTRIBUTE_OFFLINE 0x00001000")]
        public const int FILE_ATTRIBUTE_OFFLINE = 0x00001000;

        [NativeTypeName("#define FILE_ATTRIBUTE_NOT_CONTENT_INDEXED 0x00002000")]
        public const int FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 0x00002000;

        [NativeTypeName("#define FILE_ATTRIBUTE_ENCRYPTED 0x00004000")]
        public const int FILE_ATTRIBUTE_ENCRYPTED = 0x00004000;

        [NativeTypeName("#define FILE_ATTRIBUTE_INTEGRITY_STREAM 0x00008000")]
        public const int FILE_ATTRIBUTE_INTEGRITY_STREAM = 0x00008000;

        [NativeTypeName("#define FILE_ATTRIBUTE_VIRTUAL 0x00010000")]
        public const int FILE_ATTRIBUTE_VIRTUAL = 0x00010000;

        [NativeTypeName("#define FILE_ATTRIBUTE_NO_SCRUB_DATA 0x00020000")]
        public const int FILE_ATTRIBUTE_NO_SCRUB_DATA = 0x00020000;

        [NativeTypeName("#define FILE_ATTRIBUTE_EA 0x00040000")]
        public const int FILE_ATTRIBUTE_EA = 0x00040000;

        [NativeTypeName("#define FILE_ATTRIBUTE_PINNED 0x00080000")]
        public const int FILE_ATTRIBUTE_PINNED = 0x00080000;

        [NativeTypeName("#define FILE_ATTRIBUTE_UNPINNED 0x00100000")]
        public const int FILE_ATTRIBUTE_UNPINNED = 0x00100000;

        [NativeTypeName("#define FILE_ATTRIBUTE_RECALL_ON_OPEN 0x00040000")]
        public const int FILE_ATTRIBUTE_RECALL_ON_OPEN = 0x00040000;

        [NativeTypeName("#define FILE_ATTRIBUTE_RECALL_ON_DATA_ACCESS 0x00400000")]
        public const int FILE_ATTRIBUTE_RECALL_ON_DATA_ACCESS = 0x00400000;

        [NativeTypeName("#define TREE_CONNECT_ATTRIBUTE_PRIVACY 0x00004000")]
        public const int TREE_CONNECT_ATTRIBUTE_PRIVACY = 0x00004000;

        [NativeTypeName("#define TREE_CONNECT_ATTRIBUTE_INTEGRITY 0x00008000")]
        public const int TREE_CONNECT_ATTRIBUTE_INTEGRITY = 0x00008000;

        [NativeTypeName("#define TREE_CONNECT_ATTRIBUTE_GLOBAL 0x00000004")]
        public const int TREE_CONNECT_ATTRIBUTE_GLOBAL = 0x00000004;

        [NativeTypeName("#define TREE_CONNECT_ATTRIBUTE_PINNED 0x00000002")]
        public const int TREE_CONNECT_ATTRIBUTE_PINNED = 0x00000002;

        [NativeTypeName("#define FILE_ATTRIBUTE_STRICTLY_SEQUENTIAL 0x20000000")]
        public const int FILE_ATTRIBUTE_STRICTLY_SEQUENTIAL = 0x20000000;

        [NativeTypeName("#define FILE_NOTIFY_CHANGE_FILE_NAME 0x00000001")]
        public const int FILE_NOTIFY_CHANGE_FILE_NAME = 0x00000001;

        [NativeTypeName("#define FILE_NOTIFY_CHANGE_DIR_NAME 0x00000002")]
        public const int FILE_NOTIFY_CHANGE_DIR_NAME = 0x00000002;

        [NativeTypeName("#define FILE_NOTIFY_CHANGE_ATTRIBUTES 0x00000004")]
        public const int FILE_NOTIFY_CHANGE_ATTRIBUTES = 0x00000004;

        [NativeTypeName("#define FILE_NOTIFY_CHANGE_SIZE 0x00000008")]
        public const int FILE_NOTIFY_CHANGE_SIZE = 0x00000008;

        [NativeTypeName("#define FILE_NOTIFY_CHANGE_LAST_WRITE 0x00000010")]
        public const int FILE_NOTIFY_CHANGE_LAST_WRITE = 0x00000010;

        [NativeTypeName("#define FILE_NOTIFY_CHANGE_LAST_ACCESS 0x00000020")]
        public const int FILE_NOTIFY_CHANGE_LAST_ACCESS = 0x00000020;

        [NativeTypeName("#define FILE_NOTIFY_CHANGE_CREATION 0x00000040")]
        public const int FILE_NOTIFY_CHANGE_CREATION = 0x00000040;

        [NativeTypeName("#define FILE_NOTIFY_CHANGE_SECURITY 0x00000100")]
        public const int FILE_NOTIFY_CHANGE_SECURITY = 0x00000100;

        [NativeTypeName("#define FILE_ACTION_ADDED 0x00000001")]
        public const int FILE_ACTION_ADDED = 0x00000001;

        [NativeTypeName("#define FILE_ACTION_REMOVED 0x00000002")]
        public const int FILE_ACTION_REMOVED = 0x00000002;

        [NativeTypeName("#define FILE_ACTION_MODIFIED 0x00000003")]
        public const int FILE_ACTION_MODIFIED = 0x00000003;

        [NativeTypeName("#define FILE_ACTION_RENAMED_OLD_NAME 0x00000004")]
        public const int FILE_ACTION_RENAMED_OLD_NAME = 0x00000004;

        [NativeTypeName("#define FILE_ACTION_RENAMED_NEW_NAME 0x00000005")]
        public const int FILE_ACTION_RENAMED_NEW_NAME = 0x00000005;

        [NativeTypeName("#define MAILSLOT_NO_MESSAGE ((DWORD)-1)")]
        public const uint MAILSLOT_NO_MESSAGE = unchecked((uint)(-1));

        [NativeTypeName("#define MAILSLOT_WAIT_FOREVER ((DWORD)-1)")]
        public const uint MAILSLOT_WAIT_FOREVER = unchecked((uint)(-1));

        [NativeTypeName("#define FILE_CASE_SENSITIVE_SEARCH 0x00000001")]
        public const int FILE_CASE_SENSITIVE_SEARCH = 0x00000001;

        [NativeTypeName("#define FILE_CASE_PRESERVED_NAMES 0x00000002")]
        public const int FILE_CASE_PRESERVED_NAMES = 0x00000002;

        [NativeTypeName("#define FILE_UNICODE_ON_DISK 0x00000004")]
        public const int FILE_UNICODE_ON_DISK = 0x00000004;

        [NativeTypeName("#define FILE_PERSISTENT_ACLS 0x00000008")]
        public const int FILE_PERSISTENT_ACLS = 0x00000008;

        [NativeTypeName("#define FILE_FILE_COMPRESSION 0x00000010")]
        public const int FILE_FILE_COMPRESSION = 0x00000010;

        [NativeTypeName("#define FILE_VOLUME_QUOTAS 0x00000020")]
        public const int FILE_VOLUME_QUOTAS = 0x00000020;

        [NativeTypeName("#define FILE_SUPPORTS_SPARSE_FILES 0x00000040")]
        public const int FILE_SUPPORTS_SPARSE_FILES = 0x00000040;

        [NativeTypeName("#define FILE_SUPPORTS_REPARSE_POINTS 0x00000080")]
        public const int FILE_SUPPORTS_REPARSE_POINTS = 0x00000080;

        [NativeTypeName("#define FILE_SUPPORTS_REMOTE_STORAGE 0x00000100")]
        public const int FILE_SUPPORTS_REMOTE_STORAGE = 0x00000100;

        [NativeTypeName("#define FILE_RETURNS_CLEANUP_RESULT_INFO 0x00000200")]
        public const int FILE_RETURNS_CLEANUP_RESULT_INFO = 0x00000200;

        [NativeTypeName("#define FILE_SUPPORTS_POSIX_UNLINK_RENAME 0x00000400")]
        public const int FILE_SUPPORTS_POSIX_UNLINK_RENAME = 0x00000400;

        [NativeTypeName("#define FILE_VOLUME_IS_COMPRESSED 0x00008000")]
        public const int FILE_VOLUME_IS_COMPRESSED = 0x00008000;

        [NativeTypeName("#define FILE_SUPPORTS_OBJECT_IDS 0x00010000")]
        public const int FILE_SUPPORTS_OBJECT_IDS = 0x00010000;

        [NativeTypeName("#define FILE_SUPPORTS_ENCRYPTION 0x00020000")]
        public const int FILE_SUPPORTS_ENCRYPTION = 0x00020000;

        [NativeTypeName("#define FILE_NAMED_STREAMS 0x00040000")]
        public const int FILE_NAMED_STREAMS = 0x00040000;

        [NativeTypeName("#define FILE_READ_ONLY_VOLUME 0x00080000")]
        public const int FILE_READ_ONLY_VOLUME = 0x00080000;

        [NativeTypeName("#define FILE_SEQUENTIAL_WRITE_ONCE 0x00100000")]
        public const int FILE_SEQUENTIAL_WRITE_ONCE = 0x00100000;

        [NativeTypeName("#define FILE_SUPPORTS_TRANSACTIONS 0x00200000")]
        public const int FILE_SUPPORTS_TRANSACTIONS = 0x00200000;

        [NativeTypeName("#define FILE_SUPPORTS_HARD_LINKS 0x00400000")]
        public const int FILE_SUPPORTS_HARD_LINKS = 0x00400000;

        [NativeTypeName("#define FILE_SUPPORTS_EXTENDED_ATTRIBUTES 0x00800000")]
        public const int FILE_SUPPORTS_EXTENDED_ATTRIBUTES = 0x00800000;

        [NativeTypeName("#define FILE_SUPPORTS_OPEN_BY_FILE_ID 0x01000000")]
        public const int FILE_SUPPORTS_OPEN_BY_FILE_ID = 0x01000000;

        [NativeTypeName("#define FILE_SUPPORTS_USN_JOURNAL 0x02000000")]
        public const int FILE_SUPPORTS_USN_JOURNAL = 0x02000000;

        [NativeTypeName("#define FILE_SUPPORTS_INTEGRITY_STREAMS 0x04000000")]
        public const int FILE_SUPPORTS_INTEGRITY_STREAMS = 0x04000000;

        [NativeTypeName("#define FILE_SUPPORTS_BLOCK_REFCOUNTING 0x08000000")]
        public const int FILE_SUPPORTS_BLOCK_REFCOUNTING = 0x08000000;

        [NativeTypeName("#define FILE_SUPPORTS_SPARSE_VDL 0x10000000")]
        public const int FILE_SUPPORTS_SPARSE_VDL = 0x10000000;

        [NativeTypeName("#define FILE_DAX_VOLUME 0x20000000")]
        public const int FILE_DAX_VOLUME = 0x20000000;

        [NativeTypeName("#define FILE_SUPPORTS_GHOSTING 0x40000000")]
        public const int FILE_SUPPORTS_GHOSTING = 0x40000000;

        [NativeTypeName("#define FILE_INVALID_FILE_ID ((LONGLONG)-1LL)")]
        public const long FILE_INVALID_FILE_ID = ((long)(-1L));

        [NativeTypeName("#define FILE_CS_FLAG_CASE_SENSITIVE_DIR 0x00000001")]
        public const int FILE_CS_FLAG_CASE_SENSITIVE_DIR = 0x00000001;

        [NativeTypeName("#define FLUSH_FLAGS_FILE_DATA_ONLY 0x00000001")]
        public const int FLUSH_FLAGS_FILE_DATA_ONLY = 0x00000001;

        [NativeTypeName("#define FLUSH_FLAGS_NO_SYNC 0x00000002")]
        public const int FLUSH_FLAGS_NO_SYNC = 0x00000002;

        [NativeTypeName("#define FLUSH_FLAGS_FILE_DATA_SYNC_ONLY 0x00000004")]
        public const int FLUSH_FLAGS_FILE_DATA_SYNC_ONLY = 0x00000004;

        [NativeTypeName("#define MAXIMUM_REPARSE_DATA_BUFFER_SIZE ( 16 * 1024 )")]
        public const int MAXIMUM_REPARSE_DATA_BUFFER_SIZE = (16 * 1024);

        [NativeTypeName("#define IO_REPARSE_TAG_RESERVED_ZERO (0)")]
        public const int IO_REPARSE_TAG_RESERVED_ZERO = (0);

        [NativeTypeName("#define IO_REPARSE_TAG_RESERVED_ONE (1)")]
        public const int IO_REPARSE_TAG_RESERVED_ONE = (1);

        [NativeTypeName("#define IO_REPARSE_TAG_RESERVED_TWO (2)")]
        public const int IO_REPARSE_TAG_RESERVED_TWO = (2);

        [NativeTypeName("#define IO_REPARSE_TAG_RESERVED_RANGE IO_REPARSE_TAG_RESERVED_TWO")]
        public const int IO_REPARSE_TAG_RESERVED_RANGE = (2);

        [NativeTypeName("#define IO_REPARSE_TAG_MOUNT_POINT (0xA0000003L)")]
        public const uint IO_REPARSE_TAG_MOUNT_POINT = (0xA0000003);

        [NativeTypeName("#define IO_REPARSE_TAG_HSM (0xC0000004L)")]
        public const uint IO_REPARSE_TAG_HSM = (0xC0000004);

        [NativeTypeName("#define IO_REPARSE_TAG_HSM2 (0x80000006L)")]
        public const uint IO_REPARSE_TAG_HSM2 = (0x80000006);

        [NativeTypeName("#define IO_REPARSE_TAG_SIS (0x80000007L)")]
        public const uint IO_REPARSE_TAG_SIS = (0x80000007);

        [NativeTypeName("#define IO_REPARSE_TAG_WIM (0x80000008L)")]
        public const uint IO_REPARSE_TAG_WIM = (0x80000008);

        [NativeTypeName("#define IO_REPARSE_TAG_CSV (0x80000009L)")]
        public const uint IO_REPARSE_TAG_CSV = (0x80000009);

        [NativeTypeName("#define IO_REPARSE_TAG_DFS (0x8000000AL)")]
        public const uint IO_REPARSE_TAG_DFS = (0x8000000A);

        [NativeTypeName("#define IO_REPARSE_TAG_SYMLINK (0xA000000CL)")]
        public const uint IO_REPARSE_TAG_SYMLINK = (0xA000000C);

        [NativeTypeName("#define IO_REPARSE_TAG_DFSR (0x80000012L)")]
        public const uint IO_REPARSE_TAG_DFSR = (0x80000012);

        [NativeTypeName("#define IO_REPARSE_TAG_DEDUP (0x80000013L)")]
        public const uint IO_REPARSE_TAG_DEDUP = (0x80000013);

        [NativeTypeName("#define IO_REPARSE_TAG_NFS (0x80000014L)")]
        public const uint IO_REPARSE_TAG_NFS = (0x80000014);

        [NativeTypeName("#define IO_REPARSE_TAG_FILE_PLACEHOLDER (0x80000015L)")]
        public const uint IO_REPARSE_TAG_FILE_PLACEHOLDER = (0x80000015);

        [NativeTypeName("#define IO_REPARSE_TAG_WOF (0x80000017L)")]
        public const uint IO_REPARSE_TAG_WOF = (0x80000017);

        [NativeTypeName("#define IO_REPARSE_TAG_WCI (0x80000018L)")]
        public const uint IO_REPARSE_TAG_WCI = (0x80000018);

        [NativeTypeName("#define IO_REPARSE_TAG_WCI_1 (0x90001018L)")]
        public const uint IO_REPARSE_TAG_WCI_1 = (0x90001018);

        [NativeTypeName("#define IO_REPARSE_TAG_GLOBAL_REPARSE (0xA0000019L)")]
        public const uint IO_REPARSE_TAG_GLOBAL_REPARSE = (0xA0000019);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD (0x9000001AL)")]
        public const uint IO_REPARSE_TAG_CLOUD = (0x9000001A);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_1 (0x9000101AL)")]
        public const uint IO_REPARSE_TAG_CLOUD_1 = (0x9000101A);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_2 (0x9000201AL)")]
        public const uint IO_REPARSE_TAG_CLOUD_2 = (0x9000201A);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_3 (0x9000301AL)")]
        public const uint IO_REPARSE_TAG_CLOUD_3 = (0x9000301A);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_4 (0x9000401AL)")]
        public const uint IO_REPARSE_TAG_CLOUD_4 = (0x9000401A);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_5 (0x9000501AL)")]
        public const uint IO_REPARSE_TAG_CLOUD_5 = (0x9000501A);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_6 (0x9000601AL)")]
        public const uint IO_REPARSE_TAG_CLOUD_6 = (0x9000601A);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_7 (0x9000701AL)")]
        public const uint IO_REPARSE_TAG_CLOUD_7 = (0x9000701A);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_8 (0x9000801AL)")]
        public const uint IO_REPARSE_TAG_CLOUD_8 = (0x9000801A);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_9 (0x9000901AL)")]
        public const uint IO_REPARSE_TAG_CLOUD_9 = (0x9000901A);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_A (0x9000A01AL)")]
        public const uint IO_REPARSE_TAG_CLOUD_A = (0x9000A01A);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_B (0x9000B01AL)")]
        public const uint IO_REPARSE_TAG_CLOUD_B = (0x9000B01A);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_C (0x9000C01AL)")]
        public const uint IO_REPARSE_TAG_CLOUD_C = (0x9000C01A);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_D (0x9000D01AL)")]
        public const uint IO_REPARSE_TAG_CLOUD_D = (0x9000D01A);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_E (0x9000E01AL)")]
        public const uint IO_REPARSE_TAG_CLOUD_E = (0x9000E01A);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_F (0x9000F01AL)")]
        public const uint IO_REPARSE_TAG_CLOUD_F = (0x9000F01A);

        [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_MASK (0x0000F000L)")]
        public const int IO_REPARSE_TAG_CLOUD_MASK = (0x0000F000);

        [NativeTypeName("#define IO_REPARSE_TAG_APPEXECLINK (0x8000001BL)")]
        public const uint IO_REPARSE_TAG_APPEXECLINK = (0x8000001B);

        [NativeTypeName("#define IO_REPARSE_TAG_PROJFS (0x9000001CL)")]
        public const uint IO_REPARSE_TAG_PROJFS = (0x9000001C);

        [NativeTypeName("#define IO_REPARSE_TAG_STORAGE_SYNC (0x8000001EL)")]
        public const uint IO_REPARSE_TAG_STORAGE_SYNC = (0x8000001E);

        [NativeTypeName("#define IO_REPARSE_TAG_WCI_TOMBSTONE (0xA000001FL)")]
        public const uint IO_REPARSE_TAG_WCI_TOMBSTONE = (0xA000001F);

        [NativeTypeName("#define IO_REPARSE_TAG_UNHANDLED (0x80000020L)")]
        public const uint IO_REPARSE_TAG_UNHANDLED = (0x80000020);

        [NativeTypeName("#define IO_REPARSE_TAG_ONEDRIVE (0x80000021L)")]
        public const uint IO_REPARSE_TAG_ONEDRIVE = (0x80000021);

        [NativeTypeName("#define IO_REPARSE_TAG_PROJFS_TOMBSTONE (0xA0000022L)")]
        public const uint IO_REPARSE_TAG_PROJFS_TOMBSTONE = (0xA0000022);

        [NativeTypeName("#define IO_REPARSE_TAG_AF_UNIX (0x80000023L)")]
        public const uint IO_REPARSE_TAG_AF_UNIX = (0x80000023);

        [NativeTypeName("#define IO_REPARSE_TAG_WCI_LINK (0xA0000027L)")]
        public const uint IO_REPARSE_TAG_WCI_LINK = (0xA0000027);

        [NativeTypeName("#define IO_REPARSE_TAG_WCI_LINK_1 (0xA0001027L)")]
        public const uint IO_REPARSE_TAG_WCI_LINK_1 = (0xA0001027);

        [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_RESUME 0x00000001")]
        public const int SCRUB_DATA_INPUT_FLAG_RESUME = 0x00000001;

        [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_SKIP_IN_SYNC 0x00000002")]
        public const int SCRUB_DATA_INPUT_FLAG_SKIP_IN_SYNC = 0x00000002;

        [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_SKIP_NON_INTEGRITY_DATA 0x00000004")]
        public const int SCRUB_DATA_INPUT_FLAG_SKIP_NON_INTEGRITY_DATA = 0x00000004;

        [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_IGNORE_REDUNDANCY 0x00000008")]
        public const int SCRUB_DATA_INPUT_FLAG_IGNORE_REDUNDANCY = 0x00000008;

        [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_SKIP_DATA 0x00000010")]
        public const int SCRUB_DATA_INPUT_FLAG_SKIP_DATA = 0x00000010;

        [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_SCRUB_BY_OBJECT_ID 0x00000020")]
        public const int SCRUB_DATA_INPUT_FLAG_SCRUB_BY_OBJECT_ID = 0x00000020;

        [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_OPLOCK_NOT_ACQUIRED 0x00000040")]
        public const int SCRUB_DATA_INPUT_FLAG_OPLOCK_NOT_ACQUIRED = 0x00000040;

        [NativeTypeName("#define SCRUB_DATA_OUTPUT_FLAG_INCOMPLETE 0x00000001")]
        public const int SCRUB_DATA_OUTPUT_FLAG_INCOMPLETE = 0x00000001;

        [NativeTypeName("#define SCRUB_DATA_OUTPUT_FLAG_NON_USER_DATA_RANGE 0x00010000")]
        public const int SCRUB_DATA_OUTPUT_FLAG_NON_USER_DATA_RANGE = 0x00010000;

        [NativeTypeName("#define SCRUB_DATA_OUTPUT_FLAG_PARITY_EXTENT_DATA_RETURNED 0x00020000")]
        public const int SCRUB_DATA_OUTPUT_FLAG_PARITY_EXTENT_DATA_RETURNED = 0x00020000;

        [NativeTypeName("#define SCRUB_DATA_OUTPUT_FLAG_RESUME_CONTEXT_LENGTH_SPECIFIED 0x00040000")]
        public const int SCRUB_DATA_OUTPUT_FLAG_RESUME_CONTEXT_LENGTH_SPECIFIED = 0x00040000;

        [NativeTypeName("#define SHUFFLE_FILE_FLAG_SKIP_INITIALIZING_NEW_CLUSTERS (0x00000001)")]
        public const int SHUFFLE_FILE_FLAG_SKIP_INITIALIZING_NEW_CLUSTERS = (0x00000001);

        [NativeTypeName("#define IO_COMPLETION_MODIFY_STATE 0x0002")]
        public const int IO_COMPLETION_MODIFY_STATE = 0x0002;

        [NativeTypeName("#define IO_COMPLETION_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|0x3)")]
        public const int IO_COMPLETION_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x3);

        [NativeTypeName("#define IO_QOS_MAX_RESERVATION 1000000000ULL")]
        public const ulong IO_QOS_MAX_RESERVATION = 1000000000UL;

        [NativeTypeName("#define SMB_CCF_APP_INSTANCE_EA_NAME \"ClusteredApplicationInstance\"")]
        public static ReadOnlySpan<byte> SMB_CCF_APP_INSTANCE_EA_NAME => new byte[] { 0x43, 0x6C, 0x75, 0x73, 0x74, 0x65, 0x72, 0x65, 0x64, 0x41, 0x70, 0x70, 0x6C, 0x69, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x49, 0x6E, 0x73, 0x74, 0x61, 0x6E, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define NETWORK_APP_INSTANCE_CSV_FLAGS_VALID_ONLY_IF_CSV_COORDINATOR 0x00000001")]
        public const int NETWORK_APP_INSTANCE_CSV_FLAGS_VALID_ONLY_IF_CSV_COORDINATOR = 0x00000001;

        [NativeTypeName("#define DUPLICATE_CLOSE_SOURCE 0x00000001")]
        public const int DUPLICATE_CLOSE_SOURCE = 0x00000001;

        [NativeTypeName("#define DUPLICATE_SAME_ACCESS 0x00000002")]
        public const int DUPLICATE_SAME_ACCESS = 0x00000002;

        [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_NOTHING 0")]
        public const int POWERBUTTON_ACTION_INDEX_NOTHING = 0;

        [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_SLEEP 1")]
        public const int POWERBUTTON_ACTION_INDEX_SLEEP = 1;

        [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_HIBERNATE 2")]
        public const int POWERBUTTON_ACTION_INDEX_HIBERNATE = 2;

        [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_SHUTDOWN 3")]
        public const int POWERBUTTON_ACTION_INDEX_SHUTDOWN = 3;

        [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_TURN_OFF_THE_DISPLAY 4")]
        public const int POWERBUTTON_ACTION_INDEX_TURN_OFF_THE_DISPLAY = 4;

        [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_NOTHING 0")]
        public const int POWERBUTTON_ACTION_VALUE_NOTHING = 0;

        [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_SLEEP 2")]
        public const int POWERBUTTON_ACTION_VALUE_SLEEP = 2;

        [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_HIBERNATE 3")]
        public const int POWERBUTTON_ACTION_VALUE_HIBERNATE = 3;

        [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_SHUTDOWN 6")]
        public const int POWERBUTTON_ACTION_VALUE_SHUTDOWN = 6;

        [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_TURN_OFF_THE_DISPLAY 8")]
        public const int POWERBUTTON_ACTION_VALUE_TURN_OFF_THE_DISPLAY = 8;

        [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_IDEAL 0")]
        public const int PERFSTATE_POLICY_CHANGE_IDEAL = 0;

        [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_SINGLE 1")]
        public const int PERFSTATE_POLICY_CHANGE_SINGLE = 1;

        [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_ROCKET 2")]
        public const int PERFSTATE_POLICY_CHANGE_ROCKET = 2;

        [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE 3")]
        public const int PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE = 3;

        [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_DECREASE_MAX PERFSTATE_POLICY_CHANGE_ROCKET")]
        public const int PERFSTATE_POLICY_CHANGE_DECREASE_MAX = 2;

        [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_INCREASE_MAX PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE")]
        public const int PERFSTATE_POLICY_CHANGE_INCREASE_MAX = 3;

        [NativeTypeName("#define PROCESSOR_THROTTLE_DISABLED 0")]
        public const int PROCESSOR_THROTTLE_DISABLED = 0;

        [NativeTypeName("#define PROCESSOR_THROTTLE_ENABLED 1")]
        public const int PROCESSOR_THROTTLE_ENABLED = 1;

        [NativeTypeName("#define PROCESSOR_THROTTLE_AUTOMATIC 2")]
        public const int PROCESSOR_THROTTLE_AUTOMATIC = 2;

        [NativeTypeName("#define PROCESSOR_PERF_BOOST_POLICY_DISABLED 0")]
        public const int PROCESSOR_PERF_BOOST_POLICY_DISABLED = 0;

        [NativeTypeName("#define PROCESSOR_PERF_BOOST_POLICY_MAX 100")]
        public const int PROCESSOR_PERF_BOOST_POLICY_MAX = 100;

        [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_DISABLED 0")]
        public const int PROCESSOR_PERF_BOOST_MODE_DISABLED = 0;

        [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_ENABLED 1")]
        public const int PROCESSOR_PERF_BOOST_MODE_ENABLED = 1;

        [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE 2")]
        public const int PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE = 2;

        [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_EFFICIENT_ENABLED 3")]
        public const int PROCESSOR_PERF_BOOST_MODE_EFFICIENT_ENABLED = 3;

        [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE 4")]
        public const int PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE = 4;

        [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE_AT_GUARANTEED 5")]
        public const int PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE_AT_GUARANTEED = 5;

        [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE_AT_GUARANTEED 6")]
        public const int PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE_AT_GUARANTEED = 6;

        [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_MAX PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE_AT_GUARANTEED")]
        public const int PROCESSOR_PERF_BOOST_MODE_MAX = 6;

        [NativeTypeName("#define PROCESSOR_PERF_AUTONOMOUS_MODE_DISABLED 0")]
        public const int PROCESSOR_PERF_AUTONOMOUS_MODE_DISABLED = 0;

        [NativeTypeName("#define PROCESSOR_PERF_AUTONOMOUS_MODE_ENABLED 1")]
        public const int PROCESSOR_PERF_AUTONOMOUS_MODE_ENABLED = 1;

        [NativeTypeName("#define PROCESSOR_PERF_PERFORMANCE_PREFERENCE 0xff")]
        public const int PROCESSOR_PERF_PERFORMANCE_PREFERENCE = 0xff;

        [NativeTypeName("#define PROCESSOR_PERF_ENERGY_PREFERENCE 0")]
        public const int PROCESSOR_PERF_ENERGY_PREFERENCE = 0;

        [NativeTypeName("#define PROCESSOR_PERF_MINIMUM_ACTIVITY_WINDOW 0")]
        public const int PROCESSOR_PERF_MINIMUM_ACTIVITY_WINDOW = 0;

        [NativeTypeName("#define PROCESSOR_PERF_MAXIMUM_ACTIVITY_WINDOW 1270000000")]
        public const int PROCESSOR_PERF_MAXIMUM_ACTIVITY_WINDOW = 1270000000;

        [NativeTypeName("#define PROCESSOR_DUTY_CYCLING_DISABLED 0")]
        public const int PROCESSOR_DUTY_CYCLING_DISABLED = 0;

        [NativeTypeName("#define PROCESSOR_DUTY_CYCLING_ENABLED 1")]
        public const int PROCESSOR_DUTY_CYCLING_ENABLED = 1;

        [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_IDEAL 0")]
        public const int CORE_PARKING_POLICY_CHANGE_IDEAL = 0;

        [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_SINGLE 1")]
        public const int CORE_PARKING_POLICY_CHANGE_SINGLE = 1;

        [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_ROCKET 2")]
        public const int CORE_PARKING_POLICY_CHANGE_ROCKET = 2;

        [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_MULTISTEP 3")]
        public const int CORE_PARKING_POLICY_CHANGE_MULTISTEP = 3;

        [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_MAX CORE_PARKING_POLICY_CHANGE_MULTISTEP")]
        public const int CORE_PARKING_POLICY_CHANGE_MAX = 3;

        [NativeTypeName("#define POWER_DEVICE_IDLE_POLICY_PERFORMANCE 0")]
        public const int POWER_DEVICE_IDLE_POLICY_PERFORMANCE = 0;

        [NativeTypeName("#define POWER_DEVICE_IDLE_POLICY_CONSERVATIVE 1")]
        public const int POWER_DEVICE_IDLE_POLICY_CONSERVATIVE = 1;

        [NativeTypeName("#define POWER_CONNECTIVITY_IN_STANDBY_DISABLED 0")]
        public const int POWER_CONNECTIVITY_IN_STANDBY_DISABLED = 0;

        [NativeTypeName("#define POWER_CONNECTIVITY_IN_STANDBY_ENABLED 1")]
        public const int POWER_CONNECTIVITY_IN_STANDBY_ENABLED = 1;

        [NativeTypeName("#define POWER_CONNECTIVITY_IN_STANDBY_SYSTEM_MANAGED 2")]
        public const int POWER_CONNECTIVITY_IN_STANDBY_SYSTEM_MANAGED = 2;

        [NativeTypeName("#define POWER_DISCONNECTED_STANDBY_MODE_NORMAL 0")]
        public const int POWER_DISCONNECTED_STANDBY_MODE_NORMAL = 0;

        [NativeTypeName("#define POWER_DISCONNECTED_STANDBY_MODE_AGGRESSIVE 1")]
        public const int POWER_DISCONNECTED_STANDBY_MODE_AGGRESSIVE = 1;

        [NativeTypeName("#define POWER_SYSTEM_MAXIMUM 7")]
        public const int POWER_SYSTEM_MAXIMUM = 7;

        [NativeTypeName("#define ES_SYSTEM_REQUIRED ((DWORD)0x00000001)")]
        public const uint ES_SYSTEM_REQUIRED = ((uint)(0x00000001));

        [NativeTypeName("#define ES_DISPLAY_REQUIRED ((DWORD)0x00000002)")]
        public const uint ES_DISPLAY_REQUIRED = ((uint)(0x00000002));

        [NativeTypeName("#define ES_USER_PRESENT ((DWORD)0x00000004)")]
        public const uint ES_USER_PRESENT = ((uint)(0x00000004));

        [NativeTypeName("#define ES_AWAYMODE_REQUIRED ((DWORD)0x00000040)")]
        public const uint ES_AWAYMODE_REQUIRED = ((uint)(0x00000040));

        [NativeTypeName("#define ES_CONTINUOUS ((DWORD)0x80000000)")]
        public const uint ES_CONTINUOUS = ((uint)(0x80000000));

        [NativeTypeName("#define DIAGNOSTIC_REASON_VERSION 0")]
        public const int DIAGNOSTIC_REASON_VERSION = 0;

        [NativeTypeName("#define DIAGNOSTIC_REASON_SIMPLE_STRING 0x00000001")]
        public const int DIAGNOSTIC_REASON_SIMPLE_STRING = 0x00000001;

        [NativeTypeName("#define DIAGNOSTIC_REASON_DETAILED_STRING 0x00000002")]
        public const int DIAGNOSTIC_REASON_DETAILED_STRING = 0x00000002;

        [NativeTypeName("#define DIAGNOSTIC_REASON_NOT_SPECIFIED 0x80000000")]
        public const uint DIAGNOSTIC_REASON_NOT_SPECIFIED = 0x80000000;

        [NativeTypeName("#define DIAGNOSTIC_REASON_INVALID_FLAGS (~0x80000007)")]
        public const uint DIAGNOSTIC_REASON_INVALID_FLAGS = (~0x80000007);

        [NativeTypeName("#define POWER_REQUEST_CONTEXT_VERSION DIAGNOSTIC_REASON_VERSION")]
        public const int POWER_REQUEST_CONTEXT_VERSION = 0;

        [NativeTypeName("#define POWER_REQUEST_CONTEXT_SIMPLE_STRING DIAGNOSTIC_REASON_SIMPLE_STRING")]
        public const int POWER_REQUEST_CONTEXT_SIMPLE_STRING = 0x00000001;

        [NativeTypeName("#define POWER_REQUEST_CONTEXT_DETAILED_STRING DIAGNOSTIC_REASON_DETAILED_STRING")]
        public const int POWER_REQUEST_CONTEXT_DETAILED_STRING = 0x00000002;

        [NativeTypeName("#define PDCAP_D0_SUPPORTED 0x00000001")]
        public const int PDCAP_D0_SUPPORTED = 0x00000001;

        [NativeTypeName("#define PDCAP_D1_SUPPORTED 0x00000002")]
        public const int PDCAP_D1_SUPPORTED = 0x00000002;

        [NativeTypeName("#define PDCAP_D2_SUPPORTED 0x00000004")]
        public const int PDCAP_D2_SUPPORTED = 0x00000004;

        [NativeTypeName("#define PDCAP_D3_SUPPORTED 0x00000008")]
        public const int PDCAP_D3_SUPPORTED = 0x00000008;

        [NativeTypeName("#define PDCAP_WAKE_FROM_D0_SUPPORTED 0x00000010")]
        public const int PDCAP_WAKE_FROM_D0_SUPPORTED = 0x00000010;

        [NativeTypeName("#define PDCAP_WAKE_FROM_D1_SUPPORTED 0x00000020")]
        public const int PDCAP_WAKE_FROM_D1_SUPPORTED = 0x00000020;

        [NativeTypeName("#define PDCAP_WAKE_FROM_D2_SUPPORTED 0x00000040")]
        public const int PDCAP_WAKE_FROM_D2_SUPPORTED = 0x00000040;

        [NativeTypeName("#define PDCAP_WAKE_FROM_D3_SUPPORTED 0x00000080")]
        public const int PDCAP_WAKE_FROM_D3_SUPPORTED = 0x00000080;

        [NativeTypeName("#define PDCAP_WARM_EJECT_SUPPORTED 0x00000100")]
        public const int PDCAP_WARM_EJECT_SUPPORTED = 0x00000100;

        [NativeTypeName("#define POWER_SETTING_VALUE_VERSION (0x1)")]
        public const int POWER_SETTING_VALUE_VERSION = (0x1);

        [NativeTypeName("#define POWER_PLATFORM_ROLE_V1 (0x00000001)")]
        public const int POWER_PLATFORM_ROLE_V1 = (0x00000001);

        [NativeTypeName("#define POWER_PLATFORM_ROLE_V1_MAX (PlatformRolePerformanceServer + 1)")]
        public const int POWER_PLATFORM_ROLE_V1_MAX = ((int)(PlatformRolePerformanceServer) + 1);

        [NativeTypeName("#define POWER_PLATFORM_ROLE_V2 (0x00000002)")]
        public const int POWER_PLATFORM_ROLE_V2 = (0x00000002);

        [NativeTypeName("#define POWER_PLATFORM_ROLE_V2_MAX (PlatformRoleSlate + 1)")]
        public const int POWER_PLATFORM_ROLE_V2_MAX = ((int)(PlatformRoleSlate) + 1);

        [NativeTypeName("#define POWER_PLATFORM_ROLE_VERSION POWER_PLATFORM_ROLE_V2")]
        public const int POWER_PLATFORM_ROLE_VERSION = (0x00000002);

        [NativeTypeName("#define POWER_PLATFORM_ROLE_VERSION_MAX POWER_PLATFORM_ROLE_V2_MAX")]
        public const int POWER_PLATFORM_ROLE_VERSION_MAX = ((int)(PlatformRoleSlate) + 1);

        [NativeTypeName("#define PROC_IDLE_BUCKET_COUNT 6")]
        public const int PROC_IDLE_BUCKET_COUNT = 6;

        [NativeTypeName("#define PROC_IDLE_BUCKET_COUNT_EX 16")]
        public const int PROC_IDLE_BUCKET_COUNT_EX = 16;

        [NativeTypeName("#define ACPI_PPM_SOFTWARE_ALL 0xFC")]
        public const int ACPI_PPM_SOFTWARE_ALL = 0xFC;

        [NativeTypeName("#define ACPI_PPM_SOFTWARE_ANY 0xFD")]
        public const int ACPI_PPM_SOFTWARE_ANY = 0xFD;

        [NativeTypeName("#define ACPI_PPM_HARDWARE_ALL 0xFE")]
        public const int ACPI_PPM_HARDWARE_ALL = 0xFE;

        [NativeTypeName("#define MS_PPM_SOFTWARE_ALL 0x1")]
        public const int MS_PPM_SOFTWARE_ALL = 0x1;

        [NativeTypeName("#define PPM_FIRMWARE_ACPI1C2 0x00000001")]
        public const int PPM_FIRMWARE_ACPI1C2 = 0x00000001;

        [NativeTypeName("#define PPM_FIRMWARE_ACPI1C3 0x00000002")]
        public const int PPM_FIRMWARE_ACPI1C3 = 0x00000002;

        [NativeTypeName("#define PPM_FIRMWARE_ACPI1TSTATES 0x00000004")]
        public const int PPM_FIRMWARE_ACPI1TSTATES = 0x00000004;

        [NativeTypeName("#define PPM_FIRMWARE_CST 0x00000008")]
        public const int PPM_FIRMWARE_CST = 0x00000008;

        [NativeTypeName("#define PPM_FIRMWARE_CSD 0x00000010")]
        public const int PPM_FIRMWARE_CSD = 0x00000010;

        [NativeTypeName("#define PPM_FIRMWARE_PCT 0x00000020")]
        public const int PPM_FIRMWARE_PCT = 0x00000020;

        [NativeTypeName("#define PPM_FIRMWARE_PSS 0x00000040")]
        public const int PPM_FIRMWARE_PSS = 0x00000040;

        [NativeTypeName("#define PPM_FIRMWARE_XPSS 0x00000080")]
        public const int PPM_FIRMWARE_XPSS = 0x00000080;

        [NativeTypeName("#define PPM_FIRMWARE_PPC 0x00000100")]
        public const int PPM_FIRMWARE_PPC = 0x00000100;

        [NativeTypeName("#define PPM_FIRMWARE_PSD 0x00000200")]
        public const int PPM_FIRMWARE_PSD = 0x00000200;

        [NativeTypeName("#define PPM_FIRMWARE_PTC 0x00000400")]
        public const int PPM_FIRMWARE_PTC = 0x00000400;

        [NativeTypeName("#define PPM_FIRMWARE_TSS 0x00000800")]
        public const int PPM_FIRMWARE_TSS = 0x00000800;

        [NativeTypeName("#define PPM_FIRMWARE_TPC 0x00001000")]
        public const int PPM_FIRMWARE_TPC = 0x00001000;

        [NativeTypeName("#define PPM_FIRMWARE_TSD 0x00002000")]
        public const int PPM_FIRMWARE_TSD = 0x00002000;

        [NativeTypeName("#define PPM_FIRMWARE_PCCH 0x00004000")]
        public const int PPM_FIRMWARE_PCCH = 0x00004000;

        [NativeTypeName("#define PPM_FIRMWARE_PCCP 0x00008000")]
        public const int PPM_FIRMWARE_PCCP = 0x00008000;

        [NativeTypeName("#define PPM_FIRMWARE_OSC 0x00010000")]
        public const int PPM_FIRMWARE_OSC = 0x00010000;

        [NativeTypeName("#define PPM_FIRMWARE_PDC 0x00020000")]
        public const int PPM_FIRMWARE_PDC = 0x00020000;

        [NativeTypeName("#define PPM_FIRMWARE_CPC 0x00040000")]
        public const int PPM_FIRMWARE_CPC = 0x00040000;

        [NativeTypeName("#define PPM_FIRMWARE_LPI 0x00080000")]
        public const int PPM_FIRMWARE_LPI = 0x00080000;

        [NativeTypeName("#define PPM_PERFORMANCE_IMPLEMENTATION_NONE 0x00000000")]
        public const int PPM_PERFORMANCE_IMPLEMENTATION_NONE = 0x00000000;

        [NativeTypeName("#define PPM_PERFORMANCE_IMPLEMENTATION_PSTATES 0x00000001")]
        public const int PPM_PERFORMANCE_IMPLEMENTATION_PSTATES = 0x00000001;

        [NativeTypeName("#define PPM_PERFORMANCE_IMPLEMENTATION_PCCV1 0x00000002")]
        public const int PPM_PERFORMANCE_IMPLEMENTATION_PCCV1 = 0x00000002;

        [NativeTypeName("#define PPM_PERFORMANCE_IMPLEMENTATION_CPPC 0x00000003")]
        public const int PPM_PERFORMANCE_IMPLEMENTATION_CPPC = 0x00000003;

        [NativeTypeName("#define PPM_PERFORMANCE_IMPLEMENTATION_PEP 0x00000004")]
        public const int PPM_PERFORMANCE_IMPLEMENTATION_PEP = 0x00000004;

        [NativeTypeName("#define PPM_IDLE_IMPLEMENTATION_NONE 0x00000000")]
        public const int PPM_IDLE_IMPLEMENTATION_NONE = 0x00000000;

        [NativeTypeName("#define PPM_IDLE_IMPLEMENTATION_CSTATES 0x00000001")]
        public const int PPM_IDLE_IMPLEMENTATION_CSTATES = 0x00000001;

        [NativeTypeName("#define PPM_IDLE_IMPLEMENTATION_PEP 0x00000002")]
        public const int PPM_IDLE_IMPLEMENTATION_PEP = 0x00000002;

        [NativeTypeName("#define PPM_IDLE_IMPLEMENTATION_MICROPEP 0x00000003")]
        public const int PPM_IDLE_IMPLEMENTATION_MICROPEP = 0x00000003;

        [NativeTypeName("#define PPM_IDLE_IMPLEMENTATION_LPISTATES 0x00000004")]
        public const int PPM_IDLE_IMPLEMENTATION_LPISTATES = 0x00000004;

        [NativeTypeName("#define POWER_ACTION_QUERY_ALLOWED 0x00000001")]
        public const int POWER_ACTION_QUERY_ALLOWED = 0x00000001;

        [NativeTypeName("#define POWER_ACTION_UI_ALLOWED 0x00000002")]
        public const int POWER_ACTION_UI_ALLOWED = 0x00000002;

        [NativeTypeName("#define POWER_ACTION_OVERRIDE_APPS 0x00000004")]
        public const int POWER_ACTION_OVERRIDE_APPS = 0x00000004;

        [NativeTypeName("#define POWER_ACTION_HIBERBOOT 0x00000008")]
        public const int POWER_ACTION_HIBERBOOT = 0x00000008;

        [NativeTypeName("#define POWER_ACTION_USER_NOTIFY 0x00000010")]
        public const int POWER_ACTION_USER_NOTIFY = 0x00000010;

        [NativeTypeName("#define POWER_ACTION_DOZE_TO_HIBERNATE 0x00000020")]
        public const int POWER_ACTION_DOZE_TO_HIBERNATE = 0x00000020;

        [NativeTypeName("#define POWER_ACTION_ACPI_CRITICAL 0x01000000")]
        public const int POWER_ACTION_ACPI_CRITICAL = 0x01000000;

        [NativeTypeName("#define POWER_ACTION_ACPI_USER_NOTIFY 0x02000000")]
        public const int POWER_ACTION_ACPI_USER_NOTIFY = 0x02000000;

        [NativeTypeName("#define POWER_ACTION_DIRECTED_DRIPS 0x04000000")]
        public const int POWER_ACTION_DIRECTED_DRIPS = 0x04000000;

        [NativeTypeName("#define POWER_ACTION_PSEUDO_TRANSITION 0x08000000")]
        public const int POWER_ACTION_PSEUDO_TRANSITION = 0x08000000;

        [NativeTypeName("#define POWER_ACTION_LIGHTEST_FIRST 0x10000000")]
        public const int POWER_ACTION_LIGHTEST_FIRST = 0x10000000;

        [NativeTypeName("#define POWER_ACTION_LOCK_CONSOLE 0x20000000")]
        public const int POWER_ACTION_LOCK_CONSOLE = 0x20000000;

        [NativeTypeName("#define POWER_ACTION_DISABLE_WAKES 0x40000000")]
        public const int POWER_ACTION_DISABLE_WAKES = 0x40000000;

        [NativeTypeName("#define POWER_ACTION_CRITICAL 0x80000000")]
        public const uint POWER_ACTION_CRITICAL = 0x80000000;

        [NativeTypeName("#define POWER_LEVEL_USER_NOTIFY_TEXT 0x00000001")]
        public const int POWER_LEVEL_USER_NOTIFY_TEXT = 0x00000001;

        [NativeTypeName("#define POWER_LEVEL_USER_NOTIFY_SOUND 0x00000002")]
        public const int POWER_LEVEL_USER_NOTIFY_SOUND = 0x00000002;

        [NativeTypeName("#define POWER_LEVEL_USER_NOTIFY_EXEC 0x00000004")]
        public const int POWER_LEVEL_USER_NOTIFY_EXEC = 0x00000004;

        [NativeTypeName("#define POWER_USER_NOTIFY_BUTTON 0x00000008")]
        public const int POWER_USER_NOTIFY_BUTTON = 0x00000008;

        [NativeTypeName("#define POWER_USER_NOTIFY_SHUTDOWN 0x00000010")]
        public const int POWER_USER_NOTIFY_SHUTDOWN = 0x00000010;

        [NativeTypeName("#define POWER_USER_NOTIFY_FORCED_SHUTDOWN 0x00000020")]
        public const int POWER_USER_NOTIFY_FORCED_SHUTDOWN = 0x00000020;

        [NativeTypeName("#define POWER_FORCE_TRIGGER_RESET 0x80000000")]
        public const uint POWER_FORCE_TRIGGER_RESET = 0x80000000;

        [NativeTypeName("#define BATTERY_DISCHARGE_FLAGS_EVENTCODE_MASK 0x00000007")]
        public const int BATTERY_DISCHARGE_FLAGS_EVENTCODE_MASK = 0x00000007;

        [NativeTypeName("#define BATTERY_DISCHARGE_FLAGS_ENABLE 0x80000000")]
        public const uint BATTERY_DISCHARGE_FLAGS_ENABLE = 0x80000000;

        [NativeTypeName("#define NUM_DISCHARGE_POLICIES 4")]
        public const int NUM_DISCHARGE_POLICIES = 4;

        [NativeTypeName("#define DISCHARGE_POLICY_CRITICAL 0")]
        public const int DISCHARGE_POLICY_CRITICAL = 0;

        [NativeTypeName("#define DISCHARGE_POLICY_LOW 1")]
        public const int DISCHARGE_POLICY_LOW = 1;

        [NativeTypeName("#define PROCESSOR_IDLESTATE_POLICY_COUNT 0x3")]
        public const int PROCESSOR_IDLESTATE_POLICY_COUNT = 0x3;

        [NativeTypeName("#define PO_THROTTLE_NONE 0")]
        public const int PO_THROTTLE_NONE = 0;

        [NativeTypeName("#define PO_THROTTLE_CONSTANT 1")]
        public const int PO_THROTTLE_CONSTANT = 1;

        [NativeTypeName("#define PO_THROTTLE_DEGRADE 2")]
        public const int PO_THROTTLE_DEGRADE = 2;

        [NativeTypeName("#define PO_THROTTLE_ADAPTIVE 3")]
        public const int PO_THROTTLE_ADAPTIVE = 3;

        [NativeTypeName("#define PO_THROTTLE_MAXIMUM 4")]
        public const int PO_THROTTLE_MAXIMUM = 4;

        [NativeTypeName("#define HIBERFILE_TYPE_NONE 0x00")]
        public const int HIBERFILE_TYPE_NONE = 0x00;

        [NativeTypeName("#define HIBERFILE_TYPE_REDUCED 0x01")]
        public const int HIBERFILE_TYPE_REDUCED = 0x01;

        [NativeTypeName("#define HIBERFILE_TYPE_FULL 0x02")]
        public const int HIBERFILE_TYPE_FULL = 0x02;

        [NativeTypeName("#define HIBERFILE_TYPE_MAX 0x03")]
        public const int HIBERFILE_TYPE_MAX = 0x03;

        [NativeTypeName("#define IMAGE_DOS_SIGNATURE 0x5A4D")]
        public const int IMAGE_DOS_SIGNATURE = 0x5A4D;

        [NativeTypeName("#define IMAGE_OS2_SIGNATURE 0x454E")]
        public const int IMAGE_OS2_SIGNATURE = 0x454E;

        [NativeTypeName("#define IMAGE_OS2_SIGNATURE_LE 0x454C")]
        public const int IMAGE_OS2_SIGNATURE_LE = 0x454C;

        [NativeTypeName("#define IMAGE_VXD_SIGNATURE 0x454C")]
        public const int IMAGE_VXD_SIGNATURE = 0x454C;

        [NativeTypeName("#define IMAGE_NT_SIGNATURE 0x00004550")]
        public const int IMAGE_NT_SIGNATURE = 0x00004550;

        [NativeTypeName("#define IMAGE_SIZEOF_FILE_HEADER 20")]
        public const int IMAGE_SIZEOF_FILE_HEADER = 20;

        [NativeTypeName("#define IMAGE_FILE_RELOCS_STRIPPED 0x0001")]
        public const int IMAGE_FILE_RELOCS_STRIPPED = 0x0001;

        [NativeTypeName("#define IMAGE_FILE_EXECUTABLE_IMAGE 0x0002")]
        public const int IMAGE_FILE_EXECUTABLE_IMAGE = 0x0002;

        [NativeTypeName("#define IMAGE_FILE_LINE_NUMS_STRIPPED 0x0004")]
        public const int IMAGE_FILE_LINE_NUMS_STRIPPED = 0x0004;

        [NativeTypeName("#define IMAGE_FILE_LOCAL_SYMS_STRIPPED 0x0008")]
        public const int IMAGE_FILE_LOCAL_SYMS_STRIPPED = 0x0008;

        [NativeTypeName("#define IMAGE_FILE_AGGRESIVE_WS_TRIM 0x0010")]
        public const int IMAGE_FILE_AGGRESIVE_WS_TRIM = 0x0010;

        [NativeTypeName("#define IMAGE_FILE_LARGE_ADDRESS_AWARE 0x0020")]
        public const int IMAGE_FILE_LARGE_ADDRESS_AWARE = 0x0020;

        [NativeTypeName("#define IMAGE_FILE_BYTES_REVERSED_LO 0x0080")]
        public const int IMAGE_FILE_BYTES_REVERSED_LO = 0x0080;

        [NativeTypeName("#define IMAGE_FILE_32BIT_MACHINE 0x0100")]
        public const int IMAGE_FILE_32BIT_MACHINE = 0x0100;

        [NativeTypeName("#define IMAGE_FILE_DEBUG_STRIPPED 0x0200")]
        public const int IMAGE_FILE_DEBUG_STRIPPED = 0x0200;

        [NativeTypeName("#define IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP 0x0400")]
        public const int IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP = 0x0400;

        [NativeTypeName("#define IMAGE_FILE_NET_RUN_FROM_SWAP 0x0800")]
        public const int IMAGE_FILE_NET_RUN_FROM_SWAP = 0x0800;

        [NativeTypeName("#define IMAGE_FILE_SYSTEM 0x1000")]
        public const int IMAGE_FILE_SYSTEM = 0x1000;

        [NativeTypeName("#define IMAGE_FILE_DLL 0x2000")]
        public const int IMAGE_FILE_DLL = 0x2000;

        [NativeTypeName("#define IMAGE_FILE_UP_SYSTEM_ONLY 0x4000")]
        public const int IMAGE_FILE_UP_SYSTEM_ONLY = 0x4000;

        [NativeTypeName("#define IMAGE_FILE_BYTES_REVERSED_HI 0x8000")]
        public const int IMAGE_FILE_BYTES_REVERSED_HI = 0x8000;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_UNKNOWN 0")]
        public const int IMAGE_FILE_MACHINE_UNKNOWN = 0;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_TARGET_HOST 0x0001")]
        public const int IMAGE_FILE_MACHINE_TARGET_HOST = 0x0001;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_I386 0x014c")]
        public const int IMAGE_FILE_MACHINE_I386 = 0x014c;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_R3000 0x0162")]
        public const int IMAGE_FILE_MACHINE_R3000 = 0x0162;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_R4000 0x0166")]
        public const int IMAGE_FILE_MACHINE_R4000 = 0x0166;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_R10000 0x0168")]
        public const int IMAGE_FILE_MACHINE_R10000 = 0x0168;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_WCEMIPSV2 0x0169")]
        public const int IMAGE_FILE_MACHINE_WCEMIPSV2 = 0x0169;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_ALPHA 0x0184")]
        public const int IMAGE_FILE_MACHINE_ALPHA = 0x0184;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_SH3 0x01a2")]
        public const int IMAGE_FILE_MACHINE_SH3 = 0x01a2;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_SH3DSP 0x01a3")]
        public const int IMAGE_FILE_MACHINE_SH3DSP = 0x01a3;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_SH3E 0x01a4")]
        public const int IMAGE_FILE_MACHINE_SH3E = 0x01a4;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_SH4 0x01a6")]
        public const int IMAGE_FILE_MACHINE_SH4 = 0x01a6;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_SH5 0x01a8")]
        public const int IMAGE_FILE_MACHINE_SH5 = 0x01a8;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_ARM 0x01c0")]
        public const int IMAGE_FILE_MACHINE_ARM = 0x01c0;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_THUMB 0x01c2")]
        public const int IMAGE_FILE_MACHINE_THUMB = 0x01c2;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_ARMNT 0x01c4")]
        public const int IMAGE_FILE_MACHINE_ARMNT = 0x01c4;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_AM33 0x01d3")]
        public const int IMAGE_FILE_MACHINE_AM33 = 0x01d3;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_POWERPC 0x01F0")]
        public const int IMAGE_FILE_MACHINE_POWERPC = 0x01F0;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_POWERPCFP 0x01f1")]
        public const int IMAGE_FILE_MACHINE_POWERPCFP = 0x01f1;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_IA64 0x0200")]
        public const int IMAGE_FILE_MACHINE_IA64 = 0x0200;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_MIPS16 0x0266")]
        public const int IMAGE_FILE_MACHINE_MIPS16 = 0x0266;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_ALPHA64 0x0284")]
        public const int IMAGE_FILE_MACHINE_ALPHA64 = 0x0284;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_MIPSFPU 0x0366")]
        public const int IMAGE_FILE_MACHINE_MIPSFPU = 0x0366;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_MIPSFPU16 0x0466")]
        public const int IMAGE_FILE_MACHINE_MIPSFPU16 = 0x0466;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_AXP64 IMAGE_FILE_MACHINE_ALPHA64")]
        public const int IMAGE_FILE_MACHINE_AXP64 = 0x0284;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_TRICORE 0x0520")]
        public const int IMAGE_FILE_MACHINE_TRICORE = 0x0520;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_CEF 0x0CEF")]
        public const int IMAGE_FILE_MACHINE_CEF = 0x0CEF;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_EBC 0x0EBC")]
        public const int IMAGE_FILE_MACHINE_EBC = 0x0EBC;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_AMD64 0x8664")]
        public const int IMAGE_FILE_MACHINE_AMD64 = 0x8664;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_M32R 0x9041")]
        public const int IMAGE_FILE_MACHINE_M32R = 0x9041;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_ARM64 0xAA64")]
        public const int IMAGE_FILE_MACHINE_ARM64 = 0xAA64;

        [NativeTypeName("#define IMAGE_FILE_MACHINE_CEE 0xC0EE")]
        public const int IMAGE_FILE_MACHINE_CEE = 0xC0EE;

        [NativeTypeName("#define IMAGE_NUMBEROF_DIRECTORY_ENTRIES 16")]
        public const int IMAGE_NUMBEROF_DIRECTORY_ENTRIES = 16;

        [NativeTypeName("#define IMAGE_NT_OPTIONAL_HDR32_MAGIC 0x10b")]
        public const int IMAGE_NT_OPTIONAL_HDR32_MAGIC = 0x10b;

        [NativeTypeName("#define IMAGE_NT_OPTIONAL_HDR64_MAGIC 0x20b")]
        public const int IMAGE_NT_OPTIONAL_HDR64_MAGIC = 0x20b;

        [NativeTypeName("#define IMAGE_ROM_OPTIONAL_HDR_MAGIC 0x107")]
        public const int IMAGE_ROM_OPTIONAL_HDR_MAGIC = 0x107;

        [NativeTypeName("#define IMAGE_NT_OPTIONAL_HDR_MAGIC IMAGE_NT_OPTIONAL_HDR32_MAGIC")]
        public const int IMAGE_NT_OPTIONAL_HDR_MAGIC = 0x10b;

        [NativeTypeName("#define IMAGE_SUBSYSTEM_UNKNOWN 0")]
        public const int IMAGE_SUBSYSTEM_UNKNOWN = 0;

        [NativeTypeName("#define IMAGE_SUBSYSTEM_NATIVE 1")]
        public const int IMAGE_SUBSYSTEM_NATIVE = 1;

        [NativeTypeName("#define IMAGE_SUBSYSTEM_WINDOWS_GUI 2")]
        public const int IMAGE_SUBSYSTEM_WINDOWS_GUI = 2;

        [NativeTypeName("#define IMAGE_SUBSYSTEM_WINDOWS_CUI 3")]
        public const int IMAGE_SUBSYSTEM_WINDOWS_CUI = 3;

        [NativeTypeName("#define IMAGE_SUBSYSTEM_OS2_CUI 5")]
        public const int IMAGE_SUBSYSTEM_OS2_CUI = 5;

        [NativeTypeName("#define IMAGE_SUBSYSTEM_POSIX_CUI 7")]
        public const int IMAGE_SUBSYSTEM_POSIX_CUI = 7;

        [NativeTypeName("#define IMAGE_SUBSYSTEM_NATIVE_WINDOWS 8")]
        public const int IMAGE_SUBSYSTEM_NATIVE_WINDOWS = 8;

        [NativeTypeName("#define IMAGE_SUBSYSTEM_WINDOWS_CE_GUI 9")]
        public const int IMAGE_SUBSYSTEM_WINDOWS_CE_GUI = 9;

        [NativeTypeName("#define IMAGE_SUBSYSTEM_EFI_APPLICATION 10")]
        public const int IMAGE_SUBSYSTEM_EFI_APPLICATION = 10;

        [NativeTypeName("#define IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER 11")]
        public const int IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER = 11;

        [NativeTypeName("#define IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER 12")]
        public const int IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER = 12;

        [NativeTypeName("#define IMAGE_SUBSYSTEM_EFI_ROM 13")]
        public const int IMAGE_SUBSYSTEM_EFI_ROM = 13;

        [NativeTypeName("#define IMAGE_SUBSYSTEM_XBOX 14")]
        public const int IMAGE_SUBSYSTEM_XBOX = 14;

        [NativeTypeName("#define IMAGE_SUBSYSTEM_WINDOWS_BOOT_APPLICATION 16")]
        public const int IMAGE_SUBSYSTEM_WINDOWS_BOOT_APPLICATION = 16;

        [NativeTypeName("#define IMAGE_SUBSYSTEM_XBOX_CODE_CATALOG 17")]
        public const int IMAGE_SUBSYSTEM_XBOX_CODE_CATALOG = 17;

        [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_HIGH_ENTROPY_VA 0x0020")]
        public const int IMAGE_DLLCHARACTERISTICS_HIGH_ENTROPY_VA = 0x0020;

        [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_DYNAMIC_BASE 0x0040")]
        public const int IMAGE_DLLCHARACTERISTICS_DYNAMIC_BASE = 0x0040;

        [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_FORCE_INTEGRITY 0x0080")]
        public const int IMAGE_DLLCHARACTERISTICS_FORCE_INTEGRITY = 0x0080;

        [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_NX_COMPAT 0x0100")]
        public const int IMAGE_DLLCHARACTERISTICS_NX_COMPAT = 0x0100;

        [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_NO_ISOLATION 0x0200")]
        public const int IMAGE_DLLCHARACTERISTICS_NO_ISOLATION = 0x0200;

        [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_NO_SEH 0x0400")]
        public const int IMAGE_DLLCHARACTERISTICS_NO_SEH = 0x0400;

        [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_NO_BIND 0x0800")]
        public const int IMAGE_DLLCHARACTERISTICS_NO_BIND = 0x0800;

        [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_APPCONTAINER 0x1000")]
        public const int IMAGE_DLLCHARACTERISTICS_APPCONTAINER = 0x1000;

        [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_WDM_DRIVER 0x2000")]
        public const int IMAGE_DLLCHARACTERISTICS_WDM_DRIVER = 0x2000;

        [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_GUARD_CF 0x4000")]
        public const int IMAGE_DLLCHARACTERISTICS_GUARD_CF = 0x4000;

        [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE 0x8000")]
        public const int IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE = 0x8000;

        [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_EXPORT 0")]
        public const int IMAGE_DIRECTORY_ENTRY_EXPORT = 0;

        [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_IMPORT 1")]
        public const int IMAGE_DIRECTORY_ENTRY_IMPORT = 1;

        [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_RESOURCE 2")]
        public const int IMAGE_DIRECTORY_ENTRY_RESOURCE = 2;

        [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_EXCEPTION 3")]
        public const int IMAGE_DIRECTORY_ENTRY_EXCEPTION = 3;

        [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_SECURITY 4")]
        public const int IMAGE_DIRECTORY_ENTRY_SECURITY = 4;

        [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_BASERELOC 5")]
        public const int IMAGE_DIRECTORY_ENTRY_BASERELOC = 5;

        [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_DEBUG 6")]
        public const int IMAGE_DIRECTORY_ENTRY_DEBUG = 6;

        [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_ARCHITECTURE 7")]
        public const int IMAGE_DIRECTORY_ENTRY_ARCHITECTURE = 7;

        [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_GLOBALPTR 8")]
        public const int IMAGE_DIRECTORY_ENTRY_GLOBALPTR = 8;

        [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_TLS 9")]
        public const int IMAGE_DIRECTORY_ENTRY_TLS = 9;

        [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_LOAD_CONFIG 10")]
        public const int IMAGE_DIRECTORY_ENTRY_LOAD_CONFIG = 10;

        [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_BOUND_IMPORT 11")]
        public const int IMAGE_DIRECTORY_ENTRY_BOUND_IMPORT = 11;

        [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_IAT 12")]
        public const int IMAGE_DIRECTORY_ENTRY_IAT = 12;

        [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_DELAY_IMPORT 13")]
        public const int IMAGE_DIRECTORY_ENTRY_DELAY_IMPORT = 13;

        [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_COM_DESCRIPTOR 14")]
        public const int IMAGE_DIRECTORY_ENTRY_COM_DESCRIPTOR = 14;

        [NativeTypeName("#define IMAGE_SIZEOF_SHORT_NAME 8")]
        public const int IMAGE_SIZEOF_SHORT_NAME = 8;

        [NativeTypeName("#define IMAGE_SIZEOF_SECTION_HEADER 40")]
        public const int IMAGE_SIZEOF_SECTION_HEADER = 40;

        [NativeTypeName("#define IMAGE_SCN_TYPE_NO_PAD 0x00000008")]
        public const int IMAGE_SCN_TYPE_NO_PAD = 0x00000008;

        [NativeTypeName("#define IMAGE_SCN_CNT_CODE 0x00000020")]
        public const int IMAGE_SCN_CNT_CODE = 0x00000020;

        [NativeTypeName("#define IMAGE_SCN_CNT_INITIALIZED_DATA 0x00000040")]
        public const int IMAGE_SCN_CNT_INITIALIZED_DATA = 0x00000040;

        [NativeTypeName("#define IMAGE_SCN_CNT_UNINITIALIZED_DATA 0x00000080")]
        public const int IMAGE_SCN_CNT_UNINITIALIZED_DATA = 0x00000080;

        [NativeTypeName("#define IMAGE_SCN_LNK_OTHER 0x00000100")]
        public const int IMAGE_SCN_LNK_OTHER = 0x00000100;

        [NativeTypeName("#define IMAGE_SCN_LNK_INFO 0x00000200")]
        public const int IMAGE_SCN_LNK_INFO = 0x00000200;

        [NativeTypeName("#define IMAGE_SCN_LNK_REMOVE 0x00000800")]
        public const int IMAGE_SCN_LNK_REMOVE = 0x00000800;

        [NativeTypeName("#define IMAGE_SCN_LNK_COMDAT 0x00001000")]
        public const int IMAGE_SCN_LNK_COMDAT = 0x00001000;

        [NativeTypeName("#define IMAGE_SCN_NO_DEFER_SPEC_EXC 0x00004000")]
        public const int IMAGE_SCN_NO_DEFER_SPEC_EXC = 0x00004000;

        [NativeTypeName("#define IMAGE_SCN_GPREL 0x00008000")]
        public const int IMAGE_SCN_GPREL = 0x00008000;

        [NativeTypeName("#define IMAGE_SCN_MEM_FARDATA 0x00008000")]
        public const int IMAGE_SCN_MEM_FARDATA = 0x00008000;

        [NativeTypeName("#define IMAGE_SCN_MEM_PURGEABLE 0x00020000")]
        public const int IMAGE_SCN_MEM_PURGEABLE = 0x00020000;

        [NativeTypeName("#define IMAGE_SCN_MEM_16BIT 0x00020000")]
        public const int IMAGE_SCN_MEM_16BIT = 0x00020000;

        [NativeTypeName("#define IMAGE_SCN_MEM_LOCKED 0x00040000")]
        public const int IMAGE_SCN_MEM_LOCKED = 0x00040000;

        [NativeTypeName("#define IMAGE_SCN_MEM_PRELOAD 0x00080000")]
        public const int IMAGE_SCN_MEM_PRELOAD = 0x00080000;

        [NativeTypeName("#define IMAGE_SCN_ALIGN_1BYTES 0x00100000")]
        public const int IMAGE_SCN_ALIGN_1BYTES = 0x00100000;

        [NativeTypeName("#define IMAGE_SCN_ALIGN_2BYTES 0x00200000")]
        public const int IMAGE_SCN_ALIGN_2BYTES = 0x00200000;

        [NativeTypeName("#define IMAGE_SCN_ALIGN_4BYTES 0x00300000")]
        public const int IMAGE_SCN_ALIGN_4BYTES = 0x00300000;

        [NativeTypeName("#define IMAGE_SCN_ALIGN_8BYTES 0x00400000")]
        public const int IMAGE_SCN_ALIGN_8BYTES = 0x00400000;

        [NativeTypeName("#define IMAGE_SCN_ALIGN_16BYTES 0x00500000")]
        public const int IMAGE_SCN_ALIGN_16BYTES = 0x00500000;

        [NativeTypeName("#define IMAGE_SCN_ALIGN_32BYTES 0x00600000")]
        public const int IMAGE_SCN_ALIGN_32BYTES = 0x00600000;

        [NativeTypeName("#define IMAGE_SCN_ALIGN_64BYTES 0x00700000")]
        public const int IMAGE_SCN_ALIGN_64BYTES = 0x00700000;

        [NativeTypeName("#define IMAGE_SCN_ALIGN_128BYTES 0x00800000")]
        public const int IMAGE_SCN_ALIGN_128BYTES = 0x00800000;

        [NativeTypeName("#define IMAGE_SCN_ALIGN_256BYTES 0x00900000")]
        public const int IMAGE_SCN_ALIGN_256BYTES = 0x00900000;

        [NativeTypeName("#define IMAGE_SCN_ALIGN_512BYTES 0x00A00000")]
        public const int IMAGE_SCN_ALIGN_512BYTES = 0x00A00000;

        [NativeTypeName("#define IMAGE_SCN_ALIGN_1024BYTES 0x00B00000")]
        public const int IMAGE_SCN_ALIGN_1024BYTES = 0x00B00000;

        [NativeTypeName("#define IMAGE_SCN_ALIGN_2048BYTES 0x00C00000")]
        public const int IMAGE_SCN_ALIGN_2048BYTES = 0x00C00000;

        [NativeTypeName("#define IMAGE_SCN_ALIGN_4096BYTES 0x00D00000")]
        public const int IMAGE_SCN_ALIGN_4096BYTES = 0x00D00000;

        [NativeTypeName("#define IMAGE_SCN_ALIGN_8192BYTES 0x00E00000")]
        public const int IMAGE_SCN_ALIGN_8192BYTES = 0x00E00000;

        [NativeTypeName("#define IMAGE_SCN_ALIGN_MASK 0x00F00000")]
        public const int IMAGE_SCN_ALIGN_MASK = 0x00F00000;

        [NativeTypeName("#define IMAGE_SCN_LNK_NRELOC_OVFL 0x01000000")]
        public const int IMAGE_SCN_LNK_NRELOC_OVFL = 0x01000000;

        [NativeTypeName("#define IMAGE_SCN_MEM_DISCARDABLE 0x02000000")]
        public const int IMAGE_SCN_MEM_DISCARDABLE = 0x02000000;

        [NativeTypeName("#define IMAGE_SCN_MEM_NOT_CACHED 0x04000000")]
        public const int IMAGE_SCN_MEM_NOT_CACHED = 0x04000000;

        [NativeTypeName("#define IMAGE_SCN_MEM_NOT_PAGED 0x08000000")]
        public const int IMAGE_SCN_MEM_NOT_PAGED = 0x08000000;

        [NativeTypeName("#define IMAGE_SCN_MEM_SHARED 0x10000000")]
        public const int IMAGE_SCN_MEM_SHARED = 0x10000000;

        [NativeTypeName("#define IMAGE_SCN_MEM_EXECUTE 0x20000000")]
        public const int IMAGE_SCN_MEM_EXECUTE = 0x20000000;

        [NativeTypeName("#define IMAGE_SCN_MEM_READ 0x40000000")]
        public const int IMAGE_SCN_MEM_READ = 0x40000000;

        [NativeTypeName("#define IMAGE_SCN_MEM_WRITE 0x80000000")]
        public const uint IMAGE_SCN_MEM_WRITE = 0x80000000;

        [NativeTypeName("#define IMAGE_SCN_SCALE_INDEX 0x00000001")]
        public const int IMAGE_SCN_SCALE_INDEX = 0x00000001;

        [NativeTypeName("#define IMAGE_SIZEOF_SYMBOL 18")]
        public const int IMAGE_SIZEOF_SYMBOL = 18;

        [NativeTypeName("#define IMAGE_SYM_UNDEFINED (SHORT)0")]
        public const short IMAGE_SYM_UNDEFINED = (short)(0);

        [NativeTypeName("#define IMAGE_SYM_ABSOLUTE (SHORT)-1")]
        public const short IMAGE_SYM_ABSOLUTE = (short)(-1);

        [NativeTypeName("#define IMAGE_SYM_DEBUG (SHORT)-2")]
        public const short IMAGE_SYM_DEBUG = (short)(-2);

        [NativeTypeName("#define IMAGE_SYM_SECTION_MAX 0xFEFF")]
        public const int IMAGE_SYM_SECTION_MAX = 0xFEFF;

        [NativeTypeName("#define IMAGE_SYM_SECTION_MAX_EX MAXLONG")]
        public const int IMAGE_SYM_SECTION_MAX_EX = 0x7fffffff;

        [NativeTypeName("#define IMAGE_SYM_TYPE_NULL 0x0000")]
        public const int IMAGE_SYM_TYPE_NULL = 0x0000;

        [NativeTypeName("#define IMAGE_SYM_TYPE_VOID 0x0001")]
        public const int IMAGE_SYM_TYPE_VOID = 0x0001;

        [NativeTypeName("#define IMAGE_SYM_TYPE_CHAR 0x0002")]
        public const int IMAGE_SYM_TYPE_CHAR = 0x0002;

        [NativeTypeName("#define IMAGE_SYM_TYPE_SHORT 0x0003")]
        public const int IMAGE_SYM_TYPE_SHORT = 0x0003;

        [NativeTypeName("#define IMAGE_SYM_TYPE_INT 0x0004")]
        public const int IMAGE_SYM_TYPE_INT = 0x0004;

        [NativeTypeName("#define IMAGE_SYM_TYPE_LONG 0x0005")]
        public const int IMAGE_SYM_TYPE_LONG = 0x0005;

        [NativeTypeName("#define IMAGE_SYM_TYPE_FLOAT 0x0006")]
        public const int IMAGE_SYM_TYPE_FLOAT = 0x0006;

        [NativeTypeName("#define IMAGE_SYM_TYPE_DOUBLE 0x0007")]
        public const int IMAGE_SYM_TYPE_DOUBLE = 0x0007;

        [NativeTypeName("#define IMAGE_SYM_TYPE_STRUCT 0x0008")]
        public const int IMAGE_SYM_TYPE_STRUCT = 0x0008;

        [NativeTypeName("#define IMAGE_SYM_TYPE_UNION 0x0009")]
        public const int IMAGE_SYM_TYPE_UNION = 0x0009;

        [NativeTypeName("#define IMAGE_SYM_TYPE_ENUM 0x000A")]
        public const int IMAGE_SYM_TYPE_ENUM = 0x000A;

        [NativeTypeName("#define IMAGE_SYM_TYPE_MOE 0x000B")]
        public const int IMAGE_SYM_TYPE_MOE = 0x000B;

        [NativeTypeName("#define IMAGE_SYM_TYPE_BYTE 0x000C")]
        public const int IMAGE_SYM_TYPE_BYTE = 0x000C;

        [NativeTypeName("#define IMAGE_SYM_TYPE_WORD 0x000D")]
        public const int IMAGE_SYM_TYPE_WORD = 0x000D;

        [NativeTypeName("#define IMAGE_SYM_TYPE_UINT 0x000E")]
        public const int IMAGE_SYM_TYPE_UINT = 0x000E;

        [NativeTypeName("#define IMAGE_SYM_TYPE_DWORD 0x000F")]
        public const int IMAGE_SYM_TYPE_DWORD = 0x000F;

        [NativeTypeName("#define IMAGE_SYM_TYPE_PCODE 0x8000")]
        public const int IMAGE_SYM_TYPE_PCODE = 0x8000;

        [NativeTypeName("#define IMAGE_SYM_DTYPE_NULL 0")]
        public const int IMAGE_SYM_DTYPE_NULL = 0;

        [NativeTypeName("#define IMAGE_SYM_DTYPE_POINTER 1")]
        public const int IMAGE_SYM_DTYPE_POINTER = 1;

        [NativeTypeName("#define IMAGE_SYM_DTYPE_FUNCTION 2")]
        public const int IMAGE_SYM_DTYPE_FUNCTION = 2;

        [NativeTypeName("#define IMAGE_SYM_DTYPE_ARRAY 3")]
        public const int IMAGE_SYM_DTYPE_ARRAY = 3;

        [NativeTypeName("#define IMAGE_SYM_CLASS_END_OF_FUNCTION (BYTE )-1")]
        public const byte IMAGE_SYM_CLASS_END_OF_FUNCTION = unchecked((byte)(-1));

        [NativeTypeName("#define IMAGE_SYM_CLASS_NULL 0x0000")]
        public const int IMAGE_SYM_CLASS_NULL = 0x0000;

        [NativeTypeName("#define IMAGE_SYM_CLASS_AUTOMATIC 0x0001")]
        public const int IMAGE_SYM_CLASS_AUTOMATIC = 0x0001;

        [NativeTypeName("#define IMAGE_SYM_CLASS_EXTERNAL 0x0002")]
        public const int IMAGE_SYM_CLASS_EXTERNAL = 0x0002;

        [NativeTypeName("#define IMAGE_SYM_CLASS_STATIC 0x0003")]
        public const int IMAGE_SYM_CLASS_STATIC = 0x0003;

        [NativeTypeName("#define IMAGE_SYM_CLASS_REGISTER 0x0004")]
        public const int IMAGE_SYM_CLASS_REGISTER = 0x0004;

        [NativeTypeName("#define IMAGE_SYM_CLASS_EXTERNAL_DEF 0x0005")]
        public const int IMAGE_SYM_CLASS_EXTERNAL_DEF = 0x0005;

        [NativeTypeName("#define IMAGE_SYM_CLASS_LABEL 0x0006")]
        public const int IMAGE_SYM_CLASS_LABEL = 0x0006;

        [NativeTypeName("#define IMAGE_SYM_CLASS_UNDEFINED_LABEL 0x0007")]
        public const int IMAGE_SYM_CLASS_UNDEFINED_LABEL = 0x0007;

        [NativeTypeName("#define IMAGE_SYM_CLASS_MEMBER_OF_STRUCT 0x0008")]
        public const int IMAGE_SYM_CLASS_MEMBER_OF_STRUCT = 0x0008;

        [NativeTypeName("#define IMAGE_SYM_CLASS_ARGUMENT 0x0009")]
        public const int IMAGE_SYM_CLASS_ARGUMENT = 0x0009;

        [NativeTypeName("#define IMAGE_SYM_CLASS_STRUCT_TAG 0x000A")]
        public const int IMAGE_SYM_CLASS_STRUCT_TAG = 0x000A;

        [NativeTypeName("#define IMAGE_SYM_CLASS_MEMBER_OF_UNION 0x000B")]
        public const int IMAGE_SYM_CLASS_MEMBER_OF_UNION = 0x000B;

        [NativeTypeName("#define IMAGE_SYM_CLASS_UNION_TAG 0x000C")]
        public const int IMAGE_SYM_CLASS_UNION_TAG = 0x000C;

        [NativeTypeName("#define IMAGE_SYM_CLASS_TYPE_DEFINITION 0x000D")]
        public const int IMAGE_SYM_CLASS_TYPE_DEFINITION = 0x000D;

        [NativeTypeName("#define IMAGE_SYM_CLASS_UNDEFINED_STATIC 0x000E")]
        public const int IMAGE_SYM_CLASS_UNDEFINED_STATIC = 0x000E;

        [NativeTypeName("#define IMAGE_SYM_CLASS_ENUM_TAG 0x000F")]
        public const int IMAGE_SYM_CLASS_ENUM_TAG = 0x000F;

        [NativeTypeName("#define IMAGE_SYM_CLASS_MEMBER_OF_ENUM 0x0010")]
        public const int IMAGE_SYM_CLASS_MEMBER_OF_ENUM = 0x0010;

        [NativeTypeName("#define IMAGE_SYM_CLASS_REGISTER_PARAM 0x0011")]
        public const int IMAGE_SYM_CLASS_REGISTER_PARAM = 0x0011;

        [NativeTypeName("#define IMAGE_SYM_CLASS_BIT_FIELD 0x0012")]
        public const int IMAGE_SYM_CLASS_BIT_FIELD = 0x0012;

        [NativeTypeName("#define IMAGE_SYM_CLASS_FAR_EXTERNAL 0x0044")]
        public const int IMAGE_SYM_CLASS_FAR_EXTERNAL = 0x0044;

        [NativeTypeName("#define IMAGE_SYM_CLASS_BLOCK 0x0064")]
        public const int IMAGE_SYM_CLASS_BLOCK = 0x0064;

        [NativeTypeName("#define IMAGE_SYM_CLASS_FUNCTION 0x0065")]
        public const int IMAGE_SYM_CLASS_FUNCTION = 0x0065;

        [NativeTypeName("#define IMAGE_SYM_CLASS_END_OF_STRUCT 0x0066")]
        public const int IMAGE_SYM_CLASS_END_OF_STRUCT = 0x0066;

        [NativeTypeName("#define IMAGE_SYM_CLASS_FILE 0x0067")]
        public const int IMAGE_SYM_CLASS_FILE = 0x0067;

        [NativeTypeName("#define IMAGE_SYM_CLASS_SECTION 0x0068")]
        public const int IMAGE_SYM_CLASS_SECTION = 0x0068;

        [NativeTypeName("#define IMAGE_SYM_CLASS_WEAK_EXTERNAL 0x0069")]
        public const int IMAGE_SYM_CLASS_WEAK_EXTERNAL = 0x0069;

        [NativeTypeName("#define IMAGE_SYM_CLASS_CLR_TOKEN 0x006B")]
        public const int IMAGE_SYM_CLASS_CLR_TOKEN = 0x006B;

        [NativeTypeName("#define N_BTMASK 0x000F")]
        public const int N_BTMASK = 0x000F;

        [NativeTypeName("#define N_TMASK 0x0030")]
        public const int N_TMASK = 0x0030;

        [NativeTypeName("#define N_TMASK1 0x00C0")]
        public const int N_TMASK1 = 0x00C0;

        [NativeTypeName("#define N_TMASK2 0x00F0")]
        public const int N_TMASK2 = 0x00F0;

        [NativeTypeName("#define N_BTSHFT 4")]
        public const int N_BTSHFT = 4;

        [NativeTypeName("#define N_TSHIFT 2")]
        public const int N_TSHIFT = 2;

        [NativeTypeName("#define IMAGE_COMDAT_SELECT_NODUPLICATES 1")]
        public const int IMAGE_COMDAT_SELECT_NODUPLICATES = 1;

        [NativeTypeName("#define IMAGE_COMDAT_SELECT_ANY 2")]
        public const int IMAGE_COMDAT_SELECT_ANY = 2;

        [NativeTypeName("#define IMAGE_COMDAT_SELECT_SAME_SIZE 3")]
        public const int IMAGE_COMDAT_SELECT_SAME_SIZE = 3;

        [NativeTypeName("#define IMAGE_COMDAT_SELECT_EXACT_MATCH 4")]
        public const int IMAGE_COMDAT_SELECT_EXACT_MATCH = 4;

        [NativeTypeName("#define IMAGE_COMDAT_SELECT_ASSOCIATIVE 5")]
        public const int IMAGE_COMDAT_SELECT_ASSOCIATIVE = 5;

        [NativeTypeName("#define IMAGE_COMDAT_SELECT_LARGEST 6")]
        public const int IMAGE_COMDAT_SELECT_LARGEST = 6;

        [NativeTypeName("#define IMAGE_COMDAT_SELECT_NEWEST 7")]
        public const int IMAGE_COMDAT_SELECT_NEWEST = 7;

        [NativeTypeName("#define IMAGE_WEAK_EXTERN_SEARCH_NOLIBRARY 1")]
        public const int IMAGE_WEAK_EXTERN_SEARCH_NOLIBRARY = 1;

        [NativeTypeName("#define IMAGE_WEAK_EXTERN_SEARCH_LIBRARY 2")]
        public const int IMAGE_WEAK_EXTERN_SEARCH_LIBRARY = 2;

        [NativeTypeName("#define IMAGE_WEAK_EXTERN_SEARCH_ALIAS 3")]
        public const int IMAGE_WEAK_EXTERN_SEARCH_ALIAS = 3;

        [NativeTypeName("#define IMAGE_WEAK_EXTERN_ANTI_DEPENDENCY 4")]
        public const int IMAGE_WEAK_EXTERN_ANTI_DEPENDENCY = 4;

        [NativeTypeName("#define IMAGE_REL_I386_ABSOLUTE 0x0000")]
        public const int IMAGE_REL_I386_ABSOLUTE = 0x0000;

        [NativeTypeName("#define IMAGE_REL_I386_DIR16 0x0001")]
        public const int IMAGE_REL_I386_DIR16 = 0x0001;

        [NativeTypeName("#define IMAGE_REL_I386_REL16 0x0002")]
        public const int IMAGE_REL_I386_REL16 = 0x0002;

        [NativeTypeName("#define IMAGE_REL_I386_DIR32 0x0006")]
        public const int IMAGE_REL_I386_DIR32 = 0x0006;

        [NativeTypeName("#define IMAGE_REL_I386_DIR32NB 0x0007")]
        public const int IMAGE_REL_I386_DIR32NB = 0x0007;

        [NativeTypeName("#define IMAGE_REL_I386_SEG12 0x0009")]
        public const int IMAGE_REL_I386_SEG12 = 0x0009;

        [NativeTypeName("#define IMAGE_REL_I386_SECTION 0x000A")]
        public const int IMAGE_REL_I386_SECTION = 0x000A;

        [NativeTypeName("#define IMAGE_REL_I386_SECREL 0x000B")]
        public const int IMAGE_REL_I386_SECREL = 0x000B;

        [NativeTypeName("#define IMAGE_REL_I386_TOKEN 0x000C")]
        public const int IMAGE_REL_I386_TOKEN = 0x000C;

        [NativeTypeName("#define IMAGE_REL_I386_SECREL7 0x000D")]
        public const int IMAGE_REL_I386_SECREL7 = 0x000D;

        [NativeTypeName("#define IMAGE_REL_I386_REL32 0x0014")]
        public const int IMAGE_REL_I386_REL32 = 0x0014;

        [NativeTypeName("#define IMAGE_REL_MIPS_ABSOLUTE 0x0000")]
        public const int IMAGE_REL_MIPS_ABSOLUTE = 0x0000;

        [NativeTypeName("#define IMAGE_REL_MIPS_REFHALF 0x0001")]
        public const int IMAGE_REL_MIPS_REFHALF = 0x0001;

        [NativeTypeName("#define IMAGE_REL_MIPS_REFWORD 0x0002")]
        public const int IMAGE_REL_MIPS_REFWORD = 0x0002;

        [NativeTypeName("#define IMAGE_REL_MIPS_JMPADDR 0x0003")]
        public const int IMAGE_REL_MIPS_JMPADDR = 0x0003;

        [NativeTypeName("#define IMAGE_REL_MIPS_REFHI 0x0004")]
        public const int IMAGE_REL_MIPS_REFHI = 0x0004;

        [NativeTypeName("#define IMAGE_REL_MIPS_REFLO 0x0005")]
        public const int IMAGE_REL_MIPS_REFLO = 0x0005;

        [NativeTypeName("#define IMAGE_REL_MIPS_GPREL 0x0006")]
        public const int IMAGE_REL_MIPS_GPREL = 0x0006;

        [NativeTypeName("#define IMAGE_REL_MIPS_LITERAL 0x0007")]
        public const int IMAGE_REL_MIPS_LITERAL = 0x0007;

        [NativeTypeName("#define IMAGE_REL_MIPS_SECTION 0x000A")]
        public const int IMAGE_REL_MIPS_SECTION = 0x000A;

        [NativeTypeName("#define IMAGE_REL_MIPS_SECREL 0x000B")]
        public const int IMAGE_REL_MIPS_SECREL = 0x000B;

        [NativeTypeName("#define IMAGE_REL_MIPS_SECRELLO 0x000C")]
        public const int IMAGE_REL_MIPS_SECRELLO = 0x000C;

        [NativeTypeName("#define IMAGE_REL_MIPS_SECRELHI 0x000D")]
        public const int IMAGE_REL_MIPS_SECRELHI = 0x000D;

        [NativeTypeName("#define IMAGE_REL_MIPS_TOKEN 0x000E")]
        public const int IMAGE_REL_MIPS_TOKEN = 0x000E;

        [NativeTypeName("#define IMAGE_REL_MIPS_JMPADDR16 0x0010")]
        public const int IMAGE_REL_MIPS_JMPADDR16 = 0x0010;

        [NativeTypeName("#define IMAGE_REL_MIPS_REFWORDNB 0x0022")]
        public const int IMAGE_REL_MIPS_REFWORDNB = 0x0022;

        [NativeTypeName("#define IMAGE_REL_MIPS_PAIR 0x0025")]
        public const int IMAGE_REL_MIPS_PAIR = 0x0025;

        [NativeTypeName("#define IMAGE_REL_ALPHA_ABSOLUTE 0x0000")]
        public const int IMAGE_REL_ALPHA_ABSOLUTE = 0x0000;

        [NativeTypeName("#define IMAGE_REL_ALPHA_REFLONG 0x0001")]
        public const int IMAGE_REL_ALPHA_REFLONG = 0x0001;

        [NativeTypeName("#define IMAGE_REL_ALPHA_REFQUAD 0x0002")]
        public const int IMAGE_REL_ALPHA_REFQUAD = 0x0002;

        [NativeTypeName("#define IMAGE_REL_ALPHA_GPREL32 0x0003")]
        public const int IMAGE_REL_ALPHA_GPREL32 = 0x0003;

        [NativeTypeName("#define IMAGE_REL_ALPHA_LITERAL 0x0004")]
        public const int IMAGE_REL_ALPHA_LITERAL = 0x0004;

        [NativeTypeName("#define IMAGE_REL_ALPHA_LITUSE 0x0005")]
        public const int IMAGE_REL_ALPHA_LITUSE = 0x0005;

        [NativeTypeName("#define IMAGE_REL_ALPHA_GPDISP 0x0006")]
        public const int IMAGE_REL_ALPHA_GPDISP = 0x0006;

        [NativeTypeName("#define IMAGE_REL_ALPHA_BRADDR 0x0007")]
        public const int IMAGE_REL_ALPHA_BRADDR = 0x0007;

        [NativeTypeName("#define IMAGE_REL_ALPHA_HINT 0x0008")]
        public const int IMAGE_REL_ALPHA_HINT = 0x0008;

        [NativeTypeName("#define IMAGE_REL_ALPHA_INLINE_REFLONG 0x0009")]
        public const int IMAGE_REL_ALPHA_INLINE_REFLONG = 0x0009;

        [NativeTypeName("#define IMAGE_REL_ALPHA_REFHI 0x000A")]
        public const int IMAGE_REL_ALPHA_REFHI = 0x000A;

        [NativeTypeName("#define IMAGE_REL_ALPHA_REFLO 0x000B")]
        public const int IMAGE_REL_ALPHA_REFLO = 0x000B;

        [NativeTypeName("#define IMAGE_REL_ALPHA_PAIR 0x000C")]
        public const int IMAGE_REL_ALPHA_PAIR = 0x000C;

        [NativeTypeName("#define IMAGE_REL_ALPHA_MATCH 0x000D")]
        public const int IMAGE_REL_ALPHA_MATCH = 0x000D;

        [NativeTypeName("#define IMAGE_REL_ALPHA_SECTION 0x000E")]
        public const int IMAGE_REL_ALPHA_SECTION = 0x000E;

        [NativeTypeName("#define IMAGE_REL_ALPHA_SECREL 0x000F")]
        public const int IMAGE_REL_ALPHA_SECREL = 0x000F;

        [NativeTypeName("#define IMAGE_REL_ALPHA_REFLONGNB 0x0010")]
        public const int IMAGE_REL_ALPHA_REFLONGNB = 0x0010;

        [NativeTypeName("#define IMAGE_REL_ALPHA_SECRELLO 0x0011")]
        public const int IMAGE_REL_ALPHA_SECRELLO = 0x0011;

        [NativeTypeName("#define IMAGE_REL_ALPHA_SECRELHI 0x0012")]
        public const int IMAGE_REL_ALPHA_SECRELHI = 0x0012;

        [NativeTypeName("#define IMAGE_REL_ALPHA_REFQ3 0x0013")]
        public const int IMAGE_REL_ALPHA_REFQ3 = 0x0013;

        [NativeTypeName("#define IMAGE_REL_ALPHA_REFQ2 0x0014")]
        public const int IMAGE_REL_ALPHA_REFQ2 = 0x0014;

        [NativeTypeName("#define IMAGE_REL_ALPHA_REFQ1 0x0015")]
        public const int IMAGE_REL_ALPHA_REFQ1 = 0x0015;

        [NativeTypeName("#define IMAGE_REL_ALPHA_GPRELLO 0x0016")]
        public const int IMAGE_REL_ALPHA_GPRELLO = 0x0016;

        [NativeTypeName("#define IMAGE_REL_ALPHA_GPRELHI 0x0017")]
        public const int IMAGE_REL_ALPHA_GPRELHI = 0x0017;

        [NativeTypeName("#define IMAGE_REL_PPC_ABSOLUTE 0x0000")]
        public const int IMAGE_REL_PPC_ABSOLUTE = 0x0000;

        [NativeTypeName("#define IMAGE_REL_PPC_ADDR64 0x0001")]
        public const int IMAGE_REL_PPC_ADDR64 = 0x0001;

        [NativeTypeName("#define IMAGE_REL_PPC_ADDR32 0x0002")]
        public const int IMAGE_REL_PPC_ADDR32 = 0x0002;

        [NativeTypeName("#define IMAGE_REL_PPC_ADDR24 0x0003")]
        public const int IMAGE_REL_PPC_ADDR24 = 0x0003;

        [NativeTypeName("#define IMAGE_REL_PPC_ADDR16 0x0004")]
        public const int IMAGE_REL_PPC_ADDR16 = 0x0004;

        [NativeTypeName("#define IMAGE_REL_PPC_ADDR14 0x0005")]
        public const int IMAGE_REL_PPC_ADDR14 = 0x0005;

        [NativeTypeName("#define IMAGE_REL_PPC_REL24 0x0006")]
        public const int IMAGE_REL_PPC_REL24 = 0x0006;

        [NativeTypeName("#define IMAGE_REL_PPC_REL14 0x0007")]
        public const int IMAGE_REL_PPC_REL14 = 0x0007;

        [NativeTypeName("#define IMAGE_REL_PPC_TOCREL16 0x0008")]
        public const int IMAGE_REL_PPC_TOCREL16 = 0x0008;

        [NativeTypeName("#define IMAGE_REL_PPC_TOCREL14 0x0009")]
        public const int IMAGE_REL_PPC_TOCREL14 = 0x0009;

        [NativeTypeName("#define IMAGE_REL_PPC_ADDR32NB 0x000A")]
        public const int IMAGE_REL_PPC_ADDR32NB = 0x000A;

        [NativeTypeName("#define IMAGE_REL_PPC_SECREL 0x000B")]
        public const int IMAGE_REL_PPC_SECREL = 0x000B;

        [NativeTypeName("#define IMAGE_REL_PPC_SECTION 0x000C")]
        public const int IMAGE_REL_PPC_SECTION = 0x000C;

        [NativeTypeName("#define IMAGE_REL_PPC_IFGLUE 0x000D")]
        public const int IMAGE_REL_PPC_IFGLUE = 0x000D;

        [NativeTypeName("#define IMAGE_REL_PPC_IMGLUE 0x000E")]
        public const int IMAGE_REL_PPC_IMGLUE = 0x000E;

        [NativeTypeName("#define IMAGE_REL_PPC_SECREL16 0x000F")]
        public const int IMAGE_REL_PPC_SECREL16 = 0x000F;

        [NativeTypeName("#define IMAGE_REL_PPC_REFHI 0x0010")]
        public const int IMAGE_REL_PPC_REFHI = 0x0010;

        [NativeTypeName("#define IMAGE_REL_PPC_REFLO 0x0011")]
        public const int IMAGE_REL_PPC_REFLO = 0x0011;

        [NativeTypeName("#define IMAGE_REL_PPC_PAIR 0x0012")]
        public const int IMAGE_REL_PPC_PAIR = 0x0012;

        [NativeTypeName("#define IMAGE_REL_PPC_SECRELLO 0x0013")]
        public const int IMAGE_REL_PPC_SECRELLO = 0x0013;

        [NativeTypeName("#define IMAGE_REL_PPC_SECRELHI 0x0014")]
        public const int IMAGE_REL_PPC_SECRELHI = 0x0014;

        [NativeTypeName("#define IMAGE_REL_PPC_GPREL 0x0015")]
        public const int IMAGE_REL_PPC_GPREL = 0x0015;

        [NativeTypeName("#define IMAGE_REL_PPC_TOKEN 0x0016")]
        public const int IMAGE_REL_PPC_TOKEN = 0x0016;

        [NativeTypeName("#define IMAGE_REL_PPC_TYPEMASK 0x00FF")]
        public const int IMAGE_REL_PPC_TYPEMASK = 0x00FF;

        [NativeTypeName("#define IMAGE_REL_PPC_NEG 0x0100")]
        public const int IMAGE_REL_PPC_NEG = 0x0100;

        [NativeTypeName("#define IMAGE_REL_PPC_BRTAKEN 0x0200")]
        public const int IMAGE_REL_PPC_BRTAKEN = 0x0200;

        [NativeTypeName("#define IMAGE_REL_PPC_BRNTAKEN 0x0400")]
        public const int IMAGE_REL_PPC_BRNTAKEN = 0x0400;

        [NativeTypeName("#define IMAGE_REL_PPC_TOCDEFN 0x0800")]
        public const int IMAGE_REL_PPC_TOCDEFN = 0x0800;

        [NativeTypeName("#define IMAGE_REL_SH3_ABSOLUTE 0x0000")]
        public const int IMAGE_REL_SH3_ABSOLUTE = 0x0000;

        [NativeTypeName("#define IMAGE_REL_SH3_DIRECT16 0x0001")]
        public const int IMAGE_REL_SH3_DIRECT16 = 0x0001;

        [NativeTypeName("#define IMAGE_REL_SH3_DIRECT32 0x0002")]
        public const int IMAGE_REL_SH3_DIRECT32 = 0x0002;

        [NativeTypeName("#define IMAGE_REL_SH3_DIRECT8 0x0003")]
        public const int IMAGE_REL_SH3_DIRECT8 = 0x0003;

        [NativeTypeName("#define IMAGE_REL_SH3_DIRECT8_WORD 0x0004")]
        public const int IMAGE_REL_SH3_DIRECT8_WORD = 0x0004;

        [NativeTypeName("#define IMAGE_REL_SH3_DIRECT8_LONG 0x0005")]
        public const int IMAGE_REL_SH3_DIRECT8_LONG = 0x0005;

        [NativeTypeName("#define IMAGE_REL_SH3_DIRECT4 0x0006")]
        public const int IMAGE_REL_SH3_DIRECT4 = 0x0006;

        [NativeTypeName("#define IMAGE_REL_SH3_DIRECT4_WORD 0x0007")]
        public const int IMAGE_REL_SH3_DIRECT4_WORD = 0x0007;

        [NativeTypeName("#define IMAGE_REL_SH3_DIRECT4_LONG 0x0008")]
        public const int IMAGE_REL_SH3_DIRECT4_LONG = 0x0008;

        [NativeTypeName("#define IMAGE_REL_SH3_PCREL8_WORD 0x0009")]
        public const int IMAGE_REL_SH3_PCREL8_WORD = 0x0009;

        [NativeTypeName("#define IMAGE_REL_SH3_PCREL8_LONG 0x000A")]
        public const int IMAGE_REL_SH3_PCREL8_LONG = 0x000A;

        [NativeTypeName("#define IMAGE_REL_SH3_PCREL12_WORD 0x000B")]
        public const int IMAGE_REL_SH3_PCREL12_WORD = 0x000B;

        [NativeTypeName("#define IMAGE_REL_SH3_STARTOF_SECTION 0x000C")]
        public const int IMAGE_REL_SH3_STARTOF_SECTION = 0x000C;

        [NativeTypeName("#define IMAGE_REL_SH3_SIZEOF_SECTION 0x000D")]
        public const int IMAGE_REL_SH3_SIZEOF_SECTION = 0x000D;

        [NativeTypeName("#define IMAGE_REL_SH3_SECTION 0x000E")]
        public const int IMAGE_REL_SH3_SECTION = 0x000E;

        [NativeTypeName("#define IMAGE_REL_SH3_SECREL 0x000F")]
        public const int IMAGE_REL_SH3_SECREL = 0x000F;

        [NativeTypeName("#define IMAGE_REL_SH3_DIRECT32_NB 0x0010")]
        public const int IMAGE_REL_SH3_DIRECT32_NB = 0x0010;

        [NativeTypeName("#define IMAGE_REL_SH3_GPREL4_LONG 0x0011")]
        public const int IMAGE_REL_SH3_GPREL4_LONG = 0x0011;

        [NativeTypeName("#define IMAGE_REL_SH3_TOKEN 0x0012")]
        public const int IMAGE_REL_SH3_TOKEN = 0x0012;

        [NativeTypeName("#define IMAGE_REL_SHM_PCRELPT 0x0013")]
        public const int IMAGE_REL_SHM_PCRELPT = 0x0013;

        [NativeTypeName("#define IMAGE_REL_SHM_REFLO 0x0014")]
        public const int IMAGE_REL_SHM_REFLO = 0x0014;

        [NativeTypeName("#define IMAGE_REL_SHM_REFHALF 0x0015")]
        public const int IMAGE_REL_SHM_REFHALF = 0x0015;

        [NativeTypeName("#define IMAGE_REL_SHM_RELLO 0x0016")]
        public const int IMAGE_REL_SHM_RELLO = 0x0016;

        [NativeTypeName("#define IMAGE_REL_SHM_RELHALF 0x0017")]
        public const int IMAGE_REL_SHM_RELHALF = 0x0017;

        [NativeTypeName("#define IMAGE_REL_SHM_PAIR 0x0018")]
        public const int IMAGE_REL_SHM_PAIR = 0x0018;

        [NativeTypeName("#define IMAGE_REL_SH_NOMODE 0x8000")]
        public const int IMAGE_REL_SH_NOMODE = 0x8000;

        [NativeTypeName("#define IMAGE_REL_ARM_ABSOLUTE 0x0000")]
        public const int IMAGE_REL_ARM_ABSOLUTE = 0x0000;

        [NativeTypeName("#define IMAGE_REL_ARM_ADDR32 0x0001")]
        public const int IMAGE_REL_ARM_ADDR32 = 0x0001;

        [NativeTypeName("#define IMAGE_REL_ARM_ADDR32NB 0x0002")]
        public const int IMAGE_REL_ARM_ADDR32NB = 0x0002;

        [NativeTypeName("#define IMAGE_REL_ARM_BRANCH24 0x0003")]
        public const int IMAGE_REL_ARM_BRANCH24 = 0x0003;

        [NativeTypeName("#define IMAGE_REL_ARM_BRANCH11 0x0004")]
        public const int IMAGE_REL_ARM_BRANCH11 = 0x0004;

        [NativeTypeName("#define IMAGE_REL_ARM_TOKEN 0x0005")]
        public const int IMAGE_REL_ARM_TOKEN = 0x0005;

        [NativeTypeName("#define IMAGE_REL_ARM_GPREL12 0x0006")]
        public const int IMAGE_REL_ARM_GPREL12 = 0x0006;

        [NativeTypeName("#define IMAGE_REL_ARM_GPREL7 0x0007")]
        public const int IMAGE_REL_ARM_GPREL7 = 0x0007;

        [NativeTypeName("#define IMAGE_REL_ARM_BLX24 0x0008")]
        public const int IMAGE_REL_ARM_BLX24 = 0x0008;

        [NativeTypeName("#define IMAGE_REL_ARM_BLX11 0x0009")]
        public const int IMAGE_REL_ARM_BLX11 = 0x0009;

        [NativeTypeName("#define IMAGE_REL_ARM_SECTION 0x000E")]
        public const int IMAGE_REL_ARM_SECTION = 0x000E;

        [NativeTypeName("#define IMAGE_REL_ARM_SECREL 0x000F")]
        public const int IMAGE_REL_ARM_SECREL = 0x000F;

        [NativeTypeName("#define IMAGE_REL_ARM_MOV32A 0x0010")]
        public const int IMAGE_REL_ARM_MOV32A = 0x0010;

        [NativeTypeName("#define IMAGE_REL_ARM_MOV32 0x0010")]
        public const int IMAGE_REL_ARM_MOV32 = 0x0010;

        [NativeTypeName("#define IMAGE_REL_ARM_MOV32T 0x0011")]
        public const int IMAGE_REL_ARM_MOV32T = 0x0011;

        [NativeTypeName("#define IMAGE_REL_THUMB_MOV32 0x0011")]
        public const int IMAGE_REL_THUMB_MOV32 = 0x0011;

        [NativeTypeName("#define IMAGE_REL_ARM_BRANCH20T 0x0012")]
        public const int IMAGE_REL_ARM_BRANCH20T = 0x0012;

        [NativeTypeName("#define IMAGE_REL_THUMB_BRANCH20 0x0012")]
        public const int IMAGE_REL_THUMB_BRANCH20 = 0x0012;

        [NativeTypeName("#define IMAGE_REL_ARM_BRANCH24T 0x0014")]
        public const int IMAGE_REL_ARM_BRANCH24T = 0x0014;

        [NativeTypeName("#define IMAGE_REL_THUMB_BRANCH24 0x0014")]
        public const int IMAGE_REL_THUMB_BRANCH24 = 0x0014;

        [NativeTypeName("#define IMAGE_REL_ARM_BLX23T 0x0015")]
        public const int IMAGE_REL_ARM_BLX23T = 0x0015;

        [NativeTypeName("#define IMAGE_REL_THUMB_BLX23 0x0015")]
        public const int IMAGE_REL_THUMB_BLX23 = 0x0015;

        [NativeTypeName("#define IMAGE_REL_AM_ABSOLUTE 0x0000")]
        public const int IMAGE_REL_AM_ABSOLUTE = 0x0000;

        [NativeTypeName("#define IMAGE_REL_AM_ADDR32 0x0001")]
        public const int IMAGE_REL_AM_ADDR32 = 0x0001;

        [NativeTypeName("#define IMAGE_REL_AM_ADDR32NB 0x0002")]
        public const int IMAGE_REL_AM_ADDR32NB = 0x0002;

        [NativeTypeName("#define IMAGE_REL_AM_CALL32 0x0003")]
        public const int IMAGE_REL_AM_CALL32 = 0x0003;

        [NativeTypeName("#define IMAGE_REL_AM_FUNCINFO 0x0004")]
        public const int IMAGE_REL_AM_FUNCINFO = 0x0004;

        [NativeTypeName("#define IMAGE_REL_AM_REL32_1 0x0005")]
        public const int IMAGE_REL_AM_REL32_1 = 0x0005;

        [NativeTypeName("#define IMAGE_REL_AM_REL32_2 0x0006")]
        public const int IMAGE_REL_AM_REL32_2 = 0x0006;

        [NativeTypeName("#define IMAGE_REL_AM_SECREL 0x0007")]
        public const int IMAGE_REL_AM_SECREL = 0x0007;

        [NativeTypeName("#define IMAGE_REL_AM_SECTION 0x0008")]
        public const int IMAGE_REL_AM_SECTION = 0x0008;

        [NativeTypeName("#define IMAGE_REL_AM_TOKEN 0x0009")]
        public const int IMAGE_REL_AM_TOKEN = 0x0009;

        [NativeTypeName("#define IMAGE_REL_ARM64_ABSOLUTE 0x0000")]
        public const int IMAGE_REL_ARM64_ABSOLUTE = 0x0000;

        [NativeTypeName("#define IMAGE_REL_ARM64_ADDR32 0x0001")]
        public const int IMAGE_REL_ARM64_ADDR32 = 0x0001;

        [NativeTypeName("#define IMAGE_REL_ARM64_ADDR32NB 0x0002")]
        public const int IMAGE_REL_ARM64_ADDR32NB = 0x0002;

        [NativeTypeName("#define IMAGE_REL_ARM64_BRANCH26 0x0003")]
        public const int IMAGE_REL_ARM64_BRANCH26 = 0x0003;

        [NativeTypeName("#define IMAGE_REL_ARM64_PAGEBASE_REL21 0x0004")]
        public const int IMAGE_REL_ARM64_PAGEBASE_REL21 = 0x0004;

        [NativeTypeName("#define IMAGE_REL_ARM64_REL21 0x0005")]
        public const int IMAGE_REL_ARM64_REL21 = 0x0005;

        [NativeTypeName("#define IMAGE_REL_ARM64_PAGEOFFSET_12A 0x0006")]
        public const int IMAGE_REL_ARM64_PAGEOFFSET_12A = 0x0006;

        [NativeTypeName("#define IMAGE_REL_ARM64_PAGEOFFSET_12L 0x0007")]
        public const int IMAGE_REL_ARM64_PAGEOFFSET_12L = 0x0007;

        [NativeTypeName("#define IMAGE_REL_ARM64_SECREL 0x0008")]
        public const int IMAGE_REL_ARM64_SECREL = 0x0008;

        [NativeTypeName("#define IMAGE_REL_ARM64_SECREL_LOW12A 0x0009")]
        public const int IMAGE_REL_ARM64_SECREL_LOW12A = 0x0009;

        [NativeTypeName("#define IMAGE_REL_ARM64_SECREL_HIGH12A 0x000A")]
        public const int IMAGE_REL_ARM64_SECREL_HIGH12A = 0x000A;

        [NativeTypeName("#define IMAGE_REL_ARM64_SECREL_LOW12L 0x000B")]
        public const int IMAGE_REL_ARM64_SECREL_LOW12L = 0x000B;

        [NativeTypeName("#define IMAGE_REL_ARM64_TOKEN 0x000C")]
        public const int IMAGE_REL_ARM64_TOKEN = 0x000C;

        [NativeTypeName("#define IMAGE_REL_ARM64_SECTION 0x000D")]
        public const int IMAGE_REL_ARM64_SECTION = 0x000D;

        [NativeTypeName("#define IMAGE_REL_ARM64_ADDR64 0x000E")]
        public const int IMAGE_REL_ARM64_ADDR64 = 0x000E;

        [NativeTypeName("#define IMAGE_REL_ARM64_BRANCH19 0x000F")]
        public const int IMAGE_REL_ARM64_BRANCH19 = 0x000F;

        [NativeTypeName("#define IMAGE_REL_AMD64_ABSOLUTE 0x0000")]
        public const int IMAGE_REL_AMD64_ABSOLUTE = 0x0000;

        [NativeTypeName("#define IMAGE_REL_AMD64_ADDR64 0x0001")]
        public const int IMAGE_REL_AMD64_ADDR64 = 0x0001;

        [NativeTypeName("#define IMAGE_REL_AMD64_ADDR32 0x0002")]
        public const int IMAGE_REL_AMD64_ADDR32 = 0x0002;

        [NativeTypeName("#define IMAGE_REL_AMD64_ADDR32NB 0x0003")]
        public const int IMAGE_REL_AMD64_ADDR32NB = 0x0003;

        [NativeTypeName("#define IMAGE_REL_AMD64_REL32 0x0004")]
        public const int IMAGE_REL_AMD64_REL32 = 0x0004;

        [NativeTypeName("#define IMAGE_REL_AMD64_REL32_1 0x0005")]
        public const int IMAGE_REL_AMD64_REL32_1 = 0x0005;

        [NativeTypeName("#define IMAGE_REL_AMD64_REL32_2 0x0006")]
        public const int IMAGE_REL_AMD64_REL32_2 = 0x0006;

        [NativeTypeName("#define IMAGE_REL_AMD64_REL32_3 0x0007")]
        public const int IMAGE_REL_AMD64_REL32_3 = 0x0007;

        [NativeTypeName("#define IMAGE_REL_AMD64_REL32_4 0x0008")]
        public const int IMAGE_REL_AMD64_REL32_4 = 0x0008;

        [NativeTypeName("#define IMAGE_REL_AMD64_REL32_5 0x0009")]
        public const int IMAGE_REL_AMD64_REL32_5 = 0x0009;

        [NativeTypeName("#define IMAGE_REL_AMD64_SECTION 0x000A")]
        public const int IMAGE_REL_AMD64_SECTION = 0x000A;

        [NativeTypeName("#define IMAGE_REL_AMD64_SECREL 0x000B")]
        public const int IMAGE_REL_AMD64_SECREL = 0x000B;

        [NativeTypeName("#define IMAGE_REL_AMD64_SECREL7 0x000C")]
        public const int IMAGE_REL_AMD64_SECREL7 = 0x000C;

        [NativeTypeName("#define IMAGE_REL_AMD64_TOKEN 0x000D")]
        public const int IMAGE_REL_AMD64_TOKEN = 0x000D;

        [NativeTypeName("#define IMAGE_REL_AMD64_SREL32 0x000E")]
        public const int IMAGE_REL_AMD64_SREL32 = 0x000E;

        [NativeTypeName("#define IMAGE_REL_AMD64_PAIR 0x000F")]
        public const int IMAGE_REL_AMD64_PAIR = 0x000F;

        [NativeTypeName("#define IMAGE_REL_AMD64_SSPAN32 0x0010")]
        public const int IMAGE_REL_AMD64_SSPAN32 = 0x0010;

        [NativeTypeName("#define IMAGE_REL_AMD64_EHANDLER 0x0011")]
        public const int IMAGE_REL_AMD64_EHANDLER = 0x0011;

        [NativeTypeName("#define IMAGE_REL_AMD64_IMPORT_BR 0x0012")]
        public const int IMAGE_REL_AMD64_IMPORT_BR = 0x0012;

        [NativeTypeName("#define IMAGE_REL_AMD64_IMPORT_CALL 0x0013")]
        public const int IMAGE_REL_AMD64_IMPORT_CALL = 0x0013;

        [NativeTypeName("#define IMAGE_REL_AMD64_CFG_BR 0x0014")]
        public const int IMAGE_REL_AMD64_CFG_BR = 0x0014;

        [NativeTypeName("#define IMAGE_REL_AMD64_CFG_BR_REX 0x0015")]
        public const int IMAGE_REL_AMD64_CFG_BR_REX = 0x0015;

        [NativeTypeName("#define IMAGE_REL_AMD64_CFG_CALL 0x0016")]
        public const int IMAGE_REL_AMD64_CFG_CALL = 0x0016;

        [NativeTypeName("#define IMAGE_REL_AMD64_INDIR_BR 0x0017")]
        public const int IMAGE_REL_AMD64_INDIR_BR = 0x0017;

        [NativeTypeName("#define IMAGE_REL_AMD64_INDIR_BR_REX 0x0018")]
        public const int IMAGE_REL_AMD64_INDIR_BR_REX = 0x0018;

        [NativeTypeName("#define IMAGE_REL_AMD64_INDIR_CALL 0x0019")]
        public const int IMAGE_REL_AMD64_INDIR_CALL = 0x0019;

        [NativeTypeName("#define IMAGE_REL_AMD64_INDIR_BR_SWITCHTABLE_FIRST 0x0020")]
        public const int IMAGE_REL_AMD64_INDIR_BR_SWITCHTABLE_FIRST = 0x0020;

        [NativeTypeName("#define IMAGE_REL_AMD64_INDIR_BR_SWITCHTABLE_LAST 0x002F")]
        public const int IMAGE_REL_AMD64_INDIR_BR_SWITCHTABLE_LAST = 0x002F;

        [NativeTypeName("#define IMAGE_REL_IA64_ABSOLUTE 0x0000")]
        public const int IMAGE_REL_IA64_ABSOLUTE = 0x0000;

        [NativeTypeName("#define IMAGE_REL_IA64_IMM14 0x0001")]
        public const int IMAGE_REL_IA64_IMM14 = 0x0001;

        [NativeTypeName("#define IMAGE_REL_IA64_IMM22 0x0002")]
        public const int IMAGE_REL_IA64_IMM22 = 0x0002;

        [NativeTypeName("#define IMAGE_REL_IA64_IMM64 0x0003")]
        public const int IMAGE_REL_IA64_IMM64 = 0x0003;

        [NativeTypeName("#define IMAGE_REL_IA64_DIR32 0x0004")]
        public const int IMAGE_REL_IA64_DIR32 = 0x0004;

        [NativeTypeName("#define IMAGE_REL_IA64_DIR64 0x0005")]
        public const int IMAGE_REL_IA64_DIR64 = 0x0005;

        [NativeTypeName("#define IMAGE_REL_IA64_PCREL21B 0x0006")]
        public const int IMAGE_REL_IA64_PCREL21B = 0x0006;

        [NativeTypeName("#define IMAGE_REL_IA64_PCREL21M 0x0007")]
        public const int IMAGE_REL_IA64_PCREL21M = 0x0007;

        [NativeTypeName("#define IMAGE_REL_IA64_PCREL21F 0x0008")]
        public const int IMAGE_REL_IA64_PCREL21F = 0x0008;

        [NativeTypeName("#define IMAGE_REL_IA64_GPREL22 0x0009")]
        public const int IMAGE_REL_IA64_GPREL22 = 0x0009;

        [NativeTypeName("#define IMAGE_REL_IA64_LTOFF22 0x000A")]
        public const int IMAGE_REL_IA64_LTOFF22 = 0x000A;

        [NativeTypeName("#define IMAGE_REL_IA64_SECTION 0x000B")]
        public const int IMAGE_REL_IA64_SECTION = 0x000B;

        [NativeTypeName("#define IMAGE_REL_IA64_SECREL22 0x000C")]
        public const int IMAGE_REL_IA64_SECREL22 = 0x000C;

        [NativeTypeName("#define IMAGE_REL_IA64_SECREL64I 0x000D")]
        public const int IMAGE_REL_IA64_SECREL64I = 0x000D;

        [NativeTypeName("#define IMAGE_REL_IA64_SECREL32 0x000E")]
        public const int IMAGE_REL_IA64_SECREL32 = 0x000E;

        [NativeTypeName("#define IMAGE_REL_IA64_DIR32NB 0x0010")]
        public const int IMAGE_REL_IA64_DIR32NB = 0x0010;

        [NativeTypeName("#define IMAGE_REL_IA64_SREL14 0x0011")]
        public const int IMAGE_REL_IA64_SREL14 = 0x0011;

        [NativeTypeName("#define IMAGE_REL_IA64_SREL22 0x0012")]
        public const int IMAGE_REL_IA64_SREL22 = 0x0012;

        [NativeTypeName("#define IMAGE_REL_IA64_SREL32 0x0013")]
        public const int IMAGE_REL_IA64_SREL32 = 0x0013;

        [NativeTypeName("#define IMAGE_REL_IA64_UREL32 0x0014")]
        public const int IMAGE_REL_IA64_UREL32 = 0x0014;

        [NativeTypeName("#define IMAGE_REL_IA64_PCREL60X 0x0015")]
        public const int IMAGE_REL_IA64_PCREL60X = 0x0015;

        [NativeTypeName("#define IMAGE_REL_IA64_PCREL60B 0x0016")]
        public const int IMAGE_REL_IA64_PCREL60B = 0x0016;

        [NativeTypeName("#define IMAGE_REL_IA64_PCREL60F 0x0017")]
        public const int IMAGE_REL_IA64_PCREL60F = 0x0017;

        [NativeTypeName("#define IMAGE_REL_IA64_PCREL60I 0x0018")]
        public const int IMAGE_REL_IA64_PCREL60I = 0x0018;

        [NativeTypeName("#define IMAGE_REL_IA64_PCREL60M 0x0019")]
        public const int IMAGE_REL_IA64_PCREL60M = 0x0019;

        [NativeTypeName("#define IMAGE_REL_IA64_IMMGPREL64 0x001A")]
        public const int IMAGE_REL_IA64_IMMGPREL64 = 0x001A;

        [NativeTypeName("#define IMAGE_REL_IA64_TOKEN 0x001B")]
        public const int IMAGE_REL_IA64_TOKEN = 0x001B;

        [NativeTypeName("#define IMAGE_REL_IA64_GPREL32 0x001C")]
        public const int IMAGE_REL_IA64_GPREL32 = 0x001C;

        [NativeTypeName("#define IMAGE_REL_IA64_ADDEND 0x001F")]
        public const int IMAGE_REL_IA64_ADDEND = 0x001F;

        [NativeTypeName("#define IMAGE_REL_CEF_ABSOLUTE 0x0000")]
        public const int IMAGE_REL_CEF_ABSOLUTE = 0x0000;

        [NativeTypeName("#define IMAGE_REL_CEF_ADDR32 0x0001")]
        public const int IMAGE_REL_CEF_ADDR32 = 0x0001;

        [NativeTypeName("#define IMAGE_REL_CEF_ADDR64 0x0002")]
        public const int IMAGE_REL_CEF_ADDR64 = 0x0002;

        [NativeTypeName("#define IMAGE_REL_CEF_ADDR32NB 0x0003")]
        public const int IMAGE_REL_CEF_ADDR32NB = 0x0003;

        [NativeTypeName("#define IMAGE_REL_CEF_SECTION 0x0004")]
        public const int IMAGE_REL_CEF_SECTION = 0x0004;

        [NativeTypeName("#define IMAGE_REL_CEF_SECREL 0x0005")]
        public const int IMAGE_REL_CEF_SECREL = 0x0005;

        [NativeTypeName("#define IMAGE_REL_CEF_TOKEN 0x0006")]
        public const int IMAGE_REL_CEF_TOKEN = 0x0006;

        [NativeTypeName("#define IMAGE_REL_CEE_ABSOLUTE 0x0000")]
        public const int IMAGE_REL_CEE_ABSOLUTE = 0x0000;

        [NativeTypeName("#define IMAGE_REL_CEE_ADDR32 0x0001")]
        public const int IMAGE_REL_CEE_ADDR32 = 0x0001;

        [NativeTypeName("#define IMAGE_REL_CEE_ADDR64 0x0002")]
        public const int IMAGE_REL_CEE_ADDR64 = 0x0002;

        [NativeTypeName("#define IMAGE_REL_CEE_ADDR32NB 0x0003")]
        public const int IMAGE_REL_CEE_ADDR32NB = 0x0003;

        [NativeTypeName("#define IMAGE_REL_CEE_SECTION 0x0004")]
        public const int IMAGE_REL_CEE_SECTION = 0x0004;

        [NativeTypeName("#define IMAGE_REL_CEE_SECREL 0x0005")]
        public const int IMAGE_REL_CEE_SECREL = 0x0005;

        [NativeTypeName("#define IMAGE_REL_CEE_TOKEN 0x0006")]
        public const int IMAGE_REL_CEE_TOKEN = 0x0006;

        [NativeTypeName("#define IMAGE_REL_M32R_ABSOLUTE 0x0000")]
        public const int IMAGE_REL_M32R_ABSOLUTE = 0x0000;

        [NativeTypeName("#define IMAGE_REL_M32R_ADDR32 0x0001")]
        public const int IMAGE_REL_M32R_ADDR32 = 0x0001;

        [NativeTypeName("#define IMAGE_REL_M32R_ADDR32NB 0x0002")]
        public const int IMAGE_REL_M32R_ADDR32NB = 0x0002;

        [NativeTypeName("#define IMAGE_REL_M32R_ADDR24 0x0003")]
        public const int IMAGE_REL_M32R_ADDR24 = 0x0003;

        [NativeTypeName("#define IMAGE_REL_M32R_GPREL16 0x0004")]
        public const int IMAGE_REL_M32R_GPREL16 = 0x0004;

        [NativeTypeName("#define IMAGE_REL_M32R_PCREL24 0x0005")]
        public const int IMAGE_REL_M32R_PCREL24 = 0x0005;

        [NativeTypeName("#define IMAGE_REL_M32R_PCREL16 0x0006")]
        public const int IMAGE_REL_M32R_PCREL16 = 0x0006;

        [NativeTypeName("#define IMAGE_REL_M32R_PCREL8 0x0007")]
        public const int IMAGE_REL_M32R_PCREL8 = 0x0007;

        [NativeTypeName("#define IMAGE_REL_M32R_REFHALF 0x0008")]
        public const int IMAGE_REL_M32R_REFHALF = 0x0008;

        [NativeTypeName("#define IMAGE_REL_M32R_REFHI 0x0009")]
        public const int IMAGE_REL_M32R_REFHI = 0x0009;

        [NativeTypeName("#define IMAGE_REL_M32R_REFLO 0x000A")]
        public const int IMAGE_REL_M32R_REFLO = 0x000A;

        [NativeTypeName("#define IMAGE_REL_M32R_PAIR 0x000B")]
        public const int IMAGE_REL_M32R_PAIR = 0x000B;

        [NativeTypeName("#define IMAGE_REL_M32R_SECTION 0x000C")]
        public const int IMAGE_REL_M32R_SECTION = 0x000C;

        [NativeTypeName("#define IMAGE_REL_M32R_SECREL32 0x000D")]
        public const int IMAGE_REL_M32R_SECREL32 = 0x000D;

        [NativeTypeName("#define IMAGE_REL_M32R_TOKEN 0x000E")]
        public const int IMAGE_REL_M32R_TOKEN = 0x000E;

        [NativeTypeName("#define IMAGE_REL_EBC_ABSOLUTE 0x0000")]
        public const int IMAGE_REL_EBC_ABSOLUTE = 0x0000;

        [NativeTypeName("#define IMAGE_REL_EBC_ADDR32NB 0x0001")]
        public const int IMAGE_REL_EBC_ADDR32NB = 0x0001;

        [NativeTypeName("#define IMAGE_REL_EBC_REL32 0x0002")]
        public const int IMAGE_REL_EBC_REL32 = 0x0002;

        [NativeTypeName("#define IMAGE_REL_EBC_SECTION 0x0003")]
        public const int IMAGE_REL_EBC_SECTION = 0x0003;

        [NativeTypeName("#define IMAGE_REL_EBC_SECREL 0x0004")]
        public const int IMAGE_REL_EBC_SECREL = 0x0004;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM7B_INST_WORD_X 3")]
        public const int EMARCH_ENC_I17_IMM7B_INST_WORD_X = 3;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM7B_SIZE_X 7")]
        public const int EMARCH_ENC_I17_IMM7B_SIZE_X = 7;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM7B_INST_WORD_POS_X 4")]
        public const int EMARCH_ENC_I17_IMM7B_INST_WORD_POS_X = 4;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM7B_VAL_POS_X 0")]
        public const int EMARCH_ENC_I17_IMM7B_VAL_POS_X = 0;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM9D_INST_WORD_X 3")]
        public const int EMARCH_ENC_I17_IMM9D_INST_WORD_X = 3;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM9D_SIZE_X 9")]
        public const int EMARCH_ENC_I17_IMM9D_SIZE_X = 9;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM9D_INST_WORD_POS_X 18")]
        public const int EMARCH_ENC_I17_IMM9D_INST_WORD_POS_X = 18;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM9D_VAL_POS_X 7")]
        public const int EMARCH_ENC_I17_IMM9D_VAL_POS_X = 7;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM5C_INST_WORD_X 3")]
        public const int EMARCH_ENC_I17_IMM5C_INST_WORD_X = 3;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM5C_SIZE_X 5")]
        public const int EMARCH_ENC_I17_IMM5C_SIZE_X = 5;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM5C_INST_WORD_POS_X 13")]
        public const int EMARCH_ENC_I17_IMM5C_INST_WORD_POS_X = 13;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM5C_VAL_POS_X 16")]
        public const int EMARCH_ENC_I17_IMM5C_VAL_POS_X = 16;

        [NativeTypeName("#define EMARCH_ENC_I17_IC_INST_WORD_X 3")]
        public const int EMARCH_ENC_I17_IC_INST_WORD_X = 3;

        [NativeTypeName("#define EMARCH_ENC_I17_IC_SIZE_X 1")]
        public const int EMARCH_ENC_I17_IC_SIZE_X = 1;

        [NativeTypeName("#define EMARCH_ENC_I17_IC_INST_WORD_POS_X 12")]
        public const int EMARCH_ENC_I17_IC_INST_WORD_POS_X = 12;

        [NativeTypeName("#define EMARCH_ENC_I17_IC_VAL_POS_X 21")]
        public const int EMARCH_ENC_I17_IC_VAL_POS_X = 21;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41a_INST_WORD_X 1")]
        public const int EMARCH_ENC_I17_IMM41a_INST_WORD_X = 1;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41a_SIZE_X 10")]
        public const int EMARCH_ENC_I17_IMM41a_SIZE_X = 10;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41a_INST_WORD_POS_X 14")]
        public const int EMARCH_ENC_I17_IMM41a_INST_WORD_POS_X = 14;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41a_VAL_POS_X 22")]
        public const int EMARCH_ENC_I17_IMM41a_VAL_POS_X = 22;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41b_INST_WORD_X 1")]
        public const int EMARCH_ENC_I17_IMM41b_INST_WORD_X = 1;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41b_SIZE_X 8")]
        public const int EMARCH_ENC_I17_IMM41b_SIZE_X = 8;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41b_INST_WORD_POS_X 24")]
        public const int EMARCH_ENC_I17_IMM41b_INST_WORD_POS_X = 24;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41b_VAL_POS_X 32")]
        public const int EMARCH_ENC_I17_IMM41b_VAL_POS_X = 32;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41c_INST_WORD_X 2")]
        public const int EMARCH_ENC_I17_IMM41c_INST_WORD_X = 2;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41c_SIZE_X 23")]
        public const int EMARCH_ENC_I17_IMM41c_SIZE_X = 23;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41c_INST_WORD_POS_X 0")]
        public const int EMARCH_ENC_I17_IMM41c_INST_WORD_POS_X = 0;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41c_VAL_POS_X 40")]
        public const int EMARCH_ENC_I17_IMM41c_VAL_POS_X = 40;

        [NativeTypeName("#define EMARCH_ENC_I17_SIGN_INST_WORD_X 3")]
        public const int EMARCH_ENC_I17_SIGN_INST_WORD_X = 3;

        [NativeTypeName("#define EMARCH_ENC_I17_SIGN_SIZE_X 1")]
        public const int EMARCH_ENC_I17_SIGN_SIZE_X = 1;

        [NativeTypeName("#define EMARCH_ENC_I17_SIGN_INST_WORD_POS_X 27")]
        public const int EMARCH_ENC_I17_SIGN_INST_WORD_POS_X = 27;

        [NativeTypeName("#define EMARCH_ENC_I17_SIGN_VAL_POS_X 63")]
        public const int EMARCH_ENC_I17_SIGN_VAL_POS_X = 63;

        [NativeTypeName("#define X3_OPCODE_INST_WORD_X 3")]
        public const int X3_OPCODE_INST_WORD_X = 3;

        [NativeTypeName("#define X3_OPCODE_SIZE_X 4")]
        public const int X3_OPCODE_SIZE_X = 4;

        [NativeTypeName("#define X3_OPCODE_INST_WORD_POS_X 28")]
        public const int X3_OPCODE_INST_WORD_POS_X = 28;

        [NativeTypeName("#define X3_OPCODE_SIGN_VAL_POS_X 0")]
        public const int X3_OPCODE_SIGN_VAL_POS_X = 0;

        [NativeTypeName("#define X3_I_INST_WORD_X 3")]
        public const int X3_I_INST_WORD_X = 3;

        [NativeTypeName("#define X3_I_SIZE_X 1")]
        public const int X3_I_SIZE_X = 1;

        [NativeTypeName("#define X3_I_INST_WORD_POS_X 27")]
        public const int X3_I_INST_WORD_POS_X = 27;

        [NativeTypeName("#define X3_I_SIGN_VAL_POS_X 59")]
        public const int X3_I_SIGN_VAL_POS_X = 59;

        [NativeTypeName("#define X3_D_WH_INST_WORD_X 3")]
        public const int X3_D_WH_INST_WORD_X = 3;

        [NativeTypeName("#define X3_D_WH_SIZE_X 3")]
        public const int X3_D_WH_SIZE_X = 3;

        [NativeTypeName("#define X3_D_WH_INST_WORD_POS_X 24")]
        public const int X3_D_WH_INST_WORD_POS_X = 24;

        [NativeTypeName("#define X3_D_WH_SIGN_VAL_POS_X 0")]
        public const int X3_D_WH_SIGN_VAL_POS_X = 0;

        [NativeTypeName("#define X3_IMM20_INST_WORD_X 3")]
        public const int X3_IMM20_INST_WORD_X = 3;

        [NativeTypeName("#define X3_IMM20_SIZE_X 20")]
        public const int X3_IMM20_SIZE_X = 20;

        [NativeTypeName("#define X3_IMM20_INST_WORD_POS_X 4")]
        public const int X3_IMM20_INST_WORD_POS_X = 4;

        [NativeTypeName("#define X3_IMM20_SIGN_VAL_POS_X 0")]
        public const int X3_IMM20_SIGN_VAL_POS_X = 0;

        [NativeTypeName("#define X3_IMM39_1_INST_WORD_X 2")]
        public const int X3_IMM39_1_INST_WORD_X = 2;

        [NativeTypeName("#define X3_IMM39_1_SIZE_X 23")]
        public const int X3_IMM39_1_SIZE_X = 23;

        [NativeTypeName("#define X3_IMM39_1_INST_WORD_POS_X 0")]
        public const int X3_IMM39_1_INST_WORD_POS_X = 0;

        [NativeTypeName("#define X3_IMM39_1_SIGN_VAL_POS_X 36")]
        public const int X3_IMM39_1_SIGN_VAL_POS_X = 36;

        [NativeTypeName("#define X3_IMM39_2_INST_WORD_X 1")]
        public const int X3_IMM39_2_INST_WORD_X = 1;

        [NativeTypeName("#define X3_IMM39_2_SIZE_X 16")]
        public const int X3_IMM39_2_SIZE_X = 16;

        [NativeTypeName("#define X3_IMM39_2_INST_WORD_POS_X 16")]
        public const int X3_IMM39_2_INST_WORD_POS_X = 16;

        [NativeTypeName("#define X3_IMM39_2_SIGN_VAL_POS_X 20")]
        public const int X3_IMM39_2_SIGN_VAL_POS_X = 20;

        [NativeTypeName("#define X3_P_INST_WORD_X 3")]
        public const int X3_P_INST_WORD_X = 3;

        [NativeTypeName("#define X3_P_SIZE_X 4")]
        public const int X3_P_SIZE_X = 4;

        [NativeTypeName("#define X3_P_INST_WORD_POS_X 0")]
        public const int X3_P_INST_WORD_POS_X = 0;

        [NativeTypeName("#define X3_P_SIGN_VAL_POS_X 0")]
        public const int X3_P_SIGN_VAL_POS_X = 0;

        [NativeTypeName("#define X3_TMPLT_INST_WORD_X 0")]
        public const int X3_TMPLT_INST_WORD_X = 0;

        [NativeTypeName("#define X3_TMPLT_SIZE_X 4")]
        public const int X3_TMPLT_SIZE_X = 4;

        [NativeTypeName("#define X3_TMPLT_INST_WORD_POS_X 0")]
        public const int X3_TMPLT_INST_WORD_POS_X = 0;

        [NativeTypeName("#define X3_TMPLT_SIGN_VAL_POS_X 0")]
        public const int X3_TMPLT_SIGN_VAL_POS_X = 0;

        [NativeTypeName("#define X3_BTYPE_QP_INST_WORD_X 2")]
        public const int X3_BTYPE_QP_INST_WORD_X = 2;

        [NativeTypeName("#define X3_BTYPE_QP_SIZE_X 9")]
        public const int X3_BTYPE_QP_SIZE_X = 9;

        [NativeTypeName("#define X3_BTYPE_QP_INST_WORD_POS_X 23")]
        public const int X3_BTYPE_QP_INST_WORD_POS_X = 23;

        [NativeTypeName("#define X3_BTYPE_QP_INST_VAL_POS_X 0")]
        public const int X3_BTYPE_QP_INST_VAL_POS_X = 0;

        [NativeTypeName("#define X3_EMPTY_INST_WORD_X 1")]
        public const int X3_EMPTY_INST_WORD_X = 1;

        [NativeTypeName("#define X3_EMPTY_SIZE_X 2")]
        public const int X3_EMPTY_SIZE_X = 2;

        [NativeTypeName("#define X3_EMPTY_INST_WORD_POS_X 14")]
        public const int X3_EMPTY_INST_WORD_POS_X = 14;

        [NativeTypeName("#define X3_EMPTY_INST_VAL_POS_X 0")]
        public const int X3_EMPTY_INST_VAL_POS_X = 0;

        [NativeTypeName("#define IMAGE_REL_BASED_ABSOLUTE 0")]
        public const int IMAGE_REL_BASED_ABSOLUTE = 0;

        [NativeTypeName("#define IMAGE_REL_BASED_HIGH 1")]
        public const int IMAGE_REL_BASED_HIGH = 1;

        [NativeTypeName("#define IMAGE_REL_BASED_LOW 2")]
        public const int IMAGE_REL_BASED_LOW = 2;

        [NativeTypeName("#define IMAGE_REL_BASED_HIGHLOW 3")]
        public const int IMAGE_REL_BASED_HIGHLOW = 3;

        [NativeTypeName("#define IMAGE_REL_BASED_HIGHADJ 4")]
        public const int IMAGE_REL_BASED_HIGHADJ = 4;

        [NativeTypeName("#define IMAGE_REL_BASED_MACHINE_SPECIFIC_5 5")]
        public const int IMAGE_REL_BASED_MACHINE_SPECIFIC_5 = 5;

        [NativeTypeName("#define IMAGE_REL_BASED_RESERVED 6")]
        public const int IMAGE_REL_BASED_RESERVED = 6;

        [NativeTypeName("#define IMAGE_REL_BASED_MACHINE_SPECIFIC_7 7")]
        public const int IMAGE_REL_BASED_MACHINE_SPECIFIC_7 = 7;

        [NativeTypeName("#define IMAGE_REL_BASED_MACHINE_SPECIFIC_8 8")]
        public const int IMAGE_REL_BASED_MACHINE_SPECIFIC_8 = 8;

        [NativeTypeName("#define IMAGE_REL_BASED_MACHINE_SPECIFIC_9 9")]
        public const int IMAGE_REL_BASED_MACHINE_SPECIFIC_9 = 9;

        [NativeTypeName("#define IMAGE_REL_BASED_DIR64 10")]
        public const int IMAGE_REL_BASED_DIR64 = 10;

        [NativeTypeName("#define IMAGE_REL_BASED_IA64_IMM64 9")]
        public const int IMAGE_REL_BASED_IA64_IMM64 = 9;

        [NativeTypeName("#define IMAGE_REL_BASED_MIPS_JMPADDR 5")]
        public const int IMAGE_REL_BASED_MIPS_JMPADDR = 5;

        [NativeTypeName("#define IMAGE_REL_BASED_MIPS_JMPADDR16 9")]
        public const int IMAGE_REL_BASED_MIPS_JMPADDR16 = 9;

        [NativeTypeName("#define IMAGE_REL_BASED_ARM_MOV32 5")]
        public const int IMAGE_REL_BASED_ARM_MOV32 = 5;

        [NativeTypeName("#define IMAGE_REL_BASED_THUMB_MOV32 7")]
        public const int IMAGE_REL_BASED_THUMB_MOV32 = 7;

        [NativeTypeName("#define IMAGE_ARCHIVE_START_SIZE 8")]
        public const int IMAGE_ARCHIVE_START_SIZE = 8;

        [NativeTypeName("#define IMAGE_ARCHIVE_START \"!<arch>\\n\"")]
        public static ReadOnlySpan<byte> IMAGE_ARCHIVE_START => new byte[] { 0x21, 0x3C, 0x61, 0x72, 0x63, 0x68, 0x3E, 0x0A, 0x00 };

        [NativeTypeName("#define IMAGE_ARCHIVE_END \"`\\n\"")]
        public static ReadOnlySpan<byte> IMAGE_ARCHIVE_END => new byte[] { 0x60, 0x0A, 0x00 };

        [NativeTypeName("#define IMAGE_ARCHIVE_PAD \"\\n\"")]
        public static ReadOnlySpan<byte> IMAGE_ARCHIVE_PAD => new byte[] { 0x0A, 0x00 };

        [NativeTypeName("#define IMAGE_ARCHIVE_LINKER_MEMBER \"/               \"")]
        public static ReadOnlySpan<byte> IMAGE_ARCHIVE_LINKER_MEMBER => new byte[] { 0x2F, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x00 };

        [NativeTypeName("#define IMAGE_ARCHIVE_LONGNAMES_MEMBER \"//              \"")]
        public static ReadOnlySpan<byte> IMAGE_ARCHIVE_LONGNAMES_MEMBER => new byte[] { 0x2F, 0x2F, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x00 };

        [NativeTypeName("#define IMAGE_ARCHIVE_HYBRIDMAP_MEMBER \"/<HYBRIDMAP>/   \"")]
        public static ReadOnlySpan<byte> IMAGE_ARCHIVE_HYBRIDMAP_MEMBER => new byte[] { 0x2F, 0x3C, 0x48, 0x59, 0x42, 0x52, 0x49, 0x44, 0x4D, 0x41, 0x50, 0x3E, 0x2F, 0x20, 0x20, 0x20, 0x00 };

        [NativeTypeName("#define IMAGE_SIZEOF_ARCHIVE_MEMBER_HDR 60")]
        public const int IMAGE_SIZEOF_ARCHIVE_MEMBER_HDR = 60;

        [NativeTypeName("#define IMAGE_ORDINAL_FLAG64 0x8000000000000000")]
        public const ulong IMAGE_ORDINAL_FLAG64 = 0x8000000000000000;

        [NativeTypeName("#define IMAGE_ORDINAL_FLAG32 0x80000000")]
        public const uint IMAGE_ORDINAL_FLAG32 = 0x80000000;

        [NativeTypeName("#define IMAGE_ORDINAL_FLAG IMAGE_ORDINAL_FLAG32")]
        public const uint IMAGE_ORDINAL_FLAG = 0x80000000;

        [NativeTypeName("#define IMAGE_RESOURCE_NAME_IS_STRING 0x80000000")]
        public const uint IMAGE_RESOURCE_NAME_IS_STRING = 0x80000000;

        [NativeTypeName("#define IMAGE_RESOURCE_DATA_IS_DIRECTORY 0x80000000")]
        public const uint IMAGE_RESOURCE_DATA_IS_DIRECTORY = 0x80000000;

        [NativeTypeName("#define IMAGE_DYNAMIC_RELOCATION_GUARD_RF_PROLOGUE 0x00000001")]
        public const int IMAGE_DYNAMIC_RELOCATION_GUARD_RF_PROLOGUE = 0x00000001;

        [NativeTypeName("#define IMAGE_DYNAMIC_RELOCATION_GUARD_RF_EPILOGUE 0x00000002")]
        public const int IMAGE_DYNAMIC_RELOCATION_GUARD_RF_EPILOGUE = 0x00000002;

        [NativeTypeName("#define IMAGE_DYNAMIC_RELOCATION_GUARD_IMPORT_CONTROL_TRANSFER 0x00000003")]
        public const int IMAGE_DYNAMIC_RELOCATION_GUARD_IMPORT_CONTROL_TRANSFER = 0x00000003;

        [NativeTypeName("#define IMAGE_DYNAMIC_RELOCATION_GUARD_INDIR_CONTROL_TRANSFER 0x00000004")]
        public const int IMAGE_DYNAMIC_RELOCATION_GUARD_INDIR_CONTROL_TRANSFER = 0x00000004;

        [NativeTypeName("#define IMAGE_DYNAMIC_RELOCATION_GUARD_SWITCHTABLE_BRANCH 0x00000005")]
        public const int IMAGE_DYNAMIC_RELOCATION_GUARD_SWITCHTABLE_BRANCH = 0x00000005;

        [NativeTypeName("#define IMAGE_HOT_PATCH_BASE_OBLIGATORY 0x00000001")]
        public const int IMAGE_HOT_PATCH_BASE_OBLIGATORY = 0x00000001;

        [NativeTypeName("#define IMAGE_HOT_PATCH_BASE_CAN_ROLL_BACK 0x00000002")]
        public const int IMAGE_HOT_PATCH_BASE_CAN_ROLL_BACK = 0x00000002;

        [NativeTypeName("#define IMAGE_HOT_PATCH_CHUNK_INVERSE 0x80000000")]
        public const uint IMAGE_HOT_PATCH_CHUNK_INVERSE = 0x80000000;

        [NativeTypeName("#define IMAGE_HOT_PATCH_CHUNK_OBLIGATORY 0x40000000")]
        public const int IMAGE_HOT_PATCH_CHUNK_OBLIGATORY = 0x40000000;

        [NativeTypeName("#define IMAGE_HOT_PATCH_CHUNK_RESERVED 0x3FF03000")]
        public const int IMAGE_HOT_PATCH_CHUNK_RESERVED = 0x3FF03000;

        [NativeTypeName("#define IMAGE_HOT_PATCH_CHUNK_TYPE 0x000FC000")]
        public const int IMAGE_HOT_PATCH_CHUNK_TYPE = 0x000FC000;

        [NativeTypeName("#define IMAGE_HOT_PATCH_CHUNK_SOURCE_RVA 0x00008000")]
        public const int IMAGE_HOT_PATCH_CHUNK_SOURCE_RVA = 0x00008000;

        [NativeTypeName("#define IMAGE_HOT_PATCH_CHUNK_TARGET_RVA 0x00004000")]
        public const int IMAGE_HOT_PATCH_CHUNK_TARGET_RVA = 0x00004000;

        [NativeTypeName("#define IMAGE_HOT_PATCH_CHUNK_SIZE 0x00000FFF")]
        public const int IMAGE_HOT_PATCH_CHUNK_SIZE = 0x00000FFF;

        [NativeTypeName("#define IMAGE_HOT_PATCH_NONE 0x00000000")]
        public const int IMAGE_HOT_PATCH_NONE = 0x00000000;

        [NativeTypeName("#define IMAGE_HOT_PATCH_FUNCTION 0x0001C000")]
        public const int IMAGE_HOT_PATCH_FUNCTION = 0x0001C000;

        [NativeTypeName("#define IMAGE_HOT_PATCH_ABSOLUTE 0x0002C000")]
        public const int IMAGE_HOT_PATCH_ABSOLUTE = 0x0002C000;

        [NativeTypeName("#define IMAGE_HOT_PATCH_REL32 0x0003C000")]
        public const int IMAGE_HOT_PATCH_REL32 = 0x0003C000;

        [NativeTypeName("#define IMAGE_HOT_PATCH_CALL_TARGET 0x00044000")]
        public const int IMAGE_HOT_PATCH_CALL_TARGET = 0x00044000;

        [NativeTypeName("#define IMAGE_HOT_PATCH_INDIRECT 0x0005C000")]
        public const int IMAGE_HOT_PATCH_INDIRECT = 0x0005C000;

        [NativeTypeName("#define IMAGE_HOT_PATCH_NO_CALL_TARGET 0x00064000")]
        public const int IMAGE_HOT_PATCH_NO_CALL_TARGET = 0x00064000;

        [NativeTypeName("#define IMAGE_HOT_PATCH_DYNAMIC_VALUE 0x00078000")]
        public const int IMAGE_HOT_PATCH_DYNAMIC_VALUE = 0x00078000;

        [NativeTypeName("#define IMAGE_GUARD_CF_INSTRUMENTED 0x00000100")]
        public const int IMAGE_GUARD_CF_INSTRUMENTED = 0x00000100;

        [NativeTypeName("#define IMAGE_GUARD_CFW_INSTRUMENTED 0x00000200")]
        public const int IMAGE_GUARD_CFW_INSTRUMENTED = 0x00000200;

        [NativeTypeName("#define IMAGE_GUARD_CF_FUNCTION_TABLE_PRESENT 0x00000400")]
        public const int IMAGE_GUARD_CF_FUNCTION_TABLE_PRESENT = 0x00000400;

        [NativeTypeName("#define IMAGE_GUARD_SECURITY_COOKIE_UNUSED 0x00000800")]
        public const int IMAGE_GUARD_SECURITY_COOKIE_UNUSED = 0x00000800;

        [NativeTypeName("#define IMAGE_GUARD_PROTECT_DELAYLOAD_IAT 0x00001000")]
        public const int IMAGE_GUARD_PROTECT_DELAYLOAD_IAT = 0x00001000;

        [NativeTypeName("#define IMAGE_GUARD_DELAYLOAD_IAT_IN_ITS_OWN_SECTION 0x00002000")]
        public const int IMAGE_GUARD_DELAYLOAD_IAT_IN_ITS_OWN_SECTION = 0x00002000;

        [NativeTypeName("#define IMAGE_GUARD_CF_EXPORT_SUPPRESSION_INFO_PRESENT 0x00004000")]
        public const int IMAGE_GUARD_CF_EXPORT_SUPPRESSION_INFO_PRESENT = 0x00004000;

        [NativeTypeName("#define IMAGE_GUARD_CF_ENABLE_EXPORT_SUPPRESSION 0x00008000")]
        public const int IMAGE_GUARD_CF_ENABLE_EXPORT_SUPPRESSION = 0x00008000;

        [NativeTypeName("#define IMAGE_GUARD_CF_LONGJUMP_TABLE_PRESENT 0x00010000")]
        public const int IMAGE_GUARD_CF_LONGJUMP_TABLE_PRESENT = 0x00010000;

        [NativeTypeName("#define IMAGE_GUARD_RF_INSTRUMENTED 0x00020000")]
        public const int IMAGE_GUARD_RF_INSTRUMENTED = 0x00020000;

        [NativeTypeName("#define IMAGE_GUARD_RF_ENABLE 0x00040000")]
        public const int IMAGE_GUARD_RF_ENABLE = 0x00040000;

        [NativeTypeName("#define IMAGE_GUARD_RF_STRICT 0x00080000")]
        public const int IMAGE_GUARD_RF_STRICT = 0x00080000;

        [NativeTypeName("#define IMAGE_GUARD_RETPOLINE_PRESENT 0x00100000")]
        public const int IMAGE_GUARD_RETPOLINE_PRESENT = 0x00100000;

        [NativeTypeName("#define IMAGE_GUARD_EH_CONTINUATION_TABLE_PRESENT 0x00200000")]
        public const int IMAGE_GUARD_EH_CONTINUATION_TABLE_PRESENT = 0x00200000;

        [NativeTypeName("#define IMAGE_GUARD_CF_FUNCTION_TABLE_SIZE_MASK 0xF0000000")]
        public const uint IMAGE_GUARD_CF_FUNCTION_TABLE_SIZE_MASK = 0xF0000000;

        [NativeTypeName("#define IMAGE_GUARD_CF_FUNCTION_TABLE_SIZE_SHIFT 28")]
        public const int IMAGE_GUARD_CF_FUNCTION_TABLE_SIZE_SHIFT = 28;

        [NativeTypeName("#define IMAGE_GUARD_FLAG_FID_SUPPRESSED 0x01")]
        public const int IMAGE_GUARD_FLAG_FID_SUPPRESSED = 0x01;

        [NativeTypeName("#define IMAGE_GUARD_FLAG_EXPORT_SUPPRESSED 0x02")]
        public const int IMAGE_GUARD_FLAG_EXPORT_SUPPRESSED = 0x02;

        [NativeTypeName("#define IMAGE_ENCLAVE_LONG_ID_LENGTH ENCLAVE_LONG_ID_LENGTH")]
        public const int IMAGE_ENCLAVE_LONG_ID_LENGTH = 32;

        [NativeTypeName("#define IMAGE_ENCLAVE_SHORT_ID_LENGTH ENCLAVE_SHORT_ID_LENGTH")]
        public const int IMAGE_ENCLAVE_SHORT_ID_LENGTH = 16;

        [NativeTypeName("#define IMAGE_ENCLAVE_POLICY_DEBUGGABLE 0x00000001")]
        public const int IMAGE_ENCLAVE_POLICY_DEBUGGABLE = 0x00000001;

        [NativeTypeName("#define IMAGE_ENCLAVE_FLAG_PRIMARY_IMAGE 0x00000001")]
        public const int IMAGE_ENCLAVE_FLAG_PRIMARY_IMAGE = 0x00000001;

        [NativeTypeName("#define IMAGE_ENCLAVE_IMPORT_MATCH_NONE 0x00000000")]
        public const int IMAGE_ENCLAVE_IMPORT_MATCH_NONE = 0x00000000;

        [NativeTypeName("#define IMAGE_ENCLAVE_IMPORT_MATCH_UNIQUE_ID 0x00000001")]
        public const int IMAGE_ENCLAVE_IMPORT_MATCH_UNIQUE_ID = 0x00000001;

        [NativeTypeName("#define IMAGE_ENCLAVE_IMPORT_MATCH_AUTHOR_ID 0x00000002")]
        public const int IMAGE_ENCLAVE_IMPORT_MATCH_AUTHOR_ID = 0x00000002;

        [NativeTypeName("#define IMAGE_ENCLAVE_IMPORT_MATCH_FAMILY_ID 0x00000003")]
        public const int IMAGE_ENCLAVE_IMPORT_MATCH_FAMILY_ID = 0x00000003;

        [NativeTypeName("#define IMAGE_ENCLAVE_IMPORT_MATCH_IMAGE_ID 0x00000004")]
        public const int IMAGE_ENCLAVE_IMPORT_MATCH_IMAGE_ID = 0x00000004;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_UNKNOWN 0")]
        public const int IMAGE_DEBUG_TYPE_UNKNOWN = 0;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_COFF 1")]
        public const int IMAGE_DEBUG_TYPE_COFF = 1;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_CODEVIEW 2")]
        public const int IMAGE_DEBUG_TYPE_CODEVIEW = 2;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_FPO 3")]
        public const int IMAGE_DEBUG_TYPE_FPO = 3;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_MISC 4")]
        public const int IMAGE_DEBUG_TYPE_MISC = 4;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_EXCEPTION 5")]
        public const int IMAGE_DEBUG_TYPE_EXCEPTION = 5;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_FIXUP 6")]
        public const int IMAGE_DEBUG_TYPE_FIXUP = 6;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_OMAP_TO_SRC 7")]
        public const int IMAGE_DEBUG_TYPE_OMAP_TO_SRC = 7;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_OMAP_FROM_SRC 8")]
        public const int IMAGE_DEBUG_TYPE_OMAP_FROM_SRC = 8;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_BORLAND 9")]
        public const int IMAGE_DEBUG_TYPE_BORLAND = 9;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_RESERVED10 10")]
        public const int IMAGE_DEBUG_TYPE_RESERVED10 = 10;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_CLSID 11")]
        public const int IMAGE_DEBUG_TYPE_CLSID = 11;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_VC_FEATURE 12")]
        public const int IMAGE_DEBUG_TYPE_VC_FEATURE = 12;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_POGO 13")]
        public const int IMAGE_DEBUG_TYPE_POGO = 13;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_ILTCG 14")]
        public const int IMAGE_DEBUG_TYPE_ILTCG = 14;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_MPX 15")]
        public const int IMAGE_DEBUG_TYPE_MPX = 15;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_REPRO 16")]
        public const int IMAGE_DEBUG_TYPE_REPRO = 16;

        [NativeTypeName("#define IMAGE_DEBUG_TYPE_EX_DLLCHARACTERISTICS 20")]
        public const int IMAGE_DEBUG_TYPE_EX_DLLCHARACTERISTICS = 20;

        [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_EX_CET_COMPAT 0x1")]
        public const int IMAGE_DLLCHARACTERISTICS_EX_CET_COMPAT = 0x1;

        [NativeTypeName("#define FRAME_FPO 0")]
        public const int FRAME_FPO = 0;

        [NativeTypeName("#define FRAME_TRAP 1")]
        public const int FRAME_TRAP = 1;

        [NativeTypeName("#define FRAME_TSS 2")]
        public const int FRAME_TSS = 2;

        [NativeTypeName("#define FRAME_NONFPO 3")]
        public const int FRAME_NONFPO = 3;

        [NativeTypeName("#define SIZEOF_RFPO_DATA 16")]
        public const int SIZEOF_RFPO_DATA = 16;

        [NativeTypeName("#define IMAGE_DEBUG_MISC_EXENAME 1")]
        public const int IMAGE_DEBUG_MISC_EXENAME = 1;

        [NativeTypeName("#define IMAGE_SEPARATE_DEBUG_SIGNATURE 0x4944")]
        public const int IMAGE_SEPARATE_DEBUG_SIGNATURE = 0x4944;

        [NativeTypeName("#define NON_PAGED_DEBUG_SIGNATURE 0x494E")]
        public const int NON_PAGED_DEBUG_SIGNATURE = 0x494E;

        [NativeTypeName("#define IMAGE_SEPARATE_DEBUG_FLAGS_MASK 0x8000")]
        public const int IMAGE_SEPARATE_DEBUG_FLAGS_MASK = 0x8000;

        [NativeTypeName("#define IMAGE_SEPARATE_DEBUG_MISMATCH 0x8000")]
        public const int IMAGE_SEPARATE_DEBUG_MISMATCH = 0x8000;

        [NativeTypeName("#define IMPORT_OBJECT_HDR_SIG2 0xffff")]
        public const int IMPORT_OBJECT_HDR_SIG2 = 0xffff;

        [NativeTypeName("#define RTL_RUN_ONCE_CHECK_ONLY 0x00000001UL")]
        public const uint RTL_RUN_ONCE_CHECK_ONLY = 0x00000001U;

        [NativeTypeName("#define RTL_RUN_ONCE_ASYNC 0x00000002UL")]
        public const uint RTL_RUN_ONCE_ASYNC = 0x00000002U;

        [NativeTypeName("#define RTL_RUN_ONCE_INIT_FAILED 0x00000004UL")]
        public const uint RTL_RUN_ONCE_INIT_FAILED = 0x00000004U;

        [NativeTypeName("#define RTL_RUN_ONCE_CTX_RESERVED_BITS 2")]
        public const int RTL_RUN_ONCE_CTX_RESERVED_BITS = 2;

        [NativeTypeName("#define FAST_FAIL_LEGACY_GS_VIOLATION 0")]
        public const int FAST_FAIL_LEGACY_GS_VIOLATION = 0;

        [NativeTypeName("#define FAST_FAIL_VTGUARD_CHECK_FAILURE 1")]
        public const int FAST_FAIL_VTGUARD_CHECK_FAILURE = 1;

        [NativeTypeName("#define FAST_FAIL_STACK_COOKIE_CHECK_FAILURE 2")]
        public const int FAST_FAIL_STACK_COOKIE_CHECK_FAILURE = 2;

        [NativeTypeName("#define FAST_FAIL_CORRUPT_LIST_ENTRY 3")]
        public const int FAST_FAIL_CORRUPT_LIST_ENTRY = 3;

        [NativeTypeName("#define FAST_FAIL_INCORRECT_STACK 4")]
        public const int FAST_FAIL_INCORRECT_STACK = 4;

        [NativeTypeName("#define FAST_FAIL_INVALID_ARG 5")]
        public const int FAST_FAIL_INVALID_ARG = 5;

        [NativeTypeName("#define FAST_FAIL_GS_COOKIE_INIT 6")]
        public const int FAST_FAIL_GS_COOKIE_INIT = 6;

        [NativeTypeName("#define FAST_FAIL_FATAL_APP_EXIT 7")]
        public const int FAST_FAIL_FATAL_APP_EXIT = 7;

        [NativeTypeName("#define FAST_FAIL_RANGE_CHECK_FAILURE 8")]
        public const int FAST_FAIL_RANGE_CHECK_FAILURE = 8;

        [NativeTypeName("#define FAST_FAIL_UNSAFE_REGISTRY_ACCESS 9")]
        public const int FAST_FAIL_UNSAFE_REGISTRY_ACCESS = 9;

        [NativeTypeName("#define FAST_FAIL_GUARD_ICALL_CHECK_FAILURE 10")]
        public const int FAST_FAIL_GUARD_ICALL_CHECK_FAILURE = 10;

        [NativeTypeName("#define FAST_FAIL_GUARD_WRITE_CHECK_FAILURE 11")]
        public const int FAST_FAIL_GUARD_WRITE_CHECK_FAILURE = 11;

        [NativeTypeName("#define FAST_FAIL_INVALID_FIBER_SWITCH 12")]
        public const int FAST_FAIL_INVALID_FIBER_SWITCH = 12;

        [NativeTypeName("#define FAST_FAIL_INVALID_SET_OF_CONTEXT 13")]
        public const int FAST_FAIL_INVALID_SET_OF_CONTEXT = 13;

        [NativeTypeName("#define FAST_FAIL_INVALID_REFERENCE_COUNT 14")]
        public const int FAST_FAIL_INVALID_REFERENCE_COUNT = 14;

        [NativeTypeName("#define FAST_FAIL_INVALID_JUMP_BUFFER 18")]
        public const int FAST_FAIL_INVALID_JUMP_BUFFER = 18;

        [NativeTypeName("#define FAST_FAIL_MRDATA_MODIFIED 19")]
        public const int FAST_FAIL_MRDATA_MODIFIED = 19;

        [NativeTypeName("#define FAST_FAIL_CERTIFICATION_FAILURE 20")]
        public const int FAST_FAIL_CERTIFICATION_FAILURE = 20;

        [NativeTypeName("#define FAST_FAIL_INVALID_EXCEPTION_CHAIN 21")]
        public const int FAST_FAIL_INVALID_EXCEPTION_CHAIN = 21;

        [NativeTypeName("#define FAST_FAIL_CRYPTO_LIBRARY 22")]
        public const int FAST_FAIL_CRYPTO_LIBRARY = 22;

        [NativeTypeName("#define FAST_FAIL_INVALID_CALL_IN_DLL_CALLOUT 23")]
        public const int FAST_FAIL_INVALID_CALL_IN_DLL_CALLOUT = 23;

        [NativeTypeName("#define FAST_FAIL_INVALID_IMAGE_BASE 24")]
        public const int FAST_FAIL_INVALID_IMAGE_BASE = 24;

        [NativeTypeName("#define FAST_FAIL_DLOAD_PROTECTION_FAILURE 25")]
        public const int FAST_FAIL_DLOAD_PROTECTION_FAILURE = 25;

        [NativeTypeName("#define FAST_FAIL_UNSAFE_EXTENSION_CALL 26")]
        public const int FAST_FAIL_UNSAFE_EXTENSION_CALL = 26;

        [NativeTypeName("#define FAST_FAIL_DEPRECATED_SERVICE_INVOKED 27")]
        public const int FAST_FAIL_DEPRECATED_SERVICE_INVOKED = 27;

        [NativeTypeName("#define FAST_FAIL_INVALID_BUFFER_ACCESS 28")]
        public const int FAST_FAIL_INVALID_BUFFER_ACCESS = 28;

        [NativeTypeName("#define FAST_FAIL_INVALID_BALANCED_TREE 29")]
        public const int FAST_FAIL_INVALID_BALANCED_TREE = 29;

        [NativeTypeName("#define FAST_FAIL_INVALID_NEXT_THREAD 30")]
        public const int FAST_FAIL_INVALID_NEXT_THREAD = 30;

        [NativeTypeName("#define FAST_FAIL_GUARD_ICALL_CHECK_SUPPRESSED 31")]
        public const int FAST_FAIL_GUARD_ICALL_CHECK_SUPPRESSED = 31;

        [NativeTypeName("#define FAST_FAIL_APCS_DISABLED 32")]
        public const int FAST_FAIL_APCS_DISABLED = 32;

        [NativeTypeName("#define FAST_FAIL_INVALID_IDLE_STATE 33")]
        public const int FAST_FAIL_INVALID_IDLE_STATE = 33;

        [NativeTypeName("#define FAST_FAIL_MRDATA_PROTECTION_FAILURE 34")]
        public const int FAST_FAIL_MRDATA_PROTECTION_FAILURE = 34;

        [NativeTypeName("#define FAST_FAIL_UNEXPECTED_HEAP_EXCEPTION 35")]
        public const int FAST_FAIL_UNEXPECTED_HEAP_EXCEPTION = 35;

        [NativeTypeName("#define FAST_FAIL_INVALID_LOCK_STATE 36")]
        public const int FAST_FAIL_INVALID_LOCK_STATE = 36;

        [NativeTypeName("#define FAST_FAIL_GUARD_JUMPTABLE 37")]
        public const int FAST_FAIL_GUARD_JUMPTABLE = 37;

        [NativeTypeName("#define FAST_FAIL_INVALID_LONGJUMP_TARGET 38")]
        public const int FAST_FAIL_INVALID_LONGJUMP_TARGET = 38;

        [NativeTypeName("#define FAST_FAIL_INVALID_DISPATCH_CONTEXT 39")]
        public const int FAST_FAIL_INVALID_DISPATCH_CONTEXT = 39;

        [NativeTypeName("#define FAST_FAIL_INVALID_THREAD 40")]
        public const int FAST_FAIL_INVALID_THREAD = 40;

        [NativeTypeName("#define FAST_FAIL_INVALID_SYSCALL_NUMBER 41")]
        public const int FAST_FAIL_INVALID_SYSCALL_NUMBER = 41;

        [NativeTypeName("#define FAST_FAIL_INVALID_FILE_OPERATION 42")]
        public const int FAST_FAIL_INVALID_FILE_OPERATION = 42;

        [NativeTypeName("#define FAST_FAIL_LPAC_ACCESS_DENIED 43")]
        public const int FAST_FAIL_LPAC_ACCESS_DENIED = 43;

        [NativeTypeName("#define FAST_FAIL_GUARD_SS_FAILURE 44")]
        public const int FAST_FAIL_GUARD_SS_FAILURE = 44;

        [NativeTypeName("#define FAST_FAIL_LOADER_CONTINUITY_FAILURE 45")]
        public const int FAST_FAIL_LOADER_CONTINUITY_FAILURE = 45;

        [NativeTypeName("#define FAST_FAIL_GUARD_EXPORT_SUPPRESSION_FAILURE 46")]
        public const int FAST_FAIL_GUARD_EXPORT_SUPPRESSION_FAILURE = 46;

        [NativeTypeName("#define FAST_FAIL_INVALID_CONTROL_STACK 47")]
        public const int FAST_FAIL_INVALID_CONTROL_STACK = 47;

        [NativeTypeName("#define FAST_FAIL_SET_CONTEXT_DENIED 48")]
        public const int FAST_FAIL_SET_CONTEXT_DENIED = 48;

        [NativeTypeName("#define FAST_FAIL_INVALID_IAT 49")]
        public const int FAST_FAIL_INVALID_IAT = 49;

        [NativeTypeName("#define FAST_FAIL_HEAP_METADATA_CORRUPTION 50")]
        public const int FAST_FAIL_HEAP_METADATA_CORRUPTION = 50;

        [NativeTypeName("#define FAST_FAIL_PAYLOAD_RESTRICTION_VIOLATION 51")]
        public const int FAST_FAIL_PAYLOAD_RESTRICTION_VIOLATION = 51;

        [NativeTypeName("#define FAST_FAIL_LOW_LABEL_ACCESS_DENIED 52")]
        public const int FAST_FAIL_LOW_LABEL_ACCESS_DENIED = 52;

        [NativeTypeName("#define FAST_FAIL_ENCLAVE_CALL_FAILURE 53")]
        public const int FAST_FAIL_ENCLAVE_CALL_FAILURE = 53;

        [NativeTypeName("#define FAST_FAIL_UNHANDLED_LSS_EXCEPTON 54")]
        public const int FAST_FAIL_UNHANDLED_LSS_EXCEPTON = 54;

        [NativeTypeName("#define FAST_FAIL_ADMINLESS_ACCESS_DENIED 55")]
        public const int FAST_FAIL_ADMINLESS_ACCESS_DENIED = 55;

        [NativeTypeName("#define FAST_FAIL_UNEXPECTED_CALL 56")]
        public const int FAST_FAIL_UNEXPECTED_CALL = 56;

        [NativeTypeName("#define FAST_FAIL_CONTROL_INVALID_RETURN_ADDRESS 57")]
        public const int FAST_FAIL_CONTROL_INVALID_RETURN_ADDRESS = 57;

        [NativeTypeName("#define FAST_FAIL_UNEXPECTED_HOST_BEHAVIOR 58")]
        public const int FAST_FAIL_UNEXPECTED_HOST_BEHAVIOR = 58;

        [NativeTypeName("#define FAST_FAIL_FLAGS_CORRUPTION 59")]
        public const int FAST_FAIL_FLAGS_CORRUPTION = 59;

        [NativeTypeName("#define FAST_FAIL_VEH_CORRUPTION 60")]
        public const int FAST_FAIL_VEH_CORRUPTION = 60;

        [NativeTypeName("#define FAST_FAIL_ETW_CORRUPTION 61")]
        public const int FAST_FAIL_ETW_CORRUPTION = 61;

        [NativeTypeName("#define FAST_FAIL_RIO_ABORT 62")]
        public const int FAST_FAIL_RIO_ABORT = 62;

        [NativeTypeName("#define FAST_FAIL_INVALID_PFN 63")]
        public const int FAST_FAIL_INVALID_PFN = 63;

        [NativeTypeName("#define FAST_FAIL_INVALID_FAST_FAIL_CODE 0xFFFFFFFF")]
        public const uint FAST_FAIL_INVALID_FAST_FAIL_CODE = 0xFFFFFFFF;

        [NativeTypeName("#define HEAP_NO_SERIALIZE 0x00000001")]
        public const int HEAP_NO_SERIALIZE = 0x00000001;

        [NativeTypeName("#define HEAP_GROWABLE 0x00000002")]
        public const int HEAP_GROWABLE = 0x00000002;

        [NativeTypeName("#define HEAP_GENERATE_EXCEPTIONS 0x00000004")]
        public const int HEAP_GENERATE_EXCEPTIONS = 0x00000004;

        [NativeTypeName("#define HEAP_ZERO_MEMORY 0x00000008")]
        public const int HEAP_ZERO_MEMORY = 0x00000008;

        [NativeTypeName("#define HEAP_REALLOC_IN_PLACE_ONLY 0x00000010")]
        public const int HEAP_REALLOC_IN_PLACE_ONLY = 0x00000010;

        [NativeTypeName("#define HEAP_TAIL_CHECKING_ENABLED 0x00000020")]
        public const int HEAP_TAIL_CHECKING_ENABLED = 0x00000020;

        [NativeTypeName("#define HEAP_FREE_CHECKING_ENABLED 0x00000040")]
        public const int HEAP_FREE_CHECKING_ENABLED = 0x00000040;

        [NativeTypeName("#define HEAP_DISABLE_COALESCE_ON_FREE 0x00000080")]
        public const int HEAP_DISABLE_COALESCE_ON_FREE = 0x00000080;

        [NativeTypeName("#define HEAP_CREATE_ALIGN_16 0x00010000")]
        public const int HEAP_CREATE_ALIGN_16 = 0x00010000;

        [NativeTypeName("#define HEAP_CREATE_ENABLE_TRACING 0x00020000")]
        public const int HEAP_CREATE_ENABLE_TRACING = 0x00020000;

        [NativeTypeName("#define HEAP_CREATE_ENABLE_EXECUTE 0x00040000")]
        public const int HEAP_CREATE_ENABLE_EXECUTE = 0x00040000;

        [NativeTypeName("#define HEAP_MAXIMUM_TAG 0x0FFF")]
        public const int HEAP_MAXIMUM_TAG = 0x0FFF;

        [NativeTypeName("#define HEAP_PSEUDO_TAG_FLAG 0x8000")]
        public const int HEAP_PSEUDO_TAG_FLAG = 0x8000;

        [NativeTypeName("#define HEAP_TAG_SHIFT 18")]
        public const int HEAP_TAG_SHIFT = 18;

        [NativeTypeName("#define HEAP_CREATE_SEGMENT_HEAP 0x00000100")]
        public const int HEAP_CREATE_SEGMENT_HEAP = 0x00000100;

        [NativeTypeName("#define HEAP_CREATE_HARDENED 0x00000200")]
        public const int HEAP_CREATE_HARDENED = 0x00000200;

        [NativeTypeName("#define IS_TEXT_UNICODE_ASCII16 0x0001")]
        public const int IS_TEXT_UNICODE_ASCII16 = 0x0001;

        [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_ASCII16 0x0010")]
        public const int IS_TEXT_UNICODE_REVERSE_ASCII16 = 0x0010;

        [NativeTypeName("#define IS_TEXT_UNICODE_STATISTICS 0x0002")]
        public const int IS_TEXT_UNICODE_STATISTICS = 0x0002;

        [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_STATISTICS 0x0020")]
        public const int IS_TEXT_UNICODE_REVERSE_STATISTICS = 0x0020;

        [NativeTypeName("#define IS_TEXT_UNICODE_CONTROLS 0x0004")]
        public const int IS_TEXT_UNICODE_CONTROLS = 0x0004;

        [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_CONTROLS 0x0040")]
        public const int IS_TEXT_UNICODE_REVERSE_CONTROLS = 0x0040;

        [NativeTypeName("#define IS_TEXT_UNICODE_SIGNATURE 0x0008")]
        public const int IS_TEXT_UNICODE_SIGNATURE = 0x0008;

        [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_SIGNATURE 0x0080")]
        public const int IS_TEXT_UNICODE_REVERSE_SIGNATURE = 0x0080;

        [NativeTypeName("#define IS_TEXT_UNICODE_ILLEGAL_CHARS 0x0100")]
        public const int IS_TEXT_UNICODE_ILLEGAL_CHARS = 0x0100;

        [NativeTypeName("#define IS_TEXT_UNICODE_ODD_LENGTH 0x0200")]
        public const int IS_TEXT_UNICODE_ODD_LENGTH = 0x0200;

        [NativeTypeName("#define IS_TEXT_UNICODE_DBCS_LEADBYTE 0x0400")]
        public const int IS_TEXT_UNICODE_DBCS_LEADBYTE = 0x0400;

        [NativeTypeName("#define IS_TEXT_UNICODE_NULL_BYTES 0x1000")]
        public const int IS_TEXT_UNICODE_NULL_BYTES = 0x1000;

        [NativeTypeName("#define IS_TEXT_UNICODE_UNICODE_MASK 0x000F")]
        public const int IS_TEXT_UNICODE_UNICODE_MASK = 0x000F;

        [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_MASK 0x00F0")]
        public const int IS_TEXT_UNICODE_REVERSE_MASK = 0x00F0;

        [NativeTypeName("#define IS_TEXT_UNICODE_NOT_UNICODE_MASK 0x0F00")]
        public const int IS_TEXT_UNICODE_NOT_UNICODE_MASK = 0x0F00;

        [NativeTypeName("#define IS_TEXT_UNICODE_NOT_ASCII_MASK 0xF000")]
        public const int IS_TEXT_UNICODE_NOT_ASCII_MASK = 0xF000;

        [NativeTypeName("#define COMPRESSION_FORMAT_NONE (0x0000)")]
        public const int COMPRESSION_FORMAT_NONE = (0x0000);

        [NativeTypeName("#define COMPRESSION_FORMAT_DEFAULT (0x0001)")]
        public const int COMPRESSION_FORMAT_DEFAULT = (0x0001);

        [NativeTypeName("#define COMPRESSION_FORMAT_LZNT1 (0x0002)")]
        public const int COMPRESSION_FORMAT_LZNT1 = (0x0002);

        [NativeTypeName("#define COMPRESSION_FORMAT_XPRESS (0x0003)")]
        public const int COMPRESSION_FORMAT_XPRESS = (0x0003);

        [NativeTypeName("#define COMPRESSION_FORMAT_XPRESS_HUFF (0x0004)")]
        public const int COMPRESSION_FORMAT_XPRESS_HUFF = (0x0004);

        [NativeTypeName("#define COMPRESSION_ENGINE_STANDARD (0x0000)")]
        public const int COMPRESSION_ENGINE_STANDARD = (0x0000);

        [NativeTypeName("#define COMPRESSION_ENGINE_MAXIMUM (0x0100)")]
        public const int COMPRESSION_ENGINE_MAXIMUM = (0x0100);

        [NativeTypeName("#define COMPRESSION_ENGINE_HIBER (0x0200)")]
        public const int COMPRESSION_ENGINE_HIBER = (0x0200);

        [NativeTypeName("#define SEF_DACL_AUTO_INHERIT 0x01")]
        public const int SEF_DACL_AUTO_INHERIT = 0x01;

        [NativeTypeName("#define SEF_SACL_AUTO_INHERIT 0x02")]
        public const int SEF_SACL_AUTO_INHERIT = 0x02;

        [NativeTypeName("#define SEF_DEFAULT_DESCRIPTOR_FOR_OBJECT 0x04")]
        public const int SEF_DEFAULT_DESCRIPTOR_FOR_OBJECT = 0x04;

        [NativeTypeName("#define SEF_AVOID_PRIVILEGE_CHECK 0x08")]
        public const int SEF_AVOID_PRIVILEGE_CHECK = 0x08;

        [NativeTypeName("#define SEF_AVOID_OWNER_CHECK 0x10")]
        public const int SEF_AVOID_OWNER_CHECK = 0x10;

        [NativeTypeName("#define SEF_DEFAULT_OWNER_FROM_PARENT 0x20")]
        public const int SEF_DEFAULT_OWNER_FROM_PARENT = 0x20;

        [NativeTypeName("#define SEF_DEFAULT_GROUP_FROM_PARENT 0x40")]
        public const int SEF_DEFAULT_GROUP_FROM_PARENT = 0x40;

        [NativeTypeName("#define SEF_MACL_NO_WRITE_UP 0x100")]
        public const int SEF_MACL_NO_WRITE_UP = 0x100;

        [NativeTypeName("#define SEF_MACL_NO_READ_UP 0x200")]
        public const int SEF_MACL_NO_READ_UP = 0x200;

        [NativeTypeName("#define SEF_MACL_NO_EXECUTE_UP 0x400")]
        public const int SEF_MACL_NO_EXECUTE_UP = 0x400;

        [NativeTypeName("#define SEF_AI_USE_EXTRA_PARAMS 0x800")]
        public const int SEF_AI_USE_EXTRA_PARAMS = 0x800;

        [NativeTypeName("#define SEF_AVOID_OWNER_RESTRICTION 0x1000")]
        public const int SEF_AVOID_OWNER_RESTRICTION = 0x1000;

        [NativeTypeName("#define SEF_FORCE_USER_MODE 0x2000")]
        public const int SEF_FORCE_USER_MODE = 0x2000;

        [NativeTypeName("#define SEF_MACL_VALID_FLAGS (SEF_MACL_NO_WRITE_UP   | \\\r\n                                           SEF_MACL_NO_READ_UP    | \\\r\n                                           SEF_MACL_NO_EXECUTE_UP)")]
        public const int SEF_MACL_VALID_FLAGS = (0x100 | 0x200 | 0x400);

        [NativeTypeName("#define MESSAGE_RESOURCE_UNICODE 0x0001")]
        public const int MESSAGE_RESOURCE_UNICODE = 0x0001;

        [NativeTypeName("#define MESSAGE_RESOURCE_UTF8 0x0002")]
        public const int MESSAGE_RESOURCE_UTF8 = 0x0002;

        [NativeTypeName("#define VER_EQUAL 1")]
        public const int VER_EQUAL = 1;

        [NativeTypeName("#define VER_GREATER 2")]
        public const int VER_GREATER = 2;

        [NativeTypeName("#define VER_GREATER_EQUAL 3")]
        public const int VER_GREATER_EQUAL = 3;

        [NativeTypeName("#define VER_LESS 4")]
        public const int VER_LESS = 4;

        [NativeTypeName("#define VER_LESS_EQUAL 5")]
        public const int VER_LESS_EQUAL = 5;

        [NativeTypeName("#define VER_AND 6")]
        public const int VER_AND = 6;

        [NativeTypeName("#define VER_OR 7")]
        public const int VER_OR = 7;

        [NativeTypeName("#define VER_CONDITION_MASK 7")]
        public const int VER_CONDITION_MASK = 7;

        [NativeTypeName("#define VER_NUM_BITS_PER_CONDITION_MASK 3")]
        public const int VER_NUM_BITS_PER_CONDITION_MASK = 3;

        [NativeTypeName("#define VER_MINORVERSION 0x0000001")]
        public const int VER_MINORVERSION = 0x0000001;

        [NativeTypeName("#define VER_MAJORVERSION 0x0000002")]
        public const int VER_MAJORVERSION = 0x0000002;

        [NativeTypeName("#define VER_BUILDNUMBER 0x0000004")]
        public const int VER_BUILDNUMBER = 0x0000004;

        [NativeTypeName("#define VER_PLATFORMID 0x0000008")]
        public const int VER_PLATFORMID = 0x0000008;

        [NativeTypeName("#define VER_SERVICEPACKMINOR 0x0000010")]
        public const int VER_SERVICEPACKMINOR = 0x0000010;

        [NativeTypeName("#define VER_SERVICEPACKMAJOR 0x0000020")]
        public const int VER_SERVICEPACKMAJOR = 0x0000020;

        [NativeTypeName("#define VER_SUITENAME 0x0000040")]
        public const int VER_SUITENAME = 0x0000040;

        [NativeTypeName("#define VER_PRODUCT_TYPE 0x0000080")]
        public const int VER_PRODUCT_TYPE = 0x0000080;

        [NativeTypeName("#define VER_NT_WORKSTATION 0x0000001")]
        public const int VER_NT_WORKSTATION = 0x0000001;

        [NativeTypeName("#define VER_NT_DOMAIN_CONTROLLER 0x0000002")]
        public const int VER_NT_DOMAIN_CONTROLLER = 0x0000002;

        [NativeTypeName("#define VER_NT_SERVER 0x0000003")]
        public const int VER_NT_SERVER = 0x0000003;

        [NativeTypeName("#define VER_PLATFORM_WIN32s 0")]
        public const int VER_PLATFORM_WIN32s = 0;

        [NativeTypeName("#define VER_PLATFORM_WIN32_WINDOWS 1")]
        public const int VER_PLATFORM_WIN32_WINDOWS = 1;

        [NativeTypeName("#define VER_PLATFORM_WIN32_NT 2")]
        public const int VER_PLATFORM_WIN32_NT = 2;

        [NativeTypeName("#define RTL_UMS_VERSION (0x0100)")]
        public const int RTL_UMS_VERSION = (0x0100);

        [NativeTypeName("#define VRL_PREDEFINED_CLASS_BEGIN (1 << 0)")]
        public const int VRL_PREDEFINED_CLASS_BEGIN = (1 << 0);

        [NativeTypeName("#define VRL_CUSTOM_CLASS_BEGIN (1 << 8)")]
        public const int VRL_CUSTOM_CLASS_BEGIN = (1 << 8);

        [NativeTypeName("#define VRL_CLASS_CONSISTENCY (VRL_PREDEFINED_CLASS_BEGIN << 0)")]
        public const int VRL_CLASS_CONSISTENCY = ((1 << 0) << 0);

        [NativeTypeName("#define VRL_ENABLE_KERNEL_BREAKS (1 << 31)")]
        public const int VRL_ENABLE_KERNEL_BREAKS = (1 << 31);

        [NativeTypeName("#define CTMF_INCLUDE_APPCONTAINER 0x00000001UL")]
        public const uint CTMF_INCLUDE_APPCONTAINER = 0x00000001U;

        [NativeTypeName("#define CTMF_INCLUDE_LPAC 0x00000002UL")]
        public const uint CTMF_INCLUDE_LPAC = 0x00000002U;

        [NativeTypeName("#define CTMF_VALID_FLAGS (CTMF_INCLUDE_APPCONTAINER | CTMF_INCLUDE_LPAC)")]
        public const uint CTMF_VALID_FLAGS = (0x00000001U | 0x00000002U);

        [NativeTypeName("#define FLUSH_NV_MEMORY_IN_FLAG_NO_DRAIN (0x00000001)")]
        public const int FLUSH_NV_MEMORY_IN_FLAG_NO_DRAIN = (0x00000001);

        [NativeTypeName("#define FLUSH_NV_MEMORY_DEFAULT_TOKEN (ULONG_PTR)(-1)")]
        public static readonly nuint FLUSH_NV_MEMORY_DEFAULT_TOKEN = unchecked((nuint)(-1));

        [NativeTypeName("#define WRITE_NV_MEMORY_FLAG_FLUSH (0x00000001)")]
        public const int WRITE_NV_MEMORY_FLAG_FLUSH = (0x00000001);

        [NativeTypeName("#define WRITE_NV_MEMORY_FLAG_NON_TEMPORAL (0x00000002)")]
        public const int WRITE_NV_MEMORY_FLAG_NON_TEMPORAL = (0x00000002);

        [NativeTypeName("#define WRITE_NV_MEMORY_FLAG_PERSIST (WRITE_NV_MEMORY_FLAG_FLUSH \\\r\n                                              | WRITE_NV_MEMORY_FLAG_NON_TEMPORAL)")]
        public const int WRITE_NV_MEMORY_FLAG_PERSIST = ((0x00000001) | (0x00000002));

        [NativeTypeName("#define WRITE_NV_MEMORY_FLAG_NO_DRAIN (0x00000100)")]
        public const int WRITE_NV_MEMORY_FLAG_NO_DRAIN = (0x00000100);

        [NativeTypeName("#define FILL_NV_MEMORY_FLAG_FLUSH (0x00000001)")]
        public const int FILL_NV_MEMORY_FLAG_FLUSH = (0x00000001);

        [NativeTypeName("#define FILL_NV_MEMORY_FLAG_NON_TEMPORAL (0x00000002)")]
        public const int FILL_NV_MEMORY_FLAG_NON_TEMPORAL = (0x00000002);

        [NativeTypeName("#define FILL_NV_MEMORY_FLAG_PERSIST (FILL_NV_MEMORY_FLAG_FLUSH \\\r\n                                              | FILL_NV_MEMORY_FLAG_NON_TEMPORAL)")]
        public const int FILL_NV_MEMORY_FLAG_PERSIST = ((0x00000001) | (0x00000002));

        [NativeTypeName("#define FILL_NV_MEMORY_FLAG_NO_DRAIN (0x00000100)")]
        public const int FILL_NV_MEMORY_FLAG_NO_DRAIN = (0x00000100);

        [NativeTypeName("#define RTL_CORRELATION_VECTOR_STRING_LENGTH 129")]
        public const int RTL_CORRELATION_VECTOR_STRING_LENGTH = 129;

        [NativeTypeName("#define RTL_CORRELATION_VECTOR_VERSION_1 ((CHAR)1)")]
        public const sbyte RTL_CORRELATION_VECTOR_VERSION_1 = ((sbyte)(1));

        [NativeTypeName("#define RTL_CORRELATION_VECTOR_VERSION_2 ((CHAR)2)")]
        public const sbyte RTL_CORRELATION_VECTOR_VERSION_2 = ((sbyte)(2));

        [NativeTypeName("#define RTL_CORRELATION_VECTOR_VERSION_CURRENT RTL_CORRELATION_VECTOR_VERSION_2")]
        public const sbyte RTL_CORRELATION_VECTOR_VERSION_CURRENT = ((sbyte)(2));

        [NativeTypeName("#define RTL_CORRELATION_VECTOR_V1_PREFIX_LENGTH (16)")]
        public const int RTL_CORRELATION_VECTOR_V1_PREFIX_LENGTH = (16);

        [NativeTypeName("#define RTL_CORRELATION_VECTOR_V1_LENGTH (64)")]
        public const int RTL_CORRELATION_VECTOR_V1_LENGTH = (64);

        [NativeTypeName("#define RTL_CORRELATION_VECTOR_V2_PREFIX_LENGTH (22)")]
        public const int RTL_CORRELATION_VECTOR_V2_PREFIX_LENGTH = (22);

        [NativeTypeName("#define RTL_CORRELATION_VECTOR_V2_LENGTH (128)")]
        public const int RTL_CORRELATION_VECTOR_V2_LENGTH = (128);

        [NativeTypeName("#define IMAGE_POLICY_METADATA_VERSION 1")]
        public const int IMAGE_POLICY_METADATA_VERSION = 1;

        [NativeTypeName("#define IMAGE_POLICY_SECTION_NAME \".tPolicy\"")]
        public static ReadOnlySpan<byte> IMAGE_POLICY_SECTION_NAME => new byte[] { 0x2E, 0x74, 0x50, 0x6F, 0x6C, 0x69, 0x63, 0x79, 0x00 };

        [NativeTypeName("#define RTL_CRITICAL_SECTION_FLAG_NO_DEBUG_INFO 0x01000000")]
        public const int RTL_CRITICAL_SECTION_FLAG_NO_DEBUG_INFO = 0x01000000;

        [NativeTypeName("#define RTL_CRITICAL_SECTION_FLAG_DYNAMIC_SPIN 0x02000000")]
        public const int RTL_CRITICAL_SECTION_FLAG_DYNAMIC_SPIN = 0x02000000;

        [NativeTypeName("#define RTL_CRITICAL_SECTION_FLAG_STATIC_INIT 0x04000000")]
        public const int RTL_CRITICAL_SECTION_FLAG_STATIC_INIT = 0x04000000;

        [NativeTypeName("#define RTL_CRITICAL_SECTION_FLAG_RESOURCE_TYPE 0x08000000")]
        public const int RTL_CRITICAL_SECTION_FLAG_RESOURCE_TYPE = 0x08000000;

        [NativeTypeName("#define RTL_CRITICAL_SECTION_FLAG_FORCE_DEBUG_INFO 0x10000000")]
        public const int RTL_CRITICAL_SECTION_FLAG_FORCE_DEBUG_INFO = 0x10000000;

        [NativeTypeName("#define RTL_CRITICAL_SECTION_ALL_FLAG_BITS 0xFF000000")]
        public const uint RTL_CRITICAL_SECTION_ALL_FLAG_BITS = 0xFF000000;

        [NativeTypeName("#define RTL_CRITICAL_SECTION_FLAG_RESERVED (RTL_CRITICAL_SECTION_ALL_FLAG_BITS & (~(RTL_CRITICAL_SECTION_FLAG_NO_DEBUG_INFO | RTL_CRITICAL_SECTION_FLAG_DYNAMIC_SPIN | RTL_CRITICAL_SECTION_FLAG_STATIC_INIT | RTL_CRITICAL_SECTION_FLAG_RESOURCE_TYPE | RTL_CRITICAL_SECTION_FLAG_FORCE_DEBUG_INFO)))")]
        public const uint RTL_CRITICAL_SECTION_FLAG_RESERVED = (0xFF000000 & (~(0x01000000u | 0x02000000 | 0x04000000 | 0x08000000 | 0x10000000)));

        [NativeTypeName("#define RTL_CRITICAL_SECTION_DEBUG_FLAG_STATIC_INIT 0x00000001")]
        public const int RTL_CRITICAL_SECTION_DEBUG_FLAG_STATIC_INIT = 0x00000001;

        [NativeTypeName("#define RTL_CONDITION_VARIABLE_LOCKMODE_SHARED 0x1")]
        public const int RTL_CONDITION_VARIABLE_LOCKMODE_SHARED = 0x1;

        [NativeTypeName("#define HEAP_OPTIMIZE_RESOURCES_CURRENT_VERSION 1")]
        public const int HEAP_OPTIMIZE_RESOURCES_CURRENT_VERSION = 1;

        [NativeTypeName("#define WT_EXECUTEDEFAULT 0x00000000")]
        public const int WT_EXECUTEDEFAULT = 0x00000000;

        [NativeTypeName("#define WT_EXECUTEINIOTHREAD 0x00000001")]
        public const int WT_EXECUTEINIOTHREAD = 0x00000001;

        [NativeTypeName("#define WT_EXECUTEINUITHREAD 0x00000002")]
        public const int WT_EXECUTEINUITHREAD = 0x00000002;

        [NativeTypeName("#define WT_EXECUTEINWAITTHREAD 0x00000004")]
        public const int WT_EXECUTEINWAITTHREAD = 0x00000004;

        [NativeTypeName("#define WT_EXECUTEONLYONCE 0x00000008")]
        public const int WT_EXECUTEONLYONCE = 0x00000008;

        [NativeTypeName("#define WT_EXECUTEINTIMERTHREAD 0x00000020")]
        public const int WT_EXECUTEINTIMERTHREAD = 0x00000020;

        [NativeTypeName("#define WT_EXECUTELONGFUNCTION 0x00000010")]
        public const int WT_EXECUTELONGFUNCTION = 0x00000010;

        [NativeTypeName("#define WT_EXECUTEINPERSISTENTIOTHREAD 0x00000040")]
        public const int WT_EXECUTEINPERSISTENTIOTHREAD = 0x00000040;

        [NativeTypeName("#define WT_EXECUTEINPERSISTENTTHREAD 0x00000080")]
        public const int WT_EXECUTEINPERSISTENTTHREAD = 0x00000080;

        [NativeTypeName("#define WT_TRANSFER_IMPERSONATION 0x00000100")]
        public const int WT_TRANSFER_IMPERSONATION = 0x00000100;

        [NativeTypeName("#define WT_EXECUTEINLONGTHREAD 0x00000010")]
        public const int WT_EXECUTEINLONGTHREAD = 0x00000010;

        [NativeTypeName("#define WT_EXECUTEDELETEWAIT 0x00000008")]
        public const int WT_EXECUTEDELETEWAIT = 0x00000008;

        [NativeTypeName("#define ACTIVATION_CONTEXT_PATH_TYPE_NONE (1)")]
        public const int ACTIVATION_CONTEXT_PATH_TYPE_NONE = (1);

        [NativeTypeName("#define ACTIVATION_CONTEXT_PATH_TYPE_WIN32_FILE (2)")]
        public const int ACTIVATION_CONTEXT_PATH_TYPE_WIN32_FILE = (2);

        [NativeTypeName("#define ACTIVATION_CONTEXT_PATH_TYPE_URL (3)")]
        public const int ACTIVATION_CONTEXT_PATH_TYPE_URL = (3);

        [NativeTypeName("#define ACTIVATION_CONTEXT_PATH_TYPE_ASSEMBLYREF (4)")]
        public const int ACTIVATION_CONTEXT_PATH_TYPE_ASSEMBLYREF = (4);

        [NativeTypeName("#define CREATE_BOUNDARY_DESCRIPTOR_ADD_APPCONTAINER_SID 0x1")]
        public const int CREATE_BOUNDARY_DESCRIPTOR_ADD_APPCONTAINER_SID = 0x1;

        [NativeTypeName("#define PERFORMANCE_DATA_VERSION 1")]
        public const int PERFORMANCE_DATA_VERSION = 1;

        [NativeTypeName("#define READ_THREAD_PROFILING_FLAG_DISPATCHING 0x00000001")]
        public const int READ_THREAD_PROFILING_FLAG_DISPATCHING = 0x00000001;

        [NativeTypeName("#define READ_THREAD_PROFILING_FLAG_HARDWARE_COUNTERS 0x00000002")]
        public const int READ_THREAD_PROFILING_FLAG_HARDWARE_COUNTERS = 0x00000002;

        [NativeTypeName("#define UNIFIEDBUILDREVISION_KEY L\"\\\\Registry\\\\Machine\\\\Software\\\\Microsoft\\\\Windows NT\\\\CurrentVersion\"")]
        public const string UNIFIEDBUILDREVISION_KEY = "\\Registry\\Machine\\Software\\Microsoft\\Windows NT\\CurrentVersion";

        [NativeTypeName("#define UNIFIEDBUILDREVISION_VALUE L\"UBR\"")]
        public const string UNIFIEDBUILDREVISION_VALUE = "UBR";

        [NativeTypeName("#define UNIFIEDBUILDREVISION_MIN 0x00000000")]
        public const int UNIFIEDBUILDREVISION_MIN = 0x00000000;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_KEY L\"\\\\Registry\\\\Machine\\\\Software\\\\Microsoft\\\\Windows NT\\\\CurrentVersion\\\\OEM\"")]
        public const string DEVICEFAMILYDEVICEFORM_KEY = "\\Registry\\Machine\\Software\\Microsoft\\Windows NT\\CurrentVersion\\OEM";

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_VALUE L\"DeviceForm\"")]
        public const string DEVICEFAMILYDEVICEFORM_VALUE = "DeviceForm";

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_UAP 0x00000000")]
        public const int DEVICEFAMILYINFOENUM_UAP = 0x00000000;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_WINDOWS_8X 0x00000001")]
        public const int DEVICEFAMILYINFOENUM_WINDOWS_8X = 0x00000001;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_WINDOWS_PHONE_8X 0x00000002")]
        public const int DEVICEFAMILYINFOENUM_WINDOWS_PHONE_8X = 0x00000002;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_DESKTOP 0x00000003")]
        public const int DEVICEFAMILYINFOENUM_DESKTOP = 0x00000003;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_MOBILE 0x00000004")]
        public const int DEVICEFAMILYINFOENUM_MOBILE = 0x00000004;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_XBOX 0x00000005")]
        public const int DEVICEFAMILYINFOENUM_XBOX = 0x00000005;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_TEAM 0x00000006")]
        public const int DEVICEFAMILYINFOENUM_TEAM = 0x00000006;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_IOT 0x00000007")]
        public const int DEVICEFAMILYINFOENUM_IOT = 0x00000007;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_IOT_HEADLESS 0x00000008")]
        public const int DEVICEFAMILYINFOENUM_IOT_HEADLESS = 0x00000008;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_SERVER 0x00000009")]
        public const int DEVICEFAMILYINFOENUM_SERVER = 0x00000009;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_HOLOGRAPHIC 0x0000000A")]
        public const int DEVICEFAMILYINFOENUM_HOLOGRAPHIC = 0x0000000A;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_XBOXSRA 0x0000000B")]
        public const int DEVICEFAMILYINFOENUM_XBOXSRA = 0x0000000B;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_XBOXERA 0x0000000C")]
        public const int DEVICEFAMILYINFOENUM_XBOXERA = 0x0000000C;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_SERVER_NANO 0x0000000D")]
        public const int DEVICEFAMILYINFOENUM_SERVER_NANO = 0x0000000D;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_8828080 0x0000000E")]
        public const int DEVICEFAMILYINFOENUM_8828080 = 0x0000000E;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_7067329 0x0000000F")]
        public const int DEVICEFAMILYINFOENUM_7067329 = 0x0000000F;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_WINDOWS_CORE 0x00000010")]
        public const int DEVICEFAMILYINFOENUM_WINDOWS_CORE = 0x00000010;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_WINDOWS_CORE_HEADLESS 0x00000011")]
        public const int DEVICEFAMILYINFOENUM_WINDOWS_CORE_HEADLESS = 0x00000011;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_MAX 0x00000011")]
        public const int DEVICEFAMILYINFOENUM_MAX = 0x00000011;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_UNKNOWN 0x00000000")]
        public const int DEVICEFAMILYDEVICEFORM_UNKNOWN = 0x00000000;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_PHONE 0x00000001")]
        public const int DEVICEFAMILYDEVICEFORM_PHONE = 0x00000001;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_TABLET 0x00000002")]
        public const int DEVICEFAMILYDEVICEFORM_TABLET = 0x00000002;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_DESKTOP 0x00000003")]
        public const int DEVICEFAMILYDEVICEFORM_DESKTOP = 0x00000003;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_NOTEBOOK 0x00000004")]
        public const int DEVICEFAMILYDEVICEFORM_NOTEBOOK = 0x00000004;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_CONVERTIBLE 0x00000005")]
        public const int DEVICEFAMILYDEVICEFORM_CONVERTIBLE = 0x00000005;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_DETACHABLE 0x00000006")]
        public const int DEVICEFAMILYDEVICEFORM_DETACHABLE = 0x00000006;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_ALLINONE 0x00000007")]
        public const int DEVICEFAMILYDEVICEFORM_ALLINONE = 0x00000007;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_STICKPC 0x00000008")]
        public const int DEVICEFAMILYDEVICEFORM_STICKPC = 0x00000008;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_PUCK 0x00000009")]
        public const int DEVICEFAMILYDEVICEFORM_PUCK = 0x00000009;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_LARGESCREEN 0x0000000A")]
        public const int DEVICEFAMILYDEVICEFORM_LARGESCREEN = 0x0000000A;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_HMD 0x0000000B")]
        public const int DEVICEFAMILYDEVICEFORM_HMD = 0x0000000B;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_INDUSTRY_HANDHELD 0x0000000C")]
        public const int DEVICEFAMILYDEVICEFORM_INDUSTRY_HANDHELD = 0x0000000C;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_INDUSTRY_TABLET 0x0000000D")]
        public const int DEVICEFAMILYDEVICEFORM_INDUSTRY_TABLET = 0x0000000D;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_BANKING 0x0000000E")]
        public const int DEVICEFAMILYDEVICEFORM_BANKING = 0x0000000E;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_BUILDING_AUTOMATION 0x0000000F")]
        public const int DEVICEFAMILYDEVICEFORM_BUILDING_AUTOMATION = 0x0000000F;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_DIGITAL_SIGNAGE 0x00000010")]
        public const int DEVICEFAMILYDEVICEFORM_DIGITAL_SIGNAGE = 0x00000010;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_GAMING 0x00000011")]
        public const int DEVICEFAMILYDEVICEFORM_GAMING = 0x00000011;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_HOME_AUTOMATION 0x00000012")]
        public const int DEVICEFAMILYDEVICEFORM_HOME_AUTOMATION = 0x00000012;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_INDUSTRIAL_AUTOMATION 0x00000013")]
        public const int DEVICEFAMILYDEVICEFORM_INDUSTRIAL_AUTOMATION = 0x00000013;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_KIOSK 0x00000014")]
        public const int DEVICEFAMILYDEVICEFORM_KIOSK = 0x00000014;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_MAKER_BOARD 0x00000015")]
        public const int DEVICEFAMILYDEVICEFORM_MAKER_BOARD = 0x00000015;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_MEDICAL 0x00000016")]
        public const int DEVICEFAMILYDEVICEFORM_MEDICAL = 0x00000016;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_NETWORKING 0x00000017")]
        public const int DEVICEFAMILYDEVICEFORM_NETWORKING = 0x00000017;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_POINT_OF_SERVICE 0x00000018")]
        public const int DEVICEFAMILYDEVICEFORM_POINT_OF_SERVICE = 0x00000018;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_PRINTING 0x00000019")]
        public const int DEVICEFAMILYDEVICEFORM_PRINTING = 0x00000019;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_THIN_CLIENT 0x0000001A")]
        public const int DEVICEFAMILYDEVICEFORM_THIN_CLIENT = 0x0000001A;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_TOY 0x0000001B")]
        public const int DEVICEFAMILYDEVICEFORM_TOY = 0x0000001B;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_VENDING 0x0000001C")]
        public const int DEVICEFAMILYDEVICEFORM_VENDING = 0x0000001C;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_INDUSTRY_OTHER 0x0000001D")]
        public const int DEVICEFAMILYDEVICEFORM_INDUSTRY_OTHER = 0x0000001D;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_ONE 0x0000001E")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_ONE = 0x0000001E;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_ONE_S 0x0000001F")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_ONE_S = 0x0000001F;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_ONE_X 0x00000020")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_ONE_X = 0x00000020;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_ONE_X_DEVKIT 0x00000021")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_ONE_X_DEVKIT = 0x00000021;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_MAX 0x00000021")]
        public const int DEVICEFAMILYDEVICEFORM_MAX = 0x00000021;

        [NativeTypeName("#define DLL_PROCESS_ATTACH 1")]
        public const int DLL_PROCESS_ATTACH = 1;

        [NativeTypeName("#define DLL_THREAD_ATTACH 2")]
        public const int DLL_THREAD_ATTACH = 2;

        [NativeTypeName("#define DLL_THREAD_DETACH 3")]
        public const int DLL_THREAD_DETACH = 3;

        [NativeTypeName("#define DLL_PROCESS_DETACH 0")]
        public const int DLL_PROCESS_DETACH = 0;

        [NativeTypeName("#define EVENTLOG_SEQUENTIAL_READ 0x0001")]
        public const int EVENTLOG_SEQUENTIAL_READ = 0x0001;

        [NativeTypeName("#define EVENTLOG_SEEK_READ 0x0002")]
        public const int EVENTLOG_SEEK_READ = 0x0002;

        [NativeTypeName("#define EVENTLOG_FORWARDS_READ 0x0004")]
        public const int EVENTLOG_FORWARDS_READ = 0x0004;

        [NativeTypeName("#define EVENTLOG_BACKWARDS_READ 0x0008")]
        public const int EVENTLOG_BACKWARDS_READ = 0x0008;

        [NativeTypeName("#define EVENTLOG_SUCCESS 0x0000")]
        public const int EVENTLOG_SUCCESS = 0x0000;

        [NativeTypeName("#define EVENTLOG_ERROR_TYPE 0x0001")]
        public const int EVENTLOG_ERROR_TYPE = 0x0001;

        [NativeTypeName("#define EVENTLOG_WARNING_TYPE 0x0002")]
        public const int EVENTLOG_WARNING_TYPE = 0x0002;

        [NativeTypeName("#define EVENTLOG_INFORMATION_TYPE 0x0004")]
        public const int EVENTLOG_INFORMATION_TYPE = 0x0004;

        [NativeTypeName("#define EVENTLOG_AUDIT_SUCCESS 0x0008")]
        public const int EVENTLOG_AUDIT_SUCCESS = 0x0008;

        [NativeTypeName("#define EVENTLOG_AUDIT_FAILURE 0x0010")]
        public const int EVENTLOG_AUDIT_FAILURE = 0x0010;

        [NativeTypeName("#define EVENTLOG_START_PAIRED_EVENT 0x0001")]
        public const int EVENTLOG_START_PAIRED_EVENT = 0x0001;

        [NativeTypeName("#define EVENTLOG_END_PAIRED_EVENT 0x0002")]
        public const int EVENTLOG_END_PAIRED_EVENT = 0x0002;

        [NativeTypeName("#define EVENTLOG_END_ALL_PAIRED_EVENTS 0x0004")]
        public const int EVENTLOG_END_ALL_PAIRED_EVENTS = 0x0004;

        [NativeTypeName("#define EVENTLOG_PAIRED_EVENT_ACTIVE 0x0008")]
        public const int EVENTLOG_PAIRED_EVENT_ACTIVE = 0x0008;

        [NativeTypeName("#define EVENTLOG_PAIRED_EVENT_INACTIVE 0x0010")]
        public const int EVENTLOG_PAIRED_EVENT_INACTIVE = 0x0010;

        [NativeTypeName("#define MAXLOGICALLOGNAMESIZE 256")]
        public const int MAXLOGICALLOGNAMESIZE = 256;

        [NativeTypeName("#define KEY_QUERY_VALUE (0x0001)")]
        public const int KEY_QUERY_VALUE = (0x0001);

        [NativeTypeName("#define KEY_SET_VALUE (0x0002)")]
        public const int KEY_SET_VALUE = (0x0002);

        [NativeTypeName("#define KEY_CREATE_SUB_KEY (0x0004)")]
        public const int KEY_CREATE_SUB_KEY = (0x0004);

        [NativeTypeName("#define KEY_ENUMERATE_SUB_KEYS (0x0008)")]
        public const int KEY_ENUMERATE_SUB_KEYS = (0x0008);

        [NativeTypeName("#define KEY_NOTIFY (0x0010)")]
        public const int KEY_NOTIFY = (0x0010);

        [NativeTypeName("#define KEY_CREATE_LINK (0x0020)")]
        public const int KEY_CREATE_LINK = (0x0020);

        [NativeTypeName("#define KEY_WOW64_32KEY (0x0200)")]
        public const int KEY_WOW64_32KEY = (0x0200);

        [NativeTypeName("#define KEY_WOW64_64KEY (0x0100)")]
        public const int KEY_WOW64_64KEY = (0x0100);

        [NativeTypeName("#define KEY_WOW64_RES (0x0300)")]
        public const int KEY_WOW64_RES = (0x0300);

        [NativeTypeName("#define KEY_READ ((STANDARD_RIGHTS_READ       |\\\r\n                                  KEY_QUERY_VALUE            |\\\r\n                                  KEY_ENUMERATE_SUB_KEYS     |\\\r\n                                  KEY_NOTIFY)                 \\\r\n                                  &                           \\\r\n                                 (~SYNCHRONIZE))")]
        public const int KEY_READ = ((((0x00020000)) | (0x0001) | (0x0008) | (0x0010)) & (~(0x00100000)));

        [NativeTypeName("#define KEY_WRITE ((STANDARD_RIGHTS_WRITE      |\\\r\n                                  KEY_SET_VALUE              |\\\r\n                                  KEY_CREATE_SUB_KEY)         \\\r\n                                  &                           \\\r\n                                 (~SYNCHRONIZE))")]
        public const int KEY_WRITE = ((((0x00020000)) | (0x0002) | (0x0004)) & (~(0x00100000)));

        [NativeTypeName("#define KEY_EXECUTE ((KEY_READ)                   \\\r\n                                  &                           \\\r\n                                 (~SYNCHRONIZE))")]
        public const int KEY_EXECUTE = ((((((0x00020000)) | (0x0001) | (0x0008) | (0x0010)) & (~(0x00100000)))) & (~(0x00100000)));

        [NativeTypeName("#define KEY_ALL_ACCESS ((STANDARD_RIGHTS_ALL        |\\\r\n                                  KEY_QUERY_VALUE            |\\\r\n                                  KEY_SET_VALUE              |\\\r\n                                  KEY_CREATE_SUB_KEY         |\\\r\n                                  KEY_ENUMERATE_SUB_KEYS     |\\\r\n                                  KEY_NOTIFY                 |\\\r\n                                  KEY_CREATE_LINK)            \\\r\n                                  &                           \\\r\n                                 (~SYNCHRONIZE))")]
        public const int KEY_ALL_ACCESS = (((0x001F0000) | (0x0001) | (0x0002) | (0x0004) | (0x0008) | (0x0010) | (0x0020)) & (~(0x00100000)));

        [NativeTypeName("#define REG_OPTION_RESERVED (0x00000000L)")]
        public const int REG_OPTION_RESERVED = (0x00000000);

        [NativeTypeName("#define REG_OPTION_NON_VOLATILE (0x00000000L)")]
        public const int REG_OPTION_NON_VOLATILE = (0x00000000);

        [NativeTypeName("#define REG_OPTION_VOLATILE (0x00000001L)")]
        public const int REG_OPTION_VOLATILE = (0x00000001);

        [NativeTypeName("#define REG_OPTION_CREATE_LINK (0x00000002L)")]
        public const int REG_OPTION_CREATE_LINK = (0x00000002);

        [NativeTypeName("#define REG_OPTION_BACKUP_RESTORE (0x00000004L)")]
        public const int REG_OPTION_BACKUP_RESTORE = (0x00000004);

        [NativeTypeName("#define REG_OPTION_OPEN_LINK (0x00000008L)")]
        public const int REG_OPTION_OPEN_LINK = (0x00000008);

        [NativeTypeName("#define REG_OPTION_DONT_VIRTUALIZE (0x00000010L)")]
        public const int REG_OPTION_DONT_VIRTUALIZE = (0x00000010);

        [NativeTypeName("#define REG_LEGAL_OPTION (REG_OPTION_RESERVED            |\\\r\n                 REG_OPTION_NON_VOLATILE        |\\\r\n                 REG_OPTION_VOLATILE            |\\\r\n                 REG_OPTION_CREATE_LINK         |\\\r\n                 REG_OPTION_BACKUP_RESTORE      |\\\r\n                 REG_OPTION_OPEN_LINK           |\\\r\n                 REG_OPTION_DONT_VIRTUALIZE)")]
        public const int REG_LEGAL_OPTION = ((0x00000000) | (0x00000000) | (0x00000001) | (0x00000002) | (0x00000004) | (0x00000008) | (0x00000010));

        [NativeTypeName("#define REG_OPEN_LEGAL_OPTION (REG_OPTION_RESERVED            |\\\r\n                 REG_OPTION_BACKUP_RESTORE      |\\\r\n                 REG_OPTION_OPEN_LINK           |\\\r\n                 REG_OPTION_DONT_VIRTUALIZE)")]
        public const int REG_OPEN_LEGAL_OPTION = ((0x00000000) | (0x00000004) | (0x00000008) | (0x00000010));

        [NativeTypeName("#define REG_CREATED_NEW_KEY (0x00000001L)")]
        public const int REG_CREATED_NEW_KEY = (0x00000001);

        [NativeTypeName("#define REG_OPENED_EXISTING_KEY (0x00000002L)")]
        public const int REG_OPENED_EXISTING_KEY = (0x00000002);

        [NativeTypeName("#define REG_STANDARD_FORMAT 1")]
        public const int REG_STANDARD_FORMAT = 1;

        [NativeTypeName("#define REG_LATEST_FORMAT 2")]
        public const int REG_LATEST_FORMAT = 2;

        [NativeTypeName("#define REG_NO_COMPRESSION 4")]
        public const int REG_NO_COMPRESSION = 4;

        [NativeTypeName("#define REG_WHOLE_HIVE_VOLATILE (0x00000001L)")]
        public const int REG_WHOLE_HIVE_VOLATILE = (0x00000001);

        [NativeTypeName("#define REG_REFRESH_HIVE (0x00000002L)")]
        public const int REG_REFRESH_HIVE = (0x00000002);

        [NativeTypeName("#define REG_NO_LAZY_FLUSH (0x00000004L)")]
        public const int REG_NO_LAZY_FLUSH = (0x00000004);

        [NativeTypeName("#define REG_FORCE_RESTORE (0x00000008L)")]
        public const int REG_FORCE_RESTORE = (0x00000008);

        [NativeTypeName("#define REG_APP_HIVE (0x00000010L)")]
        public const int REG_APP_HIVE = (0x00000010);

        [NativeTypeName("#define REG_PROCESS_PRIVATE (0x00000020L)")]
        public const int REG_PROCESS_PRIVATE = (0x00000020);

        [NativeTypeName("#define REG_START_JOURNAL (0x00000040L)")]
        public const int REG_START_JOURNAL = (0x00000040);

        [NativeTypeName("#define REG_HIVE_EXACT_FILE_GROWTH (0x00000080L)")]
        public const int REG_HIVE_EXACT_FILE_GROWTH = (0x00000080);

        [NativeTypeName("#define REG_HIVE_NO_RM (0x00000100L)")]
        public const int REG_HIVE_NO_RM = (0x00000100);

        [NativeTypeName("#define REG_HIVE_SINGLE_LOG (0x00000200L)")]
        public const int REG_HIVE_SINGLE_LOG = (0x00000200);

        [NativeTypeName("#define REG_BOOT_HIVE (0x00000400L)")]
        public const int REG_BOOT_HIVE = (0x00000400);

        [NativeTypeName("#define REG_LOAD_HIVE_OPEN_HANDLE (0x00000800L)")]
        public const int REG_LOAD_HIVE_OPEN_HANDLE = (0x00000800);

        [NativeTypeName("#define REG_FLUSH_HIVE_FILE_GROWTH (0x00001000L)")]
        public const int REG_FLUSH_HIVE_FILE_GROWTH = (0x00001000);

        [NativeTypeName("#define REG_OPEN_READ_ONLY (0x00002000L)")]
        public const int REG_OPEN_READ_ONLY = (0x00002000);

        [NativeTypeName("#define REG_IMMUTABLE (0x00004000L)")]
        public const int REG_IMMUTABLE = (0x00004000);

        [NativeTypeName("#define REG_NO_IMPERSONATION_FALLBACK (0x00008000L)")]
        public const int REG_NO_IMPERSONATION_FALLBACK = (0x00008000);

        [NativeTypeName("#define REG_APP_HIVE_OPEN_READ_ONLY (REG_OPEN_READ_ONLY)")]
        public const int REG_APP_HIVE_OPEN_READ_ONLY = ((0x00002000));

        [NativeTypeName("#define REG_FORCE_UNLOAD 1")]
        public const int REG_FORCE_UNLOAD = 1;

        [NativeTypeName("#define REG_UNLOAD_LEGAL_FLAGS (REG_FORCE_UNLOAD)")]
        public const int REG_UNLOAD_LEGAL_FLAGS = (1);

        [NativeTypeName("#define REG_NOTIFY_CHANGE_NAME (0x00000001L)")]
        public const int REG_NOTIFY_CHANGE_NAME = (0x00000001);

        [NativeTypeName("#define REG_NOTIFY_CHANGE_ATTRIBUTES (0x00000002L)")]
        public const int REG_NOTIFY_CHANGE_ATTRIBUTES = (0x00000002);

        [NativeTypeName("#define REG_NOTIFY_CHANGE_LAST_SET (0x00000004L)")]
        public const int REG_NOTIFY_CHANGE_LAST_SET = (0x00000004);

        [NativeTypeName("#define REG_NOTIFY_CHANGE_SECURITY (0x00000008L)")]
        public const int REG_NOTIFY_CHANGE_SECURITY = (0x00000008);

        [NativeTypeName("#define REG_NOTIFY_THREAD_AGNOSTIC (0x10000000L)")]
        public const int REG_NOTIFY_THREAD_AGNOSTIC = (0x10000000);

        [NativeTypeName("#define REG_LEGAL_CHANGE_FILTER (REG_NOTIFY_CHANGE_NAME          |\\\r\n                 REG_NOTIFY_CHANGE_ATTRIBUTES    |\\\r\n                 REG_NOTIFY_CHANGE_LAST_SET      |\\\r\n                 REG_NOTIFY_CHANGE_SECURITY      |\\\r\n                 REG_NOTIFY_THREAD_AGNOSTIC)")]
        public const int REG_LEGAL_CHANGE_FILTER = ((0x00000001) | (0x00000002) | (0x00000004) | (0x00000008) | (0x10000000));

        [NativeTypeName("#define REG_NONE ( 0ul )")]
        public const uint REG_NONE = (0U);

        [NativeTypeName("#define REG_SZ ( 1ul )")]
        public const uint REG_SZ = (1U);

        [NativeTypeName("#define REG_EXPAND_SZ ( 2ul )")]
        public const uint REG_EXPAND_SZ = (2U);

        [NativeTypeName("#define REG_BINARY ( 3ul )")]
        public const uint REG_BINARY = (3U);

        [NativeTypeName("#define REG_DWORD ( 4ul )")]
        public const uint REG_DWORD = (4U);

        [NativeTypeName("#define REG_DWORD_LITTLE_ENDIAN ( 4ul )")]
        public const uint REG_DWORD_LITTLE_ENDIAN = (4U);

        [NativeTypeName("#define REG_DWORD_BIG_ENDIAN ( 5ul )")]
        public const uint REG_DWORD_BIG_ENDIAN = (5U);

        [NativeTypeName("#define REG_LINK ( 6ul )")]
        public const uint REG_LINK = (6U);

        [NativeTypeName("#define REG_MULTI_SZ ( 7ul )")]
        public const uint REG_MULTI_SZ = (7U);

        [NativeTypeName("#define REG_RESOURCE_LIST ( 8ul )")]
        public const uint REG_RESOURCE_LIST = (8U);

        [NativeTypeName("#define REG_FULL_RESOURCE_DESCRIPTOR ( 9ul )")]
        public const uint REG_FULL_RESOURCE_DESCRIPTOR = (9U);

        [NativeTypeName("#define REG_RESOURCE_REQUIREMENTS_LIST ( 10ul )")]
        public const uint REG_RESOURCE_REQUIREMENTS_LIST = (10U);

        [NativeTypeName("#define REG_QWORD ( 11ul )")]
        public const uint REG_QWORD = (11U);

        [NativeTypeName("#define REG_QWORD_LITTLE_ENDIAN ( 11ul )")]
        public const uint REG_QWORD_LITTLE_ENDIAN = (11U);

        [NativeTypeName("#define SERVICE_KERNEL_DRIVER 0x00000001")]
        public const int SERVICE_KERNEL_DRIVER = 0x00000001;

        [NativeTypeName("#define SERVICE_FILE_SYSTEM_DRIVER 0x00000002")]
        public const int SERVICE_FILE_SYSTEM_DRIVER = 0x00000002;

        [NativeTypeName("#define SERVICE_ADAPTER 0x00000004")]
        public const int SERVICE_ADAPTER = 0x00000004;

        [NativeTypeName("#define SERVICE_RECOGNIZER_DRIVER 0x00000008")]
        public const int SERVICE_RECOGNIZER_DRIVER = 0x00000008;

        [NativeTypeName("#define SERVICE_DRIVER (SERVICE_KERNEL_DRIVER | \\\r\n                                        SERVICE_FILE_SYSTEM_DRIVER | \\\r\n                                        SERVICE_RECOGNIZER_DRIVER)")]
        public const int SERVICE_DRIVER = (0x00000001 | 0x00000002 | 0x00000008);

        [NativeTypeName("#define SERVICE_WIN32_OWN_PROCESS 0x00000010")]
        public const int SERVICE_WIN32_OWN_PROCESS = 0x00000010;

        [NativeTypeName("#define SERVICE_WIN32_SHARE_PROCESS 0x00000020")]
        public const int SERVICE_WIN32_SHARE_PROCESS = 0x00000020;

        [NativeTypeName("#define SERVICE_WIN32 (SERVICE_WIN32_OWN_PROCESS | \\\r\n                                        SERVICE_WIN32_SHARE_PROCESS)")]
        public const int SERVICE_WIN32 = (0x00000010 | 0x00000020);

        [NativeTypeName("#define SERVICE_USER_SERVICE 0x00000040")]
        public const int SERVICE_USER_SERVICE = 0x00000040;

        [NativeTypeName("#define SERVICE_USERSERVICE_INSTANCE 0x00000080")]
        public const int SERVICE_USERSERVICE_INSTANCE = 0x00000080;

        [NativeTypeName("#define SERVICE_USER_SHARE_PROCESS (SERVICE_USER_SERVICE | \\\r\n                                        SERVICE_WIN32_SHARE_PROCESS)")]
        public const int SERVICE_USER_SHARE_PROCESS = (0x00000040 | 0x00000020);

        [NativeTypeName("#define SERVICE_USER_OWN_PROCESS (SERVICE_USER_SERVICE | \\\r\n                                        SERVICE_WIN32_OWN_PROCESS)")]
        public const int SERVICE_USER_OWN_PROCESS = (0x00000040 | 0x00000010);

        [NativeTypeName("#define SERVICE_INTERACTIVE_PROCESS 0x00000100")]
        public const int SERVICE_INTERACTIVE_PROCESS = 0x00000100;

        [NativeTypeName("#define SERVICE_PKG_SERVICE 0x00000200")]
        public const int SERVICE_PKG_SERVICE = 0x00000200;

        [NativeTypeName("#define SERVICE_TYPE_ALL (SERVICE_WIN32  | \\\r\n                                        SERVICE_ADAPTER | \\\r\n                                        SERVICE_DRIVER  | \\\r\n                                        SERVICE_INTERACTIVE_PROCESS | \\\r\n                                        SERVICE_USER_SERVICE | \\\r\n                                        SERVICE_USERSERVICE_INSTANCE | \\\r\n                                        SERVICE_PKG_SERVICE)")]
        public const int SERVICE_TYPE_ALL = ((0x00000010 | 0x00000020) | 0x00000004 | (0x00000001 | 0x00000002 | 0x00000008) | 0x00000100 | 0x00000040 | 0x00000080 | 0x00000200);

        [NativeTypeName("#define SERVICE_BOOT_START 0x00000000")]
        public const int SERVICE_BOOT_START = 0x00000000;

        [NativeTypeName("#define SERVICE_SYSTEM_START 0x00000001")]
        public const int SERVICE_SYSTEM_START = 0x00000001;

        [NativeTypeName("#define SERVICE_AUTO_START 0x00000002")]
        public const int SERVICE_AUTO_START = 0x00000002;

        [NativeTypeName("#define SERVICE_DEMAND_START 0x00000003")]
        public const int SERVICE_DEMAND_START = 0x00000003;

        [NativeTypeName("#define SERVICE_DISABLED 0x00000004")]
        public const int SERVICE_DISABLED = 0x00000004;

        [NativeTypeName("#define SERVICE_ERROR_IGNORE 0x00000000")]
        public const int SERVICE_ERROR_IGNORE = 0x00000000;

        [NativeTypeName("#define SERVICE_ERROR_NORMAL 0x00000001")]
        public const int SERVICE_ERROR_NORMAL = 0x00000001;

        [NativeTypeName("#define SERVICE_ERROR_SEVERE 0x00000002")]
        public const int SERVICE_ERROR_SEVERE = 0x00000002;

        [NativeTypeName("#define SERVICE_ERROR_CRITICAL 0x00000003")]
        public const int SERVICE_ERROR_CRITICAL = 0x00000003;

        [NativeTypeName("#define CM_SERVICE_NETWORK_BOOT_LOAD 0x00000001")]
        public const int CM_SERVICE_NETWORK_BOOT_LOAD = 0x00000001;

        [NativeTypeName("#define CM_SERVICE_VIRTUAL_DISK_BOOT_LOAD 0x00000002")]
        public const int CM_SERVICE_VIRTUAL_DISK_BOOT_LOAD = 0x00000002;

        [NativeTypeName("#define CM_SERVICE_USB_DISK_BOOT_LOAD 0x00000004")]
        public const int CM_SERVICE_USB_DISK_BOOT_LOAD = 0x00000004;

        [NativeTypeName("#define CM_SERVICE_SD_DISK_BOOT_LOAD 0x00000008")]
        public const int CM_SERVICE_SD_DISK_BOOT_LOAD = 0x00000008;

        [NativeTypeName("#define CM_SERVICE_USB3_DISK_BOOT_LOAD 0x00000010")]
        public const int CM_SERVICE_USB3_DISK_BOOT_LOAD = 0x00000010;

        [NativeTypeName("#define CM_SERVICE_MEASURED_BOOT_LOAD 0x00000020")]
        public const int CM_SERVICE_MEASURED_BOOT_LOAD = 0x00000020;

        [NativeTypeName("#define CM_SERVICE_VERIFIER_BOOT_LOAD 0x00000040")]
        public const int CM_SERVICE_VERIFIER_BOOT_LOAD = 0x00000040;

        [NativeTypeName("#define CM_SERVICE_WINPE_BOOT_LOAD 0x00000080")]
        public const int CM_SERVICE_WINPE_BOOT_LOAD = 0x00000080;

        [NativeTypeName("#define CM_SERVICE_RAM_DISK_BOOT_LOAD 0x00000100")]
        public const int CM_SERVICE_RAM_DISK_BOOT_LOAD = 0x00000100;

        [NativeTypeName("#define CM_SERVICE_VALID_PROMOTION_MASK (CM_SERVICE_NETWORK_BOOT_LOAD |       \\\r\n                                         CM_SERVICE_VIRTUAL_DISK_BOOT_LOAD |  \\\r\n                                         CM_SERVICE_USB_DISK_BOOT_LOAD |      \\\r\n                                         CM_SERVICE_SD_DISK_BOOT_LOAD |       \\\r\n                                         CM_SERVICE_USB3_DISK_BOOT_LOAD |     \\\r\n                                         CM_SERVICE_MEASURED_BOOT_LOAD |      \\\r\n                                         CM_SERVICE_VERIFIER_BOOT_LOAD |      \\\r\n                                         CM_SERVICE_WINPE_BOOT_LOAD |         \\\r\n                                         CM_SERVICE_RAM_DISK_BOOT_LOAD)")]
        public const int CM_SERVICE_VALID_PROMOTION_MASK = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020 | 0x00000040 | 0x00000080 | 0x00000100);

        [NativeTypeName("#define TAPE_ERASE_SHORT 0L")]
        public const int TAPE_ERASE_SHORT = 0;

        [NativeTypeName("#define TAPE_ERASE_LONG 1L")]
        public const int TAPE_ERASE_LONG = 1;

        [NativeTypeName("#define TAPE_LOAD 0L")]
        public const int TAPE_LOAD = 0;

        [NativeTypeName("#define TAPE_UNLOAD 1L")]
        public const int TAPE_UNLOAD = 1;

        [NativeTypeName("#define TAPE_TENSION 2L")]
        public const int TAPE_TENSION = 2;

        [NativeTypeName("#define TAPE_LOCK 3L")]
        public const int TAPE_LOCK = 3;

        [NativeTypeName("#define TAPE_UNLOCK 4L")]
        public const int TAPE_UNLOCK = 4;

        [NativeTypeName("#define TAPE_FORMAT 5L")]
        public const int TAPE_FORMAT = 5;

        [NativeTypeName("#define TAPE_SETMARKS 0L")]
        public const int TAPE_SETMARKS = 0;

        [NativeTypeName("#define TAPE_FILEMARKS 1L")]
        public const int TAPE_FILEMARKS = 1;

        [NativeTypeName("#define TAPE_SHORT_FILEMARKS 2L")]
        public const int TAPE_SHORT_FILEMARKS = 2;

        [NativeTypeName("#define TAPE_LONG_FILEMARKS 3L")]
        public const int TAPE_LONG_FILEMARKS = 3;

        [NativeTypeName("#define TAPE_ABSOLUTE_POSITION 0L")]
        public const int TAPE_ABSOLUTE_POSITION = 0;

        [NativeTypeName("#define TAPE_LOGICAL_POSITION 1L")]
        public const int TAPE_LOGICAL_POSITION = 1;

        [NativeTypeName("#define TAPE_PSEUDO_LOGICAL_POSITION 2L")]
        public const int TAPE_PSEUDO_LOGICAL_POSITION = 2;

        [NativeTypeName("#define TAPE_REWIND 0L")]
        public const int TAPE_REWIND = 0;

        [NativeTypeName("#define TAPE_ABSOLUTE_BLOCK 1L")]
        public const int TAPE_ABSOLUTE_BLOCK = 1;

        [NativeTypeName("#define TAPE_LOGICAL_BLOCK 2L")]
        public const int TAPE_LOGICAL_BLOCK = 2;

        [NativeTypeName("#define TAPE_PSEUDO_LOGICAL_BLOCK 3L")]
        public const int TAPE_PSEUDO_LOGICAL_BLOCK = 3;

        [NativeTypeName("#define TAPE_SPACE_END_OF_DATA 4L")]
        public const int TAPE_SPACE_END_OF_DATA = 4;

        [NativeTypeName("#define TAPE_SPACE_RELATIVE_BLOCKS 5L")]
        public const int TAPE_SPACE_RELATIVE_BLOCKS = 5;

        [NativeTypeName("#define TAPE_SPACE_FILEMARKS 6L")]
        public const int TAPE_SPACE_FILEMARKS = 6;

        [NativeTypeName("#define TAPE_SPACE_SEQUENTIAL_FMKS 7L")]
        public const int TAPE_SPACE_SEQUENTIAL_FMKS = 7;

        [NativeTypeName("#define TAPE_SPACE_SETMARKS 8L")]
        public const int TAPE_SPACE_SETMARKS = 8;

        [NativeTypeName("#define TAPE_SPACE_SEQUENTIAL_SMKS 9L")]
        public const int TAPE_SPACE_SEQUENTIAL_SMKS = 9;

        [NativeTypeName("#define TAPE_DRIVE_FIXED 0x00000001")]
        public const int TAPE_DRIVE_FIXED = 0x00000001;

        [NativeTypeName("#define TAPE_DRIVE_SELECT 0x00000002")]
        public const int TAPE_DRIVE_SELECT = 0x00000002;

        [NativeTypeName("#define TAPE_DRIVE_INITIATOR 0x00000004")]
        public const int TAPE_DRIVE_INITIATOR = 0x00000004;

        [NativeTypeName("#define TAPE_DRIVE_ERASE_SHORT 0x00000010")]
        public const int TAPE_DRIVE_ERASE_SHORT = 0x00000010;

        [NativeTypeName("#define TAPE_DRIVE_ERASE_LONG 0x00000020")]
        public const int TAPE_DRIVE_ERASE_LONG = 0x00000020;

        [NativeTypeName("#define TAPE_DRIVE_ERASE_BOP_ONLY 0x00000040")]
        public const int TAPE_DRIVE_ERASE_BOP_ONLY = 0x00000040;

        [NativeTypeName("#define TAPE_DRIVE_ERASE_IMMEDIATE 0x00000080")]
        public const int TAPE_DRIVE_ERASE_IMMEDIATE = 0x00000080;

        [NativeTypeName("#define TAPE_DRIVE_TAPE_CAPACITY 0x00000100")]
        public const int TAPE_DRIVE_TAPE_CAPACITY = 0x00000100;

        [NativeTypeName("#define TAPE_DRIVE_TAPE_REMAINING 0x00000200")]
        public const int TAPE_DRIVE_TAPE_REMAINING = 0x00000200;

        [NativeTypeName("#define TAPE_DRIVE_FIXED_BLOCK 0x00000400")]
        public const int TAPE_DRIVE_FIXED_BLOCK = 0x00000400;

        [NativeTypeName("#define TAPE_DRIVE_VARIABLE_BLOCK 0x00000800")]
        public const int TAPE_DRIVE_VARIABLE_BLOCK = 0x00000800;

        [NativeTypeName("#define TAPE_DRIVE_WRITE_PROTECT 0x00001000")]
        public const int TAPE_DRIVE_WRITE_PROTECT = 0x00001000;

        [NativeTypeName("#define TAPE_DRIVE_EOT_WZ_SIZE 0x00002000")]
        public const int TAPE_DRIVE_EOT_WZ_SIZE = 0x00002000;

        [NativeTypeName("#define TAPE_DRIVE_ECC 0x00010000")]
        public const int TAPE_DRIVE_ECC = 0x00010000;

        [NativeTypeName("#define TAPE_DRIVE_COMPRESSION 0x00020000")]
        public const int TAPE_DRIVE_COMPRESSION = 0x00020000;

        [NativeTypeName("#define TAPE_DRIVE_PADDING 0x00040000")]
        public const int TAPE_DRIVE_PADDING = 0x00040000;

        [NativeTypeName("#define TAPE_DRIVE_REPORT_SMKS 0x00080000")]
        public const int TAPE_DRIVE_REPORT_SMKS = 0x00080000;

        [NativeTypeName("#define TAPE_DRIVE_GET_ABSOLUTE_BLK 0x00100000")]
        public const int TAPE_DRIVE_GET_ABSOLUTE_BLK = 0x00100000;

        [NativeTypeName("#define TAPE_DRIVE_GET_LOGICAL_BLK 0x00200000")]
        public const int TAPE_DRIVE_GET_LOGICAL_BLK = 0x00200000;

        [NativeTypeName("#define TAPE_DRIVE_SET_EOT_WZ_SIZE 0x00400000")]
        public const int TAPE_DRIVE_SET_EOT_WZ_SIZE = 0x00400000;

        [NativeTypeName("#define TAPE_DRIVE_EJECT_MEDIA 0x01000000")]
        public const int TAPE_DRIVE_EJECT_MEDIA = 0x01000000;

        [NativeTypeName("#define TAPE_DRIVE_CLEAN_REQUESTS 0x02000000")]
        public const int TAPE_DRIVE_CLEAN_REQUESTS = 0x02000000;

        [NativeTypeName("#define TAPE_DRIVE_SET_CMP_BOP_ONLY 0x04000000")]
        public const int TAPE_DRIVE_SET_CMP_BOP_ONLY = 0x04000000;

        [NativeTypeName("#define TAPE_DRIVE_RESERVED_BIT 0x80000000")]
        public const uint TAPE_DRIVE_RESERVED_BIT = 0x80000000;

        [NativeTypeName("#define TAPE_DRIVE_LOAD_UNLOAD 0x80000001")]
        public const uint TAPE_DRIVE_LOAD_UNLOAD = 0x80000001;

        [NativeTypeName("#define TAPE_DRIVE_TENSION 0x80000002")]
        public const uint TAPE_DRIVE_TENSION = 0x80000002;

        [NativeTypeName("#define TAPE_DRIVE_LOCK_UNLOCK 0x80000004")]
        public const uint TAPE_DRIVE_LOCK_UNLOCK = 0x80000004;

        [NativeTypeName("#define TAPE_DRIVE_REWIND_IMMEDIATE 0x80000008")]
        public const uint TAPE_DRIVE_REWIND_IMMEDIATE = 0x80000008;

        [NativeTypeName("#define TAPE_DRIVE_SET_BLOCK_SIZE 0x80000010")]
        public const uint TAPE_DRIVE_SET_BLOCK_SIZE = 0x80000010;

        [NativeTypeName("#define TAPE_DRIVE_LOAD_UNLD_IMMED 0x80000020")]
        public const uint TAPE_DRIVE_LOAD_UNLD_IMMED = 0x80000020;

        [NativeTypeName("#define TAPE_DRIVE_TENSION_IMMED 0x80000040")]
        public const uint TAPE_DRIVE_TENSION_IMMED = 0x80000040;

        [NativeTypeName("#define TAPE_DRIVE_LOCK_UNLK_IMMED 0x80000080")]
        public const uint TAPE_DRIVE_LOCK_UNLK_IMMED = 0x80000080;

        [NativeTypeName("#define TAPE_DRIVE_SET_ECC 0x80000100")]
        public const uint TAPE_DRIVE_SET_ECC = 0x80000100;

        [NativeTypeName("#define TAPE_DRIVE_SET_COMPRESSION 0x80000200")]
        public const uint TAPE_DRIVE_SET_COMPRESSION = 0x80000200;

        [NativeTypeName("#define TAPE_DRIVE_SET_PADDING 0x80000400")]
        public const uint TAPE_DRIVE_SET_PADDING = 0x80000400;

        [NativeTypeName("#define TAPE_DRIVE_SET_REPORT_SMKS 0x80000800")]
        public const uint TAPE_DRIVE_SET_REPORT_SMKS = 0x80000800;

        [NativeTypeName("#define TAPE_DRIVE_ABSOLUTE_BLK 0x80001000")]
        public const uint TAPE_DRIVE_ABSOLUTE_BLK = 0x80001000;

        [NativeTypeName("#define TAPE_DRIVE_ABS_BLK_IMMED 0x80002000")]
        public const uint TAPE_DRIVE_ABS_BLK_IMMED = 0x80002000;

        [NativeTypeName("#define TAPE_DRIVE_LOGICAL_BLK 0x80004000")]
        public const uint TAPE_DRIVE_LOGICAL_BLK = 0x80004000;

        [NativeTypeName("#define TAPE_DRIVE_LOG_BLK_IMMED 0x80008000")]
        public const uint TAPE_DRIVE_LOG_BLK_IMMED = 0x80008000;

        [NativeTypeName("#define TAPE_DRIVE_END_OF_DATA 0x80010000")]
        public const uint TAPE_DRIVE_END_OF_DATA = 0x80010000;

        [NativeTypeName("#define TAPE_DRIVE_RELATIVE_BLKS 0x80020000")]
        public const uint TAPE_DRIVE_RELATIVE_BLKS = 0x80020000;

        [NativeTypeName("#define TAPE_DRIVE_FILEMARKS 0x80040000")]
        public const uint TAPE_DRIVE_FILEMARKS = 0x80040000;

        [NativeTypeName("#define TAPE_DRIVE_SEQUENTIAL_FMKS 0x80080000")]
        public const uint TAPE_DRIVE_SEQUENTIAL_FMKS = 0x80080000;

        [NativeTypeName("#define TAPE_DRIVE_SETMARKS 0x80100000")]
        public const uint TAPE_DRIVE_SETMARKS = 0x80100000;

        [NativeTypeName("#define TAPE_DRIVE_SEQUENTIAL_SMKS 0x80200000")]
        public const uint TAPE_DRIVE_SEQUENTIAL_SMKS = 0x80200000;

        [NativeTypeName("#define TAPE_DRIVE_REVERSE_POSITION 0x80400000")]
        public const uint TAPE_DRIVE_REVERSE_POSITION = 0x80400000;

        [NativeTypeName("#define TAPE_DRIVE_SPACE_IMMEDIATE 0x80800000")]
        public const uint TAPE_DRIVE_SPACE_IMMEDIATE = 0x80800000;

        [NativeTypeName("#define TAPE_DRIVE_WRITE_SETMARKS 0x81000000")]
        public const uint TAPE_DRIVE_WRITE_SETMARKS = 0x81000000;

        [NativeTypeName("#define TAPE_DRIVE_WRITE_FILEMARKS 0x82000000")]
        public const uint TAPE_DRIVE_WRITE_FILEMARKS = 0x82000000;

        [NativeTypeName("#define TAPE_DRIVE_WRITE_SHORT_FMKS 0x84000000")]
        public const uint TAPE_DRIVE_WRITE_SHORT_FMKS = 0x84000000;

        [NativeTypeName("#define TAPE_DRIVE_WRITE_LONG_FMKS 0x88000000")]
        public const uint TAPE_DRIVE_WRITE_LONG_FMKS = 0x88000000;

        [NativeTypeName("#define TAPE_DRIVE_WRITE_MARK_IMMED 0x90000000")]
        public const uint TAPE_DRIVE_WRITE_MARK_IMMED = 0x90000000;

        [NativeTypeName("#define TAPE_DRIVE_FORMAT 0xA0000000")]
        public const uint TAPE_DRIVE_FORMAT = 0xA0000000;

        [NativeTypeName("#define TAPE_DRIVE_FORMAT_IMMEDIATE 0xC0000000")]
        public const uint TAPE_DRIVE_FORMAT_IMMEDIATE = 0xC0000000;

        [NativeTypeName("#define TAPE_DRIVE_HIGH_FEATURES 0x80000000")]
        public const uint TAPE_DRIVE_HIGH_FEATURES = 0x80000000;

        [NativeTypeName("#define TAPE_FIXED_PARTITIONS 0L")]
        public const int TAPE_FIXED_PARTITIONS = 0;

        [NativeTypeName("#define TAPE_SELECT_PARTITIONS 1L")]
        public const int TAPE_SELECT_PARTITIONS = 1;

        [NativeTypeName("#define TAPE_INITIATOR_PARTITIONS 2L")]
        public const int TAPE_INITIATOR_PARTITIONS = 2;

        [NativeTypeName("#define TAPE_QUERY_DRIVE_PARAMETERS 0L")]
        public const int TAPE_QUERY_DRIVE_PARAMETERS = 0;

        [NativeTypeName("#define TAPE_QUERY_MEDIA_CAPACITY 1L")]
        public const int TAPE_QUERY_MEDIA_CAPACITY = 1;

        [NativeTypeName("#define TAPE_CHECK_FOR_DRIVE_PROBLEM 2L")]
        public const int TAPE_CHECK_FOR_DRIVE_PROBLEM = 2;

        [NativeTypeName("#define TAPE_QUERY_IO_ERROR_DATA 3L")]
        public const int TAPE_QUERY_IO_ERROR_DATA = 3;

        [NativeTypeName("#define TAPE_QUERY_DEVICE_ERROR_DATA 4L")]
        public const int TAPE_QUERY_DEVICE_ERROR_DATA = 4;

        [NativeTypeName("#define TRANSACTIONMANAGER_QUERY_INFORMATION ( 0x0001 )")]
        public const int TRANSACTIONMANAGER_QUERY_INFORMATION = (0x0001);

        [NativeTypeName("#define TRANSACTIONMANAGER_SET_INFORMATION ( 0x0002 )")]
        public const int TRANSACTIONMANAGER_SET_INFORMATION = (0x0002);

        [NativeTypeName("#define TRANSACTIONMANAGER_RECOVER ( 0x0004 )")]
        public const int TRANSACTIONMANAGER_RECOVER = (0x0004);

        [NativeTypeName("#define TRANSACTIONMANAGER_RENAME ( 0x0008 )")]
        public const int TRANSACTIONMANAGER_RENAME = (0x0008);

        [NativeTypeName("#define TRANSACTIONMANAGER_CREATE_RM ( 0x0010 )")]
        public const int TRANSACTIONMANAGER_CREATE_RM = (0x0010);

        [NativeTypeName("#define TRANSACTIONMANAGER_BIND_TRANSACTION ( 0x0020 )")]
        public const int TRANSACTIONMANAGER_BIND_TRANSACTION = (0x0020);

        [NativeTypeName("#define TRANSACTIONMANAGER_GENERIC_READ (STANDARD_RIGHTS_READ            |\\\r\n                                                    TRANSACTIONMANAGER_QUERY_INFORMATION)")]
        public const int TRANSACTIONMANAGER_GENERIC_READ = (((0x00020000)) | (0x0001));

        [NativeTypeName("#define TRANSACTIONMANAGER_GENERIC_WRITE (STANDARD_RIGHTS_WRITE           |\\\r\n                                                    TRANSACTIONMANAGER_SET_INFORMATION     |\\\r\n                                                    TRANSACTIONMANAGER_RECOVER             |\\\r\n                                                    TRANSACTIONMANAGER_RENAME              |\\\r\n                                                    TRANSACTIONMANAGER_CREATE_RM)")]
        public const int TRANSACTIONMANAGER_GENERIC_WRITE = (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010));

        [NativeTypeName("#define TRANSACTIONMANAGER_GENERIC_EXECUTE (STANDARD_RIGHTS_EXECUTE)")]
        public const int TRANSACTIONMANAGER_GENERIC_EXECUTE = (((0x00020000)));

        [NativeTypeName("#define TRANSACTIONMANAGER_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED        |\\\r\n                                                    TRANSACTIONMANAGER_GENERIC_READ        |\\\r\n                                                    TRANSACTIONMANAGER_GENERIC_WRITE       |\\\r\n                                                    TRANSACTIONMANAGER_GENERIC_EXECUTE     |\\\r\n                                                    TRANSACTIONMANAGER_BIND_TRANSACTION)")]
        public const int TRANSACTIONMANAGER_ALL_ACCESS = ((0x000F0000) | (((0x00020000)) | (0x0001)) | (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010)) | (((0x00020000))) | (0x0020));

        [NativeTypeName("#define TRANSACTION_QUERY_INFORMATION ( 0x0001 )")]
        public const int TRANSACTION_QUERY_INFORMATION = (0x0001);

        [NativeTypeName("#define TRANSACTION_SET_INFORMATION ( 0x0002 )")]
        public const int TRANSACTION_SET_INFORMATION = (0x0002);

        [NativeTypeName("#define TRANSACTION_ENLIST ( 0x0004 )")]
        public const int TRANSACTION_ENLIST = (0x0004);

        [NativeTypeName("#define TRANSACTION_COMMIT ( 0x0008 )")]
        public const int TRANSACTION_COMMIT = (0x0008);

        [NativeTypeName("#define TRANSACTION_ROLLBACK ( 0x0010 )")]
        public const int TRANSACTION_ROLLBACK = (0x0010);

        [NativeTypeName("#define TRANSACTION_PROPAGATE ( 0x0020 )")]
        public const int TRANSACTION_PROPAGATE = (0x0020);

        [NativeTypeName("#define TRANSACTION_RIGHT_RESERVED1 ( 0x0040 )")]
        public const int TRANSACTION_RIGHT_RESERVED1 = (0x0040);

        [NativeTypeName("#define TRANSACTION_GENERIC_READ (STANDARD_RIGHTS_READ            |\\\r\n                                             TRANSACTION_QUERY_INFORMATION   |\\\r\n                                             SYNCHRONIZE)")]
        public const int TRANSACTION_GENERIC_READ = (((0x00020000)) | (0x0001) | (0x00100000));

        [NativeTypeName("#define TRANSACTION_GENERIC_WRITE (STANDARD_RIGHTS_WRITE           |\\\r\n                                             TRANSACTION_SET_INFORMATION     |\\\r\n                                             TRANSACTION_COMMIT              |\\\r\n                                             TRANSACTION_ENLIST              |\\\r\n                                             TRANSACTION_ROLLBACK            |\\\r\n                                             TRANSACTION_PROPAGATE           |\\\r\n                                             SYNCHRONIZE)")]
        public const int TRANSACTION_GENERIC_WRITE = (((0x00020000)) | (0x0002) | (0x0008) | (0x0004) | (0x0010) | (0x0020) | (0x00100000));

        [NativeTypeName("#define TRANSACTION_GENERIC_EXECUTE (STANDARD_RIGHTS_EXECUTE         |\\\r\n                                             TRANSACTION_COMMIT              |\\\r\n                                             TRANSACTION_ROLLBACK            |\\\r\n                                             SYNCHRONIZE)")]
        public const int TRANSACTION_GENERIC_EXECUTE = (((0x00020000)) | (0x0008) | (0x0010) | (0x00100000));

        [NativeTypeName("#define TRANSACTION_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED        |\\\r\n                                             TRANSACTION_GENERIC_READ        |\\\r\n                                             TRANSACTION_GENERIC_WRITE       |\\\r\n                                             TRANSACTION_GENERIC_EXECUTE)")]
        public const int TRANSACTION_ALL_ACCESS = ((0x000F0000) | (((0x00020000)) | (0x0001) | (0x00100000)) | (((0x00020000)) | (0x0002) | (0x0008) | (0x0004) | (0x0010) | (0x0020) | (0x00100000)) | (((0x00020000)) | (0x0008) | (0x0010) | (0x00100000)));

        [NativeTypeName("#define TRANSACTION_RESOURCE_MANAGER_RIGHTS (TRANSACTION_GENERIC_READ        |\\\r\n                                             STANDARD_RIGHTS_WRITE           |\\\r\n                                             TRANSACTION_SET_INFORMATION     |\\\r\n                                             TRANSACTION_ENLIST              |\\\r\n                                             TRANSACTION_ROLLBACK            |\\\r\n                                             TRANSACTION_PROPAGATE           |\\\r\n                                             SYNCHRONIZE)")]
        public const int TRANSACTION_RESOURCE_MANAGER_RIGHTS = ((((0x00020000)) | (0x0001) | (0x00100000)) | ((0x00020000)) | (0x0002) | (0x0004) | (0x0010) | (0x0020) | (0x00100000));

        [NativeTypeName("#define RESOURCEMANAGER_QUERY_INFORMATION ( 0x0001 )")]
        public const int RESOURCEMANAGER_QUERY_INFORMATION = (0x0001);

        [NativeTypeName("#define RESOURCEMANAGER_SET_INFORMATION ( 0x0002 )")]
        public const int RESOURCEMANAGER_SET_INFORMATION = (0x0002);

        [NativeTypeName("#define RESOURCEMANAGER_RECOVER ( 0x0004 )")]
        public const int RESOURCEMANAGER_RECOVER = (0x0004);

        [NativeTypeName("#define RESOURCEMANAGER_ENLIST ( 0x0008 )")]
        public const int RESOURCEMANAGER_ENLIST = (0x0008);

        [NativeTypeName("#define RESOURCEMANAGER_GET_NOTIFICATION ( 0x0010 )")]
        public const int RESOURCEMANAGER_GET_NOTIFICATION = (0x0010);

        [NativeTypeName("#define RESOURCEMANAGER_REGISTER_PROTOCOL ( 0x0020 )")]
        public const int RESOURCEMANAGER_REGISTER_PROTOCOL = (0x0020);

        [NativeTypeName("#define RESOURCEMANAGER_COMPLETE_PROPAGATION ( 0x0040 )")]
        public const int RESOURCEMANAGER_COMPLETE_PROPAGATION = (0x0040);

        [NativeTypeName("#define RESOURCEMANAGER_GENERIC_READ (STANDARD_RIGHTS_READ                 |\\\r\n                                             RESOURCEMANAGER_QUERY_INFORMATION    |\\\r\n                                             SYNCHRONIZE)")]
        public const int RESOURCEMANAGER_GENERIC_READ = (((0x00020000)) | (0x0001) | (0x00100000));

        [NativeTypeName("#define RESOURCEMANAGER_GENERIC_WRITE (STANDARD_RIGHTS_WRITE                |\\\r\n                                             RESOURCEMANAGER_SET_INFORMATION      |\\\r\n                                             RESOURCEMANAGER_RECOVER              |\\\r\n                                             RESOURCEMANAGER_ENLIST               |\\\r\n                                             RESOURCEMANAGER_GET_NOTIFICATION     |\\\r\n                                             RESOURCEMANAGER_REGISTER_PROTOCOL    |\\\r\n                                             RESOURCEMANAGER_COMPLETE_PROPAGATION |\\\r\n                                             SYNCHRONIZE)")]
        public const int RESOURCEMANAGER_GENERIC_WRITE = (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010) | (0x0020) | (0x0040) | (0x00100000));

        [NativeTypeName("#define RESOURCEMANAGER_GENERIC_EXECUTE (STANDARD_RIGHTS_EXECUTE              |\\\r\n                                             RESOURCEMANAGER_RECOVER              |\\\r\n                                             RESOURCEMANAGER_ENLIST               |\\\r\n                                             RESOURCEMANAGER_GET_NOTIFICATION     |\\\r\n                                             RESOURCEMANAGER_COMPLETE_PROPAGATION |\\\r\n                                             SYNCHRONIZE)")]
        public const int RESOURCEMANAGER_GENERIC_EXECUTE = (((0x00020000)) | (0x0004) | (0x0008) | (0x0010) | (0x0040) | (0x00100000));

        [NativeTypeName("#define RESOURCEMANAGER_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED             |\\\r\n                                             RESOURCEMANAGER_GENERIC_READ         |\\\r\n                                             RESOURCEMANAGER_GENERIC_WRITE        |\\\r\n                                             RESOURCEMANAGER_GENERIC_EXECUTE)")]
        public const int RESOURCEMANAGER_ALL_ACCESS = ((0x000F0000) | (((0x00020000)) | (0x0001) | (0x00100000)) | (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010) | (0x0020) | (0x0040) | (0x00100000)) | (((0x00020000)) | (0x0004) | (0x0008) | (0x0010) | (0x0040) | (0x00100000)));

        [NativeTypeName("#define ENLISTMENT_QUERY_INFORMATION ( 0x0001 )")]
        public const int ENLISTMENT_QUERY_INFORMATION = (0x0001);

        [NativeTypeName("#define ENLISTMENT_SET_INFORMATION ( 0x0002 )")]
        public const int ENLISTMENT_SET_INFORMATION = (0x0002);

        [NativeTypeName("#define ENLISTMENT_RECOVER ( 0x0004 )")]
        public const int ENLISTMENT_RECOVER = (0x0004);

        [NativeTypeName("#define ENLISTMENT_SUBORDINATE_RIGHTS ( 0x0008 )")]
        public const int ENLISTMENT_SUBORDINATE_RIGHTS = (0x0008);

        [NativeTypeName("#define ENLISTMENT_SUPERIOR_RIGHTS ( 0x0010 )")]
        public const int ENLISTMENT_SUPERIOR_RIGHTS = (0x0010);

        [NativeTypeName("#define ENLISTMENT_GENERIC_READ (STANDARD_RIGHTS_READ           |\\\r\n                                        ENLISTMENT_QUERY_INFORMATION)")]
        public const int ENLISTMENT_GENERIC_READ = (((0x00020000)) | (0x0001));

        [NativeTypeName("#define ENLISTMENT_GENERIC_WRITE (STANDARD_RIGHTS_WRITE          |\\\r\n                                        ENLISTMENT_SET_INFORMATION     |\\\r\n                                        ENLISTMENT_RECOVER             |\\\r\n                                        ENLISTMENT_SUBORDINATE_RIGHTS  |\\\r\n                                        ENLISTMENT_SUPERIOR_RIGHTS)")]
        public const int ENLISTMENT_GENERIC_WRITE = (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010));

        [NativeTypeName("#define ENLISTMENT_GENERIC_EXECUTE (STANDARD_RIGHTS_EXECUTE        |\\\r\n                                        ENLISTMENT_RECOVER             |\\\r\n                                        ENLISTMENT_SUBORDINATE_RIGHTS  |\\\r\n                                        ENLISTMENT_SUPERIOR_RIGHTS)")]
        public const int ENLISTMENT_GENERIC_EXECUTE = (((0x00020000)) | (0x0004) | (0x0008) | (0x0010));

        [NativeTypeName("#define ENLISTMENT_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED       |\\\r\n                                        ENLISTMENT_GENERIC_READ        |\\\r\n                                        ENLISTMENT_GENERIC_WRITE       |\\\r\n                                        ENLISTMENT_GENERIC_EXECUTE)")]
        public const int ENLISTMENT_ALL_ACCESS = ((0x000F0000) | (((0x00020000)) | (0x0001)) | (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010)) | (((0x00020000)) | (0x0004) | (0x0008) | (0x0010)));

        [NativeTypeName("#define PcTeb 0x18")]
        public const int PcTeb = 0x18;

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_ASSEMBLY_INFORMATION (1)")]
        public const int ACTIVATION_CONTEXT_SECTION_ASSEMBLY_INFORMATION = (1);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_DLL_REDIRECTION (2)")]
        public const int ACTIVATION_CONTEXT_SECTION_DLL_REDIRECTION = (2);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_WINDOW_CLASS_REDIRECTION (3)")]
        public const int ACTIVATION_CONTEXT_SECTION_WINDOW_CLASS_REDIRECTION = (3);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_COM_SERVER_REDIRECTION (4)")]
        public const int ACTIVATION_CONTEXT_SECTION_COM_SERVER_REDIRECTION = (4);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_COM_INTERFACE_REDIRECTION (5)")]
        public const int ACTIVATION_CONTEXT_SECTION_COM_INTERFACE_REDIRECTION = (5);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_COM_TYPE_LIBRARY_REDIRECTION (6)")]
        public const int ACTIVATION_CONTEXT_SECTION_COM_TYPE_LIBRARY_REDIRECTION = (6);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_COM_PROGID_REDIRECTION (7)")]
        public const int ACTIVATION_CONTEXT_SECTION_COM_PROGID_REDIRECTION = (7);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_GLOBAL_OBJECT_RENAME_TABLE (8)")]
        public const int ACTIVATION_CONTEXT_SECTION_GLOBAL_OBJECT_RENAME_TABLE = (8);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_CLR_SURROGATES (9)")]
        public const int ACTIVATION_CONTEXT_SECTION_CLR_SURROGATES = (9);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_APPLICATION_SETTINGS (10)")]
        public const int ACTIVATION_CONTEXT_SECTION_APPLICATION_SETTINGS = (10);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_COMPATIBILITY_INFO (11)")]
        public const int ACTIVATION_CONTEXT_SECTION_COMPATIBILITY_INFO = (11);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_WINRT_ACTIVATABLE_CLASSES (12)")]
        public const int ACTIVATION_CONTEXT_SECTION_WINRT_ACTIVATABLE_CLASSES = (12);
    }
}
