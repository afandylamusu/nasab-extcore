﻿// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Data.Abstractions;

namespace Manufactures.ViewModels.Manufacture
{
    public class IndexViewModelFactory
    {
        public IndexViewModel Create(IStorage storage)
        {
            return new IndexViewModel()
            {
            };
        }
    }
}