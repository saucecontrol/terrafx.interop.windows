// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="APP_LOCAL_DEVICE_ID" /> struct.</summary>
    public static unsafe class APP_LOCAL_DEVICE_IDTests
    {
        /// <summary>Validates that the <see cref="APP_LOCAL_DEVICE_ID" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<APP_LOCAL_DEVICE_ID>(), Is.EqualTo(sizeof(APP_LOCAL_DEVICE_ID)));
        }

        /// <summary>Validates that the <see cref="APP_LOCAL_DEVICE_ID" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(APP_LOCAL_DEVICE_ID).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="APP_LOCAL_DEVICE_ID" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(APP_LOCAL_DEVICE_ID), Is.EqualTo(32));
        }
    }
}
