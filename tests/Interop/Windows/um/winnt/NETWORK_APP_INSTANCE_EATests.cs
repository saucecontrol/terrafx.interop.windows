// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="NETWORK_APP_INSTANCE_EA" /> struct.</summary>
    public static unsafe class NETWORK_APP_INSTANCE_EATests
    {
        /// <summary>Validates that the <see cref="NETWORK_APP_INSTANCE_EA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<NETWORK_APP_INSTANCE_EA>(), Is.EqualTo(sizeof(NETWORK_APP_INSTANCE_EA)));
        }

        /// <summary>Validates that the <see cref="NETWORK_APP_INSTANCE_EA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(NETWORK_APP_INSTANCE_EA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="NETWORK_APP_INSTANCE_EA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(NETWORK_APP_INSTANCE_EA), Is.EqualTo(20));
        }
    }
}
