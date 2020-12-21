// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct TRUECOLORINFO
    {
        [NativeTypeName("DWORD [3]")]
        public fixed uint dwBitMasks[3];

        [NativeTypeName("RGBQUAD [256]")]
        public _bmiColors_e__FixedBuffer bmiColors;

        public partial struct _bmiColors_e__FixedBuffer
        {
            public RGBQUAD e0;
            public RGBQUAD e1;
            public RGBQUAD e2;
            public RGBQUAD e3;
            public RGBQUAD e4;
            public RGBQUAD e5;
            public RGBQUAD e6;
            public RGBQUAD e7;
            public RGBQUAD e8;
            public RGBQUAD e9;
            public RGBQUAD e10;
            public RGBQUAD e11;
            public RGBQUAD e12;
            public RGBQUAD e13;
            public RGBQUAD e14;
            public RGBQUAD e15;
            public RGBQUAD e16;
            public RGBQUAD e17;
            public RGBQUAD e18;
            public RGBQUAD e19;
            public RGBQUAD e20;
            public RGBQUAD e21;
            public RGBQUAD e22;
            public RGBQUAD e23;
            public RGBQUAD e24;
            public RGBQUAD e25;
            public RGBQUAD e26;
            public RGBQUAD e27;
            public RGBQUAD e28;
            public RGBQUAD e29;
            public RGBQUAD e30;
            public RGBQUAD e31;
            public RGBQUAD e32;
            public RGBQUAD e33;
            public RGBQUAD e34;
            public RGBQUAD e35;
            public RGBQUAD e36;
            public RGBQUAD e37;
            public RGBQUAD e38;
            public RGBQUAD e39;
            public RGBQUAD e40;
            public RGBQUAD e41;
            public RGBQUAD e42;
            public RGBQUAD e43;
            public RGBQUAD e44;
            public RGBQUAD e45;
            public RGBQUAD e46;
            public RGBQUAD e47;
            public RGBQUAD e48;
            public RGBQUAD e49;
            public RGBQUAD e50;
            public RGBQUAD e51;
            public RGBQUAD e52;
            public RGBQUAD e53;
            public RGBQUAD e54;
            public RGBQUAD e55;
            public RGBQUAD e56;
            public RGBQUAD e57;
            public RGBQUAD e58;
            public RGBQUAD e59;
            public RGBQUAD e60;
            public RGBQUAD e61;
            public RGBQUAD e62;
            public RGBQUAD e63;
            public RGBQUAD e64;
            public RGBQUAD e65;
            public RGBQUAD e66;
            public RGBQUAD e67;
            public RGBQUAD e68;
            public RGBQUAD e69;
            public RGBQUAD e70;
            public RGBQUAD e71;
            public RGBQUAD e72;
            public RGBQUAD e73;
            public RGBQUAD e74;
            public RGBQUAD e75;
            public RGBQUAD e76;
            public RGBQUAD e77;
            public RGBQUAD e78;
            public RGBQUAD e79;
            public RGBQUAD e80;
            public RGBQUAD e81;
            public RGBQUAD e82;
            public RGBQUAD e83;
            public RGBQUAD e84;
            public RGBQUAD e85;
            public RGBQUAD e86;
            public RGBQUAD e87;
            public RGBQUAD e88;
            public RGBQUAD e89;
            public RGBQUAD e90;
            public RGBQUAD e91;
            public RGBQUAD e92;
            public RGBQUAD e93;
            public RGBQUAD e94;
            public RGBQUAD e95;
            public RGBQUAD e96;
            public RGBQUAD e97;
            public RGBQUAD e98;
            public RGBQUAD e99;
            public RGBQUAD e100;
            public RGBQUAD e101;
            public RGBQUAD e102;
            public RGBQUAD e103;
            public RGBQUAD e104;
            public RGBQUAD e105;
            public RGBQUAD e106;
            public RGBQUAD e107;
            public RGBQUAD e108;
            public RGBQUAD e109;
            public RGBQUAD e110;
            public RGBQUAD e111;
            public RGBQUAD e112;
            public RGBQUAD e113;
            public RGBQUAD e114;
            public RGBQUAD e115;
            public RGBQUAD e116;
            public RGBQUAD e117;
            public RGBQUAD e118;
            public RGBQUAD e119;
            public RGBQUAD e120;
            public RGBQUAD e121;
            public RGBQUAD e122;
            public RGBQUAD e123;
            public RGBQUAD e124;
            public RGBQUAD e125;
            public RGBQUAD e126;
            public RGBQUAD e127;
            public RGBQUAD e128;
            public RGBQUAD e129;
            public RGBQUAD e130;
            public RGBQUAD e131;
            public RGBQUAD e132;
            public RGBQUAD e133;
            public RGBQUAD e134;
            public RGBQUAD e135;
            public RGBQUAD e136;
            public RGBQUAD e137;
            public RGBQUAD e138;
            public RGBQUAD e139;
            public RGBQUAD e140;
            public RGBQUAD e141;
            public RGBQUAD e142;
            public RGBQUAD e143;
            public RGBQUAD e144;
            public RGBQUAD e145;
            public RGBQUAD e146;
            public RGBQUAD e147;
            public RGBQUAD e148;
            public RGBQUAD e149;
            public RGBQUAD e150;
            public RGBQUAD e151;
            public RGBQUAD e152;
            public RGBQUAD e153;
            public RGBQUAD e154;
            public RGBQUAD e155;
            public RGBQUAD e156;
            public RGBQUAD e157;
            public RGBQUAD e158;
            public RGBQUAD e159;
            public RGBQUAD e160;
            public RGBQUAD e161;
            public RGBQUAD e162;
            public RGBQUAD e163;
            public RGBQUAD e164;
            public RGBQUAD e165;
            public RGBQUAD e166;
            public RGBQUAD e167;
            public RGBQUAD e168;
            public RGBQUAD e169;
            public RGBQUAD e170;
            public RGBQUAD e171;
            public RGBQUAD e172;
            public RGBQUAD e173;
            public RGBQUAD e174;
            public RGBQUAD e175;
            public RGBQUAD e176;
            public RGBQUAD e177;
            public RGBQUAD e178;
            public RGBQUAD e179;
            public RGBQUAD e180;
            public RGBQUAD e181;
            public RGBQUAD e182;
            public RGBQUAD e183;
            public RGBQUAD e184;
            public RGBQUAD e185;
            public RGBQUAD e186;
            public RGBQUAD e187;
            public RGBQUAD e188;
            public RGBQUAD e189;
            public RGBQUAD e190;
            public RGBQUAD e191;
            public RGBQUAD e192;
            public RGBQUAD e193;
            public RGBQUAD e194;
            public RGBQUAD e195;
            public RGBQUAD e196;
            public RGBQUAD e197;
            public RGBQUAD e198;
            public RGBQUAD e199;
            public RGBQUAD e200;
            public RGBQUAD e201;
            public RGBQUAD e202;
            public RGBQUAD e203;
            public RGBQUAD e204;
            public RGBQUAD e205;
            public RGBQUAD e206;
            public RGBQUAD e207;
            public RGBQUAD e208;
            public RGBQUAD e209;
            public RGBQUAD e210;
            public RGBQUAD e211;
            public RGBQUAD e212;
            public RGBQUAD e213;
            public RGBQUAD e214;
            public RGBQUAD e215;
            public RGBQUAD e216;
            public RGBQUAD e217;
            public RGBQUAD e218;
            public RGBQUAD e219;
            public RGBQUAD e220;
            public RGBQUAD e221;
            public RGBQUAD e222;
            public RGBQUAD e223;
            public RGBQUAD e224;
            public RGBQUAD e225;
            public RGBQUAD e226;
            public RGBQUAD e227;
            public RGBQUAD e228;
            public RGBQUAD e229;
            public RGBQUAD e230;
            public RGBQUAD e231;
            public RGBQUAD e232;
            public RGBQUAD e233;
            public RGBQUAD e234;
            public RGBQUAD e235;
            public RGBQUAD e236;
            public RGBQUAD e237;
            public RGBQUAD e238;
            public RGBQUAD e239;
            public RGBQUAD e240;
            public RGBQUAD e241;
            public RGBQUAD e242;
            public RGBQUAD e243;
            public RGBQUAD e244;
            public RGBQUAD e245;
            public RGBQUAD e246;
            public RGBQUAD e247;
            public RGBQUAD e248;
            public RGBQUAD e249;
            public RGBQUAD e250;
            public RGBQUAD e251;
            public RGBQUAD e252;
            public RGBQUAD e253;
            public RGBQUAD e254;
            public RGBQUAD e255;

            public unsafe ref RGBQUAD this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<RGBQUAD> AsSpan()
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, 256);
#else
                return new Span<RGBQUAD>((RGBQUAD*)Unsafe.AsPointer(ref this), 256);
#endif
            }
        }
    }
}
