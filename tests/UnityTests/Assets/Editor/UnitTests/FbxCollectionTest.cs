﻿// ***********************************************************************
// Copyright (c) 2017 Unity Technologies. All rights reserved.
//
// Licensed under the ##LICENSENAME##.
// See LICENSE.md file in the project root for full license information.
// ***********************************************************************
using NUnit.Framework;
using System.Collections;
using FbxSdk;

namespace UnitTests
{
    public class FbxCollectionTest : Base<FbxCollection>
    {
        [Test]
        public void TestBasics() {
            // Call all the functions.
            var collection = CreateObject();
            collection.Clear();
        }
    }
}